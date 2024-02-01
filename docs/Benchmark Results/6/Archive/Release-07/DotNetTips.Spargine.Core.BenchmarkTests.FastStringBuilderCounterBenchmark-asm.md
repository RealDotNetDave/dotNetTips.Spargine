## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       mov       rdx,25C39AD1C28
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,25C69AD1568
       mov       rbp,[rdx]
       mov       rdx,25C39AD1C30
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
       call      qword ptr [7FF9C788BC48]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FF9C75D4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FF9C75D4000
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
       mov       rdx,7FF9C75D4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FF9C75D4000
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
       mov       rdx,7FF9C75D4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FF9C75D4000
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
       mov       rax,341DDD4A33B3
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
       mov       rcx,341DDD4A33B3
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
       mov       rcx,341DDD4A33B3
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
       mov       rcx,341DDD4A33B3
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
       mov       rax,25C49AD1028
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
       mov       rdx,7FF9C75D4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C75D4000
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C07CD150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,22202000C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FF9C07CD9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,22204000528
       mov       rbp,[rdx]
       mov       rdx,22202000C80
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
       call      qword ptr [7FF9C0765FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9C07CD9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF9C07CD258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FF9C07AFE38]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9C0499018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FF9C0364000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FF9C0364000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C05DD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C0767750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9C0364000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FF9C0364000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C05DD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C0767750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9C0364000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FF9C0364000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C05DD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C0767750]
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
       call      qword ptr [7FF9C05F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF9C07CD9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rax,0C41F310D8917
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
       call      qword ptr [7FF9C07656F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       call      qword ptr [7FF9C0765348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,0C41F310D8917
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
       call      qword ptr [7FF9C0765408]
       mov       rcx,0C41F310D8917
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
       call      qword ptr [7FF9C073B6D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FF9C073B288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FF9C0DC97B0]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FF9C0DC97C8]
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
       call      qword ptr [7FF9C0DC97C8]
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
       call      qword ptr [7FF9C0765708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FF9C0765720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FF9C08EBB40]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,0C41F310D8917
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
       call      qword ptr [7FF9C05F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22204002028
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
       mov       rdx,7FF9C0364000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C0364000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C05DD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C0767750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       mov       rdx,2258759E3B0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,225A7591568
       mov       rbp,[rdx]
       mov       rdx,2258759E3B8
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
       call      qword ptr [7FF9C784BC48]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FF9C75A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FF9C75A4000
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
       mov       rdx,7FF9C75A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FF9C75A4000
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
       mov       rdx,7FF9C75A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FF9C75A4000
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
       mov       rax,0EDEEF2238AF8
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
       mov       rcx,0EDEEF2238AF8
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
       mov       rcx,0EDEEF2238AF8
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
       mov       rcx,0EDEEF2238AF8
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
       mov       rax,225A7593020
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
       mov       rdx,7FF9C75A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C75A4000
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C07BB150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,17E77C00C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FF9C07BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,17E6FC00528
       mov       rbp,[rdx]
       mov       rdx,17E77C00C80
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
       call      qword ptr [7FF9C0753FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9C07BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF9C07BB258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FF9C079FE38]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9C0499018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FF9C0364000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FF9C0364000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C05DD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C0755750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9C0364000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FF9C0364000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C05DD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C0755750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9C0364000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FF9C0364000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C05DD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C0755750]
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
       call      qword ptr [7FF9C05F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF9C07BB9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rax,8B78146D1C6A
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
       call      qword ptr [7FF9C07536F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       call      qword ptr [7FF9C0753348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,8B78146D1C6A
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
       call      qword ptr [7FF9C0753408]
       mov       rcx,8B78146D1C6A
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
       call      qword ptr [7FF9C07296D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FF9C0729288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FF9C0DD5918]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FF9C0DD5930]
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
       call      qword ptr [7FF9C0DD5930]
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
       call      qword ptr [7FF9C0753708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FF9C0753720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FF9C08D9B40]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,8B78146D1C6A
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
       call      qword ptr [7FF9C05F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,17E6FC02028
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
       mov       rdx,7FF9C0364000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C0364000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C05DD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C0755750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       mov       rdx,1CFA35527B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,1CFA3541568
       mov       rbp,[rdx]
       mov       rdx,1CFA35527C0
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
       call      qword ptr [7FF9C788BC48]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FF9C75E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FF9C75E4000
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
       mov       rdx,7FF9C75E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FF9C75E4000
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
       mov       rdx,7FF9C75E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FF9C75E4000
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
       mov       rax,6234F8A694FA
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
       mov       rcx,6234F8A694FA
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
       mov       rcx,6234F8A694FA
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
       mov       rcx,6234F8A694FA
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
       mov       rax,1CFA3543020
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
       mov       rdx,7FF9C75E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C75E4000
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C513B150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,1D8D5400C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FF9C513B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,1D8C3400528
       mov       rbp,[rdx]
       mov       rdx,1D8D5400C80
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
       call      qword ptr [7FF9C50D3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9C513B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF9C513B258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FF9C511FE38]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9C4E19018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FF9C4CE4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FF9C4CE4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C4F5D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C50D5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9C4CE4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FF9C4CE4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C4F5D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C50D5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9C4CE4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FF9C4CE4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C4F5D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C50D5750]
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
       call      qword ptr [7FF9C4F799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF9C513B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rax,0D9BA946D7D0C
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
       call      qword ptr [7FF9C50D36F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       call      qword ptr [7FF9C50D3348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,0D9BA946D7D0C
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
       call      qword ptr [7FF9C50D3408]
       mov       rcx,0D9BA946D7D0C
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
       call      qword ptr [7FF9C50A96D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FF9C50A9288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FF9C5755C30]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FF9C5755C48]
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
       call      qword ptr [7FF9C5755C48]
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
       call      qword ptr [7FF9C50D3708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FF9C50D3720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FF9C5259B40]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,0D9BA946D7D0C
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
       call      qword ptr [7FF9C4F799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1D8C3402028
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
       mov       rdx,7FF9C4CE4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C4CE4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C4F5D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C50D5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       mov       rdx,1BC661C1C28
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,1BC361C1568
       mov       rbp,[rdx]
       mov       rdx,1BC661C1C30
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
       call      qword ptr [7FF9C788BC48]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FF9C75E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FF9C75E4000
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
       mov       rdx,7FF9C75E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FF9C75E4000
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
       mov       rdx,7FF9C75E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FF9C75E4000
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
       mov       rax,0BEC97418D7C9
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
       mov       rcx,0BEC97418D7C9
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
       mov       rcx,0BEC97418D7C9
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
       mov       rcx,0BEC97418D7C9
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
       mov       rax,1BC361C3020
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
       mov       rdx,7FF9C75E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C75E4000
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C515B150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,1B8AD400C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FF9C515B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,1B8A3400528
       mov       rbp,[rdx]
       mov       rdx,1B8AD400C80
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
       call      qword ptr [7FF9C50F3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9C515B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF9C515B258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FF9C513FE38]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9C4E39018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FF9C4D04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FF9C4D04000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C4F7D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C50F5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9C4D04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FF9C4D04000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C4F7D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C50F5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9C4D04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FF9C4D04000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C4F7D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C50F5750]
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
       call      qword ptr [7FF9C4F999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF9C515B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rax,0D93F67AC194
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
       call      qword ptr [7FF9C50F36F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       call      qword ptr [7FF9C50F3348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,0D93F67AC194
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
       call      qword ptr [7FF9C50F3408]
       mov       rcx,0D93F67AC194
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
       call      qword ptr [7FF9C50C96D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FF9C50C9288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FF9C5765C30]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FF9C5765C48]
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
       call      qword ptr [7FF9C5765C48]
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
       call      qword ptr [7FF9C50F3708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FF9C50F3720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FF9C5279B40]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,0D93F67AC194
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
       call      qword ptr [7FF9C4F999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1B8A3402028
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
       mov       rdx,7FF9C4D04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C4D04000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C4F7D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C50F5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       mov       rdx,25107791C28
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,250A7791568
       mov       rbp,[rdx]
       mov       rdx,25107791C30
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
       call      qword ptr [7FF9C786BC48]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FF9C75C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FF9C75C4000
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
       mov       rdx,7FF9C75C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FF9C75C4000
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
       mov       rdx,7FF9C75C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FF9C75C4000
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
       mov       rax,3CA03A72D5C4
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
       mov       rcx,3CA03A72D5C4
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
       mov       rcx,3CA03A72D5C4
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
       mov       rcx,3CA03A72D5C4
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
       mov       rax,250A7793020
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
       mov       rdx,7FF9C75C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C75C4000
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C07EB150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,19058800C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FF9C07EB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,19048800528
       mov       rbp,[rdx]
       mov       rdx,19058800C80
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
       call      qword ptr [7FF9C0783FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9C07EB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF9C07EB258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FF9C07CFE38]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9C04C9018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FF9C0394000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FF9C0394000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C060D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C0785750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9C0394000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FF9C0394000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C060D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C0785750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9C0394000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FF9C0394000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C060D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C0785750]
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
       call      qword ptr [7FF9C06299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF9C07EB9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rax,0BE2755A3F719
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
       call      qword ptr [7FF9C07836F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       call      qword ptr [7FF9C0783348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,0BE2755A3F719
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
       call      qword ptr [7FF9C0783408]
       mov       rcx,0BE2755A3F719
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
       call      qword ptr [7FF9C07596D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FF9C0759288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FF9C0E07810]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FF9C0E07828]
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
       call      qword ptr [7FF9C0E07828]
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
       call      qword ptr [7FF9C0783708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FF9C0783720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FF9C0909B40]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,0BE2755A3F719
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
       call      qword ptr [7FF9C06299F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,19048802028
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
       mov       rdx,7FF9C0394000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C0394000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C060D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C0785750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       mov       rdx,200EB1727B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,200EB161568
       mov       rbp,[rdx]
       mov       rdx,200EB1727C0
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
       call      qword ptr [7FF9C786BC48]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FF9C75C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FF9C75C4000
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
       mov       rdx,7FF9C75C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FF9C75C4000
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
       mov       rdx,7FF9C75C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FF9C75C4000
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
       mov       rax,8B5C5BF1EE38
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
       mov       rcx,8B5C5BF1EE38
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
       mov       rcx,8B5C5BF1EE38
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
       mov       rcx,8B5C5BF1EE38
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
       mov       rax,200EB163020
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
       mov       rdx,7FF9C75C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C75C4000
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C516B150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,150D4800C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FF9C516B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,150CA800528
       mov       rbp,[rdx]
       mov       rdx,150D4800C80
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
       call      qword ptr [7FF9C5103FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9C516B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF9C516B258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FF9C514FE38]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9C4E49018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FF9C4D14000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FF9C4D14000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C4F8D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C5105750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9C4D14000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FF9C4D14000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C4F8D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C5105750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9C4D14000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FF9C4D14000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C4F8D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C5105750]
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
       call      qword ptr [7FF9C4FA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF9C516B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rax,1F19D16DE17E
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
       call      qword ptr [7FF9C51036F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       call      qword ptr [7FF9C5103348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,1F19D16DE17E
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
       call      qword ptr [7FF9C5103408]
       mov       rcx,1F19D16DE17E
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
       call      qword ptr [7FF9C50D96D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FF9C50D9288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FF9C5787810]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FF9C5787828]
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
       call      qword ptr [7FF9C5787828]
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
       call      qword ptr [7FF9C5103708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FF9C5103720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FF9C5289B40]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,1F19D16DE17E
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
       call      qword ptr [7FF9C4FA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,150CA802028
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
       mov       rdx,7FF9C4D14000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C4D14000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C4F8D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C5105750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       mov       rdx,262864C1C28
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,262964C1568
       mov       rbp,[rdx]
       mov       rdx,262864C1C30
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
       call      qword ptr [7FF9C786BC48]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FF9C75C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FF9C75C4000
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
       mov       rdx,7FF9C75C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FF9C75C4000
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
       mov       rdx,7FF9C75C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FF9C75C4000
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
       mov       rax,0A9EC392E949F
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
       mov       rcx,0A9EC392E949F
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
       mov       rcx,0A9EC392E949F
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
       mov       rcx,0A9EC392E949F
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
       mov       rax,262964C3020
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
       mov       rdx,7FF9C75C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C75C4000
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C513B150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,2578D800C78
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FF9C513B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,2577B800528
       mov       rbp,[rdx]
       mov       rdx,2578D800C80
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
       call      qword ptr [7FF9C50D3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FF9C513B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FF9C513B258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FF9C511FE38]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9C4E19018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FF9C4CE4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FF9C4CE4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C4F5D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C50D5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9C4CE4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FF9C4CE4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C4F5D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C50D5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FF9C4CE4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FF9C4CE4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C4F5D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C50D5750]
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
       call      qword ptr [7FF9C4F799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF9C513B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rax,0E48E2D192A5A
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
       call      qword ptr [7FF9C50D36F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       call      qword ptr [7FF9C50D3348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,0E48E2D192A5A
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
       call      qword ptr [7FF9C50D3408]
       mov       rcx,0E48E2D192A5A
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
       call      qword ptr [7FF9C50A96D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FF9C50A9288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FF9C5757810]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FF9C5757828]
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
       call      qword ptr [7FF9C5757828]
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
       call      qword ptr [7FF9C50D3708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FF9C50D3720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FF9C5259B40]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,0E48E2D192A5A
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
       call      qword ptr [7FF9C4F799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2577B802028
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
       mov       rdx,7FF9C4CE4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C4CE4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C4F5D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C50D5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C786BC48]; System.Text.StringBuilder.ToString()
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
       mov       rax,2A9DF6F3020
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
       mov       rdx,7FF9C75C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C75C4000
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C07BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9C079FE38]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9C05F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF9C07BB9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF9C05F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,24678C02028
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
       mov       rdx,7FF9C0364000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C0364000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C05DD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C0755750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C786BC48]; System.Text.StringBuilder.ToString()
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
       mov       rax,2342D183020
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
       mov       rdx,7FF9C75C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C75C4000
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C07FB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9C07DFE38]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9C06399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF9C07FB9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF9C06399F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1A722802028
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
       mov       rdx,7FF9C03A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C03A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C061D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C0795750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C788BC48]; System.Text.StringBuilder.ToString()
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
       mov       rax,22BDA473020
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
       mov       rdx,7FF9C75E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C75E4000
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C515B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9C513FE38]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9C4F999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF9C515B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF9C4F999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,28B2EC02028
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
       mov       rdx,7FF9C4D04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C4D04000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C4F7D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C50F5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C787BC48]; System.Text.StringBuilder.ToString()
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
       mov       rax,1A42AFA3020
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
       mov       rdx,7FF9C75D4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C75D4000
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C514B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9C512FE38]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9C4F899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF9C514B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF9C4F899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,239B0002028
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
       mov       rdx,7FF9C4CF4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C4CF4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C4F6D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C50E5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C786BC48]; System.Text.StringBuilder.ToString()
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
       mov       rax,242B45D3020
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
       mov       rdx,7FF9C75C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C75C4000
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C515B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9C513FE38]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9C4F999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF9C515B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF9C4F999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2E148002028
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
       mov       rdx,7FF9C4D04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C4D04000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C4F7D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C50F5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C784BC48]; System.Text.StringBuilder.ToString()
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
       mov       rax,22BC2363020
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
       mov       rdx,7FF9C75A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C75A4000
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C517B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9C515FE38]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9C4FB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF9C517B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF9C4FB99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1D29A802028
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
       mov       rdx,7FF9C4D24000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C4D24000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C4F9D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C5115750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C786BC48]; System.Text.StringBuilder.ToString()
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
       mov       rax,2A2417A3020
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
       mov       rdx,7FF9C75C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C75C4000
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C516B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9C514FE38]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9C4FA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF9C516B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF9C4FA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,19CF5C02028
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
       mov       rdx,7FF9C4D14000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C4D14000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C4F8D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C5105750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C785BC48]; System.Text.StringBuilder.ToString()
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
       mov       rax,262C4FD3020
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
       mov       rdx,7FF9C75B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C75B4000
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C07BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9C079FE38]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9C05F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF9C07BB9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF9C05F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,15AE2C02028
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
       mov       rdx,7FF9C0364000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C0364000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C05DD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C0755750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C786BC48]; System.Text.StringBuilder.ToString()
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
       mov       rax,19A51DF3020
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
       mov       rdx,7FF9C75C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C75C4000
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C07DB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9C07BFE38]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9C06199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF9C07DB9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF9C06199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1D2C5C02028
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
       mov       rdx,7FF9C0384000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C0384000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C05FD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C0775750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C784BC48]; System.Text.StringBuilder.ToString()
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
       mov       rax,288222B3020
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
       mov       rdx,7FF9C75A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C75A4000
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C516B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9C514FE38]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9C4FA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF9C516B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF9C4FA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1EEA3802028
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
       mov       rdx,7FF9C4D14000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C4D14000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C4F8D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C5105750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C787BC48]; System.Text.StringBuilder.ToString()
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
       mov       rax,16BA00E3020
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
       mov       rdx,7FF9C75D4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C75D4000
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C516B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9C514FE38]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9C4FA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF9C516B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF9C4FA99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1BA84002028
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
       mov       rdx,7FF9C4D14000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C4D14000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C4F8D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C5105750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C786BC48]; System.Text.StringBuilder.ToString()
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
       mov       rax,2BABF463020
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
       mov       rdx,7FF9C75C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C75C4000
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C515B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9C513FE38]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9C4F999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF9C515B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF9C4F999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1C04C802028
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
       mov       rdx,7FF9C4D04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C4D04000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C4F7D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C50F5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C786BC48]; System.Text.StringBuilder.ToString()
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
       mov       rax,1E910C23020
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
       mov       rdx,7FF9C75C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C75C4000
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C515B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9C513FE38]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9C4F999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF9C515B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF9C4F999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1C16C402028
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
       mov       rdx,7FF9C4D04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C4D04000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C4F7D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C50F5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C787BC48]; System.Text.StringBuilder.ToString()
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
       mov       rax,1BD11B43020
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
       mov       rdx,7FF9C75D4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C75D4000
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C515B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FF9C513FE38]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF9C4F999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF9C515B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF9C4F999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,19509C02028
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
       mov       rdx,7FF9C4D04000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C4D04000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C4F7D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C50F5750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7886D08],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       cmp       qword ptr [rbp+10],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,19146E23020
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L08
M01_L02:
       mov       rcx,7FF9C7887358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,19126E24368
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,19116E21C28
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,19116E21C30
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       movsxd    rax,eax
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       jmp       short M01_L07
M01_L07:
       mov       rcx,rsp
       call      M01_L09
       nop
M01_L08:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L09:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9C7887358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,19126E24368
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 563
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FF9C5677000]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C56770D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C5179F50],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,1A230402028
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,7FF9C517A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1A230407808
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,1A242400C78
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C516B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,1A242400C80
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      qword ptr [7FF9C50D9990]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      qword ptr [7FF9C4E79288]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C516B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       cdqe
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF9C516B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L08
       nop
M01_L07:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9C517A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1A230407808
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 564
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7896D08],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       cmp       qword ptr [rbp+10],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,20E84D43020
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L08
M01_L02:
       mov       rcx,7FF9C7897358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,20E84D48770
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,20EE4D41C28
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,20EE4D41C30
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       movsxd    rax,eax
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       jmp       short M01_L07
M01_L07:
       mov       rcx,rsp
       call      M01_L09
       nop
M01_L08:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L09:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9C7897358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,20E84D48770
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 563
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FF9C5647000]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C56470D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C5149F50],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,21FDA002028
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,7FF9C514A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21FDA007808
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,21FE4000C78
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C513B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,21FE4000C80
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      qword ptr [7FF9C50A9990]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      qword ptr [7FF9C4E49288]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C513B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       cdqe
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF9C513B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L08
       nop
M01_L07:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9C514A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21FDA007808
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 564
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7886D08],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       cmp       qword ptr [rbp+10],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,22CD4BB3020
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L08
M01_L02:
       mov       rcx,7FF9C7887358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,22CB4BB4368
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,22CA4BB1C28
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,22CA4BB1C30
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       movsxd    rax,eax
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       jmp       short M01_L07
M01_L07:
       mov       rcx,rsp
       call      M01_L09
       nop
M01_L08:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L09:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9C7887358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,22CB4BB4368
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 563
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FF9C5647000]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C56470D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C5149F50],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,2684B002028
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,7FF9C514A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2684B007808
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,2685D000C78
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C513B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,2685D000C80
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      qword ptr [7FF9C50A9990]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      qword ptr [7FF9C4E49288]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C513B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       cdqe
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF9C513B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L08
       nop
M01_L07:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9C514A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2684B007808
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 564
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7896D08],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       cmp       qword ptr [rbp+10],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,27AB4C13020
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L08
M01_L02:
       mov       rcx,7FF9C7897358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,27AB4C18770
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,27B14C11C28
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,27B14C11C30
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       movsxd    rax,eax
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       jmp       short M01_L07
M01_L07:
       mov       rcx,rsp
       call      M01_L09
       nop
M01_L08:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L09:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9C7897358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,27AB4C18770
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 563
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FF9C5647300]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C56473D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C5149F50],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,1B8F2802028
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,7FF9C514A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1B8F2807808
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,1B8FA800C78
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C513B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,1B8FA800C80
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      qword ptr [7FF9C50A9990]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      qword ptr [7FF9C4E49288]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C513B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       cdqe
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF9C513B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L08
       nop
M01_L07:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9C514A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1B8F2807808
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 564
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7896D08],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       cmp       qword ptr [rbp+10],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,29092D93020
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L08
M01_L02:
       mov       rcx,7FF9C7897358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,29092D98770
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,290F2D91C28
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,290F2D91C30
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       movsxd    rax,eax
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       jmp       short M01_L07
M01_L07:
       mov       rcx,rsp
       call      M01_L09
       nop
M01_L08:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L09:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9C7897358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,29092D98770
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 563
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FF9C5677000]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C56770D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C5179F50],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,27FB3C02028
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,7FF9C517A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,27FB3C07808
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,27FC5C00C78
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C516B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,27FC5C00C80
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      qword ptr [7FF9C50D9990]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      qword ptr [7FF9C4E79288]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C516B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       cdqe
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF9C516B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L08
       nop
M01_L07:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9C517A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,27FB3C07808
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 564
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7896D08],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       cmp       qword ptr [rbp+10],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,2C172563020
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L08
M01_L02:
       mov       rcx,7FF9C7897358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2C172568770
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,2C162561C28
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,2C162561C30
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       movsxd    rax,eax
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       jmp       short M01_L07
M01_L07:
       mov       rcx,rsp
       call      M01_L09
       nop
M01_L08:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L09:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9C7897358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2C172568770
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 563
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FF9CE781000]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE7810D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9CE2B9F50],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,1F911402028
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,7FF9CE2BA710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1F911407808
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,1F911412820
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE2AD288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,1F911412828
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      qword ptr [7FF9CE21B990]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      qword ptr [7FF9CDFA9288]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE2AD288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       cdqe
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE2AD3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L08
       nop
M01_L07:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9CE2BA710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1F911407808
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 564
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C78A6D08],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       cmp       qword ptr [rbp+10],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,161DDDD3020
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L08
M01_L02:
       mov       rcx,7FF9C78A7358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,161DDDD8770
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,161DDDE37D0
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,161DDDE37D8
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       movsxd    rax,eax
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       jmp       short M01_L07
M01_L07:
       mov       rcx,rsp
       call      M01_L09
       nop
M01_L08:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L09:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9C78A7358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,161DDDD8770
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 563
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FF9CE827300]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE8273D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9CE329F50],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,26EE7002028
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,7FF9CE32A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,26EE7007808
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,26EE7011808
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE31B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,26EE7011810
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      qword ptr [7FF9CE289990]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      qword ptr [7FF9CE029288]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE31B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       cdqe
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE31B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L08
       nop
M01_L07:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9CE32A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,26EE7007808
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 564
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-70],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C7896D08],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,7FF9C7897358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,24988328770
       mov       rcx,[rcx]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       cmp       qword ptr [rbp+18],0
       jne       short M01_L02
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+18]
       cmp       dword ptr [rcx+8],0
       setne     cl
       movzx     ecx,cl
       mov       [rbp-3C],ecx
M01_L03:
       mov       ecx,[rbp-3C]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L09
       nop
       nop
       mov       rcx,[rbp+18]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L08
M01_L04:
       mov       rcx,[rbp-18]
       mov       edx,[rbp-1C]
       cmp       edx,[rcx+8]
       jb        short M01_L05
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp-28],rcx
       nop
       cmp       dword ptr [rbp+10],0FFFFFFFF
       je        short M01_L06
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.AppendLine(System.String)
       mov       [rbp-50],rax
       nop
M01_L07:
       nop
       mov       ecx,[rbp-1C]
       inc       ecx
       mov       [rbp-1C],ecx
M01_L08:
       mov       ecx,[rbp-1C]
       mov       rdx,[rbp-18]
       cmp       ecx,[rdx+8]
       jl        short M01_L04
       nop
M01_L09:
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-30],rcx
       nop
       jmp       short M01_L10
M01_L10:
       mov       rcx,rsp
       call      M01_L11
       nop
       mov       rax,[rbp-30]
       add       rsp,90
       pop       rbp
       ret
M01_L11:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       nop
       mov       rcx,7FF9C7897358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,24988328770
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 465
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FF9C5647318]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C56473D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-70],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5159F50],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,7FF9C515A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,19E07807808
       mov       rcx,[rcx]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       cmp       qword ptr [rbp+18],0
       jne       short M01_L02
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+18]
       cmp       dword ptr [rcx+8],0
       setne     cl
       movzx     ecx,cl
       mov       [rbp-3C],ecx
M01_L03:
       mov       ecx,[rbp-3C]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L09
       nop
       nop
       mov       rcx,[rbp+18]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L08
M01_L04:
       mov       rcx,[rbp-18]
       mov       edx,[rbp-1C]
       cmp       edx,[rcx+8]
       jb        short M01_L05
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp-28],rcx
       nop
       cmp       dword ptr [rbp+10],0FFFFFFFF
       je        short M01_L06
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C514B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C514B318]
       mov       [rbp-50],rax
       nop
M01_L07:
       nop
       mov       ecx,[rbp-1C]
       inc       ecx
       mov       [rbp-1C],ecx
M01_L08:
       mov       ecx,[rbp-1C]
       mov       rdx,[rbp-18]
       cmp       ecx,[rdx+8]
       jl        short M01_L04
       nop
M01_L09:
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-30],rcx
       nop
       mov       rcx,rsp
       call      M01_L10
       nop
       mov       rax,[rbp-30]
       add       rsp,90
       pop       rbp
       ret
M01_L10:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       nop
       mov       rcx,7FF9C515A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,19E07807808
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 465
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-70],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C7896D08],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,7FF9C7897358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1F51CA08770
       mov       rcx,[rcx]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       cmp       qword ptr [rbp+18],0
       jne       short M01_L02
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+18]
       cmp       dword ptr [rcx+8],0
       setne     cl
       movzx     ecx,cl
       mov       [rbp-3C],ecx
M01_L03:
       mov       ecx,[rbp-3C]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L09
       nop
       nop
       mov       rcx,[rbp+18]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L08
M01_L04:
       mov       rcx,[rbp-18]
       mov       edx,[rbp-1C]
       cmp       edx,[rcx+8]
       jb        short M01_L05
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp-28],rcx
       nop
       cmp       dword ptr [rbp+10],0FFFFFFFF
       je        short M01_L06
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.AppendLine(System.String)
       mov       [rbp-50],rax
       nop
M01_L07:
       nop
       mov       ecx,[rbp-1C]
       inc       ecx
       mov       [rbp-1C],ecx
M01_L08:
       mov       ecx,[rbp-1C]
       mov       rdx,[rbp-18]
       cmp       ecx,[rdx+8]
       jl        short M01_L04
       nop
M01_L09:
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-30],rcx
       nop
       jmp       short M01_L10
M01_L10:
       mov       rcx,rsp
       call      M01_L11
       nop
       mov       rax,[rbp-30]
       add       rsp,90
       pop       rbp
       ret
M01_L11:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       nop
       mov       rcx,7FF9C7897358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1F51CA08770
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 465
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FF9C5649318]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C56493D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-70],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5149F50],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,7FF9C514A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1DB84007808
       mov       rcx,[rcx]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       cmp       qword ptr [rbp+18],0
       jne       short M01_L02
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+18]
       cmp       dword ptr [rcx+8],0
       setne     cl
       movzx     ecx,cl
       mov       [rbp-3C],ecx
M01_L03:
       mov       ecx,[rbp-3C]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L09
       nop
       nop
       mov       rcx,[rbp+18]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L08
M01_L04:
       mov       rcx,[rbp-18]
       mov       edx,[rbp-1C]
       cmp       edx,[rcx+8]
       jb        short M01_L05
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp-28],rcx
       nop
       cmp       dword ptr [rbp+10],0FFFFFFFF
       je        short M01_L06
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C513B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C513B318]
       mov       [rbp-50],rax
       nop
M01_L07:
       nop
       mov       ecx,[rbp-1C]
       inc       ecx
       mov       [rbp-1C],ecx
M01_L08:
       mov       ecx,[rbp-1C]
       mov       rdx,[rbp-18]
       cmp       ecx,[rdx+8]
       jl        short M01_L04
       nop
M01_L09:
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-30],rcx
       nop
       mov       rcx,rsp
       call      M01_L10
       nop
       mov       rax,[rbp-30]
       add       rsp,90
       pop       rbp
       ret
M01_L10:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       nop
       mov       rcx,7FF9C514A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1DB84007808
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 465
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-70],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C7886D08],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,7FF9C7887358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,240B0298770
       mov       rcx,[rcx]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       cmp       qword ptr [rbp+18],0
       jne       short M01_L02
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+18]
       cmp       dword ptr [rcx+8],0
       setne     cl
       movzx     ecx,cl
       mov       [rbp-3C],ecx
M01_L03:
       mov       ecx,[rbp-3C]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L09
       nop
       nop
       mov       rcx,[rbp+18]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L08
M01_L04:
       mov       rcx,[rbp-18]
       mov       edx,[rbp-1C]
       cmp       edx,[rcx+8]
       jb        short M01_L05
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp-28],rcx
       nop
       cmp       dword ptr [rbp+10],0FFFFFFFF
       je        short M01_L06
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.AppendLine(System.String)
       mov       [rbp-50],rax
       nop
M01_L07:
       nop
       mov       ecx,[rbp-1C]
       inc       ecx
       mov       [rbp-1C],ecx
M01_L08:
       mov       ecx,[rbp-1C]
       mov       rdx,[rbp-18]
       cmp       ecx,[rdx+8]
       jl        short M01_L04
       nop
M01_L09:
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-30],rcx
       nop
       jmp       short M01_L10
M01_L10:
       mov       rcx,rsp
       call      M01_L11
       nop
       mov       rax,[rbp-30]
       add       rsp,90
       pop       rbp
       ret
M01_L11:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       nop
       mov       rcx,7FF9C7887358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,240B0298770
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 465
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FF9C5667318]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C56673D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-70],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5169F50],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,7FF9C516A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23388007808
       mov       rcx,[rcx]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       cmp       qword ptr [rbp+18],0
       jne       short M01_L02
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+18]
       cmp       dword ptr [rcx+8],0
       setne     cl
       movzx     ecx,cl
       mov       [rbp-3C],ecx
M01_L03:
       mov       ecx,[rbp-3C]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L09
       nop
       nop
       mov       rcx,[rbp+18]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L08
M01_L04:
       mov       rcx,[rbp-18]
       mov       edx,[rbp-1C]
       cmp       edx,[rcx+8]
       jb        short M01_L05
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp-28],rcx
       nop
       cmp       dword ptr [rbp+10],0FFFFFFFF
       je        short M01_L06
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C515B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C515B318]
       mov       [rbp-50],rax
       nop
M01_L07:
       nop
       mov       ecx,[rbp-1C]
       inc       ecx
       mov       [rbp-1C],ecx
M01_L08:
       mov       ecx,[rbp-1C]
       mov       rdx,[rbp-18]
       cmp       ecx,[rdx+8]
       jl        short M01_L04
       nop
M01_L09:
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-30],rcx
       nop
       mov       rcx,rsp
       call      M01_L10
       nop
       mov       rax,[rbp-30]
       add       rsp,90
       pop       rbp
       ret
M01_L10:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       nop
       mov       rcx,7FF9C516A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23388007808
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 465
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-70],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C7886D08],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,7FF9C7887358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,25894E18770
       mov       rcx,[rcx]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       cmp       qword ptr [rbp+18],0
       jne       short M01_L02
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+18]
       cmp       dword ptr [rcx+8],0
       setne     cl
       movzx     ecx,cl
       mov       [rbp-3C],ecx
M01_L03:
       mov       ecx,[rbp-3C]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L09
       nop
       nop
       mov       rcx,[rbp+18]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L08
M01_L04:
       mov       rcx,[rbp-18]
       mov       edx,[rbp-1C]
       cmp       edx,[rcx+8]
       jb        short M01_L05
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp-28],rcx
       nop
       cmp       dword ptr [rbp+10],0FFFFFFFF
       je        short M01_L06
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.AppendLine(System.String)
       mov       [rbp-50],rax
       nop
M01_L07:
       nop
       mov       ecx,[rbp-1C]
       inc       ecx
       mov       [rbp-1C],ecx
M01_L08:
       mov       ecx,[rbp-1C]
       mov       rdx,[rbp-18]
       cmp       ecx,[rdx+8]
       jl        short M01_L04
       nop
M01_L09:
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-30],rcx
       nop
       jmp       short M01_L10
M01_L10:
       mov       rcx,rsp
       call      M01_L11
       nop
       mov       rax,[rbp-30]
       add       rsp,90
       pop       rbp
       ret
M01_L11:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       nop
       mov       rcx,7FF9C7887358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,25894E18770
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 465
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FF9C5657318]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C56573D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-70],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5159F50],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,7FF9C515A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1A2FD807808
       mov       rcx,[rcx]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       cmp       qword ptr [rbp+18],0
       jne       short M01_L02
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+18]
       cmp       dword ptr [rcx+8],0
       setne     cl
       movzx     ecx,cl
       mov       [rbp-3C],ecx
M01_L03:
       mov       ecx,[rbp-3C]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L09
       nop
       nop
       mov       rcx,[rbp+18]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L08
M01_L04:
       mov       rcx,[rbp-18]
       mov       edx,[rbp-1C]
       cmp       edx,[rcx+8]
       jb        short M01_L05
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp-28],rcx
       nop
       cmp       dword ptr [rbp+10],0FFFFFFFF
       je        short M01_L06
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C514B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C514B318]
       mov       [rbp-50],rax
       nop
M01_L07:
       nop
       mov       ecx,[rbp-1C]
       inc       ecx
       mov       [rbp-1C],ecx
M01_L08:
       mov       ecx,[rbp-1C]
       mov       rdx,[rbp-18]
       cmp       ecx,[rdx+8]
       jl        short M01_L04
       nop
M01_L09:
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-30],rcx
       nop
       mov       rcx,rsp
       call      M01_L10
       nop
       mov       rax,[rbp-30]
       add       rsp,90
       pop       rbp
       ret
M01_L10:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       nop
       mov       rcx,7FF9C515A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1A2FD807808
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 465
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-70],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C7876D08],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,7FF9C7877358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,209A6158770
       mov       rcx,[rcx]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       cmp       qword ptr [rbp+18],0
       jne       short M01_L02
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+18]
       cmp       dword ptr [rcx+8],0
       setne     cl
       movzx     ecx,cl
       mov       [rbp-3C],ecx
M01_L03:
       mov       ecx,[rbp-3C]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L09
       nop
       nop
       mov       rcx,[rbp+18]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L08
M01_L04:
       mov       rcx,[rbp-18]
       mov       edx,[rbp-1C]
       cmp       edx,[rcx+8]
       jb        short M01_L05
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp-28],rcx
       nop
       cmp       dword ptr [rbp+10],0FFFFFFFF
       je        short M01_L06
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.AppendLine(System.String)
       mov       [rbp-50],rax
       nop
M01_L07:
       nop
       mov       ecx,[rbp-1C]
       inc       ecx
       mov       [rbp-1C],ecx
M01_L08:
       mov       ecx,[rbp-1C]
       mov       rdx,[rbp-18]
       cmp       ecx,[rdx+8]
       jl        short M01_L04
       nop
M01_L09:
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-30],rcx
       nop
       jmp       short M01_L10
M01_L10:
       mov       rcx,rsp
       call      M01_L11
       nop
       mov       rax,[rbp-30]
       add       rsp,90
       pop       rbp
       ret
M01_L11:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       nop
       mov       rcx,7FF9C7877358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,209A6158770
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 465
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FF9C5667018]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C56670D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-70],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5169F50],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,7FF9C516A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,230D0007808
       mov       rcx,[rcx]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       cmp       qword ptr [rbp+18],0
       jne       short M01_L02
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+18]
       cmp       dword ptr [rcx+8],0
       setne     cl
       movzx     ecx,cl
       mov       [rbp-3C],ecx
M01_L03:
       mov       ecx,[rbp-3C]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L09
       nop
       nop
       mov       rcx,[rbp+18]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L08
M01_L04:
       mov       rcx,[rbp-18]
       mov       edx,[rbp-1C]
       cmp       edx,[rcx+8]
       jb        short M01_L05
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp-28],rcx
       nop
       cmp       dword ptr [rbp+10],0FFFFFFFF
       je        short M01_L06
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C515B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C515B318]
       mov       [rbp-50],rax
       nop
M01_L07:
       nop
       mov       ecx,[rbp-1C]
       inc       ecx
       mov       [rbp-1C],ecx
M01_L08:
       mov       ecx,[rbp-1C]
       mov       rdx,[rbp-18]
       cmp       ecx,[rdx+8]
       jl        short M01_L04
       nop
M01_L09:
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-30],rcx
       nop
       mov       rcx,rsp
       call      M01_L10
       nop
       mov       rax,[rbp-30]
       add       rsp,90
       pop       rbp
       ret
M01_L10:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       nop
       mov       rcx,7FF9C516A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,230D0007808
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 465
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-70],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C7876D08],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,7FF9C7877358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,164A3FA6778
       mov       rcx,[rcx]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       cmp       qword ptr [rbp+18],0
       jne       short M01_L02
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+18]
       cmp       dword ptr [rcx+8],0
       setne     cl
       movzx     ecx,cl
       mov       [rbp-3C],ecx
M01_L03:
       mov       ecx,[rbp-3C]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L09
       nop
       nop
       mov       rcx,[rbp+18]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L08
M01_L04:
       mov       rcx,[rbp-18]
       mov       edx,[rbp-1C]
       cmp       edx,[rcx+8]
       jb        short M01_L05
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp-28],rcx
       nop
       cmp       dword ptr [rbp+10],0FFFFFFFF
       je        short M01_L06
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.AppendLine(System.String)
       mov       [rbp-50],rax
       nop
M01_L07:
       nop
       mov       ecx,[rbp-1C]
       inc       ecx
       mov       [rbp-1C],ecx
M01_L08:
       mov       ecx,[rbp-1C]
       mov       rdx,[rbp-18]
       cmp       ecx,[rdx+8]
       jl        short M01_L04
       nop
M01_L09:
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-30],rcx
       nop
       jmp       short M01_L10
M01_L10:
       mov       rcx,rsp
       call      M01_L11
       nop
       mov       rax,[rbp-30]
       add       rsp,90
       pop       rbp
       ret
M01_L11:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       nop
       mov       rcx,7FF9C7877358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,164A3FA6778
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 465
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FF9CE817018]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE8170D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-70],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9CE319F50],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,7FF9CE31A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2230D8053F8
       mov       rcx,[rcx]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       cmp       qword ptr [rbp+18],0
       jne       short M01_L02
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+18]
       cmp       dword ptr [rcx+8],0
       setne     cl
       movzx     ecx,cl
       mov       [rbp-3C],ecx
M01_L03:
       mov       ecx,[rbp-3C]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L09
       nop
       nop
       mov       rcx,[rbp+18]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L08
M01_L04:
       mov       rcx,[rbp-18]
       mov       edx,[rbp-1C]
       cmp       edx,[rcx+8]
       jb        short M01_L05
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp-28],rcx
       nop
       cmp       dword ptr [rbp+10],0FFFFFFFF
       je        short M01_L06
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE30B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE30B318]
       mov       [rbp-50],rax
       nop
M01_L07:
       nop
       mov       ecx,[rbp-1C]
       inc       ecx
       mov       [rbp-1C],ecx
M01_L08:
       mov       ecx,[rbp-1C]
       mov       rdx,[rbp-18]
       cmp       ecx,[rdx+8]
       jl        short M01_L04
       nop
M01_L09:
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-30],rcx
       nop
       mov       rcx,rsp
       call      M01_L10
       nop
       mov       rax,[rbp-30]
       add       rsp,90
       pop       rbp
       ret
M01_L10:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       nop
       mov       rcx,7FF9CE31A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2230D8053F8
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 465
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-70],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C7886D08],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,7FF9C7887358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,149DDE68770
       mov       rcx,[rcx]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       cmp       qword ptr [rbp+18],0
       jne       short M01_L02
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+18]
       cmp       dword ptr [rcx+8],0
       setne     cl
       movzx     ecx,cl
       mov       [rbp-3C],ecx
M01_L03:
       mov       ecx,[rbp-3C]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L09
       nop
       nop
       mov       rcx,[rbp+18]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L08
M01_L04:
       mov       rcx,[rbp-18]
       mov       edx,[rbp-1C]
       cmp       edx,[rcx+8]
       jb        short M01_L05
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp-28],rcx
       nop
       cmp       dword ptr [rbp+10],0FFFFFFFF
       je        short M01_L06
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.AppendLine(System.String)
       mov       [rbp-50],rax
       nop
M01_L07:
       nop
       mov       ecx,[rbp-1C]
       inc       ecx
       mov       [rbp-1C],ecx
M01_L08:
       mov       ecx,[rbp-1C]
       mov       rdx,[rbp-18]
       cmp       ecx,[rdx+8]
       jl        short M01_L04
       nop
M01_L09:
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-30],rcx
       nop
       jmp       short M01_L10
M01_L10:
       mov       rcx,rsp
       call      M01_L11
       nop
       mov       rax,[rbp-30]
       add       rsp,90
       pop       rbp
       ret
M01_L11:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       nop
       mov       rcx,7FF9C7887358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,149DDE68770
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 465
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FF9CE827018]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE8270D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-70],rsp
       mov       [rbp+10],ecx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9CE329F50],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,7FF9CE32A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,205A5007808
       mov       rcx,[rcx]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       cmp       qword ptr [rbp+18],0
       jne       short M01_L02
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+18]
       cmp       dword ptr [rcx+8],0
       setne     cl
       movzx     ecx,cl
       mov       [rbp-3C],ecx
M01_L03:
       mov       ecx,[rbp-3C]
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L09
       nop
       nop
       mov       rcx,[rbp+18]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L08
M01_L04:
       mov       rcx,[rbp-18]
       mov       edx,[rbp-1C]
       cmp       edx,[rcx+8]
       jb        short M01_L05
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp-28],rcx
       nop
       cmp       dword ptr [rbp+10],0FFFFFFFF
       je        short M01_L06
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE31B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE31B318]
       mov       [rbp-50],rax
       nop
M01_L07:
       nop
       mov       ecx,[rbp-1C]
       inc       ecx
       mov       [rbp-1C],ecx
M01_L08:
       mov       ecx,[rbp-1C]
       mov       rdx,[rbp-18]
       cmp       ecx,[rdx+8]
       jl        short M01_L04
       nop
M01_L09:
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-30],rcx
       nop
       mov       rcx,rsp
       call      M01_L10
       nop
       mov       rax,[rbp-30]
       add       rsp,90
       pop       rbp
       ret
M01_L10:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+90]
       nop
       mov       rcx,7FF9CE32A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,205A5007808
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-68]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 465
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-50],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7886D08],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+10],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       mov       rcx,1D1ECAE3020
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M02_L03
M02_L01:
       mov       rcx,7FF9C7887358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1D1ECAE8770
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-40]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-40]
       call      qword ptr [rax+18]
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-18],rcx
       nop
       jmp       short M02_L02
M02_L02:
       mov       rcx,rsp
       call      M02_L04
       nop
M02_L03:
       mov       rax,[rbp-18]
       add       rsp,70
       pop       rbp
       ret
M02_L04:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       nop
       mov       rcx,7FF9C7887358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1D1ECAE8770
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-38]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 336
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C5677060]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C56770D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9C4ECB630]
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
       call      qword ptr [7FF9C516B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C5179F50],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       mov       rcx,24B17802028
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M02_L02
M02_L01:
       mov       rcx,7FF9C517A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,24B17807808
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp-8]
       mov       rax,[rbp+10]
       call      qword ptr [rax+18]
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M02_L03
       nop
M02_L02:
       mov       rax,[rbp-18]
       add       rsp,60
       pop       rbp
       ret
M02_L03:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       nop
       mov       rcx,7FF9C517A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,24B17807808
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-38]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 326
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-50],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C78A6D08],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+10],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       mov       rcx,1B58F783020
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M02_L03
M02_L01:
       mov       rcx,7FF9C78A7358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1B58F788770
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-40]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-40]
       call      qword ptr [rax+18]
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-18],rcx
       nop
       jmp       short M02_L02
M02_L02:
       mov       rcx,rsp
       call      M02_L04
       nop
M02_L03:
       mov       rax,[rbp-18]
       add       rsp,70
       pop       rbp
       ret
M02_L04:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       nop
       mov       rcx,7FF9C78A7358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1B58F788770
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-38]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 336
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C5667360]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C56673D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9C4ECB630]
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
       call      qword ptr [7FF9C516B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C5179F50],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       mov       rcx,23DFB002028
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M02_L02
M02_L01:
       mov       rcx,7FF9C517A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23DFB007808
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp-8]
       mov       rax,[rbp+10]
       call      qword ptr [rax+18]
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M02_L03
       nop
M02_L02:
       mov       rax,[rbp-18]
       add       rsp,60
       pop       rbp
       ret
M02_L03:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       nop
       mov       rcx,7FF9C517A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23DFB007808
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-38]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 326
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-50],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7876D08],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+10],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       mov       rcx,1FE1EC33020
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M02_L03
M02_L01:
       mov       rcx,7FF9C7877358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FE1EC38770
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-40]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-40]
       call      qword ptr [rax+18]
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-18],rcx
       nop
       jmp       short M02_L02
M02_L02:
       mov       rcx,rsp
       call      M02_L04
       nop
M02_L03:
       mov       rax,[rbp-18]
       add       rsp,70
       pop       rbp
       ret
M02_L04:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       nop
       mov       rcx,7FF9C7877358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FE1EC38770
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-38]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 336
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C5647360]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C56473D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9C4E9B630]
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
       call      qword ptr [7FF9C513B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C5149F50],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       mov       rcx,26503C02028
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M02_L02
M02_L01:
       mov       rcx,7FF9C514A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,26503C07808
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp-8]
       mov       rax,[rbp+10]
       call      qword ptr [rax+18]
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M02_L03
       nop
M02_L02:
       mov       rax,[rbp-18]
       add       rsp,60
       pop       rbp
       ret
M02_L03:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       nop
       mov       rcx,7FF9C514A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,26503C07808
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-38]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 326
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-50],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C78A6D08],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+10],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       mov       rcx,16056393020
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M02_L03
M02_L01:
       mov       rcx,7FF9C78A7358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,16056398770
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-40]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-40]
       call      qword ptr [rax+18]
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-18],rcx
       nop
       jmp       short M02_L02
M02_L02:
       mov       rcx,rsp
       call      M02_L04
       nop
M02_L03:
       mov       rax,[rbp-18]
       add       rsp,70
       pop       rbp
       ret
M02_L04:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       nop
       mov       rcx,7FF9C78A7358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,16056398770
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-38]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 336
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C5657360]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C56573D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9C4EAB630]
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
       call      qword ptr [7FF9C514B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C5159F50],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       mov       rcx,203AB802028
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M02_L02
M02_L01:
       mov       rcx,7FF9C515A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,203AB807808
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp-8]
       mov       rax,[rbp+10]
       call      qword ptr [rax+18]
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M02_L03
       nop
M02_L02:
       mov       rax,[rbp-18]
       add       rsp,60
       pop       rbp
       ret
M02_L03:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       nop
       mov       rcx,7FF9C515A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,203AB807808
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-38]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 326
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-50],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7896D08],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+10],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       mov       rcx,1FBA7703020
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M02_L03
M02_L01:
       mov       rcx,7FF9C7897358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FBA7708770
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-40]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-40]
       call      qword ptr [rax+18]
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-18],rcx
       nop
       jmp       short M02_L02
M02_L02:
       mov       rcx,rsp
       call      M02_L04
       nop
M02_L03:
       mov       rax,[rbp-18]
       add       rsp,70
       pop       rbp
       ret
M02_L04:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       nop
       mov       rcx,7FF9C7897358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FBA7708770
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-38]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 336
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9C5657360]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C56573D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9C4EBB630]
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
       call      qword ptr [7FF9C515B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C5169F50],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       mov       rcx,1DC6C802028
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M02_L02
M02_L01:
       mov       rcx,7FF9C516A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1DC6C807808
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp-8]
       mov       rax,[rbp+10]
       call      qword ptr [rax+18]
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M02_L03
       nop
M02_L02:
       mov       rax,[rbp-18]
       add       rsp,60
       pop       rbp
       ret
M02_L03:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       nop
       mov       rcx,7FF9C516A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1DC6C807808
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-38]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 326
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-50],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7876D08],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+10],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       mov       rcx,20F665F3020
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M02_L03
M02_L01:
       mov       rcx,7FF9C7877358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,20F665F8770
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-40]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-40]
       call      qword ptr [rax+18]
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-18],rcx
       nop
       jmp       short M02_L02
M02_L02:
       mov       rcx,rsp
       call      M02_L04
       nop
M02_L03:
       mov       rax,[rbp-18]
       add       rsp,70
       pop       rbp
       ret
M02_L04:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       nop
       mov       rcx,7FF9C7877358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,20F665F8770
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-38]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 336
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CE837360]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE8373D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9CE09B630]
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
       call      qword ptr [7FF9CE33B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9CE349F50],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       mov       rcx,268BC002028
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M02_L02
M02_L01:
       mov       rcx,7FF9CE34A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,268BC007808
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp-8]
       mov       rax,[rbp+10]
       call      qword ptr [rax+18]
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M02_L03
       nop
M02_L02:
       mov       rax,[rbp-18]
       add       rsp,60
       pop       rbp
       ret
M02_L03:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       nop
       mov       rcx,7FF9CE34A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,268BC007808
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-38]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 326
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-50],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7876D08],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+10],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       mov       rcx,14EAA193020
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M02_L03
M02_L01:
       mov       rcx,7FF9C7877358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,14EAA198770
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-40]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-40]
       call      qword ptr [rax+18]
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-18],rcx
       nop
       jmp       short M02_L02
M02_L02:
       mov       rcx,rsp
       call      M02_L04
       nop
M02_L03:
       mov       rax,[rbp-18]
       add       rsp,70
       pop       rbp
       ret
M02_L04:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       nop
       mov       rcx,7FF9C7877358
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,14EAA198770
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-38]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 336
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CEA67060]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEA670D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9CE2BB630]
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
       call      qword ptr [7FF9CE55B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9CE569F50],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M02_L01
       nop
       mov       rcx,23064C02028
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M02_L02
M02_L01:
       mov       rcx,7FF9CE56A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23064C07808
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp-8]
       mov       rax,[rbp+10]
       call      qword ptr [rax+18]
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M02_L03
       nop
M02_L02:
       mov       rax,[rbp-18]
       add       rsp,60
       pop       rbp
       ret
M02_L03:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       nop
       mov       rcx,7FF9CE56A710
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23064C07808
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-38]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 326
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

