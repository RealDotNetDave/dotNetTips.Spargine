## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.CreateStringBuilder01()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       rsi,rcx
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
; 			foreach (var person in this._people)
; 			                       ^^^^^^^^^^^^
       mov       rbx,[rsi+0B8]
       mov       ebp,[rbx+14]
       xor       r14d,r14d
       jmp       short M00_L01
M00_L00:
       mov       rdx,2616C201568
       mov       rdx,[rdx]
       mov       r8,[rcx+30]
       mov       rcx,[rcx+58]
       xor       r9d,r9d
       mov       rax,2616C201388
       mov       rax,[rax]
       mov       r10,2616C206528
       mov       r10,[r10]
       mov       [rsp+20],r8
       mov       [rsp+28],rcx
       mov       [rsp+30],r9
       mov       [rsp+38],rax
       mov       rcx,rdi
       mov       r8,r10
       lea       r9,[rsp+20]
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
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FFED0B12E80]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L05:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       int       3
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 304
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
       mov       r11,7FFED0780508
       call      qword ptr [7FFED0B10508]
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
       lea       edx,[rax+rdx*2+0FFD0]
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
       mov       r11,7FFED0780500
       call      qword ptr [7FFED0B10500]
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
       mov       r11,7FFED07804F8
       call      qword ptr [7FFED0B104F8]
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
       mov       r11,7FFED07804F0
       call      qword ptr [7FFED0B104F0]
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
       mov       rcx,2616C203020
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
       mov       rdx,7FFED0774000
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
       mov       rdx,7FFED0774000
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
       lea       r9d,[rcx+r9*2+0FFD0]
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
       mov       rax,2616C203020
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
       mov       rdx,7FFED0774000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FFED0774000
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

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetPropertyValues01()
; 			var person = RandomData.GenerateRefPerson<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = TypeHelper.GetPropertyValues(person);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       rsi,rcx
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.TypeHelper.GetPropertyValues(!!0)
       call      DotNetTips.Spargine.Core.TypeHelper.GetPropertyValues[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,48
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 122
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
       mov       rdx,7FFED0BD5A50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       rbp,rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFED07B0630
       call      qword ptr [7FFED0B60630]
       mov       ecx,esi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFED07B0638
       call      qword ptr [7FFED0B60638]
       mov       ecx,esi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFED07B0640
       call      qword ptr [7FFED0B60640]
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
       mov       rax,46DC5D638865
       cmp       rcx,rax
       jg        near ptr M01_L03
       mov       rax,0B923A29C779B
       cmp       rcx,rax
       jl        near ptr M01_L03
       imul      rsi,rcx,2710
       lea       rcx,[rsp+50]
       call      System.DateTimeOffset.get_ClockDateTime()
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rax
       sub       rdx,rsi
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L04
       mov       rcx,0
       and       rcx,rax
       or        rdx,rcx
       mov       ecx,[rsp+50]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L05
       mov       r8,0FF29406B2A1B
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
       mov       r11,7FFED07B0648
       call      qword ptr [7FFED0B60648]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFED07B0650
       call      qword ptr [7FFED0B60650]
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFED07B0658
       call      qword ptr [7FFED0B60658]
       mov       ecx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFED07B0660
       call      qword ptr [7FFED0B60660]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFED07B0668
       call      qword ptr [7FFED0B60668]
       mov       ecx,[rsp+0B0]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFED07B0670
       call      qword ptr [7FFED0B60670]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFED07B0678
       call      qword ptr [7FFED0B60678]
       mov       ecx,[rsp+0B8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFED07B0680
       call      qword ptr [7FFED0B60680]
       mov       ecx,[rsp+0C0]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFED07B0688
       call      qword ptr [7FFED0B60688]
       mov       ecx,[rsp+0C8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFED07B0690
       call      qword ptr [7FFED0B60690]
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
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       [rsp+30],rcx
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
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Extensions+<GetAllProperties>d__10
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
       mov       rdx,7FFED0C40590
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
       mov       rdx,7FFED0C40590
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
       je        near ptr M02_L21
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.TypeHelper+<>c__13`1[[System.__Canon, System.Private.CoreLib]].<GetPropertyValues>b__13_0(System.Reflection.PropertyInfo)
       mov       [r12+18],rcx
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rdi
       mov       rdx,7FFED0C40590
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
       mov       rcx,offset MD_System.Linq.Enumerable.Where(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       r14,rax
       cmp       qword ptr [rbp+10],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdi
       mov       rdx,7FFED0C40590
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
       mov       rdx,7FFED0C40590
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
       je        near ptr M02_L21
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.TypeHelper+<>c__13`1[[System.__Canon, System.Private.CoreLib]].<GetPropertyValues>b__13_1(System.Reflection.PropertyInfo)
       mov       [r12+18],rcx
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rdi
       mov       rdx,7FFED0C40590
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
       je        near ptr M02_L23
       test      r15,r15
       je        near ptr M02_L22
       xor       edx,edx
       mov       [rdi+10],rdx
       lea       rcx,[rdi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1A27ECC2F28
       mov       rdx,[rdx]
       lea       rcx,[rdi+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+28],0
       mov       rcx,rdi
       mov       r11,7FFED07B04D8
       call      qword ptr [7FFED0B404D8]
       mov       rdi,rax
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M02_L19
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
       mov       rdx,1A27ECCAD00
       mov       rdx,[rdx]
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       test      eax,eax
       je        near ptr M02_L16
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
       je        near ptr M02_L18
       mov       rcx,r13
       mov       r11,7FFED07B04D0
       call      qword ptr [7FFED0B404D0]
       test      eax,eax
       jle       near ptr M02_L18
       mov       rcx,r15
       mov       rax,[r12+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       mov       rcx,r13
       mov       edx,2C
       call      DotNetTips.Spargine.Core.Extensions.ToDelimitedString(System.Collections.IDictionary, Char)
       mov       r12,rax
       mov       rcx,rbx
       mov       r11,7FFED07B04F0
       call      qword ptr [7FFED0B404F0]
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionIsNullOrHasNoItems()
       mov       rcx,rax
       mov       rdx,1A27ECCAD08
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentReadOnlyCollectionException(System.String, System.String)
M02_L15:
       lea       rcx,[rsp+20]
       mov       [rcx],r15
       mov       [rcx+8],r12
       mov       rcx,rbx
       lea       rdx,[rsp+20]
       mov       r11,7FFED07B04E0
       call      qword ptr [7FFED0B404E0]
       test      eax,eax
       jne       near ptr M02_L18
       lea       rcx,[rsp+20]
       mov       [rcx],r15
       mov       [rcx+8],r12
       mov       rcx,rbx
       lea       rdx,[rsp+20]
       mov       r11,7FFED07B04E8
       call      qword ptr [7FFED0B404E8]
       jmp       near ptr M02_L18
M02_L16:
       mov       rcx,r15
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[r12+58]
       call      qword ptr [rax+30]
       mov       r13,rax
       test      r13,r13
       je        near ptr M02_L18
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
       mov       r11,7FFED07B0508
       call      qword ptr [7FFED0B40508]
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L17
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorCollectionIsNullOrHasNoItems()
       mov       rcx,rax
       mov       rdx,1A27ECCAD08
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentReadOnlyCollectionException(System.String, System.String)
M02_L17:
       lea       rcx,[rsp+20]
       mov       [rcx],r15
       mov       [rcx+8],r12
       mov       rcx,rbx
       lea       rdx,[rsp+20]
       mov       r11,7FFED07B04F8
       call      qword ptr [7FFED0B404F8]
       test      eax,eax
       jne       short M02_L18
       lea       rcx,[rsp+20]
       mov       [rcx],r15
       mov       [rcx+8],r12
       mov       rcx,rbx
       lea       rdx,[rsp+20]
       mov       r11,7FFED07B0500
       call      qword ptr [7FFED0B40500]
M02_L18:
       add       ebp,1
       jo        short M02_L20
       cmp       r14d,ebp
       jg        near ptr M02_L14
M02_L19:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Collections.Immutable.ImmutableDictionary.ToImmutableDictionary(System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<!!0,!!1>>, System.Collections.Generic.IEqualityComparer`1<!!0>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       xor       r8d,r8d
       xor       r9d,r9d
       call      System.Collections.Immutable.ImmutableDictionary.ToImmutableDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L20:
       call      CORINFO_HELP_OVERFLOW
M02_L21:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
M02_L22:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L23:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 1278
```

