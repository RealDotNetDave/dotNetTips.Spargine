## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rdx,2A197881C00
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,2A117881568
       mov       rbp,[rdx]
       mov       rdx,2A197881C08
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
       call      qword ptr [7FFA9895B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FFA986A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FFA986A4000
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
       mov       rdx,7FFA986A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FFA986A4000
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
       mov       rdx,7FFA986A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FFA986A4000
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
       mov       rax,0DC63B1318F2F
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
       mov       rcx,0DC63B1318F2F
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
       mov       rcx,0DC63B1318F2F
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
       mov       rcx,0DC63B1318F2F
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
       mov       rax,2A117883020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFA986A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFA986A4000
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA973CD150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,18884C00C50
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FFA973CD9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,18874C00528
       mov       rbp,[rdx]
       mov       rdx,18884C00C58
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
       call      qword ptr [7FFA97365FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FFA973CD9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFA973CD258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FFA973AFE58]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFA97099018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFA96F64000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FFA96F64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971DD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97367750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFA96F64000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FFA96F64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971DD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97367750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFA96F64000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FFA96F64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971DD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97367750]
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
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA973CD9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rax,0A3E68F3BE377
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
       call      qword ptr [7FFA973656F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       call      qword ptr [7FFA97365348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,0A3E68F3BE377
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
       call      qword ptr [7FFA97365408]
       mov       rcx,0A3E68F3BE377
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
       call      qword ptr [7FFA9733B6D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FFA9733B288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FFA979B57F8]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FFA979B5810]
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
       call      qword ptr [7FFA979B5810]
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
       call      qword ptr [7FFA97365708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FFA97365720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFA974E7120]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,0A3E68F3BE377
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
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,18874C02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFA96F64000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFA96F64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971DD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97367750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rdx,158959F2790
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,158959E1568
       mov       rbp,[rdx]
       mov       rdx,158959F2798
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
       call      qword ptr [7FFA9895B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FFA986B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FFA986B4000
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
       mov       rdx,7FFA986B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FFA986B4000
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
       mov       rdx,7FFA986B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FFA986B4000
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
       mov       rax,7F89C3C1243D
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
       mov       rcx,7F89C3C1243D
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
       mov       rcx,7F89C3C1243D
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
       mov       rcx,7F89C3C1243D
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
       mov       rax,158959E3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFA986B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFA986B4000
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA973CB150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,1DF70C00C50
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FFA973CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,1DF66C00528
       mov       rbp,[rdx]
       mov       rdx,1DF70C00C58
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
       call      qword ptr [7FFA97363FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FFA973CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFA973CB258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FFA973AFE58]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFA970A9018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFA96F74000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FFA96F74000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971ED030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97365750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFA96F74000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FFA96F74000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971ED030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97365750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFA96F74000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FFA96F74000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971ED030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97365750]
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
       call      qword ptr [7FFA972099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA973CB9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rax,0D8E5C6D39A49
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
       call      qword ptr [7FFA973636F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       call      qword ptr [7FFA97363348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,0D8E5C6D39A49
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
       call      qword ptr [7FFA97363408]
       mov       rcx,0D8E5C6D39A49
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
       call      qword ptr [7FFA973396D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FFA97339288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FFA979C7900]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FFA979C7918]
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
       call      qword ptr [7FFA979C7918]
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
       call      qword ptr [7FFA97363708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FFA97363720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFA974E5120]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,0D8E5C6D39A49
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
       call      qword ptr [7FFA972099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1DF66C02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFA96F74000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFA96F74000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971ED030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97365750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rdx,2203316B3C8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,22053161568
       mov       rbp,[rdx]
       mov       rdx,2203316B3D0
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
       call      qword ptr [7FFA9894B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FFA986A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FFA986A4000
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
       mov       rdx,7FFA986A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FFA986A4000
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
       mov       rdx,7FFA986A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FFA986A4000
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
       mov       rax,86ED74148BE2
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
       mov       rcx,86ED74148BE2
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
       mov       rcx,86ED74148BE2
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
       mov       rcx,86ED74148BE2
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
       mov       rax,22053163020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFA986A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFA986A4000
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA973DB150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,2561680E820
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FFA973DB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,25616800528
       mov       rbp,[rdx]
       mov       rdx,2561680E828
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
       call      qword ptr [7FFA97373FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FFA973DB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFA973DB258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FFA973BFE58]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFA970B9018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFA96F84000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FFA96F84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971FD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97375750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFA96F84000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FFA96F84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971FD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97375750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFA96F84000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FFA96F84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971FD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97375750]
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
       call      qword ptr [7FFA972199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA973DB9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rax,1E5B8C84826A
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
       call      qword ptr [7FFA973736F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       call      qword ptr [7FFA97373348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,1E5B8C84826A
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
       call      qword ptr [7FFA97373408]
       mov       rcx,1E5B8C84826A
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
       call      qword ptr [7FFA973496D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FFA97349288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FFA979E5C18]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FFA979E5C30]
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
       call      qword ptr [7FFA979E5C30]
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
       call      qword ptr [7FFA97373708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FFA97373720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFA974F5120]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,1E5B8C84826A
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
       call      qword ptr [7FFA972199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,25616802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFA96F84000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFA96F84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971FD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97375750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rdx,23891331C00
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,23831331568
       mov       rbp,[rdx]
       mov       rdx,23891331C08
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
       call      qword ptr [7FFA9893B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FFA98694000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FFA98694000
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
       mov       rdx,7FFA98694000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FFA98694000
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
       mov       rdx,7FFA98694000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FFA98694000
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
       mov       rax,5112791A9D67
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
       mov       rcx,5112791A9D67
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
       mov       rcx,5112791A9D67
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
       mov       rcx,5112791A9D67
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
       mov       rax,23831333020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFA98694000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFA98694000
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA973BB150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,25A7A400C50
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FFA973BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,25A6E400528
       mov       rbp,[rdx]
       mov       rdx,25A7A400C58
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
       call      qword ptr [7FFA97353FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FFA973BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFA973BB258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FFA9739FE58]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFA97099018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFA96F64000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FFA96F64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971DD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97355750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFA96F64000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FFA96F64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971DD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97355750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFA96F64000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FFA96F64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971DD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97355750]
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
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA973BB9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rax,0FADB9739B43F
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
       call      qword ptr [7FFA973536F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       call      qword ptr [7FFA97353348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,0FADB9739B43F
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
       call      qword ptr [7FFA97353408]
       mov       rcx,0FADB9739B43F
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
       call      qword ptr [7FFA973296D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FFA97329288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FFA979C77F8]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FFA979C7810]
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
       call      qword ptr [7FFA979C7810]
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
       call      qword ptr [7FFA97353708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FFA97353720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFA974D5120]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,0FADB9739B43F
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
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,25A6E402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFA96F64000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFA96F64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971DD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97355750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rdx,20EE4142C18
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,20F24141568
       mov       rbp,[rdx]
       mov       rdx,20EE4142C20
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
       call      qword ptr [7FFA9894B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FFA986A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FFA986A4000
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
       mov       rdx,7FFA986A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FFA986A4000
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
       mov       rdx,7FFA986A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FFA986A4000
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
       mov       rax,9C42EDB02D45
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
       mov       rcx,9C42EDB02D45
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
       mov       rcx,9C42EDB02D45
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
       mov       rcx,9C42EDB02D45
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
       mov       rax,20F24143020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFA986A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFA986A4000
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA973DB150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,1118880D3D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FFA973DB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,1118C800528
       mov       rbp,[rdx]
       mov       rdx,1118880D3E0
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
       call      qword ptr [7FFA97373FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FFA973DB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFA973DB258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FFA973BFE58]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFA970B9018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFA96F84000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FFA96F84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971FD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97375750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFA96F84000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FFA96F84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971FD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97375750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFA96F84000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FFA96F84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971FD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97375750]
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
       call      qword ptr [7FFA972199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA973DB9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rax,0AA8CF6E43148
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
       call      qword ptr [7FFA973736F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       call      qword ptr [7FFA97373348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,0AA8CF6E43148
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
       call      qword ptr [7FFA97373408]
       mov       rcx,0AA8CF6E43148
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
       call      qword ptr [7FFA973496D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FFA97349288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FFA979E57F8]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FFA979E5810]
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
       call      qword ptr [7FFA979E5810]
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
       call      qword ptr [7FFA97373708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FFA97373720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFA974F5120]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,0AA8CF6E43148
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
       call      qword ptr [7FFA972199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1118C802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFA96F84000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFA96F84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971FD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97375750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rdx,218650637A8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,21865051568
       mov       rbp,[rdx]
       mov       rdx,218650637B0
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
       call      qword ptr [7FFA9896B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FFA986C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FFA986C4000
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
       mov       rdx,7FFA986C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FFA986C4000
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
       mov       rdx,7FFA986C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FFA986C4000
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
       mov       rax,0EACF1FBAAFDC
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
       mov       rcx,0EACF1FBAAFDC
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
       mov       rcx,0EACF1FBAAFDC
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
       mov       rcx,0EACF1FBAAFDC
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
       mov       rax,21865053020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFA986C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFA986C4000
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA9739B150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,159530117E0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FFA9739B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,15953000528
       mov       rbp,[rdx]
       mov       rdx,159530117E8
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
       call      qword ptr [7FFA97333FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FFA9739B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFA9739B258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FFA9737FE58]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFA97079018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFA96F44000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FFA96F44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971BD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97335750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFA96F44000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FFA96F44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971BD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97335750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFA96F44000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FFA96F44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971BD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97335750]
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
       call      qword ptr [7FFA971D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA9739B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rax,0A38C1265406
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
       call      qword ptr [7FFA973336F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       call      qword ptr [7FFA97333348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,0A38C1265406
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
       call      qword ptr [7FFA97333408]
       mov       rcx,0A38C1265406
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
       call      qword ptr [7FFA973096D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FFA97309288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FFA979A7018]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FFA979A7030]
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
       call      qword ptr [7FFA979A7030]
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
       call      qword ptr [7FFA97333708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FFA97333720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFA974B5120]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,0A38C1265406
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
       call      qword ptr [7FFA971D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,15953002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFA96F44000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFA96F44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971BD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97335750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rdx,1B44D40F3A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       mov       ecx,[rcx+8]
       movsxd    rcx,ecx
       test      rcx,rcx
       jle       short M00_L02
       mov       rdx,1B46D401568
       mov       rbp,[rdx]
       mov       rdx,1B44D40F3A8
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
       call      qword ptr [7FFA9894B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FFA986A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A4B1
       mov       rdx,7FFA986A4000
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
       mov       rdx,7FFA986A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,987B
       mov       rdx,7FFA986A4000
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
       mov       rdx,7FFA986A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A7ED
       mov       rdx,7FFA986A4000
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
       mov       rax,868A688BCC06
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
       mov       rcx,868A688BCC06
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
       mov       rcx,868A688BCC06
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
       mov       rcx,868A688BCC06
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
       mov       rax,1B46D403020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FFA986A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFA986A4000
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA973AB150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,1EC0A008BE8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FFA973AB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       rcx,[rsi+288]
       cmp       dword ptr [rcx+8],0
       je        short M00_L03
       mov       rdx,1EC0E000528
       mov       rbp,[rdx]
       mov       rdx,1EC0A008BF0
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
       call      qword ptr [7FFA97343FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7FFA973AB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFA973AB258]
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FFA9738FE58]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFA97089018]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFA96F54000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A145
       mov       rdx,7FFA96F54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971CD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97345750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFA96F54000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,94A7
       mov       rdx,7FFA96F54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971CD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97345750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,303
       mov       rdx,7FFA96F54000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A481
       mov       rdx,7FFA96F54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971CD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97345750]
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
       call      qword ptr [7FFA971E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA973AB9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rax,0AEE5C3A17D3E
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
       call      qword ptr [7FFA973436F0]; System.Number.ParseFormatSpecifier(System.ReadOnlySpan`1<Char>, Int32 ByRef)
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
       call      qword ptr [7FFA97343348]; System.Number.Int32ToHexStr(Int32, Char, Int32)
       mov       rcx,0AEE5C3A17D3E
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
       call      qword ptr [7FFA97343408]
       mov       rcx,0AEE5C3A17D3E
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
       call      qword ptr [7FFA973196D8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|44_0(System.IFormatProvider)
       mov       rdi,rax
       jmp       short M03_L09
M03_L08:
       call      qword ptr [7FFA97319288]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       rdi,rax
M03_L09:
       lea       r8,[rbp+70]
       mov       [rbp+8],r8
       mov       dword ptr [rbp+10],0B
       lea       r8,[rbp+8]
       lea       rcx,[rbp+48]
       mov       edx,1
       call      qword ptr [7FFA979B57F8]
       mov       dword ptr [rbp+48],0A
       mov       byte ptr [rbp+50],0
       lea       rcx,[rbp+48]
       call      qword ptr [7FFA979B5810]
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
       call      qword ptr [7FFA979B5810]
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
       call      qword ptr [7FFA97343708]; System.Number.NumberToString(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, Char, Int32, System.Globalization.NumberFormatInfo)
       jmp       short M03_L15
M03_L14:
       mov       [rbp+18],rbx
       mov       [rbp+20],r14d
       lea       r8,[rbp+18]
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+28]
       mov       r9,rdi
       call      qword ptr [7FFA97343720]; System.Number.NumberToStringFormat(System.Text.ValueStringBuilder ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M03_L15:
       lea       rcx,[rbp+28]
       call      qword ptr [7FFA974C5120]; System.Text.ValueStringBuilder.ToString()
       mov       rcx,0AEE5C3A17D3E
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
       call      qword ptr [7FFA971E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1EC0E002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,178FF
       mov       rdx,7FFA96F54000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFA96F54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971CD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97345750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA9893B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,1E3B98A3020
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
       mov       rdx,7FFA98694000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFA98694000
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA973BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFA9739FE58]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA973BB9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2297DC02028
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
       mov       rdx,7FFA96F64000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFA96F64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971DD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97355750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA9894B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,28E25313020
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
       mov       rdx,7FFA986A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFA986A4000
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA973BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFA9739FE58]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA973BB9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1CC0D002028
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
       mov       rdx,7FFA96F64000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFA96F64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971DD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97355750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA9893B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,23E016C3020
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
       mov       rdx,7FFA98694000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFA98694000
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA973CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFA973AFE58]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFA972099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA973CB9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFA972099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,20C62C02028
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
       mov       rdx,7FFA96F74000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFA96F74000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971ED030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97365750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA9895B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,226540E3020
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
       mov       rdx,7FFA986B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFA986B4000
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA9739B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFA9737FE58]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFA971D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA9739B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFA971D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1F425002028
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
       mov       rdx,7FFA96F44000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFA96F44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971BD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97335750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA9896B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,2208B113020
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
       mov       rdx,7FFA986C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFA986C4000
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA9739B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFA9737FE58]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFA971D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA9739B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFA971D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,247D1802028
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
       mov       rdx,7FFA96F44000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFA96F44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971BD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97335750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA9895B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,28B82743020
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
       mov       rdx,7FFA986B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFA986B4000
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA973AB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFA9738FE58]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFA971E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA973AB9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFA971E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1994C002028
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
       mov       rdx,7FFA96F54000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFA96F54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971CD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97345750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA9896B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,26C4D0F3020
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
       mov       rdx,7FFA986C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFA986C4000
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA973AB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFA9738FE58]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFA971E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA973AB9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFA971E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,27A93C02028
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
       mov       rdx,7FFA96F54000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFA96F54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971CD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97345750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA9892B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,1F7E54D3020
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
       mov       rdx,7FFA98684000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFA98684000
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA973BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFA9739FE58]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA973BB9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFA971F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,236AF802028
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
       mov       rdx,7FFA96F64000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFA96F64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971DD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97355750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA9896B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,2C741743020
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
       mov       rdx,7FFA986C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFA986C4000
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA973CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFA973AFE58]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFA972099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA973CB9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFA972099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21F4A000030
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
       mov       rdx,7FFA96F74000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFA96F74000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971ED030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97365750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA9895B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,2AE8E733020
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
       mov       rdx,7FFA986B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFA986B4000
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA973AB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFA9738FE58]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFA971E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA973AB9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFA971E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2A8DA802028
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
       mov       rdx,7FFA96F54000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFA96F54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971CD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97345750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA9893B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,1E3354B3020
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
       mov       rdx,7FFA98694000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFA98694000
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA9739B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFA9737FE58]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFA971D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA9739B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFA971D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,28139C02028
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
       mov       rdx,7FFA96F44000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFA96F44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971BD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97335750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA9895B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,26F06733020
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
       mov       rdx,7FFA986B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFA986B4000
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA973CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFA973AFE58]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFA972099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA973CB9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFA972099F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1B2D1C02028
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
       mov       rdx,7FFA96F74000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFA96F74000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971ED030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97365750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA9895B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,202B35F3020
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
       mov       rdx,7FFA986B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFA986B4000
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA973AB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFA9738FE58]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFA971E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA973AB9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFA971E99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1FA7F002028
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
       mov       rdx,7FFA96F54000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFA96F54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971CD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97345750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA9893B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rax,1B1F7023020
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
       mov       rdx,7FFA98694000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFA98694000
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA9739B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L01:
       inc       ebx
       mov       rcx,[rsi+2A0]
       cmp       [rcx+8],ebx
       jg        short M00_L00
M00_L02:
       mov       rcx,rdi
       call      qword ptr [7FFA9737FE58]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FFA971D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFA9739B9D8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFA971D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22B29C02028
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
       mov       rdx,7FFA96F44000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFA96F44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA971BD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFA97335750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rax,18337073020
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
       mov       rcx,7FFA98946A60
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,183370785F0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,18397071C00
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,18337071568
       mov       r15,[rdx]
       mov       rdx,18397071C08
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
       call      qword ptr [7FFA9893B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rcx,183370785F0
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
       mov       rcx,7FFA98946A60
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,183370785F0
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FFA978B5000]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA978B5240]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,1F3E4C02028
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
       mov       rcx,1F3E4C07640
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFA97777258]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,1F3F0C00C50
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFA973BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,1F3E4C00528
       mov       r12,[rdx]
       mov       rdx,1F3F0C00C58
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFA97353FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFA973BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFA9739FE58]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFA973BB258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFA97777260]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1F3E4C07640
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFA97777260]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      00007FFA98C899A8
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FFA97235300]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA97235540]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,23599402028
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
       mov       rcx,235A9403238
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFA970EC190]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,23595409C00
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFA96D2B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,23599400528
       mov       r12,[rdx]
       mov       rdx,23595409C08
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFA96CC3FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFA96D2B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFA96D0FE58]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFA96D2B258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFA970EC198]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,235A9403238
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFA970EC198]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rax,1FA512B3020
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
       mov       rcx,7FFA98956A60
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FA512B85F0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,1FAD12BABB0
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,1FA512B1568
       mov       r15,[rdx]
       mov       rdx,1FAD12BABB8
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
       call      qword ptr [7FFA9894B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rcx,1FA512B85F0
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
       mov       rcx,7FFA98956A60
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FA512B85F0
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FFA976A5870]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA976A5AB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,234B8800030
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
       mov       rcx,234B8805648
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFA9757B2D0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,234B6800C50
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFA971BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,234BC800528
       mov       r12,[rdx]
       mov       rdx,234B6800C58
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFA97153FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFA971BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFA9719FE58]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFA971BB258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFA9757B2D8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,234B8805648
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFA9757B2D8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rax,239D0021028
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
       mov       rcx,7FFA98976A60
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,239900261E0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,239E0021C00
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,23990021568
       mov       r15,[rdx]
       mov       rdx,239E0021C08
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
       call      qword ptr [7FFA9896B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rcx,239900261E0
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
       mov       rcx,7FFA98976A60
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,239900261E0
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FFA97897870]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA97897AB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,2DDE3802028
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
       mov       rcx,2DDE3807640
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFA9776C968]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,2DDE7800C50
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFA973AB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,2DDE3800528
       mov       r12,[rdx]
       mov       rdx,2DDE7800C58
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFA97343FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFA973AB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFA9738FE58]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFA973AB258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFA9776C970]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,2DDE3807640
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFA9776C970]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rax,21D18AD3020
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
       mov       rcx,7FFA98946A60
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21D18AD85F0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       rdx,21D38ADABB0
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       movsxd    r14,ebx
       test      r14,r14
       jle       short M01_L02
       mov       rdx,21D18AD1568
       mov       r15,[rdx]
       mov       rdx,21D38ADABB8
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
       call      qword ptr [7FFA9893B6B8]; System.Text.StringBuilder.ToString()
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
       mov       rcx,21D18AD85F0
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
       mov       rcx,7FFA98946A60
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21D18AD85F0
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FFA978D5300]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA978D5540]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,1B02E002028
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
       mov       rcx,1B02E007640
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFA9779BCA8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,1B036008BE8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFA973DB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,1B02E000528
       mov       r12,[rdx]
       mov       rdx,1B036008BF0
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFA97373FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFA973DB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFA973BFE58]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFA973DB258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFA9779BCB0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1B02E007640
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFA9779BCB0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      00007FFA98C599E8
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FFA978D5300]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA978D5540]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,1BB87402028
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
       mov       rcx,1BB87407640
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFA9779B830]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,1BB8F400C50
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFA973DB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,1BB87400528
       mov       r12,[rdx]
       mov       rdx,1BB8F400C58
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFA97373FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFA973DB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFA973BFE58]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFA973DB258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFA9779B838]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1BB87407640
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFA9779B838]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      00007FFA98C799C8
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.BytesToString()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       call      qword ptr [7FFA978C5300]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA978C5540]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rax,18EFAC02028
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
       mov       rcx,18EFAC07640
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFA9778B4B8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       rcx,rax
       mov       [rbp-40],rcx
       cmp       [rcx],cl
       mov       rdx,18EF8C00C50
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFA973CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       mov       r15d,r14d
       test      r15,r15
       jle       short M01_L03
       mov       rdx,18EFAC00528
       mov       r12,[rdx]
       mov       rdx,18EF8C00C58
       mov       r13,[rdx]
M01_L01:
       cmp       ebx,r14d
       jae       short M01_L05
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      qword ptr [7FFA97363FD8]; System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,[rbp-40]
       call      qword ptr [7FFA973CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       call      qword ptr [7FFA973AFE58]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7FFA973CB258]
       mov       rcx,[rbp-40]
       jmp       short M01_L04
M01_L08:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFA9778B4C0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,18EFAC07640
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FFA9778B4C0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rcx,7FFA98976A60
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23B189785F0
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
       call      qword ptr [7FFA9896B6B8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,23B189785F0
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
       mov       rcx,7FFA98976A60
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23B189785F0
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FFA978C5318]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA978C53D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,2684C807640
       mov       rbx,[rcx]
       mov       rcx,rbx
       call      qword ptr [7FFA9778B4B8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
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
       call      qword ptr [7FFA973CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M01_L03
M01_L01:
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L02
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FFA973CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       mov       rdx,2684C8084B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,[rbp-38]
       mov       r8d,2
       call      qword ptr [7FFA973CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFA973AFE58]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFA9778B4C0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,2684C807640
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFA9778B4C0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      00007FFA98C695E0
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FFA97255318]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA972553D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,1E680005230
       mov       rbx,[rcx]
       mov       rcx,rbx
       call      qword ptr [7FFA9710C190]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
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
       call      qword ptr [7FFA96D4B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M01_L03
M01_L01:
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L02
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FFA96D4B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       mov       rdx,1E6800060A0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,[rbp-38]
       mov       r8d,2
       call      qword ptr [7FFA96D4B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFA96D2FE58]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFA9710C198]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1E680005230
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFA9710C198]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rcx,7FFA98976A60
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,16F076185F0
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
       call      qword ptr [7FFA9896B6B8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,16F076185F0
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
       mov       rcx,7FFA98976A60
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,16F076185F0
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FFA978A7888]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA978A7948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,25C30407640
       mov       rbx,[rcx]
       mov       rcx,rbx
       call      qword ptr [7FFA9777CDE8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
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
       call      qword ptr [7FFA973BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M01_L03
M01_L01:
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L02
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FFA973BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       mov       rdx,25C304084B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,[rbp-38]
       mov       r8d,2
       call      qword ptr [7FFA973BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFA9739FE58]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFA9777CDF0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,25C30407640
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFA9777CDF0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rcx,7FFA98936A60
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,198277C85F0
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
       call      qword ptr [7FFA9892B6B8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,198277C85F0
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
       mov       rcx,7FFA98936A60
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,198277C85F0
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FFA978D5318]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA978D53D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,22097007640
       mov       rbx,[rcx]
       mov       rcx,rbx
       call      qword ptr [7FFA9778BCA8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
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
       call      qword ptr [7FFA973CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M01_L03
M01_L01:
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L02
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FFA973CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       mov       rdx,220970084B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,[rbp-38]
       mov       r8d,2
       call      qword ptr [7FFA973CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFA973AFE58]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFA9778BCB0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,22097007640
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFA9778BCB0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rcx,7FFA98936A60
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FAA9D085F0
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
       call      qword ptr [7FFA9892B6B8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,1FAA9D085F0
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
       mov       rcx,7FFA98936A60
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FAA9D085F0
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FFA978A5018]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA978A50D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,1F44B807640
       mov       rbx,[rcx]
       mov       rcx,rbx
       call      qword ptr [7FFA97767258]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
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
       call      qword ptr [7FFA973AB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M01_L03
M01_L01:
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L02
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FFA973AB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       mov       rdx,1F44B8084B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,[rbp-38]
       mov       r8d,2
       call      qword ptr [7FFA973AB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFA9738FE58]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFA97767260]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1F44B807640
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFA97767260]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      00007FFA98C79990
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
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FFA97897888]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA97897948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,2A38D407640
       mov       rbx,[rcx]
       mov       rcx,rbx
       call      qword ptr [7FFA9776CDE8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
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
       call      qword ptr [7FFA973AB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M01_L03
M01_L01:
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L02
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FFA973AB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       mov       rdx,2A38D4084B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,[rbp-38]
       mov       r8d,2
       call      qword ptr [7FFA973AB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFA9738FE58]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFA9776CDF0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,2A38D407640
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFA9776CDF0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rcx,7FFA98966A60
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,173BD3085F0
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
       call      qword ptr [7FFA9895B6B8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,173BD3085F0
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
       mov       rcx,7FFA98966A60
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,173BD3085F0
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderCounterBenchmark.CombineStrings()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+2A0]
       xor       ecx,ecx
       call      qword ptr [7FFA978A7318]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(DotNetTips.Spargine.Core.Tristate, System.String[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA978A73D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,209C1C03238
       mov       rbx,[rcx]
       mov       rcx,rbx
       call      qword ptr [7FFA9777CDE8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
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
       call      qword ptr [7FFA973BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M01_L03
M01_L01:
       cmp       [rdx],dl
       test      r12,r12
       je        short M01_L02
       mov       r8d,[r12+8]
       lea       rdx,[r12+0C]
       mov       rcx,[rbp-38]
       call      qword ptr [7FFA973BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L02:
       mov       rdx,209C1C040A8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,[rbp-38]
       mov       r8d,2
       call      qword ptr [7FFA973BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFA9739FE58]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFA9777CDF0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,209C1C03238
       mov       rbx,[rcx]
       mov       rcx,rbx
       mov       rdx,[rbp-38]
       call      qword ptr [7FFA9777CDF0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rax,1E203863020
       mov       rax,[rax]
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
M02_L00:
       mov       rcx,1E1E38661E0
       mov       rcx,[rcx]
       call      qword ptr [7FFA98D02CC8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-10],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA9894B6B8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,1E1E38661E0
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFA98D02CD0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1E1E38661E0
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFA98D02CD0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA978A7360]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA978A73D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFA9711B630]
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
       call      qword ptr [7FFA973BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       mov       rax,2869E002028
       mov       rax,[rax]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L00:
       mov       rcx,2869E007640
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFA9777CDE8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-18],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA9739FE58]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFA9777CDF0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,2869E007640
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFA9777CDF0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rax,2A4A8573020
       mov       rax,[rax]
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
M02_L00:
       mov       rcx,2A4A85785F0
       mov       rcx,[rcx]
       call      qword ptr [7FFA98D12CC8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-10],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA9895B6B8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,2A4A85785F0
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFA98D12CD0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,2A4A85785F0
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFA98D12CD0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA976878D0]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA97687948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFA96EFB630]
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
       call      qword ptr [7FFA9719B9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       mov       rax,11FCB002028
       mov       rax,[rax]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L00:
       mov       rcx,11FCB007640
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFA9755CDE8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-18],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA9717FE58]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFA9755CDF0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,11FCB007640
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFA9755CDF0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rax,1EF57F03020
       mov       rax,[rax]
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
M02_L00:
       mov       rcx,1EF57F085F0
       mov       rcx,[rcx]
       call      qword ptr [7FFA98CE1B78]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-10],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA9892B6B8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,1EF57F085F0
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFA98CE1B80]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1EF57F085F0
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFA98CE1B80]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA978B5360]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA978B53D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFA9710B630]
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
       call      qword ptr [7FFA973AB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       mov       rax,1D003C02028
       mov       rax,[rax]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L00:
       mov       rcx,1D003C07640
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFA9776C190]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-18],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA9738FE58]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFA9776C198]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1D003C07640
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFA9776C198]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rax,1F340441028
       mov       rax,[rax]
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
M02_L00:
       mov       rcx,1F3404465F8
       mov       rcx,[rcx]
       call      qword ptr [7FFA98CF1478]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-10],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA9893B6B8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,1F3404465F8
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFA98CF1480]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1F3404465F8
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFA98CF1480]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA978B58D0]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA978B5948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFA9712B630]
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
       call      qword ptr [7FFA973CB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       mov       rax,1851B802028
       mov       rax,[rax]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L00:
       mov       rcx,1851B807640
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFA9778B2D0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-18],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA973AFE58]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFA9778B2D8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1851B807640
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFA9778B2D8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rax,1C151CE3020
       mov       rax,[rax]
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
M02_L00:
       mov       rcx,1C151CE85F0
       mov       rcx,[rcx]
       call      qword ptr [7FFA98D12CC8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-10],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA9895B6B8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,1C151CE85F0
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFA98D12CD0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1C151CE85F0
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFA98D12CD0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA978A5360]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA978A53D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFA9710B630]
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
       call      qword ptr [7FFA973AB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       mov       rax,2699A002028
       mov       rax,[rax]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L00:
       mov       rcx,2699A007640
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFA9776B008]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-18],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA9738FE58]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFA9776B010]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,2699A007640
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFA9776B010]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rax,297587E3020
       mov       rax,[rax]
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
M02_L00:
       mov       rcx,297587E85F0
       mov       rcx,[rcx]
       call      qword ptr [7FFA98D22CC8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-10],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA9896B6B8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,297587E85F0
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFA98D22CD0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,297587E85F0
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFA98D22CD0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       call      qword ptr [7FFA978B58D0]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA978B5948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFA9711B630]
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
       call      qword ptr [7FFA973BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
       mov       rax,1D61A802028
       mov       rax,[rax]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L00:
       mov       rcx,1D626805230
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFA9777C190]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-18],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA9739FE58]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFA9777C198]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,1D626805230
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFA9777C198]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rax,2562AC03020
       mov       rax,[rax]
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
M02_L00:
       mov       rcx,2562AC085F0
       mov       rcx,[rcx]
       call      qword ptr [7FFA98D22CC8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-10],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFA9896B6B8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,2562AC085F0
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFA98D22CD0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,2562AC085F0
       mov       rcx,[rcx]
       mov       rdx,[rbp-10]
       call      qword ptr [7FFA98D22CD0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       mov       rcx,7FFA973E4ED0
       mov       [rdi+18],rcx
       mov       rcx,rdi
       call      qword ptr [7FFA9786D060]; DotNetTips.Spargine.Core.FastStringBuilder.PerformAction(System.Action`1<System.Text.StringBuilder>)
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA9786D0D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFA9712B630]
       int       3
; Total bytes of code 121
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
       jne       short M01_L00
       mov       rax,26950000030
       mov       rax,[rax]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,26950005648
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FFA97762A08]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-18],rax
       mov       rcx,[rsi+8]
       mov       rdx,rax
       call      qword ptr [rsi+18]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA973AFE58]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFA97762A10]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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
       mov       rcx,26950005648
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rbp-18]
       call      qword ptr [7FFA97762A10]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Return(System.__Canon)
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

