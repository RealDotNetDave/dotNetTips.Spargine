## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntriesCount()
; 			var result = this.CommaDelimitedString.Split(ControlChars.Comma, 2, StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 116
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
       mov       rax,87AC66790362
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
       mov       rcx,87AC66790362
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
       mov       rcx,7FFE59220020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,23AE2388EC8
       mov       rax,[rax]
       mov       rcx,87AC66790362
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
       mov       rcx,7FFE59220020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,23AE2388ED0
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE595323D8]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,87AC66790362
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
       mov       rdx,7FFE59124020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59124020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntriesCount()
; 			var result = this.CommaDelimitedString.Split(ControlChars.Comma, 2, StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 116
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
       mov       rax,0B052C87192EA
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
       mov       rcx,0B052C87192EA
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
       mov       rcx,7FFE59230020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,1E8C20E8EC8
       mov       rax,[rax]
       mov       rcx,0B052C87192EA
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
       mov       rcx,7FFE59230020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1E8C20E8ED0
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE595426D0]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,0B052C87192EA
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
       mov       rdx,7FFE59134020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59134020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntriesCount()
; 			var result = this.CommaDelimitedString.Split(ControlChars.Comma, 2, StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 116
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
       mov       rax,9DA8328F4B45
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
       mov       rcx,9DA8328F4B45
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
       mov       rcx,7FFE59220020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,1D0B9E24A60
       mov       rax,[rax]
       mov       rcx,9DA8328F4B45
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
       mov       rcx,7FFE59220020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1D0B9E24A68
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE595326D0]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,9DA8328F4B45
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
       mov       rdx,7FFE59124020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59124020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntriesCount()
; 			var result = this.CommaDelimitedString.Split(ControlChars.Comma, 2, StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 116
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
       mov       rax,0DDF8CB1B3B48
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
       mov       rcx,0DDF8CB1B3B48
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
       mov       rcx,7FFE59210020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,2625E876A78
       mov       rax,[rax]
       mov       rcx,0DDF8CB1B3B48
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
       mov       rcx,7FFE59210020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2625E876A80
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE595226D0]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,0DDF8CB1B3B48
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
       mov       rdx,7FFE59114020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59114020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntriesCount()
; 			var result = this.CommaDelimitedString.Split(ControlChars.Comma, 2, StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 116
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
       mov       rax,75C0DB15914C
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
       mov       rcx,75C0DB15914C
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
       mov       rcx,7FFE59210020
       mov       edx,29
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,2C948718ED8
       mov       rax,[rax]
       mov       rcx,75C0DB15914C
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
       mov       rcx,2C948718EC8
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FFE5951FCD8]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,75C0DB15914C
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
       mov       rdx,7FFE59114020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59114020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntriesCount()
; 			var result = this.CommaDelimitedString.Split(ControlChars.Comma, 2, StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 116
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
       mov       rax,36A6497E7DB7
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
       mov       rcx,36A6497E7DB7
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
       mov       rcx,7FFE59240020
       mov       edx,2A
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,1DEE7D16A90
       mov       rax,[rax]
       mov       rcx,36A6497E7DB7
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
       mov       rcx,1DEE7D16A78
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FFE5954FCD8]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,36A6497E7DB7
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
       mov       rdx,7FFE59144020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59144020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntriesCount()
; 			var result = this.CommaDelimitedString.Split(ControlChars.Comma, 2, StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 116
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
       mov       rax,78BCC7A3F9F5
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
       mov       rcx,78BCC7A3F9F5
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
       mov       rcx,7FFE59240020
       mov       edx,2A
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,296F3764A78
       mov       rax,[rax]
       mov       rcx,78BCC7A3F9F5
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
       mov       rcx,296F3764A60
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FFE5954FCD8]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,78BCC7A3F9F5
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
       mov       rdx,7FFE59144020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59144020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorCount01()
; 			var result = this.CommaDelimitedString.Split(ControlChars.Comma, 2, StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 113
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
       mov       rax,86297DAB9EA7
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
       mov       rcx,86297DAB9EA7
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
       mov       rcx,7FFE59230020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,24D441F6A78
       mov       rax,[rax]
       mov       rcx,86297DAB9EA7
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
       mov       rcx,7FFE59230020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,24D441F6A80
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE59541B28]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,86297DAB9EA7
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
       mov       rdx,7FFE59134020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59134020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorCount01()
; 			var result = this.CommaDelimitedString.Split(ControlChars.Comma, 2, StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 113
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
       mov       rax,0AEF5A01557B4
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
       mov       rcx,0AEF5A01557B4
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
       mov       rcx,7FFE59240020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,1B7F94D4A60
       mov       rax,[rax]
       mov       rcx,0AEF5A01557B4
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
       mov       rcx,7FFE59240020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1B7F94D4A68
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE59551E20]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,0AEF5A01557B4
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
       mov       rdx,7FFE59144020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59144020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorCount01()
; 			var result = this.CommaDelimitedString.Split(ControlChars.Comma, 2, StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 113
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
       mov       rax,87BD928BC759
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
       mov       rcx,87BD928BC759
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
       mov       rcx,7FFE59220020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,13FD60F6EB0
       mov       rax,[rax]
       mov       rcx,87BD928BC759
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
       mov       rcx,7FFE59220020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,13FD60F6EB8
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE59531B28]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,87BD928BC759
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
       mov       rdx,7FFE59124020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59124020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorCount01()
; 			var result = this.CommaDelimitedString.Split(ControlChars.Comma, 2, StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 113
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
       mov       rax,42700B8431E9
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
       mov       rcx,42700B8431E9
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
       mov       rcx,7FFE59230020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,235EA096A78
       mov       rax,[rax]
       mov       rcx,42700B8431E9
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
       mov       rcx,7FFE59230020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,235EA096A80
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE59541B28]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,42700B8431E9
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
       mov       rdx,7FFE59134020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59134020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorCount01()
; 			var result = this.CommaDelimitedString.Split(ControlChars.Comma, 2, StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 113
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
       mov       rax,0ADB615EBCB3D
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
       mov       rcx,0ADB615EBCB3D
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
       mov       rcx,7FFE59240020
       mov       edx,29
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,28C0B0E8ED8
       mov       rax,[rax]
       mov       rcx,0ADB615EBCB3D
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
       mov       rcx,28C0B0E8EC8
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FFE5954FCD8]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,0ADB615EBCB3D
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
       mov       rdx,7FFE59144020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59144020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorCount01()
; 			var result = this.CommaDelimitedString.Split(ControlChars.Comma, 2, StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 113
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
       mov       rax,46DF20996359
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
       mov       rcx,46DF20996359
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
       mov       rcx,7FFE59220020
       mov       edx,2A
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,2555B0A6A90
       mov       rax,[rax]
       mov       rcx,46DF20996359
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
       mov       rcx,2555B0A6A78
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FFE5952FCD8]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,46DF20996359
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
       mov       rdx,7FFE59124020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59124020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorCount01()
; 			var result = this.CommaDelimitedString.Split(ControlChars.Comma, 2, StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 113
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
       mov       rax,6D72152E019C
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
       mov       rcx,6D72152E019C
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
       mov       rcx,7FFE59230020
       mov       edx,2A
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,2D6BEF58EE0
       mov       rax,[rax]
       mov       rcx,6D72152E019C
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
       mov       rcx,2D6BEF58EC8
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FFE5953FCD8]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,6D72152E019C
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
       mov       rdx,7FFE59134020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59134020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntries()
; 			var result = this.CommaDelimitedString.Split(ControlChars.Comma, StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 116
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
       mov       rax,0BD328BDCCCA2
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
       mov       rcx,0BD328BDCCCA2
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
       mov       rcx,7FFE59230020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,23C28A78EC8
       mov       rax,[rax]
       mov       rcx,0BD328BDCCCA2
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
       mov       rcx,7FFE59230020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,23C28A78ED0
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE595423D8]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,0BD328BDCCCA2
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
       mov       rdx,7FFE59134020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59134020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntries()
; 			var result = this.CommaDelimitedString.Split(ControlChars.Comma, StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 116
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
       mov       rax,5B8FACDDEBC6
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
       mov       rcx,5B8FACDDEBC6
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
       mov       rcx,7FFE59230020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,240E87E8EC8
       mov       rax,[rax]
       mov       rcx,5B8FACDDEBC6
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
       mov       rcx,7FFE59230020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,240E87E8ED0
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE595423D8]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,5B8FACDDEBC6
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
       mov       rdx,7FFE59134020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59134020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntries()
; 			var result = this.CommaDelimitedString.Split(ControlChars.Comma, StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 116
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
       mov       rax,4D1D0AF70089
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
       mov       rcx,4D1D0AF70089
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
       mov       rcx,7FFE59220020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,1EE762F6A78
       mov       rax,[rax]
       mov       rcx,4D1D0AF70089
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
       mov       rcx,7FFE59220020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1EE762F6A80
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE595326D0]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,4D1D0AF70089
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
       mov       rdx,7FFE59124020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59124020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntries()
; 			var result = this.CommaDelimitedString.Split(ControlChars.Comma, StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 116
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
       mov       rax,468EB17DA0E2
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
       mov       rcx,468EB17DA0E2
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
       mov       rcx,7FFE59230020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,222704C4A60
       mov       rax,[rax]
       mov       rcx,468EB17DA0E2
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
       mov       rcx,7FFE59230020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,222704C4A68
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE595423D8]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,468EB17DA0E2
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
       mov       rdx,7FFE59134020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59134020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntries()
; 			var result = this.CommaDelimitedString.Split(ControlChars.Comma, StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 116
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
       mov       rax,0F859777EAF12
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
       mov       rcx,0F859777EAF12
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
       mov       rcx,7FFE59220020
       mov       edx,29
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,2C6A4D56A88
       mov       rax,[rax]
       mov       rcx,0F859777EAF12
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
       mov       rcx,2C6A4D56A78
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FFE5952FCD8]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,0F859777EAF12
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
       mov       rdx,7FFE59124020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59124020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntries()
; 			var result = this.CommaDelimitedString.Split(ControlChars.Comma, StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 116
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
       mov       rax,78FC9514946F
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
       mov       rcx,78FC9514946F
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
       mov       rcx,7FFE59240020
       mov       edx,2A
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,212FAC76A90
       mov       rax,[rax]
       mov       rcx,78FC9514946F
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
       mov       rcx,212FAC76A78
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FFE5954F5D8]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,78FC9514946F
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
       mov       rdx,7FFE59144020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59144020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparatorRemoveEmptyEntries()
; 			var result = this.CommaDelimitedString.Split(ControlChars.Comma, StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 116
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
       mov       rax,0AE01A9699307
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
       mov       rcx,0AE01A9699307
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
       mov       rcx,7FFE59210020
       mov       edx,2A
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,29FFDFC4A78
       mov       rax,[rax]
       mov       rcx,0AE01A9699307
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
       mov       rcx,29FFDFC4A60
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FFE5951FCD8]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,0AE01A9699307
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
       mov       rdx,7FFE59114020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59114020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator01()
; 			var result = this.CommaDelimitedString.Split(StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 62
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
       mov       r8,127E25F3060
       mov       r8,[r8]
       mov       rdx,127E25F96B0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       rcx,rax
       mov       rdx,127F25F9170
       mov       rdx,[rdx]
       mov       r8,127E25F3060
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator01()
; 			var result = this.CommaDelimitedString.Split(StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 62
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
       mov       r8,26B7C703060
       mov       r8,[r8]
       mov       rdx,26B7C7036A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       rcx,rax
       mov       rdx,26B8C7011B8
       mov       rdx,[rdx]
       mov       r8,26B7C703060
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator01()
; 			var result = this.CommaDelimitedString.Split(StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 62
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
       mov       r8,1EDFF8F3060
       mov       r8,[r8]
       mov       rdx,1EDDF8FD200
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       rcx,rax
       mov       rdx,1EDDF8FD9A0
       mov       rdx,[rdx]
       mov       r8,1EDFF8F3060
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator01()
; 			var result = this.CommaDelimitedString.Split(StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 62
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
       mov       r8,22A43A23060
       mov       r8,[r8]
       mov       rdx,22A23A21250
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       rcx,rax
       mov       rdx,22A43A315D0
       mov       rdx,[rdx]
       mov       r8,22A43A23060
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator01()
; 			var result = this.CommaDelimitedString.Split(StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 62
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
       mov       r8,1C30C1E3060
       mov       r8,[r8]
       mov       rdx,1C2EC1E9208
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       rcx,rax
       mov       rdx,1C30C1E9618
       mov       rdx,[rdx]
       mov       r8,1C30C1E3060
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator01()
; 			var result = this.CommaDelimitedString.Split(StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 62
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
       mov       r8,1B890241048
       mov       r8,[r8]
       mov       rdx,1B870243268
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       rcx,rax
       mov       rdx,1B870243A08
       mov       rdx,[rdx]
       mov       r8,1B890241048
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator01()
; 			var result = this.CommaDelimitedString.Split(StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 62
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
       mov       r8,2DFF4C41048
       mov       r8,[r8]
       mov       rdx,2DFD4C43268
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       rcx,rax
       mov       rdx,2E004CBE1F0
       mov       rdx,[rdx]
       mov       r8,2DFF4C41048
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntriesCount()
; 			var result = this.CommaDelimitedString.Split(",", 2, StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,26D74F43198
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,26D74F43060
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
; Total bytes of code 104
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
       mov       rax,60543BF382AD
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
       mov       rcx,7FFE59210020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,26D64F44A60
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
       mov       rcx,7FFE59210020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,26D64F44A68
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE595223D8]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFE59210020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,26D64F44A68
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE595223D8]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,60543BF382AD
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
       mov       rdx,7FFE59114020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59114020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntriesCount()
; 			var result = this.CommaDelimitedString.Split(",", 2, StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,16926AD3198
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,16926AD3060
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
; Total bytes of code 104
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
       mov       rax,5AF3CDAE7401
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
       mov       rcx,7FFE59230020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,16926AD8EC8
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
       mov       rcx,7FFE59230020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,16926AD8ED0
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE595423D8]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFE59230020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,16926AD8ED0
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE595423D8]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,5AF3CDAE7401
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
       mov       rdx,7FFE59134020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59134020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntriesCount()
; 			var result = this.CommaDelimitedString.Split(",", 2, StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1C161BB3198
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1C161BB3060
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
; Total bytes of code 104
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
       mov       rax,75C9DDB8005
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
       mov       rcx,7FFE59210020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1C141BB4A60
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
       mov       rcx,7FFE59210020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1C141BB4A68
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE595226D0]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFE59210020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1C141BB4A68
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE595226D0]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,75C9DDB8005
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
       mov       rdx,7FFE59114020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59114020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntriesCount()
; 			var result = this.CommaDelimitedString.Split(",", 2, StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,26A6AE03198
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,26A6AE03060
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
; Total bytes of code 104
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
       mov       rax,35DA9B330DB6
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
       mov       rcx,7FFE59210020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,26A6AE08EC8
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
       mov       rcx,7FFE59210020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,26A6AE08ED0
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE59522B60]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFE59210020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,26A6AE08ED0
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE59522B60]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,35DA9B330DB6
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
       mov       rdx,7FFE59114020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59114020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntriesCount()
; 			var result = this.CommaDelimitedString.Split(",", 2, StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1EE4E0F3198
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1EE4E0F3060
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
; Total bytes of code 104
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
       mov       rax,0DA5A581942D0
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
       mov       rcx,7FFE59210020
       mov       edx,29
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1EE6E0F6A88
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
       mov       rcx,1EE6E0F6A78
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FFE5951FCD8]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,1EE6E0F6A78
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FFE5951FCD8]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0DA5A581942D0
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
       mov       rdx,7FFE59114020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59114020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntriesCount()
; 			var result = this.CommaDelimitedString.Split(",", 2, StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1DBC9F43198
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1DBC9F43060
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
; Total bytes of code 104
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
       mov       rax,9B50287D50E2
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
       mov       rcx,7FFE59240020
       mov       edx,2A
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1DBC9F48EE0
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
       mov       rcx,1DBC9F48EC8
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FFE5954FCD8]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,1DBC9F48EC8
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FFE5954FCD8]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,9B50287D50E2
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
       mov       rdx,7FFE59144020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59144020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntriesCount()
; 			var result = this.CommaDelimitedString.Split(",", 2, StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,2704D611180
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,2704D611048
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
; Total bytes of code 104
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
       mov       rax,0E044C1345B1D
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
       mov       rcx,7FFE59210020
       mov       edx,2A
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2704D616EC8
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
       mov       rcx,2704D616EB0
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FFE5951FCD8]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,2704D616EB0
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FFE5951FCD8]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0E044C1345B1D
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
       mov       rdx,7FFE59114020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59114020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorCount()
; 			var result = this.CommaDelimitedString.Split(",", 2, StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,28FFECF3198
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,28FFECF3060
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
; Total bytes of code 101
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
       mov       rax,7462D0489296
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
       mov       rcx,7FFE59230020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2900ECF6A78
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
       mov       rcx,7FFE59230020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2900ECF6A80
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE59541B28]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFE59230020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2900ECF6A80
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE59541B28]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,7462D0489296
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
       mov       rdx,7FFE59134020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59134020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorCount()
; 			var result = this.CommaDelimitedString.Split(",", 2, StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1A884843198
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1A884843060
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
; Total bytes of code 101
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
       mov       rax,0BA3F57E12DF4
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
       mov       rcx,7FFE59220020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1A8A4846A78
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
       mov       rcx,7FFE59220020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1A8A4846A80
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE59531B28]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFE59220020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1A8A4846A80
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE59531B28]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0BA3F57E12DF4
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
       mov       rdx,7FFE59124020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59124020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorCount()
; 			var result = this.CommaDelimitedString.Split(",", 2, StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,162455A3198
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,162455A3060
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
; Total bytes of code 101
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
       mov       rax,0DF92C261D3D3
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
       mov       rcx,7FFE59210020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,162355A4A60
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
       mov       rcx,7FFE59210020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,162355A4A68
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE59521E20]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFE59210020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,162355A4A68
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE59521E20]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0DF92C261D3D3
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
       mov       rdx,7FFE59114020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59114020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorCount()
; 			var result = this.CommaDelimitedString.Split(",", 2, StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,278EE9C3198
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,278EE9C3060
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
; Total bytes of code 101
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
       mov       rax,823C7AFFE42C
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
       mov       rcx,7FFE59220020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,278FE9C6A78
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
       mov       rcx,7FFE59220020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,278FE9C6A80
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE59531B28]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFE59220020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,278FE9C6A80
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE59531B28]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,823C7AFFE42C
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
       mov       rdx,7FFE59124020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59124020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorCount()
; 			var result = this.CommaDelimitedString.Split(",", 2, StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,2C1B15F3198
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,2C1B15F3060
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
; Total bytes of code 101
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
       mov       rax,0A913A4C748AB
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
       mov       rcx,7FFE59210020
       mov       edx,29
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2C1D15F6A88
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
       mov       rcx,2C1D15F6A78
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FFE5951FCD8]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,2C1D15F6A78
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FFE5951FCD8]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0A913A4C748AB
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
       mov       rdx,7FFE59114020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59114020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorCount()
; 			var result = this.CommaDelimitedString.Split(",", 2, StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,16E3E623198
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,16E3E623060
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
; Total bytes of code 101
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
       mov       rax,0DE4010F5530D
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
       mov       rcx,7FFE59240020
       mov       edx,2A
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,16E5E624A78
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
       mov       rcx,16E5E624A60
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FFE5954F5D8]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,16E5E624A60
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FFE5954F5D8]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0DE4010F5530D
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
       mov       rdx,7FFE59144020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59144020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorCount()
; 			var result = this.CommaDelimitedString.Split(",", 2, StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1C358A63198
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1C358A63060
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
; Total bytes of code 101
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
       mov       rax,44F5AC69F0C1
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
       mov       rcx,7FFE59210020
       mov       edx,2A
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1C358A66EC8
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
       mov       rcx,1C358A66EB0
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FFE5951F5D8]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,1C358A66EB0
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FFE5951F5D8]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,44F5AC69F0C1
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
       mov       rdx,7FFE59114020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59114020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntries()
; 			var result = this.CommaDelimitedString.Split(",", StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,171FFFE3198
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,171FFFE3060
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
; Total bytes of code 104
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
       mov       rax,0E75485B477E3
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
       mov       rcx,7FFE59240020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1722FFE4A60
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
       mov       rcx,7FFE59240020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1722FFE4A68
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE595526D0]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFE59240020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1722FFE4A68
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE595526D0]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0E75485B477E3
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
       mov       rdx,7FFE59144020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59144020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntries()
; 			var result = this.CommaDelimitedString.Split(",", StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1F2DD393198
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1F2DD393060
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
; Total bytes of code 104
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
       mov       rax,9B3D57F8A3FE
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
       mov       rcx,7FFE59220020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1F2FD396A78
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
       mov       rcx,7FFE59220020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1F2FD396A80
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE595323D8]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFE59220020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1F2FD396A80
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE595323D8]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,9B3D57F8A3FE
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
       mov       rdx,7FFE59124020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59124020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntries()
; 			var result = this.CommaDelimitedString.Split(",", StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,160528B3198
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,160528B3060
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
; Total bytes of code 104
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
       mov       rax,0B7465E7E4912
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
       mov       rcx,7FFE59240020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,160528B8EC8
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
       mov       rcx,7FFE59240020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,160528B8ED0
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE595523D8]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFE59240020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,160528B8ED0
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE595523D8]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0B7465E7E4912
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
       mov       rdx,7FFE59144020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59144020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntries()
; 			var result = this.CommaDelimitedString.Split(",", StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,165BDD73198
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,165BDD73060
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
; Total bytes of code 104
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
       mov       rax,37383D3148F5
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
       mov       rcx,7FFE59210020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,165CDD76A78
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
       mov       rcx,7FFE59210020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,165CDD76A80
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE595226D0]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFE59210020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,165CDD76A80
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE595226D0]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,37383D3148F5
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
       mov       rdx,7FFE59114020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59114020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntries()
; 			var result = this.CommaDelimitedString.Split(",", StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,256D12E3198
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,256D12E3060
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
; Total bytes of code 104
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
       mov       rax,328DC7B6E92C
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
       mov       rcx,7FFE59230020
       mov       edx,29
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,256C12E4A70
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
       mov       rcx,256C12E4A60
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FFE5953FCD8]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,256C12E4A60
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FFE5953FCD8]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,328DC7B6E92C
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
       mov       rdx,7FFE59134020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59134020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntries()
; 			var result = this.CommaDelimitedString.Split(",", StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1830A103198
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1830A103060
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
; Total bytes of code 104
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
       mov       rax,0F9C79C5BA0A0
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
       mov       rcx,7FFE59230020
       mov       edx,2A
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,182FA106A90
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
       mov       rcx,182FA106A78
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FFE5953FCD8]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,182FA106A78
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FFE5953FCD8]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0F9C79C5BA0A0
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
       mov       rdx,7FFE59134020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59134020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparatorRemoveEmptyEntries()
; 			var result = this.CommaDelimitedString.Split(",", StringSplitOptions.RemoveEmptyEntries);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,28DC5963198
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,28DC5963060
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
; Total bytes of code 104
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
       mov       rax,3B2D33E5B46F
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
       mov       rcx,7FFE59210020
       mov       edx,2A
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,28DE5966A90
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
       mov       rcx,28DE5966A78
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FFE5951F8D8]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,28DE5966A78
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FFE5951F8D8]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,3B2D33E5B46F
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
       mov       rdx,7FFE59114020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59114020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparator()
; 			var result = this.CommaDelimitedString.Split(",", StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,22C4F813198
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,22C4F813060
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
; Total bytes of code 101
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
       mov       rax,0B1881CE4BCE0
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
       mov       rcx,7FFE59240020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,22C3F814A60
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
       mov       rcx,7FFE59240020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,22C3F814A68
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE59551B28]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFE59240020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,22C3F814A68
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE59551B28]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0B1881CE4BCE0
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
       mov       rdx,7FFE59144020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59144020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparator()
; 			var result = this.CommaDelimitedString.Split(",", StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,23753933198
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,23753933060
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
; Total bytes of code 101
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
       mov       rax,9783992A2C47
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
       mov       rcx,7FFE59210020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,23753938EC8
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
       mov       rcx,7FFE59210020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,23753938ED0
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE59521E20]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFE59210020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,23753938ED0
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE59521E20]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,9783992A2C47
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
       mov       rdx,7FFE59114020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59114020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparator()
; 			var result = this.CommaDelimitedString.Split(",", StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1F644DA3198
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1F644DA3060
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
; Total bytes of code 101
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
       mov       rax,31298C9D6A44
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
       mov       rcx,7FFE59220020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1F634DA4A60
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
       mov       rcx,7FFE59220020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1F634DA4A68
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE59531B28]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFE59220020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1F634DA4A68
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE59531B28]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,31298C9D6A44
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
       mov       rdx,7FFE59124020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59124020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparator()
; 			var result = this.CommaDelimitedString.Split(",", StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1A7FFB63198
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1A7FFB63060
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
; Total bytes of code 101
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
       mov       rax,824219DA49DC
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
       mov       rcx,7FFE59230020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1A81FB66A78
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
       mov       rcx,7FFE59230020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1A81FB66A80
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE59541B28]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FFE59230020
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1A81FB66A80
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE59541B28]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,824219DA49DC
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
       mov       rdx,7FFE59134020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59134020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparator()
; 			var result = this.CommaDelimitedString.Split(",", StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1DDA8C21180
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1DDA8C21048
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
; Total bytes of code 101
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
       mov       rax,0CA1793C7090B
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
       mov       rcx,7FFE59210020
       mov       edx,29
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1DDA8C26EC0
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
       mov       rcx,1DDA8C26EB0
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FFE5951FCD8]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,1DDA8C26EB0
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FFE5951FCD8]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0CA1793C7090B
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
       mov       rdx,7FFE59114020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59114020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparator()
; 			var result = this.CommaDelimitedString.Split(",", StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1C974103198
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1C974103060
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
; Total bytes of code 101
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
       mov       rax,0C7D3D1635D57
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
       mov       rcx,7FFE59210020
       mov       edx,2A
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1C974108EE0
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
       mov       rcx,1C974108EC8
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FFE5951FCD8]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,1C974108EC8
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FFE5951FCD8]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0C7D3D1635D57
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
       mov       rdx,7FFE59114020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59114020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitStringSeparator()
; 			var result = this.CommaDelimitedString.Split(",", StringSplitOptions.None);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,205A7793198
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,205A7793060
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
; Total bytes of code 101
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
       mov       rax,0B1F440CCBFA9
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
       mov       rcx,7FFE59240020
       mov       edx,2A
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,205C7796A90
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
       mov       rcx,205C7796A78
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FFE5954F8D8]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,205C7796A78
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FFE5954F8D8]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0B1F440CCBFA9
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
       mov       rdx,7FFE59144020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FFE59144020
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
; 			var result = this.StringToTrim.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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
       mov       r8,2624BC03060
       mov       r8,[r8]
       mov       rdx,2627BC011B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFD8],rdi
       mov       rcx,2624BC01AF8
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE59520D98]
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
       mov       rax,2624BC01528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,2627BC011C0
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
       call      qword ptr [7FFE59518548]
       mov       rbx,rax
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFE59520308]
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
       call      qword ptr [7FFE59520308]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
; 			var result = this.StringToTrim.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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
       mov       r8,1C78B093060
       mov       r8,[r8]
       mov       rdx,1C78B095E58
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFD8],rdi
       mov       rcx,1C78B091AF8
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE59510D98]
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
       mov       rax,1C78B091528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1C78B095E60
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
       call      qword ptr [7FFE59508548]
       mov       rbx,rax
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFE59510308]
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
       call      qword ptr [7FFE59510308]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
; 			var result = this.StringToTrim.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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
       mov       r8,253E3C43060
       mov       r8,[r8]
       mov       rdx,25403C4F180
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFD8],rdi
       mov       rcx,253E3C41AF8
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE59520D98]
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
       mov       rax,253E3C41528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,25403C4F188
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
       call      qword ptr [7FFE59518548]
       mov       rbx,rax
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFE59520610]
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
       call      qword ptr [7FFE59520610]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
; 			var result = this.StringToTrim.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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
       mov       r8,2E3D5D33060
       mov       r8,[r8]
       mov       rdx,2E3E5D311B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFD8],rdi
       mov       rcx,2E3D5D31AF8
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE59520D98]
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
       mov       rax,2E3D5D31528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,2E3E5D311C0
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
       call      qword ptr [7FFE59518548]
       mov       rbx,rax
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFE59520B80]
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
       call      qword ptr [7FFE59520B80]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
; 			var result = this.StringToTrim.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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
       mov       r8,1ADBC273060
       mov       r8,[r8]
       mov       rdx,1ADAC2719F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFD8],rdi
       mov       rcx,1ADBC271AF8
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE59520D98]
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
       mov       rax,1ADBC271528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1ADAC2719F8
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
       call      qword ptr [7FFE59518548]
       mov       rbx,rax
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFE59520610]
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
       call      qword ptr [7FFE59520610]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
; 			var result = this.StringToTrim.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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
       mov       r8,2D503D63060
       mov       r8,[r8]
       mov       rdx,2D4F3D619F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFD8],rdi
       mov       rcx,2D503D61AF8
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE59550D98]
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
       mov       rax,2D503D61528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,2D4F3D619F8
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
       call      qword ptr [7FFE59548548]
       mov       rbx,rax
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFE59550B80]
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
       call      qword ptr [7FFE59550B80]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ComputeMD5Hash()
; 			var result = this.StringToTrim.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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
       mov       r8,2507D7D3060
       mov       r8,[r8]
       mov       rdx,2508D7D11B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFD8],rdi
       mov       rcx,2507D7D1AF8
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE59530D98]
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
       mov       rax,2507D7D1528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,2508D7D11C0
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
       call      qword ptr [7FFE59528548]
       mov       rbx,rax
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFE59530308]
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
       call      qword ptr [7FFE59530308]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
; 			var result = this.StringToTrim.Concat(",", Tristate.True, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       mov       rcx,1C6D3BA3198
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
       mov       r8,1C6D3BA3060
       mov       r8,[r8]
       mov       rdx,1C6B3BA1250
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
       mov       rax,[7FFE59538548]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
; 			var result = this.StringToTrim.Concat(",", Tristate.True, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       mov       rcx,18867AF3198
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
       mov       r8,18867AF3060
       mov       r8,[r8]
       mov       rdx,18847AF1250
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
       mov       rax,[7FFE59518548]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
; 			var result = this.StringToTrim.Concat(",", Tristate.True, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       mov       rcx,2931C1A3198
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
       mov       r8,2931C1A3060
       mov       r8,[r8]
       mov       rdx,2931C1AF650
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
       mov       rax,[7FFE59528548]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
; 			var result = this.StringToTrim.Concat(",", Tristate.True, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       mov       rcx,18F6D623198
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
       mov       r8,18F6D623060
       mov       r8,[r8]
       mov       rdx,18F4D621250
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
       mov       rax,[7FFE59548548]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
; 			var result = this.StringToTrim.Concat(",", Tristate.True, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       mov       rcx,292C9B53198
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
       mov       r8,292C9B53060
       mov       r8,[r8]
       mov       rdx,292E9B5F218
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
       mov       rax,[7FFE59528548]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
; 			var result = this.StringToTrim.Concat(",", Tristate.True, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       mov       rcx,2354AD93198
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
       mov       r8,2354AD93060
       mov       r8,[r8]
       mov       rdx,2355AD91250
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
       mov       rax,[7FFE59538548]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Concat01()
; 			var result = this.StringToTrim.Concat(",", Tristate.True, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       mov       rcx,1A760E33198
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
       mov       r8,1A760E33060
       mov       r8,[r8]
       mov       rdx,1A740E31250
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
       mov       rax,[7FFE59548548]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator02()
; 			var result = StringBuilderHelper.ConcatToString(this.CommaDelimitedString, ",", Tristate.True, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rdi,rax
       mov       rcx,21816773198
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 99
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
       mov       r8,21816773060
       mov       r8,[r8]
       mov       rdx,21826771250
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,7FFE59594C88
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,218067775A0
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
       call      qword ptr [7FFE59538548]
       mov       rsi,rax
       mov       rcx,218067775A0
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
       mov       rcx,7FFE59594C88
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,218067775A0
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator02()
; 			var result = StringBuilderHelper.ConcatToString(this.CommaDelimitedString, ",", Tristate.True, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rdi,rax
       mov       rcx,28B90033198
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 99
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
       mov       r8,28B90033060
       mov       r8,[r8]
       mov       rdx,28B70031250
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,7FFE595A4C88
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,28B9003BA08
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
       call      qword ptr [7FFE59548548]
       mov       rsi,rax
       mov       rcx,28B9003BA08
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
       mov       rcx,7FFE595A4C88
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,28B9003BA08
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator02()
; 			var result = StringBuilderHelper.ConcatToString(this.CommaDelimitedString, ",", Tristate.True, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rdi,rax
       mov       rcx,1CE4DCF3198
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 99
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
       mov       r8,1CE4DCF3060
       mov       r8,[r8]
       mov       rdx,1CE4DCF36A0
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,7FFE59594C88
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1CE6DCF95B8
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
       call      qword ptr [7FFE59538548]
       mov       rsi,rax
       mov       rcx,1CE6DCF95B8
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
       mov       rcx,7FFE59594C88
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1CE6DCF95B8
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator02()
; 			var result = StringBuilderHelper.ConcatToString(this.CommaDelimitedString, ",", Tristate.True, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rdi,rax
       mov       rcx,20224EF3198
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 99
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
       mov       r8,20224EF3060
       mov       r8,[r8]
       mov       rdx,20234EF1250
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,7FFE59584C88
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,20204EF75A0
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
       call      qword ptr [7FFE59528548]
       mov       rsi,rax
       mov       rcx,20204EF75A0
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
       mov       rcx,7FFE59584C88
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,20204EF75A0
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator02()
; 			var result = StringBuilderHelper.ConcatToString(this.CommaDelimitedString, ",", Tristate.True, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rdi,rax
       mov       rcx,1FD05F93198
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 99
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
       mov       r8,1FD05F93060
       mov       r8,[r8]
       mov       rdx,1FD05F936A0
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,7FFE595A4C88
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FD25F995B8
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
       call      qword ptr [7FFE59548548]
       mov       rsi,rax
       mov       rcx,1FD25F995B8
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
       mov       rcx,7FFE595A4C88
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FD25F995B8
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator02()
; 			var result = StringBuilderHelper.ConcatToString(this.CommaDelimitedString, ",", Tristate.True, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rdi,rax
       mov       rcx,2420D4A3198
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 99
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
       mov       r8,2420D4A3060
       mov       r8,[r8]
       mov       rdx,241ED4A1250
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,7FFE59584C88
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2420D4ABA08
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
       call      qword ptr [7FFE59528548]
       mov       rsi,rax
       mov       rcx,2420D4ABA08
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
       mov       rcx,7FFE59584C88
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2420D4ABA08
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SplitCharSeparator02()
; 			var result = StringBuilderHelper.ConcatToString(this.CommaDelimitedString, ",", Tristate.True, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rdi,rax
       mov       rcx,20786253198
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 99
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
       mov       r8,20786253060
       mov       r8,[r8]
       mov       rdx,207862556B8
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,7FFE59574C88
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,207762575A0
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
       call      qword ptr [7FFE59518548]
       mov       rsi,rax
       mov       rcx,207762575A0
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
       mov       rcx,7FFE59574C88
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,207762575A0
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
; 			var result = this.StringToTrim.ContainsAny("A", "Z");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,216BD093608
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,216BD093610
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
; 			var result = this.StringToTrim.ContainsAny("A", "Z");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,233D2CC11B8
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,233D2CC11C0
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
; 			var result = this.StringToTrim.ContainsAny("A", "Z");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,208079831D0
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,208079831D8
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
; 			var result = this.StringToTrim.ContainsAny("A", "Z");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,26CD7E119F0
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,26CD7E119F8
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
; 			var result = this.StringToTrim.ContainsAny("A", "Z");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,1F587F7EDF0
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,1F587F7EDF8
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
; 			var result = this.StringToTrim.ContainsAny("A", "Z");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,15D1AB13A08
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,15D1AB13A10
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ContainsAny()
; 			var result = this.StringToTrim.ContainsAny("A", "Z");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,1CAC16811B8
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,1CAC16811C0
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
; 			var result = this.StringToTrim.DefaultIfNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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
       mov       rcx,275A2413060
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
; 			var result = this.StringToTrim.DefaultIfNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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
       mov       rcx,2D623733060
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
; 			var result = this.StringToTrim.DefaultIfNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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
       mov       rcx,20C8B243060
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
; 			var result = this.StringToTrim.DefaultIfNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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
       mov       rcx,2CD6B543060
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
; 			var result = this.StringToTrim.DefaultIfNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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
       mov       rcx,20563D71048
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
; 			var result = this.StringToTrim.DefaultIfNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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
       mov       rcx,243285F3060
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNull()
; 			var result = this.StringToTrim.DefaultIfNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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
       mov       rcx,23E09641048
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
; 			var result = this.StringToTrim.DefaultIfNullOrEmpty("David");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       rdx,2193CFCD168
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
; 			var result = this.StringToTrim.DefaultIfNullOrEmpty("David");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       rdx,252BE3111B8
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
; 			var result = this.StringToTrim.DefaultIfNullOrEmpty("David");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       rdx,1C30EE131D0
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
; 			var result = this.StringToTrim.DefaultIfNullOrEmpty("David");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       rdx,2872FAE11B8
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
; 			var result = this.StringToTrim.DefaultIfNullOrEmpty("David");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       rdx,236A39011B8
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
; 			var result = this.StringToTrim.DefaultIfNullOrEmpty("David");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       rdx,201805CB9A0
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DefaultIfNullOrEmpty()
; 			var result = this.StringToTrim.DefaultIfNullOrEmpty("David");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       rdx,259CD9731D0
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DelimitedStringToArray()
; 			var result = this.CommaDelimitedString.DelimitedStringToArray();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 59
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
       mov       r8,1F5A0AE3060
       mov       r8,[r8]
       mov       rdx,1F590AE1250
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DelimitedStringToArray()
; 			var result = this.CommaDelimitedString.DelimitedStringToArray();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 59
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
       mov       r8,28E59E43060
       mov       r8,[r8]
       mov       rdx,28E59E456B8
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DelimitedStringToArray()
; 			var result = this.CommaDelimitedString.DelimitedStringToArray();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 59
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
       mov       r8,2375E4A3060
       mov       r8,[r8]
       mov       rdx,2376E4A1250
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DelimitedStringToArray()
; 			var result = this.CommaDelimitedString.DelimitedStringToArray();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 59
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
       mov       r8,2A01EE83060
       mov       r8,[r8]
       mov       rdx,2A04EE81250
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DelimitedStringToArray()
; 			var result = this.CommaDelimitedString.DelimitedStringToArray();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 59
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
       mov       r8,1A116B13060
       mov       r8,[r8]
       mov       rdx,1A106B11250
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DelimitedStringToArray()
; 			var result = this.CommaDelimitedString.DelimitedStringToArray();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 59
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
       mov       r8,2A2BC663060
       mov       r8,[r8]
       mov       rdx,2A29C661250
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.DelimitedStringToArray()
; 			var result = this.CommaDelimitedString.DelimitedStringToArray();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
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
; Total bytes of code 59
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
       mov       r8,228C0AD3060
       mov       r8,[r8]
       mov       rdx,228D0AD1250
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters.EqualsIgnoreCase(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters.EqualsIgnoreCase(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters.EqualsIgnoreCase(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters.EqualsIgnoreCase(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters.EqualsIgnoreCase(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters.EqualsIgnoreCase(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters.EqualsIgnoreCase(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters.EqualsOrBothNullOrEmpty(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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
       mov       rcx,1E3F70B3060
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,1E3F70B3060
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters.EqualsOrBothNullOrEmpty(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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
       mov       rcx,18D8F521048
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,18D8F521048
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters.EqualsOrBothNullOrEmpty(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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
       mov       rcx,1D9A73C3060
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,1D9A73C3060
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters.EqualsOrBothNullOrEmpty(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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
       mov       rcx,20A56E41048
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,20A56E41048
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters.EqualsOrBothNullOrEmpty(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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
       mov       rcx,17D8F323060
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,17D8F323060
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters.EqualsOrBothNullOrEmpty(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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
       mov       rcx,24530CC3060
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,24530CC3060
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters.EqualsOrBothNullOrEmpty(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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
       mov       rcx,1B9C29C3060
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,1B9C29C3060
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
; 			var result = this.Base64String.FromBase64();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,1A1A9C51A48
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1A1A9C51A28
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FFE59528E30]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 134
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
; 			var result = this.Base64String.FromBase64();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,1A885851A48
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1A885851A28
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FFE59528E30]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 134
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
; 			var result = this.Base64String.FromBase64();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,29F200B1A48
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,29F200B1A28
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FFE59538E30]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 134
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
; 			var result = this.Base64String.FromBase64();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,1DA8F891A48
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1DA8F891A28
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FFE59528E30]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 134
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
; 			var result = this.Base64String.FromBase64();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,1D9C0751A48
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1D9C0751A28
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FFE59548E30]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 134
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
; 			var result = this.Base64String.FromBase64();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,142988E1A48
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,142988E1A28
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FFE59538E30]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 134
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.FromBase64()
; 			var result = this.Base64String.FromBase64();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rdx,1BAA8D41A48
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1BAA8D41A28
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FFE59558E30]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 134
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
; 			var result = this.StringToTrim.HasValue();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
; 			var result = this.StringToTrim.HasValue();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
; 			var result = this.StringToTrim.HasValue();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
; 			var result = this.StringToTrim.HasValue();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
; 			var result = this.StringToTrim.HasValue();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
; 			var result = this.StringToTrim.HasValue();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.HasValue()
; 			var result = this.StringToTrim.HasValue();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
; 			var result = this.StringToTrim.Indent(10, '>');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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
       mov       r8,1FBE85A3060
       mov       r8,[r8]
       mov       rdx,1FBE85B1668
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
       mov       r9,1FBE85A3060
       mov       r9,[r9]
       mov       r8,1FBE85B1AB0
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
       mov       rax,[7FFE59538548]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
; 			var result = this.StringToTrim.Indent(10, '>');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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
       mov       r8,21E2B343060
       mov       r8,[r8]
       mov       rdx,21E0B341250
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
       mov       r9,21E2B343060
       mov       r9,[r9]
       mov       r8,21E0B341698
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
       mov       rax,[7FFE59538548]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
; 			var result = this.StringToTrim.Indent(10, '>');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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
       mov       r8,243A63E3060
       mov       r8,[r8]
       mov       rdx,243863E1250
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
       mov       r9,243A63E3060
       mov       r9,[r9]
       mov       r8,243863E1698
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
       mov       rax,[7FFE59528548]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
; 			var result = this.StringToTrim.Indent(10, '>');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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
       mov       r8,23EE5EF1048
       mov       r8,[r8]
       mov       rdx,23F05EF3268
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
       mov       r9,23EE5EF1048
       mov       r9,[r9]
       mov       r8,23F05EF36B0
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
       mov       rax,[7FFE59548548]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
; 			var result = this.StringToTrim.Indent(10, '>');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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
       mov       r8,15E1BBC1048
       mov       r8,[r8]
       mov       rdx,15E2BBC1250
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
       mov       r9,15E1BBC1048
       mov       r9,[r9]
       mov       r8,15E2BBC1698
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
       mov       rax,[7FFE59528548]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
; 			var result = this.StringToTrim.Indent(10, '>');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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
       mov       r8,20809653060
       mov       r8,[r8]
       mov       rdx,208096556B8
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
       mov       r9,20809653060
       mov       r9,[r9]
       mov       r8,20809655B00
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
       mov       rax,[7FFE59508548]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.Indent()
; 			var result = this.StringToTrim.Indent(10, '>');
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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
       mov       r8,1F377483060
       mov       r8,[r8]
       mov       rdx,1F3774836A0
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
       mov       r9,1F377483060
       mov       r9,[r9]
       mov       r8,1F377483AE8
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
       mov       rax,[7FFE59538548]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0DC]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0DC]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0DC]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0DC]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0DC]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0DC]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0DC]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0DC]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0DC]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0DC]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0DC]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0DC]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0DC]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0DC]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceChar()
; 			var result = this._testCharacter.IsWhitespace();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0DC]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceChar()
; 			var result = this._testCharacter.IsWhitespace();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0DC]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceChar()
; 			var result = this._testCharacter.IsWhitespace();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0DC]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceChar()
; 			var result = this._testCharacter.IsWhitespace();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0DC]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceChar()
; 			var result = this._testCharacter.IsWhitespace();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0DC]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceChar()
; 			var result = this._testCharacter.IsWhitespace();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0DC]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceChar()
; 			var result = this._testCharacter.IsWhitespace();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+0DC]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceString()
; 			var result = this.StringToTrim.IsWhitespace();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceString()
; 			var result = this.StringToTrim.IsWhitespace();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceString()
; 			var result = this.StringToTrim.IsWhitespace();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceString()
; 			var result = this.StringToTrim.IsWhitespace();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceString()
; 			var result = this.StringToTrim.IsWhitespace();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceString()
; 			var result = this.StringToTrim.IsWhitespace();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsWhitespaceString()
; 			var result = this.StringToTrim.IsWhitespace();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters.StartsWithOrdinal(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters.StartsWithOrdinal(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters.StartsWithOrdinal(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters.StartsWithOrdinal(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters.StartsWithOrdinal(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters.StartsWithOrdinal(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters.StartsWithOrdinal(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters.StartsWithOrdinalIgnoreCase(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters.StartsWithOrdinalIgnoreCase(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters.StartsWithOrdinalIgnoreCase(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters.StartsWithOrdinalIgnoreCase(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters.StartsWithOrdinalIgnoreCase(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters.StartsWithOrdinalIgnoreCase(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters.StartsWithOrdinalIgnoreCase(this.String15Characters);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,[rsi+38]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
; 			var result = this.StringToTrim.SubstringTrim(25, 25);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,1BF898B1798
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
       mov       rcx,1BF898B1698
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L03:
       mov       ebp,[rdi+8]
       mov       ecx,ebp
       sub       ecx,ebx
       cmp       ecx,esi
       jg        short M01_L04
       mov       rcx,1BF998B3608
       mov       rcx,[rcx]
       mov       rdx,1BF898B1798
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       test      ebx,ebx
       jne       short M01_L05
       mov       rcx,1BF998B3060
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
       mov       rax,7FFEB7A23926
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
       mov       rax,7FFEB7A23926
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
       mov       r8,1BF998B3060
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
; 			var result = this.StringToTrim.SubstringTrim(25, 25);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,25BEFCB1798
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
       mov       rcx,25BEFCB1698
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L03:
       mov       ebp,[rdi+8]
       mov       ecx,ebp
       sub       ecx,ebx
       cmp       ecx,esi
       jg        short M01_L04
       mov       rcx,25C0FCB11B8
       mov       rcx,[rcx]
       mov       rdx,25BEFCB1798
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       test      ebx,ebx
       jne       short M01_L05
       mov       rcx,25BDFCB3060
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
       mov       rax,7FFEB7A23926
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
       mov       rax,7FFEB7A23926
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
       mov       r8,25BDFCB3060
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
; 			var result = this.StringToTrim.SubstringTrim(25, 25);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,24ECA4A3BE8
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
       mov       rcx,24ECA4A3AE8
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L03:
       mov       ebp,[rdi+8]
       mov       ecx,ebp
       sub       ecx,ebx
       cmp       ecx,esi
       jg        short M01_L04
       mov       rcx,24EEA4AF180
       mov       rcx,[rcx]
       mov       rdx,24ECA4A3BE8
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       test      ebx,ebx
       jne       short M01_L05
       mov       rcx,24ECA4A3060
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
       mov       rax,7FFEB7A23926
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
       mov       rax,7FFEB7A23926
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
       mov       r8,24ECA4A3060
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
; 			var result = this.StringToTrim.SubstringTrim(25, 25);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,24A9EB237B0
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
       mov       rcx,24A9EB236B0
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L03:
       mov       ebp,[rdi+8]
       mov       ecx,ebp
       sub       ecx,ebx
       cmp       ecx,esi
       jg        short M01_L04
       mov       rcx,24AAEB211B8
       mov       rcx,[rcx]
       mov       rdx,24A9EB237B0
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       test      ebx,ebx
       jne       short M01_L05
       mov       rcx,24ABEB21048
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
       mov       rax,7FFEB7A23926
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
       mov       rax,7FFEB7A23926
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
       mov       r8,24ABEB21048
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
; 			var result = this.StringToTrim.SubstringTrim(25, 25);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,211045C5C00
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
       mov       rcx,211045C5B00
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L03:
       mov       ebp,[rdi+8]
       mov       ecx,ebp
       sub       ecx,ebx
       cmp       ecx,esi
       jg        short M01_L04
       mov       rcx,211045C5E58
       mov       rcx,[rcx]
       mov       rdx,211045C5C00
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       test      ebx,ebx
       jne       short M01_L05
       mov       rcx,211045C3060
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
       mov       rax,7FFEB7A23926
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
       mov       rax,7FFEB7A23926
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
       mov       r8,211045C3060
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
; 			var result = this.StringToTrim.SubstringTrim(25, 25);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,20AE7791798
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
       mov       rcx,20AE7791698
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L03:
       mov       ebp,[rdi+8]
       mov       ecx,ebp
       sub       ecx,ebx
       cmp       ecx,esi
       jg        short M01_L04
       mov       rcx,20B077911B8
       mov       rcx,[rcx]
       mov       rdx,20AE7791798
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       test      ebx,ebx
       jne       short M01_L05
       mov       rcx,20AD7793060
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
       mov       rax,7FFEB7A23926
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
       mov       rax,7FFEB7A23926
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
       mov       r8,20AD7793060
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.SubstringTrim()
; 			var result = this.StringToTrim.SubstringTrim(25, 25);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,2CB65F71798
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
       mov       rcx,2CB65F71698
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L03:
       mov       ebp,[rdi+8]
       mov       ecx,ebp
       sub       ecx,ebx
       cmp       ecx,esi
       jg        short M01_L04
       mov       rcx,2CB65F719F0
       mov       rcx,[rcx]
       mov       rdx,2CB65F71798
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       test      ebx,ebx
       jne       short M01_L05
       mov       rcx,2CB85F71048
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
       mov       rax,7FFEB7A23926
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
       mov       rax,7FFEB7A23926
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
       mov       r8,2CB85F71048
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
; 			var words = this.StringArray.ToDelimitedString(ControlChars.Space);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(words.ToTitleCase());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
       mov       rdx,7FFE5961E1C8
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
       mov       rax,113C46A3060
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
       mov       rdx,7FFE5961E1F0
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
       mov       rdx,7FFE5961E210
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass14_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFE59558548]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
; 			var words = this.StringArray.ToDelimitedString(ControlChars.Space);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(words.ToTitleCase());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
       mov       rdx,7FFE595EE280
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
       mov       rax,1EFA7F83060
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
       mov       rdx,7FFE595EE2A8
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
       mov       rdx,7FFE595EE2C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass14_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFE59528548]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
; 			var words = this.StringArray.ToDelimitedString(ControlChars.Space);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(words.ToTitleCase());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
       mov       rdx,7FFE5960E280
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
       mov       rax,2453F123060
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
       mov       rdx,7FFE5960E2A8
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
       mov       rdx,7FFE5960E2C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass14_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFE59548548]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
; 			var words = this.StringArray.ToDelimitedString(ControlChars.Space);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(words.ToTitleCase());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
       mov       rdx,7FFE5961E1C8
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
       mov       rax,28C79453060
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
       mov       rdx,7FFE5961E1F0
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
       mov       rdx,7FFE5961E210
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass14_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFE59558548]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
; 			var words = this.StringArray.ToDelimitedString(ControlChars.Space);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(words.ToTitleCase());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
       mov       rdx,7FFE5960E510
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
       mov       rax,2164ADB3060
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
       mov       rdx,7FFE5960E538
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
       mov       rdx,7FFE5960E558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass14_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFE59548548]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
; 			var words = this.StringArray.ToDelimitedString(ControlChars.Space);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(words.ToTitleCase());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
       mov       rdx,7FFE5961E280
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
       mov       rax,214EF7B3060
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
       mov       rdx,7FFE5961E2A8
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
       mov       rdx,7FFE5961E2C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass14_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFE59558548]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTitleCase()
; 			var words = this.StringArray.ToDelimitedString(ControlChars.Space);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(words.ToTitleCase());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
       mov       rdx,7FFE5960E510
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
       mov       rax,1F92D3D3060
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
       mov       rdx,7FFE5960E538
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
       mov       rdx,7FFE5960E558
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass14_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFE59548548]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
; 			var result = this.StringToTrim.ToTrimmed();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
; 			var result = this.StringToTrim.ToTrimmed();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
; 			var result = this.StringToTrim.ToTrimmed();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
; 			var result = this.StringToTrim.ToTrimmed();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
; 			var result = this.StringToTrim.ToTrimmed();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
; 			var result = this.StringToTrim.ToTrimmed();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.ToTrimmedString()
; 			var result = this.StringToTrim.ToTrimmed();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
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

