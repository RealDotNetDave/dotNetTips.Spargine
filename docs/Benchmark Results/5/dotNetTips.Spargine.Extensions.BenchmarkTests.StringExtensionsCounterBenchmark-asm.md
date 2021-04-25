## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntriesCount()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       dword ptr [rsp+3C],2C
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       lea       r9,[rsp+28]
       mov       [r9],rdx
       mov       [r9+8],r8d
       lea       rdx,[rsp+28]
       mov       r8d,2
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 115
```
```assembly
; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+50],rax
       mov       rax,262470F761F5
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M01_L12
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L13
       cmp       edi,1
       jle       short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       cmp       dword ptr [rdx+8],0
       ja        short M01_L00
       and       ebx,0FFFFFFFD
M01_L00:
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       rcx,[rsp+30]
       lea       r8,[rbp+48]
       mov       [r8],rcx
       mov       dword ptr [r8+8],80
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       [rbp+40],ecx
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp+28],xmm0
       mov       rcx,rsi
       lea       rdx,[rbp+28]
       lea       r8,[rbp+38]
       call      System.String.MakeSeparatorList(System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+40]
       mov       ecx,eax
       mov       edx,[rbp+50]
       cmp       rcx,rdx
       ja        near ptr M01_L14
       mov       r8,[rbp+48]
       test      eax,eax
       jne       near ptr M01_L07
       mov       edi,1
M01_L01:
       mov       r14,rsi
       test      bl,2
       je        short M01_L02
       test      edi,edi
       jle       short M01_L02
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L02:
       test      bl,1
       je        short M01_L03
       cmp       dword ptr [r14+8],0
       je        short M01_L05
M01_L03:
       test      edi,edi
       je        short M01_L05
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rcx,262470F761F5
       cmp       [rbp],rcx
       je        short M01_L04
       call      CORINFO_HELP_FAIL_FAST
M01_L04:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rcx,7FFB3C1F0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,2B5B5756D40
       mov       rax,[rax]
       mov       rcx,262470F761F5
       cmp       [rbp],rcx
       je        short M01_L06
       call      CORINFO_HELP_FAIL_FAST
M01_L06:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       xor       r14d,r14d
       lea       rdx,[rbp+18]
       mov       [rdx],r8
       mov       [rdx+8],eax
       lea       rdx,[rbp+8]
       mov       [rdx],rcx
       mov       [rdx+8],r14d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r15,rax
M01_L09:
       cmp       qword ptr [rbp+38],0
       je        short M01_L10
       mov       rcx,7FFB3C1F0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2B5B5756D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4F6150]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,262470F761F5
       cmp       [rbp],rcx
       je        short M01_L11
       call      CORINFO_HELP_FAIL_FAST
M01_L11:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0F4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0F4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L14:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 747
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntriesCount()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       dword ptr [rsp+3C],2C
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       lea       r9,[rsp+28]
       mov       [r9],rdx
       mov       [r9+8],r8d
       lea       rdx,[rsp+28]
       mov       r8d,2
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 115
```
```assembly
; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+50],rax
       mov       rax,3FAB1D2801B8
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M01_L12
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L13
       cmp       edi,1
       jle       short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       cmp       dword ptr [rdx+8],0
       ja        short M01_L00
       and       ebx,0FFFFFFFD
M01_L00:
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       rcx,[rsp+30]
       lea       r8,[rbp+48]
       mov       [r8],rcx
       mov       dword ptr [r8+8],80
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       [rbp+40],ecx
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp+28],xmm0
       mov       rcx,rsi
       lea       rdx,[rbp+28]
       lea       r8,[rbp+38]
       call      System.String.MakeSeparatorList(System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+40]
       mov       ecx,eax
       mov       edx,[rbp+50]
       cmp       rcx,rdx
       ja        near ptr M01_L14
       mov       r8,[rbp+48]
       test      eax,eax
       jne       near ptr M01_L07
       mov       edi,1
M01_L01:
       mov       r14,rsi
       test      bl,2
       je        short M01_L02
       test      edi,edi
       jle       short M01_L02
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L02:
       test      bl,1
       je        short M01_L03
       cmp       dword ptr [r14+8],0
       je        short M01_L05
M01_L03:
       test      edi,edi
       je        short M01_L05
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rcx,3FAB1D2801B8
       cmp       [rbp],rcx
       je        short M01_L04
       call      CORINFO_HELP_FAIL_FAST
M01_L04:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rcx,7FFB3C1F0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,22DDFEF6D40
       mov       rax,[rax]
       mov       rcx,3FAB1D2801B8
       cmp       [rbp],rcx
       je        short M01_L06
       call      CORINFO_HELP_FAIL_FAST
M01_L06:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       xor       r14d,r14d
       lea       rdx,[rbp+18]
       mov       [rdx],r8
       mov       [rdx+8],eax
       lea       rdx,[rbp+8]
       mov       [rdx],rcx
       mov       [rdx+8],r14d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r15,rax
M01_L09:
       cmp       qword ptr [rbp+38],0
       je        short M01_L10
       mov       rcx,7FFB3C1F0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,22DDFEF6D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4F60E0]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,3FAB1D2801B8
       cmp       [rbp],rcx
       je        short M01_L11
       call      CORINFO_HELP_FAIL_FAST
M01_L11:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0F4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0F4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L14:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 747
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntriesCount()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       dword ptr [rsp+3C],2C
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       lea       r9,[rsp+28]
       mov       [r9],rdx
       mov       [r9+8],r8d
       lea       rdx,[rsp+28]
       mov       r8d,2
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 115
```
```assembly
; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+50],rax
       mov       rax,0D5E5A973E891
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M01_L12
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L13
       cmp       edi,1
       jle       short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       cmp       dword ptr [rdx+8],0
       ja        short M01_L00
       and       ebx,0FFFFFFFD
M01_L00:
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       rcx,[rsp+30]
       lea       r8,[rbp+48]
       mov       [r8],rcx
       mov       dword ptr [r8+8],80
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       [rbp+40],ecx
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp+28],xmm0
       mov       rcx,rsi
       lea       rdx,[rbp+28]
       lea       r8,[rbp+38]
       call      System.String.MakeSeparatorList(System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+40]
       mov       ecx,eax
       mov       edx,[rbp+50]
       cmp       rcx,rdx
       ja        near ptr M01_L14
       mov       r8,[rbp+48]
       test      eax,eax
       jne       near ptr M01_L07
       mov       edi,1
M01_L01:
       mov       r14,rsi
       test      bl,2
       je        short M01_L02
       test      edi,edi
       jle       short M01_L02
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L02:
       test      bl,1
       je        short M01_L03
       cmp       dword ptr [r14+8],0
       je        short M01_L05
M01_L03:
       test      edi,edi
       je        short M01_L05
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rcx,0D5E5A973E891
       cmp       [rbp],rcx
       je        short M01_L04
       call      CORINFO_HELP_FAIL_FAST
M01_L04:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rcx,7FFB3C1C0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,2191B236D40
       mov       rax,[rax]
       mov       rcx,0D5E5A973E891
       cmp       [rbp],rcx
       je        short M01_L06
       call      CORINFO_HELP_FAIL_FAST
M01_L06:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       xor       r14d,r14d
       lea       rdx,[rbp+18]
       mov       [rdx],r8
       mov       [rdx+8],eax
       lea       rdx,[rbp+8]
       mov       [rdx],rcx
       mov       [rdx+8],r14d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r15,rax
M01_L09:
       cmp       qword ptr [rbp+38],0
       je        short M01_L10
       mov       rcx,7FFB3C1C0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2191B236D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4C6418]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,0D5E5A973E891
       cmp       [rbp],rcx
       je        short M01_L11
       call      CORINFO_HELP_FAIL_FAST
M01_L11:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L14:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 747
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntriesCount()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       dword ptr [rsp+3C],2C
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       lea       r9,[rsp+28]
       mov       [r9],rdx
       mov       [r9+8],r8d
       lea       rdx,[rsp+28]
       mov       r8d,2
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 115
```
```assembly
; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+50],rax
       mov       rax,8B88DF34DCD5
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M01_L12
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L13
       cmp       edi,1
       jle       short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       cmp       dword ptr [rdx+8],0
       ja        short M01_L00
       and       ebx,0FFFFFFFD
M01_L00:
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       rcx,[rsp+30]
       lea       r8,[rbp+48]
       mov       [r8],rcx
       mov       dword ptr [r8+8],80
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       [rbp+40],ecx
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp+28],xmm0
       mov       rcx,rsi
       lea       rdx,[rbp+28]
       lea       r8,[rbp+38]
       call      System.String.MakeSeparatorList(System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+40]
       mov       ecx,eax
       mov       edx,[rbp+50]
       cmp       rcx,rdx
       ja        near ptr M01_L14
       mov       r8,[rbp+48]
       test      eax,eax
       jne       near ptr M01_L07
       mov       edi,1
M01_L01:
       mov       r14,rsi
       test      bl,2
       je        short M01_L02
       test      edi,edi
       jle       short M01_L02
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L02:
       test      bl,1
       je        short M01_L03
       cmp       dword ptr [r14+8],0
       je        short M01_L05
M01_L03:
       test      edi,edi
       je        short M01_L05
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rcx,8B88DF34DCD5
       cmp       [rbp],rcx
       je        short M01_L04
       call      CORINFO_HELP_FAIL_FAST
M01_L04:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rcx,7FFB3C1D0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,13FAEFF7158
       mov       rax,[rax]
       mov       rcx,8B88DF34DCD5
       cmp       [rbp],rcx
       je        short M01_L06
       call      CORINFO_HELP_FAIL_FAST
M01_L06:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       xor       r14d,r14d
       lea       rdx,[rbp+18]
       mov       [rdx],r8
       mov       [rdx+8],eax
       lea       rdx,[rbp+8]
       mov       [rdx],rcx
       mov       [rdx+8],r14d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r15,rax
M01_L09:
       cmp       qword ptr [rbp+38],0
       je        short M01_L10
       mov       rcx,7FFB3C1D0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,13FAEFF7160
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4D6418]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,8B88DF34DCD5
       cmp       [rbp],rcx
       je        short M01_L11
       call      CORINFO_HELP_FAIL_FAST
M01_L11:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L14:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 747
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntriesCount()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       dword ptr [rsp+3C],2C
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       lea       r9,[rsp+28]
       mov       [r9],rdx
       mov       [r9+8],r8d
       lea       rdx,[rsp+28]
       mov       r8d,2
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 115
```
```assembly
; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+50],rax
       mov       rax,0F2314F686B25
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M01_L12
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L13
       cmp       edi,1
       jle       short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       cmp       dword ptr [rdx+8],0
       ja        short M01_L00
       and       ebx,0FFFFFFFD
M01_L00:
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       rcx,[rsp+30]
       lea       r8,[rbp+48]
       mov       [r8],rcx
       mov       dword ptr [r8+8],80
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       [rbp+40],ecx
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp+28],xmm0
       mov       rcx,rsi
       lea       rdx,[rbp+28]
       lea       r8,[rbp+38]
       call      System.String.MakeSeparatorList(System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+40]
       mov       ecx,eax
       mov       edx,[rbp+50]
       cmp       rcx,rdx
       ja        near ptr M01_L14
       mov       r8,[rbp+48]
       test      eax,eax
       jne       near ptr M01_L07
       mov       edi,1
M01_L01:
       mov       r14,rsi
       test      bl,2
       je        short M01_L02
       test      edi,edi
       jle       short M01_L02
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L02:
       test      bl,1
       je        short M01_L03
       cmp       dword ptr [r14+8],0
       je        short M01_L05
M01_L03:
       test      edi,edi
       je        short M01_L05
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rcx,0F2314F686B25
       cmp       [rbp],rcx
       je        short M01_L04
       call      CORINFO_HELP_FAIL_FAST
M01_L04:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rcx,7FFB3C1E0020
       mov       edx,2F
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,258A8624D58
       mov       rax,[rax]
       mov       rcx,0F2314F686B25
       cmp       [rbp],rcx
       je        short M01_L06
       call      CORINFO_HELP_FAIL_FAST
M01_L06:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       xor       r14d,r14d
       lea       rdx,[rbp+18]
       mov       [rdx],r8
       mov       [rdx+8],eax
       lea       rdx,[rbp+8]
       mov       [rdx],rcx
       mov       [rdx+8],r14d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r15,rax
M01_L09:
       cmp       qword ptr [rbp+38],0
       je        short M01_L10
       mov       rcx,258A8624D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FFB3C4F36E0]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,0F2314F686B25
       cmp       [rbp],rcx
       je        short M01_L11
       call      CORINFO_HELP_FAIL_FAST
M01_L11:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0E4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0E4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L14:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 725
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntriesCount()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       dword ptr [rsp+3C],2C
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       lea       r9,[rsp+28]
       mov       [r9],rdx
       mov       [r9+8],r8d
       lea       rdx,[rsp+28]
       mov       r8d,2
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 115
```
```assembly
; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+50],rax
       mov       rax,0DFB2C7EFF87C
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M01_L12
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L13
       cmp       edi,1
       jle       short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       cmp       dword ptr [rdx+8],0
       ja        short M01_L00
       and       ebx,0FFFFFFFD
M01_L00:
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       rcx,[rsp+30]
       lea       r8,[rbp+48]
       mov       [r8],rcx
       mov       dword ptr [r8+8],80
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       [rbp+40],ecx
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp+28],xmm0
       mov       rcx,rsi
       lea       rdx,[rbp+28]
       lea       r8,[rbp+38]
       call      System.String.MakeSeparatorList(System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+40]
       mov       ecx,eax
       mov       edx,[rbp+50]
       cmp       rcx,rdx
       ja        near ptr M01_L14
       mov       r8,[rbp+48]
       test      eax,eax
       jne       near ptr M01_L07
       mov       edi,1
M01_L01:
       mov       r14,rsi
       test      bl,2
       je        short M01_L02
       test      edi,edi
       jle       short M01_L02
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L02:
       test      bl,1
       je        short M01_L03
       cmp       dword ptr [r14+8],0
       je        short M01_L05
M01_L03:
       test      edi,edi
       je        short M01_L05
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rcx,0DFB2C7EFF87C
       cmp       [rbp],rcx
       je        short M01_L04
       call      CORINFO_HELP_FAIL_FAST
M01_L04:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rcx,7FFB3C1C0020
       mov       edx,30
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,25AB8394D60
       mov       rax,[rax]
       mov       rcx,0DFB2C7EFF87C
       cmp       [rbp],rcx
       je        short M01_L06
       call      CORINFO_HELP_FAIL_FAST
M01_L06:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       xor       r14d,r14d
       lea       rdx,[rbp+18]
       mov       [rdx],r8
       mov       [rdx+8],eax
       lea       rdx,[rbp+8]
       mov       [rdx],rcx
       mov       [rdx+8],r14d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r15,rax
M01_L09:
       cmp       qword ptr [rbp+38],0
       je        short M01_L10
       mov       rcx,25AB8394D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FFB3C4D36E0]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,0DFB2C7EFF87C
       cmp       [rbp],rcx
       je        short M01_L11
       call      CORINFO_HELP_FAIL_FAST
M01_L11:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L14:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 725
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntriesCount()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       dword ptr [rsp+3C],2C
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       lea       r9,[rsp+28]
       mov       [r9],rdx
       mov       [r9+8],r8d
       lea       rdx,[rsp+28]
       mov       r8d,2
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 115
```
```assembly
; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+50],rax
       mov       rax,453E6E9E7F6
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M01_L12
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L13
       cmp       edi,1
       jle       short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       cmp       dword ptr [rdx+8],0
       ja        short M01_L00
       and       ebx,0FFFFFFFD
M01_L00:
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       rcx,[rsp+30]
       lea       r8,[rbp+48]
       mov       [r8],rcx
       mov       dword ptr [r8+8],80
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       [rbp+40],ecx
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp+28],xmm0
       mov       rcx,rsi
       lea       rdx,[rbp+28]
       lea       r8,[rbp+38]
       call      System.String.MakeSeparatorList(System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+40]
       mov       ecx,eax
       mov       edx,[rbp+50]
       cmp       rcx,rdx
       ja        near ptr M01_L14
       mov       r8,[rbp+48]
       test      eax,eax
       jne       near ptr M01_L07
       mov       edi,1
M01_L01:
       mov       r14,rsi
       test      bl,2
       je        short M01_L02
       test      edi,edi
       jle       short M01_L02
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L02:
       test      bl,1
       je        short M01_L03
       cmp       dword ptr [r14+8],0
       je        short M01_L05
M01_L03:
       test      edi,edi
       je        short M01_L05
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rcx,453E6E9E7F6
       cmp       [rbp],rcx
       je        short M01_L04
       call      CORINFO_HELP_FAIL_FAST
M01_L04:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rcx,7FFB3C1D0020
       mov       edx,30
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,17341EC6D58
       mov       rax,[rax]
       mov       rcx,453E6E9E7F6
       cmp       [rbp],rcx
       je        short M01_L06
       call      CORINFO_HELP_FAIL_FAST
M01_L06:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       xor       r14d,r14d
       lea       rdx,[rbp+18]
       mov       [rdx],r8
       mov       [rdx+8],eax
       lea       rdx,[rbp+8]
       mov       [rdx],rcx
       mov       [rdx+8],r14d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r15,rax
M01_L09:
       cmp       qword ptr [rbp+38],0
       je        short M01_L10
       mov       rcx,17341EC6D40
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FFB3C4E36E0]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,453E6E9E7F6
       cmp       [rbp],rcx
       je        short M01_L11
       call      CORINFO_HELP_FAIL_FAST
M01_L11:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L14:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 725
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorCount01()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       dword ptr [rsp+3C],2C
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       lea       r9,[rsp+28]
       mov       [r9],rdx
       mov       [r9+8],r8d
       lea       rdx,[rsp+28]
       mov       r8d,2
       xor       r9d,r9d
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 112
```
```assembly
; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+50],rax
       mov       rax,78FDEB82EFD
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M01_L12
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L13
       cmp       edi,1
       jle       short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       cmp       dword ptr [rdx+8],0
       ja        short M01_L00
       and       ebx,0FFFFFFFD
M01_L00:
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       rcx,[rsp+30]
       lea       r8,[rbp+48]
       mov       [r8],rcx
       mov       dword ptr [r8+8],80
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       [rbp+40],ecx
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp+28],xmm0
       mov       rcx,rsi
       lea       rdx,[rbp+28]
       lea       r8,[rbp+38]
       call      System.String.MakeSeparatorList(System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+40]
       mov       ecx,eax
       mov       edx,[rbp+50]
       cmp       rcx,rdx
       ja        near ptr M01_L14
       mov       r8,[rbp+48]
       test      eax,eax
       jne       near ptr M01_L07
       mov       edi,1
M01_L01:
       mov       r14,rsi
       test      bl,2
       je        short M01_L02
       test      edi,edi
       jle       short M01_L02
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L02:
       test      bl,1
       je        short M01_L03
       cmp       dword ptr [r14+8],0
       je        short M01_L05
M01_L03:
       test      edi,edi
       je        short M01_L05
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rcx,78FDEB82EFD
       cmp       [rbp],rcx
       je        short M01_L04
       call      CORINFO_HELP_FAIL_FAST
M01_L04:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rcx,7FFB3C1F0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,1EC16559150
       mov       rax,[rax]
       mov       rcx,78FDEB82EFD
       cmp       [rbp],rcx
       je        short M01_L06
       call      CORINFO_HELP_FAIL_FAST
M01_L06:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       xor       r14d,r14d
       lea       rdx,[rbp+18]
       mov       [rdx],r8
       mov       [rdx+8],eax
       lea       rdx,[rbp+8]
       mov       [rdx],rcx
       mov       [rdx+8],r14d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r15,rax
M01_L09:
       cmp       qword ptr [rbp+38],0
       je        short M01_L10
       mov       rcx,7FFB3C1F0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1EC16559158
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4F58A0]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,78FDEB82EFD
       cmp       [rbp],rcx
       je        short M01_L11
       call      CORINFO_HELP_FAIL_FAST
M01_L11:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0F4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0F4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L14:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 747
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorCount01()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       dword ptr [rsp+3C],2C
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       lea       r9,[rsp+28]
       mov       [r9],rdx
       mov       [r9+8],r8d
       lea       rdx,[rsp+28]
       mov       r8d,2
       xor       r9d,r9d
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 112
```
```assembly
; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+50],rax
       mov       rax,1EB5DED74AD2
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M01_L12
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L13
       cmp       edi,1
       jle       short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       cmp       dword ptr [rdx+8],0
       ja        short M01_L00
       and       ebx,0FFFFFFFD
M01_L00:
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       rcx,[rsp+30]
       lea       r8,[rbp+48]
       mov       [r8],rcx
       mov       dword ptr [r8+8],80
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       [rbp+40],ecx
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp+28],xmm0
       mov       rcx,rsi
       lea       rdx,[rbp+28]
       lea       r8,[rbp+38]
       call      System.String.MakeSeparatorList(System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+40]
       mov       ecx,eax
       mov       edx,[rbp+50]
       cmp       rcx,rdx
       ja        near ptr M01_L14
       mov       r8,[rbp+48]
       test      eax,eax
       jne       near ptr M01_L07
       mov       edi,1
M01_L01:
       mov       r14,rsi
       test      bl,2
       je        short M01_L02
       test      edi,edi
       jle       short M01_L02
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L02:
       test      bl,1
       je        short M01_L03
       cmp       dword ptr [r14+8],0
       je        short M01_L05
M01_L03:
       test      edi,edi
       je        short M01_L05
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rcx,1EB5DED74AD2
       cmp       [rbp],rcx
       je        short M01_L04
       call      CORINFO_HELP_FAIL_FAST
M01_L04:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rcx,7FFB3C1C0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,1DF1D067158
       mov       rax,[rax]
       mov       rcx,1EB5DED74AD2
       cmp       [rbp],rcx
       je        short M01_L06
       call      CORINFO_HELP_FAIL_FAST
M01_L06:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       xor       r14d,r14d
       lea       rdx,[rbp+18]
       mov       [rdx],r8
       mov       [rdx+8],eax
       lea       rdx,[rbp+8]
       mov       [rdx],rcx
       mov       [rdx+8],r14d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r15,rax
M01_L09:
       cmp       qword ptr [rbp+38],0
       je        short M01_L10
       mov       rcx,7FFB3C1C0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1DF1D067160
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4C5830]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,1EB5DED74AD2
       cmp       [rbp],rcx
       je        short M01_L11
       call      CORINFO_HELP_FAIL_FAST
M01_L11:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L14:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 747
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorCount01()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       dword ptr [rsp+3C],2C
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       lea       r9,[rsp+28]
       mov       [r9],rdx
       mov       [r9+8],r8d
       lea       rdx,[rsp+28]
       mov       r8d,2
       xor       r9d,r9d
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 112
```
```assembly
; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+50],rax
       mov       rax,4D7297F7AB4F
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M01_L12
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L13
       cmp       edi,1
       jle       short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       cmp       dword ptr [rdx+8],0
       ja        short M01_L00
       and       ebx,0FFFFFFFD
M01_L00:
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       rcx,[rsp+30]
       lea       r8,[rbp+48]
       mov       [r8],rcx
       mov       dword ptr [r8+8],80
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       [rbp+40],ecx
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp+28],xmm0
       mov       rcx,rsi
       lea       rdx,[rbp+28]
       lea       r8,[rbp+38]
       call      System.String.MakeSeparatorList(System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+40]
       mov       ecx,eax
       mov       edx,[rbp+50]
       cmp       rcx,rdx
       ja        near ptr M01_L14
       mov       r8,[rbp+48]
       test      eax,eax
       jne       near ptr M01_L07
       mov       edi,1
M01_L01:
       mov       r14,rsi
       test      bl,2
       je        short M01_L02
       test      edi,edi
       jle       short M01_L02
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L02:
       test      bl,1
       je        short M01_L03
       cmp       dword ptr [r14+8],0
       je        short M01_L05
M01_L03:
       test      edi,edi
       je        short M01_L05
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rcx,4D7297F7AB4F
       cmp       [rbp],rcx
       je        short M01_L04
       call      CORINFO_HELP_FAIL_FAST
M01_L04:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rcx,7FFB3C1E0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,140E2834D48
       mov       rax,[rax]
       mov       rcx,4D7297F7AB4F
       cmp       [rbp],rcx
       je        short M01_L06
       call      CORINFO_HELP_FAIL_FAST
M01_L06:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       xor       r14d,r14d
       lea       rdx,[rbp+18]
       mov       [rdx],r8
       mov       [rdx+8],eax
       lea       rdx,[rbp+8]
       mov       [rdx],rcx
       mov       [rdx+8],r14d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r15,rax
M01_L09:
       cmp       qword ptr [rbp+38],0
       je        short M01_L10
       mov       rcx,7FFB3C1E0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,140E2834D50
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4E5830]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,4D7297F7AB4F
       cmp       [rbp],rcx
       je        short M01_L11
       call      CORINFO_HELP_FAIL_FAST
M01_L11:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0E4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0E4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L14:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 747
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorCount01()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       dword ptr [rsp+3C],2C
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       lea       r9,[rsp+28]
       mov       [r9],rdx
       mov       [r9+8],r8d
       lea       rdx,[rsp+28]
       mov       r8d,2
       xor       r9d,r9d
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 112
```
```assembly
; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+50],rax
       mov       rax,865FC70A2811
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M01_L12
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L13
       cmp       edi,1
       jle       short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       cmp       dword ptr [rdx+8],0
       ja        short M01_L00
       and       ebx,0FFFFFFFD
M01_L00:
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       rcx,[rsp+30]
       lea       r8,[rbp+48]
       mov       [r8],rcx
       mov       dword ptr [r8+8],80
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       [rbp+40],ecx
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp+28],xmm0
       mov       rcx,rsi
       lea       rdx,[rbp+28]
       lea       r8,[rbp+38]
       call      System.String.MakeSeparatorList(System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+40]
       mov       ecx,eax
       mov       edx,[rbp+50]
       cmp       rcx,rdx
       ja        near ptr M01_L14
       mov       r8,[rbp+48]
       test      eax,eax
       jne       near ptr M01_L07
       mov       edi,1
M01_L01:
       mov       r14,rsi
       test      bl,2
       je        short M01_L02
       test      edi,edi
       jle       short M01_L02
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L02:
       test      bl,1
       je        short M01_L03
       cmp       dword ptr [r14+8],0
       je        short M01_L05
M01_L03:
       test      edi,edi
       je        short M01_L05
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rcx,865FC70A2811
       cmp       [rbp],rcx
       je        short M01_L04
       call      CORINFO_HELP_FAIL_FAST
M01_L04:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rcx,7FFB3C1F0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,2CF8DBD6D40
       mov       rax,[rax]
       mov       rcx,865FC70A2811
       cmp       [rbp],rcx
       je        short M01_L06
       call      CORINFO_HELP_FAIL_FAST
M01_L06:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       xor       r14d,r14d
       lea       rdx,[rbp+18]
       mov       [rdx],r8
       mov       [rdx+8],eax
       lea       rdx,[rbp+8]
       mov       [rdx],rcx
       mov       [rdx+8],r14d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r15,rax
M01_L09:
       cmp       qword ptr [rbp+38],0
       je        short M01_L10
       mov       rcx,7FFB3C1F0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2CF8DBD6D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4F5B68]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,865FC70A2811
       cmp       [rbp],rcx
       je        short M01_L11
       call      CORINFO_HELP_FAIL_FAST
M01_L11:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0F4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0F4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L14:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 747
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorCount01()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       dword ptr [rsp+3C],2C
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       lea       r9,[rsp+28]
       mov       [r9],rdx
       mov       [r9+8],r8d
       lea       rdx,[rsp+28]
       mov       r8d,2
       xor       r9d,r9d
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 112
```
```assembly
; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+50],rax
       mov       rax,473922AF8360
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M01_L12
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L13
       cmp       edi,1
       jle       short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       cmp       dword ptr [rdx+8],0
       ja        short M01_L00
       and       ebx,0FFFFFFFD
M01_L00:
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       rcx,[rsp+30]
       lea       r8,[rbp+48]
       mov       [r8],rcx
       mov       dword ptr [r8+8],80
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       [rbp+40],ecx
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp+28],xmm0
       mov       rcx,rsi
       lea       rdx,[rbp+28]
       lea       r8,[rbp+38]
       call      System.String.MakeSeparatorList(System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+40]
       mov       ecx,eax
       mov       edx,[rbp+50]
       cmp       rcx,rdx
       ja        near ptr M01_L14
       mov       r8,[rbp+48]
       test      eax,eax
       jne       near ptr M01_L07
       mov       edi,1
M01_L01:
       mov       r14,rsi
       test      bl,2
       je        short M01_L02
       test      edi,edi
       jle       short M01_L02
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L02:
       test      bl,1
       je        short M01_L03
       cmp       dword ptr [r14+8],0
       je        short M01_L05
M01_L03:
       test      edi,edi
       je        short M01_L05
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rcx,473922AF8360
       cmp       [rbp],rcx
       je        short M01_L04
       call      CORINFO_HELP_FAIL_FAST
M01_L04:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rcx,7FFB3C1D0020
       mov       edx,2F
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,17B0DA04D58
       mov       rax,[rax]
       mov       rcx,473922AF8360
       cmp       [rbp],rcx
       je        short M01_L06
       call      CORINFO_HELP_FAIL_FAST
M01_L06:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       xor       r14d,r14d
       lea       rdx,[rbp+18]
       mov       [rdx],r8
       mov       [rdx+8],eax
       lea       rdx,[rbp+8]
       mov       [rdx],rcx
       mov       [rdx+8],r14d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r15,rax
M01_L09:
       cmp       qword ptr [rbp+38],0
       je        short M01_L10
       mov       rcx,17B0DA04D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FFB3C4E36E0]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,473922AF8360
       cmp       [rbp],rcx
       je        short M01_L11
       call      CORINFO_HELP_FAIL_FAST
M01_L11:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L14:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 725
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorCount01()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       dword ptr [rsp+3C],2C
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       lea       r9,[rsp+28]
       mov       [r9],rdx
       mov       [r9+8],r8d
       lea       rdx,[rsp+28]
       mov       r8d,2
       xor       r9d,r9d
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 112
```
```assembly
; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+50],rax
       mov       rax,91013738F46E
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M01_L12
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L13
       cmp       edi,1
       jle       short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       cmp       dword ptr [rdx+8],0
       ja        short M01_L00
       and       ebx,0FFFFFFFD
M01_L00:
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       rcx,[rsp+30]
       lea       r8,[rbp+48]
       mov       [r8],rcx
       mov       dword ptr [r8+8],80
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       [rbp+40],ecx
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp+28],xmm0
       mov       rcx,rsi
       lea       rdx,[rbp+28]
       lea       r8,[rbp+38]
       call      System.String.MakeSeparatorList(System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+40]
       mov       ecx,eax
       mov       edx,[rbp+50]
       cmp       rcx,rdx
       ja        near ptr M01_L14
       mov       r8,[rbp+48]
       test      eax,eax
       jne       near ptr M01_L07
       mov       edi,1
M01_L01:
       mov       r14,rsi
       test      bl,2
       je        short M01_L02
       test      edi,edi
       jle       short M01_L02
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L02:
       test      bl,1
       je        short M01_L03
       cmp       dword ptr [r14+8],0
       je        short M01_L05
M01_L03:
       test      edi,edi
       je        short M01_L05
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rcx,91013738F46E
       cmp       [rbp],rcx
       je        short M01_L04
       call      CORINFO_HELP_FAIL_FAST
M01_L04:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rcx,7FFB3C1C0020
       mov       edx,30
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,147BF1E9168
       mov       rax,[rax]
       mov       rcx,91013738F46E
       cmp       [rbp],rcx
       je        short M01_L06
       call      CORINFO_HELP_FAIL_FAST
M01_L06:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       xor       r14d,r14d
       lea       rdx,[rbp+18]
       mov       [rdx],r8
       mov       [rdx+8],eax
       lea       rdx,[rbp+8]
       mov       [rdx],rcx
       mov       [rdx+8],r14d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r15,rax
M01_L09:
       cmp       qword ptr [rbp+38],0
       je        short M01_L10
       mov       rcx,147BF1E9150
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FFB3C4D33A8]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,91013738F46E
       cmp       [rbp],rcx
       je        short M01_L11
       call      CORINFO_HELP_FAIL_FAST
M01_L11:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L14:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 725
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorCount01()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       dword ptr [rsp+3C],2C
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       lea       r9,[rsp+28]
       mov       [r9],rdx
       mov       [r9+8],r8d
       lea       rdx,[rsp+28]
       mov       r8d,2
       xor       r9d,r9d
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 112
```
```assembly
; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+50],rax
       mov       rax,861A4E83554A
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M01_L12
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L13
       cmp       edi,1
       jle       short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       cmp       dword ptr [rdx+8],0
       ja        short M01_L00
       and       ebx,0FFFFFFFD
M01_L00:
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       rcx,[rsp+30]
       lea       r8,[rbp+48]
       mov       [r8],rcx
       mov       dword ptr [r8+8],80
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       [rbp+40],ecx
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp+28],xmm0
       mov       rcx,rsi
       lea       rdx,[rbp+28]
       lea       r8,[rbp+38]
       call      System.String.MakeSeparatorList(System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+40]
       mov       ecx,eax
       mov       edx,[rbp+50]
       cmp       rcx,rdx
       ja        near ptr M01_L14
       mov       r8,[rbp+48]
       test      eax,eax
       jne       near ptr M01_L07
       mov       edi,1
M01_L01:
       mov       r14,rsi
       test      bl,2
       je        short M01_L02
       test      edi,edi
       jle       short M01_L02
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L02:
       test      bl,1
       je        short M01_L03
       cmp       dword ptr [r14+8],0
       je        short M01_L05
M01_L03:
       test      edi,edi
       je        short M01_L05
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rcx,861A4E83554A
       cmp       [rbp],rcx
       je        short M01_L04
       call      CORINFO_HELP_FAIL_FAST
M01_L04:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rcx,7FFB3C1F0020
       mov       edx,30
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,21253F16D58
       mov       rax,[rax]
       mov       rcx,861A4E83554A
       cmp       [rbp],rcx
       je        short M01_L06
       call      CORINFO_HELP_FAIL_FAST
M01_L06:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       xor       r14d,r14d
       lea       rdx,[rbp+18]
       mov       [rdx],r8
       mov       [rdx+8],eax
       lea       rdx,[rbp+8]
       mov       [rdx],rcx
       mov       [rdx+8],r14d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r15,rax
M01_L09:
       cmp       qword ptr [rbp+38],0
       je        short M01_L10
       mov       rcx,21253F16D40
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FFB3C5036E0]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,861A4E83554A
       cmp       [rbp],rcx
       je        short M01_L11
       call      CORINFO_HELP_FAIL_FAST
M01_L11:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0F4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0F4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L14:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 725
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntries()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       dword ptr [rsp+3C],2C
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       lea       r9,[rsp+28]
       mov       [r9],rdx
       mov       [r9+8],r8d
       lea       rdx,[rsp+28]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 115
```
```assembly
; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+50],rax
       mov       rax,0C2723A1CD649
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M01_L12
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L13
       cmp       edi,1
       jle       short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       cmp       dword ptr [rdx+8],0
       ja        short M01_L00
       and       ebx,0FFFFFFFD
M01_L00:
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       rcx,[rsp+30]
       lea       r8,[rbp+48]
       mov       [r8],rcx
       mov       dword ptr [r8+8],80
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       [rbp+40],ecx
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp+28],xmm0
       mov       rcx,rsi
       lea       rdx,[rbp+28]
       lea       r8,[rbp+38]
       call      System.String.MakeSeparatorList(System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+40]
       mov       ecx,eax
       mov       edx,[rbp+50]
       cmp       rcx,rdx
       ja        near ptr M01_L14
       mov       r8,[rbp+48]
       test      eax,eax
       jne       near ptr M01_L07
       mov       edi,1
M01_L01:
       mov       r14,rsi
       test      bl,2
       je        short M01_L02
       test      edi,edi
       jle       short M01_L02
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L02:
       test      bl,1
       je        short M01_L03
       cmp       dword ptr [r14+8],0
       je        short M01_L05
M01_L03:
       test      edi,edi
       je        short M01_L05
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rcx,0C2723A1CD649
       cmp       [rbp],rcx
       je        short M01_L04
       call      CORINFO_HELP_FAIL_FAST
M01_L04:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rcx,7FFB3C1E0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,1CBE3AA6D40
       mov       rax,[rax]
       mov       rcx,0C2723A1CD649
       cmp       [rbp],rcx
       je        short M01_L06
       call      CORINFO_HELP_FAIL_FAST
M01_L06:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       xor       r14d,r14d
       lea       rdx,[rbp+18]
       mov       [rdx],r8
       mov       [rdx+8],eax
       lea       rdx,[rbp+8]
       mov       [rdx],rcx
       mov       [rdx+8],r14d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r15,rax
M01_L09:
       cmp       qword ptr [rbp+38],0
       je        short M01_L10
       mov       rcx,7FFB3C1E0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1CBE3AA6D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4E60E0]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,0C2723A1CD649
       cmp       [rbp],rcx
       je        short M01_L11
       call      CORINFO_HELP_FAIL_FAST
M01_L11:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0E4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0E4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L14:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 747
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntries()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       dword ptr [rsp+3C],2C
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       lea       r9,[rsp+28]
       mov       [r9],rdx
       mov       [r9+8],r8d
       lea       rdx,[rsp+28]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 115
```
```assembly
; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+50],rax
       mov       rax,0B570CDC735BA
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M01_L12
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L13
       cmp       edi,1
       jle       short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       cmp       dword ptr [rdx+8],0
       ja        short M01_L00
       and       ebx,0FFFFFFFD
M01_L00:
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       rcx,[rsp+30]
       lea       r8,[rbp+48]
       mov       [r8],rcx
       mov       dword ptr [r8+8],80
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       [rbp+40],ecx
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp+28],xmm0
       mov       rcx,rsi
       lea       rdx,[rbp+28]
       lea       r8,[rbp+38]
       call      System.String.MakeSeparatorList(System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+40]
       mov       ecx,eax
       mov       edx,[rbp+50]
       cmp       rcx,rdx
       ja        near ptr M01_L14
       mov       r8,[rbp+48]
       test      eax,eax
       jne       near ptr M01_L07
       mov       edi,1
M01_L01:
       mov       r14,rsi
       test      bl,2
       je        short M01_L02
       test      edi,edi
       jle       short M01_L02
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L02:
       test      bl,1
       je        short M01_L03
       cmp       dword ptr [r14+8],0
       je        short M01_L05
M01_L03:
       test      edi,edi
       je        short M01_L05
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rcx,0B570CDC735BA
       cmp       [rbp],rcx
       je        short M01_L04
       call      CORINFO_HELP_FAIL_FAST
M01_L04:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rcx,7FFB3C1D0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,1DABDF56D40
       mov       rax,[rax]
       mov       rcx,0B570CDC735BA
       cmp       [rbp],rcx
       je        short M01_L06
       call      CORINFO_HELP_FAIL_FAST
M01_L06:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       xor       r14d,r14d
       lea       rdx,[rbp+18]
       mov       [rdx],r8
       mov       [rdx+8],eax
       lea       rdx,[rbp+8]
       mov       [rdx],rcx
       mov       [rdx+8],r14d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r15,rax
M01_L09:
       cmp       qword ptr [rbp+38],0
       je        short M01_L10
       mov       rcx,7FFB3C1D0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1DABDF56D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4D60E0]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,0B570CDC735BA
       cmp       [rbp],rcx
       je        short M01_L11
       call      CORINFO_HELP_FAIL_FAST
M01_L11:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L14:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 747
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntries()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       dword ptr [rsp+3C],2C
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       lea       r9,[rsp+28]
       mov       [r9],rdx
       mov       [r9+8],r8d
       lea       rdx,[rsp+28]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 115
```
```assembly
; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+50],rax
       mov       rax,38AB73DA9767
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M01_L12
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L13
       cmp       edi,1
       jle       short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       cmp       dword ptr [rdx+8],0
       ja        short M01_L00
       and       ebx,0FFFFFFFD
M01_L00:
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       rcx,[rsp+30]
       lea       r8,[rbp+48]
       mov       [r8],rcx
       mov       dword ptr [r8+8],80
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       [rbp+40],ecx
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp+28],xmm0
       mov       rcx,rsi
       lea       rdx,[rbp+28]
       lea       r8,[rbp+38]
       call      System.String.MakeSeparatorList(System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+40]
       mov       ecx,eax
       mov       edx,[rbp+50]
       cmp       rcx,rdx
       ja        near ptr M01_L14
       mov       r8,[rbp+48]
       test      eax,eax
       jne       near ptr M01_L07
       mov       edi,1
M01_L01:
       mov       r14,rsi
       test      bl,2
       je        short M01_L02
       test      edi,edi
       jle       short M01_L02
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L02:
       test      bl,1
       je        short M01_L03
       cmp       dword ptr [r14+8],0
       je        short M01_L05
M01_L03:
       test      edi,edi
       je        short M01_L05
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rcx,38AB73DA9767
       cmp       [rbp],rcx
       je        short M01_L04
       call      CORINFO_HELP_FAIL_FAST
M01_L04:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rcx,7FFB3C1C0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,21CE7014D48
       mov       rax,[rax]
       mov       rcx,38AB73DA9767
       cmp       [rbp],rcx
       je        short M01_L06
       call      CORINFO_HELP_FAIL_FAST
M01_L06:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       xor       r14d,r14d
       lea       rdx,[rbp+18]
       mov       [rdx],r8
       mov       [rdx+8],eax
       lea       rdx,[rbp+8]
       mov       [rdx],rcx
       mov       [rdx+8],r14d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r15,rax
M01_L09:
       cmp       qword ptr [rbp+38],0
       je        short M01_L10
       mov       rcx,7FFB3C1C0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,21CE7014D50
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4C6418]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,38AB73DA9767
       cmp       [rbp],rcx
       je        short M01_L11
       call      CORINFO_HELP_FAIL_FAST
M01_L11:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L14:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 747
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntries()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       dword ptr [rsp+3C],2C
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       lea       r9,[rsp+28]
       mov       [r9],rdx
       mov       [r9+8],r8d
       lea       rdx,[rsp+28]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 115
```
```assembly
; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+50],rax
       mov       rax,8CC2FB7731DD
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M01_L12
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L13
       cmp       edi,1
       jle       short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       cmp       dword ptr [rdx+8],0
       ja        short M01_L00
       and       ebx,0FFFFFFFD
M01_L00:
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       rcx,[rsp+30]
       lea       r8,[rbp+48]
       mov       [r8],rcx
       mov       dword ptr [r8+8],80
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       [rbp+40],ecx
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp+28],xmm0
       mov       rcx,rsi
       lea       rdx,[rbp+28]
       lea       r8,[rbp+38]
       call      System.String.MakeSeparatorList(System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+40]
       mov       ecx,eax
       mov       edx,[rbp+50]
       cmp       rcx,rdx
       ja        near ptr M01_L14
       mov       r8,[rbp+48]
       test      eax,eax
       jne       near ptr M01_L07
       mov       edi,1
M01_L01:
       mov       r14,rsi
       test      bl,2
       je        short M01_L02
       test      edi,edi
       jle       short M01_L02
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L02:
       test      bl,1
       je        short M01_L03
       cmp       dword ptr [r14+8],0
       je        short M01_L05
M01_L03:
       test      edi,edi
       je        short M01_L05
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rcx,8CC2FB7731DD
       cmp       [rbp],rcx
       je        short M01_L04
       call      CORINFO_HELP_FAIL_FAST
M01_L04:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rcx,7FFB3C1C0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,201C53E9150
       mov       rax,[rax]
       mov       rcx,8CC2FB7731DD
       cmp       [rbp],rcx
       je        short M01_L06
       call      CORINFO_HELP_FAIL_FAST
M01_L06:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       xor       r14d,r14d
       lea       rdx,[rbp+18]
       mov       [rdx],r8
       mov       [rdx+8],eax
       lea       rdx,[rbp+8]
       mov       [rdx],rcx
       mov       [rdx+8],r14d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r15,rax
M01_L09:
       cmp       qword ptr [rbp+38],0
       je        short M01_L10
       mov       rcx,7FFB3C1C0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,201C53E9158
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4C6418]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,8CC2FB7731DD
       cmp       [rbp],rcx
       je        short M01_L11
       call      CORINFO_HELP_FAIL_FAST
M01_L11:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L14:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 747
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntries()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       dword ptr [rsp+3C],2C
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       lea       r9,[rsp+28]
       mov       [r9],rdx
       mov       [r9+8],r8d
       lea       rdx,[rsp+28]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 115
```
```assembly
; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+50],rax
       mov       rax,36180D46C5C5
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M01_L12
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L13
       cmp       edi,1
       jle       short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       cmp       dword ptr [rdx+8],0
       ja        short M01_L00
       and       ebx,0FFFFFFFD
M01_L00:
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       rcx,[rsp+30]
       lea       r8,[rbp+48]
       mov       [r8],rcx
       mov       dword ptr [r8+8],80
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       [rbp+40],ecx
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp+28],xmm0
       mov       rcx,rsi
       lea       rdx,[rbp+28]
       lea       r8,[rbp+38]
       call      System.String.MakeSeparatorList(System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+40]
       mov       ecx,eax
       mov       edx,[rbp+50]
       cmp       rcx,rdx
       ja        near ptr M01_L14
       mov       r8,[rbp+48]
       test      eax,eax
       jne       near ptr M01_L07
       mov       edi,1
M01_L01:
       mov       r14,rsi
       test      bl,2
       je        short M01_L02
       test      edi,edi
       jle       short M01_L02
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L02:
       test      bl,1
       je        short M01_L03
       cmp       dword ptr [r14+8],0
       je        short M01_L05
M01_L03:
       test      edi,edi
       je        short M01_L05
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rcx,36180D46C5C5
       cmp       [rbp],rcx
       je        short M01_L04
       call      CORINFO_HELP_FAIL_FAST
M01_L04:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rcx,7FFB3C1F0020
       mov       edx,2F
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,1FE148E7168
       mov       rax,[rax]
       mov       rcx,36180D46C5C5
       cmp       [rbp],rcx
       je        short M01_L06
       call      CORINFO_HELP_FAIL_FAST
M01_L06:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       xor       r14d,r14d
       lea       rdx,[rbp+18]
       mov       [rdx],r8
       mov       [rdx+8],eax
       lea       rdx,[rbp+8]
       mov       [rdx],rcx
       mov       [rdx+8],r14d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r15,rax
M01_L09:
       cmp       qword ptr [rbp+38],0
       je        short M01_L10
       mov       rcx,1FE148E7158
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FFB3C5036E0]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,36180D46C5C5
       cmp       [rbp],rcx
       je        short M01_L11
       call      CORINFO_HELP_FAIL_FAST
M01_L11:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0F4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0F4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L14:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 725
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntries()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       dword ptr [rsp+3C],2C
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       lea       r9,[rsp+28]
       mov       [r9],rdx
       mov       [r9+8],r8d
       lea       rdx,[rsp+28]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 115
```
```assembly
; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+50],rax
       mov       rax,19E2812A3B4A
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M01_L12
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L13
       cmp       edi,1
       jle       short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       cmp       dword ptr [rdx+8],0
       ja        short M01_L00
       and       ebx,0FFFFFFFD
M01_L00:
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       rcx,[rsp+30]
       lea       r8,[rbp+48]
       mov       [r8],rcx
       mov       dword ptr [r8+8],80
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       [rbp+40],ecx
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp+28],xmm0
       mov       rcx,rsi
       lea       rdx,[rbp+28]
       lea       r8,[rbp+38]
       call      System.String.MakeSeparatorList(System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+40]
       mov       ecx,eax
       mov       edx,[rbp+50]
       cmp       rcx,rdx
       ja        near ptr M01_L14
       mov       r8,[rbp+48]
       test      eax,eax
       jne       near ptr M01_L07
       mov       edi,1
M01_L01:
       mov       r14,rsi
       test      bl,2
       je        short M01_L02
       test      edi,edi
       jle       short M01_L02
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L02:
       test      bl,1
       je        short M01_L03
       cmp       dword ptr [r14+8],0
       je        short M01_L05
M01_L03:
       test      edi,edi
       je        short M01_L05
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rcx,19E2812A3B4A
       cmp       [rbp],rcx
       je        short M01_L04
       call      CORINFO_HELP_FAIL_FAST
M01_L04:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rcx,7FFB3C1E0020
       mov       edx,30
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,222EE676D58
       mov       rax,[rax]
       mov       rcx,19E2812A3B4A
       cmp       [rbp],rcx
       je        short M01_L06
       call      CORINFO_HELP_FAIL_FAST
M01_L06:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       xor       r14d,r14d
       lea       rdx,[rbp+18]
       mov       [rdx],r8
       mov       [rdx+8],eax
       lea       rdx,[rbp+8]
       mov       [rdx],rcx
       mov       [rdx+8],r14d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r15,rax
M01_L09:
       cmp       qword ptr [rbp+38],0
       je        short M01_L10
       mov       rcx,222EE676D40
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FFB3C4F36E0]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,19E2812A3B4A
       cmp       [rbp],rcx
       je        short M01_L11
       call      CORINFO_HELP_FAIL_FAST
M01_L11:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0E4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0E4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L14:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 725
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntries()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       dword ptr [rsp+3C],2C
       cmp       [rcx],ecx
       lea       rdx,[rsp+3C]
       mov       r8d,1
       lea       r9,[rsp+28]
       mov       [r9],rdx
       mov       [r9+8],r8d
       lea       rdx,[rsp+28]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 115
```
```assembly
; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       [rbp+50],rax
       mov       rax,0FA6833AD936D
       mov       [rbp],rax
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M01_L12
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L13
       cmp       edi,1
       jle       short M01_L01
       cmp       dword ptr [rsi+8],0
       je        short M01_L01
       cmp       dword ptr [rdx+8],0
       ja        short M01_L00
       and       ebx,0FFFFFFFD
M01_L00:
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       rcx,[rsp+30]
       lea       r8,[rbp+48]
       mov       [r8],rcx
       mov       dword ptr [r8+8],80
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       [rbp+40],ecx
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp+28],xmm0
       mov       rcx,rsi
       lea       rdx,[rbp+28]
       lea       r8,[rbp+38]
       call      System.String.MakeSeparatorList(System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+40]
       mov       ecx,eax
       mov       edx,[rbp+50]
       cmp       rcx,rdx
       ja        near ptr M01_L14
       mov       r8,[rbp+48]
       test      eax,eax
       jne       near ptr M01_L07
       mov       edi,1
M01_L01:
       mov       r14,rsi
       test      bl,2
       je        short M01_L02
       test      edi,edi
       jle       short M01_L02
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L02:
       test      bl,1
       je        short M01_L03
       cmp       dword ptr [r14+8],0
       je        short M01_L05
M01_L03:
       test      edi,edi
       je        short M01_L05
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rcx,0FA6833AD936D
       cmp       [rbp],rcx
       je        short M01_L04
       call      CORINFO_HELP_FAIL_FAST
M01_L04:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rcx,7FFB3C1E0020
       mov       edx,30
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,1DC92999168
       mov       rax,[rax]
       mov       rcx,0FA6833AD936D
       cmp       [rbp],rcx
       je        short M01_L06
       call      CORINFO_HELP_FAIL_FAST
M01_L06:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       test      ebx,ebx
       jne       short M01_L08
       xor       ebx,ebx
       xor       r14d,r14d
       lea       rcx,[rbp+18]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+8]
       mov       [rcx],rbx
       mov       [rcx+8],r14d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r15,rax
       jmp       short M01_L09
M01_L08:
       xor       ecx,ecx
       xor       r14d,r14d
       lea       rdx,[rbp+18]
       mov       [rdx],r8
       mov       [rdx+8],eax
       lea       rdx,[rbp+8]
       mov       [rdx],rcx
       mov       [rdx+8],r14d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r15,rax
M01_L09:
       cmp       qword ptr [rbp+38],0
       je        short M01_L10
       mov       rcx,1DC92999150
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FFB3C4F36E0]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,0FA6833AD936D
       cmp       [rbp],rcx
       je        short M01_L11
       call      CORINFO_HELP_FAIL_FAST
M01_L11:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0E4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0E4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L14:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 725
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       r8,26C5FF63020
       mov       r8,[r8]
       mov       rdx,26C3FF61230
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       rcx,rax
       mov       rdx,26C4FF611E0
       mov       rdx,[rdx]
       mov       r8,26C5FF63020
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Enum, System.String, System.String)
       mov       rcx,offset MT_System.Char[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rax+10],bx
       cmp       [rsi],esi
       add       rax,10
       mov       ecx,1
       lea       rdx,[rsp+20]
       mov       [rdx],rax
       mov       [rdx+8],ecx
       mov       rcx,rsi
       lea       rdx,[rsp+20]
       mov       r9d,edi
       mov       r8d,7FFFFFFF
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 185
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       r8,28349E63020
       mov       r8,[r8]
       mov       rdx,28349E63640
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       rcx,rax
       mov       rdx,28359E611E0
       mov       rdx,[rdx]
       mov       r8,28349E63020
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Enum, System.String, System.String)
       mov       rcx,offset MT_System.Char[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rax+10],bx
       cmp       [rsi],esi
       add       rax,10
       mov       ecx,1
       lea       rdx,[rsp+20]
       mov       [rdx],rax
       mov       [rdx+8],ecx
       mov       rcx,rsi
       lea       rdx,[rsp+20]
       mov       r9d,edi
       mov       r8d,7FFFFFFF
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 185
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       r8,2AA53AB3020
       mov       r8,[r8]
       mov       rdx,2AA53AC15A8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       rcx,rax
       mov       rdx,2AA33AB11E0
       mov       rdx,[rdx]
       mov       r8,2AA53AB3020
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Enum, System.String, System.String)
       mov       rcx,offset MT_System.Char[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rax+10],bx
       cmp       [rsi],esi
       add       rax,10
       mov       ecx,1
       lea       rdx,[rsp+20]
       mov       [rdx],rax
       mov       [rdx+8],ecx
       mov       rcx,rsi
       lea       rdx,[rsp+20]
       mov       r9d,edi
       mov       r8d,7FFFFFFF
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 185
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       r8,1FE551B3020
       mov       r8,[r8]
       mov       rdx,1FE751B3228
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       rcx,rax
       mov       rdx,1FE751B39F0
       mov       rdx,[rdx]
       mov       r8,1FE551B3020
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Enum, System.String, System.String)
       mov       rcx,offset MT_System.Char[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rax+10],bx
       cmp       [rsi],esi
       add       rax,10
       mov       ecx,1
       lea       rdx,[rsp+20]
       mov       [rdx],rax
       mov       [rdx+8],ecx
       mov       rcx,rsi
       lea       rdx,[rsp+20]
       mov       r9d,edi
       mov       r8d,7FFFFFFF
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 185
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       r8,223BAF93020
       mov       r8,[r8]
       mov       rdx,223CAF9F198
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       rcx,rax
       mov       rdx,223BAF935F0
       mov       rdx,[rdx]
       mov       r8,223BAF93020
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Enum, System.String, System.String)
       mov       rcx,offset MT_System.Char[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rax+10],bx
       cmp       [rsi],esi
       add       rax,10
       mov       ecx,1
       lea       rdx,[rsp+20]
       mov       [rdx],rax
       mov       [rdx+8],ecx
       mov       rcx,rsi
       lea       rdx,[rsp+20]
       mov       r9d,edi
       mov       r8d,7FFFFFFF
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 185
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       r8,218D50D3020
       mov       r8,[r8]
       mov       rdx,218D50E15A8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       rcx,rax
       mov       rdx,218D50E1D70
       mov       rdx,[rdx]
       mov       r8,218D50D3020
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Enum, System.String, System.String)
       mov       rcx,offset MT_System.Char[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rax+10],bx
       cmp       [rsi],esi
       add       rax,10
       mov       ecx,1
       lea       rdx,[rsp+20]
       mov       [rdx],rax
       mov       [rdx+8],ecx
       mov       rcx,rsi
       lea       rdx,[rsp+20]
       mov       r9d,edi
       mov       r8d,7FFFFFFF
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 185
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       r8,1F744963020
       mov       r8,[r8]
       mov       rdx,1F744963640
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       rcx,rax
       mov       rdx,1F7549611E0
       mov       rdx,[rdx]
       mov       r8,1F744963020
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Enum, System.String, System.String)
       mov       rcx,offset MT_System.Char[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rax+10],bx
       cmp       [rsi],esi
       add       rax,10
       mov       ecx,1
       lea       rdx,[rsp+20]
       mov       [rdx],rax
       mov       [rdx+8],ecx
       mov       rcx,rsi
       lea       rdx,[rsp+20]
       mov       r9d,edi
       mov       r8d,7FFFFFFF
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 185
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntriesCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,22943613158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,22943613020
       mov       rdx,[rdx]
M00_L00:
       mov       dword ptr [rsp+20],1
       xor       r8d,r8d
       mov       r9d,2
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 103
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,0AE932BFB56EA
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1E0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,22953614D48
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,7FFB3C1E0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,22953614D50
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4E6150]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFB3C1E0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,22953614D50
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4E6150]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0AE932BFB56EA
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0E4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0E4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 975
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntriesCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,17A61F73158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,17A61F73020
       mov       rdx,[rdx]
M00_L00:
       mov       dword ptr [rsp+20],1
       xor       r8d,r8d
       mov       r9d,2
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 103
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,0CAF29B31388
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1D0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,17A81F76D40
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,7FFB3C1D0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,17A81F76D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4D6150]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFB3C1D0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,17A81F76D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4D6150]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0CAF29B31388
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 975
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntriesCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,256EA1C1160
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,256EA1C1028
       mov       rdx,[rdx]
M00_L00:
       mov       dword ptr [rsp+20],1
       xor       r8d,r8d
       mov       r9d,2
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 103
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,6A95954A1E3A
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1D0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,256EA1C7158
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,7FFB3C1D0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,256EA1C7160
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4D60E0]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFB3C1D0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,256EA1C7160
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4D60E0]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,6A95954A1E3A
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 975
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntriesCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1C4869B3158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1C4869B3020
       mov       rdx,[rdx]
M00_L00:
       mov       dword ptr [rsp+20],1
       xor       r8d,r8d
       mov       r9d,2
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 103
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,0D0A810EF5072
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1C0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1C4769B4D48
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,7FFB3C1C0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1C4769B4D50
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4C6418]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFB3C1C0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1C4769B4D50
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4C6418]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0D0A810EF5072
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 975
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntriesCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,274F1393158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,274F1393020
       mov       rdx,[rdx]
M00_L00:
       mov       dword ptr [rsp+20],1
       xor       r8d,r8d
       mov       r9d,2
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 103
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,7A5AD24856DF
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1F0020
       mov       edx,2F
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,274E1394D58
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,274E1394D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FFB3C5036E0]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,274E1394D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FFB3C5036E0]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,7A5AD24856DF
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0F4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0F4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 931
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntriesCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,2BD7CFB3158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,2BD7CFB3020
       mov       rdx,[rdx]
M00_L00:
       mov       dword ptr [rsp+20],1
       xor       r8d,r8d
       mov       r9d,2
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 103
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,0E81497E67680
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1C0020
       mov       edx,30
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2BD7CFB9168
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,2BD7CFB9150
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FFB3C4D36E0]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,2BD7CFB9150
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FFB3C4D36E0]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0E81497E67680
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 931
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntriesCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,2A6418D3158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,2A6418D3020
       mov       rdx,[rdx]
M00_L00:
       mov       dword ptr [rsp+20],1
       xor       r8d,r8d
       mov       r9d,2
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 103
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,0BBD5334712AB
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1F0020
       mov       edx,30
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2A6318D4D60
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,2A6318D4D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FFB3C503418]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,2A6318D4D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FFB3C503418]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0BBD5334712AB
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0F4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0F4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 931
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,25664A63158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,25664A63020
       mov       rdx,[rdx]
M00_L00:
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,2
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 100
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,3623526CC40B
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1C0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,25664A69150
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,7FFB3C1C0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,25664A69158
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4C5B68]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFB3C1C0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,25664A69158
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4C5B68]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,3623526CC40B
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 975
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,210B0643158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,210B0643020
       mov       rdx,[rdx]
M00_L00:
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,2
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 100
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,34446AE86AC2
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1D0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,210C0646D40
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,7FFB3C1D0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,210C0646D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4D5830]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFB3C1D0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,210C0646D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4D5830]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,34446AE86AC2
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 975
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,2EF7AC53158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,2EF7AC53020
       mov       rdx,[rdx]
M00_L00:
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,2
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 100
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,72A179515812
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1C0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2EF9AC56D40
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,7FFB3C1C0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2EF9AC56D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4C5B68]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFB3C1C0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2EF9AC56D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4C5B68]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,72A179515812
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 975
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1C1F4551160
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1C1F4551028
       mov       rdx,[rdx]
M00_L00:
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,2
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 100
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,0EBE044C9176E
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1D0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1C214556D40
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,7FFB3C1D0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1C214556D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4D5830]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFB3C1D0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1C214556D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4D5830]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0EBE044C9176E
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 975
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1A003823158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1A003823020
       mov       rdx,[rdx]
M00_L00:
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,2
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 100
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,7496DD5173DF
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1C0020
       mov       edx,2F
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1A003829160
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,1A003829150
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FFB3C4D36E0]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,1A003829150
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FFB3C4D36E0]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,7496DD5173DF
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 931
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,20E5F983158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,20E5F983020
       mov       rdx,[rdx]
M00_L00:
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,2
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 100
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,29A700CB7C5E
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1D0020
       mov       edx,30
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,20E7F986D58
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,20E7F986D40
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FFB3C4E3418]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,20E7F986D40
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FFB3C4E3418]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,29A700CB7C5E
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 931
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorCount()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1C4BF773158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1C4BF773020
       mov       rdx,[rdx]
M00_L00:
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,2
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 100
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,0B391D49808B3
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1C0020
       mov       edx,30
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1C4DF776D58
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,1C4DF776D40
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FFB3C4D36E0]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,1C4DF776D40
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FFB3C4D36E0]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0B391D49808B3
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 931
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntries()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,23D38443158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,23D38443020
       mov       rdx,[rdx]
M00_L00:
       mov       dword ptr [rsp+20],1
       xor       r8d,r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 103
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,0A573304C69D2
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1C0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,23D48446D40
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,7FFB3C1C0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,23D48446D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4C6150]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFB3C1C0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,23D48446D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4C6150]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0A573304C69D2
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 975
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntries()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,179DB783158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,179DB783020
       mov       rdx,[rdx]
M00_L00:
       mov       dword ptr [rsp+20],1
       xor       r8d,r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 103
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,72C4BCCD7DB1
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1E0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,179CB784D48
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,7FFB3C1E0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,179CB784D50
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4E6150]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFB3C1E0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,179CB784D50
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4E6150]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,72C4BCCD7DB1
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0E4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0E4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 975
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntries()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1EEB7F73158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1EEB7F73020
       mov       rdx,[rdx]
M00_L00:
       mov       dword ptr [rsp+20],1
       xor       r8d,r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 103
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,970E2F80C45D
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1D0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1EED7F76D40
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,7FFB3C1D0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1EED7F76D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4D60E0]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFB3C1D0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1EED7F76D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4D60E0]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,970E2F80C45D
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 975
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntries()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,2B2FBF13158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,2B2FBF13020
       mov       rdx,[rdx]
M00_L00:
       mov       dword ptr [rsp+20],1
       xor       r8d,r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 103
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,0CB84AF593072
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1F0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2B2FBF19150
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,7FFB3C1F0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2B2FBF19158
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4F6418]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFB3C1F0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2B2FBF19158
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4F6418]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0CB84AF593072
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0F4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0F4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 975
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntries()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,2AD06F81160
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,2AD06F81028
       mov       rdx,[rdx]
M00_L00:
       mov       dword ptr [rsp+20],1
       xor       r8d,r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 103
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,0AC9AE5721FC
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1D0020
       mov       edx,2F
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2AD26F86D50
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,2AD26F86D40
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FFB3C4E36E0]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,2AD26F86D40
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FFB3C4E36E0]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0AC9AE5721FC
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 931
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntries()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,25C8C423158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,25C8C423020
       mov       rdx,[rdx]
M00_L00:
       mov       dword ptr [rsp+20],1
       xor       r8d,r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 103
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,0EB3FB2286120
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1B0020
       mov       edx,30
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,25C8C429168
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,25C8C429150
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FFB3C4C36E0]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,25C8C429150
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FFB3C4C36E0]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0EB3FB2286120
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0B4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0B4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 931
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntries()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,22852F33158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,22852F33020
       mov       rdx,[rdx]
M00_L00:
       mov       dword ptr [rsp+20],1
       xor       r8d,r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 103
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,26997A25DAFC
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1E0020
       mov       edx,30
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,22882F34D60
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,22882F34D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FFB3C4F36E0]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,22882F34D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FFB3C4F36E0]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,26997A25DAFC
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0E4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0E4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 931
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparator()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,216DF993158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,216DF993020
       mov       rdx,[rdx]
M00_L00:
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 100
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,6D38505C545C
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1D0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,216CF994D48
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,7FFB3C1D0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,216CF994D50
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4D58A0]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFB3C1D0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,216CF994D50
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4D58A0]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,6D38505C545C
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 975
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparator()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,29143DB3158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,29143DB3020
       mov       rdx,[rdx]
M00_L00:
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 100
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,0D83D2547406A
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1D0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,29133DB4D48
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,7FFB3C1D0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,29133DB4D50
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4D5830]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFB3C1D0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,29133DB4D50
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4D5830]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0D83D2547406A
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 975
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparator()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1FDC4F03158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1FDC4F03020
       mov       rdx,[rdx]
M00_L00:
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 100
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,4F9216D71FD3
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1E0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1FDE4F06D40
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,7FFB3C1E0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1FDE4F06D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4E5B68]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFB3C1E0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1FDE4F06D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4E5B68]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,4F9216D71FD3
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0E4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0E4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 975
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparator()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,26869313158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,26869313020
       mov       rdx,[rdx]
M00_L00:
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 100
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,7FE80A623E57
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1E0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,26859314D48
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,7FFB3C1E0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,26859314D50
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4E5B68]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFB3C1E0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,26859314D50
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4E5B68]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,7FE80A623E57
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0E4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0E4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 975
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparator()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,180AA6E3158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,180AA6E3020
       mov       rdx,[rdx]
M00_L00:
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 100
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,0B44DD60E3256
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1E0020
       mov       edx,2F
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1808A6E4D58
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,1808A6E4D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FFB3C4F36E0]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,1808A6E4D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FFB3C4F36E0]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0B44DD60E3256
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0E4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0E4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 931
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparator()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1E6EEB73158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1E6EEB73020
       mov       rdx,[rdx]
M00_L00:
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 100
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,39525B11B833
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1C0020
       mov       edx,30
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1E70EB76D58
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,1E70EB76D40
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FFB3C4D36E0]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,1E70EB76D40
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FFB3C4D36E0]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,39525B11B833
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0C4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 931
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparator()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1EB35003158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1EB35003020
       mov       rdx,[rdx]
M00_L00:
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r9d,7FFFFFFF
       call      System.String.SplitInternal(System.String, System.String[], Int32, System.StringSplitOptions)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 100
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
       mov       rax,0FFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+80],xmm4
       vmovdqa   xmmword ptr [rbp+rax+90],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0A0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,0ECECB9C333C0
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       edi,r9d
       mov       ebx,[rbp+0D0]
       test      edi,edi
       jl        near ptr M01_L16
       test      ebx,0FFFFFFFC
       jne       near ptr M01_L17
       test      rdx,rdx
       setne     r14b
       movzx     r14d,r14b
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
       xor       edx,edx
       lea       r8,[rbp+30]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rbp+30]
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L02:
       cmp       edi,1
       jle       short M01_L03
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        short M01_L03
       test      r14d,r14d
       je        near ptr M01_L08
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edi,1
M01_L03:
       mov       r14,rsi
       test      bl,2
       je        short M01_L04
       test      edi,edi
       jle       short M01_L04
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r14,rax
M01_L04:
       test      bl,1
       je        short M01_L05
       cmp       dword ptr [r14+8],0
       je        short M01_L06
M01_L05:
       test      edi,edi
       je        short M01_L06
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M01_L14
M01_L06:
       mov       rcx,7FFB3C1D0020
       mov       edx,30
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1EB35009168
       mov       rax,[rcx]
       jmp       near ptr M01_L14
M01_L07:
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,ebx
       call      System.String.SplitInternal(System.String, Int32, System.StringSplitOptions)
       jmp       near ptr M01_L14
M01_L08:
       mov       [rbp+0C0],r8
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+70]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+60],r9
       mov       [rbp+68],r9d
       add       rsp,30
       test      esp,[rsp]
       sub       rsp,200
       sub       rsp,30
       lea       r9,[rsp+30]
       lea       rcx,[rbp+50]
       mov       [rcx],r9
       mov       dword ptr [rcx+8],80
       xor       r9d,r9d
       mov       [rbp+40],r9
       mov       [rbp+48],r9d
       lea       r8,[rbp+60]
       lea       r9,[rbp+40]
       mov       rcx,rsi
       mov       rdx,[rbp+0C0]
       call      System.String.MakeSeparatorList(System.String[], System.Collections.Generic.ValueListBuilder`1<Int32> ByRef, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+68]
       mov       ecx,eax
       mov       edx,[rbp+78]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r8,[rbp+70]
       mov       r9d,[rbp+48]
       mov       ecx,r9d
       mov       edx,[rbp+58]
       cmp       rcx,rdx
       ja        near ptr M01_L18
       mov       r10,[rbp+50]
       test      eax,eax
       jne       short M01_L09
       mov       rcx,offset MT_System.String[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       jmp       near ptr M01_L14
M01_L09:
       test      ebx,ebx
       jne       short M01_L10
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       r14,rax
       jmp       short M01_L11
M01_L10:
       lea       rcx,[rbp+20]
       mov       [rcx],r8
       mov       [rcx+8],eax
       lea       rcx,[rbp+10]
       mov       [rcx],r10
       mov       [rcx+8],r9d
       mov       [rsp+20],edi
       mov       [rsp+28],ebx
       mov       rcx,rsi
       lea       rdx,[rbp+20]
       lea       r8,[rbp+10]
       xor       r9d,r9d
       call      System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       r14,rax
M01_L11:
       cmp       qword ptr [rbp+60],0
       je        short M01_L12
       mov       rcx,1EB35009150
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FFB3C4E36E0]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,1EB35009150
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FFB3C4E36E0]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0ECECB9C333C0
       cmp       [rbp+8],rcx
       je        short M01_L15
       call      CORINFO_HELP_FAIL_FAST
M01_L15:
       nop
       lea       rsp,[rbp+80]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFB3C0D4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       ecx,42
       mov       edx,57
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource, System.ExceptionArgument)
       int       3
M01_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 931
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       r8,14CCBC53020
       mov       r8,[r8]
       mov       rdx,14CCBC61558
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFD8],rdi
       mov       rcx,14CCBC51AD8
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4F1248]
       mov       rdx,rax
       mov       rcx,[rbp+0FFD8]
       call      System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
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
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,14CCBC51508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,14CCBC61560
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       r14d,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       call      qword ptr [7FFB3C4F8548]
       mov       rbx,rax
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFB3C4F4120]
       mov       rax,rbx
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M01_L04
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFB3C4F4120]
M01_L04:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 364
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       r8,19E86D33020
       mov       r8,[r8]
       mov       rdx,19E86D41D70
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFD8],rdi
       mov       rcx,19E86D31AD8
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4D1248]
       mov       rdx,rax
       mov       rcx,[rbp+0FFD8]
       call      System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
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
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,19E86D31508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,19E86D41D78
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       r14d,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       call      qword ptr [7FFB3C4C8548]
       mov       rbx,rax
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFB3C4C43E8]
       mov       rax,rbx
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M01_L04
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFB3C4C43E8]
M01_L04:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 364
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       r8,250A41B3020
       mov       r8,[r8]
       mov       rdx,250B41B11E0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFD8],rdi
       mov       rcx,250A41B1AD8
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C501248]
       mov       rdx,rax
       mov       rcx,[rbp+0FFD8]
       call      System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
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
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,250A41B1508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,250B41B11E8
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       r14d,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       call      qword ptr [7FFB3C4F8548]
       mov       rbx,rax
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFB3C4F40B0]
       mov       rax,rbx
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M01_L04
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFB3C4F40B0]
M01_L04:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 364
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       r8,24C70233020
       mov       r8,[r8]
       mov       rdx,24C502319F8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFD8],rdi
       mov       rcx,24C70231AD8
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4E1248]
       mov       rdx,rax
       mov       rcx,[rbp+0FFD8]
       call      System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
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
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,24C70231508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,24C50231A00
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       r14d,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       call      qword ptr [7FFB3C4D8548]
       mov       rbx,rax
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFB3C4D4120]
       mov       rax,rbx
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M01_L04
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFB3C4D4120]
M01_L04:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 364
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       r8,1F6C7873020
       mov       r8,[r8]
       mov       rdx,1F6E78711E0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFD8],rdi
       mov       rcx,1F6C7871AD8
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4E1248]
       mov       rdx,rax
       mov       rcx,[rbp+0FFD8]
       call      System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
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
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,1F6C7871508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1F6E78711E8
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       r14d,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       call      qword ptr [7FFB3C4D8548]
       mov       rbx,rax
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFB3C4D43E8]
       mov       rax,rbx
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M01_L04
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFB3C4D43E8]
M01_L04:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 364
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       r8,198C67C3020
       mov       r8,[r8]
       mov       rdx,198C67C35F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFD8],rdi
       mov       rcx,198C67C1AD8
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4E1248]
       mov       rdx,rax
       mov       rcx,[rbp+0FFD8]
       call      System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
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
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,198C67C1508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,198C67C35F8
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       r14d,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       call      qword ptr [7FFB3C4D8548]
       mov       rbx,rax
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFB3C4D43E8]
       mov       rax,rbx
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M01_L04
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFB3C4D43E8]
M01_L04:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 364
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       r8,280AD793020
       mov       r8,[r8]
       mov       rdx,2809D79D150
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFD8],rdi
       mov       rcx,280AD791AD8
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4D1248]
       mov       rdx,rax
       mov       rcx,[rbp+0FFD8]
       call      System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
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
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,280AD791508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,2809D79D158
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       r14d,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       call      qword ptr [7FFB3C4C8548]
       mov       rbx,rax
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFB3C4C43E8]
       mov       rax,rbx
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M01_L04
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFB3C4C43E8]
M01_L04:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 364
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,1F47B7D3158
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
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
; Total bytes of code 99
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,1F47B7D3020
       mov       r8,[r8]
       mov       rdx,1F46B7D1230
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       test      rcx,rcx
       jne       short M01_L00
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M01_L01
M01_L00:
       mov       rdx,rbp
       mov       r9d,[rdx+8]
M01_L01:
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       xor       r8d,r8d
       call      System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M01_L06
       xor       ebp,ebp
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M01_L06
M01_L02:
       movsxd    rcx,ebp
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L03
       cmp       esi,0FFFFFFFE
       jne       short M01_L04
M01_L03:
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M01_L05:
       inc       ebp
       cmp       r15d,ebp
       jg        short M01_L02
M01_L06:
       mov       rcx,r14
       mov       rax,[7FFB3C4C8548]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
; Total bytes of code 249
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,1FA580D3158
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
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
; Total bytes of code 99
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,1FA580D3020
       mov       r8,[r8]
       mov       rdx,1FA480D1230
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       test      rcx,rcx
       jne       short M01_L00
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M01_L01
M01_L00:
       mov       rdx,rbp
       mov       r9d,[rdx+8]
M01_L01:
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       xor       r8d,r8d
       call      System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M01_L06
       xor       ebp,ebp
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M01_L06
M01_L02:
       movsxd    rcx,ebp
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L03
       cmp       esi,0FFFFFFFE
       jne       short M01_L04
M01_L03:
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M01_L05:
       inc       ebp
       cmp       r15d,ebp
       jg        short M01_L02
M01_L06:
       mov       rcx,r14
       mov       rax,[7FFB3C4F8548]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
; Total bytes of code 249
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,195661D3158
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
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
; Total bytes of code 99
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,195661D3020
       mov       r8,[r8]
       mov       rdx,195761DF198
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       test      rcx,rcx
       jne       short M01_L00
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M01_L01
M01_L00:
       mov       rdx,rbp
       mov       r9d,[rdx+8]
M01_L01:
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       xor       r8d,r8d
       call      System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M01_L06
       xor       ebp,ebp
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M01_L06
M01_L02:
       movsxd    rcx,ebp
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L03
       cmp       esi,0FFFFFFFE
       jne       short M01_L04
M01_L03:
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M01_L05:
       inc       ebp
       cmp       r15d,ebp
       jg        short M01_L02
M01_L06:
       mov       rcx,r14
       mov       rax,[7FFB3C4C8548]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
; Total bytes of code 249
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,153B0A43158
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
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
; Total bytes of code 99
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,153B0A43020
       mov       r8,[r8]
       mov       rdx,153D0A4F198
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       test      rcx,rcx
       jne       short M01_L00
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M01_L01
M01_L00:
       mov       rdx,rbp
       mov       r9d,[rdx+8]
M01_L01:
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       xor       r8d,r8d
       call      System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M01_L06
       xor       ebp,ebp
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M01_L06
M01_L02:
       movsxd    rcx,ebp
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L03
       cmp       esi,0FFFFFFFE
       jne       short M01_L04
M01_L03:
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M01_L05:
       inc       ebp
       cmp       r15d,ebp
       jg        short M01_L02
M01_L06:
       mov       rcx,r14
       mov       rax,[7FFB3C4D8548]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
; Total bytes of code 249
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,1F51A483158
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
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
; Total bytes of code 99
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,1F51A483020
       mov       r8,[r8]
       mov       rdx,1F51A483640
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       test      rcx,rcx
       jne       short M01_L00
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M01_L01
M01_L00:
       mov       rdx,rbp
       mov       r9d,[rdx+8]
M01_L01:
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       xor       r8d,r8d
       call      System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M01_L06
       xor       ebp,ebp
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M01_L06
M01_L02:
       movsxd    rcx,ebp
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L03
       cmp       esi,0FFFFFFFE
       jne       short M01_L04
M01_L03:
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M01_L05:
       inc       ebp
       cmp       r15d,ebp
       jg        short M01_L02
M01_L06:
       mov       rcx,r14
       mov       rax,[7FFB3C4C8548]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
; Total bytes of code 249
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,1D9BA523158
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
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
; Total bytes of code 99
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,1D9BA523020
       mov       r8,[r8]
       mov       rdx,1D9CA52F198
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       test      rcx,rcx
       jne       short M01_L00
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M01_L01
M01_L00:
       mov       rdx,rbp
       mov       r9d,[rdx+8]
M01_L01:
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       xor       r8d,r8d
       call      System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M01_L06
       xor       ebp,ebp
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M01_L06
M01_L02:
       movsxd    rcx,ebp
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L03
       cmp       esi,0FFFFFFFE
       jne       short M01_L04
M01_L03:
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M01_L05:
       inc       ebp
       cmp       r15d,ebp
       jg        short M01_L02
M01_L06:
       mov       rcx,r14
       mov       rax,[7FFB3C4F8548]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
; Total bytes of code 249
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,2ADA9903158
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
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
; Total bytes of code 99
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,2ADA9903020
       mov       r8,[r8]
       mov       rdx,2ADA99115A8
       mov       rdx,[rdx]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rbp
       test      rcx,rcx
       jne       short M01_L00
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M01_L01
M01_L00:
       mov       rdx,rbp
       mov       r9d,[rdx+8]
M01_L01:
       mov       dword ptr [rsp+20],10
       mov       rcx,r14
       xor       r8d,r8d
       call      System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M01_L06
       xor       ebp,ebp
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       short M01_L06
M01_L02:
       movsxd    rcx,ebp
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L03
       cmp       esi,0FFFFFFFE
       jne       short M01_L04
M01_L03:
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.Text.StringBuilder.Append(System.String)
M01_L05:
       inc       ebp
       cmp       r15d,ebp
       jg        short M01_L02
M01_L06:
       mov       rcx,r14
       mov       rax,[7FFB3C4D8548]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
; Total bytes of code 249
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator02()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rdi,rax
       mov       rcx,25C3F431160
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
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
; Total bytes of code 98
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,25C3F431028
       mov       r8,[r8]
       mov       rdx,25C3F43F5B0
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,7FFB3C534B70
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,25C3F439978
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFD0],rax
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       movsxd    rcx,r15d
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       esi,0FFFFFFFE
       jne       short M01_L02
M01_L01:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4D8548]
       mov       rsi,rax
       mov       rcx,25C3F439978
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       lea       rsp,[rbp+0FFD8]
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
       mov       rcx,7FFB3C534B70
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,25C3F439978
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
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
; Total bytes of code 354
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator02()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rdi,rax
       mov       rcx,26F1ADD3158
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
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
; Total bytes of code 98
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,26F1ADD3020
       mov       r8,[r8]
       mov       rdx,26F1ADD3640
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,7FFB3C554B70
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,26F3ADD9560
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFD0],rax
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       movsxd    rcx,r15d
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       esi,0FFFFFFFE
       jne       short M01_L02
M01_L01:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4F8548]
       mov       rsi,rax
       mov       rcx,26F3ADD9560
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       lea       rsp,[rbp+0FFD8]
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
       mov       rcx,7FFB3C554B70
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,26F3ADD9560
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
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
; Total bytes of code 354
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator02()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rdi,rax
       mov       rcx,1B0B9993158
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
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
; Total bytes of code 98
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,1B0B9993020
       mov       r8,[r8]
       mov       rdx,1B0D999F198
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,7FFB3C524B70
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1B0D9999560
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFD0],rax
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       movsxd    rcx,r15d
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       esi,0FFFFFFFE
       jne       short M01_L02
M01_L01:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4C8548]
       mov       rsi,rax
       mov       rcx,1B0D9999560
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       lea       rsp,[rbp+0FFD8]
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
       mov       rcx,7FFB3C524B70
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1B0D9999560
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
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
; Total bytes of code 354
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator02()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rdi,rax
       mov       rcx,1B1F2B43158
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
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
; Total bytes of code 98
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,1B1F2B43020
       mov       r8,[r8]
       mov       rdx,1B202B47200
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,7FFB3C544B70
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1B1E2B43590
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFD0],rax
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       movsxd    rcx,r15d
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       esi,0FFFFFFFE
       jne       short M01_L02
M01_L01:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4E8548]
       mov       rsi,rax
       mov       rcx,1B1E2B43590
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       lea       rsp,[rbp+0FFD8]
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
       mov       rcx,7FFB3C544B70
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1B1E2B43590
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
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
; Total bytes of code 354
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator02()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rdi,rax
       mov       rcx,29528E63158
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
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
; Total bytes of code 98
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,29528E63020
       mov       r8,[r8]
       mov       rdx,29508E61230
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,7FFB3C544B70
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,29518E67568
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFD0],rax
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       movsxd    rcx,r15d
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       esi,0FFFFFFFE
       jne       short M01_L02
M01_L01:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4E8548]
       mov       rsi,rax
       mov       rcx,29518E67568
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       lea       rsp,[rbp+0FFD8]
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
       mov       rcx,7FFB3C544B70
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,29518E67568
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
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
; Total bytes of code 354
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator02()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rdi,rax
       mov       rcx,2A7D7E23158
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
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
; Total bytes of code 98
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,2A7D7E23020
       mov       r8,[r8]
       mov       rdx,2A7D7E315A8
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,7FFB3C554B70
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2A7D7E2B970
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFD0],rax
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       movsxd    rcx,r15d
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       esi,0FFFFFFFE
       jne       short M01_L02
M01_L01:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4F8548]
       mov       rsi,rax
       mov       rcx,2A7D7E2B970
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       lea       rsp,[rbp+0FFD8]
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
       mov       rcx,7FFB3C554B70
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2A7D7E2B970
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
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
; Total bytes of code 354
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator02()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rdi,rax
       mov       rcx,1FA17D93158
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
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
; Total bytes of code 98
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,1FA17D93020
       mov       r8,[r8]
       mov       rdx,1FA37D93228
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,7FFB3C544B70
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FA27D97568
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFD0],rax
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       movsxd    rcx,r15d
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       esi,0FFFFFFFE
       jne       short M01_L02
M01_L01:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4E8548]
       mov       rsi,rax
       mov       rcx,1FA27D97568
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       lea       rsp,[rbp+0FFD8]
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
       mov       rcx,7FFB3C544B70
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FA27D97568
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
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
; Total bytes of code 354
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,19B3A3611E0
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,19B3A3611E8
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.StringExtensions.ContainsAny(System.String, System.String[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 119
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.ContainsAny(System.String, System.String[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringExtensions+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+8]
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       test      eax,eax
       je        short M01_L00
       cmp       dword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,offset dotNetTips.Spargine.Extensions.StringExtensions+<>c__DisplayClass3_0.<ContainsAny>b__0(System.String)
       mov       [rdi+18],r8
       mov       r8,rdi
       mov       rdx,rsi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
; Total bytes of code 144
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,1757DA211E0
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,1757DA211E8
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.StringExtensions.ContainsAny(System.String, System.String[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 119
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.ContainsAny(System.String, System.String[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringExtensions+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+8]
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       test      eax,eax
       je        short M01_L00
       cmp       dword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,offset dotNetTips.Spargine.Extensions.StringExtensions+<>c__DisplayClass3_0.<ContainsAny>b__0(System.String)
       mov       [rdi+18],r8
       mov       r8,rdi
       mov       rdx,rsi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
; Total bytes of code 144
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,1AD5A845E00
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,1AD5A845E08
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.StringExtensions.ContainsAny(System.String, System.String[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 119
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.ContainsAny(System.String, System.String[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringExtensions+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+8]
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       test      eax,eax
       je        short M01_L00
       cmp       dword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,offset dotNetTips.Spargine.Extensions.StringExtensions+<>c__DisplayClass3_0.<ContainsAny>b__0(System.String)
       mov       [rdi+18],r8
       mov       r8,rdi
       mov       rdx,rsi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
; Total bytes of code 144
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,1E2EBB811E0
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,1E2EBB811E8
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.StringExtensions.ContainsAny(System.String, System.String[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 119
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.ContainsAny(System.String, System.String[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringExtensions+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+8]
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       test      eax,eax
       je        short M01_L00
       cmp       dword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,offset dotNetTips.Spargine.Extensions.StringExtensions+<>c__DisplayClass3_0.<ContainsAny>b__0(System.String)
       mov       [rdi+18],r8
       mov       r8,rdi
       mov       rdx,rsi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
; Total bytes of code 144
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,26F4CD111E0
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,26F4CD111E8
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.StringExtensions.ContainsAny(System.String, System.String[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 119
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.ContainsAny(System.String, System.String[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringExtensions+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+8]
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       test      eax,eax
       je        short M01_L00
       cmp       dword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,offset dotNetTips.Spargine.Extensions.StringExtensions+<>c__DisplayClass3_0.<ContainsAny>b__0(System.String)
       mov       [rdi+18],r8
       mov       r8,rdi
       mov       rdx,rsi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
; Total bytes of code 144
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,2D7F47D35F0
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,2D7F47D35F8
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.StringExtensions.ContainsAny(System.String, System.String[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 119
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.ContainsAny(System.String, System.String[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringExtensions+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+8]
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       test      eax,eax
       je        short M01_L00
       cmp       dword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,offset dotNetTips.Spargine.Extensions.StringExtensions+<>c__DisplayClass3_0.<ContainsAny>b__0(System.String)
       mov       [rdi+18],r8
       mov       r8,rdi
       mov       rdx,rsi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
; Total bytes of code 144
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,1DA9B221558
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,1DA9B221560
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.StringExtensions.ContainsAny(System.String, System.String[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 119
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.ContainsAny(System.String, System.String[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringExtensions+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+8]
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       test      eax,eax
       je        short M01_L00
       cmp       dword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,offset dotNetTips.Spargine.Extensions.StringExtensions+<>c__DisplayClass3_0.<ContainsAny>b__0(System.String)
       mov       [rdi+18],r8
       mov       r8,rdi
       mov       rdx,rsi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr dotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
; Total bytes of code 144
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,18DD0D53020
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,1B99E543020
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,22CBB933020
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,224A6C53020
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,2737ECA3020
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,1CEA2D53020
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNull(System.String)
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,28892053020
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,25228F01558
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       jbe       short M01_L00
       mov       rax,rcx
       ret
M01_L00:
       mov       rax,rdx
       ret
; Total bytes of code 19
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,14405D711E0
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       jbe       short M01_L00
       mov       rax,rcx
       ret
M01_L00:
       mov       rax,rdx
       ret
; Total bytes of code 19
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,1D7F3FD19F8
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       jbe       short M01_L00
       mov       rax,rcx
       ret
M01_L00:
       mov       rax,rdx
       ret
; Total bytes of code 19
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,1C025E83E08
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       jbe       short M01_L00
       mov       rax,rcx
       ret
M01_L00:
       mov       rax,rdx
       ret
; Total bytes of code 19
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,1E45A3035F0
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       jbe       short M01_L00
       mov       rax,rcx
       ret
M01_L00:
       mov       rax,rdx
       ret
; Total bytes of code 19
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,1A1806FF148
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       jbe       short M01_L00
       mov       rax,rcx
       ret
M01_L00:
       mov       rax,rdx
       ret
; Total bytes of code 19
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,2E65246F148
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.DefaultIfNullOrEmpty(System.String, System.String)
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       jbe       short M01_L00
       mov       rax,rcx
       ret
M01_L00:
       mov       rax,rdx
       ret
; Total bytes of code 19
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DelimitedStringToArray()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       edx,2C
       call      dotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       edi,edx
       mov       r8,21ADA8F3020
       mov       r8,[r8]
       mov       rdx,21ADA8F3640
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       movzx     ecx,di
       mov       [rsp+34],cx
       cmp       [rsi],esi
       lea       rcx,[rsp+34]
       mov       edx,1
       lea       r8,[rsp+20]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rsp+20]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 117
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DelimitedStringToArray()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       edx,2C
       call      dotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       edi,edx
       mov       r8,250DEEE3020
       mov       r8,[r8]
       mov       rdx,250DEEF15A8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       movzx     ecx,di
       mov       [rsp+34],cx
       cmp       [rsi],esi
       lea       rcx,[rsp+34]
       mov       edx,1
       lea       r8,[rsp+20]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rsp+20]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 117
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DelimitedStringToArray()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       edx,2C
       call      dotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       edi,edx
       mov       r8,2B6FCB81028
       mov       r8,[r8]
       mov       rdx,2B6CCB81230
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       movzx     ecx,di
       mov       [rsp+34],cx
       cmp       [rsi],esi
       lea       rcx,[rsp+34]
       mov       edx,1
       lea       r8,[rsp+20]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rsp+20]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 117
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DelimitedStringToArray()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       edx,2C
       call      dotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       edi,edx
       mov       r8,26B95873020
       mov       r8,[r8]
       mov       rdx,26B75871230
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       movzx     ecx,di
       mov       [rsp+34],cx
       cmp       [rsi],esi
       lea       rcx,[rsp+34]
       mov       edx,1
       lea       r8,[rsp+20]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rsp+20]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 117
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DelimitedStringToArray()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       edx,2C
       call      dotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       edi,edx
       mov       r8,1F0AC493020
       mov       r8,[r8]
       mov       rdx,1F0BC49F198
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       movzx     ecx,di
       mov       [rsp+34],cx
       cmp       [rsi],esi
       lea       rcx,[rsp+34]
       mov       edx,1
       lea       r8,[rsp+20]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rsp+20]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 117
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DelimitedStringToArray()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       edx,2C
       call      dotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       edi,edx
       mov       r8,1BF5B473020
       mov       r8,[r8]
       mov       rdx,1BF5B475638
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       movzx     ecx,di
       mov       [rsp+34],cx
       cmp       [rsi],esi
       lea       rcx,[rsp+34]
       mov       edx,1
       lea       r8,[rsp+20]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rsp+20]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 117
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DelimitedStringToArray()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rax
       mov       edx,2C
       call      dotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char)
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       edi,edx
       mov       r8,1C499DE3020
       mov       r8,[r8]
       mov       rdx,1C489DE1230
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       movzx     ecx,di
       mov       [rsp+34],cx
       cmp       [rsi],esi
       lea       rcx,[rsp+34]
       mov       edx,1
       lea       r8,[rsp+20]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rsi
       lea       rdx,[rsp+20]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 117
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       sub       rsp,28
       mov       r8d,5
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       sub       rsp,28
       mov       r8d,5
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       sub       rsp,28
       mov       r8d,5
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       sub       rsp,28
       mov       r8d,5
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       sub       rsp,28
       mov       r8d,5
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       sub       rsp,28
       mov       r8d,5
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       sub       rsp,28
       mov       r8d,5
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 21
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,233F5353020
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,233F5353020
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,1AFCBA63020
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,1AFCBA63020
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,1E7B5CA3020
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,1E7B5CA3020
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,1B531771028
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,1B531771028
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,2B699001028
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,2B699001028
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,25ADD8F3020
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,25ADD8F3020
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,12D47033020
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,12D47033020
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+18]
       call      dotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       test      eax,eax
       jne       short M01_L00
       mov       rax,rsi
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
       mov       rdx,21DED481A28
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,21DED481A08
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FFB3C4D8E30]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 134
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+18]
       call      dotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       test      eax,eax
       jne       short M01_L00
       mov       rax,rsi
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
       mov       rdx,12942451A28
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,12942451A08
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FFB3C4F8E30]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 134
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+18]
       call      dotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       test      eax,eax
       jne       short M01_L00
       mov       rax,rsi
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
       mov       rdx,296440B1A28
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,296440B1A08
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FFB3C4F8E30]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 134
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+18]
       call      dotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       test      eax,eax
       jne       short M01_L00
       mov       rax,rsi
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
       mov       rdx,13200AE1A28
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,13200AE1A08
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FFB3C4F8E30]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 134
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+18]
       call      dotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       test      eax,eax
       jne       short M01_L00
       mov       rax,rsi
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
       mov       rdx,21BA1861A28
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,21BA1861A08
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FFB3C4D8E30]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 134
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+18]
       call      dotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       test      eax,eax
       jne       short M01_L00
       mov       rax,rsi
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
       mov       rdx,1E1FB851A28
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1E1FB851A08
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FFB3C4E8E30]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 134
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+18]
       call      dotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       test      eax,eax
       jne       short M01_L00
       mov       rax,rsi
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
       mov       rdx,24C15F71A28
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,24C15F71A08
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FFB3C4C8E30]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 134
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       xor       eax,eax
       add       rsp,28
       ret
; Total bytes of code 41
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       xor       eax,eax
       add       rsp,28
       ret
; Total bytes of code 41
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       xor       eax,eax
       add       rsp,28
       ret
; Total bytes of code 41
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       xor       eax,eax
       add       rsp,28
       ret
; Total bytes of code 41
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       xor       eax,eax
       add       rsp,28
       ret
; Total bytes of code 41
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       xor       eax,eax
       add       rsp,28
       ret
; Total bytes of code 41
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       xor       eax,eax
       add       rsp,28
       ret
; Total bytes of code 41
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,0A
       mov       r8d,3E
       call      dotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       r8,27160243020
       mov       r8,[r8]
       mov       rdx,27160243640
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       edx,esi
       neg       edx
       shr       edx,1F
       mov       r9d,esi
       sar       r9d,1F
       or        edx,r9d
       cmp       edx,0FFFFFFFF
       setne     dl
       movzx     edx,dl
       mov       r9,27160243020
       mov       r9,[r9]
       mov       r8,27160243A30
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       mov       rcx,rbp
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       test      esi,esi
       jne       short M01_L00
       mov       rcx,rbp
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L00:
       mov       r14d,1
       jmp       short M01_L02
M01_L01:
       movzx     edx,bx
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(Char)
       inc       r14d
M01_L02:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L03
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L05
M01_L03:
       cmp       r14d,edx
       jle       short M01_L01
       test      esi,esi
       jle       short M01_L04
       mov       rcx,rbp
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L04:
       mov       rcx,rbp
       mov       rax,[7FFB3C4E8548]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M01_L05:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 261
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,0A
       mov       r8d,3E
       call      dotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       r8,233866A1028
       mov       r8,[r8]
       mov       rdx,233766A1230
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       edx,esi
       neg       edx
       shr       edx,1F
       mov       r9d,esi
       sar       r9d,1F
       or        edx,r9d
       cmp       edx,0FFFFFFFF
       setne     dl
       movzx     edx,dl
       mov       r9,233866A1028
       mov       r9,[r9]
       mov       r8,233766A1620
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       mov       rcx,rbp
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       test      esi,esi
       jne       short M01_L00
       mov       rcx,rbp
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L00:
       mov       r14d,1
       jmp       short M01_L02
M01_L01:
       movzx     edx,bx
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(Char)
       inc       r14d
M01_L02:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L03
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L05
M01_L03:
       cmp       r14d,edx
       jle       short M01_L01
       test      esi,esi
       jle       short M01_L04
       mov       rcx,rbp
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L04:
       mov       rcx,rbp
       mov       rax,[7FFB3C4D8548]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M01_L05:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 261
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,0A
       mov       r8d,3E
       call      dotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       r8,195579F3020
       mov       r8,[r8]
       mov       rdx,195379FD1A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       edx,esi
       neg       edx
       shr       edx,1F
       mov       r9d,esi
       sar       r9d,1F
       or        edx,r9d
       cmp       edx,0FFFFFFFF
       setne     dl
       movzx     edx,dl
       mov       r9,195579F3020
       mov       r9,[r9]
       mov       r8,195379FD590
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       mov       rcx,rbp
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       test      esi,esi
       jne       short M01_L00
       mov       rcx,rbp
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L00:
       mov       r14d,1
       jmp       short M01_L02
M01_L01:
       movzx     edx,bx
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(Char)
       inc       r14d
M01_L02:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L03
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L05
M01_L03:
       cmp       r14d,edx
       jle       short M01_L01
       test      esi,esi
       jle       short M01_L04
       mov       rcx,rbp
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L04:
       mov       rcx,rbp
       mov       rax,[7FFB3C4E8548]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M01_L05:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 261
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,0A
       mov       r8d,3E
       call      dotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       r8,1967D3B3020
       mov       r8,[r8]
       mov       rdx,1969D3BF198
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       edx,esi
       neg       edx
       shr       edx,1F
       mov       r9d,esi
       sar       r9d,1F
       or        edx,r9d
       cmp       edx,0FFFFFFFF
       setne     dl
       movzx     edx,dl
       mov       r9,1967D3B3020
       mov       r9,[r9]
       mov       r8,1969D3BF588
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       mov       rcx,rbp
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       test      esi,esi
       jne       short M01_L00
       mov       rcx,rbp
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L00:
       mov       r14d,1
       jmp       short M01_L02
M01_L01:
       movzx     edx,bx
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(Char)
       inc       r14d
M01_L02:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L03
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L05
M01_L03:
       cmp       r14d,edx
       jle       short M01_L01
       test      esi,esi
       jle       short M01_L04
       mov       rcx,rbp
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L04:
       mov       rcx,rbp
       mov       rax,[7FFB3C4D8548]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M01_L05:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 261
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,0A
       mov       r8d,3E
       call      dotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       r8,1F1368B3020
       mov       r8,[r8]
       mov       rdx,1F1368C15A8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       edx,esi
       neg       edx
       shr       edx,1F
       mov       r9d,esi
       sar       r9d,1F
       or        edx,r9d
       cmp       edx,0FFFFFFFF
       setne     dl
       movzx     edx,dl
       mov       r9,1F1368B3020
       mov       r9,[r9]
       mov       r8,1F1368C1998
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       mov       rcx,rbp
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       test      esi,esi
       jne       short M01_L00
       mov       rcx,rbp
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L00:
       mov       r14d,1
       jmp       short M01_L02
M01_L01:
       movzx     edx,bx
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(Char)
       inc       r14d
M01_L02:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L03
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L05
M01_L03:
       cmp       r14d,edx
       jle       short M01_L01
       test      esi,esi
       jle       short M01_L04
       mov       rcx,rbp
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L04:
       mov       rcx,rbp
       mov       rax,[7FFB3C4B8548]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M01_L05:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 261
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,0A
       mov       r8d,3E
       call      dotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       r8,195C5FB3020
       mov       r8,[r8]
       mov       rdx,195A5FB1230
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       edx,esi
       neg       edx
       shr       edx,1F
       mov       r9d,esi
       sar       r9d,1F
       or        edx,r9d
       cmp       edx,0FFFFFFFF
       setne     dl
       movzx     edx,dl
       mov       r9,195C5FB3020
       mov       r9,[r9]
       mov       r8,195A5FB1620
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       mov       rcx,rbp
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       test      esi,esi
       jne       short M01_L00
       mov       rcx,rbp
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L00:
       mov       r14d,1
       jmp       short M01_L02
M01_L01:
       movzx     edx,bx
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(Char)
       inc       r14d
M01_L02:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L03
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L05
M01_L03:
       cmp       r14d,edx
       jle       short M01_L01
       test      esi,esi
       jle       short M01_L04
       mov       rcx,rbp
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L04:
       mov       rcx,rbp
       mov       rax,[7FFB3C4F8548]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M01_L05:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 261
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,0A
       mov       r8d,3E
       call      dotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       mov       r8,27B646A3020
       mov       r8,[r8]
       mov       rdx,27B646A3640
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       edx,esi
       neg       edx
       shr       edx,1F
       mov       r9d,esi
       sar       r9d,1F
       or        edx,r9d
       cmp       edx,0FFFFFFFF
       setne     dl
       movzx     edx,dl
       mov       r9,27B646A3020
       mov       r9,[r9]
       mov       r8,27B646A3A30
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       edx,eax
       mov       rcx,rbp
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       test      esi,esi
       jne       short M01_L00
       mov       rcx,rbp
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L00:
       mov       r14d,1
       jmp       short M01_L02
M01_L01:
       movzx     edx,bx
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(Char)
       inc       r14d
M01_L02:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L03
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L05
M01_L03:
       cmp       r14d,edx
       jle       short M01_L01
       test      esi,esi
       jle       short M01_L04
       mov       rcx,rbp
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L04:
       mov       rcx,rbp
       mov       rax,[7FFB3C4C8548]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M01_L05:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 261
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+194]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       movzx     eax,cx
       add       eax,0FFFFFFBF
       and       rax,0FFFFFFFFFFFFFFDF
       cmp       rax,1A
       setl      al
       movzx     eax,al
       ret
; Total bytes of code 21
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+194]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       movzx     eax,cx
       add       eax,0FFFFFFBF
       and       rax,0FFFFFFFFFFFFFFDF
       cmp       rax,1A
       setl      al
       movzx     eax,al
       ret
; Total bytes of code 21
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+194]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       movzx     eax,cx
       add       eax,0FFFFFFBF
       and       rax,0FFFFFFFFFFFFFFDF
       cmp       rax,1A
       setl      al
       movzx     eax,al
       ret
; Total bytes of code 21
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+194]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       movzx     eax,cx
       add       eax,0FFFFFFBF
       and       rax,0FFFFFFFFFFFFFFDF
       cmp       rax,1A
       setl      al
       movzx     eax,al
       ret
; Total bytes of code 21
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+194]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       movzx     eax,cx
       add       eax,0FFFFFFBF
       and       rax,0FFFFFFFFFFFFFFDF
       cmp       rax,1A
       setl      al
       movzx     eax,al
       ret
; Total bytes of code 21
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+194]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       movzx     eax,cx
       add       eax,0FFFFFFBF
       and       rax,0FFFFFFFFFFFFFFDF
       cmp       rax,1A
       setl      al
       movzx     eax,al
       ret
; Total bytes of code 21
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+194]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       movzx     eax,cx
       add       eax,0FFFFFFBF
       and       rax,0FFFFFFFFFFFFFFDF
       cmp       rax,1A
       setl      al
       movzx     eax,al
       ret
; Total bytes of code 21
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+194]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       movzx     eax,cx
       lea       edx,[rax+0FFBF]
       and       rdx,0FFFFFFFFFFFFFFDF
       cmp       rdx,1A
       jl        short M01_L00
       add       eax,0FFFFFFD0
       cmp       eax,0A
       setb      al
       movzx     eax,al
       ret
M01_L00:
       mov       eax,1
       ret
; Total bytes of code 35
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+194]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       movzx     eax,cx
       lea       edx,[rax+0FFBF]
       and       rdx,0FFFFFFFFFFFFFFDF
       cmp       rdx,1A
       jl        short M01_L00
       add       eax,0FFFFFFD0
       cmp       eax,0A
       setb      al
       movzx     eax,al
       ret
M01_L00:
       mov       eax,1
       ret
; Total bytes of code 35
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+194]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       movzx     eax,cx
       lea       edx,[rax+0FFBF]
       and       rdx,0FFFFFFFFFFFFFFDF
       cmp       rdx,1A
       jl        short M01_L00
       add       eax,0FFFFFFD0
       cmp       eax,0A
       setb      al
       movzx     eax,al
       ret
M01_L00:
       mov       eax,1
       ret
; Total bytes of code 35
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+194]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       movzx     eax,cx
       lea       edx,[rax+0FFBF]
       and       rdx,0FFFFFFFFFFFFFFDF
       cmp       rdx,1A
       jl        short M01_L00
       add       eax,0FFFFFFD0
       cmp       eax,0A
       setb      al
       movzx     eax,al
       ret
M01_L00:
       mov       eax,1
       ret
; Total bytes of code 35
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+194]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       movzx     eax,cx
       lea       edx,[rax+0FFBF]
       and       rdx,0FFFFFFFFFFFFFFDF
       cmp       rdx,1A
       jl        short M01_L00
       add       eax,0FFFFFFD0
       cmp       eax,0A
       setb      al
       movzx     eax,al
       ret
M01_L00:
       mov       eax,1
       ret
; Total bytes of code 35
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+194]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       movzx     eax,cx
       lea       edx,[rax+0FFBF]
       and       rdx,0FFFFFFFFFFFFFFDF
       cmp       rdx,1A
       jl        short M01_L00
       add       eax,0FFFFFFD0
       cmp       eax,0A
       setb      al
       movzx     eax,al
       ret
M01_L00:
       mov       eax,1
       ret
; Total bytes of code 35
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+194]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       movzx     eax,cx
       lea       edx,[rax+0FFBF]
       and       rdx,0FFFFFFFFFFFFFFDF
       cmp       rdx,1A
       jl        short M01_L00
       add       eax,0FFFFFFD0
       cmp       eax,0A
       setb      al
       movzx     eax,al
       ret
M01_L00:
       mov       eax,1
       ret
; Total bytes of code 35
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       lea       rcx,[rsp+20]
       call      System.Guid.NewGuid()
       lea       rcx,[rsp+20]
       call      System.Guid.ToString()
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; System.Guid.NewGuid()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       vzeroupper
       lea       rbp,[rsp+40]
       mov       rsi,rcx
       lea       rcx,[rbp+0FFE0]
       call      Interop+Ole32.CoCreateGuid(System.Guid ByRef)
       mov       edi,eax
       test      edi,edi
       jne       short M01_L00
       vmovdqu   xmm0,xmmword ptr [rbp+0FFE0]
       vmovdqu   xmmword ptr [rsi],xmm0
       mov       rax,rsi
       lea       rsp,[rbp+0FFF0]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.Exception..ctor()
       mov       [rsi+74],edi
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 91
```
```assembly
; System.Guid.ToString()
       mov       rdx,1CFDDAF19E0
       mov       rdx,[rdx]
       xor       r8d,r8d
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 21
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       xor       eax,eax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1CFEDAE11E0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
M03_L00:
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       lea       rcx,[rsp+20]
       call      System.Guid.NewGuid()
       lea       rcx,[rsp+20]
       call      System.Guid.ToString()
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; System.Guid.NewGuid()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       vzeroupper
       lea       rbp,[rsp+40]
       mov       rsi,rcx
       lea       rcx,[rbp+0FFE0]
       call      Interop+Ole32.CoCreateGuid(System.Guid ByRef)
       mov       edi,eax
       test      edi,edi
       jne       short M01_L00
       vmovdqu   xmm0,xmmword ptr [rbp+0FFE0]
       vmovdqu   xmmword ptr [rsi],xmm0
       mov       rax,rsi
       lea       rsp,[rbp+0FFF0]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.Exception..ctor()
       mov       [rsi+74],edi
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 91
```
```assembly
; System.Guid.ToString()
       mov       rdx,1F05A4FF9E8
       mov       rdx,[rdx]
       xor       r8d,r8d
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 21
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       xor       eax,eax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1F04A4F11E0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
M03_L00:
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       lea       rcx,[rsp+20]
       call      System.Guid.NewGuid()
       lea       rcx,[rsp+20]
       call      System.Guid.ToString()
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; System.Guid.NewGuid()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       vzeroupper
       lea       rbp,[rsp+40]
       mov       rsi,rcx
       lea       rcx,[rbp+0FFE0]
       call      Interop+Ole32.CoCreateGuid(System.Guid ByRef)
       mov       edi,eax
       test      edi,edi
       jne       short M01_L00
       vmovdqu   xmm0,xmmword ptr [rbp+0FFE0]
       vmovdqu   xmmword ptr [rsi],xmm0
       mov       rax,rsi
       lea       rsp,[rbp+0FFF0]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.Exception..ctor()
       mov       [rsi+74],edi
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 91
```
```assembly
; System.Guid.ToString()
       mov       rdx,1C11F6F1668
       mov       rdx,[rdx]
       xor       r8d,r8d
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 21
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       xor       eax,eax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1C13F6FF560
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
M03_L00:
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       lea       rcx,[rsp+20]
       call      System.Guid.NewGuid()
       lea       rcx,[rsp+20]
       call      System.Guid.ToString()
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; System.Guid.NewGuid()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       vzeroupper
       lea       rbp,[rsp+40]
       mov       rsi,rcx
       lea       rcx,[rbp+0FFE0]
       call      Interop+Ole32.CoCreateGuid(System.Guid ByRef)
       mov       edi,eax
       test      edi,edi
       jne       short M01_L00
       vmovdqu   xmm0,xmmword ptr [rbp+0FFE0]
       vmovdqu   xmmword ptr [rsi],xmm0
       mov       rax,rsi
       lea       rsp,[rbp+0FFF0]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.Exception..ctor()
       mov       [rsi+74],edi
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 91
```
```assembly
; System.Guid.ToString()
       mov       rdx,206D2A3F5D0
       mov       rdx,[rdx]
       xor       r8d,r8d
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 21
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       xor       eax,eax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,206B2A335F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
M03_L00:
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       lea       rcx,[rsp+20]
       call      System.Guid.NewGuid()
       lea       rcx,[rsp+20]
       call      System.Guid.ToString()
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; System.Guid.NewGuid()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       vzeroupper
       lea       rbp,[rsp+40]
       mov       rsi,rcx
       lea       rcx,[rbp+0FFE0]
       call      Interop+Ole32.CoCreateGuid(System.Guid ByRef)
       mov       edi,eax
       test      edi,edi
       jne       short M01_L00
       vmovdqu   xmm0,xmmword ptr [rbp+0FFE0]
       vmovdqu   xmmword ptr [rsi],xmm0
       mov       rax,rsi
       lea       rsp,[rbp+0FFF0]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.Exception..ctor()
       mov       [rsi+74],edi
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 91
```
```assembly
; System.Guid.ToString()
       mov       rdx,24F87BFF5D0
       mov       rdx,[rdx]
       xor       r8d,r8d
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 21
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       xor       eax,eax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,24F97BF11E0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
M03_L00:
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       lea       rcx,[rsp+20]
       call      System.Guid.NewGuid()
       lea       rcx,[rsp+20]
       call      System.Guid.ToString()
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; System.Guid.NewGuid()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       vzeroupper
       lea       rbp,[rsp+40]
       mov       rsi,rcx
       lea       rcx,[rbp+0FFE0]
       call      Interop+Ole32.CoCreateGuid(System.Guid ByRef)
       mov       edi,eax
       test      edi,edi
       jne       short M01_L00
       vmovdqu   xmm0,xmmword ptr [rbp+0FFE0]
       vmovdqu   xmmword ptr [rsi],xmm0
       mov       rax,rsi
       lea       rsp,[rbp+0FFF0]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.Exception..ctor()
       mov       [rsi+74],edi
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 91
```
```assembly
; System.Guid.ToString()
       mov       rdx,1AB54153A78
       mov       rdx,[rdx]
       xor       r8d,r8d
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 21
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       xor       eax,eax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1AB7415F148
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
M03_L00:
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       lea       rcx,[rsp+20]
       call      System.Guid.NewGuid()
       lea       rcx,[rsp+20]
       call      System.Guid.ToString()
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; System.Guid.NewGuid()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       vzeroupper
       lea       rbp,[rsp+40]
       mov       rsi,rcx
       lea       rcx,[rbp+0FFE0]
       call      Interop+Ole32.CoCreateGuid(System.Guid ByRef)
       mov       edi,eax
       test      edi,edi
       jne       short M01_L00
       vmovdqu   xmm0,xmmword ptr [rbp+0FFE0]
       vmovdqu   xmmword ptr [rsi],xmm0
       mov       rax,rsi
       lea       rsp,[rbp+0FFF0]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.Exception..ctor()
       mov       [rsi+74],edi
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 91
```
```assembly
; System.Guid.ToString()
       mov       rdx,1F0CCF23660
       mov       rdx,[rdx]
       xor       r8d,r8d
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 21
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       xor       eax,eax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1F0ECF211E0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
M03_L00:
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,1C6F0003E08
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       xor       eax,eax
       test      rsi,rsi
       je        short M01_L00
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1C6F0003E10
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,26CB233F148
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       xor       eax,eax
       test      rsi,rsi
       je        short M01_L00
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,26CB233F150
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,1CEA0DF39F0
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       xor       eax,eax
       test      rsi,rsi
       je        short M01_L00
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1CEA0DF39F8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,159FD7D11E0
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       xor       eax,eax
       test      rsi,rsi
       je        short M01_L00
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,159FD7D11E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,1D3645219F8
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       xor       eax,eax
       test      rsi,rsi
       je        short M01_L00
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1D364521A00
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,18821D4F560
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       xor       eax,eax
       test      rsi,rsi
       je        short M01_L00
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,18821D4F568
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,1D1BA3111E0
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       xor       eax,eax
       test      rsi,rsi
       je        short M01_L00
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1D1BA3111E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,8
       call      System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 80
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceChar()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+194]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(Char)
       movzx     eax,cx
       cmp       eax,20
       jg        short M01_L01
       cmp       eax,20
       je        short M01_L00
       cmp       eax,9
       je        short M01_L00
       cmp       eax,0D
       je        short M01_L00
       cmp       eax,0A
       sete      al
       movzx     eax,al
       ret
M01_L00:
       mov       eax,1
       ret
M01_L01:
       xor       eax,eax
       ret
; Total bytes of code 42
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceChar()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+194]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(Char)
       movzx     eax,cx
       cmp       eax,20
       jg        short M01_L01
       cmp       eax,20
       je        short M01_L00
       cmp       eax,9
       je        short M01_L00
       cmp       eax,0D
       je        short M01_L00
       cmp       eax,0A
       sete      al
       movzx     eax,al
       ret
M01_L00:
       mov       eax,1
       ret
M01_L01:
       xor       eax,eax
       ret
; Total bytes of code 42
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceChar()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+194]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(Char)
       movzx     eax,cx
       cmp       eax,20
       jg        short M01_L01
       cmp       eax,20
       je        short M01_L00
       cmp       eax,9
       je        short M01_L00
       cmp       eax,0D
       je        short M01_L00
       cmp       eax,0A
       sete      al
       movzx     eax,al
       ret
M01_L00:
       mov       eax,1
       ret
M01_L01:
       xor       eax,eax
       ret
; Total bytes of code 42
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceChar()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+194]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(Char)
       movzx     eax,cx
       cmp       eax,20
       jg        short M01_L01
       cmp       eax,20
       je        short M01_L00
       cmp       eax,9
       je        short M01_L00
       cmp       eax,0D
       je        short M01_L00
       cmp       eax,0A
       sete      al
       movzx     eax,al
       ret
M01_L00:
       mov       eax,1
       ret
M01_L01:
       xor       eax,eax
       ret
; Total bytes of code 42
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceChar()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+194]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(Char)
       movzx     eax,cx
       cmp       eax,20
       jg        short M01_L01
       cmp       eax,20
       je        short M01_L00
       cmp       eax,9
       je        short M01_L00
       cmp       eax,0D
       je        short M01_L00
       cmp       eax,0A
       sete      al
       movzx     eax,al
       ret
M01_L00:
       mov       eax,1
       ret
M01_L01:
       xor       eax,eax
       ret
; Total bytes of code 42
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceChar()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+194]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(Char)
       movzx     eax,cx
       cmp       eax,20
       jg        short M01_L01
       cmp       eax,20
       je        short M01_L00
       cmp       eax,9
       je        short M01_L00
       cmp       eax,0D
       je        short M01_L00
       cmp       eax,0A
       sete      al
       movzx     eax,al
       ret
M01_L00:
       mov       eax,1
       ret
M01_L01:
       xor       eax,eax
       ret
; Total bytes of code 42
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceChar()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+194]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(Char)
       movzx     eax,cx
       cmp       eax,20
       jg        short M01_L01
       cmp       eax,20
       je        short M01_L00
       cmp       eax,9
       je        short M01_L00
       cmp       eax,0D
       je        short M01_L00
       cmp       eax,0A
       sete      al
       movzx     eax,al
       ret
M01_L00:
       mov       eax,1
       ret
M01_L01:
       xor       eax,eax
       ret
; Total bytes of code 42
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceString()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rsi,rsi
       je        short M01_L00
       mov       edi,[rsi+8]
       test      edi,edi
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       xor       ebx,ebx
       mov       edi,[rsi+8]
       test      edi,edi
       jle       short M01_L03
M01_L02:
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(Char)
       test      eax,eax
       je        short M01_L04
       inc       ebx
       cmp       edi,ebx
       jg        short M01_L02
M01_L03:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 87
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceString()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rsi,rsi
       je        short M01_L00
       mov       edi,[rsi+8]
       test      edi,edi
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       xor       ebx,ebx
       mov       edi,[rsi+8]
       test      edi,edi
       jle       short M01_L03
M01_L02:
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(Char)
       test      eax,eax
       je        short M01_L04
       inc       ebx
       cmp       edi,ebx
       jg        short M01_L02
M01_L03:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 87
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceString()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rsi,rsi
       je        short M01_L00
       mov       edi,[rsi+8]
       test      edi,edi
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       xor       ebx,ebx
       mov       edi,[rsi+8]
       test      edi,edi
       jle       short M01_L03
M01_L02:
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(Char)
       test      eax,eax
       je        short M01_L04
       inc       ebx
       cmp       edi,ebx
       jg        short M01_L02
M01_L03:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 87
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceString()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rsi,rsi
       je        short M01_L00
       mov       edi,[rsi+8]
       test      edi,edi
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       xor       ebx,ebx
       mov       edi,[rsi+8]
       test      edi,edi
       jle       short M01_L03
M01_L02:
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(Char)
       test      eax,eax
       je        short M01_L04
       inc       ebx
       cmp       edi,ebx
       jg        short M01_L02
M01_L03:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 87
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceString()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rsi,rsi
       je        short M01_L00
       mov       edi,[rsi+8]
       test      edi,edi
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       xor       ebx,ebx
       mov       edi,[rsi+8]
       test      edi,edi
       jle       short M01_L03
M01_L02:
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(Char)
       test      eax,eax
       je        short M01_L04
       inc       ebx
       cmp       edi,ebx
       jg        short M01_L02
M01_L03:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 87
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceString()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rsi,rsi
       je        short M01_L00
       mov       edi,[rsi+8]
       test      edi,edi
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       xor       ebx,ebx
       mov       edi,[rsi+8]
       test      edi,edi
       jle       short M01_L03
M01_L02:
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(Char)
       test      eax,eax
       je        short M01_L04
       inc       ebx
       cmp       edi,ebx
       jg        short M01_L02
M01_L03:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 87
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceString()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rsi,rsi
       je        short M01_L00
       mov       edi,[rsi+8]
       test      edi,edi
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       xor       ebx,ebx
       mov       edi,[rsi+8]
       test      edi,edi
       jle       short M01_L03
M01_L02:
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsWhitespace(Char)
       test      eax,eax
       je        short M01_L04
       inc       ebx
       cmp       edi,ebx
       jg        short M01_L02
M01_L03:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 87
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+198]
       mov       rdx,256AD5B3020
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rdx,256AD5B5E00
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,rdi
       mov       r9d,9
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
; Total bytes of code 70
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+198]
       mov       rdx,1EFAF0F3020
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rdx,1EFDF0FF148
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,rdi
       mov       r9d,9
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
; Total bytes of code 70
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+198]
       mov       rdx,16A2DA53020
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rdx,16A0DA511E0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,rdi
       mov       r9d,9
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
; Total bytes of code 70
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+198]
       mov       rdx,234E5133020
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rdx,234E51355E8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,rdi
       mov       r9d,9
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
; Total bytes of code 70
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+198]
       mov       rdx,1CC7F5A3020
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rdx,1CC7F5B1558
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,rdi
       mov       r9d,9
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
; Total bytes of code 70
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+198]
       mov       rdx,21E89273020
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rdx,21EA92719F8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,rdi
       mov       r9d,9
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
; Total bytes of code 70
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+198]
       mov       rdx,266EEC13020
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.RemoveCRLF(System.String, System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rdx,2671EC111E0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,rdi
       mov       r9d,9
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Text.RegularExpressions.Regex.Replace(System.String, System.String, System.String, System.Text.RegularExpressions.RegexOptions)
; Total bytes of code 70
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L00
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       ecx,[rsi+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],4
       mov       rcx,rdi
       mov       r8,rsi
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
; Total bytes of code 91
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L00
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       ecx,[rsi+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],4
       mov       rcx,rdi
       mov       r8,rsi
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
; Total bytes of code 91
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L00
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       ecx,[rsi+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],4
       mov       rcx,rdi
       mov       r8,rsi
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
; Total bytes of code 91
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L00
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       ecx,[rsi+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],4
       mov       rcx,rdi
       mov       r8,rsi
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
; Total bytes of code 91
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L00
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       ecx,[rsi+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],4
       mov       rcx,rdi
       mov       r8,rsi
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
; Total bytes of code 91
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L00
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       ecx,[rsi+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],4
       mov       rcx,rdi
       mov       r8,rsi
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
; Total bytes of code 91
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L00
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       ecx,[rsi+8]
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],4
       mov       rcx,rdi
       mov       r8,rsi
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
; Total bytes of code 91
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       sub       rsp,38
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       jbe       short M01_L00
       test      rdx,rdx
       je        short M01_L00
       cmp       dword ptr [rdx+8],0
       ja        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,38
       ret
M01_L01:
       mov       r8d,[rdx+8]
       mov       [rsp+20],r8d
       mov       dword ptr [rsp+28],5
       mov       r8,rdx
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       ret
; Total bytes of code 76
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       sub       rsp,38
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       jbe       short M01_L00
       test      rdx,rdx
       je        short M01_L00
       cmp       dword ptr [rdx+8],0
       ja        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,38
       ret
M01_L01:
       mov       r8d,[rdx+8]
       mov       [rsp+20],r8d
       mov       dword ptr [rsp+28],5
       mov       r8,rdx
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       ret
; Total bytes of code 76
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       sub       rsp,38
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       jbe       short M01_L00
       test      rdx,rdx
       je        short M01_L00
       cmp       dword ptr [rdx+8],0
       ja        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,38
       ret
M01_L01:
       mov       r8d,[rdx+8]
       mov       [rsp+20],r8d
       mov       dword ptr [rsp+28],5
       mov       r8,rdx
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       ret
; Total bytes of code 76
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       sub       rsp,38
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       jbe       short M01_L00
       test      rdx,rdx
       je        short M01_L00
       cmp       dword ptr [rdx+8],0
       ja        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,38
       ret
M01_L01:
       mov       r8d,[rdx+8]
       mov       [rsp+20],r8d
       mov       dword ptr [rsp+28],5
       mov       r8,rdx
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       ret
; Total bytes of code 76
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       sub       rsp,38
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       jbe       short M01_L00
       test      rdx,rdx
       je        short M01_L00
       cmp       dword ptr [rdx+8],0
       ja        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,38
       ret
M01_L01:
       mov       r8d,[rdx+8]
       mov       [rsp+20],r8d
       mov       dword ptr [rsp+28],5
       mov       r8,rdx
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       ret
; Total bytes of code 76
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       sub       rsp,38
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       jbe       short M01_L00
       test      rdx,rdx
       je        short M01_L00
       cmp       dword ptr [rdx+8],0
       ja        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,38
       ret
M01_L01:
       mov       r8d,[rdx+8]
       mov       [rsp+20],r8d
       mov       dword ptr [rsp+28],5
       mov       r8,rdx
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       ret
; Total bytes of code 76
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       sub       rsp,38
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       jbe       short M01_L00
       test      rdx,rdx
       je        short M01_L00
       cmp       dword ptr [rdx+8],0
       ja        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,38
       ret
M01_L01:
       mov       r8d,[rdx+8]
       mov       [rsp+20],r8d
       mov       dword ptr [rsp+28],5
       mov       r8,rdx
       xor       edx,edx
       xor       r9d,r9d
       call      System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,38
       ret
; Total bytes of code 76
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      dotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       test      rdi,rdi
       je        short M01_L00
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jne       short M01_L01
M01_L00:
       mov       rax,rdi
       jmp       near ptr M01_L15
M01_L01:
       mov       ecx,esi
       neg       ecx
       shr       ecx,1F
       mov       eax,esi
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L02
       mov       rcx,1DABF621AF0
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L02:
       mov       ecx,ebx
       neg       ecx
       shr       ecx,1F
       mov       eax,ebx
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L03
       mov       rcx,1DABF621998
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L03:
       mov       ebp,[rdi+8]
       mov       ecx,ebp
       sub       ecx,ebx
       cmp       ecx,esi
       jg        short M01_L04
       mov       rcx,1DA9F6111E0
       mov       rcx,[rcx]
       mov       rdx,1DABF621AF0
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       test      ebx,ebx
       jne       short M01_L05
       mov       rcx,1DABF613020
       mov       rax,[rcx]
       jmp       near ptr M01_L15
M01_L05:
       lea       ebx,[rsi+rbx+0FFFF]
       jmp       short M01_L07
M01_L06:
       inc       esi
M01_L07:
       cmp       esi,ebx
       jg        short M01_L10
       cmp       esi,ebp
       jae       near ptr M01_L16
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L08
       cmp       ecx,100
       jae       near ptr M01_L16
       movsxd    rcx,ecx
       mov       rax,7FFB9B3C3926
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L06
       jmp       short M01_L10
M01_L08:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L06
       jmp       short M01_L10
M01_L09:
       dec       ebx
M01_L10:
       cmp       ebx,esi
       jl        short M01_L12
       cmp       ebx,ebp
       jae       near ptr M01_L16
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L11
       cmp       ecx,100
       jae       short M01_L16
       movsxd    rcx,ecx
       mov       rax,7FFB9B3C3926
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L09
       jmp       short M01_L12
M01_L11:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L09
M01_L12:
       mov       r8d,ebx
       sub       r8d,esi
       inc       r8d
       jne       short M01_L13
       mov       r8,1DABF613020
       mov       rax,[r8]
       jmp       short M01_L15
M01_L13:
       cmp       ebp,r8d
       je        short M01_L14
       mov       rcx,rdi
       mov       edx,esi
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L15
M01_L14:
       mov       rax,rdi
M01_L15:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 419
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      dotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       test      rdi,rdi
       je        short M01_L00
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jne       short M01_L01
M01_L00:
       mov       rax,rdi
       jmp       near ptr M01_L15
M01_L01:
       mov       ecx,esi
       neg       ecx
       shr       ecx,1F
       mov       eax,esi
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L02
       mov       rcx,267F0E7F6E0
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L02:
       mov       ecx,ebx
       neg       ecx
       shr       ecx,1F
       mov       eax,ebx
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L03
       mov       rcx,267F0E7F588
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L03:
       mov       ebp,[rdi+8]
       mov       ecx,ebp
       sub       ecx,ebx
       cmp       ecx,esi
       jg        short M01_L04
       mov       rcx,267D0E711E0
       mov       rcx,[rcx]
       mov       rdx,267F0E7F6E0
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       test      ebx,ebx
       jne       short M01_L05
       mov       rcx,267E0E73020
       mov       rax,[rcx]
       jmp       near ptr M01_L15
M01_L05:
       lea       ebx,[rsi+rbx+0FFFF]
       jmp       short M01_L07
M01_L06:
       inc       esi
M01_L07:
       cmp       esi,ebx
       jg        short M01_L10
       cmp       esi,ebp
       jae       near ptr M01_L16
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L08
       cmp       ecx,100
       jae       near ptr M01_L16
       movsxd    rcx,ecx
       mov       rax,7FFB9B3C3926
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L06
       jmp       short M01_L10
M01_L08:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L06
       jmp       short M01_L10
M01_L09:
       dec       ebx
M01_L10:
       cmp       ebx,esi
       jl        short M01_L12
       cmp       ebx,ebp
       jae       near ptr M01_L16
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L11
       cmp       ecx,100
       jae       short M01_L16
       movsxd    rcx,ecx
       mov       rax,7FFB9B3C3926
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L09
       jmp       short M01_L12
M01_L11:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L09
M01_L12:
       mov       r8d,ebx
       sub       r8d,esi
       inc       r8d
       jne       short M01_L13
       mov       r8,267E0E73020
       mov       rax,[r8]
       jmp       short M01_L15
M01_L13:
       cmp       ebp,r8d
       je        short M01_L14
       mov       rcx,rdi
       mov       edx,esi
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L15
M01_L14:
       mov       rax,rdi
M01_L15:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 419
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      dotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       test      rdi,rdi
       je        short M01_L00
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jne       short M01_L01
M01_L00:
       mov       rax,rdi
       jmp       near ptr M01_L15
M01_L01:
       mov       ecx,esi
       neg       ecx
       shr       ecx,1F
       mov       eax,esi
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L02
       mov       rcx,2132FD5F6E0
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L02:
       mov       ecx,ebx
       neg       ecx
       shr       ecx,1F
       mov       eax,ebx
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L03
       mov       rcx,2132FD5F588
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L03:
       mov       ebp,[rdi+8]
       mov       ecx,ebp
       sub       ecx,ebx
       cmp       ecx,esi
       jg        short M01_L04
       mov       rcx,2130FD511E0
       mov       rcx,[rcx]
       mov       rdx,2132FD5F6E0
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       test      ebx,ebx
       jne       short M01_L05
       mov       rcx,2131FD53020
       mov       rax,[rcx]
       jmp       near ptr M01_L15
M01_L05:
       lea       ebx,[rsi+rbx+0FFFF]
       jmp       short M01_L07
M01_L06:
       inc       esi
M01_L07:
       cmp       esi,ebx
       jg        short M01_L10
       cmp       esi,ebp
       jae       near ptr M01_L16
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L08
       cmp       ecx,100
       jae       near ptr M01_L16
       movsxd    rcx,ecx
       mov       rax,7FFB9B3C3926
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L06
       jmp       short M01_L10
M01_L08:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L06
       jmp       short M01_L10
M01_L09:
       dec       ebx
M01_L10:
       cmp       ebx,esi
       jl        short M01_L12
       cmp       ebx,ebp
       jae       near ptr M01_L16
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L11
       cmp       ecx,100
       jae       short M01_L16
       movsxd    rcx,ecx
       mov       rax,7FFB9B3C3926
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L09
       jmp       short M01_L12
M01_L11:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L09
M01_L12:
       mov       r8d,ebx
       sub       r8d,esi
       inc       r8d
       jne       short M01_L13
       mov       r8,2131FD53020
       mov       rax,[r8]
       jmp       short M01_L15
M01_L13:
       cmp       ebp,r8d
       je        short M01_L14
       mov       rcx,rdi
       mov       edx,esi
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L15
M01_L14:
       mov       rax,rdi
M01_L15:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 419
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      dotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       test      rdi,rdi
       je        short M01_L00
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jne       short M01_L01
M01_L00:
       mov       rax,rdi
       jmp       near ptr M01_L15
M01_L01:
       mov       ecx,esi
       neg       ecx
       shr       ecx,1F
       mov       eax,esi
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L02
       mov       rcx,1E8CEE3F6E0
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L02:
       mov       ecx,ebx
       neg       ecx
       shr       ecx,1F
       mov       eax,ebx
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L03
       mov       rcx,1E8CEE3F588
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L03:
       mov       ebp,[rdi+8]
       mov       ecx,ebp
       sub       ecx,ebx
       cmp       ecx,esi
       jg        short M01_L04
       mov       rcx,1E8DEE311E0
       mov       rcx,[rcx]
       mov       rdx,1E8CEE3F6E0
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       test      ebx,ebx
       jne       short M01_L05
       mov       rcx,1E8BEE33020
       mov       rax,[rcx]
       jmp       near ptr M01_L15
M01_L05:
       lea       ebx,[rsi+rbx+0FFFF]
       jmp       short M01_L07
M01_L06:
       inc       esi
M01_L07:
       cmp       esi,ebx
       jg        short M01_L10
       cmp       esi,ebp
       jae       near ptr M01_L16
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L08
       cmp       ecx,100
       jae       near ptr M01_L16
       movsxd    rcx,ecx
       mov       rax,7FFB9B3C3926
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L06
       jmp       short M01_L10
M01_L08:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L06
       jmp       short M01_L10
M01_L09:
       dec       ebx
M01_L10:
       cmp       ebx,esi
       jl        short M01_L12
       cmp       ebx,ebp
       jae       near ptr M01_L16
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L11
       cmp       ecx,100
       jae       short M01_L16
       movsxd    rcx,ecx
       mov       rax,7FFB9B3C3926
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L09
       jmp       short M01_L12
M01_L11:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L09
M01_L12:
       mov       r8d,ebx
       sub       r8d,esi
       inc       r8d
       jne       short M01_L13
       mov       r8,1E8BEE33020
       mov       rax,[r8]
       jmp       short M01_L15
M01_L13:
       cmp       ebp,r8d
       je        short M01_L14
       mov       rcx,rdi
       mov       edx,esi
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L15
M01_L14:
       mov       rax,rdi
M01_L15:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 419
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      dotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       test      rdi,rdi
       je        short M01_L00
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jne       short M01_L01
M01_L00:
       mov       rax,rdi
       jmp       near ptr M01_L15
M01_L01:
       mov       ecx,esi
       neg       ecx
       shr       ecx,1F
       mov       eax,esi
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L02
       mov       rcx,1FC8DA31778
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L02:
       mov       ecx,ebx
       neg       ecx
       shr       ecx,1F
       mov       eax,ebx
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L03
       mov       rcx,1FC8DA31620
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L03:
       mov       ebp,[rdi+8]
       mov       ecx,ebp
       sub       ecx,ebx
       cmp       ecx,esi
       jg        short M01_L04
       mov       rcx,1FC7DA355E8
       mov       rcx,[rcx]
       mov       rdx,1FC8DA31778
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       test      ebx,ebx
       jne       short M01_L05
       mov       rcx,1FC7DA33020
       mov       rax,[rcx]
       jmp       near ptr M01_L15
M01_L05:
       lea       ebx,[rsi+rbx+0FFFF]
       jmp       short M01_L07
M01_L06:
       inc       esi
M01_L07:
       cmp       esi,ebx
       jg        short M01_L10
       cmp       esi,ebp
       jae       near ptr M01_L16
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L08
       cmp       ecx,100
       jae       near ptr M01_L16
       movsxd    rcx,ecx
       mov       rax,7FFB9B3C3926
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L06
       jmp       short M01_L10
M01_L08:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L06
       jmp       short M01_L10
M01_L09:
       dec       ebx
M01_L10:
       cmp       ebx,esi
       jl        short M01_L12
       cmp       ebx,ebp
       jae       near ptr M01_L16
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L11
       cmp       ecx,100
       jae       short M01_L16
       movsxd    rcx,ecx
       mov       rax,7FFB9B3C3926
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L09
       jmp       short M01_L12
M01_L11:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L09
M01_L12:
       mov       r8d,ebx
       sub       r8d,esi
       inc       r8d
       jne       short M01_L13
       mov       r8,1FC7DA33020
       mov       rax,[r8]
       jmp       short M01_L15
M01_L13:
       cmp       ebp,r8d
       je        short M01_L14
       mov       rcx,rdi
       mov       edx,esi
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L15
M01_L14:
       mov       rax,rdi
M01_L15:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 419
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      dotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       test      rdi,rdi
       je        short M01_L00
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jne       short M01_L01
M01_L00:
       mov       rax,rdi
       jmp       near ptr M01_L15
M01_L01:
       mov       ecx,esi
       neg       ecx
       shr       ecx,1F
       mov       eax,esi
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L02
       mov       rcx,10B3C763770
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L02:
       mov       ecx,ebx
       neg       ecx
       shr       ecx,1F
       mov       eax,ebx
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L03
       mov       rcx,10B3C763618
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L03:
       mov       ebp,[rdi+8]
       mov       ecx,ebp
       sub       ecx,ebx
       cmp       ecx,esi
       jg        short M01_L04
       mov       rcx,10B6C7611E0
       mov       rcx,[rcx]
       mov       rdx,10B3C763770
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       test      ebx,ebx
       jne       short M01_L05
       mov       rcx,10B5C761028
       mov       rax,[rcx]
       jmp       near ptr M01_L15
M01_L05:
       lea       ebx,[rsi+rbx+0FFFF]
       jmp       short M01_L07
M01_L06:
       inc       esi
M01_L07:
       cmp       esi,ebx
       jg        short M01_L10
       cmp       esi,ebp
       jae       near ptr M01_L16
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L08
       cmp       ecx,100
       jae       near ptr M01_L16
       movsxd    rcx,ecx
       mov       rax,7FFB9B3C3926
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L06
       jmp       short M01_L10
M01_L08:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L06
       jmp       short M01_L10
M01_L09:
       dec       ebx
M01_L10:
       cmp       ebx,esi
       jl        short M01_L12
       cmp       ebx,ebp
       jae       near ptr M01_L16
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L11
       cmp       ecx,100
       jae       short M01_L16
       movsxd    rcx,ecx
       mov       rax,7FFB9B3C3926
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L09
       jmp       short M01_L12
M01_L11:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L09
M01_L12:
       mov       r8d,ebx
       sub       r8d,esi
       inc       r8d
       jne       short M01_L13
       mov       r8,10B5C761028
       mov       rax,[r8]
       jmp       short M01_L15
M01_L13:
       cmp       ebp,r8d
       je        short M01_L14
       mov       rcx,rdi
       mov       edx,esi
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L15
M01_L14:
       mov       rax,rdi
M01_L15:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 419
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       edx,19
       mov       r8d,19
       call      dotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,edx
       mov       ebx,r8d
       test      rdi,rdi
       je        short M01_L00
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jne       short M01_L01
M01_L00:
       mov       rax,rdi
       jmp       near ptr M01_L15
M01_L01:
       mov       ecx,esi
       neg       ecx
       shr       ecx,1F
       mov       eax,esi
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L02
       mov       rcx,2DCE9DD1778
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L02:
       mov       ecx,ebx
       neg       ecx
       shr       ecx,1F
       mov       eax,ebx
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       jne       short M01_L03
       mov       rcx,2DCE9DD1620
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L03:
       mov       ebp,[rdi+8]
       mov       ecx,ebp
       sub       ecx,ebx
       cmp       ecx,esi
       jg        short M01_L04
       mov       rcx,2DCD9DD55E8
       mov       rcx,[rcx]
       mov       rdx,2DCE9DD1778
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       test      ebx,ebx
       jne       short M01_L05
       mov       rcx,2DCD9DD3020
       mov       rax,[rcx]
       jmp       near ptr M01_L15
M01_L05:
       lea       ebx,[rsi+rbx+0FFFF]
       jmp       short M01_L07
M01_L06:
       inc       esi
M01_L07:
       cmp       esi,ebx
       jg        short M01_L10
       cmp       esi,ebp
       jae       near ptr M01_L16
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L08
       cmp       ecx,100
       jae       near ptr M01_L16
       movsxd    rcx,ecx
       mov       rax,7FFB9B3C3926
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L06
       jmp       short M01_L10
M01_L08:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L06
       jmp       short M01_L10
M01_L09:
       dec       ebx
M01_L10:
       cmp       ebx,esi
       jl        short M01_L12
       cmp       ebx,ebp
       jae       near ptr M01_L16
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L11
       cmp       ecx,100
       jae       short M01_L16
       movsxd    rcx,ecx
       mov       rax,7FFB9B3C3926
       test      byte ptr [rcx+rax],80
       setne     r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       short M01_L09
       jmp       short M01_L12
M01_L11:
       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       movzx     r14d,al
       test      r14d,r14d
       jne       short M01_L09
M01_L12:
       mov       r8d,ebx
       sub       r8d,esi
       inc       r8d
       jne       short M01_L13
       mov       r8,2DCD9DD3020
       mov       rax,[r8]
       jmp       short M01_L15
M01_L13:
       cmp       ebp,r8d
       je        short M01_L14
       mov       rcx,rdi
       mov       edx,esi
       call      System.String.Substring(Int32, Int32)
       jmp       short M01_L15
M01_L14:
       mov       rax,rdi
M01_L15:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 419
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,20
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       mov       rcx,rax
       mov       rsi,[rsi+10]
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 78
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB3C617650
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L02
       mov       rax,248C7211028
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       lea       edx,[rax+rax*4]
       add       edx,edx
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB3C617660
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB3C617680
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass16_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C508548]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       dec       r8d
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
; Total bytes of code 345
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      rsi,rsi
       je        short M02_L00
       cmp       dword ptr [rsi+8],0
       ja        short M02_L01
M02_L00:
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Globalization.TextInfo.ToTitleCase(System.String)
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,20
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       mov       rcx,rax
       mov       rsi,[rsi+10]
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 78
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB3C5E7AE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L02
       mov       rax,25E4FD83020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       lea       edx,[rax+rax*4]
       add       edx,edx
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB3C5E7AF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB3C5E7B18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass16_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4D8548]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       dec       r8d
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
; Total bytes of code 345
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      rsi,rsi
       je        short M02_L00
       cmp       dword ptr [rsi+8],0
       ja        short M02_L01
M02_L00:
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Globalization.TextInfo.ToTitleCase(System.String)
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,20
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       mov       rcx,rax
       mov       rsi,[rsi+10]
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 78
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB3C607AE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L02
       mov       rax,1C3801A3020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       lea       edx,[rax+rax*4]
       add       edx,edx
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB3C607AF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB3C607B18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass16_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4F8548]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       dec       r8d
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
; Total bytes of code 345
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      rsi,rsi
       je        short M02_L00
       cmp       dword ptr [rsi+8],0
       ja        short M02_L01
M02_L00:
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Globalization.TextInfo.ToTitleCase(System.String)
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,20
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       mov       rcx,rax
       mov       rsi,[rsi+10]
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 78
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB3C617B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L02
       mov       rax,25532523020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       lea       edx,[rax+rax*4]
       add       edx,edx
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB3C617B40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB3C617B60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass16_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C508548]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       dec       r8d
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
; Total bytes of code 345
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      rsi,rsi
       je        short M02_L00
       cmp       dword ptr [rsi+8],0
       ja        short M02_L01
M02_L00:
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Globalization.TextInfo.ToTitleCase(System.String)
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,20
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       mov       rcx,rax
       mov       rsi,[rsi+10]
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 78
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB3C607B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L02
       mov       rax,207E6383020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       lea       edx,[rax+rax*4]
       add       edx,edx
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB3C607B40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB3C607B60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass16_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4F8548]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       dec       r8d
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
; Total bytes of code 345
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      rsi,rsi
       je        short M02_L00
       cmp       dword ptr [rsi+8],0
       ja        short M02_L01
M02_L00:
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Globalization.TextInfo.ToTitleCase(System.String)
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,20
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       mov       rcx,rax
       mov       rsi,[rsi+10]
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 78
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB3C607B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L02
       mov       rax,178659B3020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       lea       edx,[rax+rax*4]
       add       edx,edx
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB3C607B40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB3C607B60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass16_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4E8548]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       dec       r8d
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
; Total bytes of code 345
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      rsi,rsi
       je        short M02_L00
       cmp       dword ptr [rsi+8],0
       ja        short M02_L01
M02_L00:
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Globalization.TextInfo.ToTitleCase(System.String)
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,20
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       mov       rcx,rax
       mov       rsi,[rsi+10]
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 78
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB3C607B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L02
       mov       rax,1EF53CC3020
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       lea       edx,[rax+rax*4]
       add       edx,edx
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB3C607B40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB3C607B60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass16_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFB3C4E8548]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       dec       r8d
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
; Total bytes of code 345
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.ToTitleCase(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      rsi,rsi
       je        short M02_L00
       cmp       dword ptr [rsi+8],0
       ja        short M02_L01
M02_L00:
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Globalization.TextInfo.ToTitleCase(System.String)
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L00
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M01_L00:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L00
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M01_L00:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L00
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M01_L00:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L00
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M01_L00:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L00
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M01_L00:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L00
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M01_L00:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M01_L00
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M01_L00:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,2
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```

