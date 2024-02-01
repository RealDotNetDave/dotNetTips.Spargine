## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString_Comparison()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       cmp       qword ptr [rsi+288],0
       jne       short M00_L00
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L00:
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
       mov       rcx,[rsi+288]
       mov       edx,[rcx+8]
       add       edx,edx
       mov       rcx,rdi
       call      System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,208B7E71C40
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,20867E71568
       mov       rbp,[rdx]
       mov       rdx,208B7E71C48
       mov       r14,[rdx]
M00_L01:
       mov       rdx,[rsi+288]
       cmp       ebx,[rdx+8]
       jae       near ptr M00_L05
       movsxd    rcx,ebx
       lea       rdx,[rdx+rcx+10]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r14
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       mov       rax,[rsi+288]
       mov       eax,[rax+8]
       movsxd    rax,eax
       movsxd    rdx,ebx
       cmp       rax,rdx
       jg        short M00_L01
M00_L02:
       mov       ecx,[rdi+18]
       mov       edx,ecx
       mov       r8,[rdi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M00_L03
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],27
       inc       ecx
       mov       [rdi+18],ecx
       jmp       short M00_L04
M00_L03:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M00_L04:
       mov       rcx,rdi
       call      qword ptr [7FF9DB79BC48]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rsi+8],rdx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 366
```
```assembly
; System.Text.StringBuilder.set_Capacity(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      edx,edx
       jl        near ptr M01_L05
       cmp       edx,[rsi+20]
       jg        near ptr M01_L06
       mov       ecx,[rsi+1C]
       mov       eax,ecx
       add       eax,[rsi+18]
       cmp       eax,edx
       jg        near ptr M01_L07
       mov       rax,[rsi+8]
       mov       r8d,ecx
       add       r8d,[rax+8]
       cmp       r8d,edx
       je        short M01_L01
       mov       edi,edx
       sub       edi,ecx
       cmp       edi,400
       jge       short M01_L02
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
M01_L00:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       test      rax,rax
       je        short M01_L04
       mov       rcx,[rax+18]
M01_L03:
       mov       edx,edi
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rbx,rax
       jmp       short M01_L00
M01_L04:
       xor       ecx,ecx
       jmp       short M01_L03
M01_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FF9DB4F4000
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
; Total bytes of code 449
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rdx,rdx
       je        short M02_L01
       mov       rdi,[rsi+8]
       mov       ebx,[rsi+18]
       mov       ebp,[rdx+8]
       lea       r14d,[rbx+rbp]
       cmp       r14d,[rdi+8]
       jae       short M02_L04
       cmp       ebp,2
       jle       short M02_L02
       add       rdi,10
       movsxd    r8,ebx
       lea       rcx,[rdi+r8*2]
       add       rdx,0C
       movsxd    r8,ebp
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L00:
       mov       [rsi+18],r14d
M02_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       test      ebp,ebp
       jle       short M02_L03
       cmp       dword ptr [rdx+8],0
       jbe       short M02_L05
       movzx     ecx,word ptr [rdx+0C]
       cmp       ebx,[rdi+8]
       jae       short M02_L05
       movsxd    rax,ebx
       mov       [rdi+rax*2+10],cx
M02_L03:
       cmp       ebp,1
       jle       short M02_L00
       cmp       dword ptr [rdx+8],1
       jbe       short M02_L05
       movzx     ecx,word ptr [rdx+0E]
       lea       edx,[rbx+1]
       cmp       edx,[rdi+8]
       jae       short M02_L05
       inc       ebx
       movsxd    rdx,ebx
       mov       [rdi+rdx*2+10],cx
       jmp       short M02_L00
M02_L04:
       mov       rcx,rsi
       call      System.Text.StringBuilder.AppendHelper(System.String)
       jmp       short M02_L01
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 165
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A0
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp],xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       rax,0CAF8ADC36CE8
       mov       [rbp+68],rax
       mov       esi,ecx
       mov       rdi,r8
       test      rdx,rdx
       je        short M03_L01
       lea       rbx,[rdx+0C]
       mov       r14d,[rdx+8]
M03_L00:
       mov       [rbp],rbx
       mov       [rbp+8],r14d
       lea       rcx,[rbp]
       lea       rdx,[rbp+50]
       call      System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
       mov       r15d,eax
       mov       r12d,r15d
       and       r12d,0FFDF
       cmp       r12d,47
       je        short M03_L02
       cmp       r12d,44
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L05
       jmp       short M03_L03
M03_L01:
       xor       ebx,ebx
       xor       r14d,r14d
       jmp       short M03_L00
M03_L02:
       cmp       dword ptr [rbp+50],0
       setle     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L05
M03_L03:
       mov       ecx,esi
       mov       edx,[rbp+50]
       call      System.Number.UInt32ToDecStr(UInt32, Int32)
       mov       rcx,0CAF8ADC36CE8
       cmp       [rbp+68],rcx
       je        short M03_L04
       call      CORINFO_HELP_FAIL_FAST
M03_L04:
       nop
       lea       rsp,[rbp+70]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L05:
       cmp       r12d,58
       jne       short M03_L07
       add       r15d,0FFFFFFDF
       movzx     edx,r15w
       mov       ecx,esi
       mov       r8d,[rbp+50]
       call      System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,0CAF8ADC36CE8
       cmp       [rbp+68],rcx
       je        short M03_L06
       call      CORINFO_HELP_FAIL_FAST
M03_L06:
       nop
       lea       rsp,[rbp+70]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L07:
       test      rdi,rdi
       je        near ptr M03_L13
       mov       rcx,rdi
       call      System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|45_0(System.IFormatProvider)
       mov       rdi,rax
M03_L08:
       lea       rcx,[rbp+58]
       xor       edx,edx
       mov       [rbp+30],edx
       mov       [rbp+34],edx
       mov       byte ptr [rbp+38],0
       mov       byte ptr [rbp+39],0
       mov       byte ptr [rbp+3A],1
       lea       rdx,[rbp+40]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],0B
       lea       rcx,[rbp+40]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M03_L17
       mov       rcx,[rcx]
       mov       byte ptr [rcx],0
       mov       dword ptr [rbp+30],0A
       mov       byte ptr [rbp+38],0
       lea       rcx,[rbp+40]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M03_L17
       mov       r12,[rcx]
       lea       rcx,[r12+0A]
       mov       edx,esi
       xor       r8d,r8d
       call      System.Number.UInt32ToDecChars(Byte*, UInt32, Int32)
       add       r12,0A
       sub       r12,rax
       mov       ecx,r12d
       mov       [rbp+30],ecx
       mov       [rbp+34],ecx
       lea       rdx,[rbp+40]
       cmp       dword ptr [rdx+8],0
       jbe       near ptr M03_L17
       mov       rdx,[rdx]
       dec       ecx
       test      ecx,ecx
       jl        short M03_L12
M03_L09:
       lea       r8,[rdx+1]
       lea       r9,[rax+1]
       movzx     eax,byte ptr [rax]
       mov       [rdx],al
       dec       ecx
       test      ecx,ecx
       mov       rax,r9
       jge       short M03_L11
M03_L10:
       mov       byte ptr [r8],0
       test      [rsp],esp
       sub       rsp,40
       lea       rcx,[rsp+30]
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rdx,[rbp+20]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],20
       xor       ecx,ecx
       mov       [rbp+18],ecx
       test      r15d,r15d
       je        short M03_L14
       mov       [rsp+20],rdi
       lea       rcx,[rbp+10]
       lea       rdx,[rbp+30]
       mov       r8d,r15d
       mov       r9d,[rbp+50]
       call      System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L11:
       mov       rdx,r8
       jmp       short M03_L09
M03_L12:
       mov       r8,rdx
       jmp       short M03_L10
M03_L13:
       call      System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
       jmp       near ptr M03_L08
M03_L14:
       lea       rcx,[rbp+10]
       lea       rdx,[rbp+30]
       mov       [rbp],rbx
       mov       [rbp+8],r14d
       lea       r8,[rbp]
       mov       r9,rdi
       call      System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+10]
       call      System.Text.ValueStringBuilder.ToString()
       mov       rcx,0CAF8ADC36CE8
       cmp       [rbp+68],rcx
       je        short M03_L16
       call      CORINFO_HELP_FAIL_FAST
M03_L16:
       nop
       lea       rsp,[rbp+70]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 627
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,20867E73020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9DB4F4000
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
**Method was not JITted yet.**
System.Text.StringBuilder.Append(Char, Int32)

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString_Comparison()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       cmp       qword ptr [rsi+288],0
       jne       short M00_L00
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L00:
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
       mov       rcx,[rsi+288]
       mov       edx,[rcx+8]
       add       edx,edx
       mov       rcx,rdi
       call      qword ptr [7FF9CF22B150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,1A277400C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FF9CF22B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,1A26B400528
       mov       rbp,[rdx]
       mov       rdx,1A277400C98
       mov       r14,[rdx]
M00_L01:
       mov       rdx,[rsi+288]
       cmp       ebx,[rdx+8]
       jae       near ptr M00_L06
       mov       ecx,ebx
       lea       rdx,[rdx+rcx+10]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r14
       call      qword ptr [7FF9CF1D3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF22B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L02:
       inc       ebx
       mov       rax,[rsi+288]
       mov       eax,[rax+8]
       movsxd    rdx,ebx
       cmp       rax,rdx
       jg        short M00_L01
M00_L03:
       mov       ecx,[rdi+18]
       mov       edx,ecx
       mov       r8,[rdi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M00_L04
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],27
       inc       ecx
       mov       [rdi+18],ecx
       jmp       short M00_L05
M00_L04:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF9CF22B258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FF9CF20FE70]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rsi+8],rdx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 384
```
```assembly
; System.Text.StringBuilder.set_Capacity(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      edx,edx
       jl        near ptr M01_L05
       cmp       edx,[rsi+20]
       jg        near ptr M01_L06
       mov       ecx,[rsi+1C]
       mov       eax,ecx
       add       eax,[rsi+18]
       cmp       eax,edx
       jg        near ptr M01_L07
       mov       rax,[rsi+8]
       mov       r8d,ecx
       add       r8d,[rax+8]
       cmp       r8d,edx
       je        short M01_L01
       mov       edi,edx
       sub       edi,ecx
       cmp       edi,400
       jge       short M01_L02
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
M01_L00:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rbx
       call      qword ptr [7FF9CEF09018]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       test      rax,rax
       je        short M01_L04
       mov       rcx,[rax+18]
M01_L03:
       mov       edx,edi
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rbx,rax
       jmp       short M01_L00
M01_L04:
       xor       ecx,ecx
       jmp       short M01_L03
M01_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9CEDD4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FF9CEDD4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF04D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1D5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9CEDD4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FF9CEDD4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF04D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1D5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9CEDD4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FF9CEDD4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF04D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1D5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 456
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,r8d
       test      esi,esi
       je        short M02_L03
       mov       r8,[rdi+8]
       mov       ebx,[rdi+18]
       lea       ecx,[rbx+rsi]
       cmp       ecx,[r8+8]
       ja        short M02_L02
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       short M02_L01
       movsxd    r8,esi
       add       r8,r8
       call      qword ptr [7FF9CF0699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L00:
       add       esi,ebx
       mov       [rdi+18],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L01:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       short M02_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M02_L00
M02_L02:
       mov       rcx,rdi
       mov       r8d,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9CF22B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
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
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       vmovdqa   xmmword ptr [rbp+50],xmm4
       mov       [rbp+60],rax
       mov       rax,52A7631FA2E2
       mov       [rbp+80],rax
       mov       esi,ecx
       mov       rdi,r8
       test      rdx,rdx
       je        short M03_L01
       lea       rbx,[rdx+0C]
       mov       r14d,[rdx+8]
M03_L00:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       rcx,[rbp+18]
       lea       rdx,[rbp+68]
       call      qword ptr [7FF9CF1D36F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
       mov       r15d,eax
       mov       r12d,r15d
       and       r12d,0FFDF
       cmp       r12d,47
       je        short M03_L02
       cmp       r12d,44
       jne       short M03_L03
       jmp       short M03_L05
M03_L01:
       xor       ebx,ebx
       xor       r14d,r14d
       jmp       short M03_L00
M03_L02:
       cmp       dword ptr [rbp+68],0
       jle       short M03_L05
M03_L03:
       cmp       r12d,58
       jne       short M03_L07
       add       r15d,0FFFFFFDF
       movzx     edx,r15w
       mov       ecx,esi
       mov       r8d,[rbp+68]
       call      qword ptr [7FF9CF1D3348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,52A7631FA2E2
       cmp       [rbp+80],rcx
       je        short M03_L04
       call      CORINFO_HELP_FAIL_FAST
M03_L04:
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
M03_L05:
       mov       ecx,esi
       mov       edx,[rbp+68]
       call      qword ptr [7FF9CF1D3408]
       mov       rcx,52A7631FA2E2
       cmp       [rbp+80],rcx
       je        short M03_L06
       call      CORINFO_HELP_FAIL_FAST
M03_L06:
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
M03_L07:
       test      rdi,rdi
       je        short M03_L08
       mov       rcx,rdi
       call      qword ptr [7FF9CF1996D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FF9CF199288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FF9CF8277B0]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FF9CF8277C8]
       lea       rcx,[rax+0A]
       xor       edx,edx
       jmp       short M03_L11
M03_L10:
       mov       r8d,0CCCCCCCD
       mov       r9d,esi
       imul      r8,r9
       shr       r8,23
       lea       r9d,[r8+r8*4]
       add       r9d,r9d
       sub       esi,r9d
       dec       rcx
       add       esi,30
       mov       [rcx],sil
       mov       esi,r8d
M03_L11:
       dec       edx
       jns       short M03_L10
       test      esi,esi
       jne       short M03_L10
       mov       rsi,rcx
       add       rax,0A
       sub       rax,rsi
       mov       r12d,eax
       mov       [rbp+48],r12d
       mov       [rbp+4C],r12d
       lea       rcx,[rbp+48]
       call      qword ptr [7FF9CF8277C8]
       jmp       short M03_L13
M03_L12:
       lea       rcx,[rax+1]
       lea       rdx,[rsi+1]
       mov       r13,rdx
       movzx     edx,byte ptr [rsi]
       mov       [rax],dl
       mov       rax,rcx
       mov       rsi,r13
M03_L13:
       dec       r12d
       jns       short M03_L12
       mov       byte ptr [rax],0
       test      [rsp],esp
       sub       rsp,40
       lea       rcx,[rsp+30]
       xor       edx,edx
       mov       [rbp+28],rdx
       mov       [rbp+38],rcx
       mov       dword ptr [rbp+40],20
       mov       [rbp+30],edx
       test      r15d,r15d
       je        short M03_L14
       mov       [rsp+20],rdi
       lea       rcx,[rbp+28]
       lea       rdx,[rbp+48]
       mov       r8d,r15d
       mov       r9d,[rbp+68]
       call      qword ptr [7FF9CF1D3708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FF9CF1D3720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FF9CF359B40]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,52A7631FA2E2
       cmp       [rbp+80],rcx
       je        short M03_L16
       call      CORINFO_HELP_FAIL_FAST
M03_L16:
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
; Total bytes of code 637
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9CF0699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,1A26B402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FF9CEDD4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9CEDD4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF04D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1D5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString_Comparison()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       cmp       qword ptr [rsi+288],0
       jne       short M00_L00
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L00:
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
       mov       rcx,[rsi+288]
       mov       edx,[rcx+8]
       add       edx,edx
       mov       rcx,rdi
       call      System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,221F4131C40
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,22194131568
       mov       rbp,[rdx]
       mov       rdx,221F4131C48
       mov       r14,[rdx]
M00_L01:
       mov       rdx,[rsi+288]
       cmp       ebx,[rdx+8]
       jae       near ptr M00_L05
       movsxd    rcx,ebx
       lea       rdx,[rdx+rcx+10]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r14
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       mov       rax,[rsi+288]
       mov       eax,[rax+8]
       movsxd    rax,eax
       movsxd    rdx,ebx
       cmp       rax,rdx
       jg        short M00_L01
M00_L02:
       mov       ecx,[rdi+18]
       mov       edx,ecx
       mov       r8,[rdi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M00_L03
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],27
       inc       ecx
       mov       [rdi+18],ecx
       jmp       short M00_L04
M00_L03:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M00_L04:
       mov       rcx,rdi
       call      qword ptr [7FF9DB79BC48]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rsi+8],rdx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 366
```
```assembly
; System.Text.StringBuilder.set_Capacity(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      edx,edx
       jl        near ptr M01_L05
       cmp       edx,[rsi+20]
       jg        near ptr M01_L06
       mov       ecx,[rsi+1C]
       mov       eax,ecx
       add       eax,[rsi+18]
       cmp       eax,edx
       jg        near ptr M01_L07
       mov       rax,[rsi+8]
       mov       r8d,ecx
       add       r8d,[rax+8]
       cmp       r8d,edx
       je        short M01_L01
       mov       edi,edx
       sub       edi,ecx
       cmp       edi,400
       jge       short M01_L02
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
M01_L00:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       test      rax,rax
       je        short M01_L04
       mov       rcx,[rax+18]
M01_L03:
       mov       edx,edi
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rbx,rax
       jmp       short M01_L00
M01_L04:
       xor       ecx,ecx
       jmp       short M01_L03
M01_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FF9DB4F4000
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
; Total bytes of code 449
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rdx,rdx
       je        short M02_L01
       mov       rdi,[rsi+8]
       mov       ebx,[rsi+18]
       mov       ebp,[rdx+8]
       lea       r14d,[rbx+rbp]
       cmp       r14d,[rdi+8]
       jae       short M02_L04
       cmp       ebp,2
       jle       short M02_L02
       add       rdi,10
       movsxd    r8,ebx
       lea       rcx,[rdi+r8*2]
       add       rdx,0C
       movsxd    r8,ebp
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L00:
       mov       [rsi+18],r14d
M02_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       test      ebp,ebp
       jle       short M02_L03
       cmp       dword ptr [rdx+8],0
       jbe       short M02_L05
       movzx     ecx,word ptr [rdx+0C]
       cmp       ebx,[rdi+8]
       jae       short M02_L05
       movsxd    rax,ebx
       mov       [rdi+rax*2+10],cx
M02_L03:
       cmp       ebp,1
       jle       short M02_L00
       cmp       dword ptr [rdx+8],1
       jbe       short M02_L05
       movzx     ecx,word ptr [rdx+0E]
       lea       edx,[rbx+1]
       cmp       edx,[rdi+8]
       jae       short M02_L05
       inc       ebx
       movsxd    rdx,ebx
       mov       [rdi+rdx*2+10],cx
       jmp       short M02_L00
M02_L04:
       mov       rcx,rsi
       call      System.Text.StringBuilder.AppendHelper(System.String)
       jmp       short M02_L01
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 165
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A0
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp],xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       rax,1D7D76F3AC1B
       mov       [rbp+68],rax
       mov       esi,ecx
       mov       rdi,r8
       test      rdx,rdx
       je        short M03_L01
       lea       rbx,[rdx+0C]
       mov       r14d,[rdx+8]
M03_L00:
       mov       [rbp],rbx
       mov       [rbp+8],r14d
       lea       rcx,[rbp]
       lea       rdx,[rbp+50]
       call      System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
       mov       r15d,eax
       mov       r12d,r15d
       and       r12d,0FFDF
       cmp       r12d,47
       je        short M03_L02
       cmp       r12d,44
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L05
       jmp       short M03_L03
M03_L01:
       xor       ebx,ebx
       xor       r14d,r14d
       jmp       short M03_L00
M03_L02:
       cmp       dword ptr [rbp+50],0
       setle     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L05
M03_L03:
       mov       ecx,esi
       mov       edx,[rbp+50]
       call      System.Number.UInt32ToDecStr(UInt32, Int32)
       mov       rcx,1D7D76F3AC1B
       cmp       [rbp+68],rcx
       je        short M03_L04
       call      CORINFO_HELP_FAIL_FAST
M03_L04:
       nop
       lea       rsp,[rbp+70]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L05:
       cmp       r12d,58
       jne       short M03_L07
       add       r15d,0FFFFFFDF
       movzx     edx,r15w
       mov       ecx,esi
       mov       r8d,[rbp+50]
       call      System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,1D7D76F3AC1B
       cmp       [rbp+68],rcx
       je        short M03_L06
       call      CORINFO_HELP_FAIL_FAST
M03_L06:
       nop
       lea       rsp,[rbp+70]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L07:
       test      rdi,rdi
       je        near ptr M03_L13
       mov       rcx,rdi
       call      System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|45_0(System.IFormatProvider)
       mov       rdi,rax
M03_L08:
       lea       rcx,[rbp+58]
       xor       edx,edx
       mov       [rbp+30],edx
       mov       [rbp+34],edx
       mov       byte ptr [rbp+38],0
       mov       byte ptr [rbp+39],0
       mov       byte ptr [rbp+3A],1
       lea       rdx,[rbp+40]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],0B
       lea       rcx,[rbp+40]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M03_L17
       mov       rcx,[rcx]
       mov       byte ptr [rcx],0
       mov       dword ptr [rbp+30],0A
       mov       byte ptr [rbp+38],0
       lea       rcx,[rbp+40]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M03_L17
       mov       r12,[rcx]
       lea       rcx,[r12+0A]
       mov       edx,esi
       xor       r8d,r8d
       call      System.Number.UInt32ToDecChars(Byte*, UInt32, Int32)
       add       r12,0A
       sub       r12,rax
       mov       ecx,r12d
       mov       [rbp+30],ecx
       mov       [rbp+34],ecx
       lea       rdx,[rbp+40]
       cmp       dword ptr [rdx+8],0
       jbe       near ptr M03_L17
       mov       rdx,[rdx]
       dec       ecx
       test      ecx,ecx
       jl        short M03_L12
M03_L09:
       lea       r8,[rdx+1]
       lea       r9,[rax+1]
       movzx     eax,byte ptr [rax]
       mov       [rdx],al
       dec       ecx
       test      ecx,ecx
       mov       rax,r9
       jge       short M03_L11
M03_L10:
       mov       byte ptr [r8],0
       test      [rsp],esp
       sub       rsp,40
       lea       rcx,[rsp+30]
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rdx,[rbp+20]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],20
       xor       ecx,ecx
       mov       [rbp+18],ecx
       test      r15d,r15d
       je        short M03_L14
       mov       [rsp+20],rdi
       lea       rcx,[rbp+10]
       lea       rdx,[rbp+30]
       mov       r8d,r15d
       mov       r9d,[rbp+50]
       call      System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L11:
       mov       rdx,r8
       jmp       short M03_L09
M03_L12:
       mov       r8,rdx
       jmp       short M03_L10
M03_L13:
       call      System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
       jmp       near ptr M03_L08
M03_L14:
       lea       rcx,[rbp+10]
       lea       rdx,[rbp+30]
       mov       [rbp],rbx
       mov       [rbp+8],r14d
       lea       r8,[rbp]
       mov       r9,rdi
       call      System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+10]
       call      System.Text.ValueStringBuilder.ToString()
       mov       rcx,1D7D76F3AC1B
       cmp       [rbp+68],rcx
       je        short M03_L16
       call      CORINFO_HELP_FAIL_FAST
M03_L16:
       nop
       lea       rsp,[rbp+70]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 627
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,22194133020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9DB4F4000
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
**Method was not JITted yet.**
System.Text.StringBuilder.Append(Char, Int32)

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString_Comparison()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       cmp       qword ptr [rsi+288],0
       jne       short M00_L00
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L00:
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
       mov       rcx,[rsi+288]
       mov       edx,[rcx+8]
       add       edx,edx
       mov       rcx,rdi
       call      qword ptr [7FF9CF20B150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,12F9A000C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,12F90000528
       mov       rbp,[rdx]
       mov       rdx,12F9A000C98
       mov       r14,[rdx]
M00_L01:
       mov       rdx,[rsi+288]
       cmp       ebx,[rdx+8]
       jae       near ptr M00_L06
       mov       ecx,ebx
       lea       rdx,[rdx+rcx+10]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r14
       call      qword ptr [7FF9CF1B3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L02:
       inc       ebx
       mov       rax,[rsi+288]
       mov       eax,[rax+8]
       movsxd    rdx,ebx
       cmp       rax,rdx
       jg        short M00_L01
M00_L03:
       mov       ecx,[rdi+18]
       mov       edx,ecx
       mov       r8,[rdi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M00_L04
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],27
       inc       ecx
       mov       [rdi+18],ecx
       jmp       short M00_L05
M00_L04:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF9CF20B258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FF9CF1EFE70]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rsi+8],rdx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 384
```
```assembly
; System.Text.StringBuilder.set_Capacity(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      edx,edx
       jl        near ptr M01_L05
       cmp       edx,[rsi+20]
       jg        near ptr M01_L06
       mov       ecx,[rsi+1C]
       mov       eax,ecx
       add       eax,[rsi+18]
       cmp       eax,edx
       jg        near ptr M01_L07
       mov       rax,[rsi+8]
       mov       r8d,ecx
       add       r8d,[rax+8]
       cmp       r8d,edx
       je        short M01_L01
       mov       edi,edx
       sub       edi,ecx
       cmp       edi,400
       jge       short M01_L02
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
M01_L00:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rbx
       call      qword ptr [7FF9CEEE9018]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       test      rax,rax
       je        short M01_L04
       mov       rcx,[rax+18]
M01_L03:
       mov       edx,edi
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rbx,rax
       jmp       short M01_L00
M01_L04:
       xor       ecx,ecx
       jmp       short M01_L03
M01_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF02D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF02D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF02D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 456
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,r8d
       test      esi,esi
       je        short M02_L03
       mov       r8,[rdi+8]
       mov       ebx,[rdi+18]
       lea       ecx,[rbx+rsi]
       cmp       ecx,[r8+8]
       ja        short M02_L02
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       short M02_L01
       movsxd    r8,esi
       add       r8,r8
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L00:
       add       esi,ebx
       mov       [rdi+18],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L01:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       short M02_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M02_L00
M02_L02:
       mov       rcx,rdi
       mov       r8d,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9CF20B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
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
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       vmovdqa   xmmword ptr [rbp+50],xmm4
       mov       [rbp+60],rax
       mov       rax,0F3583EA94BBC
       mov       [rbp+80],rax
       mov       esi,ecx
       mov       rdi,r8
       test      rdx,rdx
       je        short M03_L01
       lea       rbx,[rdx+0C]
       mov       r14d,[rdx+8]
M03_L00:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       rcx,[rbp+18]
       lea       rdx,[rbp+68]
       call      qword ptr [7FF9CF1B36F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
       mov       r15d,eax
       mov       r12d,r15d
       and       r12d,0FFDF
       cmp       r12d,47
       je        short M03_L02
       cmp       r12d,44
       jne       short M03_L03
       jmp       short M03_L05
M03_L01:
       xor       ebx,ebx
       xor       r14d,r14d
       jmp       short M03_L00
M03_L02:
       cmp       dword ptr [rbp+68],0
       jle       short M03_L05
M03_L03:
       cmp       r12d,58
       jne       short M03_L07
       add       r15d,0FFFFFFDF
       movzx     edx,r15w
       mov       ecx,esi
       mov       r8d,[rbp+68]
       call      qword ptr [7FF9CF1B3348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,0F3583EA94BBC
       cmp       [rbp+80],rcx
       je        short M03_L04
       call      CORINFO_HELP_FAIL_FAST
M03_L04:
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
M03_L05:
       mov       ecx,esi
       mov       edx,[rbp+68]
       call      qword ptr [7FF9CF1B3408]
       mov       rcx,0F3583EA94BBC
       cmp       [rbp+80],rcx
       je        short M03_L06
       call      CORINFO_HELP_FAIL_FAST
M03_L06:
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
M03_L07:
       test      rdi,rdi
       je        short M03_L08
       mov       rcx,rdi
       call      qword ptr [7FF9CF1796D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FF9CF179288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FF9CF815918]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FF9CF815930]
       lea       rcx,[rax+0A]
       xor       edx,edx
       jmp       short M03_L11
M03_L10:
       mov       r8d,0CCCCCCCD
       mov       r9d,esi
       imul      r8,r9
       shr       r8,23
       lea       r9d,[r8+r8*4]
       add       r9d,r9d
       sub       esi,r9d
       dec       rcx
       add       esi,30
       mov       [rcx],sil
       mov       esi,r8d
M03_L11:
       dec       edx
       jns       short M03_L10
       test      esi,esi
       jne       short M03_L10
       mov       rsi,rcx
       add       rax,0A
       sub       rax,rsi
       mov       r12d,eax
       mov       [rbp+48],r12d
       mov       [rbp+4C],r12d
       lea       rcx,[rbp+48]
       call      qword ptr [7FF9CF815930]
       jmp       short M03_L13
M03_L12:
       lea       rcx,[rax+1]
       lea       rdx,[rsi+1]
       mov       r13,rdx
       movzx     edx,byte ptr [rsi]
       mov       [rax],dl
       mov       rax,rcx
       mov       rsi,r13
M03_L13:
       dec       r12d
       jns       short M03_L12
       mov       byte ptr [rax],0
       test      [rsp],esp
       sub       rsp,40
       lea       rcx,[rsp+30]
       xor       edx,edx
       mov       [rbp+28],rdx
       mov       [rbp+38],rcx
       mov       dword ptr [rbp+40],20
       mov       [rbp+30],edx
       test      r15d,r15d
       je        short M03_L14
       mov       [rsp+20],rdi
       lea       rcx,[rbp+28]
       lea       rdx,[rbp+48]
       mov       r8d,r15d
       mov       r9d,[rbp+68]
       call      qword ptr [7FF9CF1B3708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FF9CF1B3720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FF9CF329B40]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,0F3583EA94BBC
       cmp       [rbp+80],rcx
       je        short M03_L16
       call      CORINFO_HELP_FAIL_FAST
M03_L16:
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
; Total bytes of code 637
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,12F90002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF02D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString_Comparison()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       cmp       qword ptr [rsi+288],0
       jne       short M00_L00
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L00:
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
       mov       rcx,[rsi+288]
       mov       edx,[rcx+8]
       add       edx,edx
       mov       rcx,rdi
       call      System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,217669A1C40
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,216F69A1568
       mov       rbp,[rdx]
       mov       rdx,217669A1C48
       mov       r14,[rdx]
M00_L01:
       mov       rdx,[rsi+288]
       cmp       ebx,[rdx+8]
       jae       near ptr M00_L05
       movsxd    rcx,ebx
       lea       rdx,[rdx+rcx+10]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r14
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       mov       rax,[rsi+288]
       mov       eax,[rax+8]
       movsxd    rax,eax
       movsxd    rdx,ebx
       cmp       rax,rdx
       jg        short M00_L01
M00_L02:
       mov       ecx,[rdi+18]
       mov       edx,ecx
       mov       r8,[rdi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M00_L03
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],27
       inc       ecx
       mov       [rdi+18],ecx
       jmp       short M00_L04
M00_L03:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M00_L04:
       mov       rcx,rdi
       call      qword ptr [7FF9DB79BC48]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rsi+8],rdx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 366
```
```assembly
; System.Text.StringBuilder.set_Capacity(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      edx,edx
       jl        near ptr M01_L05
       cmp       edx,[rsi+20]
       jg        near ptr M01_L06
       mov       ecx,[rsi+1C]
       mov       eax,ecx
       add       eax,[rsi+18]
       cmp       eax,edx
       jg        near ptr M01_L07
       mov       rax,[rsi+8]
       mov       r8d,ecx
       add       r8d,[rax+8]
       cmp       r8d,edx
       je        short M01_L01
       mov       edi,edx
       sub       edi,ecx
       cmp       edi,400
       jge       short M01_L02
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
M01_L00:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       test      rax,rax
       je        short M01_L04
       mov       rcx,[rax+18]
M01_L03:
       mov       edx,edi
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rbx,rax
       jmp       short M01_L00
M01_L04:
       xor       ecx,ecx
       jmp       short M01_L03
M01_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FF9DB4F4000
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
; Total bytes of code 449
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rdx,rdx
       je        short M02_L01
       mov       rdi,[rsi+8]
       mov       ebx,[rsi+18]
       mov       ebp,[rdx+8]
       lea       r14d,[rbx+rbp]
       cmp       r14d,[rdi+8]
       jae       short M02_L04
       cmp       ebp,2
       jle       short M02_L02
       add       rdi,10
       movsxd    r8,ebx
       lea       rcx,[rdi+r8*2]
       add       rdx,0C
       movsxd    r8,ebp
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L00:
       mov       [rsi+18],r14d
M02_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       test      ebp,ebp
       jle       short M02_L03
       cmp       dword ptr [rdx+8],0
       jbe       short M02_L05
       movzx     ecx,word ptr [rdx+0C]
       cmp       ebx,[rdi+8]
       jae       short M02_L05
       movsxd    rax,ebx
       mov       [rdi+rax*2+10],cx
M02_L03:
       cmp       ebp,1
       jle       short M02_L00
       cmp       dword ptr [rdx+8],1
       jbe       short M02_L05
       movzx     ecx,word ptr [rdx+0E]
       lea       edx,[rbx+1]
       cmp       edx,[rdi+8]
       jae       short M02_L05
       inc       ebx
       movsxd    rdx,ebx
       mov       [rdi+rdx*2+10],cx
       jmp       short M02_L00
M02_L04:
       mov       rcx,rsi
       call      System.Text.StringBuilder.AppendHelper(System.String)
       jmp       short M02_L01
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 165
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A0
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp],xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       rax,9522CFAF7EBA
       mov       [rbp+68],rax
       mov       esi,ecx
       mov       rdi,r8
       test      rdx,rdx
       je        short M03_L01
       lea       rbx,[rdx+0C]
       mov       r14d,[rdx+8]
M03_L00:
       mov       [rbp],rbx
       mov       [rbp+8],r14d
       lea       rcx,[rbp]
       lea       rdx,[rbp+50]
       call      System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
       mov       r15d,eax
       mov       r12d,r15d
       and       r12d,0FFDF
       cmp       r12d,47
       je        short M03_L02
       cmp       r12d,44
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L05
       jmp       short M03_L03
M03_L01:
       xor       ebx,ebx
       xor       r14d,r14d
       jmp       short M03_L00
M03_L02:
       cmp       dword ptr [rbp+50],0
       setle     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L05
M03_L03:
       mov       ecx,esi
       mov       edx,[rbp+50]
       call      System.Number.UInt32ToDecStr(UInt32, Int32)
       mov       rcx,9522CFAF7EBA
       cmp       [rbp+68],rcx
       je        short M03_L04
       call      CORINFO_HELP_FAIL_FAST
M03_L04:
       nop
       lea       rsp,[rbp+70]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L05:
       cmp       r12d,58
       jne       short M03_L07
       add       r15d,0FFFFFFDF
       movzx     edx,r15w
       mov       ecx,esi
       mov       r8d,[rbp+50]
       call      System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,9522CFAF7EBA
       cmp       [rbp+68],rcx
       je        short M03_L06
       call      CORINFO_HELP_FAIL_FAST
M03_L06:
       nop
       lea       rsp,[rbp+70]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L07:
       test      rdi,rdi
       je        near ptr M03_L13
       mov       rcx,rdi
       call      System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|45_0(System.IFormatProvider)
       mov       rdi,rax
M03_L08:
       lea       rcx,[rbp+58]
       xor       edx,edx
       mov       [rbp+30],edx
       mov       [rbp+34],edx
       mov       byte ptr [rbp+38],0
       mov       byte ptr [rbp+39],0
       mov       byte ptr [rbp+3A],1
       lea       rdx,[rbp+40]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],0B
       lea       rcx,[rbp+40]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M03_L17
       mov       rcx,[rcx]
       mov       byte ptr [rcx],0
       mov       dword ptr [rbp+30],0A
       mov       byte ptr [rbp+38],0
       lea       rcx,[rbp+40]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M03_L17
       mov       r12,[rcx]
       lea       rcx,[r12+0A]
       mov       edx,esi
       xor       r8d,r8d
       call      System.Number.UInt32ToDecChars(Byte*, UInt32, Int32)
       add       r12,0A
       sub       r12,rax
       mov       ecx,r12d
       mov       [rbp+30],ecx
       mov       [rbp+34],ecx
       lea       rdx,[rbp+40]
       cmp       dword ptr [rdx+8],0
       jbe       near ptr M03_L17
       mov       rdx,[rdx]
       dec       ecx
       test      ecx,ecx
       jl        short M03_L12
M03_L09:
       lea       r8,[rdx+1]
       lea       r9,[rax+1]
       movzx     eax,byte ptr [rax]
       mov       [rdx],al
       dec       ecx
       test      ecx,ecx
       mov       rax,r9
       jge       short M03_L11
M03_L10:
       mov       byte ptr [r8],0
       test      [rsp],esp
       sub       rsp,40
       lea       rcx,[rsp+30]
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rdx,[rbp+20]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],20
       xor       ecx,ecx
       mov       [rbp+18],ecx
       test      r15d,r15d
       je        short M03_L14
       mov       [rsp+20],rdi
       lea       rcx,[rbp+10]
       lea       rdx,[rbp+30]
       mov       r8d,r15d
       mov       r9d,[rbp+50]
       call      System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L11:
       mov       rdx,r8
       jmp       short M03_L09
M03_L12:
       mov       r8,rdx
       jmp       short M03_L10
M03_L13:
       call      System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
       jmp       near ptr M03_L08
M03_L14:
       lea       rcx,[rbp+10]
       lea       rdx,[rbp+30]
       mov       [rbp],rbx
       mov       [rbp+8],r14d
       lea       r8,[rbp]
       mov       r9,rdi
       call      System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+10]
       call      System.Text.ValueStringBuilder.ToString()
       mov       rcx,9522CFAF7EBA
       cmp       [rbp+68],rcx
       je        short M03_L16
       call      CORINFO_HELP_FAIL_FAST
M03_L16:
       nop
       lea       rsp,[rbp+70]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 627
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,216F69A3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9DB4F4000
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
**Method was not JITted yet.**
System.Text.StringBuilder.Append(Char, Int32)

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString_Comparison()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       cmp       qword ptr [rsi+288],0
       jne       short M00_L00
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L00:
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
       mov       rcx,[rsi+288]
       mov       edx,[rcx+8]
       add       edx,edx
       mov       rcx,rdi
       call      qword ptr [7FF9CF20B150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,2AD54400C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,2AD4E400528
       mov       rbp,[rdx]
       mov       rdx,2AD54400C98
       mov       r14,[rdx]
M00_L01:
       mov       rdx,[rsi+288]
       cmp       ebx,[rdx+8]
       jae       near ptr M00_L06
       mov       ecx,ebx
       lea       rdx,[rdx+rcx+10]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r14
       call      qword ptr [7FF9CF1B3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L02:
       inc       ebx
       mov       rax,[rsi+288]
       mov       eax,[rax+8]
       movsxd    rdx,ebx
       cmp       rax,rdx
       jg        short M00_L01
M00_L03:
       mov       ecx,[rdi+18]
       mov       edx,ecx
       mov       r8,[rdi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M00_L04
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],27
       inc       ecx
       mov       [rdi+18],ecx
       jmp       short M00_L05
M00_L04:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF9CF20B258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FF9CF1EFE70]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rsi+8],rdx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 384
```
```assembly
; System.Text.StringBuilder.set_Capacity(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      edx,edx
       jl        near ptr M01_L05
       cmp       edx,[rsi+20]
       jg        near ptr M01_L06
       mov       ecx,[rsi+1C]
       mov       eax,ecx
       add       eax,[rsi+18]
       cmp       eax,edx
       jg        near ptr M01_L07
       mov       rax,[rsi+8]
       mov       r8d,ecx
       add       r8d,[rax+8]
       cmp       r8d,edx
       je        short M01_L01
       mov       edi,edx
       sub       edi,ecx
       cmp       edi,400
       jge       short M01_L02
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
M01_L00:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rbx
       call      qword ptr [7FF9CEEE9018]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       test      rax,rax
       je        short M01_L04
       mov       rcx,[rax+18]
M01_L03:
       mov       edx,edi
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rbx,rax
       jmp       short M01_L00
M01_L04:
       xor       ecx,ecx
       jmp       short M01_L03
M01_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF02D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF02D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF02D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 456
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,r8d
       test      esi,esi
       je        short M02_L03
       mov       r8,[rdi+8]
       mov       ebx,[rdi+18]
       lea       ecx,[rbx+rsi]
       cmp       ecx,[r8+8]
       ja        short M02_L02
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       short M02_L01
       movsxd    r8,esi
       add       r8,r8
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L00:
       add       esi,ebx
       mov       [rdi+18],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L01:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       short M02_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M02_L00
M02_L02:
       mov       rcx,rdi
       mov       r8d,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9CF20B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
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
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       vmovdqa   xmmword ptr [rbp+50],xmm4
       mov       [rbp+60],rax
       mov       rax,8E3EDAA79A89
       mov       [rbp+80],rax
       mov       esi,ecx
       mov       rdi,r8
       test      rdx,rdx
       je        short M03_L01
       lea       rbx,[rdx+0C]
       mov       r14d,[rdx+8]
M03_L00:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       rcx,[rbp+18]
       lea       rdx,[rbp+68]
       call      qword ptr [7FF9CF1B36F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
       mov       r15d,eax
       mov       r12d,r15d
       and       r12d,0FFDF
       cmp       r12d,47
       je        short M03_L02
       cmp       r12d,44
       jne       short M03_L03
       jmp       short M03_L05
M03_L01:
       xor       ebx,ebx
       xor       r14d,r14d
       jmp       short M03_L00
M03_L02:
       cmp       dword ptr [rbp+68],0
       jle       short M03_L05
M03_L03:
       cmp       r12d,58
       jne       short M03_L07
       add       r15d,0FFFFFFDF
       movzx     edx,r15w
       mov       ecx,esi
       mov       r8d,[rbp+68]
       call      qword ptr [7FF9CF1B3348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,8E3EDAA79A89
       cmp       [rbp+80],rcx
       je        short M03_L04
       call      CORINFO_HELP_FAIL_FAST
M03_L04:
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
M03_L05:
       mov       ecx,esi
       mov       edx,[rbp+68]
       call      qword ptr [7FF9CF1B3408]
       mov       rcx,8E3EDAA79A89
       cmp       [rbp+80],rcx
       je        short M03_L06
       call      CORINFO_HELP_FAIL_FAST
M03_L06:
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
M03_L07:
       test      rdi,rdi
       je        short M03_L08
       mov       rcx,rdi
       call      qword ptr [7FF9CF1796D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FF9CF179288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FF9CF817C30]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FF9CF817C48]
       lea       rcx,[rax+0A]
       xor       edx,edx
       jmp       short M03_L11
M03_L10:
       mov       r8d,0CCCCCCCD
       mov       r9d,esi
       imul      r8,r9
       shr       r8,23
       lea       r9d,[r8+r8*4]
       add       r9d,r9d
       sub       esi,r9d
       dec       rcx
       add       esi,30
       mov       [rcx],sil
       mov       esi,r8d
M03_L11:
       dec       edx
       jns       short M03_L10
       test      esi,esi
       jne       short M03_L10
       mov       rsi,rcx
       add       rax,0A
       sub       rax,rsi
       mov       r12d,eax
       mov       [rbp+48],r12d
       mov       [rbp+4C],r12d
       lea       rcx,[rbp+48]
       call      qword ptr [7FF9CF817C48]
       jmp       short M03_L13
M03_L12:
       lea       rcx,[rax+1]
       lea       rdx,[rsi+1]
       mov       r13,rdx
       movzx     edx,byte ptr [rsi]
       mov       [rax],dl
       mov       rax,rcx
       mov       rsi,r13
M03_L13:
       dec       r12d
       jns       short M03_L12
       mov       byte ptr [rax],0
       test      [rsp],esp
       sub       rsp,40
       lea       rcx,[rsp+30]
       xor       edx,edx
       mov       [rbp+28],rdx
       mov       [rbp+38],rcx
       mov       dword ptr [rbp+40],20
       mov       [rbp+30],edx
       test      r15d,r15d
       je        short M03_L14
       mov       [rsp+20],rdi
       lea       rcx,[rbp+28]
       lea       rdx,[rbp+48]
       mov       r8d,r15d
       mov       r9d,[rbp+68]
       call      qword ptr [7FF9CF1B3708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FF9CF1B3720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FF9CF329B40]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,8E3EDAA79A89
       cmp       [rbp+80],rcx
       je        short M03_L16
       call      CORINFO_HELP_FAIL_FAST
M03_L16:
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
; Total bytes of code 637
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,2AD4E402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF02D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString_Comparison()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       cmp       qword ptr [rsi+288],0
       jne       short M00_L00
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L00:
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
       mov       rcx,[rsi+288]
       mov       edx,[rcx+8]
       add       edx,edx
       mov       rcx,rdi
       call      System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,1826D6E1C40
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,1820D6E1568
       mov       rbp,[rdx]
       mov       rdx,1826D6E1C48
       mov       r14,[rdx]
M00_L01:
       mov       rdx,[rsi+288]
       cmp       ebx,[rdx+8]
       jae       near ptr M00_L05
       movsxd    rcx,ebx
       lea       rdx,[rdx+rcx+10]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r14
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       mov       rax,[rsi+288]
       mov       eax,[rax+8]
       movsxd    rax,eax
       movsxd    rdx,ebx
       cmp       rax,rdx
       jg        short M00_L01
M00_L02:
       mov       ecx,[rdi+18]
       mov       edx,ecx
       mov       r8,[rdi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M00_L03
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],27
       inc       ecx
       mov       [rdi+18],ecx
       jmp       short M00_L04
M00_L03:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M00_L04:
       mov       rcx,rdi
       call      qword ptr [7FF9DB78BC48]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rsi+8],rdx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 366
```
```assembly
; System.Text.StringBuilder.set_Capacity(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      edx,edx
       jl        near ptr M01_L05
       cmp       edx,[rsi+20]
       jg        near ptr M01_L06
       mov       ecx,[rsi+1C]
       mov       eax,ecx
       add       eax,[rsi+18]
       cmp       eax,edx
       jg        near ptr M01_L07
       mov       rax,[rsi+8]
       mov       r8d,ecx
       add       r8d,[rax+8]
       cmp       r8d,edx
       je        short M01_L01
       mov       edi,edx
       sub       edi,ecx
       cmp       edi,400
       jge       short M01_L02
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
M01_L00:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       test      rax,rax
       je        short M01_L04
       mov       rcx,[rax+18]
M01_L03:
       mov       edx,edi
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rbx,rax
       jmp       short M01_L00
M01_L04:
       xor       ecx,ecx
       jmp       short M01_L03
M01_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9DB4E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FF9DB4E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9DB4E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FF9DB4E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9DB4E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FF9DB4E4000
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
; Total bytes of code 449
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rdx,rdx
       je        short M02_L01
       mov       rdi,[rsi+8]
       mov       ebx,[rsi+18]
       mov       ebp,[rdx+8]
       lea       r14d,[rbx+rbp]
       cmp       r14d,[rdi+8]
       jae       short M02_L04
       cmp       ebp,2
       jle       short M02_L02
       add       rdi,10
       movsxd    r8,ebx
       lea       rcx,[rdi+r8*2]
       add       rdx,0C
       movsxd    r8,ebp
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L00:
       mov       [rsi+18],r14d
M02_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       test      ebp,ebp
       jle       short M02_L03
       cmp       dword ptr [rdx+8],0
       jbe       short M02_L05
       movzx     ecx,word ptr [rdx+0C]
       cmp       ebx,[rdi+8]
       jae       short M02_L05
       movsxd    rax,ebx
       mov       [rdi+rax*2+10],cx
M02_L03:
       cmp       ebp,1
       jle       short M02_L00
       cmp       dword ptr [rdx+8],1
       jbe       short M02_L05
       movzx     ecx,word ptr [rdx+0E]
       lea       edx,[rbx+1]
       cmp       edx,[rdi+8]
       jae       short M02_L05
       inc       ebx
       movsxd    rdx,ebx
       mov       [rdi+rdx*2+10],cx
       jmp       short M02_L00
M02_L04:
       mov       rcx,rsi
       call      System.Text.StringBuilder.AppendHelper(System.String)
       jmp       short M02_L01
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 165
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A0
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp],xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       eax,0DFB9AD0F
       mov       [rbp+68],rax
       mov       esi,ecx
       mov       rdi,r8
       test      rdx,rdx
       je        short M03_L01
       lea       rbx,[rdx+0C]
       mov       r14d,[rdx+8]
M03_L00:
       mov       [rbp],rbx
       mov       [rbp+8],r14d
       lea       rcx,[rbp]
       lea       rdx,[rbp+50]
       call      System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
       mov       r15d,eax
       mov       r12d,r15d
       and       r12d,0FFDF
       cmp       r12d,47
       je        short M03_L02
       cmp       r12d,44
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L05
       jmp       short M03_L03
M03_L01:
       xor       ebx,ebx
       xor       r14d,r14d
       jmp       short M03_L00
M03_L02:
       cmp       dword ptr [rbp+50],0
       setle     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L05
M03_L03:
       mov       ecx,esi
       mov       edx,[rbp+50]
       call      System.Number.UInt32ToDecStr(UInt32, Int32)
       mov       ecx,0DFB9AD0F
       cmp       [rbp+68],rcx
       je        short M03_L04
       call      CORINFO_HELP_FAIL_FAST
M03_L04:
       nop
       lea       rsp,[rbp+70]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L05:
       cmp       r12d,58
       jne       short M03_L07
       add       r15d,0FFFFFFDF
       movzx     edx,r15w
       mov       ecx,esi
       mov       r8d,[rbp+50]
       call      System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       ecx,0DFB9AD0F
       cmp       [rbp+68],rcx
       je        short M03_L06
       call      CORINFO_HELP_FAIL_FAST
M03_L06:
       nop
       lea       rsp,[rbp+70]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L07:
       test      rdi,rdi
       je        near ptr M03_L13
       mov       rcx,rdi
       call      System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|45_0(System.IFormatProvider)
       mov       rdi,rax
M03_L08:
       lea       rcx,[rbp+58]
       xor       edx,edx
       mov       [rbp+30],edx
       mov       [rbp+34],edx
       mov       byte ptr [rbp+38],0
       mov       byte ptr [rbp+39],0
       mov       byte ptr [rbp+3A],1
       lea       rdx,[rbp+40]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],0B
       lea       rcx,[rbp+40]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M03_L17
       mov       rcx,[rcx]
       mov       byte ptr [rcx],0
       mov       dword ptr [rbp+30],0A
       mov       byte ptr [rbp+38],0
       lea       rcx,[rbp+40]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M03_L17
       mov       r12,[rcx]
       lea       rcx,[r12+0A]
       mov       edx,esi
       xor       r8d,r8d
       call      System.Number.UInt32ToDecChars(Byte*, UInt32, Int32)
       add       r12,0A
       sub       r12,rax
       mov       ecx,r12d
       mov       [rbp+30],ecx
       mov       [rbp+34],ecx
       lea       rdx,[rbp+40]
       cmp       dword ptr [rdx+8],0
       jbe       near ptr M03_L17
       mov       rdx,[rdx]
       dec       ecx
       test      ecx,ecx
       jl        short M03_L12
M03_L09:
       lea       r8,[rdx+1]
       lea       r9,[rax+1]
       movzx     eax,byte ptr [rax]
       mov       [rdx],al
       dec       ecx
       test      ecx,ecx
       mov       rax,r9
       jge       short M03_L11
M03_L10:
       mov       byte ptr [r8],0
       test      [rsp],esp
       sub       rsp,40
       lea       rcx,[rsp+30]
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rdx,[rbp+20]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],20
       xor       ecx,ecx
       mov       [rbp+18],ecx
       test      r15d,r15d
       je        short M03_L14
       mov       [rsp+20],rdi
       lea       rcx,[rbp+10]
       lea       rdx,[rbp+30]
       mov       r8d,r15d
       mov       r9d,[rbp+50]
       call      System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L11:
       mov       rdx,r8
       jmp       short M03_L09
M03_L12:
       mov       r8,rdx
       jmp       short M03_L10
M03_L13:
       call      System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
       jmp       near ptr M03_L08
M03_L14:
       lea       rcx,[rbp+10]
       lea       rdx,[rbp+30]
       mov       [rbp],rbx
       mov       [rbp+8],r14d
       lea       r8,[rbp]
       mov       r9,rdi
       call      System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+10]
       call      System.Text.ValueStringBuilder.ToString()
       mov       ecx,0DFB9AD0F
       cmp       [rbp+68],rcx
       je        short M03_L16
       call      CORINFO_HELP_FAIL_FAST
M03_L16:
       nop
       lea       rsp,[rbp+70]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 607
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,1820D6E3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FF9DB4E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9DB4E4000
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
**Method was not JITted yet.**
System.Text.StringBuilder.Append(Char, Int32)

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString_Comparison()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       cmp       qword ptr [rsi+288],0
       jne       short M00_L00
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L00:
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
       mov       rcx,[rsi+288]
       mov       edx,[rcx+8]
       add       edx,edx
       mov       rcx,rdi
       call      qword ptr [7FF9CF23B150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,27EDE811820
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FF9CF23B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,27EDE800528
       mov       rbp,[rdx]
       mov       rdx,27EDE811828
       mov       r14,[rdx]
M00_L01:
       mov       rdx,[rsi+288]
       cmp       ebx,[rdx+8]
       jae       near ptr M00_L06
       mov       ecx,ebx
       lea       rdx,[rdx+rcx+10]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r14
       call      qword ptr [7FF9CF1E3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF23B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L02:
       inc       ebx
       mov       rax,[rsi+288]
       mov       eax,[rax+8]
       movsxd    rdx,ebx
       cmp       rax,rdx
       jg        short M00_L01
M00_L03:
       mov       ecx,[rdi+18]
       mov       edx,ecx
       mov       r8,[rdi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M00_L04
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],27
       inc       ecx
       mov       [rdi+18],ecx
       jmp       short M00_L05
M00_L04:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF9CF23B258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FF9CF21FE70]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rsi+8],rdx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 384
```
```assembly
; System.Text.StringBuilder.set_Capacity(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      edx,edx
       jl        near ptr M01_L05
       cmp       edx,[rsi+20]
       jg        near ptr M01_L06
       mov       ecx,[rsi+1C]
       mov       eax,ecx
       add       eax,[rsi+18]
       cmp       eax,edx
       jg        near ptr M01_L07
       mov       rax,[rsi+8]
       mov       r8d,ecx
       add       r8d,[rax+8]
       cmp       r8d,edx
       je        short M01_L01
       mov       edi,edx
       sub       edi,ecx
       cmp       edi,400
       jge       short M01_L02
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
M01_L00:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rbx
       call      qword ptr [7FF9CEF19018]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       test      rax,rax
       je        short M01_L04
       mov       rcx,[rax+18]
M01_L03:
       mov       edx,edi
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rbx,rax
       jmp       short M01_L00
M01_L04:
       xor       ecx,ecx
       jmp       short M01_L03
M01_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9CEDE4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FF9CEDE4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF05D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1E5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9CEDE4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FF9CEDE4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF05D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1E5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9CEDE4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FF9CEDE4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF05D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1E5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 456
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,r8d
       test      esi,esi
       je        short M02_L03
       mov       r8,[rdi+8]
       mov       ebx,[rdi+18]
       lea       ecx,[rbx+rsi]
       cmp       ecx,[r8+8]
       ja        short M02_L02
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       short M02_L01
       movsxd    r8,esi
       add       r8,r8
       call      qword ptr [7FF9CF0799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L00:
       add       esi,ebx
       mov       [rdi+18],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L01:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       short M02_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M02_L00
M02_L02:
       mov       rcx,rdi
       mov       r8d,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9CF23B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
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
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       vmovdqa   xmmword ptr [rbp+50],xmm4
       mov       [rbp+60],rax
       mov       rax,567489FB964F
       mov       [rbp+80],rax
       mov       esi,ecx
       mov       rdi,r8
       test      rdx,rdx
       je        short M03_L01
       lea       rbx,[rdx+0C]
       mov       r14d,[rdx+8]
M03_L00:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       rcx,[rbp+18]
       lea       rdx,[rbp+68]
       call      qword ptr [7FF9CF1E36F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
       mov       r15d,eax
       mov       r12d,r15d
       and       r12d,0FFDF
       cmp       r12d,47
       je        short M03_L02
       cmp       r12d,44
       jne       short M03_L03
       jmp       short M03_L05
M03_L01:
       xor       ebx,ebx
       xor       r14d,r14d
       jmp       short M03_L00
M03_L02:
       cmp       dword ptr [rbp+68],0
       jle       short M03_L05
M03_L03:
       cmp       r12d,58
       jne       short M03_L07
       add       r15d,0FFFFFFDF
       movzx     edx,r15w
       mov       ecx,esi
       mov       r8d,[rbp+68]
       call      qword ptr [7FF9CF1E3348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,567489FB964F
       cmp       [rbp+80],rcx
       je        short M03_L04
       call      CORINFO_HELP_FAIL_FAST
M03_L04:
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
M03_L05:
       mov       ecx,esi
       mov       edx,[rbp+68]
       call      qword ptr [7FF9CF1E3408]
       mov       rcx,567489FB964F
       cmp       [rbp+80],rcx
       je        short M03_L06
       call      CORINFO_HELP_FAIL_FAST
M03_L06:
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
M03_L07:
       test      rdi,rdi
       je        short M03_L08
       mov       rcx,rdi
       call      qword ptr [7FF9CF1A96D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FF9CF1A9288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FF9CF847810]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FF9CF847828]
       lea       rcx,[rax+0A]
       xor       edx,edx
       jmp       short M03_L11
M03_L10:
       mov       r8d,0CCCCCCCD
       mov       r9d,esi
       imul      r8,r9
       shr       r8,23
       lea       r9d,[r8+r8*4]
       add       r9d,r9d
       sub       esi,r9d
       dec       rcx
       add       esi,30
       mov       [rcx],sil
       mov       esi,r8d
M03_L11:
       dec       edx
       jns       short M03_L10
       test      esi,esi
       jne       short M03_L10
       mov       rsi,rcx
       add       rax,0A
       sub       rax,rsi
       mov       r12d,eax
       mov       [rbp+48],r12d
       mov       [rbp+4C],r12d
       lea       rcx,[rbp+48]
       call      qword ptr [7FF9CF847828]
       jmp       short M03_L13
M03_L12:
       lea       rcx,[rax+1]
       lea       rdx,[rsi+1]
       mov       r13,rdx
       movzx     edx,byte ptr [rsi]
       mov       [rax],dl
       mov       rax,rcx
       mov       rsi,r13
M03_L13:
       dec       r12d
       jns       short M03_L12
       mov       byte ptr [rax],0
       test      [rsp],esp
       sub       rsp,40
       lea       rcx,[rsp+30]
       xor       edx,edx
       mov       [rbp+28],rdx
       mov       [rbp+38],rcx
       mov       dword ptr [rbp+40],20
       mov       [rbp+30],edx
       test      r15d,r15d
       je        short M03_L14
       mov       [rsp+20],rdi
       lea       rcx,[rbp+28]
       lea       rdx,[rbp+48]
       mov       r8d,r15d
       mov       r9d,[rbp+68]
       call      qword ptr [7FF9CF1E3708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FF9CF1E3720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FF9CF359B40]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,567489FB964F
       cmp       [rbp+80],rcx
       je        short M03_L16
       call      CORINFO_HELP_FAIL_FAST
M03_L16:
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
; Total bytes of code 637
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9CF0799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,27EDE802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FF9CEDE4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9CEDE4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF05D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1E5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString_Comparison()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       cmp       qword ptr [rsi+288],0
       jne       short M00_L00
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L00:
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
       mov       rcx,[rsi+288]
       mov       edx,[rcx+8]
       add       edx,edx
       mov       rcx,rdi
       call      System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,220C67F27D0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,220C67E1568
       mov       rbp,[rdx]
       mov       rdx,220C67F27D8
       mov       r14,[rdx]
M00_L01:
       mov       rdx,[rsi+288]
       cmp       ebx,[rdx+8]
       jae       near ptr M00_L05
       movsxd    rcx,ebx
       lea       rdx,[rdx+rcx+10]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r14
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       mov       rax,[rsi+288]
       mov       eax,[rax+8]
       movsxd    rax,eax
       movsxd    rdx,ebx
       cmp       rax,rdx
       jg        short M00_L01
M00_L02:
       mov       ecx,[rdi+18]
       mov       edx,ecx
       mov       r8,[rdi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M00_L03
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],27
       inc       ecx
       mov       [rdi+18],ecx
       jmp       short M00_L04
M00_L03:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M00_L04:
       mov       rcx,rdi
       call      qword ptr [7FF9DB79BC48]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rsi+8],rdx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 366
```
```assembly
; System.Text.StringBuilder.set_Capacity(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      edx,edx
       jl        near ptr M01_L05
       cmp       edx,[rsi+20]
       jg        near ptr M01_L06
       mov       ecx,[rsi+1C]
       mov       eax,ecx
       add       eax,[rsi+18]
       cmp       eax,edx
       jg        near ptr M01_L07
       mov       rax,[rsi+8]
       mov       r8d,ecx
       add       r8d,[rax+8]
       cmp       r8d,edx
       je        short M01_L01
       mov       edi,edx
       sub       edi,ecx
       cmp       edi,400
       jge       short M01_L02
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
M01_L00:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       test      rax,rax
       je        short M01_L04
       mov       rcx,[rax+18]
M01_L03:
       mov       edx,edi
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rbx,rax
       jmp       short M01_L00
M01_L04:
       xor       ecx,ecx
       jmp       short M01_L03
M01_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FF9DB4F4000
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
; Total bytes of code 449
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rdx,rdx
       je        short M02_L01
       mov       rdi,[rsi+8]
       mov       ebx,[rsi+18]
       mov       ebp,[rdx+8]
       lea       r14d,[rbx+rbp]
       cmp       r14d,[rdi+8]
       jae       short M02_L04
       cmp       ebp,2
       jle       short M02_L02
       add       rdi,10
       movsxd    r8,ebx
       lea       rcx,[rdi+r8*2]
       add       rdx,0C
       movsxd    r8,ebp
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L00:
       mov       [rsi+18],r14d
M02_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       test      ebp,ebp
       jle       short M02_L03
       cmp       dword ptr [rdx+8],0
       jbe       short M02_L05
       movzx     ecx,word ptr [rdx+0C]
       cmp       ebx,[rdi+8]
       jae       short M02_L05
       movsxd    rax,ebx
       mov       [rdi+rax*2+10],cx
M02_L03:
       cmp       ebp,1
       jle       short M02_L00
       cmp       dword ptr [rdx+8],1
       jbe       short M02_L05
       movzx     ecx,word ptr [rdx+0E]
       lea       edx,[rbx+1]
       cmp       edx,[rdi+8]
       jae       short M02_L05
       inc       ebx
       movsxd    rdx,ebx
       mov       [rdi+rdx*2+10],cx
       jmp       short M02_L00
M02_L04:
       mov       rcx,rsi
       call      System.Text.StringBuilder.AppendHelper(System.String)
       jmp       short M02_L01
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 165
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A0
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp],xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       rax,0D945BA779912
       mov       [rbp+68],rax
       mov       esi,ecx
       mov       rdi,r8
       test      rdx,rdx
       je        short M03_L01
       lea       rbx,[rdx+0C]
       mov       r14d,[rdx+8]
M03_L00:
       mov       [rbp],rbx
       mov       [rbp+8],r14d
       lea       rcx,[rbp]
       lea       rdx,[rbp+50]
       call      System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
       mov       r15d,eax
       mov       r12d,r15d
       and       r12d,0FFDF
       cmp       r12d,47
       je        short M03_L02
       cmp       r12d,44
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L05
       jmp       short M03_L03
M03_L01:
       xor       ebx,ebx
       xor       r14d,r14d
       jmp       short M03_L00
M03_L02:
       cmp       dword ptr [rbp+50],0
       setle     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L05
M03_L03:
       mov       ecx,esi
       mov       edx,[rbp+50]
       call      System.Number.UInt32ToDecStr(UInt32, Int32)
       mov       rcx,0D945BA779912
       cmp       [rbp+68],rcx
       je        short M03_L04
       call      CORINFO_HELP_FAIL_FAST
M03_L04:
       nop
       lea       rsp,[rbp+70]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L05:
       cmp       r12d,58
       jne       short M03_L07
       add       r15d,0FFFFFFDF
       movzx     edx,r15w
       mov       ecx,esi
       mov       r8d,[rbp+50]
       call      System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,0D945BA779912
       cmp       [rbp+68],rcx
       je        short M03_L06
       call      CORINFO_HELP_FAIL_FAST
M03_L06:
       nop
       lea       rsp,[rbp+70]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L07:
       test      rdi,rdi
       je        near ptr M03_L13
       mov       rcx,rdi
       call      System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|45_0(System.IFormatProvider)
       mov       rdi,rax
M03_L08:
       lea       rcx,[rbp+58]
       xor       edx,edx
       mov       [rbp+30],edx
       mov       [rbp+34],edx
       mov       byte ptr [rbp+38],0
       mov       byte ptr [rbp+39],0
       mov       byte ptr [rbp+3A],1
       lea       rdx,[rbp+40]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],0B
       lea       rcx,[rbp+40]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M03_L17
       mov       rcx,[rcx]
       mov       byte ptr [rcx],0
       mov       dword ptr [rbp+30],0A
       mov       byte ptr [rbp+38],0
       lea       rcx,[rbp+40]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M03_L17
       mov       r12,[rcx]
       lea       rcx,[r12+0A]
       mov       edx,esi
       xor       r8d,r8d
       call      System.Number.UInt32ToDecChars(Byte*, UInt32, Int32)
       add       r12,0A
       sub       r12,rax
       mov       ecx,r12d
       mov       [rbp+30],ecx
       mov       [rbp+34],ecx
       lea       rdx,[rbp+40]
       cmp       dword ptr [rdx+8],0
       jbe       near ptr M03_L17
       mov       rdx,[rdx]
       dec       ecx
       test      ecx,ecx
       jl        short M03_L12
M03_L09:
       lea       r8,[rdx+1]
       lea       r9,[rax+1]
       movzx     eax,byte ptr [rax]
       mov       [rdx],al
       dec       ecx
       test      ecx,ecx
       mov       rax,r9
       jge       short M03_L11
M03_L10:
       mov       byte ptr [r8],0
       test      [rsp],esp
       sub       rsp,40
       lea       rcx,[rsp+30]
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rdx,[rbp+20]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],20
       xor       ecx,ecx
       mov       [rbp+18],ecx
       test      r15d,r15d
       je        short M03_L14
       mov       [rsp+20],rdi
       lea       rcx,[rbp+10]
       lea       rdx,[rbp+30]
       mov       r8d,r15d
       mov       r9d,[rbp+50]
       call      System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L11:
       mov       rdx,r8
       jmp       short M03_L09
M03_L12:
       mov       r8,rdx
       jmp       short M03_L10
M03_L13:
       call      System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
       jmp       near ptr M03_L08
M03_L14:
       lea       rcx,[rbp+10]
       lea       rdx,[rbp+30]
       mov       [rbp],rbx
       mov       [rbp+8],r14d
       lea       r8,[rbp]
       mov       r9,rdi
       call      System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+10]
       call      System.Text.ValueStringBuilder.ToString()
       mov       rcx,0D945BA779912
       cmp       [rbp+68],rcx
       je        short M03_L16
       call      CORINFO_HELP_FAIL_FAST
M03_L16:
       nop
       lea       rsp,[rbp+70]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 627
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,220C67E3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9DB4F4000
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
**Method was not JITted yet.**
System.Text.StringBuilder.Append(Char, Int32)

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString_Comparison()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       cmp       qword ptr [rsi+288],0
       jne       short M00_L00
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L00:
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
       mov       rcx,[rsi+288]
       mov       edx,[rcx+8]
       add       edx,edx
       mov       rcx,rdi
       call      qword ptr [7FF9CF20B150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,1F6E9011820
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,1F6E9000528
       mov       rbp,[rdx]
       mov       rdx,1F6E9011828
       mov       r14,[rdx]
M00_L01:
       mov       rdx,[rsi+288]
       cmp       ebx,[rdx+8]
       jae       near ptr M00_L06
       mov       ecx,ebx
       lea       rdx,[rdx+rcx+10]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r14
       call      qword ptr [7FF9CF1B3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L02:
       inc       ebx
       mov       rax,[rsi+288]
       mov       eax,[rax+8]
       movsxd    rdx,ebx
       cmp       rax,rdx
       jg        short M00_L01
M00_L03:
       mov       ecx,[rdi+18]
       mov       edx,ecx
       mov       r8,[rdi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M00_L04
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],27
       inc       ecx
       mov       [rdi+18],ecx
       jmp       short M00_L05
M00_L04:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF9CF20B258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FF9CF1EFE70]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rsi+8],rdx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 384
```
```assembly
; System.Text.StringBuilder.set_Capacity(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      edx,edx
       jl        near ptr M01_L05
       cmp       edx,[rsi+20]
       jg        near ptr M01_L06
       mov       ecx,[rsi+1C]
       mov       eax,ecx
       add       eax,[rsi+18]
       cmp       eax,edx
       jg        near ptr M01_L07
       mov       rax,[rsi+8]
       mov       r8d,ecx
       add       r8d,[rax+8]
       cmp       r8d,edx
       je        short M01_L01
       mov       edi,edx
       sub       edi,ecx
       cmp       edi,400
       jge       short M01_L02
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
M01_L00:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rbx
       call      qword ptr [7FF9CEEE9018]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       test      rax,rax
       je        short M01_L04
       mov       rcx,[rax+18]
M01_L03:
       mov       edx,edi
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rbx,rax
       jmp       short M01_L00
M01_L04:
       xor       ecx,ecx
       jmp       short M01_L03
M01_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF02D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF02D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF02D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 456
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,r8d
       test      esi,esi
       je        short M02_L03
       mov       r8,[rdi+8]
       mov       ebx,[rdi+18]
       lea       ecx,[rbx+rsi]
       cmp       ecx,[r8+8]
       ja        short M02_L02
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       short M02_L01
       movsxd    r8,esi
       add       r8,r8
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L00:
       add       esi,ebx
       mov       [rdi+18],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L01:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       short M02_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M02_L00
M02_L02:
       mov       rcx,rdi
       mov       r8d,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9CF20B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
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
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       vmovdqa   xmmword ptr [rbp+50],xmm4
       mov       [rbp+60],rax
       mov       rax,6DF6EBC93211
       mov       [rbp+80],rax
       mov       esi,ecx
       mov       rdi,r8
       test      rdx,rdx
       je        short M03_L01
       lea       rbx,[rdx+0C]
       mov       r14d,[rdx+8]
M03_L00:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       rcx,[rbp+18]
       lea       rdx,[rbp+68]
       call      qword ptr [7FF9CF1B36F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
       mov       r15d,eax
       mov       r12d,r15d
       and       r12d,0FFDF
       cmp       r12d,47
       je        short M03_L02
       cmp       r12d,44
       jne       short M03_L03
       jmp       short M03_L05
M03_L01:
       xor       ebx,ebx
       xor       r14d,r14d
       jmp       short M03_L00
M03_L02:
       cmp       dword ptr [rbp+68],0
       jle       short M03_L05
M03_L03:
       cmp       r12d,58
       jne       short M03_L07
       add       r15d,0FFFFFFDF
       movzx     edx,r15w
       mov       ecx,esi
       mov       r8d,[rbp+68]
       call      qword ptr [7FF9CF1B3348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,6DF6EBC93211
       cmp       [rbp+80],rcx
       je        short M03_L04
       call      CORINFO_HELP_FAIL_FAST
M03_L04:
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
M03_L05:
       mov       ecx,esi
       mov       edx,[rbp+68]
       call      qword ptr [7FF9CF1B3408]
       mov       rcx,6DF6EBC93211
       cmp       [rbp+80],rcx
       je        short M03_L06
       call      CORINFO_HELP_FAIL_FAST
M03_L06:
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
M03_L07:
       test      rdi,rdi
       je        short M03_L08
       mov       rcx,rdi
       call      qword ptr [7FF9CF1796D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FF9CF179288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FF9CF807018]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FF9CF807030]
       lea       rcx,[rax+0A]
       xor       edx,edx
       jmp       short M03_L11
M03_L10:
       mov       r8d,0CCCCCCCD
       mov       r9d,esi
       imul      r8,r9
       shr       r8,23
       lea       r9d,[r8+r8*4]
       add       r9d,r9d
       sub       esi,r9d
       dec       rcx
       add       esi,30
       mov       [rcx],sil
       mov       esi,r8d
M03_L11:
       dec       edx
       jns       short M03_L10
       test      esi,esi
       jne       short M03_L10
       mov       rsi,rcx
       add       rax,0A
       sub       rax,rsi
       mov       r12d,eax
       mov       [rbp+48],r12d
       mov       [rbp+4C],r12d
       lea       rcx,[rbp+48]
       call      qword ptr [7FF9CF807030]
       jmp       short M03_L13
M03_L12:
       lea       rcx,[rax+1]
       lea       rdx,[rsi+1]
       mov       r13,rdx
       movzx     edx,byte ptr [rsi]
       mov       [rax],dl
       mov       rax,rcx
       mov       rsi,r13
M03_L13:
       dec       r12d
       jns       short M03_L12
       mov       byte ptr [rax],0
       test      [rsp],esp
       sub       rsp,40
       lea       rcx,[rsp+30]
       xor       edx,edx
       mov       [rbp+28],rdx
       mov       [rbp+38],rcx
       mov       dword ptr [rbp+40],20
       mov       [rbp+30],edx
       test      r15d,r15d
       je        short M03_L14
       mov       [rsp+20],rdi
       lea       rcx,[rbp+28]
       lea       rdx,[rbp+48]
       mov       r8d,r15d
       mov       r9d,[rbp+68]
       call      qword ptr [7FF9CF1B3708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FF9CF1B3720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FF9CF329B40]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,6DF6EBC93211
       cmp       [rbp+80],rcx
       je        short M03_L16
       call      CORINFO_HELP_FAIL_FAST
M03_L16:
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
; Total bytes of code 637
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,1F6E9002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF02D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString_Comparison()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       cmp       qword ptr [rsi+288],0
       jne       short M00_L00
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L00:
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
       mov       rcx,[rsi+288]
       mov       edx,[rcx+8]
       add       edx,edx
       mov       rcx,rdi
       call      System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,19ED4CE1C40
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,19E64CE1568
       mov       rbp,[rdx]
       mov       rdx,19ED4CE1C48
       mov       r14,[rdx]
M00_L01:
       mov       rdx,[rsi+288]
       cmp       ebx,[rdx+8]
       jae       near ptr M00_L05
       movsxd    rcx,ebx
       lea       rdx,[rdx+rcx+10]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r14
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       mov       rax,[rsi+288]
       mov       eax,[rax+8]
       movsxd    rax,eax
       movsxd    rdx,ebx
       cmp       rax,rdx
       jg        short M00_L01
M00_L02:
       mov       ecx,[rdi+18]
       mov       edx,ecx
       mov       r8,[rdi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M00_L03
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],27
       inc       ecx
       mov       [rdi+18],ecx
       jmp       short M00_L04
M00_L03:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M00_L04:
       mov       rcx,rdi
       call      qword ptr [7FF9DB78BC48]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rsi+8],rdx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 366
```
```assembly
; System.Text.StringBuilder.set_Capacity(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      edx,edx
       jl        near ptr M01_L05
       cmp       edx,[rsi+20]
       jg        near ptr M01_L06
       mov       ecx,[rsi+1C]
       mov       eax,ecx
       add       eax,[rsi+18]
       cmp       eax,edx
       jg        near ptr M01_L07
       mov       rax,[rsi+8]
       mov       r8d,ecx
       add       r8d,[rax+8]
       cmp       r8d,edx
       je        short M01_L01
       mov       edi,edx
       sub       edi,ecx
       cmp       edi,400
       jge       short M01_L02
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
M01_L00:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       test      rax,rax
       je        short M01_L04
       mov       rcx,[rax+18]
M01_L03:
       mov       edx,edi
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rbx,rax
       jmp       short M01_L00
M01_L04:
       xor       ecx,ecx
       jmp       short M01_L03
M01_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9DB4E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FF9DB4E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9DB4E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FF9DB4E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9DB4E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FF9DB4E4000
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
; Total bytes of code 449
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rdx,rdx
       je        short M02_L01
       mov       rdi,[rsi+8]
       mov       ebx,[rsi+18]
       mov       ebp,[rdx+8]
       lea       r14d,[rbx+rbp]
       cmp       r14d,[rdi+8]
       jae       short M02_L04
       cmp       ebp,2
       jle       short M02_L02
       add       rdi,10
       movsxd    r8,ebx
       lea       rcx,[rdi+r8*2]
       add       rdx,0C
       movsxd    r8,ebp
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L00:
       mov       [rsi+18],r14d
M02_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       test      ebp,ebp
       jle       short M02_L03
       cmp       dword ptr [rdx+8],0
       jbe       short M02_L05
       movzx     ecx,word ptr [rdx+0C]
       cmp       ebx,[rdi+8]
       jae       short M02_L05
       movsxd    rax,ebx
       mov       [rdi+rax*2+10],cx
M02_L03:
       cmp       ebp,1
       jle       short M02_L00
       cmp       dword ptr [rdx+8],1
       jbe       short M02_L05
       movzx     ecx,word ptr [rdx+0E]
       lea       edx,[rbx+1]
       cmp       edx,[rdi+8]
       jae       short M02_L05
       inc       ebx
       movsxd    rdx,ebx
       mov       [rdi+rdx*2+10],cx
       jmp       short M02_L00
M02_L04:
       mov       rcx,rsi
       call      System.Text.StringBuilder.AppendHelper(System.String)
       jmp       short M02_L01
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 165
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A0
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp],xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       rax,0D79C8B54C90B
       mov       [rbp+68],rax
       mov       esi,ecx
       mov       rdi,r8
       test      rdx,rdx
       je        short M03_L01
       lea       rbx,[rdx+0C]
       mov       r14d,[rdx+8]
M03_L00:
       mov       [rbp],rbx
       mov       [rbp+8],r14d
       lea       rcx,[rbp]
       lea       rdx,[rbp+50]
       call      System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
       mov       r15d,eax
       mov       r12d,r15d
       and       r12d,0FFDF
       cmp       r12d,47
       je        short M03_L02
       cmp       r12d,44
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L05
       jmp       short M03_L03
M03_L01:
       xor       ebx,ebx
       xor       r14d,r14d
       jmp       short M03_L00
M03_L02:
       cmp       dword ptr [rbp+50],0
       setle     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L05
M03_L03:
       mov       ecx,esi
       mov       edx,[rbp+50]
       call      System.Number.UInt32ToDecStr(UInt32, Int32)
       mov       rcx,0D79C8B54C90B
       cmp       [rbp+68],rcx
       je        short M03_L04
       call      CORINFO_HELP_FAIL_FAST
M03_L04:
       nop
       lea       rsp,[rbp+70]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L05:
       cmp       r12d,58
       jne       short M03_L07
       add       r15d,0FFFFFFDF
       movzx     edx,r15w
       mov       ecx,esi
       mov       r8d,[rbp+50]
       call      System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,0D79C8B54C90B
       cmp       [rbp+68],rcx
       je        short M03_L06
       call      CORINFO_HELP_FAIL_FAST
M03_L06:
       nop
       lea       rsp,[rbp+70]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L07:
       test      rdi,rdi
       je        near ptr M03_L13
       mov       rcx,rdi
       call      System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|45_0(System.IFormatProvider)
       mov       rdi,rax
M03_L08:
       lea       rcx,[rbp+58]
       xor       edx,edx
       mov       [rbp+30],edx
       mov       [rbp+34],edx
       mov       byte ptr [rbp+38],0
       mov       byte ptr [rbp+39],0
       mov       byte ptr [rbp+3A],1
       lea       rdx,[rbp+40]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],0B
       lea       rcx,[rbp+40]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M03_L17
       mov       rcx,[rcx]
       mov       byte ptr [rcx],0
       mov       dword ptr [rbp+30],0A
       mov       byte ptr [rbp+38],0
       lea       rcx,[rbp+40]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M03_L17
       mov       r12,[rcx]
       lea       rcx,[r12+0A]
       mov       edx,esi
       xor       r8d,r8d
       call      System.Number.UInt32ToDecChars(Byte*, UInt32, Int32)
       add       r12,0A
       sub       r12,rax
       mov       ecx,r12d
       mov       [rbp+30],ecx
       mov       [rbp+34],ecx
       lea       rdx,[rbp+40]
       cmp       dword ptr [rdx+8],0
       jbe       near ptr M03_L17
       mov       rdx,[rdx]
       dec       ecx
       test      ecx,ecx
       jl        short M03_L12
M03_L09:
       lea       r8,[rdx+1]
       lea       r9,[rax+1]
       movzx     eax,byte ptr [rax]
       mov       [rdx],al
       dec       ecx
       test      ecx,ecx
       mov       rax,r9
       jge       short M03_L11
M03_L10:
       mov       byte ptr [r8],0
       test      [rsp],esp
       sub       rsp,40
       lea       rcx,[rsp+30]
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rdx,[rbp+20]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],20
       xor       ecx,ecx
       mov       [rbp+18],ecx
       test      r15d,r15d
       je        short M03_L14
       mov       [rsp+20],rdi
       lea       rcx,[rbp+10]
       lea       rdx,[rbp+30]
       mov       r8d,r15d
       mov       r9d,[rbp+50]
       call      System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L11:
       mov       rdx,r8
       jmp       short M03_L09
M03_L12:
       mov       r8,rdx
       jmp       short M03_L10
M03_L13:
       call      System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
       jmp       near ptr M03_L08
M03_L14:
       lea       rcx,[rbp+10]
       lea       rdx,[rbp+30]
       mov       [rbp],rbx
       mov       [rbp+8],r14d
       lea       r8,[rbp]
       mov       r9,rdi
       call      System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+10]
       call      System.Text.ValueStringBuilder.ToString()
       mov       rcx,0D79C8B54C90B
       cmp       [rbp+68],rcx
       je        short M03_L16
       call      CORINFO_HELP_FAIL_FAST
M03_L16:
       nop
       lea       rsp,[rbp+70]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 627
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,19E64CE3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FF9DB4E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9DB4E4000
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
**Method was not JITted yet.**
System.Text.StringBuilder.Append(Char, Int32)

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString_Comparison()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       cmp       qword ptr [rsi+288],0
       jne       short M00_L00
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L00:
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
       mov       rcx,[rsi+288]
       mov       edx,[rcx+8]
       add       edx,edx
       mov       rcx,rdi
       call      qword ptr [7FF9CF20B150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,1B673401CA8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,1B667400528
       mov       rbp,[rdx]
       mov       rdx,1B673401CB0
       mov       r14,[rdx]
M00_L01:
       mov       rdx,[rsi+288]
       cmp       ebx,[rdx+8]
       jae       near ptr M00_L06
       mov       ecx,ebx
       lea       rdx,[rdx+rcx+10]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r14
       call      qword ptr [7FF9CF1B3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L02:
       inc       ebx
       mov       rax,[rsi+288]
       mov       eax,[rax+8]
       movsxd    rdx,ebx
       cmp       rax,rdx
       jg        short M00_L01
M00_L03:
       mov       ecx,[rdi+18]
       mov       edx,ecx
       mov       r8,[rdi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M00_L04
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],27
       inc       ecx
       mov       [rdi+18],ecx
       jmp       short M00_L05
M00_L04:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF9CF20B258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FF9CF1EFE70]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rsi+8],rdx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 384
```
```assembly
; System.Text.StringBuilder.set_Capacity(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      edx,edx
       jl        near ptr M01_L05
       cmp       edx,[rsi+20]
       jg        near ptr M01_L06
       mov       ecx,[rsi+1C]
       mov       eax,ecx
       add       eax,[rsi+18]
       cmp       eax,edx
       jg        near ptr M01_L07
       mov       rax,[rsi+8]
       mov       r8d,ecx
       add       r8d,[rax+8]
       cmp       r8d,edx
       je        short M01_L01
       mov       edi,edx
       sub       edi,ecx
       cmp       edi,400
       jge       short M01_L02
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
M01_L00:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rbx
       call      qword ptr [7FF9CEEE9018]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       test      rax,rax
       je        short M01_L04
       mov       rcx,[rax+18]
M01_L03:
       mov       edx,edi
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rbx,rax
       jmp       short M01_L00
M01_L04:
       xor       ecx,ecx
       jmp       short M01_L03
M01_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF02D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF02D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF02D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 456
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,r8d
       test      esi,esi
       je        short M02_L03
       mov       r8,[rdi+8]
       mov       ebx,[rdi+18]
       lea       ecx,[rbx+rsi]
       cmp       ecx,[r8+8]
       ja        short M02_L02
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       short M02_L01
       movsxd    r8,esi
       add       r8,r8
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L00:
       add       esi,ebx
       mov       [rdi+18],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L01:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       short M02_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M02_L00
M02_L02:
       mov       rcx,rdi
       mov       r8d,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9CF20B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
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
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       vmovdqa   xmmword ptr [rbp+50],xmm4
       mov       [rbp+60],rax
       mov       rax,93FBC7A8F3B5
       mov       [rbp+80],rax
       mov       esi,ecx
       mov       rdi,r8
       test      rdx,rdx
       je        short M03_L01
       lea       rbx,[rdx+0C]
       mov       r14d,[rdx+8]
M03_L00:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       rcx,[rbp+18]
       lea       rdx,[rbp+68]
       call      qword ptr [7FF9CF1B36F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
       mov       r15d,eax
       mov       r12d,r15d
       and       r12d,0FFDF
       cmp       r12d,47
       je        short M03_L02
       cmp       r12d,44
       jne       short M03_L03
       jmp       short M03_L05
M03_L01:
       xor       ebx,ebx
       xor       r14d,r14d
       jmp       short M03_L00
M03_L02:
       cmp       dword ptr [rbp+68],0
       jle       short M03_L05
M03_L03:
       cmp       r12d,58
       jne       short M03_L07
       add       r15d,0FFFFFFDF
       movzx     edx,r15w
       mov       ecx,esi
       mov       r8d,[rbp+68]
       call      qword ptr [7FF9CF1B3348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,93FBC7A8F3B5
       cmp       [rbp+80],rcx
       je        short M03_L04
       call      CORINFO_HELP_FAIL_FAST
M03_L04:
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
M03_L05:
       mov       ecx,esi
       mov       edx,[rbp+68]
       call      qword ptr [7FF9CF1B3408]
       mov       rcx,93FBC7A8F3B5
       cmp       [rbp+80],rcx
       je        short M03_L06
       call      CORINFO_HELP_FAIL_FAST
M03_L06:
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
M03_L07:
       test      rdi,rdi
       je        short M03_L08
       mov       rcx,rdi
       call      qword ptr [7FF9CF1796D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FF9CF179288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FF9CF807018]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FF9CF807030]
       lea       rcx,[rax+0A]
       xor       edx,edx
       jmp       short M03_L11
M03_L10:
       mov       r8d,0CCCCCCCD
       mov       r9d,esi
       imul      r8,r9
       shr       r8,23
       lea       r9d,[r8+r8*4]
       add       r9d,r9d
       sub       esi,r9d
       dec       rcx
       add       esi,30
       mov       [rcx],sil
       mov       esi,r8d
M03_L11:
       dec       edx
       jns       short M03_L10
       test      esi,esi
       jne       short M03_L10
       mov       rsi,rcx
       add       rax,0A
       sub       rax,rsi
       mov       r12d,eax
       mov       [rbp+48],r12d
       mov       [rbp+4C],r12d
       lea       rcx,[rbp+48]
       call      qword ptr [7FF9CF807030]
       jmp       short M03_L13
M03_L12:
       lea       rcx,[rax+1]
       lea       rdx,[rsi+1]
       mov       r13,rdx
       movzx     edx,byte ptr [rsi]
       mov       [rax],dl
       mov       rax,rcx
       mov       rsi,r13
M03_L13:
       dec       r12d
       jns       short M03_L12
       mov       byte ptr [rax],0
       test      [rsp],esp
       sub       rsp,40
       lea       rcx,[rsp+30]
       xor       edx,edx
       mov       [rbp+28],rdx
       mov       [rbp+38],rcx
       mov       dword ptr [rbp+40],20
       mov       [rbp+30],edx
       test      r15d,r15d
       je        short M03_L14
       mov       [rsp+20],rdi
       lea       rcx,[rbp+28]
       lea       rdx,[rbp+48]
       mov       r8d,r15d
       mov       r9d,[rbp+68]
       call      qword ptr [7FF9CF1B3708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FF9CF1B3720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FF9CF329B40]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,93FBC7A8F3B5
       cmp       [rbp+80],rcx
       je        short M03_L16
       call      CORINFO_HELP_FAIL_FAST
M03_L16:
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
; Total bytes of code 637
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,1B667402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF02D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString_Comparison()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       cmp       qword ptr [rsi+288],0
       jne       short M00_L00
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L00:
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
       mov       rcx,[rsi+288]
       mov       edx,[rcx+8]
       add       edx,edx
       mov       rcx,rdi
       call      System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,1447A521C40
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,1441A521568
       mov       rbp,[rdx]
       mov       rdx,1447A521C48
       mov       r14,[rdx]
M00_L01:
       mov       rdx,[rsi+288]
       cmp       ebx,[rdx+8]
       jae       near ptr M00_L05
       movsxd    rcx,ebx
       lea       rdx,[rdx+rcx+10]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r14
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       mov       rax,[rsi+288]
       mov       eax,[rax+8]
       movsxd    rax,eax
       movsxd    rdx,ebx
       cmp       rax,rdx
       jg        short M00_L01
M00_L02:
       mov       ecx,[rdi+18]
       mov       edx,ecx
       mov       r8,[rdi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M00_L03
       movsxd    rdx,edx
       mov       word ptr [r8+rdx*2+10],27
       inc       ecx
       mov       [rdi+18],ecx
       jmp       short M00_L04
M00_L03:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M00_L04:
       mov       rcx,rdi
       call      qword ptr [7FF9DB79BC48]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rsi+8],rdx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 366
```
```assembly
; System.Text.StringBuilder.set_Capacity(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      edx,edx
       jl        near ptr M01_L05
       cmp       edx,[rsi+20]
       jg        near ptr M01_L06
       mov       ecx,[rsi+1C]
       mov       eax,ecx
       add       eax,[rsi+18]
       cmp       eax,edx
       jg        near ptr M01_L07
       mov       rax,[rsi+8]
       mov       r8d,ecx
       add       r8d,[rax+8]
       cmp       r8d,edx
       je        short M01_L01
       mov       edi,edx
       sub       edi,ecx
       cmp       edi,400
       jge       short M01_L02
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
M01_L00:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       test      rax,rax
       je        short M01_L04
       mov       rcx,[rax+18]
M01_L03:
       mov       edx,edi
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rbx,rax
       jmp       short M01_L00
M01_L04:
       xor       ecx,ecx
       jmp       short M01_L03
M01_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FF9DB4F4000
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
; Total bytes of code 449
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rdx,rdx
       je        short M02_L01
       mov       rdi,[rsi+8]
       mov       ebx,[rsi+18]
       mov       ebp,[rdx+8]
       lea       r14d,[rbx+rbp]
       cmp       r14d,[rdi+8]
       jae       short M02_L04
       cmp       ebp,2
       jle       short M02_L02
       add       rdi,10
       movsxd    r8,ebx
       lea       rcx,[rdi+r8*2]
       add       rdx,0C
       movsxd    r8,ebp
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L00:
       mov       [rsi+18],r14d
M02_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
       test      ebp,ebp
       jle       short M02_L03
       cmp       dword ptr [rdx+8],0
       jbe       short M02_L05
       movzx     ecx,word ptr [rdx+0C]
       cmp       ebx,[rdi+8]
       jae       short M02_L05
       movsxd    rax,ebx
       mov       [rdi+rax*2+10],cx
M02_L03:
       cmp       ebp,1
       jle       short M02_L00
       cmp       dword ptr [rdx+8],1
       jbe       short M02_L05
       movzx     ecx,word ptr [rdx+0E]
       lea       edx,[rbx+1]
       cmp       edx,[rdi+8]
       jae       short M02_L05
       inc       ebx
       movsxd    rdx,ebx
       mov       [rdi+rdx*2+10],cx
       jmp       short M02_L00
M02_L04:
       mov       rcx,rsi
       call      System.Text.StringBuilder.AppendHelper(System.String)
       jmp       short M02_L01
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 165
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A0
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp],xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       mov       rax,0FDCD6A266E9B
       mov       [rbp+68],rax
       mov       esi,ecx
       mov       rdi,r8
       test      rdx,rdx
       je        short M03_L01
       lea       rbx,[rdx+0C]
       mov       r14d,[rdx+8]
M03_L00:
       mov       [rbp],rbx
       mov       [rbp+8],r14d
       lea       rcx,[rbp]
       lea       rdx,[rbp+50]
       call      System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
       mov       r15d,eax
       mov       r12d,r15d
       and       r12d,0FFDF
       cmp       r12d,47
       je        short M03_L02
       cmp       r12d,44
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L05
       jmp       short M03_L03
M03_L01:
       xor       ebx,ebx
       xor       r14d,r14d
       jmp       short M03_L00
M03_L02:
       cmp       dword ptr [rbp+50],0
       setle     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L05
M03_L03:
       mov       ecx,esi
       mov       edx,[rbp+50]
       call      System.Number.UInt32ToDecStr(UInt32, Int32)
       mov       rcx,0FDCD6A266E9B
       cmp       [rbp+68],rcx
       je        short M03_L04
       call      CORINFO_HELP_FAIL_FAST
M03_L04:
       nop
       lea       rsp,[rbp+70]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L05:
       cmp       r12d,58
       jne       short M03_L07
       add       r15d,0FFFFFFDF
       movzx     edx,r15w
       mov       ecx,esi
       mov       r8d,[rbp+50]
       call      System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,0FDCD6A266E9B
       cmp       [rbp+68],rcx
       je        short M03_L06
       call      CORINFO_HELP_FAIL_FAST
M03_L06:
       nop
       lea       rsp,[rbp+70]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L07:
       test      rdi,rdi
       je        near ptr M03_L13
       mov       rcx,rdi
       call      System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|45_0(System.IFormatProvider)
       mov       rdi,rax
M03_L08:
       lea       rcx,[rbp+58]
       xor       edx,edx
       mov       [rbp+30],edx
       mov       [rbp+34],edx
       mov       byte ptr [rbp+38],0
       mov       byte ptr [rbp+39],0
       mov       byte ptr [rbp+3A],1
       lea       rdx,[rbp+40]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],0B
       lea       rcx,[rbp+40]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M03_L17
       mov       rcx,[rcx]
       mov       byte ptr [rcx],0
       mov       dword ptr [rbp+30],0A
       mov       byte ptr [rbp+38],0
       lea       rcx,[rbp+40]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M03_L17
       mov       r12,[rcx]
       lea       rcx,[r12+0A]
       mov       edx,esi
       xor       r8d,r8d
       call      System.Number.UInt32ToDecChars(Byte*, UInt32, Int32)
       add       r12,0A
       sub       r12,rax
       mov       ecx,r12d
       mov       [rbp+30],ecx
       mov       [rbp+34],ecx
       lea       rdx,[rbp+40]
       cmp       dword ptr [rdx+8],0
       jbe       near ptr M03_L17
       mov       rdx,[rdx]
       dec       ecx
       test      ecx,ecx
       jl        short M03_L12
M03_L09:
       lea       r8,[rdx+1]
       lea       r9,[rax+1]
       movzx     eax,byte ptr [rax]
       mov       [rdx],al
       dec       ecx
       test      ecx,ecx
       mov       rax,r9
       jge       short M03_L11
M03_L10:
       mov       byte ptr [r8],0
       test      [rsp],esp
       sub       rsp,40
       lea       rcx,[rsp+30]
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rdx,[rbp+20]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],20
       xor       ecx,ecx
       mov       [rbp+18],ecx
       test      r15d,r15d
       je        short M03_L14
       mov       [rsp+20],rdi
       lea       rcx,[rbp+10]
       lea       rdx,[rbp+30]
       mov       r8d,r15d
       mov       r9d,[rbp+50]
       call      System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L11:
       mov       rdx,r8
       jmp       short M03_L09
M03_L12:
       mov       r8,rdx
       jmp       short M03_L10
M03_L13:
       call      System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
       jmp       near ptr M03_L08
M03_L14:
       lea       rcx,[rbp+10]
       lea       rdx,[rbp+30]
       mov       [rbp],rbx
       mov       [rbp+8],r14d
       lea       r8,[rbp]
       mov       r9,rdi
       call      System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+10]
       call      System.Text.ValueStringBuilder.ToString()
       mov       rcx,0FDCD6A266E9B
       cmp       [rbp+68],rcx
       je        short M03_L16
       call      CORINFO_HELP_FAIL_FAST
M03_L16:
       nop
       lea       rsp,[rbp+70]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 627
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,1441A523020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17547
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9DB4F4000
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
**Method was not JITted yet.**
System.Text.StringBuilder.Append(Char, Int32)

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString_Comparison()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       cmp       qword ptr [rsi+288],0
       jne       short M00_L00
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L00:
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
       mov       rcx,[rsi+288]
       mov       edx,[rcx+8]
       add       edx,edx
       mov       rcx,rdi
       call      qword ptr [7FF9CF1FB150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,1E6A7400C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FF9CF1FB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,1E697400528
       mov       rbp,[rdx]
       mov       rdx,1E6A7400C98
       mov       r14,[rdx]
M00_L01:
       mov       rdx,[rsi+288]
       cmp       ebx,[rdx+8]
       jae       near ptr M00_L06
       mov       ecx,ebx
       lea       rdx,[rdx+rcx+10]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r14
       call      qword ptr [7FF9CF1A3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF1FB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L02:
       inc       ebx
       mov       rax,[rsi+288]
       mov       eax,[rax+8]
       movsxd    rdx,ebx
       cmp       rax,rdx
       jg        short M00_L01
M00_L03:
       mov       ecx,[rdi+18]
       mov       edx,ecx
       mov       r8,[rdi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short M00_L04
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],27
       inc       ecx
       mov       [rdi+18],ecx
       jmp       short M00_L05
M00_L04:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF9CF1FB258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FF9CF1DFE70]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rsi+8],rdx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 384
```
```assembly
; System.Text.StringBuilder.set_Capacity(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      edx,edx
       jl        near ptr M01_L05
       cmp       edx,[rsi+20]
       jg        near ptr M01_L06
       mov       ecx,[rsi+1C]
       mov       eax,ecx
       add       eax,[rsi+18]
       cmp       eax,edx
       jg        near ptr M01_L07
       mov       rax,[rsi+8]
       mov       r8d,ecx
       add       r8d,[rax+8]
       cmp       r8d,edx
       je        short M01_L01
       mov       edi,edx
       sub       edi,ecx
       cmp       edi,400
       jge       short M01_L02
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
M01_L00:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rbx
       call      qword ptr [7FF9CEED9018]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       test      rax,rax
       je        short M01_L04
       mov       rcx,[rax+18]
M01_L03:
       mov       edx,edi
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
       mov       rbx,rax
       jmp       short M01_L00
M01_L04:
       xor       ecx,ecx
       jmp       short M01_L03
M01_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9CEDA4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FF9CEDA4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF01D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1A5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9CEDA4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FF9CEDA4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF01D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1A5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9CEDA4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FF9CEDA4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF01D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1A5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 456
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,r8d
       test      esi,esi
       je        short M02_L03
       mov       r8,[rdi+8]
       mov       ebx,[rdi+18]
       lea       ecx,[rbx+rsi]
       cmp       ecx,[r8+8]
       ja        short M02_L02
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       short M02_L01
       movsxd    r8,esi
       add       r8,r8
       call      qword ptr [7FF9CF0399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L00:
       add       esi,ebx
       mov       [rdi+18],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L01:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       short M02_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M02_L00
M02_L02:
       mov       rcx,rdi
       mov       r8d,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9CF1FB9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M02_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
```
```assembly
; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
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
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       vmovdqa   xmmword ptr [rbp+50],xmm4
       mov       [rbp+60],rax
       mov       rax,0CC74B24EEFEB
       mov       [rbp+80],rax
       mov       esi,ecx
       mov       rdi,r8
       test      rdx,rdx
       je        short M03_L01
       lea       rbx,[rdx+0C]
       mov       r14d,[rdx+8]
M03_L00:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       rcx,[rbp+18]
       lea       rdx,[rbp+68]
       call      qword ptr [7FF9CF1A36F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
       mov       r15d,eax
       mov       r12d,r15d
       and       r12d,0FFDF
       cmp       r12d,47
       je        short M03_L02
       cmp       r12d,44
       jne       short M03_L03
       jmp       short M03_L05
M03_L01:
       xor       ebx,ebx
       xor       r14d,r14d
       jmp       short M03_L00
M03_L02:
       cmp       dword ptr [rbp+68],0
       jle       short M03_L05
M03_L03:
       cmp       r12d,58
       jne       short M03_L07
       add       r15d,0FFFFFFDF
       movzx     edx,r15w
       mov       ecx,esi
       mov       r8d,[rbp+68]
       call      qword ptr [7FF9CF1A3348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,0CC74B24EEFEB
       cmp       [rbp+80],rcx
       je        short M03_L04
       call      CORINFO_HELP_FAIL_FAST
M03_L04:
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
M03_L05:
       mov       ecx,esi
       mov       edx,[rbp+68]
       call      qword ptr [7FF9CF1A3408]
       mov       rcx,0CC74B24EEFEB
       cmp       [rbp+80],rcx
       je        short M03_L06
       call      CORINFO_HELP_FAIL_FAST
M03_L06:
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
M03_L07:
       test      rdi,rdi
       je        short M03_L08
       mov       rcx,rdi
       call      qword ptr [7FF9CF1696D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FF9CF169288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FF9CF809810]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FF9CF809828]
       lea       rcx,[rax+0A]
       xor       edx,edx
       jmp       short M03_L11
M03_L10:
       mov       r8d,0CCCCCCCD
       mov       r9d,esi
       imul      r8,r9
       shr       r8,23
       lea       r9d,[r8+r8*4]
       add       r9d,r9d
       sub       esi,r9d
       dec       rcx
       add       esi,30
       mov       [rcx],sil
       mov       esi,r8d
M03_L11:
       dec       edx
       jns       short M03_L10
       test      esi,esi
       jne       short M03_L10
       mov       rsi,rcx
       add       rax,0A
       sub       rax,rsi
       mov       r12d,eax
       mov       [rbp+48],r12d
       mov       [rbp+4C],r12d
       lea       rcx,[rbp+48]
       call      qword ptr [7FF9CF809828]
       jmp       short M03_L13
M03_L12:
       lea       rcx,[rax+1]
       lea       rdx,[rsi+1]
       mov       r13,rdx
       movzx     edx,byte ptr [rsi]
       mov       [rax],dl
       mov       rax,rcx
       mov       rsi,r13
M03_L13:
       dec       r12d
       jns       short M03_L12
       mov       byte ptr [rax],0
       test      [rsp],esp
       sub       rsp,40
       lea       rcx,[rsp+30]
       xor       edx,edx
       mov       [rbp+28],rdx
       mov       [rbp+38],rcx
       mov       dword ptr [rbp+40],20
       mov       [rbp+30],edx
       test      r15d,r15d
       je        short M03_L14
       mov       [rsp+20],rdi
       lea       rcx,[rbp+28]
       lea       rdx,[rbp+48]
       mov       r8d,r15d
       mov       r9d,[rbp+68]
       call      qword ptr [7FF9CF1A3708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FF9CF1A3720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FF9CF319B40]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,0CC74B24EEFEB
       cmp       [rbp+80],rcx
       je        short M03_L16
       call      CORINFO_HELP_FAIL_FAST
M03_L16:
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
; Total bytes of code 637
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M04_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M04_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9CF0399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rax,1E697402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,179C7
       mov       rdx,7FF9CEDA4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9CEDA4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF01D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1A5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings_Comparison()
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
       mov       rbx,[rsi+2A0]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       movsxd    rcx,ebp
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9DB7ABC48]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 167
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rdx,rdx
       je        short M01_L01
       mov       rdi,[rsi+8]
       mov       ebx,[rsi+18]
       mov       ebp,[rdx+8]
       lea       r14d,[rbx+rbp]
       cmp       r14d,[rdi+8]
       jae       short M01_L04
       cmp       ebp,2
       jle       short M01_L02
       add       rdi,10
       movsxd    r8,ebx
       lea       rcx,[rdi+r8*2]
       add       rdx,0C
       movsxd    r8,ebp
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       mov       [rsi+18],r14d
M01_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       test      ebp,ebp
       jle       short M01_L03
       cmp       dword ptr [rdx+8],0
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0C]
       cmp       ebx,[rdi+8]
       jae       short M01_L05
       movsxd    rax,ebx
       mov       [rdi+rax*2+10],cx
M01_L03:
       cmp       ebp,1
       jle       short M01_L00
       cmp       dword ptr [rdx+8],1
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0E]
       lea       edx,[rbx+1]
       cmp       edx,[rdi+8]
       jae       short M01_L05
       inc       ebx
       movsxd    rdx,ebx
       mov       [rdi+rdx*2+10],cx
       jmp       short M01_L00
M01_L04:
       mov       rcx,rsi
       call      System.Text.StringBuilder.AppendHelper(System.String)
       jmp       short M01_L01
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 165
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
       mov       rax,1C8B7C33020
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
       mov       rdx,7FF9DB504000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9DB504000
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings_Comparison()
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
       mov       rbx,[rsi+2A0]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L02
M00_L00:
       mov       edx,ebp
       mov       rdx,[rbx+rdx*8+10]
       test      rdx,rdx
       je        short M00_L01
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF22B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9CF20FE70]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 180
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,r8d
       test      esi,esi
       je        short M01_L03
       mov       r8,[rdi+8]
       mov       ebx,[rdi+18]
       lea       ecx,[rbx+rsi]
       cmp       ecx,[r8+8]
       ja        short M01_L02
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       short M01_L01
       movsxd    r8,esi
       add       r8,r8
       call      qword ptr [7FF9CF0699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       add       esi,ebx
       mov       [rdi+18],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       short M01_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L00
M01_L02:
       mov       rcx,rdi
       mov       r8d,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9CF22B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
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
       call      qword ptr [7FF9CF0699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,27BB3802028
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
       mov       rdx,7FF9CEDD4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9CEDD4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF04D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1D5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings_Comparison()
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
       mov       rbx,[rsi+2A0]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       movsxd    rcx,ebp
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9DB7ABC48]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 167
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rdx,rdx
       je        short M01_L01
       mov       rdi,[rsi+8]
       mov       ebx,[rsi+18]
       mov       ebp,[rdx+8]
       lea       r14d,[rbx+rbp]
       cmp       r14d,[rdi+8]
       jae       short M01_L04
       cmp       ebp,2
       jle       short M01_L02
       add       rdi,10
       movsxd    r8,ebx
       lea       rcx,[rdi+r8*2]
       add       rdx,0C
       movsxd    r8,ebp
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       mov       [rsi+18],r14d
M01_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       test      ebp,ebp
       jle       short M01_L03
       cmp       dword ptr [rdx+8],0
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0C]
       cmp       ebx,[rdi+8]
       jae       short M01_L05
       movsxd    rax,ebx
       mov       [rdi+rax*2+10],cx
M01_L03:
       cmp       ebp,1
       jle       short M01_L00
       cmp       dword ptr [rdx+8],1
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0E]
       lea       edx,[rbx+1]
       cmp       edx,[rdi+8]
       jae       short M01_L05
       inc       ebx
       movsxd    rdx,ebx
       mov       [rdi+rdx*2+10],cx
       jmp       short M01_L00
M01_L04:
       mov       rcx,rsi
       call      System.Text.StringBuilder.AppendHelper(System.String)
       jmp       short M01_L01
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 165
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
       mov       rax,17837453020
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
       mov       rdx,7FF9DB504000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9DB504000
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings_Comparison()
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
       mov       rbx,[rsi+2A0]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L02
M00_L00:
       mov       edx,ebp
       mov       rdx,[rbx+rdx*8+10]
       test      rdx,rdx
       je        short M00_L01
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF22B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9CF20FE70]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 180
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,r8d
       test      esi,esi
       je        short M01_L03
       mov       r8,[rdi+8]
       mov       ebx,[rdi+18]
       lea       ecx,[rbx+rsi]
       cmp       ecx,[r8+8]
       ja        short M01_L02
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       short M01_L01
       movsxd    r8,esi
       add       r8,r8
       call      qword ptr [7FF9CF0699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       add       esi,ebx
       mov       [rdi+18],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       short M01_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L00
M01_L02:
       mov       rcx,rdi
       mov       r8d,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9CF22B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
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
       call      qword ptr [7FF9CF0699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21747402028
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
       mov       rdx,7FF9CEDD4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9CEDD4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF04D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1D5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings_Comparison()
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
       mov       rbx,[rsi+2A0]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       movsxd    rcx,ebp
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9DB79BC48]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 167
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rdx,rdx
       je        short M01_L01
       mov       rdi,[rsi+8]
       mov       ebx,[rsi+18]
       mov       ebp,[rdx+8]
       lea       r14d,[rbx+rbp]
       cmp       r14d,[rdi+8]
       jae       short M01_L04
       cmp       ebp,2
       jle       short M01_L02
       add       rdi,10
       movsxd    r8,ebx
       lea       rcx,[rdi+r8*2]
       add       rdx,0C
       movsxd    r8,ebp
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       mov       [rsi+18],r14d
M01_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       test      ebp,ebp
       jle       short M01_L03
       cmp       dword ptr [rdx+8],0
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0C]
       cmp       ebx,[rdi+8]
       jae       short M01_L05
       movsxd    rax,ebx
       mov       [rdi+rax*2+10],cx
M01_L03:
       cmp       ebp,1
       jle       short M01_L00
       cmp       dword ptr [rdx+8],1
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0E]
       lea       edx,[rbx+1]
       cmp       edx,[rdi+8]
       jae       short M01_L05
       inc       ebx
       movsxd    rdx,ebx
       mov       [rdi+rdx*2+10],cx
       jmp       short M01_L00
M01_L04:
       mov       rcx,rsi
       call      System.Text.StringBuilder.AppendHelper(System.String)
       jmp       short M01_L01
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 165
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
       mov       rax,23340F13020
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
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9DB4F4000
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings_Comparison()
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
       mov       rbx,[rsi+2A0]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L02
M00_L00:
       mov       edx,ebp
       mov       rdx,[rbx+rdx*8+10]
       test      rdx,rdx
       je        short M00_L01
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF1FB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9CF1DFE70]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 180
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,r8d
       test      esi,esi
       je        short M01_L03
       mov       r8,[rdi+8]
       mov       ebx,[rdi+18]
       lea       ecx,[rbx+rsi]
       cmp       ecx,[r8+8]
       ja        short M01_L02
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       short M01_L01
       movsxd    r8,esi
       add       r8,r8
       call      qword ptr [7FF9CF0399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       add       esi,ebx
       mov       [rdi+18],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       short M01_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L00
M01_L02:
       mov       rcx,rdi
       mov       r8d,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9CF1FB9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
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
       call      qword ptr [7FF9CF0399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1E5E9402028
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
       mov       rdx,7FF9CEDA4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9CEDA4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF01D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1A5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings_Comparison()
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
       mov       rbx,[rsi+2A0]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       movsxd    rcx,ebp
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9DB79BC48]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 167
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rdx,rdx
       je        short M01_L01
       mov       rdi,[rsi+8]
       mov       ebx,[rsi+18]
       mov       ebp,[rdx+8]
       lea       r14d,[rbx+rbp]
       cmp       r14d,[rdi+8]
       jae       short M01_L04
       cmp       ebp,2
       jle       short M01_L02
       add       rdi,10
       movsxd    r8,ebx
       lea       rcx,[rdi+r8*2]
       add       rdx,0C
       movsxd    r8,ebp
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       mov       [rsi+18],r14d
M01_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       test      ebp,ebp
       jle       short M01_L03
       cmp       dword ptr [rdx+8],0
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0C]
       cmp       ebx,[rdi+8]
       jae       short M01_L05
       movsxd    rax,ebx
       mov       [rdi+rax*2+10],cx
M01_L03:
       cmp       ebp,1
       jle       short M01_L00
       cmp       dword ptr [rdx+8],1
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0E]
       lea       edx,[rbx+1]
       cmp       edx,[rdi+8]
       jae       short M01_L05
       inc       ebx
       movsxd    rdx,ebx
       mov       [rdi+rdx*2+10],cx
       jmp       short M01_L00
M01_L04:
       mov       rcx,rsi
       call      System.Text.StringBuilder.AppendHelper(System.String)
       jmp       short M01_L01
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 165
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
       mov       rax,198EE253020
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
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9DB4F4000
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings_Comparison()
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
       mov       rbx,[rsi+2A0]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L02
M00_L00:
       mov       edx,ebp
       mov       rdx,[rbx+rdx*8+10]
       test      rdx,rdx
       je        short M00_L01
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9CF1EFE70]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 180
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,r8d
       test      esi,esi
       je        short M01_L03
       mov       r8,[rdi+8]
       mov       ebx,[rdi+18]
       lea       ecx,[rbx+rsi]
       cmp       ecx,[r8+8]
       ja        short M01_L02
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       short M01_L01
       movsxd    r8,esi
       add       r8,r8
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       add       esi,ebx
       mov       [rdi+18],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       short M01_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L00
M01_L02:
       mov       rcx,rdi
       mov       r8d,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9CF20B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
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
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1A85B402028
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
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF02D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings_Comparison()
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
       mov       rbx,[rsi+2A0]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       movsxd    rcx,ebp
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9DB79BC48]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 167
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rdx,rdx
       je        short M01_L01
       mov       rdi,[rsi+8]
       mov       ebx,[rsi+18]
       mov       ebp,[rdx+8]
       lea       r14d,[rbx+rbp]
       cmp       r14d,[rdi+8]
       jae       short M01_L04
       cmp       ebp,2
       jle       short M01_L02
       add       rdi,10
       movsxd    r8,ebx
       lea       rcx,[rdi+r8*2]
       add       rdx,0C
       movsxd    r8,ebp
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       mov       [rsi+18],r14d
M01_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       test      ebp,ebp
       jle       short M01_L03
       cmp       dword ptr [rdx+8],0
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0C]
       cmp       ebx,[rdi+8]
       jae       short M01_L05
       movsxd    rax,ebx
       mov       [rdi+rax*2+10],cx
M01_L03:
       cmp       ebp,1
       jle       short M01_L00
       cmp       dword ptr [rdx+8],1
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0E]
       lea       edx,[rbx+1]
       cmp       edx,[rdi+8]
       jae       short M01_L05
       inc       ebx
       movsxd    rdx,ebx
       mov       [rdi+rdx*2+10],cx
       jmp       short M01_L00
M01_L04:
       mov       rcx,rsi
       call      System.Text.StringBuilder.AppendHelper(System.String)
       jmp       short M01_L01
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 165
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
       mov       rax,2453F4D3020
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
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9DB4F4000
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings_Comparison()
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
       mov       rbx,[rsi+2A0]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L02
M00_L00:
       mov       edx,ebp
       mov       rdx,[rbx+rdx*8+10]
       test      rdx,rdx
       je        short M00_L01
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9CF1EFE70]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 180
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,r8d
       test      esi,esi
       je        short M01_L03
       mov       r8,[rdi+8]
       mov       ebx,[rdi+18]
       lea       ecx,[rbx+rsi]
       cmp       ecx,[r8+8]
       ja        short M01_L02
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       short M01_L01
       movsxd    r8,esi
       add       r8,r8
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       add       esi,ebx
       mov       [rdi+18],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       short M01_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L00
M01_L02:
       mov       rcx,rdi
       mov       r8d,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9CF20B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
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
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1E9B0C00030
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
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF02D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings_Comparison()
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
       mov       rbx,[rsi+2A0]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       movsxd    rcx,ebp
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9DB79BC48]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 167
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rdx,rdx
       je        short M01_L01
       mov       rdi,[rsi+8]
       mov       ebx,[rsi+18]
       mov       ebp,[rdx+8]
       lea       r14d,[rbx+rbp]
       cmp       r14d,[rdi+8]
       jae       short M01_L04
       cmp       ebp,2
       jle       short M01_L02
       add       rdi,10
       movsxd    r8,ebx
       lea       rcx,[rdi+r8*2]
       add       rdx,0C
       movsxd    r8,ebp
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       mov       [rsi+18],r14d
M01_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       test      ebp,ebp
       jle       short M01_L03
       cmp       dword ptr [rdx+8],0
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0C]
       cmp       ebx,[rdi+8]
       jae       short M01_L05
       movsxd    rax,ebx
       mov       [rdi+rax*2+10],cx
M01_L03:
       cmp       ebp,1
       jle       short M01_L00
       cmp       dword ptr [rdx+8],1
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0E]
       lea       edx,[rbx+1]
       cmp       edx,[rdi+8]
       jae       short M01_L05
       inc       ebx
       movsxd    rdx,ebx
       mov       [rdi+rdx*2+10],cx
       jmp       short M01_L00
M01_L04:
       mov       rcx,rsi
       call      System.Text.StringBuilder.AppendHelper(System.String)
       jmp       short M01_L01
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 165
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
       mov       rax,1B52AB93020
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
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9DB4F4000
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings_Comparison()
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
       mov       rbx,[rsi+2A0]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L02
M00_L00:
       mov       edx,ebp
       mov       rdx,[rbx+rdx*8+10]
       test      rdx,rdx
       je        short M00_L01
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9CF1EFE70]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 180
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,r8d
       test      esi,esi
       je        short M01_L03
       mov       r8,[rdi+8]
       mov       ebx,[rdi+18]
       lea       ecx,[rbx+rsi]
       cmp       ecx,[r8+8]
       ja        short M01_L02
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       short M01_L01
       movsxd    r8,esi
       add       r8,r8
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       add       esi,ebx
       mov       [rdi+18],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       short M01_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L00
M01_L02:
       mov       rcx,rdi
       mov       r8d,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9CF20B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
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
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,237BA802028
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
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF02D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings_Comparison()
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
       mov       rbx,[rsi+2A0]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       movsxd    rcx,ebp
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9DB78BC48]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 167
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rdx,rdx
       je        short M01_L01
       mov       rdi,[rsi+8]
       mov       ebx,[rsi+18]
       mov       ebp,[rdx+8]
       lea       r14d,[rbx+rbp]
       cmp       r14d,[rdi+8]
       jae       short M01_L04
       cmp       ebp,2
       jle       short M01_L02
       add       rdi,10
       movsxd    r8,ebx
       lea       rcx,[rdi+r8*2]
       add       rdx,0C
       movsxd    r8,ebp
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       mov       [rsi+18],r14d
M01_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       test      ebp,ebp
       jle       short M01_L03
       cmp       dword ptr [rdx+8],0
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0C]
       cmp       ebx,[rdi+8]
       jae       short M01_L05
       movsxd    rax,ebx
       mov       [rdi+rax*2+10],cx
M01_L03:
       cmp       ebp,1
       jle       short M01_L00
       cmp       dword ptr [rdx+8],1
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0E]
       lea       edx,[rbx+1]
       cmp       edx,[rdi+8]
       jae       short M01_L05
       inc       ebx
       movsxd    rdx,ebx
       mov       [rdi+rdx*2+10],cx
       jmp       short M01_L00
M01_L04:
       mov       rcx,rsi
       call      System.Text.StringBuilder.AppendHelper(System.String)
       jmp       short M01_L01
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 165
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
       mov       rax,15B9EE03020
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
       mov       rdx,7FF9DB4E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9DB4E4000
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings_Comparison()
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
       mov       rbx,[rsi+2A0]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L02
M00_L00:
       mov       edx,ebp
       mov       rdx,[rbx+rdx*8+10]
       test      rdx,rdx
       je        short M00_L01
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF22B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9CF20FE70]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 180
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,r8d
       test      esi,esi
       je        short M01_L03
       mov       r8,[rdi+8]
       mov       ebx,[rdi+18]
       lea       ecx,[rbx+rsi]
       cmp       ecx,[r8+8]
       ja        short M01_L02
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       short M01_L01
       movsxd    r8,esi
       add       r8,r8
       call      qword ptr [7FF9CF0699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       add       esi,ebx
       mov       [rdi+18],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       short M01_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L00
M01_L02:
       mov       rcx,rdi
       mov       r8d,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9CF22B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
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
       call      qword ptr [7FF9CF0699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,25AA1002028
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
       mov       rdx,7FF9CEDD4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9CEDD4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF04D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1D5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
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
       xor       ebx,ebx
       mov       rcx,[rsi+2A0]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rsi+2A0]
       cmp       ebx,[rcx+8]
       jae       short M00_L02
       movsxd    rdx,ebx
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9DB7ABC48]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 183
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rdx,rdx
       je        short M01_L01
       mov       rdi,[rsi+8]
       mov       ebx,[rsi+18]
       mov       ebp,[rdx+8]
       lea       r14d,[rbx+rbp]
       cmp       r14d,[rdi+8]
       jae       short M01_L04
       cmp       ebp,2
       jle       short M01_L02
       add       rdi,10
       movsxd    r8,ebx
       lea       rcx,[rdi+r8*2]
       add       rdx,0C
       movsxd    r8,ebp
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       mov       [rsi+18],r14d
M01_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       test      ebp,ebp
       jle       short M01_L03
       cmp       dword ptr [rdx+8],0
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0C]
       cmp       ebx,[rdi+8]
       jae       short M01_L05
       movsxd    rax,ebx
       mov       [rdi+rax*2+10],cx
M01_L03:
       cmp       ebp,1
       jle       short M01_L00
       cmp       dword ptr [rdx+8],1
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0E]
       lea       edx,[rbx+1]
       cmp       edx,[rdi+8]
       jae       short M01_L05
       inc       ebx
       movsxd    rdx,ebx
       mov       [rdi+rdx*2+10],cx
       jmp       short M01_L00
M01_L04:
       mov       rcx,rsi
       call      System.Text.StringBuilder.AppendHelper(System.String)
       jmp       short M01_L01
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 165
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
       mov       rax,291A1053020
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
       mov       rdx,7FF9DB504000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9DB504000
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
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
       xor       ebx,ebx
       mov       rdx,[rsi+2A0]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L02
M00_L00:
       mov       rdx,[rsi+2A0]
       cmp       ebx,[rdx+8]
       jae       short M00_L03
       mov       ecx,ebx
       mov       rdx,[rdx+rcx*8+10]
       test      rdx,rdx
       je        short M00_L01
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9CF1EFE70]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 196
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,r8d
       test      esi,esi
       je        short M01_L03
       mov       r8,[rdi+8]
       mov       ebx,[rdi+18]
       lea       ecx,[rbx+rsi]
       cmp       ecx,[r8+8]
       ja        short M01_L02
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       short M01_L01
       movsxd    r8,esi
       add       r8,r8
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       add       esi,ebx
       mov       [rdi+18],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       short M01_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L00
M01_L02:
       mov       rcx,rdi
       mov       r8d,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9CF20B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
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
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2558E002028
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
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF02D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
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
       xor       ebx,ebx
       mov       rcx,[rsi+2A0]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rsi+2A0]
       cmp       ebx,[rcx+8]
       jae       short M00_L02
       movsxd    rdx,ebx
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9DB78BC48]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 183
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rdx,rdx
       je        short M01_L01
       mov       rdi,[rsi+8]
       mov       ebx,[rsi+18]
       mov       ebp,[rdx+8]
       lea       r14d,[rbx+rbp]
       cmp       r14d,[rdi+8]
       jae       short M01_L04
       cmp       ebp,2
       jle       short M01_L02
       add       rdi,10
       movsxd    r8,ebx
       lea       rcx,[rdi+r8*2]
       add       rdx,0C
       movsxd    r8,ebp
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       mov       [rsi+18],r14d
M01_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       test      ebp,ebp
       jle       short M01_L03
       cmp       dword ptr [rdx+8],0
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0C]
       cmp       ebx,[rdi+8]
       jae       short M01_L05
       movsxd    rax,ebx
       mov       [rdi+rax*2+10],cx
M01_L03:
       cmp       ebp,1
       jle       short M01_L00
       cmp       dword ptr [rdx+8],1
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0E]
       lea       edx,[rbx+1]
       cmp       edx,[rdi+8]
       jae       short M01_L05
       inc       ebx
       movsxd    rdx,ebx
       mov       [rdi+rdx*2+10],cx
       jmp       short M01_L00
M01_L04:
       mov       rcx,rsi
       call      System.Text.StringBuilder.AppendHelper(System.String)
       jmp       short M01_L01
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 165
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
       mov       rax,18DE4633020
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
       mov       rdx,7FF9DB4E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9DB4E4000
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
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
       xor       ebx,ebx
       mov       rdx,[rsi+2A0]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L02
M00_L00:
       mov       rdx,[rsi+2A0]
       cmp       ebx,[rdx+8]
       jae       short M00_L03
       mov       ecx,ebx
       mov       rdx,[rdx+rcx*8+10]
       test      rdx,rdx
       je        short M00_L01
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9CF1EFE70]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 196
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,r8d
       test      esi,esi
       je        short M01_L03
       mov       r8,[rdi+8]
       mov       ebx,[rdi+18]
       lea       ecx,[rbx+rsi]
       cmp       ecx,[r8+8]
       ja        short M01_L02
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       short M01_L01
       movsxd    r8,esi
       add       r8,r8
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       add       esi,ebx
       mov       [rdi+18],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       short M01_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L00
M01_L02:
       mov       rcx,rdi
       mov       r8d,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9CF20B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
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
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1B03D802028
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
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF02D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
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
       xor       ebx,ebx
       mov       rcx,[rsi+2A0]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rsi+2A0]
       cmp       ebx,[rcx+8]
       jae       short M00_L02
       movsxd    rdx,ebx
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9DB79BC48]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 183
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rdx,rdx
       je        short M01_L01
       mov       rdi,[rsi+8]
       mov       ebx,[rsi+18]
       mov       ebp,[rdx+8]
       lea       r14d,[rbx+rbp]
       cmp       r14d,[rdi+8]
       jae       short M01_L04
       cmp       ebp,2
       jle       short M01_L02
       add       rdi,10
       movsxd    r8,ebx
       lea       rcx,[rdi+r8*2]
       add       rdx,0C
       movsxd    r8,ebp
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       mov       [rsi+18],r14d
M01_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       test      ebp,ebp
       jle       short M01_L03
       cmp       dword ptr [rdx+8],0
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0C]
       cmp       ebx,[rdi+8]
       jae       short M01_L05
       movsxd    rax,ebx
       mov       [rdi+rax*2+10],cx
M01_L03:
       cmp       ebp,1
       jle       short M01_L00
       cmp       dword ptr [rdx+8],1
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0E]
       lea       edx,[rbx+1]
       cmp       edx,[rdi+8]
       jae       short M01_L05
       inc       ebx
       movsxd    rdx,ebx
       mov       [rdi+rdx*2+10],cx
       jmp       short M01_L00
M01_L04:
       mov       rcx,rsi
       call      System.Text.StringBuilder.AppendHelper(System.String)
       jmp       short M01_L01
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 165
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
       mov       rax,23373D03020
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
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9DB4F4000
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
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
       xor       ebx,ebx
       mov       rdx,[rsi+2A0]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L02
M00_L00:
       mov       rdx,[rsi+2A0]
       cmp       ebx,[rdx+8]
       jae       short M00_L03
       mov       ecx,ebx
       mov       rdx,[rdx+rcx*8+10]
       test      rdx,rdx
       je        short M00_L01
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9CF1EFE70]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 196
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,r8d
       test      esi,esi
       je        short M01_L03
       mov       r8,[rdi+8]
       mov       ebx,[rdi+18]
       lea       ecx,[rbx+rsi]
       cmp       ecx,[r8+8]
       ja        short M01_L02
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       short M01_L01
       movsxd    r8,esi
       add       r8,r8
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       add       esi,ebx
       mov       [rdi+18],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       short M01_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L00
M01_L02:
       mov       rcx,rdi
       mov       r8d,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9CF20B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
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
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22054802028
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
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF02D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
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
       xor       ebx,ebx
       mov       rcx,[rsi+2A0]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rsi+2A0]
       cmp       ebx,[rcx+8]
       jae       short M00_L02
       movsxd    rdx,ebx
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9DB7ABC48]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 183
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rdx,rdx
       je        short M01_L01
       mov       rdi,[rsi+8]
       mov       ebx,[rsi+18]
       mov       ebp,[rdx+8]
       lea       r14d,[rbx+rbp]
       cmp       r14d,[rdi+8]
       jae       short M01_L04
       cmp       ebp,2
       jle       short M01_L02
       add       rdi,10
       movsxd    r8,ebx
       lea       rcx,[rdi+r8*2]
       add       rdx,0C
       movsxd    r8,ebp
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       mov       [rsi+18],r14d
M01_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       test      ebp,ebp
       jle       short M01_L03
       cmp       dword ptr [rdx+8],0
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0C]
       cmp       ebx,[rdi+8]
       jae       short M01_L05
       movsxd    rax,ebx
       mov       [rdi+rax*2+10],cx
M01_L03:
       cmp       ebp,1
       jle       short M01_L00
       cmp       dword ptr [rdx+8],1
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0E]
       lea       edx,[rbx+1]
       cmp       edx,[rdi+8]
       jae       short M01_L05
       inc       ebx
       movsxd    rdx,ebx
       mov       [rdi+rdx*2+10],cx
       jmp       short M01_L00
M01_L04:
       mov       rcx,rsi
       call      System.Text.StringBuilder.AppendHelper(System.String)
       jmp       short M01_L01
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 165
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
       mov       rax,22024743020
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
       mov       rdx,7FF9DB504000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9DB504000
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
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
       xor       ebx,ebx
       mov       rdx,[rsi+2A0]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L02
M00_L00:
       mov       rdx,[rsi+2A0]
       cmp       ebx,[rdx+8]
       jae       short M00_L03
       mov       ecx,ebx
       mov       rdx,[rdx+rcx*8+10]
       test      rdx,rdx
       je        short M00_L01
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF1FB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9CF1DFE70]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 196
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,r8d
       test      esi,esi
       je        short M01_L03
       mov       r8,[rdi+8]
       mov       ebx,[rdi+18]
       lea       ecx,[rbx+rsi]
       cmp       ecx,[r8+8]
       ja        short M01_L02
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       short M01_L01
       movsxd    r8,esi
       add       r8,r8
       call      qword ptr [7FF9CF0399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       add       esi,ebx
       mov       [rdi+18],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       short M01_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L00
M01_L02:
       mov       rcx,rdi
       mov       r8d,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9CF1FB9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
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
       call      qword ptr [7FF9CF0399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21D3A002028
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
       mov       rdx,7FF9CEDA4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9CEDA4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF01D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1A5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
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
       xor       ebx,ebx
       mov       rcx,[rsi+2A0]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rsi+2A0]
       cmp       ebx,[rcx+8]
       jae       short M00_L02
       movsxd    rdx,ebx
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9DB79BC48]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 183
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rdx,rdx
       je        short M01_L01
       mov       rdi,[rsi+8]
       mov       ebx,[rsi+18]
       mov       ebp,[rdx+8]
       lea       r14d,[rbx+rbp]
       cmp       r14d,[rdi+8]
       jae       short M01_L04
       cmp       ebp,2
       jle       short M01_L02
       add       rdi,10
       movsxd    r8,ebx
       lea       rcx,[rdi+r8*2]
       add       rdx,0C
       movsxd    r8,ebp
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       mov       [rsi+18],r14d
M01_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       test      ebp,ebp
       jle       short M01_L03
       cmp       dword ptr [rdx+8],0
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0C]
       cmp       ebx,[rdi+8]
       jae       short M01_L05
       movsxd    rax,ebx
       mov       [rdi+rax*2+10],cx
M01_L03:
       cmp       ebp,1
       jle       short M01_L00
       cmp       dword ptr [rdx+8],1
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0E]
       lea       edx,[rbx+1]
       cmp       edx,[rdi+8]
       jae       short M01_L05
       inc       ebx
       movsxd    rdx,ebx
       mov       [rdi+rdx*2+10],cx
       jmp       short M01_L00
M01_L04:
       mov       rcx,rsi
       call      System.Text.StringBuilder.AppendHelper(System.String)
       jmp       short M01_L01
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 165
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
       mov       rax,2B780073020
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
       mov       rdx,7FF9DB4F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9DB4F4000
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
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
       xor       ebx,ebx
       mov       rdx,[rsi+2A0]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L02
M00_L00:
       mov       rdx,[rsi+2A0]
       cmp       ebx,[rdx+8]
       jae       short M00_L03
       mov       ecx,ebx
       mov       rdx,[rdx+rcx*8+10]
       test      rdx,rdx
       je        short M00_L01
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9CF1EFE70]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 196
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,r8d
       test      esi,esi
       je        short M01_L03
       mov       r8,[rdi+8]
       mov       ebx,[rdi+18]
       lea       ecx,[rbx+rsi]
       cmp       ecx,[r8+8]
       ja        short M01_L02
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       short M01_L01
       movsxd    r8,esi
       add       r8,r8
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       add       esi,ebx
       mov       [rdi+18],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       short M01_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L00
M01_L02:
       mov       rcx,rdi
       mov       r8d,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9CF20B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
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
       call      qword ptr [7FF9CF0499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1429FC02028
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
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9CEDB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF02D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
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
       xor       ebx,ebx
       mov       rcx,[rsi+2A0]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rsi+2A0]
       cmp       ebx,[rcx+8]
       jae       short M00_L02
       movsxd    rdx,ebx
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9DB78BC48]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 183
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rdx,rdx
       je        short M01_L01
       mov       rdi,[rsi+8]
       mov       ebx,[rsi+18]
       mov       ebp,[rdx+8]
       lea       r14d,[rbx+rbp]
       cmp       r14d,[rdi+8]
       jae       short M01_L04
       cmp       ebp,2
       jle       short M01_L02
       add       rdi,10
       movsxd    r8,ebx
       lea       rcx,[rdi+r8*2]
       add       rdx,0C
       movsxd    r8,ebp
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       mov       [rsi+18],r14d
M01_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       test      ebp,ebp
       jle       short M01_L03
       cmp       dword ptr [rdx+8],0
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0C]
       cmp       ebx,[rdi+8]
       jae       short M01_L05
       movsxd    rax,ebx
       mov       [rdi+rax*2+10],cx
M01_L03:
       cmp       ebp,1
       jle       short M01_L00
       cmp       dword ptr [rdx+8],1
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0E]
       lea       edx,[rbx+1]
       cmp       edx,[rdi+8]
       jae       short M01_L05
       inc       ebx
       movsxd    rdx,ebx
       mov       [rdi+rdx*2+10],cx
       jmp       short M01_L00
M01_L04:
       mov       rcx,rsi
       call      System.Text.StringBuilder.AppendHelper(System.String)
       jmp       short M01_L01
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 165
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
       mov       rax,15946AC3020
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
       mov       rdx,7FF9DB4E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9DB4E4000
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
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
       xor       ebx,ebx
       mov       rdx,[rsi+2A0]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L02
M00_L00:
       mov       rdx,[rsi+2A0]
       cmp       ebx,[rdx+8]
       jae       short M00_L03
       mov       ecx,ebx
       mov       rdx,[rdx+rcx*8+10]
       test      rdx,rdx
       je        short M00_L01
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF1FB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9CF1DFE70]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 196
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,r8d
       test      esi,esi
       je        short M01_L03
       mov       r8,[rdi+8]
       mov       ebx,[rdi+18]
       lea       ecx,[rbx+rsi]
       cmp       ecx,[r8+8]
       ja        short M01_L02
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       short M01_L01
       movsxd    r8,esi
       add       r8,r8
       call      qword ptr [7FF9CF0399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       add       esi,ebx
       mov       [rdi+18],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       short M01_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L00
M01_L02:
       mov       rcx,rdi
       mov       r8d,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9CF1FB9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
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
       call      qword ptr [7FF9CF0399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1B503C02028
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
       mov       rdx,7FF9CEDA4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9CEDA4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF01D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1A5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
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
       xor       ebx,ebx
       mov       rcx,[rsi+2A0]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L01
M00_L00:
       mov       rcx,[rsi+2A0]
       cmp       ebx,[rcx+8]
       jae       short M00_L02
       movsxd    rdx,ebx
       mov       rdx,[rcx+rdx*8+10]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9DB7BBC48]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 183
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rdx,rdx
       je        short M01_L01
       mov       rdi,[rsi+8]
       mov       ebx,[rsi+18]
       mov       ebp,[rdx+8]
       lea       r14d,[rbx+rbp]
       cmp       r14d,[rdi+8]
       jae       short M01_L04
       cmp       ebp,2
       jle       short M01_L02
       add       rdi,10
       movsxd    r8,ebx
       lea       rcx,[rdi+r8*2]
       add       rdx,0C
       movsxd    r8,ebp
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       mov       [rsi+18],r14d
M01_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       test      ebp,ebp
       jle       short M01_L03
       cmp       dword ptr [rdx+8],0
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0C]
       cmp       ebx,[rdi+8]
       jae       short M01_L05
       movsxd    rax,ebx
       mov       [rdi+rax*2+10],cx
M01_L03:
       cmp       ebp,1
       jle       short M01_L00
       cmp       dword ptr [rdx+8],1
       jbe       short M01_L05
       movzx     ecx,word ptr [rdx+0E]
       lea       edx,[rbx+1]
       cmp       edx,[rdi+8]
       jae       short M01_L05
       inc       ebx
       movsxd    rdx,ebx
       mov       [rdi+rdx*2+10],cx
       jmp       short M01_L00
M01_L04:
       mov       rcx,rsi
       call      System.Text.StringBuilder.AppendHelper(System.String)
       jmp       short M01_L01
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 165
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
       mov       rax,1D576603020
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
       mov       rdx,7FF9DB514000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9DB514000
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction_Comparison()
       push      rdi
       push      rsi
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
       xor       ebx,ebx
       mov       rdx,[rsi+2A0]
       cmp       dword ptr [rdx+8],0
       jle       short M00_L02
M00_L00:
       mov       rdx,[rsi+2A0]
       cmp       ebx,[rdx+8]
       jae       short M00_L03
       mov       ecx,ebx
       mov       rdx,[rdx+rcx*8+10]
       test      rdx,rdx
       je        short M00_L01
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF21B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9CF1FFE70]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 196
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       esi,r8d
       test      esi,esi
       je        short M01_L03
       mov       r8,[rdi+8]
       mov       ebx,[rdi+18]
       lea       ecx,[rbx+rsi]
       cmp       ecx,[r8+8]
       ja        short M01_L02
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       short M01_L01
       movsxd    r8,esi
       add       r8,r8
       call      qword ptr [7FF9CF0599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L00:
       add       esi,ebx
       mov       [rdi+18],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       short M01_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L00
M01_L02:
       mov       rcx,rdi
       mov       r8d,esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9CF21B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
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
       call      qword ptr [7FF9CF0599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,201D4002028
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
       mov       rdx,7FF9CEDC4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9CEDC4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF03D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CF1C5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
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
       mov       rax,21688083020
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
       mov       rcx,7FF9DB7A7320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,216880887A0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,216F8081C40
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,21688081568
       mov       r15,[rdx]
       mov       rdx,216F8081C48
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
       call      qword ptr [7FF9DB78BC48]; System.Text.StringBuilder.ToString()
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
       mov       rcx,216880887A0
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
       mov       rcx,7FF9DB7A7320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,216880887A0
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FF9CF6F9300]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6F9540]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,1F468C02028
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
       mov       rcx,1F468C07838
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FF9CF5AD170]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,1F46AC01CA8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,1F468C00528
       mov       r12,[rdx]
       mov       rdx,1F46AC01CB0
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FF9CF1B3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF9CF1EFE70]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF9CF20B258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9CF5AD178]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1F468C07838
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9CF5AD178]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
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
       mov       rax,2203A1A3020
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
       mov       rcx,7FF9DB7A7320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2203A1A87A0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,220BA1A1C40
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,2203A1A1568
       mov       r15,[rdx]
       mov       rdx,220BA1A1C48
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
       call      qword ptr [7FF9DB78BC48]; System.Text.StringBuilder.ToString()
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
       mov       rcx,2203A1A87A0
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
       mov       rcx,7FF9DB7A7320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2203A1A87A0
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FF9CF6F7300]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6F7540]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,18659C00030
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
       mov       rcx,18659C05840
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FF9CF5AE8D8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,18663C00C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,1865DC00528
       mov       r12,[rdx]
       mov       rdx,18663C00C98
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FF9CF1B3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF9CF1EFE70]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF9CF20B258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9CF5AE8E0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,18659C05840
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9CF5AE8E0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
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
       mov       rax,1E1F7EF3020
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
       mov       rcx,7FF9DB7D7320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1E1F7EF87A0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,1E257EF1C40
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,1E1F7EF1568
       mov       r15,[rdx]
       mov       rdx,1E257EF1C48
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
       call      qword ptr [7FF9DB7BBC48]; System.Text.StringBuilder.ToString()
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
       mov       rcx,1E1F7EF87A0
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
       mov       rcx,7FF9DB7D7320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1E1F7EF87A0
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FF9CF717300]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF717540]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,23CEB400030
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
       mov       rcx,23CEB405840
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FF9CF5CCEA8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,23CED401CA8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FF9CF22B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,23CEF400528
       mov       r12,[rdx]
       mov       rdx,23CED401CB0
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FF9CF1D3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FF9CF22B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF9CF20FE70]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF9CF22B258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9CF5CCEB0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,23CEB405840
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9CF5CCEB0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
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
       mov       rax,1C67FC53020
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
       mov       rcx,7FF9DB797320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1C65FC54398
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,1C6EFC51C40
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,1C67FC51568
       mov       r15,[rdx]
       mov       rdx,1C6EFC51C48
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
       call      qword ptr [7FF9DB77BC48]; System.Text.StringBuilder.ToString()
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
       mov       rcx,1C65FC54398
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
       mov       rcx,7FF9DB797320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1C65FC54398
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FF9CF6F9870]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6F9AB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,1EBD2802028
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
       mov       rcx,1EBD2807838
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FF9CF5AD170]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,1EBD0800C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,1EBD2800528
       mov       r12,[rdx]
       mov       rdx,1EBD0800C98
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FF9CF1B3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF9CF1EFE70]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF9CF20B258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9CF5AD178]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1EBD2807838
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9CF5AD178]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
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
       mov       rax,248E5233020
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
       mov       rcx,7FF9DB7C7320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,248E52367A8
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,24955231C40
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,248E5231568
       mov       r15,[rdx]
       mov       rdx,24955231C48
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
       call      qword ptr [7FF9DB7ABC48]; System.Text.StringBuilder.ToString()
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
       mov       rcx,248E52367A8
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
       mov       rcx,7FF9DB7C7320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,248E52367A8
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FF9CF707300]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF707540]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,1A1FC002028
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
       mov       rcx,1A1FC007838
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FF9CF5BCEA8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,1A206000C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FF9CF21B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,1A1FC000528
       mov       r12,[rdx]
       mov       rdx,1A206000C98
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FF9CF1C3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FF9CF21B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF9CF1FFE70]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF9CF21B258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9CF5BCEB0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1A1FC007838
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9CF5BCEB0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
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
       mov       rax,1C09A4A3020
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
       mov       rcx,7FF9DB7B7320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1C09A4A87A0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,1C10A4A1C40
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,1C09A4A1568
       mov       r15,[rdx]
       mov       rdx,1C10A4A1C48
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
       call      qword ptr [7FF9DB79BC48]; System.Text.StringBuilder.ToString()
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
       mov       rcx,1C09A4A87A0
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
       mov       rcx,7FF9DB7B7320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1C09A4A87A0
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FF9CF6F9870]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6F9AB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,22C1E002028
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
       mov       rcx,22C1E007838
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FF9CF5AD170]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,22C22008C28
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,22C1E000528
       mov       r12,[rdx]
       mov       rdx,22C22008C30
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FF9CF1B3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF9CF1EFE70]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF9CF20B258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9CF5AD178]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,22C1E007838
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9CF5AD178]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
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
       mov       rax,1DC958A3020
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
       mov       rcx,7FF9DB7C7320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1DC758A4398
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,1DD058A1C40
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,1DC958A1568
       mov       r15,[rdx]
       mov       rdx,1DD058A1C48
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
       call      qword ptr [7FF9DB7ABC48]; System.Text.StringBuilder.ToString()
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
       mov       rcx,1DC758A4398
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
       mov       rcx,7FF9DB7C7320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1DC758A4398
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FF9CF6F7870]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6F7AB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,1F962002028
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
       mov       rcx,1F962007838
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FF9CF5ADF78]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,1F96C000C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,1F962000528
       mov       r12,[rdx]
       mov       rdx,1F96C000C98
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FF9CF1B3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF9CF1EFE70]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FF9CF20B258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9CF5ADF80]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1F962007838
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9CF5ADF80]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
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
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       esi,ecx
       mov       rdi,rdx
       mov       rcx,7FF9DB7B7320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1E7176C67A8
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       mov       [rbp-28],rdx
       test      rdi,rdi
       je        short M01_L03
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short M01_L03
       xor       r14d,r14d
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       mov       rdx,[rbp-28]
       movsxd    rcx,r14d
       mov       rax,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       mov       rcx,rdx
       mov       rdx,rax
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L02
M01_L01:
       cmp       [rdx],edx
       mov       rcx,rdx
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,[rbp-28]
       call      System.Text.StringBuilder.Append(System.String)
M01_L02:
       inc       r14d
       cmp       ebx,r14d
       jg        short M01_L00
M01_L03:
       mov       rcx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9DB79BC48]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,1E7176C67A8
       mov       rcx,[rcx]
       mov       rdx,[rbp-28]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       add       rsp,30
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
       mov       rcx,7FF9DB7B7320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1E7176C67A8
       mov       rcx,[rcx]
       mov       rdx,[rbp-28]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 301
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FF9CF6F7318]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6F73D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
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
       mov       esi,ecx
       mov       rdi,rdx
       mov       rcx,22206807838
       mov       rbx,[rcx]
       mov       rcx,rbx
       call      qword ptr [7FF9CF5ACEA8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rdx,rax
       mov       [rbp-38],rdx
       test      rdi,rdi
       je        near ptr M01_L04
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       mov       rdx,[rbp-38]
       mov       ecx,r15d
       mov       r12,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L03
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M01_L03
M01_L01:
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L02
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       mov       rdx,222068084B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,[rbp-38]
       mov       r8d,2
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF1EFE70]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FF9CF5ACEB0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rsi
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
       mov       rcx,22206807838
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FF9CF5ACEB0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
; Total bytes of code 312
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
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
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       esi,ecx
       mov       rdi,rdx
       mov       rcx,7FF9DB7B7320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1B74EFA87A0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       mov       [rbp-28],rdx
       test      rdi,rdi
       je        short M01_L03
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short M01_L03
       xor       r14d,r14d
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       mov       rdx,[rbp-28]
       movsxd    rcx,r14d
       mov       rax,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       mov       rcx,rdx
       mov       rdx,rax
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L02
M01_L01:
       cmp       [rdx],edx
       mov       rcx,rdx
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,[rbp-28]
       call      System.Text.StringBuilder.Append(System.String)
M01_L02:
       inc       r14d
       cmp       ebx,r14d
       jg        short M01_L00
M01_L03:
       mov       rcx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9DB79BC48]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,1B74EFA87A0
       mov       rcx,[rcx]
       mov       rdx,[rbp-28]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       add       rsp,30
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
       mov       rcx,7FF9DB7B7320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1B74EFA87A0
       mov       rcx,[rcx]
       mov       rdx,[rbp-28]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 301
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FF9CF729888]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF729948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
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
       mov       esi,ecx
       mov       rdi,rdx
       mov       rcx,1FDF5007838
       mov       rbx,[rcx]
       mov       rcx,rbx
       call      qword ptr [7FF9CF5CFA18]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rdx,rax
       mov       [rbp-38],rdx
       test      rdi,rdi
       je        near ptr M01_L04
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       mov       rdx,[rbp-38]
       mov       ecx,r15d
       mov       r12,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L03
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9CF22B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M01_L03
M01_L01:
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L02
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9CF22B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       mov       rdx,1FDF50084B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,[rbp-38]
       mov       r8d,2
       call      qword ptr [7FF9CF22B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF20FE70]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FF9CF5CFA20]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rsi
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
       mov       rcx,1FDF5007838
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FF9CF5CFA20]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
; Total bytes of code 312
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
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
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       esi,ecx
       mov       rdi,rdx
       mov       rcx,7FF9DB7B7320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1E56F1187A0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       mov       [rbp-28],rdx
       test      rdi,rdi
       je        short M01_L03
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short M01_L03
       xor       r14d,r14d
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       mov       rdx,[rbp-28]
       movsxd    rcx,r14d
       mov       rax,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       mov       rcx,rdx
       mov       rdx,rax
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L02
M01_L01:
       cmp       [rdx],edx
       mov       rcx,rdx
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,[rbp-28]
       call      System.Text.StringBuilder.Append(System.String)
M01_L02:
       inc       r14d
       cmp       ebx,r14d
       jg        short M01_L00
M01_L03:
       mov       rcx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9DB79BC48]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,1E56F1187A0
       mov       rcx,[rcx]
       mov       rdx,[rbp-28]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       add       rsp,30
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
       mov       rcx,7FF9DB7B7320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1E56F1187A0
       mov       rcx,[rcx]
       mov       rdx,[rbp-28]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 301
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FF9CF6F9018]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6F90D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
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
       mov       esi,ecx
       mov       rdi,rdx
       mov       rcx,285E1407838
       mov       rbx,[rcx]
       mov       rcx,rbx
       call      qword ptr [7FF9CF5ABB10]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rdx,rax
       mov       [rbp-38],rdx
       test      rdi,rdi
       je        near ptr M01_L04
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       mov       rdx,[rbp-38]
       mov       ecx,r15d
       mov       r12,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L03
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M01_L03
M01_L01:
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L02
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       mov       rdx,285E14084B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,[rbp-38]
       mov       r8d,2
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF1EFE70]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FF9CF5ABB18]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rsi
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
       mov       rcx,285E1407838
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FF9CF5ABB18]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
; Total bytes of code 312
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
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
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       esi,ecx
       mov       rdi,rdx
       mov       rcx,7FF9DB7A7320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1E38E8A4398
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       mov       [rbp-28],rdx
       test      rdi,rdi
       je        short M01_L03
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short M01_L03
       xor       r14d,r14d
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       mov       rdx,[rbp-28]
       movsxd    rcx,r14d
       mov       rax,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       mov       rcx,rdx
       mov       rdx,rax
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L02
M01_L01:
       cmp       [rdx],edx
       mov       rcx,rdx
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,[rbp-28]
       call      System.Text.StringBuilder.Append(System.String)
M01_L02:
       inc       r14d
       cmp       ebx,r14d
       jg        short M01_L00
M01_L03:
       mov       rcx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9DB78BC48]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,1E38E8A4398
       mov       rcx,[rcx]
       mov       rdx,[rbp-28]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       add       rsp,30
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
       mov       rcx,7FF9DB7A7320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1E38E8A4398
       mov       rcx,[rcx]
       mov       rdx,[rbp-28]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 301
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FF9CF717318]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF7173D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
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
       mov       esi,ecx
       mov       rdi,rdx
       mov       rcx,244ED007838
       mov       rbx,[rcx]
       mov       rcx,rbx
       call      qword ptr [7FF9CF5CE460]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rdx,rax
       mov       [rbp-38],rdx
       test      rdi,rdi
       je        near ptr M01_L04
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       mov       rdx,[rbp-38]
       mov       ecx,r15d
       mov       r12,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L03
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9CF22B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M01_L03
M01_L01:
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L02
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9CF22B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       mov       rdx,244ED0084B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,[rbp-38]
       mov       r8d,2
       call      qword ptr [7FF9CF22B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF20FE70]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FF9CF5CE468]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rsi
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
       mov       rcx,244ED007838
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FF9CF5CE468]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
; Total bytes of code 312
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
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
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       esi,ecx
       mov       rdi,rdx
       mov       rcx,7FF9DB7C7320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1B250C887A0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       mov       [rbp-28],rdx
       test      rdi,rdi
       je        short M01_L03
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short M01_L03
       xor       r14d,r14d
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       mov       rdx,[rbp-28]
       movsxd    rcx,r14d
       mov       rax,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       mov       rcx,rdx
       mov       rdx,rax
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L02
M01_L01:
       cmp       [rdx],edx
       mov       rcx,rdx
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,[rbp-28]
       call      System.Text.StringBuilder.Append(System.String)
M01_L02:
       inc       r14d
       cmp       ebx,r14d
       jg        short M01_L00
M01_L03:
       mov       rcx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9DB7ABC48]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,1B250C887A0
       mov       rcx,[rcx]
       mov       rdx,[rbp-28]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       add       rsp,30
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
       mov       rcx,7FF9DB7C7320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1B250C887A0
       mov       rcx,[rcx]
       mov       rdx,[rbp-28]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 301
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FF9CF717018]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF7170D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
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
       mov       esi,ecx
       mov       rdi,rdx
       mov       rcx,22933C07838
       mov       rbx,[rcx]
       mov       rcx,rbx
       call      qword ptr [7FF9CF5BAC18]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rdx,rax
       mov       [rbp-38],rdx
       test      rdi,rdi
       je        near ptr M01_L04
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       mov       rdx,[rbp-38]
       mov       ecx,r15d
       mov       r12,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L03
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9CF21B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M01_L03
M01_L01:
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L02
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9CF21B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       mov       rdx,22933C084B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,[rbp-38]
       mov       r8d,2
       call      qword ptr [7FF9CF21B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF1FFE70]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FF9CF5BAC20]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rsi
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
       mov       rcx,22933C07838
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FF9CF5BAC20]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
; Total bytes of code 312
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
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
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       esi,ecx
       mov       rdi,rdx
       mov       rcx,7FF9DB797320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,14DB69787A0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       mov       [rbp-28],rdx
       test      rdi,rdi
       je        short M01_L03
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short M01_L03
       xor       r14d,r14d
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       mov       rdx,[rbp-28]
       movsxd    rcx,r14d
       mov       rax,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       mov       rcx,rdx
       mov       rdx,rax
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L02
M01_L01:
       cmp       [rdx],edx
       mov       rcx,rdx
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,[rbp-28]
       call      System.Text.StringBuilder.Append(System.String)
M01_L02:
       inc       r14d
       cmp       ebx,r14d
       jg        short M01_L00
M01_L03:
       mov       rcx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9DB77BC48]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,14DB69787A0
       mov       rcx,[rcx]
       mov       rdx,[rbp-28]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       add       rsp,30
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
       mov       rcx,7FF9DB797320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,14DB69787A0
       mov       rcx,[rcx]
       mov       rdx,[rbp-28]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 301
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FF9CF717318]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF7173D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
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
       mov       esi,ecx
       mov       rdi,rdx
       mov       rcx,1B3B0C07838
       mov       rbx,[rcx]
       mov       rcx,rbx
       call      qword ptr [7FF9CF5B9E88]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rdx,rax
       mov       [rbp-38],rdx
       test      rdi,rdi
       je        near ptr M01_L04
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       mov       rdx,[rbp-38]
       mov       ecx,r15d
       mov       r12,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L03
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9CF21B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M01_L03
M01_L01:
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L02
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9CF21B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       mov       rdx,1B3B0C084B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,[rbp-38]
       mov       r8d,2
       call      qword ptr [7FF9CF21B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF1FFE70]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FF9CF5B9E90]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rsi
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
       mov       rcx,1B3B0C07838
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FF9CF5B9E90]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
; Total bytes of code 312
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
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
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       esi,ecx
       mov       rdi,rdx
       mov       rcx,7FF9DB7A7320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,25C408187A0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       mov       [rbp-28],rdx
       test      rdi,rdi
       je        short M01_L03
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short M01_L03
       xor       r14d,r14d
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       mov       rdx,[rbp-28]
       movsxd    rcx,r14d
       mov       rax,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       mov       rcx,rdx
       mov       rdx,rax
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L02
M01_L01:
       cmp       [rdx],edx
       mov       rcx,rdx
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,[rbp-28]
       call      System.Text.StringBuilder.Append(System.String)
M01_L02:
       inc       r14d
       cmp       ebx,r14d
       jg        short M01_L00
M01_L03:
       mov       rcx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9DB78BC48]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,25C408187A0
       mov       rcx,[rcx]
       mov       rdx,[rbp-28]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       add       rsp,30
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
       mov       rcx,7FF9DB7A7320
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,25C408187A0
       mov       rcx,[rcx]
       mov       rdx,[rbp-28]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 301
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FF9CF6F9018]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6F90D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
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
       mov       esi,ecx
       mov       rdi,rdx
       mov       rcx,233E4807838
       mov       rbx,[rcx]
       mov       rcx,rbx
       call      qword ptr [7FF9CF5ABB10]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rdx,rax
       mov       [rbp-38],rdx
       test      rdi,rdi
       je        near ptr M01_L04
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       mov       rdx,[rbp-38]
       mov       ecx,r15d
       mov       r12,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L03
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M01_L03
M01_L01:
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L02
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       mov       rdx,233E48084B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,[rbp-38]
       mov       r8d,2
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF1EFE70]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FF9CF5ABB18]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rsi
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
       mov       rcx,233E4807838
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FF9CF5ABB18]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
; Total bytes of code 312
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M00_L00
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       mov       [rdi+18],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
M00_L00:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 118
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       xor       ebx,ebx
       mov       rcx,[rsi+2A0]
       cmp       dword ptr [rcx+8],0
       jle       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,[rsi+2A0]
       cmp       ebx,[rdx+8]
       jae       short M01_L02
       movsxd    rax,ebx
       mov       rdx,[rdx+rax*8+10]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       mov       rax,[rsi+2A0]
       cmp       [rax+8],ebx
       jg        short M01_L00
M01_L01:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp-20],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,18806913020
       mov       rax,[rax]
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
M02_L00:
       mov       rcx,188069187A0
       mov       rcx,[rcx]
       call      qword ptr [7FF9DBB670C8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-10],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9DB79BC48]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,188069187A0
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FF9DBB670D0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rsi
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
       mov       rcx,188069187A0
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FF9DBB670D0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 174
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
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M00_L00
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       mov       [rdi+18],rcx
       mov       rcx,rdi
       call      qword ptr [7FF9CF6F98D0]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6F9948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9CEF6B630]
       int       3
; Total bytes of code 121
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       xor       ebx,ebx
       mov       rdx,[rsi+2A0]
       cmp       dword ptr [rdx+8],0
       jle       short M01_L02
M01_L00:
       mov       rdx,[rsi+2A0]
       cmp       ebx,[rdx+8]
       jae       short M01_L03
       mov       ecx,ebx
       mov       rdx,[rdx+rcx*8+10]
       cmp       [rdi],dil
       test      rdx,rdx
       je        short M01_L01
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L01:
       inc       ebx
       mov       rax,[rsi+2A0]
       cmp       [rax+8],ebx
       jg        short M01_L00
M01_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       [rbp-20],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,19E4A000030
       mov       rax,[rax]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L00:
       mov       rcx,19E4A005840
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FF9CF5AD170]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-18],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF1EFE70]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FF9CF5AD178]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rsi
       add       rsp,30
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
       lea       rbp,[rbp+40]
       mov       rcx,19E4A005840
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FF9CF5AD178]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 175
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M00_L00
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       mov       [rdi+18],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
M00_L00:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 118
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       xor       ebx,ebx
       mov       rcx,[rsi+2A0]
       cmp       dword ptr [rcx+8],0
       jle       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,[rsi+2A0]
       cmp       ebx,[rdx+8]
       jae       short M01_L02
       movsxd    rax,ebx
       mov       rdx,[rdx+rax*8+10]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       mov       rax,[rsi+2A0]
       cmp       [rax+8],ebx
       jg        short M01_L00
M01_L01:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp-20],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,1E5AB093020
       mov       rax,[rax]
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
M02_L00:
       mov       rcx,1E5AB0987A0
       mov       rcx,[rcx]
       call      qword ptr [7FF9DBB670C8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-10],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9DB79BC48]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,1E5AB0987A0
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FF9DBB670D0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rsi
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
       mov       rcx,1E5AB0987A0
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FF9DBB670D0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 174
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
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M00_L00
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       mov       [rdi+18],rcx
       mov       rcx,rdi
       call      qword ptr [7FF9CF6F7360]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6F73D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9CEF6B630]
       int       3
; Total bytes of code 121
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       xor       ebx,ebx
       mov       rdx,[rsi+2A0]
       cmp       dword ptr [rdx+8],0
       jle       short M01_L02
M01_L00:
       mov       rdx,[rsi+2A0]
       cmp       ebx,[rdx+8]
       jae       short M01_L03
       mov       ecx,ebx
       mov       rdx,[rdx+rcx*8+10]
       cmp       [rdi],dil
       test      rdx,rdx
       je        short M01_L01
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L01:
       inc       ebx
       mov       rax,[rsi+2A0]
       cmp       [rax+8],ebx
       jg        short M01_L00
M01_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       [rbp-20],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,1DA8B802028
       mov       rax,[rax]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L00:
       mov       rcx,1DA8B807838
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FF9CF5ACEA8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-18],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF1EFE70]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FF9CF5ACEB0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rsi
       add       rsp,30
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
       lea       rbp,[rbp+40]
       mov       rcx,1DA8B807838
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FF9CF5ACEB0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 175
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M00_L00
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       mov       [rdi+18],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
M00_L00:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 118
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       xor       ebx,ebx
       mov       rcx,[rsi+2A0]
       cmp       dword ptr [rcx+8],0
       jle       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,[rsi+2A0]
       cmp       ebx,[rdx+8]
       jae       short M01_L02
       movsxd    rax,ebx
       mov       rdx,[rdx+rax*8+10]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       mov       rax,[rsi+2A0]
       cmp       [rax+8],ebx
       jg        short M01_L00
M01_L01:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp-20],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,200A9BE3020
       mov       rax,[rax]
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
M02_L00:
       mov       rcx,200A9BE87A0
       mov       rcx,[rcx]
       call      qword ptr [7FF9DBB670C8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-10],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9DB79BC48]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,200A9BE87A0
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FF9DBB670D0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rsi
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
       mov       rcx,200A9BE87A0
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FF9DBB670D0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 174
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
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M00_L00
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       mov       [rdi+18],rcx
       mov       rcx,rdi
       call      qword ptr [7FF9CF7278D0]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF727948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9CEF9B630]
       int       3
; Total bytes of code 121
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       xor       ebx,ebx
       mov       rdx,[rsi+2A0]
       cmp       dword ptr [rdx+8],0
       jle       short M01_L02
M01_L00:
       mov       rdx,[rsi+2A0]
       cmp       ebx,[rdx+8]
       jae       short M01_L03
       mov       ecx,ebx
       mov       rdx,[rdx+rcx*8+10]
       cmp       [rdi],dil
       test      rdx,rdx
       je        short M01_L01
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF23B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L01:
       inc       ebx
       mov       rax,[rsi+2A0]
       cmp       [rax+8],ebx
       jg        short M01_L00
M01_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       [rbp-20],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,1AB8BC02028
       mov       rax,[rax]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L00:
       mov       rcx,1AB8BC07838
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FF9CF5DDF00]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-18],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF21FE70]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FF9CF5DDF08]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rsi
       add       rsp,30
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
       lea       rbp,[rbp+40]
       mov       rcx,1AB8BC07838
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FF9CF5DDF08]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 175
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M00_L00
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       mov       [rdi+18],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
M00_L00:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 118
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       xor       ebx,ebx
       mov       rcx,[rsi+2A0]
       cmp       dword ptr [rcx+8],0
       jle       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,[rsi+2A0]
       cmp       ebx,[rdx+8]
       jae       short M01_L02
       movsxd    rax,ebx
       mov       rdx,[rdx+rax*8+10]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       mov       rax,[rsi+2A0]
       cmp       [rax+8],ebx
       jg        short M01_L00
M01_L01:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp-20],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,26FD4C43020
       mov       rax,[rax]
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
M02_L00:
       mov       rcx,26FF4C44398
       mov       rcx,[rcx]
       call      qword ptr [7FF9DBB470C8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-10],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9DB77BC48]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,26FF4C44398
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FF9DBB470D0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rsi
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
       mov       rcx,26FF4C44398
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FF9DBB470D0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 174
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
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M00_L00
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       mov       [rdi+18],rcx
       mov       rcx,rdi
       call      qword ptr [7FF9CF6F9360]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6F93D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9CEF6B630]
       int       3
; Total bytes of code 121
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       xor       ebx,ebx
       mov       rdx,[rsi+2A0]
       cmp       dword ptr [rdx+8],0
       jle       short M01_L02
M01_L00:
       mov       rdx,[rsi+2A0]
       cmp       ebx,[rdx+8]
       jae       short M01_L03
       mov       ecx,ebx
       mov       rdx,[rdx+rcx*8+10]
       cmp       [rdi],dil
       test      rdx,rdx
       je        short M01_L01
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L01:
       inc       ebx
       mov       rax,[rsi+2A0]
       cmp       [rax+8],ebx
       jg        short M01_L00
M01_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       [rbp-20],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,1C7C7802028
       mov       rax,[rax]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L00:
       mov       rcx,1C7C7807838
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FF9CF5AF598]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-18],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF1EFE70]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FF9CF5AF5A0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rsi
       add       rsp,30
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
       lea       rbp,[rbp+40]
       mov       rcx,1C7C7807838
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FF9CF5AF5A0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 175
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M00_L00
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       mov       [rdi+18],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
M00_L00:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 118
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       xor       ebx,ebx
       mov       rcx,[rsi+2A0]
       cmp       dword ptr [rcx+8],0
       jle       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,[rsi+2A0]
       cmp       ebx,[rdx+8]
       jae       short M01_L02
       movsxd    rax,ebx
       mov       rdx,[rdx+rax*8+10]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       mov       rax,[rsi+2A0]
       cmp       [rax+8],ebx
       jg        short M01_L00
M01_L01:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp-20],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,280B7143020
       mov       rax,[rax]
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
M02_L00:
       mov       rcx,280D7146390
       mov       rcx,[rcx]
       call      qword ptr [7FF9DBB570C8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-10],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9DB78BC48]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,280D7146390
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FF9DBB570D0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rsi
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
       mov       rcx,280D7146390
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FF9DBB570D0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 174
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
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M00_L00
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       mov       [rdi+18],rcx
       mov       rcx,rdi
       call      qword ptr [7FF9CF6F7060]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6F70D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9CEF5B630]
       int       3
; Total bytes of code 121
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       xor       ebx,ebx
       mov       rdx,[rsi+2A0]
       cmp       dword ptr [rdx+8],0
       jle       short M01_L02
M01_L00:
       mov       rdx,[rsi+2A0]
       cmp       ebx,[rdx+8]
       jae       short M01_L03
       mov       ecx,ebx
       mov       rdx,[rdx+rcx*8+10]
       cmp       [rdi],dil
       test      rdx,rdx
       je        short M01_L01
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF1FB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L01:
       inc       ebx
       mov       rax,[rsi+2A0]
       cmp       [rax+8],ebx
       jg        short M01_L00
M01_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       [rbp-20],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,1C568C02028
       mov       rax,[rax]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L00:
       mov       rcx,1C568C07838
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FF9CF599E88]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-18],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF1DFE70]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FF9CF599E90]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rsi
       add       rsp,30
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
       lea       rbp,[rbp+40]
       mov       rcx,1C568C07838
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FF9CF599E90]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 175
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M00_L00
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       mov       [rdi+18],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
M00_L00:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 118
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       xor       ebx,ebx
       mov       rcx,[rsi+2A0]
       cmp       dword ptr [rcx+8],0
       jle       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,[rsi+2A0]
       cmp       ebx,[rdx+8]
       jae       short M01_L02
       movsxd    rax,ebx
       mov       rdx,[rdx+rax*8+10]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       mov       rax,[rsi+2A0]
       cmp       [rax+8],ebx
       jg        short M01_L00
M01_L01:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp-20],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,29E072E3020
       mov       rax,[rax]
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
M02_L00:
       mov       rcx,29E072E87A0
       mov       rcx,[rcx]
       call      qword ptr [7FF9DBB470C8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-10],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9DB77BC48]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,29E072E87A0
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FF9DBB470D0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rsi
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
       mov       rcx,29E072E87A0
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FF9DBB470D0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 174
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
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M00_L00
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       mov       [rdi+18],rcx
       mov       rcx,rdi
       call      qword ptr [7FF9CF6F9360]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6F93D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9CEF6B630]
       int       3
; Total bytes of code 121
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       xor       ebx,ebx
       mov       rdx,[rsi+2A0]
       cmp       dword ptr [rdx+8],0
       jle       short M01_L02
M01_L00:
       mov       rdx,[rsi+2A0]
       cmp       ebx,[rdx+8]
       jae       short M01_L03
       mov       ecx,ebx
       mov       rdx,[rdx+rcx*8+10]
       cmp       [rdi],dil
       test      rdx,rdx
       je        short M01_L01
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF20B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L01:
       inc       ebx
       mov       rax,[rsi+2A0]
       cmp       [rax+8],ebx
       jg        short M01_L00
M01_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       [rbp-20],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,2A9D3C02028
       mov       rax,[rax]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L00:
       mov       rcx,2A9CFC03430
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FF9CF5AD170]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-18],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF1EFE70]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FF9CF5AD178]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rsi
       add       rsp,30
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
       lea       rbp,[rbp+40]
       mov       rcx,2A9CFC03430
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FF9CF5AD178]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 175
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M00_L00
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       mov       [rdi+18],rcx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
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
M00_L00:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 118
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       xor       ebx,ebx
       mov       rcx,[rsi+2A0]
       cmp       dword ptr [rcx+8],0
       jle       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,[rsi+2A0]
       cmp       ebx,[rdx+8]
       jae       short M01_L02
       movsxd    rax,ebx
       mov       rdx,[rdx+rax*8+10]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       mov       rax,[rsi+2A0]
       cmp       [rax+8],ebx
       jg        short M01_L00
M01_L01:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp-20],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,257043F3020
       mov       rax,[rax]
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
M02_L00:
       mov       rcx,257043F87A0
       mov       rcx,[rcx]
       call      qword ptr [7FF9DBB570C8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-10],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9DB78BC48]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,257043F87A0
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FF9DBB570D0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rsi
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
       mov       rcx,257043F87A0
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FF9DBB570D0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 174
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
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.PerformAction()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rcx,offset MT_System.Action`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M00_L00
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       mov       [rdi+18],rcx
       mov       rcx,rdi
       call      qword ptr [7FF9CF739060]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF7390D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9CEF9B630]
       int       3
; Total bytes of code 121
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.<PerformAction>b__8_0(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       xor       ebx,ebx
       mov       rdx,[rsi+2A0]
       cmp       dword ptr [rdx+8],0
       jle       short M01_L02
M01_L00:
       mov       rdx,[rsi+2A0]
       cmp       ebx,[rdx+8]
       jae       short M01_L03
       mov       ecx,ebx
       mov       rdx,[rdx+rcx*8+10]
       cmp       [rdi],dil
       test      rdx,rdx
       je        short M01_L01
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9CF23B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L01:
       inc       ebx
       mov       rax,[rsi+2A0]
       cmp       [rax+8],ebx
       jg        short M01_L00
M01_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       [rbp-20],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,158B9002028
       mov       rax,[rax]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L00:
       mov       rcx,158B9007838
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FF9CF5DBB10]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-18],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF21FE70]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FF9CF5DBB18]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       mov       rax,rsi
       add       rsp,30
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
       lea       rbp,[rbp+40]
       mov       rcx,158B9007838
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FF9CF5DBB18]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
       nop
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 175
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

