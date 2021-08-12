## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,8DDE98C52A47
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
       test      [rsp],esp
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
       mov       rcx,8DDE98C52A47
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
       mov       rcx,7FF9E9DF0020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,2396AE84D40
       mov       rax,[rax]
       mov       rcx,8DDE98C52A47
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
       mov       rcx,7FF9E9DF0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2396AE84D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA105D70]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,8DDE98C52A47
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
       mov       rdx,7FF9E9CF4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CF4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,0C38E91A0B0CF
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
       test      [rsp],esp
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
       mov       rcx,0C38E91A0B0CF
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
       mov       rcx,7FF9E9DE0020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,1BB89297150
       mov       rax,[rax]
       mov       rcx,0C38E91A0B0CF
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
       mov       rcx,7FF9E9DE0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1BB89297158
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA0F5EF0]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,0C38E91A0B0CF
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
       mov       rdx,7FF9E9CE4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CE4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,5BC99D3859D9
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
       test      [rsp],esp
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
       mov       rcx,5BC99D3859D9
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
       mov       rcx,7FF9E9DD0020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,13C513C7150
       mov       rax,[rax]
       mov       rcx,5BC99D3859D9
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
       mov       rcx,7FF9E9DD0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,13C513C7158
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA0E5D70]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,5BC99D3859D9
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
       mov       rdx,7FF9E9CD4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CD4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,65F5AF0DBFDB
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
       test      [rsp],esp
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
       mov       rcx,65F5AF0DBFDB
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
       mov       rcx,7FF9E9E10020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,19727669148
       mov       rax,[rax]
       mov       rcx,65F5AF0DBFDB
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
       mov       rcx,7FF9E9E10020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,19727669150
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA126058]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,65F5AF0DBFDB
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
       mov       rdx,7FF9E9D14020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9D14020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,2148C9E8E83
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
       test      [rsp],esp
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
       mov       rcx,2148C9E8E83
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
       mov       rcx,7FF9E9E00020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,21AC7157160
       mov       rax,[rax]
       mov       rcx,2148C9E8E83
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
       mov       rcx,21AC7157150
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FF9EA123038]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,2148C9E8E83
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
       mov       rdx,7FF9E9D04020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9D04020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,94ADB840F044
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
       test      [rsp],esp
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
       mov       rcx,94ADB840F044
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
       mov       rcx,7FF9E9DD0020
       mov       edx,2F
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,243C80A4D58
       mov       rax,[rax]
       mov       rcx,94ADB840F044
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
       mov       rcx,243C80A4D40
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FF9EA0F3038]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,94ADB840F044
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
       mov       rdx,7FF9E9CD4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CD4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,0E67987B9DD06
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
       test      [rsp],esp
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
       mov       rcx,0E67987B9DD06
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
       mov       rcx,7FF9E9DF0020
       mov       edx,2F
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,2A515A69160
       mov       rax,[rax]
       mov       rcx,0E67987B9DD06
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
       mov       rcx,2A515A69148
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FF9EA113038]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,0E67987B9DD06
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
       mov       rdx,7FF9E9CF4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CF4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,89F511F3AEB5
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
       test      [rsp],esp
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
       mov       rcx,89F511F3AEB5
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
       mov       rcx,7FF9E9DF0020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,2B569829148
       mov       rax,[rax]
       mov       rcx,89F511F3AEB5
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
       mov       rcx,7FF9E9DF0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2B569829150
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA105640]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,89F511F3AEB5
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
       mov       rdx,7FF9E9CF4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CF4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,338A29836831
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
       test      [rsp],esp
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
       mov       rcx,338A29836831
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
       mov       rcx,7FF9E9DE0020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,22E3BAD6D38
       mov       rax,[rax]
       mov       rcx,338A29836831
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
       mov       rcx,7FF9E9DE0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,22E3BAD6D40
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA0F54C0]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,338A29836831
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
       mov       rdx,7FF9E9CE4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CE4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,2CF01624954B
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
       test      [rsp],esp
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
       mov       rcx,2CF01624954B
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
       mov       rcx,7FF9E9E00020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,1BBB3837150
       mov       rax,[rax]
       mov       rcx,2CF01624954B
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
       mov       rcx,7FF9E9E00020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1BBB3837158
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA1154C0]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,2CF01624954B
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
       mov       rdx,7FF9E9D04020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9D04020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,0FD00EA48ED23
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
       test      [rsp],esp
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
       mov       rcx,0FD00EA48ED23
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
       mov       rcx,7FF9E9E00020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,1CCB0A69148
       mov       rax,[rax]
       mov       rcx,0FD00EA48ED23
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
       mov       rcx,7FF9E9E00020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1CCB0A69150
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA1154C0]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,0FD00EA48ED23
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
       mov       rdx,7FF9E9D04020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9D04020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,0FEB5A35840B7
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
       test      [rsp],esp
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
       mov       rcx,0FEB5A35840B7
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
       mov       rcx,7FF9E9DF0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,252FB379158
       mov       rax,[rax]
       mov       rcx,0FEB5A35840B7
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
       mov       rcx,252FB379148
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FF9EA113320]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,0FEB5A35840B7
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
       mov       rdx,7FF9E9CF4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CF4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,875ED326885A
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
       test      [rsp],esp
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
       mov       rcx,875ED326885A
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
       mov       rcx,7FF9E9DF0020
       mov       edx,2F
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,1C19C3B9160
       mov       rax,[rax]
       mov       rcx,875ED326885A
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
       mov       rcx,1C19C3B9148
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FF9EA113038]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,875ED326885A
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
       mov       rdx,7FF9E9CF4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CF4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,919196417EA3
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
       test      [rsp],esp
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
       mov       rcx,919196417EA3
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
       mov       rcx,7FF9E9E00020
       mov       edx,2F
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,24F074B4D58
       mov       rax,[rax]
       mov       rcx,919196417EA3
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
       mov       rcx,24F074B4D40
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FF9EA123320]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,919196417EA3
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
       mov       rdx,7FF9E9D04020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9D04020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,0D48BEE34D8B9
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
       test      [rsp],esp
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
       mov       rcx,0D48BEE34D8B9
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
       mov       rcx,7FF9E9E00020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,2B9BBFE4D40
       mov       rax,[rax]
       mov       rcx,0D48BEE34D8B9
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
       mov       rcx,7FF9E9E00020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2B9BBFE4D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA115D70]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,0D48BEE34D8B9
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
       mov       rdx,7FF9E9D04020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9D04020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,0FF5DDE704E49
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
       test      [rsp],esp
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
       mov       rcx,0FF5DDE704E49
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
       mov       rcx,7FF9E9E00020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,23859F14D40
       mov       rax,[rax]
       mov       rcx,0FF5DDE704E49
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
       mov       rcx,7FF9E9E00020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,23859F14D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA115EF0]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,0FF5DDE704E49
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
       mov       rdx,7FF9E9D04020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9D04020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,5237F912702
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
       test      [rsp],esp
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
       mov       rcx,5237F912702
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
       mov       rcx,7FF9E9DF0020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,272FB066D38
       mov       rax,[rax]
       mov       rcx,5237F912702
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
       mov       rcx,7FF9E9DF0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,272FB066D40
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA105D70]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,5237F912702
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
       mov       rdx,7FF9E9CF4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CF4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,6095ADD04C52
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
       test      [rsp],esp
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
       mov       rcx,6095ADD04C52
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
       mov       rcx,7FF9E9E00020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,161353C7150
       mov       rax,[rax]
       mov       rcx,6095ADD04C52
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
       mov       rcx,7FF9E9E00020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,161353C7158
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA115D70]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,6095ADD04C52
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
       mov       rdx,7FF9E9D04020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9D04020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,0B02EBF902742
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
       test      [rsp],esp
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
       mov       rcx,0B02EBF902742
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
       mov       rcx,7FF9E9DD0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,1653BF34D50
       mov       rax,[rax]
       mov       rcx,0B02EBF902742
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
       mov       rcx,1653BF34D40
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FF9EA0F3320]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,0B02EBF902742
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
       mov       rdx,7FF9E9CD4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CD4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,0DCF0FD108E7D
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
       test      [rsp],esp
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
       mov       rcx,0DCF0FD108E7D
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
       mov       rcx,7FF9E9DF0020
       mov       edx,2F
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,259B1974D58
       mov       rax,[rax]
       mov       rcx,0DCF0FD108E7D
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
       mov       rcx,259B1974D40
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FF9EA113038]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,0DCF0FD108E7D
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
       mov       rdx,7FF9E9CF4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CF4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,0EE6F817B9B95
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
       test      [rsp],esp
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
       mov       rcx,0EE6F817B9B95
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
       mov       rcx,7FF9E9E00020
       mov       edx,2F
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,20DC67C9160
       mov       rax,[rax]
       mov       rcx,0EE6F817B9B95
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
       mov       rcx,20DC67C9148
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FF9EA123038]
       xor       eax,eax
       mov       [rbp+38],rax
M01_L10:
       mov       rax,r15
       mov       rcx,0EE6F817B9B95
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
       mov       rdx,7FF9E9D04020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9D04020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       r8,1E663A43020
       mov       r8,[r8]
       mov       rdx,1E663A515D8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       rcx,rax
       mov       rdx,1E643A41240
       mov       rdx,[rdx]
       mov       r8,1E663A43020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       r8,181E5A41028
       mov       r8,[r8]
       mov       rdx,181C5A43258
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       rcx,rax
       mov       rdx,181D5A41240
       mov       rdx,[rdx]
       mov       r8,181E5A41028
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       r8,1F458EF1028
       mov       r8,[r8]
       mov       rdx,1F438EF3258
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       rcx,rax
       mov       rdx,1F438EF3A50
       mov       rdx,[rdx]
       mov       r8,1F458EF1028
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       r8,24E125B3020
       mov       r8,[r8]
       mov       rdx,24E125B5668
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       rcx,rax
       mov       rdx,24E125B5E60
       mov       rdx,[rdx]
       mov       r8,24E125B3020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       r8,238521E3020
       mov       r8,[r8]
       mov       rdx,238521F15D8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       rcx,rax
       mov       rdx,238621E1240
       mov       rdx,[rdx]
       mov       r8,238521E3020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       r8,296DCC03020
       mov       r8,[r8]
       mov       rdx,296DCC115D8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       rcx,rax
       mov       rdx,2970CC01240
       mov       rdx,[rdx]
       mov       r8,296DCC03020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       r8,2F9D4273020
       mov       r8,[r8]
       mov       rdx,2F9F427F1C8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       rcx,rax
       mov       rdx,2F9E4271240
       mov       rdx,[rdx]
       mov       r8,2F9D4273020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,2386F9E1160
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,2386F9E1028
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
       mov       rax,0B935DDA0845B
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
       mov       rcx,7FF9E9E00020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2386F9E7150
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,7FF9E9E00020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2386F9E7158
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA115D70]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FF9E9E00020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2386F9E7158
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA115D70]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0B935DDA0845B
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
       mov       rdx,7FF9E9D04020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9D04020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,20C544A1160
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,20C544A1028
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
       mov       rax,9A8FDC3D074C
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
       mov       rcx,7FF9E9DE0020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,20C544A7150
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,7FF9E9DE0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,20C544A7158
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA0F5EF0]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FF9E9DE0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,20C544A7158
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA0F5EF0]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,9A8FDC3D074C
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
       mov       rdx,7FF9E9CE4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CE4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,273B4A73158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,273B4A73020
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
       mov       rax,0CE85C5A597AD
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
       mov       rcx,7FF9E9DE0020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,273A4A74D40
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,7FF9E9DE0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,273A4A74D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA0F5B40]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FF9E9DE0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,273A4A74D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA0F5B40]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0CE85C5A597AD
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
       mov       rdx,7FF9E9CE4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CE4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1B575CB3158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1B575CB3020
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
       mov       rax,518B43527544
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
       mov       rcx,7FF9E9DD0020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1B575CB9148
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,7FF9E9DD0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1B575CB9150
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA0E5CA8]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FF9E9DD0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1B575CB9150
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA0E5CA8]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,518B43527544
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
       mov       rdx,7FF9E9CD4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CD4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,21D14A23158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,21D14A23020
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
       mov       rax,966FEA78F09F
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
       mov       rcx,7FF9E9DF0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,21D14A29158
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,21D14A29148
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FF9EA113320]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,21D14A29148
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FF9EA113320]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,966FEA78F09F
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
       mov       rdx,7FF9E9CF4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CF4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,24DB2BF1160
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,24DB2BF1028
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
       mov       rax,83F6E14E84E5
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
       mov       rcx,7FF9E9E10020
       mov       edx,2F
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,24DB2BF7168
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,24DB2BF7150
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FF9EA133320]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,24DB2BF7150
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FF9EA133320]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,83F6E14E84E5
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
       mov       rdx,7FF9E9D14020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9D14020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,27E65721160
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,27E65721028
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
       mov       rax,0C4453C7FE71E
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
       mov       rcx,7FF9E9DD0020
       mov       edx,2F
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,27E65727168
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,27E65727150
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FF9EA0F3038]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,27E65727150
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FF9EA0F3038]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0C4453C7FE71E
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
       mov       rdx,7FF9E9CD4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CD4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,2B7822E1160
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,2B7822E1028
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
       mov       rax,62DA294F5060
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
       mov       rcx,7FF9E9E00020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2B7822E7150
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,7FF9E9E00020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2B7822E7158
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA115640]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FF9E9E00020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2B7822E7158
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA115640]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,62DA294F5060
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
       mov       rdx,7FF9E9D04020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9D04020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1AF801A1160
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1AF801A1028
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
       mov       rax,0D3FD92A9FF6C
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
       mov       rcx,7FF9E9E00020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1AF901A8D30
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,7FF9E9E00020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1AF901A8D38
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA1154C0]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FF9E9E00020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1AF901A8D38
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA1154C0]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0D3FD92A9FF6C
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
       mov       rdx,7FF9E9D04020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9D04020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,23267493158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,23267493020
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
       mov       rax,584900D0AD83
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
       mov       rcx,7FF9E9DD0020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,23287496D38
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,7FF9E9DD0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,23287496D40
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA0E54C0]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FF9E9DD0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,23287496D40
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA0E54C0]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,584900D0AD83
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
       mov       rdx,7FF9E9CD4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CD4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,243DA343158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,243DA343020
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
       mov       rax,5938016AB3E
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
       mov       rcx,7FF9E9DF0020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,243DA349148
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,7FF9E9DF0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,243DA349150
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA1054C0]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FF9E9DF0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,243DA349150
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA1054C0]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,5938016AB3E
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
       mov       rdx,7FF9E9CF4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CF4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1B69E503158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1B69E503020
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
       mov       rax,0DE2D76530E19
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
       mov       rcx,7FF9E9DE0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1B69E509158
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,1B69E509148
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FF9EA103038]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,1B69E509148
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FF9EA103038]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0DE2D76530E19
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
       mov       rdx,7FF9E9CE4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CE4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,25E752B3158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,25E752B3020
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
       mov       rax,0C9D5617746BD
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
       mov       rcx,7FF9E9E00020
       mov       edx,2F
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,25E752B9160
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,25E752B9148
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FF9EA123320]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,25E752B9148
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FF9EA123320]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0C9D5617746BD
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
       mov       rdx,7FF9E9D04020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9D04020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1A14C601160
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1A14C601028
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
       mov       rax,83B78E73D5A0
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
       mov       rcx,7FF9E9DE0020
       mov       edx,2F
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1A14C607168
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,1A14C607150
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FF9EA103320]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,1A14C607150
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FF9EA103320]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,83B78E73D5A0
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
       mov       rdx,7FF9E9CE4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CE4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,19057B83158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,19057B83020
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
       mov       rax,0D692C0E8991
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
       mov       rcx,7FF9E9DE0020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,19057B89148
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,7FF9E9DE0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,19057B89150
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA0F5D70]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FF9E9DE0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,19057B89150
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA0F5D70]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0D692C0E8991
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
       mov       rdx,7FF9E9CE4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CE4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,2165A413158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,2165A413020
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
       mov       rax,0FC7BAE694B4D
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
       mov       rcx,7FF9E9DE0020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2165A419148
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,7FF9E9DE0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2165A419150
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA0F5D70]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FF9E9DE0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2165A419150
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA0F5D70]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0FC7BAE694B4D
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
       mov       rdx,7FF9E9CE4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CE4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,234256F1160
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,234256F1028
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
       mov       rax,101BBF42E201
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
       mov       rcx,7FF9E9E00020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,234056F6D38
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,7FF9E9E00020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,234056F6D40
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA115D70]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FF9E9E00020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,234056F6D40
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA115D70]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,101BBF42E201
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
       mov       rdx,7FF9E9D04020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9D04020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1E8DC1C3158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1E8DC1C3020
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
       mov       rax,0D22D852F3211
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
       mov       rcx,7FF9E9DE0020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1E8DC1C9148
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,7FF9E9DE0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1E8DC1C9150
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA0F5D70]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FF9E9DE0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1E8DC1C9150
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA0F5D70]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0D22D852F3211
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
       mov       rdx,7FF9E9CE4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CE4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1F2A7EA3158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1F2A7EA3020
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
       mov       rax,17602CC5A6C5
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
       mov       rcx,7FF9E9DE0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1F297EA4D50
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,1F297EA4D40
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FF9EA103320]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,1F297EA4D40
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FF9EA103320]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,17602CC5A6C5
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
       mov       rdx,7FF9E9CE4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CE4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1EBF2F53158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1EBF2F53020
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
       mov       rax,0DC30F66ED44A
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
       mov       rcx,7FF9E9E00020
       mov       edx,2F
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1EC02F56D50
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,1EC02F56D38
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FF9EA123320]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,1EC02F56D38
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FF9EA123320]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0DC30F66ED44A
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
       mov       rdx,7FF9E9D04020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9D04020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,2A9CF7C1160
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,2A9CF7C1028
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
       mov       rax,0D3DFB07B054C
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
       mov       rcx,7FF9E9E00020
       mov       edx,2F
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2A9CF7C7168
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,2A9CF7C7150
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FF9EA123038]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,2A9CF7C7150
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FF9EA123038]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0D3DFB07B054C
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
       mov       rdx,7FF9E9D04020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9D04020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1A9F78B3158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1A9F78B3020
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
       mov       rax,247A05A1D33F
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
       mov       rcx,7FF9E9E00020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1A9E78B4D40
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,7FF9E9E00020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1A9E78B4D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA115640]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FF9E9E00020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1A9E78B4D48
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA115640]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,247A05A1D33F
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
       mov       rdx,7FF9E9D04020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9D04020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1EE5EF43158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1EE5EF43020
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
       mov       rax,0DD4013AE9349
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
       mov       rcx,7FF9E9E10020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1EE5EF49148
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,7FF9E9E10020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1EE5EF49150
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA125640]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FF9E9E10020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1EE5EF49150
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA125640]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0DD4013AE9349
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
       mov       rdx,7FF9E9D14020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9D14020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,23B2D563158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,23B2D563020
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
       mov       rax,56C331140ADB
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
       mov       rcx,7FF9E9DE0020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,23B2D569148
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,7FF9E9DE0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,23B2D569150
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA0F54C0]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FF9E9DE0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,23B2D569150
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA0F54C0]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,56C331140ADB
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
       mov       rdx,7FF9E9CE4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CE4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,1DF647D3158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,1DF647D3020
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
       mov       rax,0EBE0C56F18CA
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
       mov       rcx,7FF9E9DD0020
       mov       edx,2C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1DF647D9148
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,7FF9E9DD0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1DF647D9150
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA0E54C0]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,7FF9E9DD0020
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1DF647D9150
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA0E54C0]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0EBE0C56F18CA
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
       mov       rdx,7FF9E9CD4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CD4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,244F7D63158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,244F7D63020
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
       mov       rax,0AF337DE435A2
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
       mov       rcx,7FF9E9DF0020
       mov       edx,2E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,244F7D69158
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,244F7D69148
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FF9EA113038]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,244F7D69148
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FF9EA113038]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0AF337DE435A2
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
       mov       rdx,7FF9E9CF4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CF4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,290A4C21160
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,290A4C21028
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
       mov       rax,984B3F5110DB
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
       mov       rcx,7FF9E9E10020
       mov       edx,2F
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,290A4C27168
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,290A4C27150
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FF9EA133038]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,290A4C27150
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FF9EA133038]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,984B3F5110DB
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
       mov       rdx,7FF9E9D14020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9D14020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rcx,rax
       cmp       [rcx],ecx
       mov       rdx,255DCDC3158
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdx,255DCDC3020
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
       mov       rax,0A8011C540A70
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
       mov       rcx,7FF9E9DF0020
       mov       edx,2F
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,255DCDC9160
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
       test      [rsp],esp
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
       test      [rsp],esp
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
       mov       rcx,255DCDC9148
       mov       rcx,[rcx]
       mov       rdx,[rbp+60]
       xor       r8d,r8d
       call      qword ptr [7FF9EA113320]
       xor       ecx,ecx
       mov       [rbp+60],rcx
M01_L12:
       cmp       qword ptr [rbp+40],0
       je        short M01_L13
       mov       rcx,255DCDC9148
       mov       rcx,[rcx]
       mov       rdx,[rbp+40]
       xor       r8d,r8d
       call      qword ptr [7FF9EA113320]
       xor       eax,eax
       mov       [rbp+40],rax
M01_L13:
       mov       rax,r14
M01_L14:
       mov       rcx,0A8011C540A70
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
       mov       rdx,7FF9E9CF4020
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A1D7
       mov       rdx,7FF9E9CF4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       mov       r8,1F375C51028
       mov       r8,[r8]
       mov       rdx,1F385C51240
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFD0],rdi
       mov       rcx,1F355C51AD8
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA121248]
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
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
       jle       short M01_L02
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,1F355C51508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1F385C51248
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L04
       call      System.Number.UInt32ToDecStr(UInt32)
M01_L01:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L03
       cmp       r14d,ebx
       jg        short M01_L00
M01_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9EA127D20]
       mov       r15,rax
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       jmp       short M01_L01
M01_L05:
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [7FF9EA122EB8]
       mov       rax,r15
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
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [7FF9EA122EB8]
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 382
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       mov       r8,1E906993020
       mov       r8,[r8]
       mov       rdx,1E926991240
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFD0],rdi
       mov       rcx,1E906991AD8
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA111248]
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
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
       jle       short M01_L02
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,1E906991508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1E926991248
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L04
       call      System.Number.UInt32ToDecStr(UInt32)
M01_L01:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L03
       cmp       r14d,ebx
       jg        short M01_L00
M01_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9EA107D20]
       mov       r15,rax
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       jmp       short M01_L01
M01_L05:
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [7FF9EA102EB8]
       mov       rax,r15
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
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [7FF9EA102EB8]
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 382
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       mov       r8,1CEBB763020
       mov       r8,[r8]
       mov       rdx,1CEDB76F1A8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFD0],rdi
       mov       rcx,1CEBB761AD8
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA121248]
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
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
       jle       short M01_L02
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,1CEBB761508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1CEDB76F1B0
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L04
       call      System.Number.UInt32ToDecStr(UInt32)
M01_L01:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L03
       cmp       r14d,ebx
       jg        short M01_L00
M01_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9EA117D20]
       mov       r15,rax
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       jmp       short M01_L01
M01_L05:
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [7FF9EA1131A0]
       mov       rax,r15
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
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [7FF9EA1131A0]
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 382
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       mov       r8,19150993020
       mov       r8,[r8]
       mov       rdx,19130991240
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFD0],rdi
       mov       rcx,19150991AD8
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA121248]
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
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
       jle       short M01_L02
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,19150991508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,19130991248
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L04
       call      System.Number.UInt32ToDecStr(UInt32)
M01_L01:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L03
       cmp       r14d,ebx
       jg        short M01_L00
M01_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9EA117D20]
       mov       r15,rax
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       jmp       short M01_L01
M01_L05:
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [7FF9EA1131A0]
       mov       rax,r15
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
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [7FF9EA1131A0]
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 382
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       mov       r8,20287803020
       mov       r8,[r8]
       mov       rdx,202878115B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFD0],rdi
       mov       rcx,20287801AD8
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA131248]
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
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
       jle       short M01_L02
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,20287801508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,202878115C0
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L04
       call      System.Number.UInt32ToDecStr(UInt32)
M01_L01:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L03
       cmp       r14d,ebx
       jg        short M01_L00
M01_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9EA127D20]
       mov       r15,rax
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       jmp       short M01_L01
M01_L05:
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [7FF9EA1231A0]
       mov       rax,r15
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
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [7FF9EA1231A0]
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 382
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       mov       r8,2638B521028
       mov       r8,[r8]
       mov       rdx,2638B523650
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFD0],rdi
       mov       rcx,2636B521AD8
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA111248]
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
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
       jle       short M01_L02
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,2636B521508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,2638B523658
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L04
       call      System.Number.UInt32ToDecStr(UInt32)
M01_L01:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L03
       cmp       r14d,ebx
       jg        short M01_L00
M01_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9EA107D20]
       mov       r15,rax
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       jmp       short M01_L01
M01_L05:
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [7FF9EA103038]
       mov       rax,r15
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
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [7FF9EA103038]
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 382
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       mov       r8,1FDD4723020
       mov       r8,[r8]
       mov       rdx,1FDD4731DD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFD0],rdi
       mov       rcx,1FDD4721AD8
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA101248]
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
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
       jle       short M01_L02
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,1FDD4721508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1FDD4731DD8
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L04
       call      System.Number.UInt32ToDecStr(UInt32)
M01_L01:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L03
       cmp       r14d,ebx
       jg        short M01_L00
M01_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9EA0F7D20]
       mov       r15,rax
       jmp       short M01_L05
M01_L03:
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       jmp       short M01_L01
M01_L05:
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [7FF9EA0F3038]
       mov       rax,r15
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
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L06
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [7FF9EA0F3038]
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 382
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,2ABCF593158
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
       mov       r8,2ABCF593020
       mov       r8,[r8]
       mov       rdx,2ABBF591260
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
       add       ebp,1
       jo        short M01_L07
       cmp       r15d,ebp
       jg        short M01_L02
M01_L06:
       mov       rcx,r14
       mov       rax,[7FF9EA127D20]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 258
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,253A3E83158
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
       mov       r8,253A3E83020
       mov       r8,[r8]
       mov       rdx,253C3E8F1C8
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
       add       ebp,1
       jo        short M01_L07
       cmp       r15d,ebp
       jg        short M01_L02
M01_L06:
       mov       rcx,r14
       mov       rax,[7FF9EA0F7D20]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 258
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,23DB7B03158
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
       mov       r8,23DB7B03020
       mov       r8,[r8]
       mov       rdx,23DB7B115D8
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
       add       ebp,1
       jo        short M01_L07
       cmp       r15d,ebp
       jg        short M01_L02
M01_L06:
       mov       rcx,r14
       mov       rax,[7FF9EA0F7D20]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 258
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,20709A13158
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
       mov       r8,20709A13020
       mov       r8,[r8]
       mov       rdx,20709A215D8
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
       add       ebp,1
       jo        short M01_L07
       cmp       r15d,ebp
       jg        short M01_L02
M01_L06:
       mov       rcx,r14
       mov       rax,[7FF9EA107D20]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 258
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,1B22B2C3158
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
       mov       r8,1B22B2C3020
       mov       r8,[r8]
       mov       rdx,1B21B2C1260
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
       add       ebp,1
       jo        short M01_L07
       cmp       r15d,ebp
       jg        short M01_L02
M01_L06:
       mov       rcx,r14
       mov       rax,[7FF9EA0F7D20]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 258
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,1712A4F3158
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
       mov       r8,1712A4F3020
       mov       r8,[r8]
       mov       rdx,1712A5015D8
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
       add       ebp,1
       jo        short M01_L07
       cmp       r15d,ebp
       jg        short M01_L02
M01_L06:
       mov       rcx,r14
       mov       rax,[7FF9EA0F7D20]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 258
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,1A2428A3158
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
       mov       r8,1A2428A3020
       mov       r8,[r8]
       mov       rdx,1A2228A1260
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
       add       ebp,1
       jo        short M01_L07
       cmp       r15d,ebp
       jg        short M01_L02
M01_L06:
       mov       rcx,r14
       mov       rax,[7FF9EA0F7D20]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 258
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rdi,rax
       mov       rcx,1C3F1F93158
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,1C3F1F93020
       mov       r8,[r8]
       mov       rdx,1C3E1F91260
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       dword ptr [rbp+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
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
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       add       r15d,1
       jo        short M01_L05
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,rbp
       mov       rax,[7FF9EA127D20]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 234
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rdi,rax
       mov       rcx,229C2C11160
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,229C2C11028
       mov       r8,[r8]
       mov       rdx,229A2C13258
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       dword ptr [rbp+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
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
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       add       r15d,1
       jo        short M01_L05
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,rbp
       mov       rax,[7FF9EA107D20]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 234
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rdi,rax
       mov       rcx,260799B3158
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,260799B3020
       mov       r8,[r8]
       mov       rdx,260799B5668
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       dword ptr [rbp+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
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
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       add       r15d,1
       jo        short M01_L05
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,rbp
       mov       rax,[7FF9EA0E7D20]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 234
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rdi,rax
       mov       rcx,1504F1C3158
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,1504F1C3020
       mov       r8,[r8]
       mov       rdx,1506F1CF1C8
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       dword ptr [rbp+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
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
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       add       r15d,1
       jo        short M01_L05
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,rbp
       mov       rax,[7FF9EA117D20]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 234
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rdi,rax
       mov       rcx,18C163C3158
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,18C163C3020
       mov       r8,[r8]
       mov       rdx,18C163D15D8
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       dword ptr [rbp+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
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
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       add       r15d,1
       jo        short M01_L05
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,rbp
       mov       rax,[7FF9EA0F7D20]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 234
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rdi,rax
       mov       rcx,1C63EF83158
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,1C63EF83020
       mov       r8,[r8]
       mov       rdx,1C65EF8F1C8
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       dword ptr [rbp+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
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
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       add       r15d,1
       jo        short M01_L05
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,rbp
       mov       rax,[7FF9EA107D20]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 234
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax]
       mov       rdi,rax
       mov       rcx,27F4E1B3158
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,27F4E1B3020
       mov       r8,[r8]
       mov       rdx,27F4E1B3670
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       dword ptr [rbp+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
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
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,rbp
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       add       r15d,1
       jo        short M01_L05
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,rbp
       mov       rax,[7FF9EA107D20]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 234
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,22DFDB51240
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,22DFDB51248
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.StringExtensions.ContainsAny(System.String, System.String[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,1FA96361A58
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,1FA96361A60
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.StringExtensions.ContainsAny(System.String, System.String[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,249AE611240
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,249AE611248
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.StringExtensions.ContainsAny(System.String, System.String[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,24F62485E60
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,24F62485E68
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.StringExtensions.ContainsAny(System.String, System.String[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,1F6F877D1B0
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,1F6F877D1B8
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.StringExtensions.ContainsAny(System.String, System.String[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,1AD592F1240
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,1AD592F1248
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.StringExtensions.ContainsAny(System.String, System.String[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rdi,rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,276CB561240
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,276CB561248
       mov       rdx,[rdx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.StringExtensions.ContainsAny(System.String, System.String[])
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rcx,1FCA1E63020
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rcx,22B52843020
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rcx,23334701028
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rcx,1BA4AF93020
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rcx,1C393273020
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rcx,16B45E63020
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rcx,264027A1028
       mov       rcx,[rcx]
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 22
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,23CEE9D1240
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,1CE4DABFDD8
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,26C695815B8
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,1D849D71240
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,1F51CA41240
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,1F5E1FA91D8
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,229CEE31240
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       r8,18CC53E3020
       mov       r8,[r8]
       mov       rdx,18CC53F15D8
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       r8,26EECE81028
       mov       r8,[r8]
       mov       rdx,26ECCE83258
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       r8,1CD8D5C1028
       mov       r8,[r8]
       mov       rdx,1CD8D5CF5E0
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       r8,15F87151028
       mov       r8,[r8]
       mov       rdx,15F8715F5E0
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       r8,2B3B92D1028
       mov       r8,[r8]
       mov       rdx,2B3D92D1260
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       r8,1600E9A1028
       mov       r8,[r8]
       mov       rdx,1600E9AF5E0
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       r8,1ECDD573020
       mov       r8,[r8]
       mov       rdx,1ECCD571260
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters01.EqualsIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters01.EqualsIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters01.EqualsIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters01.EqualsIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters01.EqualsIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters01.EqualsIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsIgnoreCase()
; 			var result = this.String10Characters01.EqualsIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters01.EqualsOrBothNullOrEmpty(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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
       mov       rcx,24806C23020
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,24806C23020
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters01.EqualsOrBothNullOrEmpty(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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
       mov       rcx,2449F8C3020
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,2449F8C3020
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters01.EqualsOrBothNullOrEmpty(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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
       mov       rcx,22B24463020
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,22B24463020
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters01.EqualsOrBothNullOrEmpty(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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
       mov       rcx,19027C41028
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,19027C41028
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters01.EqualsOrBothNullOrEmpty(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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
       mov       rcx,192811E3020
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,192811E3020
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters01.EqualsOrBothNullOrEmpty(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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
       mov       rcx,21AE9E83020
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,21AE9E83020
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.EqualsOrBothNullOrEmpty()
; 			var result = this.String10Characters01.EqualsOrBothNullOrEmpty(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.EqualsOrBothNullOrEmpty(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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
       mov       rcx,20DCF031028
       mov       rcx,[rcx]
M01_L00:
       test      rdx,rdx
       jne       short M01_L01
       mov       rdx,20DCF031028
       mov       rdx,[rdx]
M01_L01:
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       nop
       add       rsp,28
       ret
; Total bytes of code 57
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rdx,265FEE71A28
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,265FEE71A08
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FF9EA108E30]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 134
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rdx,1BF277F1A28
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1BF277F1A08
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FF9EA118E30]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 134
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rdx,211F8501A28
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,211F8501A08
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FF9EA108E30]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 134
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rdx,15A9DE31A28
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,15A9DE31A08
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FF9EA108E30]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 134
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rdx,21D571A1A28
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,21D571A1A08
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FF9EA128E30]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 134
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rdx,198828A1A28
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,198828A1A08
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FF9EA0E8E30]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 134
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rdx,23F2C081A28
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,23F2C081A08
       mov       rdx,[rdx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Convert.FromBase64String(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,[7FF9EA128E30]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 134
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       r8,1A138B13020
       mov       r8,[r8]
       mov       rdx,1A138B215D8
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
       mov       r9,1A138B13020
       mov       r9,[r9]
       mov       r8,1A138B219F0
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
       add       r14d,1
       jo        short M01_L05
M01_L02:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L03
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L06
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
       mov       rax,[7FF9EA0F7D20]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 269
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       r8,2003A553020
       mov       r8,[r8]
       mov       rdx,2005A55D1D0
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
       mov       r9,2003A553020
       mov       r9,[r9]
       mov       r8,2005A55D5E8
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
       add       r14d,1
       jo        short M01_L05
M01_L02:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L03
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L06
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
       mov       rax,[7FF9EA0F7D20]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 269
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       r8,26AE5AE1028
       mov       r8,[r8]
       mov       rdx,26AE5AEF5E0
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
       mov       r9,26AE5AE1028
       mov       r9,[r9]
       mov       r8,26AE5AEF9F8
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
       add       r14d,1
       jo        short M01_L05
M01_L02:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L03
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L06
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
       mov       rax,[7FF9EA107D20]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 269
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       r8,22586813020
       mov       r8,[r8]
       mov       rdx,225868215D8
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
       mov       r9,22586813020
       mov       r9,[r9]
       mov       r8,225868219F0
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
       add       r14d,1
       jo        short M01_L05
M01_L02:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L03
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L06
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
       mov       rax,[7FF9EA107D20]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 269
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       r8,2A263DB3020
       mov       r8,[r8]
       mov       rdx,2A263DC15D8
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
       mov       r9,2A263DB3020
       mov       r9,[r9]
       mov       r8,2A263DC19F0
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
       add       r14d,1
       jo        short M01_L05
M01_L02:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L03
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L06
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
       mov       rax,[7FF9EA117D20]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 269
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       r8,1E046F83020
       mov       r8,[r8]
       mov       rdx,1E056F8F1C8
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
       mov       r9,1E046F83020
       mov       r9,[r9]
       mov       r8,1E056F8F5E0
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
       add       r14d,1
       jo        short M01_L05
M01_L02:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L03
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L06
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
       mov       rax,[7FF9EA0F7D20]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 269
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       r8,1D879BB3020
       mov       r8,[r8]
       mov       rdx,1D869BB1260
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
       mov       r9,1D879BB3020
       mov       r9,[r9]
       mov       r8,1D869BB1678
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
       add       r14d,1
       jo        short M01_L05
M01_L02:
       mov       edx,esi
       test      edx,edx
       jge       short M01_L03
       mov       edx,esi
       neg       edx
       test      edx,edx
       jl        short M01_L06
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
       mov       rax,[7FF9EA117D20]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       call      System.Math.ThrowAbsOverflow()
       int       3
; Total bytes of code 269
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+19C]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      System.Char.IsLetter(Char)
       nop
       add       rsp,28
       ret
; Total bytes of code 18
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+19C]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      System.Char.IsLetter(Char)
       nop
       add       rsp,28
       ret
; Total bytes of code 18
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+19C]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      System.Char.IsLetter(Char)
       nop
       add       rsp,28
       ret
; Total bytes of code 18
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+19C]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      System.Char.IsLetter(Char)
       nop
       add       rsp,28
       ret
; Total bytes of code 18
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+19C]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      System.Char.IsLetter(Char)
       nop
       add       rsp,28
       ret
; Total bytes of code 18
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+19C]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      System.Char.IsLetter(Char)
       nop
       add       rsp,28
       ret
; Total bytes of code 18
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetter()
; 			var result = this._testCharacter.IsAsciiLetter();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+19C]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      System.Char.IsLetter(Char)
       nop
       add       rsp,28
       ret
; Total bytes of code 18
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+19C]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L02
       cmp       ecx,100
       jae       short M01_L05
       movsxd    rcx,ecx
       mov       rax,7FFA48FD3936
       movzx     ecx,byte ptr [rcx+rax]
       and       ecx,1F
       cmp       ecx,4
       jbe       short M01_L00
       cmp       ecx,8
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       jmp       short M01_L04
M01_L02:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       jbe       short M01_L03
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L04
M01_L03:
       mov       eax,1
M01_L04:
       add       rsp,28
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 103
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+19C]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L02
       cmp       ecx,100
       jae       short M01_L05
       movsxd    rcx,ecx
       mov       rax,7FFA48FD3936
       movzx     ecx,byte ptr [rcx+rax]
       and       ecx,1F
       cmp       ecx,4
       jbe       short M01_L00
       cmp       ecx,8
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       jmp       short M01_L04
M01_L02:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       jbe       short M01_L03
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L04
M01_L03:
       mov       eax,1
M01_L04:
       add       rsp,28
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 103
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+19C]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L02
       cmp       ecx,100
       jae       short M01_L05
       movsxd    rcx,ecx
       mov       rax,7FFA48FD3936
       movzx     ecx,byte ptr [rcx+rax]
       and       ecx,1F
       cmp       ecx,4
       jbe       short M01_L00
       cmp       ecx,8
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       jmp       short M01_L04
M01_L02:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       jbe       short M01_L03
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L04
M01_L03:
       mov       eax,1
M01_L04:
       add       rsp,28
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 103
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+19C]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L02
       cmp       ecx,100
       jae       short M01_L05
       movsxd    rcx,ecx
       mov       rax,7FFA48FD3936
       movzx     ecx,byte ptr [rcx+rax]
       and       ecx,1F
       cmp       ecx,4
       jbe       short M01_L00
       cmp       ecx,8
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       jmp       short M01_L04
M01_L02:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       jbe       short M01_L03
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L04
M01_L03:
       mov       eax,1
M01_L04:
       add       rsp,28
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 103
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+19C]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L02
       cmp       ecx,100
       jae       short M01_L05
       movsxd    rcx,ecx
       mov       rax,7FFA48FD3936
       movzx     ecx,byte ptr [rcx+rax]
       and       ecx,1F
       cmp       ecx,4
       jbe       short M01_L00
       cmp       ecx,8
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       jmp       short M01_L04
M01_L02:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       jbe       short M01_L03
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L04
M01_L03:
       mov       eax,1
M01_L04:
       add       rsp,28
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 103
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+19C]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L02
       cmp       ecx,100
       jae       short M01_L05
       movsxd    rcx,ecx
       mov       rax,7FFA48FD3936
       movzx     ecx,byte ptr [rcx+rax]
       and       ecx,1F
       cmp       ecx,4
       jbe       short M01_L00
       cmp       ecx,8
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       jmp       short M01_L04
M01_L02:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       jbe       short M01_L03
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L04
M01_L03:
       mov       eax,1
M01_L04:
       add       rsp,28
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 103
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsAsciiLetterOrDigit()
; 			var result = this._testCharacter.IsAsciiLetterOrDigit();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       movzx     ecx,word ptr [rsi+19C]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 33
```
```assembly
; dotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L02
       cmp       ecx,100
       jae       short M01_L05
       movsxd    rcx,ecx
       mov       rax,7FFA48FD3936
       movzx     ecx,byte ptr [rcx+rax]
       and       ecx,1F
       cmp       ecx,4
       jbe       short M01_L00
       cmp       ecx,8
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       jmp       short M01_L04
M01_L02:
       call      System.Globalization.CharUnicodeInfo.GetUnicodeCategoryNoBoundsChecks(UInt32)
       cmp       eax,4
       jbe       short M01_L03
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L04
M01_L03:
       mov       eax,1
M01_L04:
       add       rsp,28
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 103
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
; 			var guid = Guid.NewGuid().ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = guid.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       [rdx+54],al
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
       mov       rdx,1400E471A38
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
       mov       rdx,1400E471DD0
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
; 			var guid = Guid.NewGuid().ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = guid.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       [rdx+54],al
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
       mov       rdx,18475B2F628
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
       mov       rdx,18455B21240
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
; 			var guid = Guid.NewGuid().ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = guid.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       [rdx+54],al
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
       mov       rdx,2AF17FA5AC8
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
       mov       rdx,2AF27FA1240
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
; 			var guid = Guid.NewGuid().ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = guid.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       [rdx+54],al
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
       mov       rdx,2E3E08F16C0
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
       mov       rdx,2E3D08F1240
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
; 			var guid = Guid.NewGuid().ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = guid.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       [rdx+54],al
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
       mov       rdx,200E6AF1A38
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
       mov       rdx,200E6AF1DD0
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
; 			var guid = Guid.NewGuid().ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = guid.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       [rdx+54],al
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
       mov       rdx,1A8A6EF1A38
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
       mov       rdx,1A8A6EF1DD0
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsGuid01()
; 			var guid = Guid.NewGuid().ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = guid.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       [rdx+54],al
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
       mov       rdx,2DC7FFF16C0
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
       mov       rdx,2DC8FFF1240
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
; 			var macAddress = "00:1A:C2:7B:00:47";
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = macAddress.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,149ABAD1240
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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
       mov       rdx,149ABAD1248
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
; 			var macAddress = "00:1A:C2:7B:00:47";
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = macAddress.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,21B5DF11240
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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
       mov       rdx,21B5DF11248
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
; 			var macAddress = "00:1A:C2:7B:00:47";
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = macAddress.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,19FC4A31240
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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
       mov       rdx,19FC4A31248
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
; 			var macAddress = "00:1A:C2:7B:00:47";
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = macAddress.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,20D65511240
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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
       mov       rdx,20D65511248
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
; 			var macAddress = "00:1A:C2:7B:00:47";
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = macAddress.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,13759F93650
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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
       mov       rdx,13759F93658
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
; 			var macAddress = "00:1A:C2:7B:00:47";
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = macAddress.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,16D60E51240
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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
       mov       rdx,16D60E51248
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.IsMacAddress()
; 			var macAddress = "00:1A:C2:7B:00:47";
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = macAddress.IsGuid();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,29E3CC1F5C0
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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
       mov       rdx,29E3CC1F5C8
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
; 			var result = this._crlfString.RemoveCRLF();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+1A0]
       mov       rdx,161851C3020
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
       mov       rdx,161751C1240
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
; 			var result = this._crlfString.RemoveCRLF();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+1A0]
       mov       rdx,1D835063020
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
       mov       rdx,1D85506F1A8
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
; 			var result = this._crlfString.RemoveCRLF();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+1A0]
       mov       rdx,249B34E3020
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
       mov       rdx,249C34E1A58
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
; 			var result = this._crlfString.RemoveCRLF();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+1A0]
       mov       rdx,246E6EF3020
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
       mov       rdx,24706EF1A58
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
; 			var result = this._crlfString.RemoveCRLF();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+1A0]
       mov       rdx,2E1DC613020
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
       mov       rdx,2E1DC61F5C0
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
; 			var result = this._crlfString.RemoveCRLF();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+1A0]
       mov       rdx,1FC794C3020
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
       mov       rdx,1FC594C1240
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.RemoveCRLF01()
; 			var result = this._crlfString.RemoveCRLF();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+1A0]
       mov       rdx,1D2B0FC3020
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
       mov       rdx,1D2B0FC5648
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters01.StartsWithOrdinal(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters01.StartsWithOrdinal(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters01.StartsWithOrdinal(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters01.StartsWithOrdinal(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters01.StartsWithOrdinal(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters01.StartsWithOrdinal(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinal()
; 			var result = this.String10Characters01.StartsWithOrdinal(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinal(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters01.StartsWithOrdinalIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters01.StartsWithOrdinalIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters01.StartsWithOrdinalIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters01.StartsWithOrdinalIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters01.StartsWithOrdinalIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters01.StartsWithOrdinalIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsCounterBenchmark.StartsWithOrdinalIgnoreCase()
; 			var result = this.String10Characters01.StartsWithOrdinalIgnoreCase(this.String15Characters01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       mov       rdx,[rsi+60]
       call      dotNetTips.Spargine.Extensions.StringExtensions.StartsWithOrdinalIgnoreCase(System.String, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rcx,12A94B35BE8
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
       mov       rcx,12A94B35A80
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L03:
       mov       ebp,[rdi+8]
       mov       ecx,ebp
       sub       ecx,ebx
       jo        near ptr M01_L16
       cmp       ecx,esi
       jg        short M01_L04
       mov       rcx,12A84B3D1B0
       mov       rcx,[rcx]
       mov       rdx,12A94B35BE8
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       test      ebx,ebx
       jne       short M01_L05
       mov       rcx,12A94B33020
       mov       rax,[rcx]
       jmp       near ptr M01_L15
M01_L05:
       add       ebx,esi
       jo        near ptr M01_L16
       sub       ebx,1
       jo        near ptr M01_L16
       jmp       short M01_L07
M01_L06:
       add       esi,1
       jo        near ptr M01_L16
M01_L07:
       cmp       esi,ebx
       jg        short M01_L10
       cmp       esi,ebp
       jae       near ptr M01_L17
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L08
       cmp       ecx,100
       jae       near ptr M01_L17
       movsxd    rcx,ecx
       mov       rax,7FFA48FD3936
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
       sub       ebx,1
       jo        near ptr M01_L16
M01_L10:
       cmp       ebx,esi
       jl        short M01_L12
       cmp       ebx,ebp
       jae       near ptr M01_L17
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L11
       cmp       ecx,100
       jae       short M01_L17
       movsxd    rcx,ecx
       mov       rax,7FFA48FD3936
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
       jo        short M01_L16
       add       r8d,1
       jo        short M01_L16
       test      r8d,r8d
       jne       short M01_L13
       mov       r8,12A94B33020
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
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 466
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rcx,1F4F0C817E0
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
       mov       rcx,1F4F0C81678
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L03:
       mov       ebp,[rdi+8]
       mov       ecx,ebp
       sub       ecx,ebx
       jo        near ptr M01_L16
       cmp       ecx,esi
       jg        short M01_L04
       mov       rcx,1F510C85648
       mov       rcx,[rcx]
       mov       rdx,1F4F0C817E0
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       test      ebx,ebx
       jne       short M01_L05
       mov       rcx,1F510C83020
       mov       rax,[rcx]
       jmp       near ptr M01_L15
M01_L05:
       add       ebx,esi
       jo        near ptr M01_L16
       sub       ebx,1
       jo        near ptr M01_L16
       jmp       short M01_L07
M01_L06:
       add       esi,1
       jo        near ptr M01_L16
M01_L07:
       cmp       esi,ebx
       jg        short M01_L10
       cmp       esi,ebp
       jae       near ptr M01_L17
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L08
       cmp       ecx,100
       jae       near ptr M01_L17
       movsxd    rcx,ecx
       mov       rax,7FFA48FD3936
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
       sub       ebx,1
       jo        near ptr M01_L16
M01_L10:
       cmp       ebx,esi
       jl        short M01_L12
       cmp       ebx,ebp
       jae       near ptr M01_L17
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L11
       cmp       ecx,100
       jae       short M01_L17
       movsxd    rcx,ecx
       mov       rax,7FFA48FD3936
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
       jo        short M01_L16
       add       r8d,1
       jo        short M01_L16
       test      r8d,r8d
       jne       short M01_L13
       mov       r8,1F510C83020
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
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 466
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rcx,17066E917E0
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
       mov       rcx,17066E91678
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L03:
       mov       ebp,[rdi+8]
       mov       ecx,ebp
       sub       ecx,ebx
       jo        near ptr M01_L16
       cmp       ecx,esi
       jg        short M01_L04
       mov       rcx,17066E91A58
       mov       rcx,[rcx]
       mov       rdx,17066E917E0
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       test      ebx,ebx
       jne       short M01_L05
       mov       rcx,17076E93020
       mov       rax,[rcx]
       jmp       near ptr M01_L15
M01_L05:
       add       ebx,esi
       jo        near ptr M01_L16
       sub       ebx,1
       jo        near ptr M01_L16
       jmp       short M01_L07
M01_L06:
       add       esi,1
       jo        near ptr M01_L16
M01_L07:
       cmp       esi,ebx
       jg        short M01_L10
       cmp       esi,ebp
       jae       near ptr M01_L17
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L08
       cmp       ecx,100
       jae       near ptr M01_L17
       movsxd    rcx,ecx
       mov       rax,7FFA48FD3936
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
       sub       ebx,1
       jo        near ptr M01_L16
M01_L10:
       cmp       ebx,esi
       jl        short M01_L12
       cmp       ebx,ebp
       jae       near ptr M01_L17
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L11
       cmp       ecx,100
       jae       short M01_L17
       movsxd    rcx,ecx
       mov       rax,7FFA48FD3936
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
       jo        short M01_L16
       add       r8d,1
       jo        short M01_L16
       test      r8d,r8d
       jne       short M01_L13
       mov       r8,17076E93020
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
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 466
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rcx,234E2191B58
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
       mov       rcx,234E21919F0
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L03:
       mov       ebp,[rdi+8]
       mov       ecx,ebp
       sub       ecx,ebx
       jo        near ptr M01_L16
       cmp       ecx,esi
       jg        short M01_L04
       mov       rcx,23512181240
       mov       rcx,[rcx]
       mov       rdx,234E2191B58
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       test      ebx,ebx
       jne       short M01_L05
       mov       rcx,234E2183020
       mov       rax,[rcx]
       jmp       near ptr M01_L15
M01_L05:
       add       ebx,esi
       jo        near ptr M01_L16
       sub       ebx,1
       jo        near ptr M01_L16
       jmp       short M01_L07
M01_L06:
       add       esi,1
       jo        near ptr M01_L16
M01_L07:
       cmp       esi,ebx
       jg        short M01_L10
       cmp       esi,ebp
       jae       near ptr M01_L17
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L08
       cmp       ecx,100
       jae       near ptr M01_L17
       movsxd    rcx,ecx
       mov       rax,7FFA48FD3936
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
       sub       ebx,1
       jo        near ptr M01_L16
M01_L10:
       cmp       ebx,esi
       jl        short M01_L12
       cmp       ebx,ebp
       jae       near ptr M01_L17
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L11
       cmp       ecx,100
       jae       short M01_L17
       movsxd    rcx,ecx
       mov       rax,7FFA48FD3936
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
       jo        short M01_L16
       add       r8d,1
       jo        short M01_L16
       test      r8d,r8d
       jne       short M01_L13
       mov       r8,234E2183020
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
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 466
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rcx,1B290B637D8
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
       mov       rcx,1B290B63670
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L03:
       mov       ebp,[rdi+8]
       mov       ecx,ebp
       sub       ecx,ebx
       jo        near ptr M01_L16
       cmp       ecx,esi
       jg        short M01_L04
       mov       rcx,1B2B0B6F1A8
       mov       rcx,[rcx]
       mov       rdx,1B290B637D8
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       test      ebx,ebx
       jne       short M01_L05
       mov       rcx,1B2A0B61028
       mov       rax,[rcx]
       jmp       near ptr M01_L15
M01_L05:
       add       ebx,esi
       jo        near ptr M01_L16
       sub       ebx,1
       jo        near ptr M01_L16
       jmp       short M01_L07
M01_L06:
       add       esi,1
       jo        near ptr M01_L16
M01_L07:
       cmp       esi,ebx
       jg        short M01_L10
       cmp       esi,ebp
       jae       near ptr M01_L17
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L08
       cmp       ecx,100
       jae       near ptr M01_L17
       movsxd    rcx,ecx
       mov       rax,7FFA48FD3936
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
       sub       ebx,1
       jo        near ptr M01_L16
M01_L10:
       cmp       ebx,esi
       jl        short M01_L12
       cmp       ebx,ebp
       jae       near ptr M01_L17
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L11
       cmp       ecx,100
       jae       short M01_L17
       movsxd    rcx,ecx
       mov       rax,7FFA48FD3936
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
       jo        short M01_L16
       add       r8d,1
       jo        short M01_L16
       test      r8d,r8d
       jne       short M01_L13
       mov       r8,1B2A0B61028
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
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 466
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rcx,1B41C9317E0
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
       mov       rcx,1B41C931678
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L03:
       mov       ebp,[rdi+8]
       mov       ecx,ebp
       sub       ecx,ebx
       jo        near ptr M01_L16
       cmp       ecx,esi
       jg        short M01_L04
       mov       rcx,1B43C931240
       mov       rcx,[rcx]
       mov       rdx,1B41C9317E0
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       test      ebx,ebx
       jne       short M01_L05
       mov       rcx,1B42C933020
       mov       rax,[rcx]
       jmp       near ptr M01_L15
M01_L05:
       add       ebx,esi
       jo        near ptr M01_L16
       sub       ebx,1
       jo        near ptr M01_L16
       jmp       short M01_L07
M01_L06:
       add       esi,1
       jo        near ptr M01_L16
M01_L07:
       cmp       esi,ebx
       jg        short M01_L10
       cmp       esi,ebp
       jae       near ptr M01_L17
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L08
       cmp       ecx,100
       jae       near ptr M01_L17
       movsxd    rcx,ecx
       mov       rax,7FFA48FD3936
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
       sub       ebx,1
       jo        near ptr M01_L16
M01_L10:
       cmp       ebx,esi
       jl        short M01_L12
       cmp       ebx,ebp
       jae       near ptr M01_L17
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L11
       cmp       ecx,100
       jae       short M01_L17
       movsxd    rcx,ecx
       mov       rax,7FFA48FD3936
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
       jo        short M01_L16
       add       r8d,1
       jo        short M01_L16
       test      r8d,r8d
       jne       short M01_L13
       mov       r8,1B42C933020
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
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 466
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rcx,1EB8EB91B58
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
       mov       rcx,1EB8EB919F0
       mov       rcx,[rcx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String)
M01_L03:
       mov       ebp,[rdi+8]
       mov       ecx,ebp
       sub       ecx,ebx
       jo        near ptr M01_L16
       cmp       ecx,esi
       jg        short M01_L04
       mov       rcx,1EB6EB81240
       mov       rcx,[rcx]
       mov       rdx,1EB8EB91B58
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L04:
       test      ebx,ebx
       jne       short M01_L05
       mov       rcx,1EB8EB83020
       mov       rax,[rcx]
       jmp       near ptr M01_L15
M01_L05:
       add       ebx,esi
       jo        near ptr M01_L16
       sub       ebx,1
       jo        near ptr M01_L16
       jmp       short M01_L07
M01_L06:
       add       esi,1
       jo        near ptr M01_L16
M01_L07:
       cmp       esi,ebx
       jg        short M01_L10
       cmp       esi,ebp
       jae       near ptr M01_L17
       movsxd    rcx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L08
       cmp       ecx,100
       jae       near ptr M01_L17
       movsxd    rcx,ecx
       mov       rax,7FFA48FD3936
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
       sub       ebx,1
       jo        near ptr M01_L16
M01_L10:
       cmp       ebx,esi
       jl        short M01_L12
       cmp       ebx,ebp
       jae       near ptr M01_L17
       movsxd    rcx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L11
       cmp       ecx,100
       jae       short M01_L17
       movsxd    rcx,ecx
       mov       rax,7FFA48FD3936
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
       jo        short M01_L16
       add       r8d,1
       jo        short M01_L16
       test      r8d,r8d
       jne       short M01_L13
       mov       r8,1EB8EB83020
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
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 466
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rdx,7FF9EA22D200
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
       mov       rax,2A10F533020
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
       imul      edx,eax,0A
       jo        near ptr M01_L07
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
       mov       rdx,7FF9EA22D210
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
       mov       rdx,7FF9EA22D230
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass18_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA127D20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M01_L07
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 358
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rdx,7FF9EA20D690
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
       mov       rax,1A2CEE61028
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
       imul      edx,eax,0A
       jo        near ptr M01_L07
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
       mov       rdx,7FF9EA20D6A0
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
       mov       rdx,7FF9EA20D6C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass18_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA107D20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M01_L07
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 358
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rdx,7FF9EA20D690
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
       mov       rax,2B4C02C3020
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
       imul      edx,eax,0A
       jo        near ptr M01_L07
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
       mov       rdx,7FF9EA20D6A0
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
       mov       rdx,7FF9EA20D6C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass18_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA107D20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M01_L07
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 358
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rdx,7FF9EA1FD690
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
       mov       rax,150DF1A1028
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
       imul      edx,eax,0A
       jo        near ptr M01_L07
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
       mov       rdx,7FF9EA1FD6A0
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
       mov       rdx,7FF9EA1FD6C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass18_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA0F7D20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M01_L07
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 358
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rdx,7FF9EA21D690
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
       mov       rax,20B3A453020
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
       imul      edx,eax,0A
       jo        near ptr M01_L07
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
       mov       rdx,7FF9EA21D6A0
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
       mov       rdx,7FF9EA21D6C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass18_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA117D20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M01_L07
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 358
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rdx,7FF9EA23D690
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
       mov       rax,16DBD951028
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
       imul      edx,eax,0A
       jo        near ptr M01_L07
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
       mov       rdx,7FF9EA23D6A0
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
       mov       rdx,7FF9EA23D6C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass18_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA137D20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M01_L07
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 358
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rdx,7FF9EA20D690
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
       mov       rax,2111F773020
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
       imul      edx,eax,0A
       jo        near ptr M01_L07
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
       mov       rdx,7FF9EA20D6A0
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
       mov       rdx,7FF9EA20D6C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass18_0`1[[System.__Canon, System.Private.CoreLib]].<ToDelimitedString>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FF9EA107D20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short M01_L07
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 358
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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

