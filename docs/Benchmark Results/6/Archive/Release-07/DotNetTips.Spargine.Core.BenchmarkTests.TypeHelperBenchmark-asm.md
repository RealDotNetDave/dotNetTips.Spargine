## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.CreateStringBuilder01()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
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
       mov       rbx,[rsi+190]
       mov       ebp,[rbx+14]
       xor       r14d,r14d
       jmp       near ptr M00_L01
M00_L00:
       mov       rcx,212DA511568
       mov       r12,[rcx]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF9C79F51F0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Email()
       mov       r13,rax
       mov       rcx,r15
       call      qword ptr [7FF9C79F5240]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_PostalCode()
       mov       r15,rax
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rcx,7FF9C76B4938
       mov       edx,184
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,212DA511388
       mov       rcx,[rcx]
       mov       rdx,r12
       mov       r8,212CA511B78
       mov       r8,[r8]
       mov       [rsp+30],r13
       mov       [rsp+38],r15
       mov       r15,[rsp+28]
       mov       [rsp+40],r15
       mov       [rsp+48],rcx
       mov       rcx,rdi
       lea       r9,[rsp+30]
       call      System.Text.StringBuilder.AppendFormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
M00_L01:
       mov       rcx,rbx
       cmp       ebp,[rcx+14]
       jne       short M00_L02
       cmp       r14d,[rbx+10]
       jae       short M00_L03
       mov       rcx,[rbx+8]
       cmp       r14d,[rcx+8]
       jae       short M00_L06
       movsxd    rax,r14d
       mov       r15,[rcx+rax*8+10]
       inc       r14d
       mov       ecx,1
       jmp       short M00_L04
M00_L02:
       cmp       ebp,[rbx+14]
       jne       short M00_L05
M00_L03:
       mov       r14d,[rbx+10]
       inc       r14d
       xor       r15d,r15d
       xor       ecx,ecx
M00_L04:
       test      ecx,ecx
       jne       near ptr M00_L00
       mov       rcx,rdi
       call      qword ptr [7FF9C784BC48]; System.Text.StringBuilder.ToString()
       mov       [rsp+50],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+50]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L05:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       int       3
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 384
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Email()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7865F48],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+30]
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_PostalCode()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7865F48],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+58]
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 42
```
```assembly
; System.Text.StringBuilder.AppendFormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0B8
       xor       eax,eax
       mov       [rsp+68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       vmovdqa   xmmword ptr [rsp+80],xmm4
       vmovdqa   xmmword ptr [rsp+90],xmm4
       mov       rdi,rcx
       mov       rbp,rdx
       mov       rsi,r8
       mov       rbx,r9
       test      rsi,rsi
       je        near ptr M03_L52
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       mov       r12d,r15d
       xor       r13d,r13d
       test      rbp,rbp
       je        short M03_L00
       mov       rcx,offset MT_System.ICustomFormatter
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF9C75B0770
       call      qword ptr [7FF9C75B0770]
       mov       rdx,rax
       mov       rcx,offset MT_System.ICustomFormatter
       call      CORINFO_HELP_CHKCASTINTERFACE
       mov       r13,rax
M03_L00:
       cmp       r14d,r12d
       jge       short M03_L05
M03_L01:
       cmp       r14d,r15d
       jae       near ptr M03_L68
       movsxd    rcx,r14d
       movzx     eax,word ptr [rsi+rcx*2+0C]
       inc       r14d
       cmp       eax,7D
       je        near ptr M03_L53
       cmp       eax,7B
       jne       short M03_L03
       cmp       r14d,r12d
       jge       short M03_L02
       cmp       r14d,r15d
       jae       near ptr M03_L68
       movsxd    rcx,r14d
       cmp       word ptr [rsi+rcx*2+0C],7B
       je        near ptr M03_L54
M03_L02:
       dec       r14d
       jmp       short M03_L05
M03_L03:
       mov       ecx,[rdi+18]
       mov       edx,ecx
       mov       r8,[rdi+8]
       cmp       [r8+8],edx
       jbe       near ptr M03_L17
       movsxd    rdx,edx
       mov       [r8+rdx*2+10],ax
       inc       ecx
       mov       [rdi+18],ecx
M03_L04:
       cmp       r14d,r12d
       jl        short M03_L01
M03_L05:
       cmp       r14d,r12d
       je        near ptr M03_L37
       inc       r14d
       cmp       r14d,r12d
       je        near ptr M03_L66
       cmp       r14d,r15d
       jae       near ptr M03_L68
       movsxd    rax,r14d
       movzx     eax,word ptr [rsi+rax*2+0C]
       cmp       eax,30
       jl        near ptr M03_L66
       cmp       eax,39
       jg        near ptr M03_L66
       xor       edx,edx
M03_L06:
       lea       edx,[rdx+rdx*4]
       lea       edx,[rax+rdx*2-30]
       inc       r14d
       cmp       r14d,r12d
       je        near ptr M03_L66
       cmp       r14d,r15d
       jae       near ptr M03_L68
       movsxd    rax,r14d
       movzx     eax,word ptr [rsi+rax*2+0C]
       cmp       eax,30
       jl        short M03_L07
       cmp       eax,39
       jg        short M03_L07
       cmp       edx,0F4240
       jl        short M03_L06
M03_L07:
       mov       rcx,[rbx+18]
       cmp       [rcx+8],edx
       jle       near ptr M03_L55
M03_L08:
       cmp       r14d,r12d
       jge       short M03_L09
       cmp       r14d,r15d
       jae       near ptr M03_L68
       movsxd    rax,r14d
       movzx     eax,word ptr [rsi+rax*2+0C]
       cmp       eax,20
       jne       short M03_L09
       inc       r14d
       jmp       short M03_L08
M03_L09:
       xor       r8d,r8d
       mov       [rsp+0B0],r8d
       xor       r9d,r9d
       mov       [rsp+0AC],r9d
       cmp       eax,2C
       je        near ptr M03_L56
M03_L10:
       cmp       r14d,r12d
       jge       short M03_L11
       cmp       r14d,r15d
       jae       near ptr M03_L68
       movsxd    rax,r14d
       movzx     eax,word ptr [rsi+rax*2+0C]
       mov       [rsp+0B4],eax
       cmp       eax,20
       mov       eax,[rsp+0B4]
       je        near ptr M03_L62
M03_L11:
       test      edx,edx
       jne       near ptr M03_L16
       mov       r10,[rbx]
M03_L12:
       mov       [rsp+50],r10
       xor       r11d,r11d
       xor       edx,edx
       cmp       eax,3A
       jne       near ptr M03_L24
       inc       r14d
       mov       ecx,r14d
M03_L13:
       cmp       r14d,r12d
       je        near ptr M03_L66
       cmp       r14d,r15d
       jae       near ptr M03_L68
       movsxd    rax,r14d
       movzx     eax,word ptr [rsi+rax*2+0C]
       cmp       eax,7D
       je        near ptr M03_L23
       cmp       eax,7B
       je        near ptr M03_L66
       inc       r14d
       jmp       short M03_L13
M03_L14:
       mov       rcx,r13
       mov       r9,rbp
       mov       [rsp+40],rax
       mov       rdx,rax
       mov       r8,r10
       mov       r11,7FF9C75B0768
       call      qword ptr [7FF9C75B0768]
       mov       r10,rax
       mov       rcx,r10
       mov       rax,[rsp+40]
       mov       edx,[rsp+94]
       mov       r10,[rsp+50]
       mov       r11,[rsp+30]
M03_L15:
       mov       [rsp+48],rcx
       test      rcx,rcx
       jne       near ptr M03_L49
       jmp       short M03_L18
M03_L16:
       mov       [rsp+0B4],eax
       mov       rcx,rbx
       call      System.ParamsArray.GetAtSlow(Int32)
       mov       r10,rax
       mov       eax,[rsp+0B4]
       jmp       near ptr M03_L12
M03_L17:
       mov       rcx,rdi
       mov       edx,eax
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M03_L04
M03_L18:
       mov       [rsp+94],edx
       mov       [rsp+30],r11
       mov       [rsp+40],rax
       mov       rdx,r10
       mov       rcx,offset MT_System.ISpanFormattable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        near ptr M03_L39
       cmp       dword ptr [rsp+0B0],0
       jne       near ptr M03_L21
       cmp       dword ptr [rsp+0AC],0
       jne       near ptr M03_L39
       mov       [rsp+58],r13
M03_L19:
       mov       rcx,[rdi+8]
       mov       r9,rcx
       mov       edx,[rdi+18]
       mov       r11d,edx
       mov       ecx,[rcx+8]
       sub       ecx,edx
       mov       edx,r11d
       mov       r13d,ecx
       add       rdx,r13
       mov       r13d,[r9+8]
       cmp       rdx,r13
       ja        near ptr M03_L65
       add       r9,10
       mov       edx,r11d
       lea       r11,[r9+rdx*2]
       mov       r9,offset MT_System.Byte
       cmp       [rax],r9
       jne       near ptr M03_L38
       add       rax,8
       mov       [rsp+90],ecx
       mov       r13,[rsp+30]
       mov       rdx,r13
       mov       r9d,[rsp+94]
       mov       ecx,r9d
       movzx     eax,byte ptr [rax]
       mov       [rsp+28],rdx
       mov       edx,[rsp+90]
       test      ecx,ecx
       jne       near ptr M03_L40
       mov       [rsp+8C],edx
       mov       ecx,eax
       mov       edx,1
       cmp       eax,186A0
       jae       short M03_L22
M03_L20:
       cmp       ecx,0A
       jb        near ptr M03_L29
       cmp       ecx,64
       jae       near ptr M03_L26
       inc       edx
       jmp       near ptr M03_L29
M03_L21:
       mov       [rsp+58],r13
       jmp       near ptr M03_L19
M03_L22:
       mov       ecx,eax
       shr       ecx,5
       imul      rcx,0A7C5AC5
       shr       rcx,27
       mov       edx,6
       jmp       short M03_L20
M03_L23:
       cmp       r14d,ecx
       jle       short M03_L25
       mov       edx,r14d
       sub       edx,ecx
       mov       r11d,ecx
       mov       eax,edx
       add       rax,r11
       mov       r11d,r15d
       cmp       rax,r11
       ja        near ptr M03_L63
       lea       rax,[rsi+0C]
       mov       ecx,ecx
       lea       r11,[rax+rcx*2]
       mov       [rsp+30],r11
       mov       [rsp+94],edx
       mov       edx,[rsp+94]
       mov       r11,[rsp+30]
       jmp       short M03_L25
M03_L24:
       cmp       eax,7D
       jne       near ptr M03_L66
M03_L25:
       inc       r14d
       xor       ecx,ecx
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+58],r13
       test      r13,r13
       mov       rax,[rsp+40]
       mov       r13,[rsp+58]
       je        near ptr M03_L15
       mov       [rsp+94],edx
       test      edx,edx
       jne       near ptr M03_L64
       mov       [rsp+30],r11
       jmp       near ptr M03_L14
M03_L26:
       cmp       ecx,3E8
       jae       short M03_L27
       add       edx,2
       jmp       short M03_L29
M03_L27:
       cmp       ecx,2710
       jae       short M03_L28
       add       edx,3
       jmp       short M03_L29
M03_L28:
       add       edx,4
M03_L29:
       cmp       edx,0FFFFFFFF
       jle       short M03_L30
       mov       ecx,edx
       jmp       short M03_L31
M03_L30:
       mov       ecx,0FFFFFFFF
M03_L31:
       mov       edx,[rsp+8C]
       cmp       ecx,edx
       jg        near ptr M03_L36
       mov       [rsp+0A0],ecx
       mov       [rsp+98],r11
       movsxd    rcx,ecx
       lea       rcx,[r11+rcx*2]
M03_L32:
       mov       edx,0CCCCCCCD
       mov       r11d,eax
       imul      rdx,r11
       shr       rdx,23
       lea       r11d,[rdx+rdx*4]
       add       r11d,r11d
       sub       eax,r11d
       add       rcx,0FFFFFFFFFFFFFFFE
       add       eax,30
       mov       [rcx],ax
       test      edx,edx
       mov       eax,edx
       jne       short M03_L32
       xor       eax,eax
       mov       [rsp+98],rax
       mov       r11d,1
M03_L33:
       xor       eax,eax
       mov       [rsp+98],rax
M03_L34:
       test      r11d,r11d
       mov       [rsp+94],r9d
       je        short M03_L35
       mov       eax,[rsp+0A0]
       mov       r9,[rdi+8]
       mov       rcx,r9
       mov       edx,[rdi+18]
       mov       r11d,edx
       mov       r9d,[r9+8]
       sub       r9d,edx
       mov       r11d,r11d
       mov       r13d,r9d
       add       r11,r13
       mov       ecx,[rcx+8]
       cmp       r11,rcx
       ja        near ptr M03_L65
       cmp       eax,r9d
       ja        near ptr M03_L66
       add       edx,[rsp+0A0]
       mov       [rdi+18],edx
       mov       r8d,[rsp+0AC]
       sub       r8d,[rsp+0A0]
       cmp       dword ptr [rsp+0B0],0
       jne       near ptr M03_L67
       mov       r13,[rsp+58]
       jmp       near ptr M03_L00
M03_L35:
       mov       r13,[rsp+58]
       jmp       near ptr M03_L39
M03_L36:
       xor       r11d,r11d
       mov       [rsp+0A0],r11d
       jmp       near ptr M03_L33
M03_L37:
       mov       rax,rdi
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L38:
       mov       rdx,rax
       mov       [rsp+68],r11
       mov       [rsp+70],ecx
       lea       r9,[rsp+0A0]
       mov       r13,[rsp+30]
       mov       [rsp+78],r13
       mov       eax,[rsp+94]
       mov       [rsp+80],eax
       mov       [rsp+20],rbp
       mov       rcx,rdx
       lea       rdx,[rsp+68]
       mov       r8,r9
       lea       r9,[rsp+78]
       mov       r11,7FF9C75B0760
       call      qword ptr [7FF9C75B0760]
       mov       r11d,eax
       mov       [rsp+30],r13
       mov       r9d,[rsp+94]
       jmp       near ptr M03_L34
M03_L39:
       mov       rdx,[rsp+50]
       mov       rcx,offset MT_System.IFormattable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       [rsp+38],rax
       test      rax,rax
       je        near ptr M03_L48
       jmp       near ptr M03_L44
M03_L40:
       mov       [rsp+94],r9d
       mov       [rsp+64],eax
       mov       rax,[rsp+28]
       mov       [rsp+78],rax
       mov       [rsp+80],ecx
       mov       [rsp+68],r11
       mov       [rsp+70],edx
       lea       rcx,[rsp+0A0]
       mov       [rsp+20],rcx
       mov       ecx,[rsp+64]
       lea       rdx,[rsp+78]
       mov       r8,rbp
       lea       r9,[rsp+68]
       call      System.Number.<TryFormatUInt32>g__TryFormatUInt32Slow|43_0(UInt32, System.ReadOnlySpan`1<Char>, System.IFormatProvider, System.Span`1<Char>, Int32 ByRef)
       mov       r11d,eax
       mov       r9d,[rsp+94]
       jmp       near ptr M03_L34
M03_L41:
       mov       r9d,[rsp+0AC]
       mov       [rsp+48],rcx
       mov       eax,r9d
       sub       eax,[rcx+8]
       cmp       dword ptr [rsp+0B0],0
       jne       short M03_L43
       mov       [rsp+0A8],eax
       test      eax,eax
       jg        near ptr M03_L50
M03_L42:
       mov       rcx,rdi
       mov       rdx,[rsp+48]
       call      System.Text.StringBuilder.Append(System.String)
       cmp       dword ptr [rsp+0B0],0
       jne       near ptr M03_L51
       jmp       near ptr M03_L00
M03_L43:
       mov       [rsp+0A8],eax
       jmp       short M03_L42
M03_L44:
       mov       r8d,[rsp+94]
       test      r8d,r8d
       je        short M03_L45
       mov       r9,[rsp+40]
       test      r9,r9
       mov       [rsp+40],r9
       jne       short M03_L45
       mov       r10,[rsp+30]
       mov       [rsp+78],r10
       mov       [rsp+80],r8d
       lea       rdx,[rsp+78]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       [rsp+40],rax
M03_L45:
       mov       rcx,offset MT_System.Byte
       mov       rax,[rsp+38]
       cmp       [rax],rcx
       jne       short M03_L46
       add       rax,8
       movzx     ecx,byte ptr [rax]
       mov       rdx,[rsp+40]
       mov       r8,rbp
       call      System.Number.FormatUInt32(UInt32, System.String, System.IFormatProvider)
       mov       r10,rax
       jmp       short M03_L47
M03_L46:
       mov       rcx,rax
       mov       r8,rbp
       mov       rdx,[rsp+40]
       mov       r11,7FF9C75B0758
       call      qword ptr [7FF9C75B0758]
       mov       r10,rax
M03_L47:
       mov       rax,r10
       mov       [rsp+48],rax
       jmp       short M03_L49
M03_L48:
       mov       rdx,[rsp+50]
       test      rdx,rdx
       je        short M03_L49
       mov       rcx,rdx
       mov       rax,[rdx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rsp+48],rax
M03_L49:
       mov       rcx,[rsp+48]
       test      rcx,rcx
       jne       near ptr M03_L41
       mov       rcx,212DA513020
       mov       rdx,[rcx]
       mov       [rsp+48],rdx
       mov       rcx,[rsp+48]
       jmp       near ptr M03_L41
M03_L50:
       mov       eax,[rsp+0A8]
       mov       rcx,rdi
       mov       [rsp+0A8],eax
       mov       r8d,eax
       mov       edx,20
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M03_L42
M03_L51:
       mov       edx,[rsp+0A8]
       test      edx,edx
       jle       near ptr M03_L00
       mov       rcx,rdi
       mov       r8d,edx
       mov       edx,20
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M03_L00
M03_L52:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       ecx,31B
       mov       rdx,7FF9C75A4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M03_L53:
       cmp       r14d,r12d
       jge       near ptr M03_L66
       cmp       r14d,r15d
       jae       near ptr M03_L68
       movsxd    rcx,r14d
       cmp       word ptr [rsi+rcx*2+0C],7D
       jne       near ptr M03_L66
       inc       r14d
       jmp       near ptr M03_L03
M03_L54:
       inc       r14d
       jmp       near ptr M03_L03
M03_L55:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       ecx,0C5F3
       mov       rdx,7FF9C75A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.FormatException..ctor(System.String)
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M03_L56:
       inc       r14d
       jmp       short M03_L58
M03_L57:
       inc       r14d
M03_L58:
       cmp       r14d,r12d
       jge       short M03_L59
       cmp       r14d,r15d
       jae       near ptr M03_L68
       movsxd    rcx,r14d
       cmp       word ptr [rsi+rcx*2+0C],20
       je        short M03_L57
M03_L59:
       cmp       r14d,r12d
       je        near ptr M03_L66
       cmp       r14d,r15d
       jae       near ptr M03_L68
       movsxd    rcx,r14d
       movzx     eax,word ptr [rsi+rcx*2+0C]
       mov       ecx,eax
       cmp       ecx,2D
       jne       short M03_L60
       mov       r8d,1
       inc       r14d
       cmp       r14d,r12d
       je        near ptr M03_L66
       cmp       r14d,r15d
       jae       near ptr M03_L68
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       mov       [rsp+0B0],r8d
M03_L60:
       cmp       ecx,30
       jl        near ptr M03_L66
       cmp       ecx,39
       jg        near ptr M03_L66
M03_L61:
       mov       r9d,[rsp+0AC]
       lea       r9d,[r9+r9*4]
       lea       r9d,[rcx+r9*2-30]
       mov       eax,r9d
       inc       r14d
       cmp       r14d,r12d
       je        near ptr M03_L66
       cmp       r14d,r15d
       jae       near ptr M03_L68
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,30
       mov       [rsp+0AC],eax
       mov       eax,ecx
       jl        near ptr M03_L10
       cmp       eax,39
       jg        near ptr M03_L10
       mov       r9d,[rsp+0AC]
       cmp       r9d,0F4240
       mov       [rsp+0AC],r9d
       mov       ecx,eax
       jl        short M03_L61
       mov       eax,ecx
       jmp       near ptr M03_L10
M03_L62:
       inc       r14d
       jmp       near ptr M03_L10
M03_L63:
       mov       ecx,21
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M03_L64:
       mov       [rsp+30],r11
       mov       [rsp+78],r11
       mov       edx,[rsp+94]
       mov       [rsp+80],edx
       lea       rdx,[rsp+78]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rdx,rax
       mov       rax,rdx
       mov       r10,[rsp+50]
       jmp       near ptr M03_L14
M03_L65:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M03_L66:
       call      System.Text.StringBuilder.FormatError()
       int       3
M03_L67:
       test      r8d,r8d
       mov       r13,[rsp+58]
       jle       near ptr M03_L00
       mov       rcx,rdi
       mov       edx,20
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M03_L00
M03_L68:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2573
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
       mov       rax,212DA513020
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
System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.CreateStringBuilder01()
       push      r15
       push      r14
       push      r13
       push      r12
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
       mov       rbx,[rsi+190]
       mov       ebp,[rbx+14]
       xor       r14d,r14d
       jmp       short M00_L01
M00_L00:
       mov       rcx,2346B800528
       mov       r12,[rcx]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE73AE78]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Email()
       mov       r13,rax
       mov       rcx,r15
       call      qword ptr [7FF9CE73AEC8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_PostalCode()
       mov       [rsp+38],r13
       mov       [rsp+40],rax
       lea       rcx,[rsp+38]
       mov       rdx,r12
       mov       r8,23467800BB0
       mov       r8,[r8]
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],2
       mov       rcx,rdi
       lea       r9,[rsp+20]
       call      qword ptr [7FF9CE5BB900]; System.Text.StringBuilder.AppendFormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
M00_L01:
       mov       rcx,rbx
       cmp       ebp,[rcx+14]
       jne       short M00_L03
       cmp       r14d,[rbx+10]
       jae       short M00_L04
       mov       rcx,[rbx+8]
       cmp       r14d,[rcx+8]
       jae       short M00_L06
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       inc       r14d
       mov       ecx,1
M00_L02:
       test      ecx,ecx
       jne       near ptr M00_L00
       mov       rcx,rdi
       call      qword ptr [7FF9CE59FE38]; System.Text.StringBuilder.ToString()
       mov       [rsp+30],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+30]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L03:
       cmp       ebp,[rbx+14]
       jne       short M00_L05
M00_L04:
       mov       r14d,[rbx+10]
       inc       r14d
       xor       r15d,r15d
       xor       ecx,ecx
       jmp       short M00_L02
M00_L05:
       call      qword ptr [7FF9CE587A80]
       int       3
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 343
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Email()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9CE5C91C8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+30]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_PostalCode()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9CE5C91C8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; System.Text.StringBuilder.AppendFormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0B8
       xor       eax,eax
       mov       [rsp+68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       vmovdqa   xmmword ptr [rsp+80],xmm4
       vmovdqa   xmmword ptr [rsp+90],xmm4
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,[r9]
       mov       r14d,[r9+8]
       test      rsi,rsi
       je        near ptr M03_L60
       test      rbx,rbx
       jne       near ptr M03_L31
       xor       edx,edx
M03_L00:
       mov       rcx,offset MT_System.ICustomFormatter
       call      qword ptr [7FF9CE31B888]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       r15,rax
       xor       r12d,r12d
M03_L01:
       mov       r13d,[rsi+8]
       cmp       r13d,r12d
       jbe       near ptr M03_L24
       mov       ecx,r12d
       cmp       r13d,ecx
       jb        near ptr M03_L44
       mov       edx,ecx
       lea       rax,[rsi+rdx*2+0C]
       mov       r10d,r13d
       sub       r10d,ecx
       mov       [rsp+38],rax
       mov       [rsp+90],r10d
       mov       rcx,rax
       mov       edx,7B
       mov       r8d,7D
       mov       r9d,r10d
       call      qword ptr [7FF9CE9D7000]; System.SpanHelpers.IndexOfAnyValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
       mov       [rsp+0AC],eax
       test      eax,eax
       jl        near ptr M03_L26
       cmp       eax,[rsp+90]
       ja        near ptr M03_L46
       mov       rcx,rdi
       mov       rdx,[rsp+38]
       mov       r8d,eax
       call      qword ptr [7FF9CE5BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       add       r12d,[rsp+0AC]
       cmp       r12d,r13d
       jae       near ptr M03_L63
       mov       edx,r12d
       movzx     edx,word ptr [rsi+rdx*2+0C]
       inc       r12d
       cmp       r13d,r12d
       jbe       near ptr M03_L59
       mov       ecx,r12d
       movzx     eax,word ptr [rsi+rcx*2+0C]
       cmp       edx,eax
       je        near ptr M03_L47
       cmp       edx,7B
       jne       near ptr M03_L59
       xor       r8d,r8d
       mov       [rsp+0B4],r8d
       xor       r9d,r9d
       mov       [rsp+0B0],r9d
       xor       r10d,r10d
       mov       [rsp+40],r10
       xor       r11d,r11d
       mov       [rsp+94],r11d
       add       eax,0FFFFFFD0
       cmp       eax,0A
       jae       near ptr M03_L59
       inc       r12d
       cmp       r13d,r12d
       jbe       near ptr M03_L59
       mov       edx,r12d
       movzx     edx,word ptr [rsi+rdx*2+0C]
       cmp       edx,7D
       jne       near ptr M03_L18
M03_L02:
       inc       r12d
       xor       r13d,r13d
       xor       ecx,ecx
       mov       [rsp+58],rcx
       cmp       eax,r14d
       jae       near ptr M03_L45
       mov       edx,eax
       mov       rdx,[rbp+rdx*8]
       mov       [rsp+50],rdx
       test      r15,r15
       jne       near ptr M03_L34
M03_L03:
       test      r13,r13
       jne       near ptr M03_L16
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FF9CE31B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       short M03_L05
M03_L04:
       mov       rdx,[rsp+50]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FF9CE31B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       [rsp+48],rax
       test      rax,rax
       jne       near ptr M03_L29
       mov       rdx,[rsp+50]
       test      rdx,rdx
       je        near ptr M03_L41
       mov       rcx,offset MT_System.String
       cmp       [rdx],rcx
       jne       near ptr M03_L17
       jmp       near ptr M03_L21
M03_L05:
       cmp       dword ptr [rsp+0B0],0
       jne       short M03_L06
       cmp       dword ptr [rsp+0B4],0
       jne       short M03_L04
M03_L06:
       mov       rcx,[rdi+8]
       mov       rdx,rcx
       mov       r9d,[rdi+18]
       mov       r10d,r9d
       mov       r11d,[rcx+8]
       sub       r11d,r9d
       mov       ecx,r10d
       mov       r9d,r11d
       add       rcx,r9
       mov       r9d,[rdx+8]
       cmp       rcx,r9
       ja        near ptr M03_L46
       mov       ecx,r10d
       lea       rcx,[rdx+rcx*2+10]
       mov       rdx,offset MT_System.Byte
       cmp       [rax],rdx
       jne       near ptr M03_L22
       add       rax,8
       mov       [rsp+8C],r11d
       mov       r10,[rsp+40]
       mov       rdx,r10
       mov       r9d,[rsp+94]
       mov       r11d,r9d
       movzx     eax,byte ptr [rax]
       mov       [rsp+30],rdx
       mov       edx,[rsp+8C]
       test      r11d,r11d
       jne       near ptr M03_L36
       mov       [rsp+88],edx
       mov       r11d,eax
       mov       edx,1
       cmp       r11d,186A0
       jae       near ptr M03_L39
M03_L07:
       cmp       r11d,0A
       jae       near ptr M03_L13
M03_L08:
       cmp       edx,0FFFFFFFF
       jg        near ptr M03_L27
       mov       edx,0FFFFFFFF
M03_L09:
       mov       r11d,[rsp+88]
       cmp       edx,r11d
       jg        near ptr M03_L38
       mov       [rsp+0A0],edx
       mov       [rsp+98],rcx
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
M03_L10:
       mov       edx,0CCCCCCCD
       mov       r11d,eax
       imul      rdx,r11
       shr       rdx,23
       lea       r11d,[rdx+rdx*4]
       add       r11d,r11d
       sub       eax,r11d
       add       rcx,0FFFFFFFFFFFFFFFE
       add       eax,30
       mov       [rcx],ax
       test      edx,edx
       mov       eax,edx
       jne       short M03_L10
       xor       ecx,ecx
       mov       [rsp+98],rcx
       mov       eax,1
M03_L11:
       xor       ecx,ecx
       mov       [rsp+98],rcx
M03_L12:
       jmp       near ptr M03_L23
M03_L13:
       cmp       r11d,64
       jae       near ptr M03_L28
       inc       edx
       jmp       near ptr M03_L08
M03_L14:
       cmp       edx,7D
       je        near ptr M03_L02
       cmp       edx,3A
       jne       near ptr M03_L59
       mov       r10d,r12d
M03_L15:
       inc       r12d
       cmp       r13d,r12d
       jbe       near ptr M03_L59
       mov       edx,r12d
       movzx     edx,word ptr [rsi+rdx*2+0C]
       cmp       edx,7D
       je        near ptr M03_L25
       cmp       edx,7B
       je        near ptr M03_L59
       jmp       short M03_L15
M03_L16:
       mov       r8d,[rsp+0B4]
       cmp       [r13+8],r8d
       jl        near ptr M03_L42
       mov       r8d,[r13+8]
       lea       rdx,[r13+0C]
       mov       rcx,rdi
       call      qword ptr [7FF9CE5BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       near ptr M03_L01
M03_L17:
       mov       rcx,rdx
       mov       rax,[rdx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rdx,rax
       jmp       short M03_L21
M03_L18:
       lea       ecx,[rdx-30]
       cmp       ecx,9
       jbe       near ptr M03_L32
M03_L19:
       cmp       edx,20
       je        near ptr M03_L51
M03_L20:
       cmp       edx,2C
       je        near ptr M03_L52
       jmp       near ptr M03_L14
M03_L21:
       test      rdx,rdx
       je        near ptr M03_L61
       mov       r13,rdx
       jmp       short M03_L16
M03_L22:
       mov       rdx,rax
       mov       [rsp+68],rcx
       mov       [rsp+70],r11d
       mov       r10,[rsp+40]
       mov       [rsp+78],r10
       mov       r9d,[rsp+94]
       mov       [rsp+80],r9d
       mov       [rsp+20],rbx
       mov       rcx,rdx
       lea       rdx,[rsp+68]
       lea       r9,[rsp+78]
       lea       r8,[rsp+0A0]
       mov       r11,7FF9CE170708
       call      qword ptr [r11]
M03_L23:
       test      eax,eax
       je        near ptr M03_L04
       mov       ecx,[rsp+0A0]
       mov       rdx,[rdi+8]
       mov       rax,rdx
       mov       r9d,[rdi+18]
       mov       r10d,r9d
       mov       edx,[rdx+8]
       sub       edx,r9d
       mov       r10d,r10d
       mov       r11d,edx
       add       r10,r11
       mov       eax,[rax+8]
       cmp       r10,rax
       ja        near ptr M03_L46
       cmp       ecx,edx
       ja        near ptr M03_L59
       add       r9d,[rsp+0A0]
       mov       [rdi+18],r9d
       cmp       dword ptr [rsp+0B0],0
       jne       near ptr M03_L62
       jmp       near ptr M03_L01
M03_L24:
       mov       rax,rdi
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L25:
       inc       r10d
       mov       r11d,r12d
       sub       r11d,r10d
       mov       ecx,r10d
       mov       edx,r11d
       add       rcx,rdx
       mov       edx,r13d
       cmp       rcx,rdx
       ja        near ptr M03_L44
       mov       r10d,r10d
       lea       r10,[rsi+r10*2+0C]
       mov       r13,r10
       mov       r10d,r11d
       mov       [rsp+94],r10d
       mov       [rsp+40],r13
       jmp       near ptr M03_L02
M03_L26:
       mov       rcx,rdi
       mov       rdx,[rsp+38]
       mov       r8d,[rsp+90]
       call      qword ptr [7FF9CE5BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       mov       rax,rdi
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L27:
       jmp       near ptr M03_L09
M03_L28:
       cmp       r11d,3E8
       jae       near ptr M03_L33
       add       edx,2
       jmp       near ptr M03_L08
M03_L29:
       mov       rax,[rsp+48]
       mov       edx,[rsp+94]
       test      edx,edx
       je        short M03_L30
       mov       r8,[rsp+58]
       test      r8,r8
       mov       [rsp+58],r8
       jne       short M03_L30
       mov       r9,[rsp+40]
       mov       [rsp+78],r9
       mov       [rsp+80],edx
       lea       rcx,[rsp+78]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       [rsp+58],rax
       mov       rax,[rsp+48]
M03_L30:
       mov       rcx,rax
       mov       r8,rbx
       mov       rdx,[rsp+58]
       mov       r11,7FF9CE170700
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M03_L21
M03_L31:
       mov       rcx,offset MT_System.ICustomFormatter
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rbx
       mov       r11,7FF9CE1706F8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M03_L00
M03_L32:
       cmp       eax,0F4240
       jge       near ptr M03_L50
       lea       eax,[rax+rax*4]
       lea       eax,[rdx+rax*2-30]
       inc       r12d
       cmp       r13d,r12d
       jbe       near ptr M03_L59
       mov       edx,r12d
       movzx     edx,word ptr [rsi+rdx*2+0C]
       jmp       near ptr M03_L18
M03_L33:
       cmp       r11d,2710
       jae       near ptr M03_L37
       add       edx,3
       jmp       near ptr M03_L08
M03_L34:
       cmp       dword ptr [rsp+94],0
       jne       near ptr M03_L40
M03_L35:
       mov       rcx,r15
       mov       r9,rbx
       mov       rdx,[rsp+58]
       mov       r8,[rsp+50]
       mov       r11,7FF9CE170710
       call      qword ptr [r11]
       mov       r13,rax
       mov       rdx,[rsp+50]
       jmp       near ptr M03_L03
M03_L36:
       mov       [rsp+64],eax
       mov       rax,[rsp+30]
       mov       [rsp+78],rax
       mov       [rsp+80],r11d
       mov       [rsp+68],rcx
       mov       [rsp+70],edx
       lea       rcx,[rsp+0A0]
       mov       [rsp+20],rcx
       mov       ecx,[rsp+64]
       lea       rdx,[rsp+78]
       mov       r8,rbx
       lea       r9,[rsp+68]
       call      qword ptr [7FF9CE555000]
       jmp       near ptr M03_L12
M03_L37:
       add       edx,4
       jmp       near ptr M03_L08
M03_L38:
       xor       ecx,ecx
       mov       [rsp+0A0],ecx
       xor       eax,eax
       jmp       near ptr M03_L11
M03_L39:
       mov       r11d,eax
       shr       r11d,5
       imul      r11,0A7C5AC5
       shr       r11,27
       mov       edx,6
       jmp       near ptr M03_L07
M03_L40:
       mov       r10,[rsp+40]
       mov       [rsp+78],r10
       mov       r11d,[rsp+94]
       mov       [rsp+80],r11d
       lea       rcx,[rsp+78]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r13,rax
       mov       [rsp+58],r13
       jmp       near ptr M03_L35
M03_L41:
       xor       edx,edx
       jmp       near ptr M03_L21
M03_L42:
       cmp       dword ptr [rsp+0B0],0
       je        short M03_L43
       mov       eax,[r13+8]
       lea       rdx,[r13+0C]
       mov       rcx,rdi
       mov       r8d,eax
       call      qword ptr [7FF9CE5BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       mov       eax,[rsp+0B4]
       mov       r8d,eax
       sub       r8d,[r13+8]
       mov       rcx,rdi
       mov       edx,20
       call      qword ptr [7FF9CE5BB258]
       jmp       near ptr M03_L01
M03_L43:
       mov       r8d,[rsp+0B4]
       sub       r8d,[r13+8]
       mov       rcx,rdi
       mov       edx,20
       call      qword ptr [7FF9CE5BB258]
       mov       r8d,[r13+8]
       lea       rdx,[r13+0C]
       mov       rcx,rdi
       call      qword ptr [7FF9CE5BB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       near ptr M03_L01
M03_L44:
       mov       ecx,21
       call      qword ptr [7FF9CE5877E0]
       int       3
M03_L45:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0C2B3
       mov       rdx,7FF9CE164000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CE3DD030]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CE64F450]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L46:
       call      qword ptr [7FF9CE587498]
       int       3
M03_L47:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M03_L48
       mov       ecx,ecx
       mov       [rdx+rcx*2+10],ax
       inc       dword ptr [rdi+18]
       jmp       short M03_L49
M03_L48:
       mov       rcx,rdi
       mov       edx,eax
       mov       r8d,1
       call      qword ptr [7FF9CE5BB258]
M03_L49:
       inc       r12d
       jmp       near ptr M03_L01
M03_L50:
       cmp       edx,20
       jne       near ptr M03_L20
M03_L51:
       inc       r12d
       cmp       r13d,r12d
       jbe       near ptr M03_L59
       mov       edx,r12d
       movzx     edx,word ptr [rsi+rdx*2+0C]
       jmp       near ptr M03_L19
M03_L52:
       inc       r12d
       cmp       r13d,r12d
       jbe       near ptr M03_L59
       mov       edx,r12d
       movzx     edx,word ptr [rsi+rdx*2+0C]
       cmp       edx,20
       je        short M03_L52
       cmp       edx,2D
       jne       short M03_L53
       mov       dword ptr [rsp+0B0],1
       inc       r12d
       cmp       r13d,r12d
       jbe       near ptr M03_L59
       mov       edx,r12d
       movzx     edx,word ptr [rsi+rdx*2+0C]
M03_L53:
       lea       r8d,[rdx-30]
       cmp       r8d,0A
       jae       near ptr M03_L59
       inc       r12d
       cmp       r13d,r12d
       jbe       short M03_L59
       mov       edx,r12d
       movzx     edx,word ptr [rsi+rdx*2+0C]
       jmp       short M03_L55
M03_L54:
       lea       r8d,[r8+r8*4]
       lea       r8d,[rdx+r8*2-30]
       mov       [rsp+0B4],r8d
       inc       r12d
       cmp       r13d,r12d
       jbe       short M03_L59
       mov       edx,r12d
       movzx     edx,word ptr [rsi+rdx*2+0C]
       mov       r8d,[rsp+0B4]
M03_L55:
       lea       ecx,[rdx-30]
       cmp       ecx,9
       ja        short M03_L57
       cmp       r8d,0F4240
       jl        short M03_L54
       cmp       edx,20
       jne       short M03_L58
M03_L56:
       inc       r12d
       cmp       r13d,r12d
       jbe       short M03_L59
       mov       edx,r12d
       movzx     edx,word ptr [rsi+rdx*2+0C]
M03_L57:
       cmp       edx,20
       je        short M03_L56
       mov       [rsp+0B4],r8d
       jmp       near ptr M03_L14
M03_L58:
       mov       [rsp+0B4],r8d
       jmp       near ptr M03_L14
M03_L59:
       call      qword ptr [7FF9CE587BB8]
       int       3
M03_L60:
       mov       ecx,31B
       mov       rdx,7FF9CE164000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CE58D960]
       int       3
M03_L61:
       mov       rdx,2346B802028
       mov       rdx,[rdx]
       mov       rax,rdx
       mov       r13,rax
       jmp       near ptr M03_L16
M03_L62:
       mov       r8d,[rsp+0B4]
       cmp       r8d,[rsp+0A0]
       jle       near ptr M03_L01
       sub       r8d,[rsp+0A0]
       mov       rcx,rdi
       mov       edx,20
       call      qword ptr [7FF9CE5BB258]
       jmp       near ptr M03_L01
M03_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2384
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
       call      qword ptr [7FF9CE3F99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2346B802028
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
       mov       rdx,7FF9CE164000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9CE164000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CE3DD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9CE555750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetPropertyValues01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.TypeHelper.GetPropertyValues[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Core.TypeHelper.GetPropertyValues[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Immutable.ImmutableDictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableDictionary`2<System.String,System.String> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 91
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,160
       lea       rbp,[rsp+160]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-120],xmm4
       vmovdqa   xmmword ptr [rbp-110],xmm4
       mov       rax,0FFFFFFFFFFFFFF10
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,7FF9C7886388
       mov       edx,7
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       dword ptr [7FF9C7885F48],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       lea       rcx,[rbp-10]
       lea       rdx,[rbp-18]
       lea       r8,[rbp-20]
       call      DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       nop
       lea       rdx,[rbp-40]
       mov       [rsp+20],rdx
       lea       rdx,[rbp-48]
       mov       [rsp+28],rdx
       lea       rdx,[rbp-58]
       mov       [rsp+30],rdx
       lea       rdx,[rbp-28]
       lea       r8,[rbp-30]
       lea       r9,[rbp-38]
       mov       rcx,[rbp-10]
       call      DotNetTips.Spargine.Tester.RandomData.GetRandomPersonData(DotNetTips.Spargine.Tester.Data.Country, System.String ByRef, System.String ByRef, System.String ByRef, System.String ByRef, System.String ByRef, System.DateTimeOffset ByRef)
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-78],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7A2FD18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M01_L03:
       mov       rcx,[rbp-78]
       call      System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rbp-80],rax
       mov       rax,[rbp-80]
       mov       [rbp-68],rax
       lea       rax,[rbp-68]
       mov       [rbp-88],rax
       call      DotNetTips.Spargine.Tester.RandomData.GenerateKey()
       mov       [rbp-90],rax
       mov       rcx,[rbp-88]
       mov       rcx,[rcx]
       mov       rdx,[rbp-90]
       mov       r11,7FF9C75D02C8
       call      qword ptr [7FF9C75D02C8]
       nop
       lea       rcx,[rbp-68]
       mov       [rbp-98],rcx
       mov       ecx,[rbp+18]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rcx]
       mov       rdx,[rbp-0A0]
       mov       r11,7FF9C75D02D0
       call      qword ptr [7FF9C75D02D0]
       nop
       lea       rcx,[rbp-68]
       mov       [rbp-0A8],rcx
       mov       ecx,[rbp+18]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-0A8]
       mov       rcx,[rcx]
       mov       rdx,[rbp-0B0]
       mov       r11,7FF9C75D02D8
       call      qword ptr [7FF9C75D02D8]
       nop
       mov       rcx,[rbp-68]
       mov       [rbp-120],rcx
       vmovupd   xmm0,[rbp-58]
       vmovupd   [rbp-118],xmm0
       mov       rcx,[rbp-120]
       lea       rdx,[rbp-118]
       mov       r11,7FF9C75D02E0
       call      qword ptr [7FF9C75D02E0]
       nop
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-40]
       mov       r11,7FF9C75D02E8
       call      qword ptr [7FF9C75D02E8]
       nop
       lea       rcx,[rbp-68]
       mov       [rbp-0B8],rcx
       mov       rcx,[rbp-0B8]
       mov       [rbp-0C0],rcx
       cmp       qword ptr [rbp-20],0
       je        short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Tester.Data.City.get_Name()
       mov       [rbp-108],rax
       mov       rcx,[rbp-0C0]
       mov       [rbp-0C8],rcx
       mov       rcx,[rbp-108]
       mov       [rbp-0D0],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp-0C0]
       mov       [rbp-0C8],rcx
       mov       rcx,1A933D33020
       mov       rcx,[rcx]
       mov       [rbp-0D0],rcx
M01_L05:
       mov       rcx,[rbp-0C8]
       mov       rcx,[rcx]
       mov       rdx,[rbp-0D0]
       mov       r11,7FF9C75D02F0
       call      qword ptr [7FF9C75D02F0]
       nop
       lea       rcx,[rbp-68]
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Tester.Data.Country.get_Name()
       mov       [rbp-0E0],rax
       mov       rcx,[rbp-0D8]
       mov       rcx,[rcx]
       mov       rdx,[rbp-0E0]
       mov       r11,7FF9C75D02F8
       call      qword ptr [7FF9C75D02F8]
       nop
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-48]
       mov       r11,7FF9C75D0300
       call      qword ptr [7FF9C75D0300]
       nop
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-28]
       mov       r11,7FF9C75D0308
       call      qword ptr [7FF9C75D0308]
       nop
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-38]
       mov       r11,7FF9C75D0310
       call      qword ptr [7FF9C75D0310]
       nop
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-30]
       mov       r11,7FF9C75D0318
       call      qword ptr [7FF9C75D0318]
       nop
       lea       rcx,[rbp-68]
       mov       [rbp-0E8],rcx
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       [rbp-0F0],rax
       mov       rcx,[rbp-0E8]
       mov       rcx,[rcx]
       mov       rdx,[rbp-0F0]
       mov       r11,7FF9C75D0320
       call      qword ptr [7FF9C75D0320]
       nop
       lea       rcx,[rbp-68]
       mov       [rbp-0F8],rcx
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Tester.Data.State.get_Name()
       mov       [rbp-100],rax
       mov       rcx,[rbp-0F8]
       mov       rcx,[rcx]
       mov       rdx,[rbp-100]
       mov       r11,7FF9C75D0328
       call      qword ptr [7FF9C75D0328]
       nop
       mov       rax,[rbp-68]
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       mov       [rbp-70],rax
       nop
       jmp       short M01_L06
M01_L06:
       mov       rax,[rbp-70]
       add       rsp,160
       pop       rbp
       ret
; Total bytes of code 991
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper.GetPropertyValues[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,1F0
       vzeroupper
       lea       rbp,[rsp+1F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1D0],xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C7886D08],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-60]
       mov       [rbp-10],rcx
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      System.Object.GetType()
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       call      DotNetTips.Spargine.Core.Extensions.GetAllProperties(System.Type)
       mov       [rbp-70],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-78],rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C65098
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M02_L03:
       mov       rcx,[rbp-78]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-70]
       mov       [rbp-88],rcx
       mov       rcx,[rbp-80]
       mov       [rbp-90],rcx
       cmp       qword ptr [rbp-80],0
       jne       near ptr M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-180],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C65098
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-180],rax
M02_L05:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-188],rax
       mov       rcx,[rbp-180]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       [rbp-198],rdx
       mov       rdx,[rbp-198]
       mov       rcx,[rbp-188]
       mov       r8,offset DotNetTips.Spargine.Core.TypeHelper+<>c__14`1[[System.__Canon, System.Private.CoreLib]].<GetPropertyValues>b__14_0(System.Reflection.PropertyInfo)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-190],rcx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C65098
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-190],rax
M02_L07:
       mov       rcx,[rbp-190]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,[rbp-188]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-188]
       mov       [rbp-90],r8
M02_L08:
       mov       r8,[rbp-90]
       mov       rdx,[rbp-88]
       mov       rcx,offset MD_System.Linq.Enumerable.Where[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-98],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L09
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C65098
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+10]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp-98]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B8],rcx
       cmp       qword ptr [rbp-0A8],0
       jne       near ptr M02_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L11
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-168],rcx
       jmp       short M02_L12
M02_L11:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C65098
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-168],rax
M02_L12:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-170],rax
       mov       rcx,[rbp-168]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       [rbp-1A0],rdx
       mov       rdx,[rbp-1A0]
       mov       rcx,[rbp-170]
       mov       r8,offset DotNetTips.Spargine.Core.TypeHelper+<>c__14`1[[System.__Canon, System.Private.CoreLib]].<GetPropertyValues>b__14_1(System.Reflection.PropertyInfo)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-178],rcx
       jmp       short M02_L14
M02_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C65098
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-178],rax
M02_L14:
       mov       rcx,[rbp-178]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+10]
       mov       rdx,[rbp-170]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-170]
       mov       [rbp-0B8],r8
M02_L15:
       mov       r8,[rbp-0B8]
       mov       rdx,[rbp-0B0]
       mov       rcx,offset MD_System.Linq.Enumerable.OrderBy[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,System.String>)
       call      System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       [rbp-0C0],rax
       mov       rdx,[rbp-0C0]
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-0C8],rax
       mov       rcx,[rbp-0C8]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       near ptr M02_L25
M02_L16:
       nop
       mov       rcx,[rbp-18]
       mov       eax,[rbp-1C]
       cmp       eax,[rcx+8]
       jb        short M02_L17
       call      CORINFO_HELP_RNGCHKFAIL
M02_L17:
       mov       edx,eax
       lea       rcx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       [rbp-28],rcx
       mov       rcx,[rbp-28]
       mov       rax,[rbp-28]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rax,[rbp-0D0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-0D8],rax
       mov       rdx,1A9A3D31B78
       mov       rdx,[rdx]
       mov       rcx,[rbp-0D8]
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       mov       [rbp-0DC],eax
       mov       ecx,[rbp-0DC]
       movzx     ecx,cl
       mov       [rbp-2C],ecx
       cmp       dword ptr [rbp-2C],0
       je        near ptr M02_L21
       nop
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      System.Reflection.PropertyInfo.GetValue(System.Object)
       mov       [rbp-120],rax
       mov       rdx,[rbp-120]
       mov       rcx,offset MT_System.Collections.IDictionary
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       [rbp-38],rax
       cmp       qword ptr [rbp-38],0
       jne       short M02_L18
       xor       ecx,ecx
       mov       [rbp-128],ecx
       jmp       short M02_L19
M02_L18:
       mov       rcx,[rbp-38]
       mov       r11,7FF9C75D0688
       call      qword ptr [7FF9C75D0688]
       mov       [rbp-124],eax
       cmp       dword ptr [rbp-124],0
       setg      cl
       movzx     ecx,cl
       mov       [rbp-128],ecx
M02_L19:
       mov       ecx,[rbp-128]
       movzx     ecx,cl
       mov       [rbp-3C],ecx
       cmp       dword ptr [rbp-3C],0
       je        near ptr M02_L20
       nop
       mov       rcx,[rbp-10]
       mov       [rbp-130],rcx
       mov       rcx,[rbp-28]
       mov       rax,[rbp-28]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-138],rax
       mov       rcx,[rbp-38]
       mov       edx,2C
       call      DotNetTips.Spargine.Core.Extensions.ToDelimitedString(System.Collections.IDictionary, Char)
       mov       [rbp-140],rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-150],xmm0
       lea       rcx,[rbp-150]
       mov       r9,[rbp-140]
       mov       r8,[rbp-138]
       mov       rdx,offset MT_System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, System.__Canon)
       mov       r8,[rbp-130]
       mov       [rbp-1B8],r8
       vmovdqu   xmm0,xmmword ptr [rbp-150]
       vmovdqu   xmmword ptr [rbp-1B0],xmm0
       lea       r8,[rbp-1B0]
       mov       rdx,[rbp-1B8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       call      DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       [rbp-154],eax
       nop
       nop
M02_L20:
       nop
       nop
       jmp       near ptr M02_L23
M02_L21:
       nop
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      System.Reflection.PropertyInfo.GetValue(System.Object)
       mov       [rbp-0E8],rax
       mov       rcx,[rbp-0E8]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       setne     cl
       movzx     ecx,cl
       mov       [rbp-4C],ecx
       cmp       dword ptr [rbp-4C],0
       je        near ptr M02_L22
       nop
       mov       rcx,[rbp-10]
       mov       [rbp-0F0],rcx
       mov       rcx,[rbp-28]
       mov       rax,[rbp-28]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-0F8],rax
       mov       rcx,[rbp-48]
       mov       rax,[rbp-48]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-100],rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-110],xmm0
       lea       rcx,[rbp-110]
       mov       r9,[rbp-100]
       mov       r8,[rbp-0F8]
       mov       rdx,offset MT_System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, System.__Canon)
       mov       r8,[rbp-0F0]
       mov       [rbp-1D0],r8
       vmovdqu   xmm0,xmmword ptr [rbp-110]
       vmovdqu   xmmword ptr [rbp-1C8],xmm0
       lea       r8,[rbp-1C8]
       mov       rdx,[rbp-1D0]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       call      DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       [rbp-114],eax
       nop
       nop
M02_L22:
       nop
M02_L23:
       nop
       mov       edx,[rbp-1C]
       add       edx,1
       jno       short M02_L24
       call      CORINFO_HELP_OVERFLOW
M02_L24:
       mov       [rbp-1C],edx
M02_L25:
       mov       ecx,[rbp-1C]
       mov       rax,[rbp-18]
       cmp       ecx,[rax+8]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-50],ecx
       cmp       dword ptr [rbp-50],0
       jne       near ptr M02_L16
       mov       rdx,[rbp-10]
       mov       rcx,offset MD_System.Collections.Immutable.ImmutableDictionary.ToImmutableDictionary[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      System.Collections.Immutable.ImmutableDictionary.ToImmutableDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-160],rax
       mov       rax,[rbp-160]
       mov       [rbp-58],rax
       nop
       jmp       short M02_L26
M02_L26:
       mov       rax,[rbp-58]
       add       rsp,1F0
       pop       rbp
       ret
; Total bytes of code 1788
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
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetPropertyValues01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       edx,19
       call      qword ptr [7FF9CE731948]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.TypeHelper.GetPropertyValues[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9CE9BB9C0]; DotNetTips.Spargine.Core.TypeHelper.GetPropertyValues[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Immutable.ImmutableDictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableDictionary`2<System.String,System.String> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE9D7F90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 94
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,160
       lea       rbp,[rsp+160]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-120],xmm4
       vmovdqa   xmmword ptr [rbp-110],xmm4
       mov       rax,0FFFFFFFFFFFFFF10
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,7FF9CE5A95C8
       mov       edx,7
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       dword ptr [7FF9CE5A91C8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       lea       rcx,[rbp-10]
       lea       rdx,[rbp-18]
       lea       r8,[rbp-20]
       call      qword ptr [7FF9CE6FF150]; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       nop
       lea       rdx,[rbp-40]
       mov       [rsp+20],rdx
       lea       rdx,[rbp-48]
       mov       [rsp+28],rdx
       lea       rdx,[rbp-58]
       mov       [rsp+30],rdx
       lea       rdx,[rbp-28]
       lea       r8,[rbp-30]
       lea       r9,[rbp-38]
       mov       rcx,[rbp-10]
       call      qword ptr [7FF9CE6FF168]; DotNetTips.Spargine.Tester.RandomData.GetRandomPersonData(DotNetTips.Spargine.Tester.Data.Country, System.String ByRef, System.String ByRef, System.String ByRef, System.String ByRef, System.String ByRef, System.DateTimeOffset ByRef)
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-78],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CE751168
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M01_L03:
       mov       rcx,[rbp-78]
       call      qword ptr [7FF9CE6F59F0]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       [rbp-80],rax
       mov       rax,[rbp-80]
       mov       [rbp-68],rax
       lea       rax,[rbp-68]
       mov       [rbp-88],rax
       call      qword ptr [7FF9CE6FF360]; DotNetTips.Spargine.Tester.RandomData.GenerateKey()
       mov       [rbp-90],rax
       mov       rcx,[rbp-88]
       mov       rcx,[rcx]
       mov       rdx,[rbp-90]
       mov       r11,7FF9CE1502C8
       call      qword ptr [r11]
       nop
       lea       rcx,[rbp-68]
       mov       [rbp-98],rcx
       mov       ecx,[rbp+18]
       call      qword ptr [7FF9CE6FF528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-98]
       mov       rcx,[rcx]
       mov       rdx,[rbp-0A0]
       mov       r11,7FF9CE1502D0
       call      qword ptr [r11]
       nop
       lea       rcx,[rbp-68]
       mov       [rbp-0A8],rcx
       mov       ecx,[rbp+18]
       call      qword ptr [7FF9CE6FF528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-0A8]
       mov       rcx,[rcx]
       mov       rdx,[rbp-0B0]
       mov       r11,7FF9CE1502D8
       call      qword ptr [r11]
       nop
       mov       rcx,[rbp-68]
       mov       [rbp-120],rcx
       vmovupd   xmm0,[rbp-58]
       vmovupd   [rbp-118],xmm0
       mov       rcx,[rbp-120]
       lea       rdx,[rbp-118]
       mov       r11,7FF9CE1502E0
       call      qword ptr [r11]
       nop
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-40]
       mov       r11,7FF9CE1502E8
       call      qword ptr [r11]
       nop
       lea       rcx,[rbp-68]
       mov       [rbp-0B8],rcx
       mov       rcx,[rbp-0B8]
       mov       [rbp-0C0],rcx
       cmp       qword ptr [rbp-20],0
       je        short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE7616C0]; DotNetTips.Spargine.Tester.Data.City.get_Name()
       mov       [rbp-108],rax
       mov       rcx,[rbp-0C0]
       mov       [rbp-0C8],rcx
       mov       rcx,[rbp-108]
       mov       [rbp-0D0],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp-0C0]
       mov       [rbp-0C8],rcx
       mov       rcx,1D953402028
       mov       rcx,[rcx]
       mov       [rbp-0D0],rcx
M01_L05:
       mov       rcx,[rbp-0C8]
       mov       rcx,[rcx]
       mov       rdx,[rbp-0D0]
       mov       r11,7FF9CE1502F0
       call      qword ptr [r11]
       nop
       lea       rcx,[rbp-68]
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE761210]; DotNetTips.Spargine.Tester.Data.Country.get_Name()
       mov       [rbp-0E0],rax
       mov       rcx,[rbp-0D8]
       mov       rcx,[rcx]
       mov       rdx,[rbp-0E0]
       mov       r11,7FF9CE1502F8
       call      qword ptr [r11]
       nop
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-48]
       mov       r11,7FF9CE150300
       call      qword ptr [r11]
       nop
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-28]
       mov       r11,7FF9CE150308
       call      qword ptr [r11]
       nop
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-38]
       mov       r11,7FF9CE150310
       call      qword ptr [r11]
       nop
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-30]
       mov       r11,7FF9CE150318
       call      qword ptr [r11]
       nop
       lea       rcx,[rbp-68]
       mov       [rbp-0E8],rcx
       mov       rcx,[rbp-10]
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CE6FF138]; DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       [rbp-0F0],rax
       mov       rcx,[rbp-0E8]
       mov       rcx,[rcx]
       mov       rdx,[rbp-0F0]
       mov       r11,7FF9CE150320
       call      qword ptr [r11]
       nop
       lea       rcx,[rbp-68]
       mov       [rbp-0F8],rcx
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE761588]; DotNetTips.Spargine.Tester.Data.State.get_Name()
       mov       [rbp-100],rax
       mov       rcx,[rbp-0F8]
       mov       rcx,[rcx]
       mov       rdx,[rbp-100]
       mov       r11,7FF9CE150328
       call      qword ptr [r11]
       nop
       mov       rax,[rbp-68]
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       mov       [rbp-70],rax
       nop
       mov       rax,[rbp-70]
       add       rsp,160
       pop       rbp
       ret
; Total bytes of code 960
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper.GetPropertyValues[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,1F0
       vzeroupper
       lea       rbp,[rsp+1F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1D0],xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9CE5A9F50],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       call      qword ptr [7FF9CE39B000]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-60]
       mov       [rbp-10],rcx
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      System.Object.GetType()
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       call      qword ptr [7FF9CE93F540]; DotNetTips.Spargine.Core.Extensions.GetAllProperties(System.Type)
       mov       [rbp-70],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-78],rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CE9993F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M02_L03:
       mov       rcx,[rbp-78]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+8]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-70]
       mov       [rbp-88],rcx
       mov       rcx,[rbp-80]
       mov       [rbp-90],rcx
       cmp       qword ptr [rbp-80],0
       jne       near ptr M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-180],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CE9993F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-180],rax
M02_L05:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-188],rax
       mov       rcx,[rbp-180]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       [rbp-198],rdx
       mov       rdx,[rbp-198]
       mov       rcx,[rbp-188]
       mov       r8,7FF9CE9BAAB0
       call      qword ptr [7FF9CE2FB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-190],rcx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CE9993F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-190],rax
M02_L07:
       mov       rcx,[rbp-190]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,[rbp-188]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-188]
       mov       [rbp-90],r8
M02_L08:
       mov       r8,[rbp-90]
       mov       rdx,[rbp-88]
       mov       rcx,offset MD_System.Linq.Enumerable.Where[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,Boolean>)
       call      qword ptr [7FF9CE68DCF0]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-98],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L09
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CE9993F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rcx,[rax+10]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp-98]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B8],rcx
       cmp       qword ptr [rbp-0A8],0
       jne       near ptr M02_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L11
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-168],rcx
       jmp       short M02_L12
M02_L11:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CE9993F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-168],rax
M02_L12:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-170],rax
       mov       rcx,[rbp-168]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       [rbp-1A0],rdx
       mov       rdx,[rbp-1A0]
       mov       rcx,[rbp-170]
       mov       r8,7FF9CE9BAAC8
       call      qword ptr [7FF9CE2FB648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-178],rcx
       jmp       short M02_L14
M02_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CE9993F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-178],rax
M02_L14:
       mov       rcx,[rbp-178]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+10]
       mov       rdx,[rbp-170]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-170]
       mov       [rbp-0B8],r8
M02_L15:
       mov       r8,[rbp-0B8]
       mov       rdx,[rbp-0B0]
       mov       rcx,offset MD_System.Linq.Enumerable.OrderBy[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,System.String>)
       call      qword ptr [7FF9CE6B5270]; System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       [rbp-0C0],rax
       mov       rdx,[rbp-0C0]
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>)
       call      qword ptr [7FF9CE6B7D98]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-0C8],rax
       mov       rcx,[rbp-0C8]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       near ptr M02_L25
M02_L16:
       nop
       mov       rcx,[rbp-18]
       mov       eax,[rbp-1C]
       cmp       eax,[rcx+8]
       jb        short M02_L17
       call      CORINFO_HELP_RNGCHKFAIL
M02_L17:
       mov       edx,eax
       lea       rcx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       [rbp-28],rcx
       mov       rcx,[rbp-28]
       mov       rax,[rbp-28]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rax,[rbp-0D0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-0D8],rax
       mov       rdx,1D965400BB0
       mov       rdx,[rdx]
       mov       rcx,[rbp-0D8]
       mov       r8d,4
       call      qword ptr [7FF9CE391378]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       [rbp-0DC],eax
       mov       ecx,[rbp-0DC]
       movzx     ecx,cl
       mov       [rbp-2C],ecx
       cmp       dword ptr [rbp-2C],0
       je        near ptr M02_L21
       nop
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE6851B0]; System.Reflection.PropertyInfo.GetValue(System.Object)
       mov       [rbp-120],rax
       mov       rdx,[rbp-120]
       mov       rcx,offset MT_System.Collections.IDictionary
       call      qword ptr [7FF9CE2FB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       [rbp-38],rax
       cmp       qword ptr [rbp-38],0
       jne       short M02_L18
       xor       ecx,ecx
       mov       [rbp-128],ecx
       jmp       short M02_L19
M02_L18:
       mov       rcx,[rbp-38]
       mov       r11,7FF9CE150630
       call      qword ptr [r11]
       mov       [rbp-124],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-124],0
       setg      cl
       mov       [rbp-128],ecx
M02_L19:
       mov       ecx,[rbp-128]
       movzx     ecx,cl
       mov       [rbp-3C],ecx
       cmp       dword ptr [rbp-3C],0
       je        near ptr M02_L20
       nop
       mov       rcx,[rbp-10]
       mov       [rbp-130],rcx
       mov       rcx,[rbp-28]
       mov       rax,[rbp-28]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-138],rax
       mov       rcx,[rbp-38]
       mov       edx,2C
       call      qword ptr [7FF9CE93F600]
       mov       [rbp-140],rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-150],xmm0
       lea       rcx,[rbp-150]
       mov       r9,[rbp-140]
       mov       r8,[rbp-138]
       mov       rdx,offset MT_System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      qword ptr [7FF9CE39B7C8]; System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, System.__Canon)
       mov       r8,[rbp-130]
       mov       [rbp-1B8],r8
       vmovdqu   xmm0,xmmword ptr [rbp-150]
       vmovdqu   xmmword ptr [rbp-1B0],xmm0
       lea       r8,[rbp-1B0]
       mov       rdx,[rbp-1B8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       call      qword ptr [7FF9CE9BBB70]; DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       [rbp-154],eax
       nop
       nop
M02_L20:
       nop
       nop
       jmp       near ptr M02_L23
M02_L21:
       nop
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CE6851B0]; System.Reflection.PropertyInfo.GetValue(System.Object)
       mov       [rbp-0E8],rax
       mov       rcx,[rbp-0E8]
       mov       [rbp-48],rcx
       xor       ecx,ecx
       cmp       qword ptr [rbp-48],0
       setne     cl
       mov       [rbp-4C],ecx
       cmp       dword ptr [rbp-4C],0
       je        near ptr M02_L22
       nop
       mov       rcx,[rbp-10]
       mov       [rbp-0F0],rcx
       mov       rcx,[rbp-28]
       mov       rax,[rbp-28]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-0F8],rax
       mov       rcx,[rbp-48]
       mov       rax,[rbp-48]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-100],rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-110],xmm0
       lea       rcx,[rbp-110]
       mov       r9,[rbp-100]
       mov       r8,[rbp-0F8]
       mov       rdx,offset MT_System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      qword ptr [7FF9CE39B7C8]; System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, System.__Canon)
       mov       r8,[rbp-0F0]
       mov       [rbp-1D0],r8
       vmovdqu   xmm0,xmmword ptr [rbp-110]
       vmovdqu   xmmword ptr [rbp-1C8],xmm0
       lea       r8,[rbp-1C8]
       mov       rdx,[rbp-1D0]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       call      qword ptr [7FF9CE9BBB70]; DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       [rbp-114],eax
       nop
       nop
M02_L22:
       nop
M02_L23:
       nop
       mov       edx,[rbp-1C]
       add       edx,1
       jno       short M02_L24
       call      CORINFO_HELP_OVERFLOW
M02_L24:
       mov       [rbp-1C],edx
M02_L25:
       mov       ecx,[rbp-1C]
       mov       rax,[rbp-18]
       cmp       ecx,[rax+8]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-50],ecx
       cmp       dword ptr [rbp-50],0
       jne       near ptr M02_L16
       mov       rdx,[rbp-10]
       mov       rcx,offset MD_System.Collections.Immutable.ImmutableDictionary.ToImmutableDictionary[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF9CE9BBD98]; System.Collections.Immutable.ImmutableDictionary.ToImmutableDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       [rbp-160],rax
       mov       rax,[rbp-160]
       mov       [rbp-58],rax
       nop
       mov       rax,[rbp-58]
       add       rsp,1F0
       pop       rbp
       ret
; Total bytes of code 1798
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

