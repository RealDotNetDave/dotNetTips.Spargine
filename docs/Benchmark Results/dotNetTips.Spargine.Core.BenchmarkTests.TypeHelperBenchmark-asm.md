## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.CreateStringBuilder01()
       push      rdi
       push      rsi
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       rsi,rcx
       call      dotNetTips.Spargine.Core.TypeHelper.CreateStringBuilder()
       mov       rdi,rax
       mov       rcx,[rsi+68]
       mov       edx,[rcx+14]
       mov       [rsp+40],rcx
       xor       ecx,ecx
       mov       [rsp+48],rcx
       mov       [rsp+50],ecx
       mov       [rsp+54],edx
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rsp+48]
       mov       r9,[rcx+30]
       mov       rcx,[rcx+58]
       cmp       [rdi],edi
       xor       r8d,r8d
       mov       rdx,2459A4E1360
       mov       rdx,[rdx]
       mov       rax,245BA4E10E0
       mov       rax,[rax]
       lea       r10,[rsp+20]
       mov       [r10],r9
       mov       [r10+8],rcx
       mov       [r10+10],r8
       mov       [r10+18],rdx
       mov       rcx,rdi
       lea       r9,[rsp+20]
       mov       r8,rax
       xor       edx,edx
       call      System.Text.StringBuilder.AppendFormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB36ED31E8]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 240
```
```assembly
; dotNetTips.Spargine.Core.TypeHelper.CreateStringBuilder()
       sub       rsp,28
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPoolProvider
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+8],8
       mov       rcx,rax
       call      Microsoft.Extensions.ObjectPool.ObjectPoolProviderExtensions.CreateStringBuilderPool(Microsoft.Extensions.ObjectPool.ObjectPoolProvider)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
       add       rsp,28
       ret
; Total bytes of code 53
```
```assembly
; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       eax,[rsi+14]
       cmp       eax,[rcx+14]
       jne       short M02_L00
       mov       eax,[rsi+10]
       mov       [rsp+20],rcx
       cmp       eax,[rcx+10]
       jae       short M02_L00
       lea       rcx,[rsi+8]
       mov       rdx,[rsp+20]
       mov       rdx,[rdx+8]
       cmp       eax,[rdx+8]
       jae       short M02_L01
       movsxd    rax,eax
       mov       rdx,[rdx+rax*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rsi+10]
       mov       eax,1
       add       rsp,30
       pop       rsi
       ret
M02_L00:
       mov       rcx,rsi
       add       rsp,30
       pop       rsi
       jmp       near ptr System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNextRare()
M02_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
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
       sub       rsp,0A8
       xor       eax,eax
       mov       [rsp+68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       mov       [rsp+80],rax
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,[r9]
       mov       r14,[r9+8]
       mov       r15,[r9+10]
       mov       r12,[r9+18]
       test      rsi,rsi
       je        near ptr M03_L44
       xor       r13d,r13d
       mov       eax,[rsi+8]
       mov       [rsp+64],eax
       mov       [rsp+9C],eax
       xor       r8d,r8d
       test      rbx,rbx
       je        near ptr M03_L06
       mov       rcx,offset MT_System.ICustomFormatter
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       [rsp+0F8],rbx
       mov       rcx,rbx
       mov       r11,7FFB36B204B0
       call      qword ptr [7FFB36ED04B0]
       mov       rdx,rax
       mov       rcx,offset MT_System.ICustomFormatter
       call      CORINFO_HELP_CHKCASTINTERFACE
       mov       [rsp+58],rax
       mov       r8d,[rsp+9C]
       test      r8d,r8d
       mov       edx,r8d
       mov       rbx,[rsp+0F8]
       mov       r8,[rsp+58]
       jle       near ptr M03_L07
M03_L00:
       mov       eax,[rsp+64]
       cmp       r13d,eax
       jae       near ptr M03_L49
       movsxd    rcx,r13d
       movzx     r9d,word ptr [rsi+rcx*2+0C]
       inc       r13d
       cmp       r9d,7D
       jne       short M03_L01
       cmp       r13d,edx
       jge       near ptr M03_L47
       cmp       r13d,eax
       jae       near ptr M03_L49
       movsxd    rcx,r13d
       cmp       word ptr [rsi+rcx*2+0C],7D
       jne       near ptr M03_L47
       inc       r13d
       mov       [rsp+9C],edx
       mov       [rsp+64],eax
       mov       [rsp+58],r8
       jmp       short M03_L05
M03_L01:
       cmp       r9d,7B
       jne       short M03_L03
       mov       [rsp+9C],edx
       cmp       r13d,edx
       jge       short M03_L04
       mov       [rsp+64],eax
       cmp       r13d,eax
       jae       near ptr M03_L49
       movsxd    rcx,r13d
       cmp       word ptr [rsi+rcx*2+0C],7B
       jne       short M03_L02
       inc       r13d
       mov       [rsp+58],r8
       jmp       short M03_L05
M03_L02:
       mov       eax,[rsp+64]
       jmp       short M03_L04
M03_L03:
       mov       [rsp+9C],edx
       mov       [rsp+64],eax
       mov       [rsp+58],r8
       jmp       short M03_L05
M03_L04:
       dec       r13d
       mov       [rsp+64],eax
       mov       edx,[rsp+9C]
       jmp       short M03_L07
M03_L05:
       mov       rcx,rdi
       mov       edx,r9d
       call      System.Text.StringBuilder.Append(Char)
       mov       r8,[rsp+58]
M03_L06:
       mov       edx,[rsp+9C]
       cmp       r13d,edx
       jl        near ptr M03_L00
M03_L07:
       cmp       r13d,edx
       je        near ptr M03_L43
       inc       r13d
       cmp       r13d,edx
       je        near ptr M03_L47
       mov       eax,[rsp+64]
       cmp       r13d,eax
       jae       near ptr M03_L49
       movsxd    rcx,r13d
       movzx     r9d,word ptr [rsi+rcx*2+0C]
       cmp       r9d,30
       jl        near ptr M03_L47
       cmp       r9d,39
       jg        near ptr M03_L47
       xor       ecx,ecx
M03_L08:
       lea       ecx,[rcx+rcx*4]
       lea       ecx,[r9+rcx*2+0FFD0]
       inc       r13d
       cmp       r13d,edx
       je        near ptr M03_L47
       cmp       r13d,eax
       jae       near ptr M03_L49
       movsxd    r9,r13d
       movzx     r9d,word ptr [rsi+r9*2+0C]
       cmp       r9d,30
       jl        short M03_L09
       cmp       r9d,39
       jg        short M03_L09
       cmp       ecx,0F4240
       jl        short M03_L08
M03_L09:
       mov       r10d,[r12+8]
       cmp       r10d,ecx
       jle       near ptr M03_L45
M03_L10:
       cmp       r13d,edx
       jge       short M03_L12
       cmp       r13d,eax
       jae       near ptr M03_L49
       movsxd    r9,r13d
       movzx     r9d,word ptr [rsi+r9*2+0C]
       cmp       r9d,20
       jne       short M03_L11
       inc       r13d
       jmp       short M03_L10
M03_L11:
       mov       [rsp+58],r8
       jmp       short M03_L13
M03_L12:
       mov       [rsp+58],r8
       jmp       short M03_L13
M03_L13:
       xor       r11d,r11d
       xor       r8d,r8d
       cmp       r9d,2C
       jne       near ptr M03_L18
       inc       r13d
M03_L14:
       cmp       r13d,edx
       jge       short M03_L15
       cmp       r13d,eax
       jae       near ptr M03_L49
       movsxd    r9,r13d
       cmp       word ptr [rsi+r9*2+0C],20
       jne       short M03_L15
       inc       r13d
       jmp       short M03_L14
M03_L15:
       cmp       r13d,edx
       je        near ptr M03_L47
       cmp       r13d,eax
       jae       near ptr M03_L49
       movsxd    r9,r13d
       movzx     r9d,word ptr [rsi+r9*2+0C]
       cmp       r9d,2D
       jne       short M03_L16
       mov       dword ptr [rsp+98],1
       inc       r13d
       cmp       r13d,edx
       je        near ptr M03_L47
       cmp       r13d,eax
       jae       near ptr M03_L49
       movsxd    r9,r13d
       movzx     r9d,word ptr [rsi+r9*2+0C]
       mov       r11d,[rsp+98]
M03_L16:
       cmp       r9d,30
       jl        near ptr M03_L47
       cmp       r9d,39
       jg        near ptr M03_L47
M03_L17:
       lea       r8d,[r8+r8*4]
       lea       r8d,[r9+r8*2+0FFD0]
       inc       r13d
       cmp       r13d,edx
       je        near ptr M03_L47
       cmp       r13d,eax
       jae       near ptr M03_L49
       movsxd    r9,r13d
       movzx     r9d,word ptr [rsi+r9*2+0C]
       cmp       r9d,30
       jl        short M03_L18
       cmp       r9d,39
       jg        short M03_L18
       mov       [rsp+94],r8d
       cmp       r8d,0F4240
       mov       r8d,[rsp+94]
       jl        short M03_L17
M03_L18:
       cmp       r13d,edx
       jge       short M03_L19
       cmp       r13d,eax
       jae       near ptr M03_L49
       movsxd    r9,r13d
       movzx     r9d,word ptr [rsi+r9*2+0C]
       cmp       r9d,20
       je        short M03_L22
M03_L19:
       test      ecx,ecx
       je        near ptr M03_L25
       cmp       ecx,1
       jne       short M03_L23
       mov       [rsp+30],r14
       mov       r10,r14
M03_L20:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       r9d,3A
       jne       near ptr M03_L27
       inc       r13d
       mov       r9d,r13d
M03_L21:
       mov       [rsp+9C],edx
       cmp       r13d,edx
       mov       [rsp+0F8],rbx
       je        near ptr M03_L47
       cmp       r13d,eax
       jae       near ptr M03_L49
       movsxd    rbx,r13d
       movzx     ebx,word ptr [rsi+rbx*2+0C]
       cmp       ebx,7D
       je        short M03_L26
       cmp       ebx,7B
       je        near ptr M03_L47
       inc       r13d
       mov       edx,[rsp+9C]
       mov       rbx,[rsp+0F8]
       jmp       short M03_L21
M03_L22:
       inc       r13d
       jmp       near ptr M03_L18
M03_L23:
       cmp       ecx,2
       jne       short M03_L24
       mov       r10,r15
       mov       [rsp+30],r14
       jmp       short M03_L20
M03_L24:
       cmp       ecx,r10d
       jae       near ptr M03_L49
       movsxd    rcx,ecx
       mov       r10,[r12+rcx*8+10]
       mov       [rsp+30],r14
       jmp       near ptr M03_L20
M03_L25:
       mov       rcx,rbp
       mov       [rsp+30],r14
       mov       r10,rcx
       jmp       near ptr M03_L20
M03_L26:
       cmp       r13d,r9d
       jle       short M03_L28
       mov       r14d,r13d
       sub       r14d,r9d
       mov       ecx,r9d
       mov       [rsp+0A0],rcx
       mov       ecx,r14d
       add       rcx,[rsp+0A0]
       mov       [rsp+0A0],rcx
       mov       [rsp+64],eax
       mov       ecx,eax
       cmp       [rsp+0A0],rcx
       ja        near ptr M03_L46
       lea       rcx,[rsi+0C]
       movsxd    r9,r9d
       lea       rcx,[rcx+r9*2]
       mov       eax,[rsp+64]
       jmp       short M03_L28
M03_L27:
       cmp       r9d,7D
       mov       [rsp+9C],edx
       mov       [rsp+0F8],rbx
       jne       near ptr M03_L47
M03_L28:
       inc       r13d
       xor       r9d,r9d
       xor       ebx,ebx
       cmp       qword ptr [rsp+58],0
       je        near ptr M03_L30
       test      r14d,r14d
       mov       [rsp+64],eax
       mov       [rsp+94],r8d
       mov       [rsp+98],r11d
       je        near ptr M03_L33
       mov       [rsp+50],r10
       lea       r9,[rsp+78]
       mov       [rsp+28],rcx
       mov       [r9],rcx
       mov       [r9+8],r14d
       lea       rdx,[rsp+78]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rbx,rax
       mov       r10,[rsp+50]
M03_L29:
       mov       rcx,[rsp+58]
       mov       r9,[rsp+0F8]
       mov       rdx,rbx
       mov       [rsp+50],r10
       mov       r8,r10
       mov       r11,7FFB36B204A8
       call      qword ptr [7FFB36EE04A8]
       mov       r9,rax
       mov       eax,[rsp+64]
       mov       rcx,[rsp+28]
       mov       r8d,[rsp+94]
       mov       r10,[rsp+50]
       mov       r11d,[rsp+98]
M03_L30:
       mov       [rsp+48],r9
       test      r9,r9
       mov       [rsp+28],rcx
       jne       near ptr M03_L37
       mov       [rsp+64],eax
       mov       [rsp+94],r8d
       mov       [rsp+98],r11d
       mov       [rsp+50],r10
       mov       rdx,r10
       mov       rcx,offset MT_System.ISpanFormattable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rcx,rax
       mov       [rsp+40],rcx
       test      rcx,rcx
       je        near ptr M03_L34
       cmp       dword ptr [rsp+98],0
       jne       short M03_L31
       cmp       dword ptr [rsp+94],0
       jne       near ptr M03_L34
M03_L31:
       mov       rdx,[rdi+8]
       mov       r9,rdx
       mov       r11d,[rdi+18]
       mov       r10d,r11d
       mov       edx,[rdx+8]
       sub       edx,r11d
       mov       r11d,r10d
       mov       ecx,edx
       add       rcx,r11
       mov       r11d,[r9+8]
       cmp       rcx,r11
       ja        near ptr M03_L48
       add       r9,10
       movsxd    rcx,r10d
       lea       rcx,[r9+rcx*2]
       mov       r9,[rsp+40]
       lea       r11,[rsp+68]
       mov       [r11],rcx
       mov       [r11+8],edx
       lea       r11,[rsp+88]
       lea       rcx,[rsp+78]
       mov       r10,[rsp+28]
       mov       [rcx],r10
       mov       [rcx+8],r14d
       mov       rdx,[rsp+0F8]
       mov       [rsp+20],rdx
       mov       rcx,r9
       lea       rdx,[rsp+68]
       mov       r8,r11
       lea       r9,[rsp+78]
       mov       r11,7FFB36B204A0
       call      qword ptr [7FFB36EE04A0]
       test      eax,eax
       je        near ptr M03_L34
       mov       ecx,[rsp+88]
       add       [rdi+18],ecx
       mov       r14d,[rsp+94]
       mov       r8d,r14d
       sub       r8d,[rsp+88]
       cmp       dword ptr [rsp+98],0
       je        short M03_L32
       mov       r9d,r8d
       mov       rbx,[rsp+0F8]
       mov       r8,[rsp+58]
       mov       r14,[rsp+30]
       test      r9d,r9d
       jle       near ptr M03_L06
       mov       [rsp+58],r8
       mov       rcx,rdi
       mov       r8d,r9d
       mov       edx,20
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r8,[rsp+58]
       jmp       near ptr M03_L06
M03_L32:
       mov       rbx,[rsp+0F8]
       mov       r8,[rsp+58]
       mov       r14,[rsp+30]
       jmp       near ptr M03_L06
M03_L33:
       mov       [rsp+28],rcx
       jmp       near ptr M03_L29
M03_L34:
       mov       rdx,[rsp+50]
       mov       rcx,offset MT_System.IFormattable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       [rsp+38],rax
       test      rax,rax
       je        short M03_L36
       mov       rax,[rsp+38]
       test      r14d,r14d
       je        short M03_L35
       test      rbx,rbx
       jne       short M03_L35
       mov       [rsp+38],rax
       lea       rdx,[rsp+78]
       mov       rbx,[rsp+28]
       mov       [rdx],rbx
       mov       [rdx+8],r14d
       lea       rdx,[rsp+78]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rbx,rax
       mov       rax,[rsp+38]
M03_L35:
       mov       rcx,rax
       mov       r8,[rsp+0F8]
       mov       rdx,rbx
       mov       r11,7FFB36B20498
       call      qword ptr [7FFB36EE0498]
       mov       rbx,rax
       mov       [rsp+48],rbx
       mov       eax,[rsp+64]
       mov       r8d,[rsp+94]
       mov       r11d,[rsp+98]
       jmp       short M03_L37
M03_L36:
       mov       r14,[rsp+50]
       test      r14,r14
       je        near ptr M03_L42
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rbx,rax
       mov       [rsp+48],rbx
       mov       eax,[rsp+64]
       mov       r8d,[rsp+94]
       mov       r11d,[rsp+98]
M03_L37:
       mov       r9,[rsp+48]
       test      r9,r9
       jne       short M03_L38
       mov       r9,2459A4E3060
       mov       r9,[r9]
       mov       rbx,r9
       mov       r9,rbx
M03_L38:
       mov       [rsp+48],r9
       mov       ebx,r8d
       sub       ebx,[r9+8]
       mov       [rsp+98],r11d
       test      r11d,r11d
       mov       r9,[rsp+48]
       jne       near ptr M03_L41
       test      ebx,ebx
       mov       [rsp+64],eax
       jle       short M03_L39
       mov       [rsp+48],r9
       mov       rcx,rdi
       mov       r8d,ebx
       mov       edx,20
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r9,[rsp+48]
M03_L39:
       mov       rcx,rdi
       mov       rdx,r9
       call      System.Text.StringBuilder.Append(System.String)
       cmp       dword ptr [rsp+98],0
       je        short M03_L40
       mov       r9d,ebx
       mov       rbx,[rsp+0F8]
       mov       r8,[rsp+58]
       mov       r14,[rsp+30]
       test      r9d,r9d
       jle       near ptr M03_L06
       mov       [rsp+58],r8
       mov       rcx,rdi
       mov       r8d,r9d
       mov       edx,20
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r8,[rsp+58]
       jmp       near ptr M03_L06
M03_L40:
       mov       rbx,[rsp+0F8]
       mov       r8,[rsp+58]
       mov       r14,[rsp+30]
       jmp       near ptr M03_L06
M03_L41:
       mov       [rsp+64],eax
       jmp       short M03_L39
M03_L42:
       mov       eax,[rsp+64]
       mov       r8d,[rsp+94]
       mov       r11d,[rsp+98]
       jmp       near ptr M03_L37
M03_L43:
       mov       rax,rdi
       add       rsp,0A8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L44:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,31D
       mov       rdx,7FFB36B14020
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L45:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0C23B
       mov       rdx,7FFB36B14020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       dword ptr [rsi+74],80131537
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L46:
       mov       ecx,21
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M03_L47:
       call      System.Text.StringBuilder.FormatError()
       int       3
M03_L48:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M03_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2331
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M04_L00
       mov       rax,2459A4E3060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M04_L01
       xor       ebx,ebx
       jmp       short M04_L02
M04_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M04_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M04_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M04_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M04_L04
       cmp       eax,0
       jbe       near ptr M04_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M04_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M04_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB36B14020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB36B14020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M04_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.CreateStringBuilder02()
       push      rdi
       push      rsi
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
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
       mov       rcx,[rsi+68]
       mov       edx,[rcx+14]
       mov       [rsp+40],rcx
       xor       ecx,ecx
       mov       [rsp+48],rcx
       mov       [rsp+50],ecx
       mov       [rsp+54],edx
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       rcx,[rsp+48]
       mov       r9,[rcx+30]
       mov       rcx,[rcx+58]
       xor       r8d,r8d
       mov       rdx,1C811571360
       mov       rdx,[rdx]
       mov       rax,1C8215710E0
       mov       rax,[rax]
       lea       r10,[rsp+20]
       mov       [r10],r9
       mov       [r10+8],rcx
       mov       [r10+10],r8
       mov       [r10+18],rdx
       mov       rcx,rdi
       lea       r9,[rsp+20]
       mov       r8,rax
       xor       edx,edx
       call      System.Text.StringBuilder.AppendFormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M00_L00
M00_L01:
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB36EB31E8]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 285
```
```assembly
; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       eax,[rsi+14]
       cmp       eax,[rcx+14]
       jne       short M01_L00
       mov       eax,[rsi+10]
       mov       [rsp+20],rcx
       cmp       eax,[rcx+10]
       jae       short M01_L00
       lea       rcx,[rsi+8]
       mov       rdx,[rsp+20]
       mov       rdx,[rdx+8]
       cmp       eax,[rdx+8]
       jae       short M01_L01
       movsxd    rax,eax
       mov       rdx,[rdx+rax*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rsi+10]
       mov       eax,1
       add       rsp,30
       pop       rsi
       ret
M01_L00:
       mov       rcx,rsi
       add       rsp,30
       pop       rsi
       jmp       near ptr System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNextRare()
M01_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
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
       sub       rsp,0A8
       xor       eax,eax
       mov       [rsp+68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       mov       [rsp+80],rax
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,[r9]
       mov       r14,[r9+8]
       mov       r15,[r9+10]
       mov       r12,[r9+18]
       test      rsi,rsi
       je        near ptr M02_L44
       xor       r13d,r13d
       mov       eax,[rsi+8]
       mov       [rsp+64],eax
       mov       [rsp+9C],eax
       xor       r8d,r8d
       test      rbx,rbx
       je        near ptr M02_L06
       mov       rcx,offset MT_System.ICustomFormatter
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       [rsp+0F8],rbx
       mov       rcx,rbx
       mov       r11,7FFB36B004B0
       call      qword ptr [7FFB36EC04B0]
       mov       rdx,rax
       mov       rcx,offset MT_System.ICustomFormatter
       call      CORINFO_HELP_CHKCASTINTERFACE
       mov       [rsp+58],rax
       mov       r8d,[rsp+9C]
       test      r8d,r8d
       mov       edx,r8d
       mov       rbx,[rsp+0F8]
       mov       r8,[rsp+58]
       jle       near ptr M02_L07
M02_L00:
       mov       eax,[rsp+64]
       cmp       r13d,eax
       jae       near ptr M02_L49
       movsxd    rcx,r13d
       movzx     r9d,word ptr [rsi+rcx*2+0C]
       inc       r13d
       cmp       r9d,7D
       jne       short M02_L01
       cmp       r13d,edx
       jge       near ptr M02_L47
       cmp       r13d,eax
       jae       near ptr M02_L49
       movsxd    rcx,r13d
       cmp       word ptr [rsi+rcx*2+0C],7D
       jne       near ptr M02_L47
       inc       r13d
       mov       [rsp+9C],edx
       mov       [rsp+64],eax
       mov       [rsp+58],r8
       jmp       short M02_L05
M02_L01:
       cmp       r9d,7B
       jne       short M02_L03
       mov       [rsp+9C],edx
       cmp       r13d,edx
       jge       short M02_L04
       mov       [rsp+64],eax
       cmp       r13d,eax
       jae       near ptr M02_L49
       movsxd    rcx,r13d
       cmp       word ptr [rsi+rcx*2+0C],7B
       jne       short M02_L02
       inc       r13d
       mov       [rsp+58],r8
       jmp       short M02_L05
M02_L02:
       mov       eax,[rsp+64]
       jmp       short M02_L04
M02_L03:
       mov       [rsp+9C],edx
       mov       [rsp+64],eax
       mov       [rsp+58],r8
       jmp       short M02_L05
M02_L04:
       dec       r13d
       mov       [rsp+64],eax
       mov       edx,[rsp+9C]
       jmp       short M02_L07
M02_L05:
       mov       rcx,rdi
       mov       edx,r9d
       call      System.Text.StringBuilder.Append(Char)
       mov       r8,[rsp+58]
M02_L06:
       mov       edx,[rsp+9C]
       cmp       r13d,edx
       jl        near ptr M02_L00
M02_L07:
       cmp       r13d,edx
       je        near ptr M02_L43
       inc       r13d
       cmp       r13d,edx
       je        near ptr M02_L47
       mov       eax,[rsp+64]
       cmp       r13d,eax
       jae       near ptr M02_L49
       movsxd    rcx,r13d
       movzx     r9d,word ptr [rsi+rcx*2+0C]
       cmp       r9d,30
       jl        near ptr M02_L47
       cmp       r9d,39
       jg        near ptr M02_L47
       xor       ecx,ecx
M02_L08:
       lea       ecx,[rcx+rcx*4]
       lea       ecx,[r9+rcx*2+0FFD0]
       inc       r13d
       cmp       r13d,edx
       je        near ptr M02_L47
       cmp       r13d,eax
       jae       near ptr M02_L49
       movsxd    r9,r13d
       movzx     r9d,word ptr [rsi+r9*2+0C]
       cmp       r9d,30
       jl        short M02_L09
       cmp       r9d,39
       jg        short M02_L09
       cmp       ecx,0F4240
       jl        short M02_L08
M02_L09:
       mov       r10d,[r12+8]
       cmp       r10d,ecx
       jle       near ptr M02_L45
M02_L10:
       cmp       r13d,edx
       jge       short M02_L12
       cmp       r13d,eax
       jae       near ptr M02_L49
       movsxd    r9,r13d
       movzx     r9d,word ptr [rsi+r9*2+0C]
       cmp       r9d,20
       jne       short M02_L11
       inc       r13d
       jmp       short M02_L10
M02_L11:
       mov       [rsp+58],r8
       jmp       short M02_L13
M02_L12:
       mov       [rsp+58],r8
       jmp       short M02_L13
M02_L13:
       xor       r11d,r11d
       xor       r8d,r8d
       cmp       r9d,2C
       jne       near ptr M02_L18
       inc       r13d
M02_L14:
       cmp       r13d,edx
       jge       short M02_L15
       cmp       r13d,eax
       jae       near ptr M02_L49
       movsxd    r9,r13d
       cmp       word ptr [rsi+r9*2+0C],20
       jne       short M02_L15
       inc       r13d
       jmp       short M02_L14
M02_L15:
       cmp       r13d,edx
       je        near ptr M02_L47
       cmp       r13d,eax
       jae       near ptr M02_L49
       movsxd    r9,r13d
       movzx     r9d,word ptr [rsi+r9*2+0C]
       cmp       r9d,2D
       jne       short M02_L16
       mov       dword ptr [rsp+98],1
       inc       r13d
       cmp       r13d,edx
       je        near ptr M02_L47
       cmp       r13d,eax
       jae       near ptr M02_L49
       movsxd    r9,r13d
       movzx     r9d,word ptr [rsi+r9*2+0C]
       mov       r11d,[rsp+98]
M02_L16:
       cmp       r9d,30
       jl        near ptr M02_L47
       cmp       r9d,39
       jg        near ptr M02_L47
M02_L17:
       lea       r8d,[r8+r8*4]
       lea       r8d,[r9+r8*2+0FFD0]
       inc       r13d
       cmp       r13d,edx
       je        near ptr M02_L47
       cmp       r13d,eax
       jae       near ptr M02_L49
       movsxd    r9,r13d
       movzx     r9d,word ptr [rsi+r9*2+0C]
       cmp       r9d,30
       jl        short M02_L18
       cmp       r9d,39
       jg        short M02_L18
       mov       [rsp+94],r8d
       cmp       r8d,0F4240
       mov       r8d,[rsp+94]
       jl        short M02_L17
M02_L18:
       cmp       r13d,edx
       jge       short M02_L19
       cmp       r13d,eax
       jae       near ptr M02_L49
       movsxd    r9,r13d
       movzx     r9d,word ptr [rsi+r9*2+0C]
       cmp       r9d,20
       je        short M02_L22
M02_L19:
       test      ecx,ecx
       je        near ptr M02_L25
       cmp       ecx,1
       jne       short M02_L23
       mov       [rsp+30],r14
       mov       r10,r14
M02_L20:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       r9d,3A
       jne       near ptr M02_L27
       inc       r13d
       mov       r9d,r13d
M02_L21:
       mov       [rsp+9C],edx
       cmp       r13d,edx
       mov       [rsp+0F8],rbx
       je        near ptr M02_L47
       cmp       r13d,eax
       jae       near ptr M02_L49
       movsxd    rbx,r13d
       movzx     ebx,word ptr [rsi+rbx*2+0C]
       cmp       ebx,7D
       je        short M02_L26
       cmp       ebx,7B
       je        near ptr M02_L47
       inc       r13d
       mov       edx,[rsp+9C]
       mov       rbx,[rsp+0F8]
       jmp       short M02_L21
M02_L22:
       inc       r13d
       jmp       near ptr M02_L18
M02_L23:
       cmp       ecx,2
       jne       short M02_L24
       mov       r10,r15
       mov       [rsp+30],r14
       jmp       short M02_L20
M02_L24:
       cmp       ecx,r10d
       jae       near ptr M02_L49
       movsxd    rcx,ecx
       mov       r10,[r12+rcx*8+10]
       mov       [rsp+30],r14
       jmp       near ptr M02_L20
M02_L25:
       mov       rcx,rbp
       mov       [rsp+30],r14
       mov       r10,rcx
       jmp       near ptr M02_L20
M02_L26:
       cmp       r13d,r9d
       jle       short M02_L28
       mov       r14d,r13d
       sub       r14d,r9d
       mov       ecx,r9d
       mov       [rsp+0A0],rcx
       mov       ecx,r14d
       add       rcx,[rsp+0A0]
       mov       [rsp+0A0],rcx
       mov       [rsp+64],eax
       mov       ecx,eax
       cmp       [rsp+0A0],rcx
       ja        near ptr M02_L46
       lea       rcx,[rsi+0C]
       movsxd    r9,r9d
       lea       rcx,[rcx+r9*2]
       mov       eax,[rsp+64]
       jmp       short M02_L28
M02_L27:
       cmp       r9d,7D
       mov       [rsp+9C],edx
       mov       [rsp+0F8],rbx
       jne       near ptr M02_L47
M02_L28:
       inc       r13d
       xor       r9d,r9d
       xor       ebx,ebx
       cmp       qword ptr [rsp+58],0
       je        near ptr M02_L30
       test      r14d,r14d
       mov       [rsp+64],eax
       mov       [rsp+94],r8d
       mov       [rsp+98],r11d
       je        near ptr M02_L33
       mov       [rsp+50],r10
       lea       r9,[rsp+78]
       mov       [rsp+28],rcx
       mov       [r9],rcx
       mov       [r9+8],r14d
       lea       rdx,[rsp+78]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rbx,rax
       mov       r10,[rsp+50]
M02_L29:
       mov       rcx,[rsp+58]
       mov       r9,[rsp+0F8]
       mov       rdx,rbx
       mov       [rsp+50],r10
       mov       r8,r10
       mov       r11,7FFB36B004A8
       call      qword ptr [7FFB36EC04A8]
       mov       r9,rax
       mov       eax,[rsp+64]
       mov       rcx,[rsp+28]
       mov       r8d,[rsp+94]
       mov       r10,[rsp+50]
       mov       r11d,[rsp+98]
M02_L30:
       mov       [rsp+48],r9
       test      r9,r9
       mov       [rsp+28],rcx
       jne       near ptr M02_L37
       mov       [rsp+64],eax
       mov       [rsp+94],r8d
       mov       [rsp+98],r11d
       mov       [rsp+50],r10
       mov       rdx,r10
       mov       rcx,offset MT_System.ISpanFormattable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rcx,rax
       mov       [rsp+40],rcx
       test      rcx,rcx
       je        near ptr M02_L34
       cmp       dword ptr [rsp+98],0
       jne       short M02_L31
       cmp       dword ptr [rsp+94],0
       jne       near ptr M02_L34
M02_L31:
       mov       rdx,[rdi+8]
       mov       r9,rdx
       mov       r11d,[rdi+18]
       mov       r10d,r11d
       mov       edx,[rdx+8]
       sub       edx,r11d
       mov       r11d,r10d
       mov       ecx,edx
       add       rcx,r11
       mov       r11d,[r9+8]
       cmp       rcx,r11
       ja        near ptr M02_L48
       add       r9,10
       movsxd    rcx,r10d
       lea       rcx,[r9+rcx*2]
       mov       r9,[rsp+40]
       lea       r11,[rsp+68]
       mov       [r11],rcx
       mov       [r11+8],edx
       lea       r11,[rsp+88]
       lea       rcx,[rsp+78]
       mov       r10,[rsp+28]
       mov       [rcx],r10
       mov       [rcx+8],r14d
       mov       rdx,[rsp+0F8]
       mov       [rsp+20],rdx
       mov       rcx,r9
       lea       rdx,[rsp+68]
       mov       r8,r11
       lea       r9,[rsp+78]
       mov       r11,7FFB36B004A0
       call      qword ptr [7FFB36EC04A0]
       test      eax,eax
       je        near ptr M02_L34
       mov       ecx,[rsp+88]
       add       [rdi+18],ecx
       mov       r14d,[rsp+94]
       mov       r8d,r14d
       sub       r8d,[rsp+88]
       cmp       dword ptr [rsp+98],0
       je        short M02_L32
       mov       r9d,r8d
       mov       rbx,[rsp+0F8]
       mov       r8,[rsp+58]
       mov       r14,[rsp+30]
       test      r9d,r9d
       jle       near ptr M02_L06
       mov       [rsp+58],r8
       mov       rcx,rdi
       mov       r8d,r9d
       mov       edx,20
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r8,[rsp+58]
       jmp       near ptr M02_L06
M02_L32:
       mov       rbx,[rsp+0F8]
       mov       r8,[rsp+58]
       mov       r14,[rsp+30]
       jmp       near ptr M02_L06
M02_L33:
       mov       [rsp+28],rcx
       jmp       near ptr M02_L29
M02_L34:
       mov       rdx,[rsp+50]
       mov       rcx,offset MT_System.IFormattable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       [rsp+38],rax
       test      rax,rax
       je        short M02_L36
       mov       rax,[rsp+38]
       test      r14d,r14d
       je        short M02_L35
       test      rbx,rbx
       jne       short M02_L35
       mov       [rsp+38],rax
       lea       rdx,[rsp+78]
       mov       rbx,[rsp+28]
       mov       [rdx],rbx
       mov       [rdx+8],r14d
       lea       rdx,[rsp+78]
       xor       ecx,ecx
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rbx,rax
       mov       rax,[rsp+38]
M02_L35:
       mov       rcx,rax
       mov       r8,[rsp+0F8]
       mov       rdx,rbx
       mov       r11,7FFB36B00498
       call      qword ptr [7FFB36EC0498]
       mov       rbx,rax
       mov       [rsp+48],rbx
       mov       eax,[rsp+64]
       mov       r8d,[rsp+94]
       mov       r11d,[rsp+98]
       jmp       short M02_L37
M02_L36:
       mov       r14,[rsp+50]
       test      r14,r14
       je        near ptr M02_L42
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rbx,rax
       mov       [rsp+48],rbx
       mov       eax,[rsp+64]
       mov       r8d,[rsp+94]
       mov       r11d,[rsp+98]
M02_L37:
       mov       r9,[rsp+48]
       test      r9,r9
       jne       short M02_L38
       mov       r9,1C811573060
       mov       r9,[r9]
       mov       rbx,r9
       mov       r9,rbx
M02_L38:
       mov       [rsp+48],r9
       mov       ebx,r8d
       sub       ebx,[r9+8]
       mov       [rsp+98],r11d
       test      r11d,r11d
       mov       r9,[rsp+48]
       jne       near ptr M02_L41
       test      ebx,ebx
       mov       [rsp+64],eax
       jle       short M02_L39
       mov       [rsp+48],r9
       mov       rcx,rdi
       mov       r8d,ebx
       mov       edx,20
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r9,[rsp+48]
M02_L39:
       mov       rcx,rdi
       mov       rdx,r9
       call      System.Text.StringBuilder.Append(System.String)
       cmp       dword ptr [rsp+98],0
       je        short M02_L40
       mov       r9d,ebx
       mov       rbx,[rsp+0F8]
       mov       r8,[rsp+58]
       mov       r14,[rsp+30]
       test      r9d,r9d
       jle       near ptr M02_L06
       mov       [rsp+58],r8
       mov       rcx,rdi
       mov       r8d,r9d
       mov       edx,20
       call      System.Text.StringBuilder.Append(Char, Int32)
       mov       r8,[rsp+58]
       jmp       near ptr M02_L06
M02_L40:
       mov       rbx,[rsp+0F8]
       mov       r8,[rsp+58]
       mov       r14,[rsp+30]
       jmp       near ptr M02_L06
M02_L41:
       mov       [rsp+64],eax
       jmp       short M02_L39
M02_L42:
       mov       eax,[rsp+64]
       mov       r8d,[rsp+94]
       mov       r11d,[rsp+98]
       jmp       near ptr M02_L37
M02_L43:
       mov       rax,rdi
       add       rsp,0A8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L44:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,31D
       mov       rdx,7FFB36AF4020
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L45:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0C23B
       mov       rdx,7FFB36AF4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       dword ptr [rsi+74],80131537
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L46:
       mov       ecx,21
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M02_L47:
       call      System.Text.StringBuilder.FormatError()
       int       3
M02_L48:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M02_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2331
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M03_L00
       mov       rax,1C811573060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M03_L01
       xor       ebx,ebx
       jmp       short M03_L02
M03_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M03_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M03_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M03_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M03_L04
       cmp       eax,0
       jbe       near ptr M03_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M03_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M03_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB36AF4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB36AF4020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

