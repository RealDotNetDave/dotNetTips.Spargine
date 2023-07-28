## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,22263EB1C28
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,221D3EB1568
       mov       rbp,[rdx]
       mov       rdx,22263EB1C30
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
       call      qword ptr [7FFD6774B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FFD674A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FFD674A4000
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
       mov       rdx,7FFD674A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FFD674A4000
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
       mov       rdx,7FFD674A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FFD674A4000
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
       mov       rax,7CC8F91D5A5
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
       mov       rcx,7CC8F91D5A5
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
       mov       rcx,7CC8F91D5A5
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
       mov       rcx,7CC8F91D5A5
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
       mov       rax,221D3EB3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FFD674A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFD674A4000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD5263B150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,1AECEC0F3F8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FFD5263B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,1AED2C00528
       mov       rbp,[rdx]
       mov       rdx,1AECEC0F400
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
       call      qword ptr [7FFD525D3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FFD5263B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFD5263B258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FFD52640080]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFD52319018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFD521E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FFD521E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5245D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525D5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFD521E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FFD521E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5245D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525D5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFD521E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FFD521E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5245D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525D5750]
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
       call      qword ptr [7FFD524799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFD5263B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rax,9A47C67CCB3C
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
       call      qword ptr [7FFD525D36F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       call      qword ptr [7FFD525D3348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,9A47C67CCB3C
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
       call      qword ptr [7FFD525D3408]
       mov       rcx,9A47C67CCB3C
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
       call      qword ptr [7FFD525A96D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FFD525A9288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FFD52B29E70]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FFD52B29E88]
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
       call      qword ptr [7FFD52B29E88]
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
       call      qword ptr [7FFD525D3708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FFD525D3720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD52769B40]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,9A47C67CCB3C
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
       call      qword ptr [7FFD524799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1AED2C02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FFD521E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFD521E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5245D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525D5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,215FCFE9BC0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,215BCFE1568
       mov       rbp,[rdx]
       mov       rdx,215FCFE9BC8
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
       call      qword ptr [7FFD6775B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FFD674B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FFD674B4000
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
       mov       rdx,7FFD674B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FFD674B4000
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
       mov       rdx,7FFD674B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FFD674B4000
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
       mov       rax,9CE70BB006CE
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
       mov       rcx,9CE70BB006CE
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
       mov       rcx,9CE70BB006CE
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
       mov       rcx,9CE70BB006CE
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
       mov       rax,215BCFE3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FFD674B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFD674B4000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD5264B150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,24818C00C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FFD5264B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,24810C00528
       mov       rbp,[rdx]
       mov       rdx,24818C00C80
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
       call      qword ptr [7FFD525E3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FFD5264B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFD5264B258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FFD52650080]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFD52329018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5246D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525E5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5246D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525E5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5246D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525E5750]
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
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFD5264B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rax,88B856CCE2A7
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
       call      qword ptr [7FFD525E36F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       call      qword ptr [7FFD525E3348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,88B856CCE2A7
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
       call      qword ptr [7FFD525E3408]
       mov       rcx,88B856CCE2A7
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
       call      qword ptr [7FFD525B96D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FFD525B9288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FFD52C57918]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FFD52C57930]
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
       call      qword ptr [7FFD52C57930]
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
       call      qword ptr [7FFD525E3708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FFD525E3720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD52769B40]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,88B856CCE2A7
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
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,24810C02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5246D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525E5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,19A8D5A1C28
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,19A1D5A1568
       mov       rbp,[rdx]
       mov       rdx,19A8D5A1C30
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
       call      qword ptr [7FFD6774B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FFD674A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FFD674A4000
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
       mov       rdx,7FFD674A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FFD674A4000
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
       mov       rdx,7FFD674A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FFD674A4000
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
       mov       rax,0DBC7DC66A594
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
       mov       rcx,0DBC7DC66A594
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
       mov       rcx,0DBC7DC66A594
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
       mov       rcx,0DBC7DC66A594
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
       mov       rax,19A1D5A3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FFD674A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFD674A4000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD5263B150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,25710800C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FFD5263B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,25700800528
       mov       rbp,[rdx]
       mov       rdx,25710800C80
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
       call      qword ptr [7FFD525D3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FFD5263B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFD5263B258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FFD52640080]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFD52319018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFD521E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FFD521E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5245D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525D5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFD521E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FFD521E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5245D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525D5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFD521E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FFD521E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5245D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525D5750]
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
       call      qword ptr [7FFD524799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFD5263B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rax,0FF3E9207F4F5
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
       call      qword ptr [7FFD525D36F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       call      qword ptr [7FFD525D3348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,0FF3E9207F4F5
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
       call      qword ptr [7FFD525D3408]
       mov       rcx,0FF3E9207F4F5
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
       call      qword ptr [7FFD525A96D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FFD525A9288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FFD52C35C30]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FFD52C35C48]
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
       call      qword ptr [7FFD52C35C48]
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
       call      qword ptr [7FFD525D3708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FFD525D3720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD52759B40]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,0FF3E9207F4F5
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
       call      qword ptr [7FFD524799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,25700802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FFD521E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFD521E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5245D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525D5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,1CF496F1C28
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,1CEF96F1568
       mov       rbp,[rdx]
       mov       rdx,1CF496F1C30
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
       call      qword ptr [7FFD6776B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FFD674C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FFD674C4000
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
       mov       rdx,7FFD674C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FFD674C4000
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
       mov       rdx,7FFD674C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FFD674C4000
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
       mov       rax,34D919740B8B
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
       mov       rcx,34D919740B8B
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
       mov       rcx,34D919740B8B
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
       mov       rcx,34D919740B8B
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
       mov       rax,1CEF96F3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FFD674C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFD674C4000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD5264B150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,272BEC00C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FFD5264B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,272AEC00528
       mov       rbp,[rdx]
       mov       rdx,272BEC00C80
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
       call      qword ptr [7FFD525E3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FFD5264B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFD5264B258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FFD52650080]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFD52329018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5246D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525E5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5246D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525E5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5246D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525E5750]
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
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFD5264B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rax,56ED055F129B
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
       call      qword ptr [7FFD525E36F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       call      qword ptr [7FFD525E3348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,56ED055F129B
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
       call      qword ptr [7FFD525E3408]
       mov       rcx,56ED055F129B
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
       call      qword ptr [7FFD525B96D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FFD525B9288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FFD52C57018]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FFD52C57030]
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
       call      qword ptr [7FFD52C57030]
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
       call      qword ptr [7FFD525E3708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FFD525E3720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD52769B40]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,56ED055F129B
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
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,272AEC02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5246D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525E5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,1B738C41C28
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,1B758C41568
       mov       rbp,[rdx]
       mov       rdx,1B738C41C30
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
       call      qword ptr [7FFD6774B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FFD674A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FFD674A4000
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
       mov       rdx,7FFD674A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FFD674A4000
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
       mov       rdx,7FFD674A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FFD674A4000
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
       mov       rax,870495E59DCD
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
       mov       rcx,870495E59DCD
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
       mov       rcx,870495E59DCD
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
       mov       rcx,870495E59DCD
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
       mov       rax,1B758C43020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FFD674A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFD674A4000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD45DDB150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,28C5F409870
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FFD45DDB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,28C5F400528
       mov       rbp,[rdx]
       mov       rdx,28C5F409878
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
       call      qword ptr [7FFD45D73FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FFD45DDB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFD45DDB258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FFD45DE0080]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFD45AB9018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFD45984000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FFD45984000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD45BFD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD45D75750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFD45984000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FFD45984000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD45BFD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD45D75750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFD45984000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FFD45984000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD45BFD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD45D75750]
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
       call      qword ptr [7FFD45C199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFD45DDB9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rax,61C886BD22DC
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
       call      qword ptr [7FFD45D736F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       call      qword ptr [7FFD45D73348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,61C886BD22DC
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
       call      qword ptr [7FFD45D73408]
       mov       rcx,61C886BD22DC
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
       call      qword ptr [7FFD45D496D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FFD45D49288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FFD463D7018]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FFD463D7030]
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
       call      qword ptr [7FFD463D7030]
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
       call      qword ptr [7FFD45D73708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FFD45D73720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD45EF9B40]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,61C886BD22DC
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
       call      qword ptr [7FFD45C199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,28C5F402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FFD45984000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFD45984000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD45BFD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD45D75750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,26A32D51C28
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,269C2D51568
       mov       rbp,[rdx]
       mov       rdx,26A32D51C30
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
       call      qword ptr [7FFD6773B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FFD67494000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FFD67494000
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
       mov       rdx,7FFD67494000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FFD67494000
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
       mov       rdx,7FFD67494000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FFD67494000
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
       mov       rax,292AE854C628
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
       mov       rcx,292AE854C628
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
       mov       rcx,292AE854C628
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
       mov       rcx,292AE854C628
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
       mov       rax,269C2D53020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FFD67494000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFD67494000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD5261B150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,21BAB409C28
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FFD5261B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,21B9B400528
       mov       rbp,[rdx]
       mov       rdx,21BAB409C30
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
       call      qword ptr [7FFD525B3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FFD5261B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFD5261B258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FFD52620080]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFD522F9018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFD521C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FFD521C4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5243D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFD521C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FFD521C4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5243D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFD521C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FFD521C4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5243D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525B5750]
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
       call      qword ptr [7FFD524599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFD5261B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rax,5804FA69158D
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
       call      qword ptr [7FFD525B36F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       call      qword ptr [7FFD525B3348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,5804FA69158D
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
       call      qword ptr [7FFD525B3408]
       mov       rcx,5804FA69158D
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
       call      qword ptr [7FFD525896D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FFD52589288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FFD52C29018]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FFD52C29030]
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
       call      qword ptr [7FFD52C29030]
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
       call      qword ptr [7FFD525B3708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FFD525B3720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD52739B40]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,5804FA69158D
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
       call      qword ptr [7FFD524599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21B9B402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FFD521C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFD521C4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5243D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rdx,1CFAC3D1C28
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,1CF3C3D1568
       mov       rbp,[rdx]
       mov       rdx,1CFAC3D1C30
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
       call      qword ptr [7FFD6775B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FFD674B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FFD674B4000
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
       mov       rdx,7FFD674B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FFD674B4000
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
       mov       rdx,7FFD674B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FFD674B4000
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
       mov       rax,0F09AEB387711
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
       mov       rcx,0F09AEB387711
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
       mov       rcx,0F09AEB387711
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
       mov       rcx,0F09AEB387711
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
       mov       rax,1CF3C3D3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FFD674B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFD674B4000
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD5264B150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,168FCC00C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FFD5264B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,168FEC00528
       mov       rbp,[rdx]
       mov       rdx,168FCC00C80
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
       call      qword ptr [7FFD525E3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FFD5264B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFD5264B258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FFD52650080]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFD52329018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5246D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525E5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5246D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525E5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5246D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525E5750]
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
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFD5264B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rax,0D6190208F216
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
       call      qword ptr [7FFD525E36F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       call      qword ptr [7FFD525E3348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,0D6190208F216
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
       call      qword ptr [7FFD525E3408]
       mov       rcx,0D6190208F216
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
       call      qword ptr [7FFD525B96D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FFD525B9288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FFD52C57810]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FFD52C57828]
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
       call      qword ptr [7FFD52C57828]
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
       call      qword ptr [7FFD525E3708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FFD525E3720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD52769B40]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,0D6190208F216
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
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,168FEC02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5246D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525E5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD6777B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,2C2E5A03020
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
       mov       rdx,7FFD674D4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFD674D4000
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
       call      qword ptr [7FFD5262B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFD52630080]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFD524699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFD5262B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFD524699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,20C70802028
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
       mov       rdx,7FFD521D4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFD521D4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5244D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525C5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD6776B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,2567C573020
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
       mov       rdx,7FFD674C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFD674C4000
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
       call      qword ptr [7FFD5262B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFD52630080]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFD524699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFD5262B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFD524699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,16AF0C02028
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
       mov       rdx,7FFD521D4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFD521D4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5244D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525C5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD6776B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,1911E563020
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
       mov       rdx,7FFD674C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFD674C4000
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
       call      qword ptr [7FFD5261B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFD52620080]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFD524599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFD5261B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFD524599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2B5F6802028
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
       mov       rdx,7FFD521C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFD521C4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5243D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD6773B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,1E27D123020
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
       mov       rdx,7FFD67494000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFD67494000
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
       call      qword ptr [7FFD5264B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFD52650080]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFD5264B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,204C2402028
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
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5246D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525E5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD6775B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,206A0353020
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
       mov       rdx,7FFD674B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFD674B4000
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
       call      qword ptr [7FFD5264B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFD52650080]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFD5264B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1A6E3402028
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
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5246D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525E5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD6775B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,1C1818D3020
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
       mov       rdx,7FFD674B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFD674B4000
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
       call      qword ptr [7FFD5264B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFD52650080]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFD5264B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1F632802028
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
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5246D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525E5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD6775B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,23A64E13020
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
       mov       rdx,7FFD674B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFD674B4000
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
       call      qword ptr [7FFD5264B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFD52650080]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFD5264B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,207FA002028
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
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5246D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525E5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD6776B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,21E6E543020
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
       mov       rdx,7FFD674C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFD674C4000
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
       call      qword ptr [7FFD5263B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFD52640080]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFD524799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFD5263B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFD524799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,164ED802028
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
       mov       rdx,7FFD521E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFD521E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5245D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525D5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD6776B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,17FE2A63020
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
       mov       rdx,7FFD674C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFD674C4000
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
       call      qword ptr [7FFD5262B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFD52630080]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFD524699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFD5262B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFD524699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1C09E002028
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
       mov       rdx,7FFD521D4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFD521D4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5244D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525C5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD6775B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,1C7B1BC3020
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
       mov       rdx,7FFD674B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFD674B4000
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
       call      qword ptr [7FFD5262B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFD52630080]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFD524699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFD5262B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFD524699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1F57A402028
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
       mov       rdx,7FFD521D4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFD521D4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5244D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525C5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD6776B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,25FDFFC3020
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
       mov       rdx,7FFD674C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFD674C4000
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
       call      qword ptr [7FFD5264B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFD52650080]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFD5264B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2CC2F402028
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
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFD521F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5246D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525E5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD6777B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,1E3FF0E3020
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
       mov       rdx,7FFD674D4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFD674D4000
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
       call      qword ptr [7FFD5265B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFD52660080]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFD524999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFD5265B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFD524999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,27338C02028
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
       mov       rdx,7FFD52204000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFD52204000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5247D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525F5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD6777B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,1A8ADC33020
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
       mov       rdx,7FFD674D4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFD674D4000
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
       call      qword ptr [7FFD5261B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFD52620080]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFD524599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFD5261B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFD524599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1F8DA002028
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
       mov       rdx,7FFD521C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFD521C4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5243D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525B5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD6774B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,21CB5083020
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
       mov       rdx,7FFD674A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFD674A4000
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
       call      qword ptr [7FFD5262B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFD52630080]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFD524699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFD5262B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFD524699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2AD03402028
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
       mov       rdx,7FFD521D4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFD521D4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5244D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD525C5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rax,12E440C1028
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
       mov       rcx,7FFD67776A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,12E440C6798
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,12EA40C1C28
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,12E640C1568
       mov       r15,[rdx]
       mov       rdx,12EA40C1C30
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
       call      qword ptr [7FFD6776B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rcx,12E440C6798
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
       mov       rcx,7FFD67776A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,12E440C6798
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FFD52B07870]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52B07AB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,20622802028
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
       mov       rcx,206228077E8
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFD529BD260]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,20628800C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFD5261B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,20622800528
       mov       r12,[rdx]
       mov       rdx,20628800C80
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFD525B3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFD5261B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFD52620080]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFD5261B258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFD529BD268]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,206228077E8
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFD529BD268]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rax,22E5CF03020
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
       mov       rcx,7FFD67786A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,22E3CF06380
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,22EACF01C28
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,22E5CF01568
       mov       r15,[rdx]
       mov       rdx,22EACF01C30
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
       call      qword ptr [7FFD6777B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rcx,22E3CF06380
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
       mov       rcx,7FFD67786A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,22E3CF06380
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FFD52B17000]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52B17240]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,2880F002028
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
       mov       rcx,2880F0077E8
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFD529CA240]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,2880D001C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFD5262B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,2880F000528
       mov       r12,[rdx]
       mov       rdx,2880D001C98
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFD525C3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFD5262B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFD52630080]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFD5262B258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFD529CA248]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,2880F0077E8
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFD529CA248]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rax,1FCCF7A1028
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
       mov       rcx,7FFD67766A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FCCF7A6798
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,1FD2F7A1C28
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,1FCEF7A1568
       mov       r15,[rdx]
       mov       rdx,1FD2F7A1C30
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
       call      qword ptr [7FFD6775B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rcx,1FCCF7A6798
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
       mov       rcx,7FFD67766A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FCCF7A6798
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FFD52B07870]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52B07AB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,165B5802028
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
       mov       rcx,165B58077E8
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFD529BD260]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,165C5800C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFD5261B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,165B5800528
       mov       r12,[rdx]
       mov       rdx,165C5800C80
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFD525B3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFD5261B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFD52620080]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFD5261B258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFD529BD268]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,165B58077E8
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFD529BD268]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rax,160B6C03020
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
       mov       rcx,7FFD67766A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,160B6C08790
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,16106C01C28
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,160B6C01568
       mov       r15,[rdx]
       mov       rdx,16106C01C30
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
       call      qword ptr [7FFD6775B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rcx,160B6C08790
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
       mov       rcx,7FFD67766A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,160B6C08790
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FFD462B7870]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD462B7AB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,1D3C2C00030
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
       mov       rcx,1D3C2C057F0
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFD4616D260]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,1D3C6C02C70
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFD45DCB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,1D3C6C00528
       mov       r12,[rdx]
       mov       rdx,1D3C6C02C78
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFD45D63FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFD45DCB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFD45DD0080]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFD45DCB258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFD4616D268]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1D3C2C057F0
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFD4616D268]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rax,27D6DC01028
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
       mov       rcx,7FFD67746A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,27D6DC06798
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,27D8DC0BBB8
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,27D8DC01568
       mov       r15,[rdx]
       mov       rdx,27D8DC0BBC0
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
       call      qword ptr [7FFD6773B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rcx,27D6DC06798
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
       mov       rcx,7FFD67746A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,27D6DC06798
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FFD462B7870]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD462B7AB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,22A9D402028
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
       mov       rcx,22A9D4077E8
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFD4616DFF0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,22A9D411808
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFD45DCB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,22A9D400528
       mov       r12,[rdx]
       mov       rdx,22A9D411810
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFD45D63FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFD45DCB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFD45DD0080]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFD45DCB258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFD4616DFF8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,22A9D4077E8
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFD4616DFF8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rax,2548AA93020
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
       mov       rcx,7FFD67786A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2548AA98790
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,254EAA91C28
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,2548AA91568
       mov       r15,[rdx]
       mov       rdx,254EAA91C30
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
       call      qword ptr [7FFD6777B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rcx,2548AA98790
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
       mov       rcx,7FFD67786A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2548AA98790
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FFD462B7000]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD462B7240]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,1A7B0802028
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
       mov       rcx,1A7B08077E8
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFD4616A240]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,1A7B2801C90
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFD45DCB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,1A7B0800528
       mov       r12,[rdx]
       mov       rdx,1A7B2801C98
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFD45D63FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFD45DCB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFD45DD0080]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFD45DCB258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFD4616A248]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1A7B08077E8
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFD4616A248]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rax,1DEAADC3020
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
       mov       rcx,7FFD67786A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1DE8ADC4388
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,1DEFADC1C28
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,1DEAADC1568
       mov       r15,[rdx]
       mov       rdx,1DEFADC1C30
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
       call      qword ptr [7FFD6777B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rcx,1DE8ADC4388
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
       mov       rcx,7FFD67786A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1DE8ADC4388
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FFD462C9300]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD462C9540]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,1E78B802028
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
       mov       rcx,1E78B8077E8
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFD4616BEC8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,1E79D800C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFD45DCB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,1E78B800528
       mov       r12,[rdx]
       mov       rdx,1E79D800C80
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFD45D63FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFD45DCB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFD45DD0080]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFD45DCB258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFD4616BED0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1E78B8077E8
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFD4616BED0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,7FFD67756A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1F20F6C8790
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
       call      qword ptr [7FFD6774B6B8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,1F20F6C8790
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
       mov       rcx,7FFD67756A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1F20F6C8790
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FFD52B57018]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52B570D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,1CAAF4077E8
       mov       rbx,[rcx]
       mov       rcx,rbx
       call      qword ptr [7FFD529FA240]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
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
       call      qword ptr [7FFD5265B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M01_L03
M01_L01:
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L02
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FFD5265B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       mov       rdx,1CAAF4084B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,[rbp-38]
       mov       r8d,2
       call      qword ptr [7FFD5265B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFD52660080]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFD529FA248]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1CAAF4077E8
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFD529FA248]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD67756A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,13C0D844388
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
       call      qword ptr [7FFD6774B6B8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,13C0D844388
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
       mov       rcx,7FFD67756A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,13C0D844388
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FFD52B47888]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52B47948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,21CFE4077E8
       mov       rbx,[rcx]
       mov       rcx,rbx
       call      qword ptr [7FFD529FE330]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
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
       call      qword ptr [7FFD5265B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M01_L03
M01_L01:
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L02
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FFD5265B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       mov       rdx,21CFE4084B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,[rbp-38]
       mov       r8d,2
       call      qword ptr [7FFD5265B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFD52660080]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFD529FE338]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,21CFE4077E8
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFD529FE338]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD67776A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,218BE0A8790
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
       call      qword ptr [7FFD6776B6B8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,218BE0A8790
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
       mov       rcx,7FFD67776A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,218BE0A8790
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FFD52B19318]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52B193D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,1CF648077E8
       mov       rbx,[rcx]
       mov       rcx,rbx
       call      qword ptr [7FFD529CF950]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
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
       call      qword ptr [7FFD5262B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M01_L03
M01_L01:
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L02
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FFD5262B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       mov       rdx,1CF648084B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,[rbp-38]
       mov       r8d,2
       call      qword ptr [7FFD5262B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFD52630080]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFD529CF958]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1CF648077E8
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFD529CF958]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD67766A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,11C952E8790
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
       call      qword ptr [7FFD6775B6B8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,11C952E8790
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
       mov       rcx,7FFD67766A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,11C952E8790
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FFD46297018]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD462970D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,15444C057F0
       mov       rbx,[rcx]
       mov       rcx,rbx
       call      qword ptr [7FFD4614A240]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
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
       call      qword ptr [7FFD45DAB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M01_L03
M01_L01:
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L02
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FFD45DAB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       mov       rdx,15444C064B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,[rbp-38]
       mov       r8d,2
       call      qword ptr [7FFD45DAB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFD45DB0080]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFD4614A248]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,15444C057F0
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFD4614A248]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD67766A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1F4DE5C4388
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
       call      qword ptr [7FFD6775B6B8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,1F4DE5C4388
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
       mov       rcx,7FFD67766A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1F4DE5C4388
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FFD462C9018]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD462C90D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,23A3DC077E8
       mov       rbx,[rcx]
       mov       rcx,rbx
       call      qword ptr [7FFD4616BEC8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
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
       call      qword ptr [7FFD45DCB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M01_L03
M01_L01:
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L02
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FFD45DCB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       mov       rdx,23A3DC084B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,[rbp-38]
       mov       r8d,2
       call      qword ptr [7FFD45DCB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFD45DD0080]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFD4616BED0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,23A3DC077E8
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFD4616BED0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD67746A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2400E644388
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
       call      qword ptr [7FFD6773B6B8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,2400E644388
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
       mov       rcx,7FFD67746A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2400E644388
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FFD462C7318]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD462C73D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,1B26DC033E0
       mov       rbx,[rcx]
       mov       rcx,rbx
       call      qword ptr [7FFD46169880]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
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
       call      qword ptr [7FFD45DCB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M01_L03
M01_L01:
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L02
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FFD45DCB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       mov       rdx,1B26DC040A8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,[rbp-38]
       mov       r8d,2
       call      qword ptr [7FFD45DCB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFD45DD0080]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFD46169888]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1B26DC033E0
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFD46169888]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,7FFD67746A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,19178218790
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
       call      qword ptr [7FFD6773B6B8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,19178218790
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
       mov       rcx,7FFD67746A70
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,19178218790
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FFD462C9888]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD462C9948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,27E7C8077E8
       mov       rbx,[rcx]
       mov       rcx,rbx
       call      qword ptr [7FFD4617D528]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
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
       call      qword ptr [7FFD45DDB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M01_L03
M01_L01:
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L02
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FFD45DDB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       mov       rdx,27E7C8084B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,[rbp-38]
       mov       r8d,2
       call      qword ptr [7FFD45DDB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFD45DE0080]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFD4617D530]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,27E7C8077E8
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFD4617D530]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rax,2369F0C3020
       mov       rax,[rax]
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
M02_L00:
       mov       rcx,2369F0C8790
       mov       rcx,[rcx]
       call      qword ptr [7FFD67AF7030]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-10],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD6773B6B8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,2369F0C8790
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFD67AF7038]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,2369F0C8790
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFD67AF7038]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52B17060]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52B170D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFD5238B630]
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
       call      qword ptr [7FFD5262B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       mov       rax,1BD2FC02028
       mov       rax,[rax]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L00:
       mov       rcx,1BD2FC077E8
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFD529CCC58]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-18],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFD52630080]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFD529CCC60]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1BD2FC077E8
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFD529CCC60]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rax,138CB6E3020
       mov       rax,[rax]
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
M02_L00:
       mov       rcx,138CB6E8790
       mov       rcx,[rcx]
       call      qword ptr [7FFD67B27030]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-10],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD6776B6B8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,138CB6E8790
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFD67B27038]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,138CB6E8790
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFD67B27038]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52B37060]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52B370D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFD523AB630]
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
       call      qword ptr [7FFD5264B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       mov       rax,1AE67402028
       mov       rax,[rax]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L00:
       mov       rcx,1AE674077E8
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFD529EA240]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-18],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFD52650080]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFD529EA248]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1AE674077E8
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFD529EA248]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rax,1C3ADFB3020
       mov       rax,[rax]
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
M02_L00:
       mov       rcx,1C3ADFB8790
       mov       rcx,[rcx]
       call      qword ptr [7FFD67B17030]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-10],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD6775B6B8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,1C3ADFB8790
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFD67B17038]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1C3ADFB8790
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFD67B17038]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52B17060]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52B170D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFD5238B630]
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
       call      qword ptr [7FFD5262B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       mov       rax,202AA802028
       mov       rax,[rax]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L00:
       mov       rcx,202AA8077E8
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFD529CA240]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-18],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFD52630080]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFD529CA248]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,202AA8077E8
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFD529CA248]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rax,1F3B4FA3020
       mov       rax,[rax]
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
M02_L00:
       mov       rcx,1F3B4FA8790
       mov       rcx,[rcx]
       call      qword ptr [7FFD67B17030]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-10],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD6775B6B8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,1F3B4FA8790
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFD67B17038]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1F3B4FA8790
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFD67B17038]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD462A7060]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD462A70D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFD45B1B630]
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
       call      qword ptr [7FFD45DBB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       mov       rax,273F6802028
       mov       rax,[rax]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L00:
       mov       rcx,273F68077E8
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFD4615CC58]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-18],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFD45DC0080]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFD4615CC60]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,273F68077E8
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFD4615CC60]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rax,22722963020
       mov       rax,[rax]
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
M02_L00:
       mov       rcx,22722968790
       mov       rcx,[rcx]
       call      qword ptr [7FFD67B17030]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-10],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD6775B6B8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,22722968790
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFD67B17038]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,22722968790
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFD67B17038]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD462978D0]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD46297948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFD45B0B630]
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
       call      qword ptr [7FFD45DAB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       mov       rax,29563002028
       mov       rax,[rax]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L00:
       mov       rcx,295630077E8
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFD4614D260]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-18],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFD45DB0080]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFD4614D268]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,295630077E8
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFD4614D268]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rax,19237333020
       mov       rax,[rax]
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
M02_L00:
       mov       rcx,19217334388
       mov       rcx,[rcx]
       call      qword ptr [7FFD67B05088]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-10],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD6774B6B8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,19217334388
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFD67B05090]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,19217334388
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFD67B05090]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD462D9060]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD462D90D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFD45B3B630]
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
       call      qword ptr [7FFD45DDB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       mov       rax,1D494C02028
       mov       rax,[rax]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L00:
       mov       rcx,1D494C077E8
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFD4617BEC8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-18],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFD45DE0080]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFD4617BED0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1D494C077E8
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFD4617BED0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rax,1785F6A3020
       mov       rax,[rax]
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
M02_L00:
       mov       rcx,1785F6A8790
       mov       rcx,[rcx]
       call      qword ptr [7FFD67B07030]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-10],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFD6774B6B8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,1785F6A8790
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFD67B07038]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1785F6A8790
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFD67B07038]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52B078D0]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52B07948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFD5237B630]
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
       call      qword ptr [7FFD5261B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       mov       rax,2659EC02028
       mov       rax,[rax]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L00:
       mov       rcx,2659EC077E8
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFD529BF178]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-18],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFD52620080]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFD529BF180]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,2659EC077E8
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFD529BF180]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

