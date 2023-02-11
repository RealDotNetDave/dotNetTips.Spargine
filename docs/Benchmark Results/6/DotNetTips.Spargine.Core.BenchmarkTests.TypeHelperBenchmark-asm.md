## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       jmp       short M00_L01
M00_L00:
       mov       rdx,1B8879E1568
       mov       r15,[rdx]
       mov       r12,[rcx+30]
       mov       r13,[rcx+58]
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rcx,7FF7B99B4928
       mov       edx,184
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1B8879E1388
       mov       rcx,[rcx]
       mov       rdx,r15
       mov       r8,1B8479E84A8
       mov       r8,[r8]
       mov       [rsp+30],r12
       mov       [rsp+38],r13
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
       movsxd    rdx,r14d
       mov       rcx,[rcx+rdx*8+10]
       inc       r14d
       mov       edx,1
       jmp       short M00_L04
M00_L02:
       cmp       ebp,[rbx+14]
       jne       short M00_L05
M00_L03:
       mov       r14d,[rbx+10]
       inc       r14d
       xor       ecx,ecx
       xor       edx,edx
M00_L04:
       test      edx,edx
       jne       near ptr M00_L00
       mov       rcx,rdi
       call      qword ptr [7FF7B9B5AC58]; System.Text.StringBuilder.ToString()
       mov       [rsp+50],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+50]
       call      CORINFO_HELP_ASSIGN_REF
       nop
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
; Total bytes of code 357
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
       je        near ptr M01_L52
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       mov       r12d,r15d
       xor       r13d,r13d
       test      rbp,rbp
       je        short M01_L00
       mov       rcx,offset MT_System.ICustomFormatter
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7B98B0550
       call      qword ptr [7FF7B98B0550]
       mov       rdx,rax
       mov       rcx,offset MT_System.ICustomFormatter
       call      CORINFO_HELP_CHKCASTINTERFACE
       mov       r13,rax
M01_L00:
       cmp       r14d,r12d
       jge       short M01_L05
M01_L01:
       cmp       r14d,r15d
       jae       near ptr M01_L68
       movsxd    rcx,r14d
       movzx     eax,word ptr [rsi+rcx*2+0C]
       inc       r14d
       cmp       eax,7D
       je        near ptr M01_L53
       cmp       eax,7B
       jne       short M01_L03
       cmp       r14d,r12d
       jge       short M01_L02
       cmp       r14d,r15d
       jae       near ptr M01_L68
       movsxd    rcx,r14d
       cmp       word ptr [rsi+rcx*2+0C],7B
       je        near ptr M01_L54
M01_L02:
       dec       r14d
       jmp       short M01_L05
M01_L03:
       mov       ecx,[rdi+18]
       mov       edx,ecx
       mov       r8,[rdi+8]
       cmp       [r8+8],edx
       jbe       near ptr M01_L17
       movsxd    rdx,edx
       mov       [r8+rdx*2+10],ax
       inc       ecx
       mov       [rdi+18],ecx
M01_L04:
       cmp       r14d,r12d
       jl        short M01_L01
M01_L05:
       cmp       r14d,r12d
       je        near ptr M01_L37
       inc       r14d
       cmp       r14d,r12d
       je        near ptr M01_L66
       cmp       r14d,r15d
       jae       near ptr M01_L68
       movsxd    rax,r14d
       movzx     eax,word ptr [rsi+rax*2+0C]
       cmp       eax,30
       jl        near ptr M01_L66
       cmp       eax,39
       jg        near ptr M01_L66
       xor       edx,edx
M01_L06:
       lea       edx,[rdx+rdx*4]
       lea       edx,[rax+rdx*2-30]
       inc       r14d
       cmp       r14d,r12d
       je        near ptr M01_L66
       cmp       r14d,r15d
       jae       near ptr M01_L68
       movsxd    rax,r14d
       movzx     eax,word ptr [rsi+rax*2+0C]
       cmp       eax,30
       jl        short M01_L07
       cmp       eax,39
       jg        short M01_L07
       cmp       edx,0F4240
       jl        short M01_L06
M01_L07:
       mov       rcx,[rbx+18]
       cmp       [rcx+8],edx
       jle       near ptr M01_L55
M01_L08:
       cmp       r14d,r12d
       jge       short M01_L09
       cmp       r14d,r15d
       jae       near ptr M01_L68
       movsxd    rax,r14d
       movzx     eax,word ptr [rsi+rax*2+0C]
       cmp       eax,20
       jne       short M01_L09
       inc       r14d
       jmp       short M01_L08
M01_L09:
       xor       r8d,r8d
       mov       [rsp+0B0],r8d
       xor       r9d,r9d
       mov       [rsp+0AC],r9d
       cmp       eax,2C
       je        near ptr M01_L56
M01_L10:
       cmp       r14d,r12d
       jge       short M01_L11
       cmp       r14d,r15d
       jae       near ptr M01_L68
       movsxd    rax,r14d
       movzx     eax,word ptr [rsi+rax*2+0C]
       mov       [rsp+0B4],eax
       cmp       eax,20
       mov       eax,[rsp+0B4]
       je        near ptr M01_L62
M01_L11:
       test      edx,edx
       jne       near ptr M01_L16
       mov       r10,[rbx]
M01_L12:
       mov       [rsp+50],r10
       xor       r11d,r11d
       xor       edx,edx
       cmp       eax,3A
       jne       near ptr M01_L24
       inc       r14d
       mov       ecx,r14d
M01_L13:
       cmp       r14d,r12d
       je        near ptr M01_L66
       cmp       r14d,r15d
       jae       near ptr M01_L68
       movsxd    rax,r14d
       movzx     eax,word ptr [rsi+rax*2+0C]
       cmp       eax,7D
       je        near ptr M01_L23
       cmp       eax,7B
       je        near ptr M01_L66
       inc       r14d
       jmp       short M01_L13
M01_L14:
       mov       rcx,r13
       mov       r9,rbp
       mov       [rsp+40],rax
       mov       rdx,rax
       mov       r8,r10
       mov       r11,7FF7B98B0548
       call      qword ptr [7FF7B98B0548]
       mov       r10,rax
       mov       rcx,r10
       mov       rax,[rsp+40]
       mov       edx,[rsp+94]
       mov       r10,[rsp+50]
       mov       r11,[rsp+30]
M01_L15:
       mov       [rsp+48],rcx
       test      rcx,rcx
       jne       near ptr M01_L49
       jmp       short M01_L18
M01_L16:
       mov       [rsp+0B4],eax
       mov       rcx,rbx
       call      System.ParamsArray.GetAtSlow(Int32)
       mov       r10,rax
       mov       eax,[rsp+0B4]
       jmp       near ptr M01_L12
M01_L17:
       mov       rcx,rdi
       mov       edx,eax
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M01_L04
M01_L18:
       mov       [rsp+94],edx
       mov       [rsp+30],r11
       mov       [rsp+40],rax
       mov       rdx,r10
       mov       rcx,offset MT_System.ISpanFormattable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        near ptr M01_L39
       cmp       dword ptr [rsp+0B0],0
       jne       near ptr M01_L21
       cmp       dword ptr [rsp+0AC],0
       jne       near ptr M01_L39
       mov       [rsp+58],r13
M01_L19:
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
       ja        near ptr M01_L65
       add       r9,10
       mov       edx,r11d
       lea       r11,[r9+rdx*2]
       mov       r9,offset MT_System.Byte
       cmp       [rax],r9
       jne       near ptr M01_L38
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
       jne       near ptr M01_L40
       mov       [rsp+8C],edx
       mov       ecx,eax
       mov       edx,1
       cmp       eax,186A0
       jae       short M01_L22
M01_L20:
       cmp       ecx,0A
       jb        near ptr M01_L29
       cmp       ecx,64
       jae       near ptr M01_L26
       inc       edx
       jmp       near ptr M01_L29
M01_L21:
       mov       [rsp+58],r13
       jmp       near ptr M01_L19
M01_L22:
       mov       ecx,eax
       shr       ecx,5
       imul      rcx,0A7C5AC5
       shr       rcx,27
       mov       edx,6
       jmp       short M01_L20
M01_L23:
       cmp       r14d,ecx
       jle       short M01_L25
       mov       edx,r14d
       sub       edx,ecx
       mov       r11d,ecx
       mov       eax,edx
       add       rax,r11
       mov       r11d,r15d
       cmp       rax,r11
       ja        near ptr M01_L63
       lea       rax,[rsi+0C]
       mov       ecx,ecx
       lea       r11,[rax+rcx*2]
       mov       [rsp+30],r11
       mov       [rsp+94],edx
       mov       edx,[rsp+94]
       mov       r11,[rsp+30]
       jmp       short M01_L25
M01_L24:
       cmp       eax,7D
       jne       near ptr M01_L66
M01_L25:
       inc       r14d
       xor       ecx,ecx
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+58],r13
       test      r13,r13
       mov       rax,[rsp+40]
       mov       r13,[rsp+58]
       je        near ptr M01_L15
       mov       [rsp+94],edx
       test      edx,edx
       jne       near ptr M01_L64
       mov       [rsp+30],r11
       jmp       near ptr M01_L14
M01_L26:
       cmp       ecx,3E8
       jae       short M01_L27
       add       edx,2
       jmp       short M01_L29
M01_L27:
       cmp       ecx,2710
       jae       short M01_L28
       add       edx,3
       jmp       short M01_L29
M01_L28:
       add       edx,4
M01_L29:
       cmp       edx,0FFFFFFFF
       jle       short M01_L30
       mov       ecx,edx
       jmp       short M01_L31
M01_L30:
       mov       ecx,0FFFFFFFF
M01_L31:
       mov       edx,[rsp+8C]
       cmp       ecx,edx
       jg        near ptr M01_L36
       mov       [rsp+0A0],ecx
       mov       [rsp+98],r11
       movsxd    rcx,ecx
       lea       rcx,[r11+rcx*2]
M01_L32:
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
       jne       short M01_L32
       xor       eax,eax
       mov       [rsp+98],rax
       mov       r11d,1
M01_L33:
       xor       eax,eax
       mov       [rsp+98],rax
M01_L34:
       test      r11d,r11d
       mov       [rsp+94],r9d
       je        short M01_L35
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
       ja        near ptr M01_L65
       cmp       eax,r9d
       ja        near ptr M01_L66
       add       edx,[rsp+0A0]
       mov       [rdi+18],edx
       mov       r8d,[rsp+0AC]
       sub       r8d,[rsp+0A0]
       cmp       dword ptr [rsp+0B0],0
       jne       near ptr M01_L67
       mov       r13,[rsp+58]
       jmp       near ptr M01_L00
M01_L35:
       mov       r13,[rsp+58]
       jmp       near ptr M01_L39
M01_L36:
       xor       r11d,r11d
       mov       [rsp+0A0],r11d
       jmp       near ptr M01_L33
M01_L37:
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
M01_L38:
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
       mov       r11,7FF7B98B0540
       call      qword ptr [7FF7B98B0540]
       mov       r11d,eax
       mov       [rsp+30],r13
       mov       r9d,[rsp+94]
       jmp       near ptr M01_L34
M01_L39:
       mov       rdx,[rsp+50]
       mov       rcx,offset MT_System.IFormattable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       [rsp+38],rax
       test      rax,rax
       je        near ptr M01_L48
       jmp       near ptr M01_L44
M01_L40:
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
       jmp       near ptr M01_L34
M01_L41:
       mov       r9d,[rsp+0AC]
       mov       [rsp+48],rcx
       mov       eax,r9d
       sub       eax,[rcx+8]
       cmp       dword ptr [rsp+0B0],0
       jne       short M01_L43
       mov       [rsp+0A8],eax
       test      eax,eax
       jg        near ptr M01_L50
M01_L42:
       mov       rcx,rdi
       mov       rdx,[rsp+48]
       call      System.Text.StringBuilder.Append(System.String)
       cmp       dword ptr [rsp+0B0],0
       jne       near ptr M01_L51
       jmp       near ptr M01_L00
M01_L43:
       mov       [rsp+0A8],eax
       jmp       short M01_L42
M01_L44:
       mov       r8d,[rsp+94]
       test      r8d,r8d
       je        short M01_L45
       mov       r9,[rsp+40]
       test      r9,r9
       mov       [rsp+40],r9
       jne       short M01_L45
       mov       r10,[rsp+30]
       mov       [rsp+78],r10
       mov       [rsp+80],r8d
       lea       rdx,[rsp+78]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       [rsp+40],rax
M01_L45:
       mov       rcx,offset MT_System.Byte
       mov       rax,[rsp+38]
       cmp       [rax],rcx
       jne       short M01_L46
       add       rax,8
       movzx     ecx,byte ptr [rax]
       mov       rdx,[rsp+40]
       mov       r8,rbp
       call      System.Number.FormatUInt32(UInt32, System.String, System.IFormatProvider)
       mov       r10,rax
       jmp       short M01_L47
M01_L46:
       mov       rcx,rax
       mov       r8,rbp
       mov       rdx,[rsp+40]
       mov       r11,7FF7B98B0538
       call      qword ptr [7FF7B98B0538]
       mov       r10,rax
M01_L47:
       mov       rax,r10
       mov       [rsp+48],rax
       jmp       short M01_L49
M01_L48:
       mov       rdx,[rsp+50]
       test      rdx,rdx
       je        short M01_L49
       mov       rcx,rdx
       mov       rax,[rdx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rsp+48],rax
M01_L49:
       mov       rcx,[rsp+48]
       test      rcx,rcx
       jne       near ptr M01_L41
       mov       rcx,1B8479E1028
       mov       rdx,[rcx]
       mov       [rsp+48],rdx
       mov       rcx,[rsp+48]
       jmp       near ptr M01_L41
M01_L50:
       mov       eax,[rsp+0A8]
       mov       rcx,rdi
       mov       [rsp+0A8],eax
       mov       r8d,eax
       mov       edx,20
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M01_L42
M01_L51:
       mov       edx,[rsp+0A8]
       test      edx,edx
       jle       near ptr M01_L00
       mov       rcx,rdi
       mov       r8d,edx
       mov       edx,20
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M01_L00
M01_L52:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       ecx,31B
       mov       rdx,7FF7B98A4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L53:
       cmp       r14d,r12d
       jge       near ptr M01_L66
       cmp       r14d,r15d
       jae       near ptr M01_L68
       movsxd    rcx,r14d
       cmp       word ptr [rsi+rcx*2+0C],7D
       jne       near ptr M01_L66
       inc       r14d
       jmp       near ptr M01_L03
M01_L54:
       inc       r14d
       jmp       near ptr M01_L03
M01_L55:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       ecx,0C5F3
       mov       rdx,7FF7B98A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       rdx,rax
       mov       rcx,r14
       call      System.FormatException..ctor(System.String)
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L56:
       inc       r14d
       jmp       short M01_L58
M01_L57:
       inc       r14d
M01_L58:
       cmp       r14d,r12d
       jge       short M01_L59
       cmp       r14d,r15d
       jae       near ptr M01_L68
       movsxd    rcx,r14d
       cmp       word ptr [rsi+rcx*2+0C],20
       je        short M01_L57
M01_L59:
       cmp       r14d,r12d
       je        near ptr M01_L66
       cmp       r14d,r15d
       jae       near ptr M01_L68
       movsxd    rcx,r14d
       movzx     eax,word ptr [rsi+rcx*2+0C]
       mov       ecx,eax
       cmp       ecx,2D
       jne       short M01_L60
       mov       r8d,1
       inc       r14d
       cmp       r14d,r12d
       je        near ptr M01_L66
       cmp       r14d,r15d
       jae       near ptr M01_L68
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       mov       [rsp+0B0],r8d
M01_L60:
       cmp       ecx,30
       jl        near ptr M01_L66
       cmp       ecx,39
       jg        near ptr M01_L66
M01_L61:
       mov       r9d,[rsp+0AC]
       lea       r9d,[r9+r9*4]
       lea       r9d,[rcx+r9*2-30]
       mov       eax,r9d
       inc       r14d
       cmp       r14d,r12d
       je        near ptr M01_L66
       cmp       r14d,r15d
       jae       near ptr M01_L68
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,30
       mov       [rsp+0AC],eax
       mov       eax,ecx
       jl        near ptr M01_L10
       cmp       eax,39
       jg        near ptr M01_L10
       mov       r9d,[rsp+0AC]
       cmp       r9d,0F4240
       mov       [rsp+0AC],r9d
       mov       ecx,eax
       jl        short M01_L61
       mov       eax,ecx
       jmp       near ptr M01_L10
M01_L62:
       inc       r14d
       jmp       near ptr M01_L10
M01_L63:
       mov       ecx,21
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M01_L64:
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
       jmp       near ptr M01_L14
M01_L65:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M01_L66:
       call      System.Text.StringBuilder.FormatError()
       int       3
M01_L67:
       test      r8d,r8d
       mov       r13,[rsp+58]
       jle       near ptr M01_L00
       mov       rcx,rdi
       mov       edx,20
       call      System.Text.StringBuilder.Append(Char, Int32)
       jmp       near ptr M01_L00
M01_L68:
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
       mov       rax,1B8479E1028
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
       mov       rdx,7FF7B98A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF7B98A4000
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.CreateStringBuilder01()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
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
       mov       rdx,20646C00528
       mov       rdx,[rdx]
       mov       r8,[rcx+30]
       mov       rcx,[rcx+58]
       mov       [rsp+40],r8
       mov       [rsp+48],rcx
       lea       rcx,[rsp+40]
       mov       r8,20646C12540
       mov       r8,[r8]
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+30],2
       mov       rcx,rdi
       lea       r9,[rsp+28]
       call      qword ptr [7FFF7F0EB900]; System.Text.StringBuilder.AppendFormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
M00_L01:
       mov       rcx,rbx
       cmp       ebp,[rcx+14]
       jne       short M00_L03
       cmp       r14d,[rbx+10]
       jae       short M00_L04
       mov       rcx,[rbx+8]
       cmp       r14d,[rcx+8]
       jae       short M00_L06
       mov       edx,r14d
       mov       rcx,[rcx+rdx*8+10]
       inc       r14d
       mov       edx,1
M00_L02:
       test      edx,edx
       jne       short M00_L00
       mov       rcx,rdi
       call      qword ptr [7FFF7F0CF3F8]; System.Text.StringBuilder.ToString()
       mov       [rsp+38],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       cmp       ebp,[rbx+14]
       jne       short M00_L05
M00_L04:
       mov       r14d,[rbx+10]
       inc       r14d
       xor       ecx,ecx
       xor       edx,edx
       jmp       short M00_L02
M00_L05:
       call      qword ptr [7FFF7F0B7A80]
       int       3
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 303
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
       je        near ptr M01_L60
       test      rbx,rbx
       jne       near ptr M01_L31
       xor       edx,edx
M01_L00:
       mov       rcx,offset MT_System.ICustomFormatter
       call      qword ptr [7FFF7EE3B888]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       r15,rax
       xor       r12d,r12d
M01_L01:
       mov       r13d,[rsi+8]
       cmp       r13d,r12d
       jbe       near ptr M01_L24
       mov       ecx,r12d
       cmp       r13d,ecx
       jb        near ptr M01_L44
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
       call      qword ptr [7FFF7F333348]; System.SpanHelpers.IndexOfAnyValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
       mov       [rsp+0AC],eax
       test      eax,eax
       jl        near ptr M01_L26
       cmp       eax,[rsp+90]
       ja        near ptr M01_L46
       mov       rcx,rdi
       mov       rdx,[rsp+38]
       mov       r8d,eax
       call      qword ptr [7FFF7F0EB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       add       r12d,[rsp+0AC]
       cmp       r12d,r13d
       jae       near ptr M01_L63
       mov       edx,r12d
       movzx     edx,word ptr [rsi+rdx*2+0C]
       inc       r12d
       cmp       r13d,r12d
       jbe       near ptr M01_L59
       mov       ecx,r12d
       movzx     eax,word ptr [rsi+rcx*2+0C]
       cmp       edx,eax
       je        near ptr M01_L47
       cmp       edx,7B
       jne       near ptr M01_L59
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
       jae       near ptr M01_L59
       inc       r12d
       cmp       r13d,r12d
       jbe       near ptr M01_L59
       mov       edx,r12d
       movzx     edx,word ptr [rsi+rdx*2+0C]
       cmp       edx,7D
       jne       near ptr M01_L18
M01_L02:
       inc       r12d
       xor       r13d,r13d
       xor       ecx,ecx
       mov       [rsp+58],rcx
       cmp       eax,r14d
       jae       near ptr M01_L45
       mov       edx,eax
       mov       rdx,[rbp+rdx*8]
       mov       [rsp+50],rdx
       test      r15,r15
       jne       near ptr M01_L34
M01_L03:
       test      r13,r13
       jne       near ptr M01_L16
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFF7EE3B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       short M01_L05
M01_L04:
       mov       rdx,[rsp+50]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFF7EE3B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       [rsp+48],rax
       test      rax,rax
       jne       near ptr M01_L29
       mov       rdx,[rsp+50]
       test      rdx,rdx
       je        near ptr M01_L41
       mov       rcx,offset MT_System.String
       cmp       [rdx],rcx
       jne       near ptr M01_L17
       jmp       near ptr M01_L21
M01_L05:
       cmp       dword ptr [rsp+0B0],0
       jne       short M01_L06
       cmp       dword ptr [rsp+0B4],0
       jne       short M01_L04
M01_L06:
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
       ja        near ptr M01_L46
       mov       ecx,r10d
       lea       rcx,[rdx+rcx*2+10]
       mov       rdx,offset MT_System.Byte
       cmp       [rax],rdx
       jne       near ptr M01_L22
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
       jne       near ptr M01_L36
       mov       [rsp+88],edx
       mov       r11d,eax
       mov       edx,1
       cmp       r11d,186A0
       jae       near ptr M01_L39
M01_L07:
       cmp       r11d,0A
       jae       near ptr M01_L13
M01_L08:
       cmp       edx,0FFFFFFFF
       jg        near ptr M01_L27
       mov       edx,0FFFFFFFF
M01_L09:
       mov       r11d,[rsp+88]
       cmp       edx,r11d
       jg        near ptr M01_L38
       mov       [rsp+0A0],edx
       mov       [rsp+98],rcx
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
M01_L10:
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
       jne       short M01_L10
       xor       ecx,ecx
       mov       [rsp+98],rcx
       mov       eax,1
M01_L11:
       xor       ecx,ecx
       mov       [rsp+98],rcx
M01_L12:
       jmp       near ptr M01_L23
M01_L13:
       cmp       r11d,64
       jae       near ptr M01_L28
       inc       edx
       jmp       near ptr M01_L08
M01_L14:
       cmp       edx,7D
       je        near ptr M01_L02
       cmp       edx,3A
       jne       near ptr M01_L59
       mov       r10d,r12d
M01_L15:
       inc       r12d
       cmp       r13d,r12d
       jbe       near ptr M01_L59
       mov       edx,r12d
       movzx     edx,word ptr [rsi+rdx*2+0C]
       cmp       edx,7D
       je        near ptr M01_L25
       cmp       edx,7B
       je        near ptr M01_L59
       jmp       short M01_L15
M01_L16:
       mov       r8d,[rsp+0B4]
       cmp       [r13+8],r8d
       jl        near ptr M01_L42
       mov       r8d,[r13+8]
       lea       rdx,[r13+0C]
       mov       rcx,rdi
       call      qword ptr [7FFF7F0EB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       near ptr M01_L01
M01_L17:
       mov       rcx,rdx
       mov       rax,[rdx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rdx,rax
       jmp       short M01_L21
M01_L18:
       lea       ecx,[rdx-30]
       cmp       ecx,9
       jbe       near ptr M01_L32
M01_L19:
       cmp       edx,20
       je        near ptr M01_L51
M01_L20:
       cmp       edx,2C
       je        near ptr M01_L52
       jmp       near ptr M01_L14
M01_L21:
       test      rdx,rdx
       je        near ptr M01_L61
       mov       r13,rdx
       jmp       short M01_L16
M01_L22:
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
       mov       r11,7FFF7EC90580
       call      qword ptr [r11]
M01_L23:
       test      eax,eax
       je        near ptr M01_L04
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
       ja        near ptr M01_L46
       cmp       ecx,edx
       ja        near ptr M01_L59
       add       r9d,[rsp+0A0]
       mov       [rdi+18],r9d
       cmp       dword ptr [rsp+0B0],0
       jne       near ptr M01_L62
       jmp       near ptr M01_L01
M01_L24:
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
M01_L25:
       inc       r10d
       mov       r11d,r12d
       sub       r11d,r10d
       mov       ecx,r10d
       mov       edx,r11d
       add       rcx,rdx
       mov       edx,r13d
       cmp       rcx,rdx
       ja        near ptr M01_L44
       mov       r10d,r10d
       lea       r10,[rsi+r10*2+0C]
       mov       r13,r10
       mov       r10d,r11d
       mov       [rsp+94],r10d
       mov       [rsp+40],r13
       jmp       near ptr M01_L02
M01_L26:
       mov       rcx,rdi
       mov       rdx,[rsp+38]
       mov       r8d,[rsp+90]
       call      qword ptr [7FFF7F0EB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
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
M01_L27:
       jmp       near ptr M01_L09
M01_L28:
       cmp       r11d,3E8
       jae       near ptr M01_L33
       add       edx,2
       jmp       near ptr M01_L08
M01_L29:
       mov       rax,[rsp+48]
       mov       edx,[rsp+94]
       test      edx,edx
       je        short M01_L30
       mov       r8,[rsp+58]
       test      r8,r8
       mov       [rsp+58],r8
       jne       short M01_L30
       mov       r9,[rsp+40]
       mov       [rsp+78],r9
       mov       [rsp+80],edx
       lea       rcx,[rsp+78]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       [rsp+58],rax
       mov       rax,[rsp+48]
M01_L30:
       mov       rcx,rax
       mov       r8,rbx
       mov       rdx,[rsp+58]
       mov       r11,7FFF7EC90578
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M01_L21
M01_L31:
       mov       rcx,offset MT_System.ICustomFormatter
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rbx
       mov       r11,7FFF7EC90570
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M01_L00
M01_L32:
       cmp       eax,0F4240
       jge       near ptr M01_L50
       lea       eax,[rax+rax*4]
       lea       eax,[rdx+rax*2-30]
       inc       r12d
       cmp       r13d,r12d
       jbe       near ptr M01_L59
       mov       edx,r12d
       movzx     edx,word ptr [rsi+rdx*2+0C]
       jmp       near ptr M01_L18
M01_L33:
       cmp       r11d,2710
       jae       near ptr M01_L37
       add       edx,3
       jmp       near ptr M01_L08
M01_L34:
       cmp       dword ptr [rsp+94],0
       jne       near ptr M01_L40
M01_L35:
       mov       rcx,r15
       mov       r9,rbx
       mov       rdx,[rsp+58]
       mov       r8,[rsp+50]
       mov       r11,7FFF7EC90588
       call      qword ptr [r11]
       mov       r13,rax
       mov       rdx,[rsp+50]
       jmp       near ptr M01_L03
M01_L36:
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
       call      qword ptr [7FFF7F085000]
       jmp       near ptr M01_L12
M01_L37:
       add       edx,4
       jmp       near ptr M01_L08
M01_L38:
       xor       ecx,ecx
       mov       [rsp+0A0],ecx
       xor       eax,eax
       jmp       near ptr M01_L11
M01_L39:
       mov       r11d,eax
       shr       r11d,5
       imul      r11,0A7C5AC5
       shr       r11,27
       mov       edx,6
       jmp       near ptr M01_L07
M01_L40:
       mov       r10,[rsp+40]
       mov       [rsp+78],r10
       mov       r11d,[rsp+94]
       mov       [rsp+80],r11d
       lea       rcx,[rsp+78]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r13,rax
       mov       [rsp+58],r13
       jmp       near ptr M01_L35
M01_L41:
       xor       edx,edx
       jmp       near ptr M01_L21
M01_L42:
       cmp       dword ptr [rsp+0B0],0
       je        short M01_L43
       mov       eax,[r13+8]
       lea       rdx,[r13+0C]
       mov       rcx,rdi
       mov       r8d,eax
       call      qword ptr [7FFF7F0EB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       mov       eax,[rsp+0B4]
       mov       r8d,eax
       sub       r8d,[r13+8]
       mov       rcx,rdi
       mov       edx,20
       call      qword ptr [7FFF7F0EB258]
       jmp       near ptr M01_L01
M01_L43:
       mov       r8d,[rsp+0B4]
       sub       r8d,[r13+8]
       mov       rcx,rdi
       mov       edx,20
       call      qword ptr [7FFF7F0EB258]
       mov       r8d,[r13+8]
       lea       rdx,[r13+0C]
       mov       rcx,rdi
       call      qword ptr [7FFF7F0EB9C0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       near ptr M01_L01
M01_L44:
       mov       ecx,21
       call      qword ptr [7FFF7F0B77E0]
       int       3
M01_L45:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0C2B3
       mov       rdx,7FFF7EC84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7EEFD030]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F17F450]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L46:
       call      qword ptr [7FFF7F0B7498]
       int       3
M01_L47:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L48
       mov       ecx,ecx
       mov       [rdx+rcx*2+10],ax
       inc       dword ptr [rdi+18]
       jmp       short M01_L49
M01_L48:
       mov       rcx,rdi
       mov       edx,eax
       mov       r8d,1
       call      qword ptr [7FFF7F0EB258]
M01_L49:
       inc       r12d
       jmp       near ptr M01_L01
M01_L50:
       cmp       edx,20
       jne       near ptr M01_L20
M01_L51:
       inc       r12d
       cmp       r13d,r12d
       jbe       near ptr M01_L59
       mov       edx,r12d
       movzx     edx,word ptr [rsi+rdx*2+0C]
       jmp       near ptr M01_L19
M01_L52:
       inc       r12d
       cmp       r13d,r12d
       jbe       near ptr M01_L59
       mov       edx,r12d
       movzx     edx,word ptr [rsi+rdx*2+0C]
       cmp       edx,20
       je        short M01_L52
       cmp       edx,2D
       jne       short M01_L53
       mov       dword ptr [rsp+0B0],1
       inc       r12d
       cmp       r13d,r12d
       jbe       near ptr M01_L59
       mov       edx,r12d
       movzx     edx,word ptr [rsi+rdx*2+0C]
M01_L53:
       lea       r8d,[rdx-30]
       cmp       r8d,0A
       jae       near ptr M01_L59
       inc       r12d
       cmp       r13d,r12d
       jbe       short M01_L59
       mov       edx,r12d
       movzx     edx,word ptr [rsi+rdx*2+0C]
       jmp       short M01_L55
M01_L54:
       lea       r8d,[r8+r8*4]
       lea       r8d,[rdx+r8*2-30]
       mov       [rsp+0B4],r8d
       inc       r12d
       cmp       r13d,r12d
       jbe       short M01_L59
       mov       edx,r12d
       movzx     edx,word ptr [rsi+rdx*2+0C]
       mov       r8d,[rsp+0B4]
M01_L55:
       lea       ecx,[rdx-30]
       cmp       ecx,9
       ja        short M01_L57
       cmp       r8d,0F4240
       jl        short M01_L54
       cmp       edx,20
       jne       short M01_L58
M01_L56:
       inc       r12d
       cmp       r13d,r12d
       jbe       short M01_L59
       mov       edx,r12d
       movzx     edx,word ptr [rsi+rdx*2+0C]
M01_L57:
       cmp       edx,20
       je        short M01_L56
       mov       [rsp+0B4],r8d
       jmp       near ptr M01_L14
M01_L58:
       mov       [rsp+0B4],r8d
       jmp       near ptr M01_L14
M01_L59:
       call      qword ptr [7FFF7F0B7BB8]
       int       3
M01_L60:
       mov       ecx,31B
       mov       rdx,7FFF7EC84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7F05FF90]
       int       3
M01_L61:
       mov       rdx,20646C02028
       mov       rdx,[rdx]
       mov       rax,rdx
       mov       r13,rax
       jmp       near ptr M01_L16
M01_L62:
       mov       r8d,[rsp+0B4]
       cmp       r8d,[rsp+0A0]
       jle       near ptr M01_L01
       sub       r8d,[rsp+0A0]
       mov       rcx,rdi
       mov       edx,20
       call      qword ptr [7FFF7F0EB258]
       jmp       near ptr M01_L01
M01_L63:
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
       call      qword ptr [7FFF7EF199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,20646C02028
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
       mov       rdx,7FFF7EC84000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FFF7EC84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7EEFD030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF7F085750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetPropertyValues01()
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.TypeHelper.GetPropertyValues[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Core.TypeHelper.GetPropertyValues[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       [rbp-10],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 131
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vzeroupper
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+58],rax
       mov       [rsp+60],rcx
       mov       esi,edx
       mov       edi,r8d
       mov       ebx,r9d
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],0
       je        short M01_L00
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF7B9D09DC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       rbp,rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7B98D0638
       call      qword ptr [7FF7B98D0638]
       mov       ecx,esi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7B98D0640
       call      qword ptr [7FF7B98D0640]
       mov       ecx,esi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7B98D0648
       call      qword ptr [7FF7B98D0648]
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+50]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       jo        near ptr M01_L02
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rax,346DC5D638865
       cmp       rcx,rax
       jg        near ptr M01_L03
       mov       rax,0FFFCB923A29C779B
       cmp       rcx,rax
       jl        near ptr M01_L03
       imul      rsi,rcx,2710
       lea       rcx,[rsp+50]
       call      System.DateTimeOffset.get_ClockDateTime()
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       sub       rdx,rsi
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L04
       mov       rcx,0C000000000000000
       and       rcx,rax
       or        rdx,rcx
       mov       ecx,[rsp+50]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L05
       mov       r8,0FFFFFF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L05
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+30],xmm0
       lea       rcx,[rsp+30]
       call      System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rcx,rbp
       lea       rdx,[rsp+20]
       mov       r11,7FF7B98D0650
       call      qword ptr [7FF7B98D0650]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7B98D0658
       call      qword ptr [7FF7B98D0658]
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7B98D0660
       call      qword ptr [7FF7B98D0660]
       mov       ecx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7B98D0668
       call      qword ptr [7FF7B98D0668]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7B98D0670
       call      qword ptr [7FF7B98D0670]
       mov       ecx,[rsp+0B0]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7B98D0678
       call      qword ptr [7FF7B98D0678]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7B98D0680
       call      qword ptr [7FF7B98D0680]
       mov       ecx,[rsp+0B8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7B98D0688
       call      qword ptr [7FF7B98D0688]
       mov       ecx,[rsp+0C0]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7B98D0690
       call      qword ptr [7FF7B98D0690]
       mov       ecx,[rsp+0C8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7B98D0698
       call      qword ptr [7FF7B98D0698]
       mov       rax,rbp
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      System.SR.get_Overflow_TimeSpanTooLong()
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L04:
       xor       ecx,ecx
       call      System.DateTime.ThrowDateArithmetic(Int32)
       int       3
M01_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_TimeSpanTooLong()
       int       3
; Total bytes of code 828
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper.GetPropertyValues[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       xor       edx,edx
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rbp,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Extensions+<GetAllProperties>d__15
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+30],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+34],eax
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[rdi+10]
       cmp       qword ptr [rbp+10],0
       je        short M02_L00
       mov       rcx,[rbp+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FF7B9D6CA08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r8,[rax+8]
       test      r8,r8
       jne       near ptr M02_L06
       mov       r15,[rbp+10]
       test      r15,r15
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FF7B9D6CA08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r15,rax
M02_L03:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r15
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       test      rdx,rdx
       je        near ptr M02_L19
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.TypeHelper+<>c__14`1[[System.__Canon, System.Private.CoreLib]].<GetPropertyValues>b__14_0(System.Reflection.PropertyInfo)
       mov       [r12+18],rcx
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rdi
       mov       rdx,7FF7B9D6CA08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,r12
M02_L06:
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Where[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       r14,rax
       cmp       qword ptr [rbp+10],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdi
       mov       rdx,7FF7B9D6CA08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r15,[rax+10]
       test      r15,r15
       jne       near ptr M02_L13
       mov       r15,[rbp+10]
       test      r15,r15
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FF7B9D6CA08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r15,rax
M02_L10:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r15
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       test      rdx,rdx
       je        near ptr M02_L19
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.TypeHelper+<>c__14`1[[System.__Canon, System.Private.CoreLib]].<GetPropertyValues>b__14_1(System.Reflection.PropertyInfo)
       mov       [r12+18],rcx
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rdi
       mov       rdx,7FF7B9D6CA08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L12:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r15,r12
M02_L13:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       je        near ptr M02_L21
       test      r15,r15
       je        near ptr M02_L20
       xor       edx,edx
       mov       [rdi+10],rdx
       lea       rcx,[rdi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,204A9AF2F20
       mov       rdx,[rdx]
       lea       rcx,[rdi+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+28],0
       mov       rcx,rdi
       mov       r11,7FF7B98D04E8
       call      qword ptr [7FF7B98D04E8]
       mov       rdi,rax
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M02_L17
M02_L14:
       movsxd    rcx,ebp
       mov       r15,[rdi+rcx*8+10]
       mov       rcx,r15
       mov       r12,[r15]
       mov       rax,[r12+50]
       call      qword ptr [rax+10]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       rdx,204A9AFA4A0
       mov       rdx,[rdx]
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       test      eax,eax
       je        near ptr M02_L15
       mov       rcx,r15
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[r12+58]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.IDictionary
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r13,rax
       test      r13,r13
       je        near ptr M02_L16
       mov       rcx,r13
       mov       r11,7FF7B98D04E0
       call      qword ptr [7FF7B98D04E0]
       test      eax,eax
       jle       near ptr M02_L16
       mov       rcx,r15
       mov       rax,[r12+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       mov       rcx,r13
       mov       edx,2C
       call      DotNetTips.Spargine.Core.Extensions.ToDelimitedString(System.Collections.IDictionary, Char)
       mov       r12,rax
       mov       rcx,rbx
       mov       r11,7FF7B98D0500
       call      qword ptr [7FF7B98D0500]
       test      eax,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L22
       lea       rcx,[rsp+30]
       mov       [rcx],r15
       mov       [rcx+8],r12
       mov       rcx,rbx
       lea       rdx,[rsp+30]
       mov       r11,7FF7B98D04F0
       call      qword ptr [7FF7B98D04F0]
       test      eax,eax
       jne       near ptr M02_L16
       lea       rcx,[rsp+30]
       mov       [rcx],r15
       mov       [rcx+8],r12
       mov       rcx,rbx
       lea       rdx,[rsp+30]
       mov       r11,7FF7B98D04F8
       call      qword ptr [7FF7B98D04F8]
       jmp       near ptr M02_L16
M02_L15:
       mov       rcx,r15
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[r12+58]
       call      qword ptr [rax+30]
       mov       r13,rax
       test      r13,r13
       je        near ptr M02_L16
       mov       rcx,r15
       mov       rax,[r12+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r12,rax
       mov       rcx,rbx
       mov       r11,7FF7B98D0518
       call      qword ptr [7FF7B98D0518]
       test      eax,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L26
       lea       rcx,[rsp+30]
       mov       [rcx],r15
       mov       [rcx+8],r12
       mov       rcx,rbx
       lea       rdx,[rsp+30]
       mov       r11,7FF7B98D0508
       call      qword ptr [7FF7B98D0508]
       test      eax,eax
       jne       short M02_L16
       lea       rcx,[rsp+30]
       mov       [rcx],r15
       mov       [rcx+8],r12
       mov       rcx,rbx
       lea       rdx,[rsp+30]
       mov       r11,7FF7B98D0510
       call      qword ptr [7FF7B98D0510]
M02_L16:
       add       ebp,1
       jo        short M02_L18
       cmp       r14d,ebp
       jg        near ptr M02_L14
M02_L17:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Collections.Immutable.ImmutableDictionary.ToImmutableDictionary[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEqualityComparer`1<System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       xor       r8d,r8d
       xor       r9d,r9d
       call      System.Collections.Immutable.ImmutableDictionary.ToImmutableDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       nop
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
M02_L18:
       call      CORINFO_HELP_OVERFLOW
M02_L19:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
M02_L20:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L21:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L22:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionIsNullOrHasNoItems()
       mov       rsi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorReadOnlyCollection()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       rsi,rax
       mov       rax,204A9AFA4A8
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short M02_L23
       xor       eax,eax
       jmp       short M02_L24
M02_L23:
       mov       eax,1
M02_L24:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L25
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9B85440
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF7B9B85440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9B85440
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L25:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentReadOnlyException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,rsi
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L26:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionIsNullOrHasNoItems()
       mov       rsi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorReadOnlyCollection()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       rsi,rax
       mov       rax,204A9AFA4A8
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short M02_L27
       xor       eax,eax
       jmp       short M02_L28
M02_L27:
       mov       eax,1
M02_L28:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L29
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9B85440
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF7B9B85440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9B85440
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L29:
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentReadOnlyException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,rsi
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 1797
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetPropertyValues01()
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFF7F249C78]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.TypeHelper.GetPropertyValues[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFF7F3359C0]; DotNetTips.Spargine.Core.TypeHelper.GetPropertyValues[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       [rbp-10],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vzeroupper
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+58],rax
       mov       [rsp+60],rcx
       mov       esi,edx
       mov       edi,r8d
       mov       ebx,r9d
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],0
       je        short M01_L00
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFF7F276218
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      qword ptr [7FFF7F245138]; System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       rbp,rax
       call      qword ptr [7FFF7F289DE0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFF7EC906F8
       call      qword ptr [r11]
       mov       ecx,esi
       call      qword ptr [7FFF7F247AB0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFF7EC90700
       call      qword ptr [r11]
       mov       ecx,esi
       call      qword ptr [7FFF7F247AB0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFF7EC90708
       call      qword ptr [r11]
       call      qword ptr [7FFF7F0E3918]; System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+50]
       mov       r8d,1
       call      qword ptr [7FFF7F103750]; System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      qword ptr [7FFF7F247900]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       jo        near ptr M01_L02
       movsxd    rcx,ecx
       mov       rax,141DD76000
       imul      rcx,rax
       mov       rax,0CCCCCCCCCCCCCCC
       cmp       rcx,rax
       jg        near ptr M01_L04
       mov       rax,0F333333333333334
       cmp       rcx,rax
       jl        near ptr M01_L04
       lea       rsi,[rcx+rcx*4]
       add       rsi,rsi
       lea       rcx,[rsp+50]
       call      qword ptr [7FFF7F103150]; System.DateTimeOffset.get_ClockDateTime()
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       sub       rdx,rsi
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L03
       mov       rcx,0C000000000000000
       and       rcx,rax
       or        rdx,rcx
       mov       ecx,[rsp+50]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L04
       mov       r8,0FFFFFF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L04
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+30],xmm0
       lea       rcx,[rsp+30]
       call      qword ptr [7FFF7F103048]; System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rcx,rbp
       lea       rdx,[rsp+20]
       mov       r11,7FFF7EC90710
       call      qword ptr [r11]
       call      qword ptr [7FFF7F247990]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFF7EC90718
       call      qword ptr [r11]
       mov       ecx,edi
       call      qword ptr [7FFF7F247AB0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFF7EC90720
       call      qword ptr [r11]
       mov       ecx,ebx
       call      qword ptr [7FFF7F247AB0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFF7EC90728
       call      qword ptr [r11]
       call      qword ptr [7FFF7F2478A0]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFF7EC90730
       call      qword ptr [r11]
       mov       ecx,[rsp+0B0]
       call      qword ptr [7FFF7F247AB0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFF7EC90738
       call      qword ptr [r11]
       call      qword ptr [7FFF7F247990]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFF7EC90740
       call      qword ptr [r11]
       mov       ecx,[rsp+0B8]
       call      qword ptr [7FFF7F247AB0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFF7EC90748
       call      qword ptr [r11]
       mov       ecx,[rsp+0C0]
       call      qword ptr [7FFF7F247930]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFF7EC90750
       call      qword ptr [r11]
       mov       ecx,[rsp+0C8]
       call      qword ptr [7FFF7F247AB0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFF7EC90758
       call      qword ptr [r11]
       mov       rax,rbp
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       xor       ecx,ecx
       call      qword ptr [7FFF7F0E11E0]
       int       3
M01_L04:
       call      qword ptr [7FFF7F0B7678]
       int       3
; Total bytes of code 757
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper.GetPropertyValues[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       vzeroupper
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       [rsp+68],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FFF7EEDBDC8]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
       test      rax,rax
       je        short M02_L00
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M02_L00:
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rbp,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Extensions+<GetAllProperties>d__15
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+30],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+34],eax
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[rdi+10]
       cmp       qword ptr [rbp+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFF7F349158
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r8,[rax+8]
       test      r8,r8
       jne       near ptr M02_L07
       mov       r15,[rbp+10]
       test      r15,r15
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFF7F349158
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r15,rax
M02_L04:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r15
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       test      rdx,rdx
       je        near ptr M02_L34
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFF7F334AB0
       mov       [r12+18],rcx
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       rdx,7FFF7F349158
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,r12
M02_L07:
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Where[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,Boolean>)
       call      qword ptr [7FFF7F1D95E8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       r14,rax
       cmp       qword ptr [rbp+10],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       jmp       short M02_L09
M02_L08:
       mov       rcx,rdi
       mov       rdx,7FFF7F349158
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r15,[rax+10]
       test      r15,r15
       jne       near ptr M02_L14
       mov       r15,[rbp+10]
       test      r15,r15
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rdi
       mov       rdx,7FFF7F349158
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r15,rax
M02_L11:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r15
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       test      rdx,rdx
       je        near ptr M02_L34
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFF7F334AC8
       mov       [r12+18],rcx
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdi
       mov       rdx,7FFF7F349158
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L13:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r15,r12
M02_L14:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       je        near ptr M02_L36
       test      r15,r15
       je        near ptr M02_L35
       xor       edx,edx
       mov       [rdi+10],rdx
       lea       rcx,[rdi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,19963C01F40
       mov       rdx,[rdx]
       lea       rcx,[rdi+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+28],0
       mov       rcx,rdi
       call      qword ptr [7FFF7F22B788]; System.Linq.OrderedEnumerable`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdi,rax
       xor       ebp,ebp
       cmp       dword ptr [rdi+8],0
       jle       near ptr M02_L23
M02_L15:
       mov       ecx,ebp
       mov       r14,[rdi+rcx*8+10]
       mov       rcx,r14
       mov       r15,[r14]
       mov       rax,[r15+50]
       call      qword ptr [rax+10]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       test      rax,rax
       je        near ptr M02_L21
       cmp       dword ptr [rax+8],0B
       jne       near ptr M02_L21
       vmovupd   xmm0,[rax+0C]
       vpxor     xmm0,xmm0,[7FFF7EE7F2B0]
       vmovupd   xmm1,[rax+12]
       vpxor     xmm1,xmm1,[7FFF7EE7F2C0]
       vpor      xmm0,xmm0,xmm1
       vptest    xmm0,xmm0
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L21
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r15,rcx
       jne       near ptr M02_L37
       mov       rcx,r14
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M02_L18
M02_L16:
       test      rcx,rcx
       je        near ptr M02_L39
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rsi
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFF7F0FC4E0]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       mov       rdx,rax
M02_L17:
       mov       rcx,offset MT_System.Collections.IDictionary
       call      qword ptr [7FFF7EE3B810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        near ptr M02_L20
       mov       rcx,r12
       mov       r11,7FFF7EC90658
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M02_L20
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       mov       rcx,r12
       mov       edx,2C
       call      qword ptr [7FFF7F28D468]
       mov       r14,rax
       mov       rcx,rbx
       mov       r11,7FFF7EC90678
       call      qword ptr [r11]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L27
       mov       [rsp+48],r15
       mov       [rsp+50],r14
       mov       rcx,rbx
       lea       rdx,[rsp+48]
       mov       r11,7FFF7EC90668
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M02_L20
       mov       [rsp+48],r15
       mov       [rsp+50],r14
       mov       rcx,rbx
       lea       rdx,[rsp+48]
       mov       r11,7FFF7EC90670
       call      qword ptr [r11]
       jmp       near ptr M02_L20
M02_L18:
       xor       ecx,ecx
       jmp       near ptr M02_L16
M02_L19:
       test      r12,r12
       je        near ptr M02_L20
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       r14,rax
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r15,rax
       mov       rcx,rbx
       mov       r11,7FFF7EC90690
       call      qword ptr [r11]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L30
       mov       [rsp+48],r14
       mov       [rsp+50],r15
       mov       rcx,rbx
       lea       rdx,[rsp+48]
       mov       r11,7FFF7EC90680
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L20
       mov       [rsp+48],r14
       mov       [rsp+50],r15
       mov       rcx,rbx
       lea       rdx,[rsp+48]
       mov       r11,7FFF7EC90688
       call      qword ptr [r11]
M02_L20:
       add       ebp,1
       jo        near ptr M02_L33
       cmp       [rdi+8],ebp
       jg        near ptr M02_L15
       jmp       short M02_L23
M02_L21:
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r15,rcx
       jne       near ptr M02_L38
       mov       rcx,r14
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L24
M02_L22:
       test      rcx,rcx
       je        near ptr M02_L29
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rsi
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFF7F0FC4E0]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       mov       r12,rax
       jmp       near ptr M02_L19
M02_L23:
       mov       rcx,19967C017A0
       mov       rcx,[rcx]
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFF7F3352A0]; System.Collections.Immutable.ImmutableDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].WithComparers(System.Collections.Generic.IEqualityComparer`1<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rdi,rax
       cmp       [rdi],dil
       cmp       dword ptr [rdi+18],0
       jne       short M02_L25
       jmp       near ptr M02_L32
M02_L24:
       xor       ecx,ecx
       jmp       short M02_L22
M02_L25:
       mov       r9,[rdi+8]
       mov       r8,[rdi+10]
       mov       [rsp+38],r9
       mov       [rsp+40],r8
       mov       dword ptr [rsp+20],2
       lea       r9,[rsp+38]
       mov       r8,rbx
       lea       rcx,[rsp+58]
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableDictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      qword ptr [7FFF7F335660]; System.Collections.Immutable.ImmutableDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, MutationInput<System.__Canon,System.__Canon>, KeyCollisionBehavior<System.__Canon,System.__Canon>)
       mov       rdx,[rsp+58]
       mov       r8d,[rdi+18]
       add       r8d,[rsp+60]
       mov       rcx,rdi
       call      qword ptr [7FFF7F3356C0]; System.Collections.Immutable.ImmutableDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Wrap(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Int32)
M02_L26:
       nop
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L27:
       call      qword ptr [7FFF7F28BB28]
       mov       rbx,rax
       call      qword ptr [7FFF7F28BDE0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7F28D000]
       mov       rbx,rax
       mov       rax,19967C09950
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L28
       call      qword ptr [7FFF7F28BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0F8CA8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0F8CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F28B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F28BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F28D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F05FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L28:
       mov       edx,3
       call      qword ptr [7FFF7EED3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentReadOnlyException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,rbx
       call      qword ptr [7FFF7EEDBBD0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L29:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,3F5D
       mov       rdx,7FFF7EC84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7EEFD030]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7EEDBB88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L30:
       call      qword ptr [7FFF7F28BB28]
       mov       rsi,rax
       call      qword ptr [7FFF7F28BDE0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F28D000]
       mov       rsi,rax
       mov       rcx,19967C09950
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M02_L31
       call      qword ptr [7FFF7F28BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0F8CA8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0F8CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F28B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F28BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F28D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F05FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L31:
       mov       edx,3
       call      qword ptr [7FFF7EED3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentReadOnlyException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFF7EEDBBD0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L32:
       xor       r8d,r8d
       je        near ptr M02_L25
       mov       r8,[rdi+10]
       mov       r8,[r8+10]
       mov       rdx,[rdi+10]
       mov       rdx,[rdx+8]
       xor       ecx,ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F3352A0]; System.Collections.Immutable.ImmutableDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].WithComparers(System.Collections.Generic.IEqualityComparer`1<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       jmp       near ptr M02_L26
M02_L33:
       call      CORINFO_HELP_OVERFLOW
M02_L34:
       call      qword ptr [7FFF7EE3B630]
       int       3
M02_L35:
       mov       ecx,9
       call      qword ptr [7FFF7F0BB780]
       int       3
M02_L36:
       mov       ecx,10
       call      qword ptr [7FFF7F0BB780]
       int       3
M02_L37:
       mov       rcx,r14
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[r15+58]
       call      qword ptr [rax+30]
       mov       rdx,rax
       jmp       near ptr M02_L17
M02_L38:
       mov       rcx,r14
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[r15+58]
       call      qword ptr [rax+30]
       mov       r12,rax
       jmp       near ptr M02_L19
M02_L39:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,3F5D
       mov       rdx,7FFF7EC84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7EEFD030]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7EEDBB88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 2234
```

