## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rcx,[rsi+0D8]
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
       mov       rdx,249B7D41340
       mov       rdx,[rdx]
       mov       rax,249D7D47150
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
       call      qword ptr [7FFA7EF431E8]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 288
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
       mov       r11,7FFA7EB90498
       call      qword ptr [7FFA7EF50498]
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
       mov       r11,7FFA7EB90490
       call      qword ptr [7FFA7EF50490]
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
       mov       r11,7FFA7EB90488
       call      qword ptr [7FFA7EF50488]
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
       mov       r11,7FFA7EB90480
       call      qword ptr [7FFA7EF50480]
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
       mov       r9,249B7D43020
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
       mov       rdx,7FFA7EB84020
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
       mov       rdx,7FFA7EB84020
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
       mov       rax,249B7D43020
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
       mov       rdx,7FFA7EB84020
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
       mov       rdx,7FFA7EB84020
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetPropertyValues01()
; 			var person = RandomData.GeneratePerson<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = TypeHelper.GetPropertyValues(person);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
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
       mov       rcx,offset MD_dotNetTips.Spargine.Tester.RandomData.GeneratePerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Core.TypeHelper.GetPropertyValues(!!0)
       call      dotNetTips.Spargine.Core.TypeHelper.GetPropertyValues[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 122
```
```assembly
; dotNetTips.Spargine.Tester.RandomData.GeneratePerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
; 			var person = new T
; 			^^^^^^^^^^^^^^^^^^
; 			{
; 			 
; 				Id = RandomData.GenerateKey(),
; 				                              
; 				Address1 = RandomData.GenerateWord(addressLength),
; 				                                                  
; 				Address2 = RandomData.GenerateWord(addressLength),
; 				                                                  
; 				BornOn = DateTimeOffset.Now.Subtract(new TimeSpan(365 * GenerateInteger(1, 75), 0, 0, 0)),
; 				                                                                                          
; 				CellPhone = GeneratePhoneNumberUSA(),
; 				                                     
; 				City = RandomData.GenerateWord(cityLength),
; 				                                           
; 				Country = RandomData.GenerateWord(countryLength),
; 				                                                 
; 				Email = RandomData.GenerateEmailAddress(),
; 				                                          
; 				FirstName = RandomData.GenerateWord(firstNameLength),
; 				                                                     
; 				HomePhone = GeneratePhoneNumberUSA(),
; 				                                     
; 				LastName = RandomData.GenerateWord(lastNameLength),
; 				                                                   
; 				PostalCode = RandomData.GenerateNumber(postalCodeLength),
; 				                                                         
; 				State = RandomData.GenerateWord(stateLength)
; 				                                            
; 			};
; 			  
; 			return person;
; 			^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+60],rax
       mov       [rsp+68],rax
       mov       [rsp+70],rcx
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
       mov       rdx,7FFA7EFAE708
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       rbp,rax
       call      dotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFA7EB70570
       call      qword ptr [7FFA7EF40570]
       mov       ecx,esi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFA7EB70578
       call      qword ptr [7FFA7EF40578]
       mov       ecx,esi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFA7EB70580
       call      qword ptr [7FFA7EF40580]
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+60]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       xor       ecx,ecx
       mov       [rsp+58],rcx
       mov       ecx,1
       mov       edx,4B
       call      dotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      edx,eax,16D
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       lea       rcx,[rsp+58]
       xor       r8d,r8d
       xor       r9d,r9d
       call      System.TimeSpan..ctor(Int32, Int32, Int32, Int32, Int32)
       lea       rcx,[rsp+60]
       lea       rdx,[rsp+48]
       mov       r8,[rsp+58]
       call      System.DateTimeOffset.Subtract(System.TimeSpan)
       vmovupd   xmm0,[rsp+48]
       vmovupd   [rsp+38],xmm0
       mov       rcx,rbp
       lea       rdx,[rsp+38]
       mov       r11,7FFA7EB70588
       call      qword ptr [7FFA7EF40588]
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFA7EB70590
       call      qword ptr [7FFA7EF40590]
       mov       ecx,edi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFA7EB70598
       call      qword ptr [7FFA7EF40598]
       mov       ecx,ebx
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFA7EB705A0
       call      qword ptr [7FFA7EF405A0]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFA7EB705A8
       call      qword ptr [7FFA7EF405A8]
       mov       ecx,[rsp+0C0]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFA7EB705B0
       call      qword ptr [7FFA7EF405B0]
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFA7EB705B8
       call      qword ptr [7FFA7EF405B8]
       mov       ecx,[rsp+0C8]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFA7EB705C0
       call      qword ptr [7FFA7EF405C0]
       mov       ecx,[rsp+0D0]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFA7EB705C8
       call      qword ptr [7FFA7EF405C8]
       mov       ecx,[rsp+0D8]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFA7EB705D0
       call      qword ptr [7FFA7EF405D0]
       mov       rax,rbp
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 586
```
```assembly
; dotNetTips.Spargine.Core.TypeHelper.GetPropertyValues[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,19087AC1028
       mov       r8,[r8]
       mov       rdx,19087AC75B0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       xor       edx,edx
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rcx,rsi
       call      00007FFADE7E0330
       mov       rbp,rax
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Extensions+<GetAllProperties>d__9
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+30],0FFFFFFFE
       mov       rcx,7FFA7EC60020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L00
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L00:
       cmp       [rcx],ecx
       call      00007FFADE7E1100
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
       mov       rdx,7FFA7EFEC440
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
       mov       rdx,7FFA7EFEC440
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
       je        near ptr M02_L19
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.TypeHelper+<>c__13`1[[System.__Canon, System.Private.CoreLib]].<GetPropertyValues>b__13_0(System.Reflection.PropertyInfo)
       mov       [r12+18],rcx
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rdi
       mov       rdx,7FFA7EFEC440
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
       mov       rcx,offset MD_System.Linq.Enumerable.Where(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       r14,rax
       cmp       qword ptr [rbp+10],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       jmp       short M02_L09
M02_L08:
       mov       rcx,rdi
       mov       rdx,7FFA7EFEC440
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
       mov       rdx,7FFA7EFEC440
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
       je        near ptr M02_L19
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.TypeHelper+<>c__13`1[[System.__Canon, System.Private.CoreLib]].<GetPropertyValues>b__13_1(System.Reflection.PropertyInfo)
       mov       [r12+18],rcx
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdi
       mov       rdx,7FFA7EFEC440
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
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       mov       rdx,r14
       mov       r8,r15
       xor       r9d,r9d
       call      System.Linq.OrderedEnumerable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>, Boolean, System.Linq.OrderedEnumerable`1<System.__Canon>)
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M02_L18
M02_L15:
       movsxd    rcx,ebp
       mov       r15,[rdi+rcx*8+10]
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       rdx,19097AC1180
       mov       rdx,[rdx]
       mov       r8d,4
       call      System.String.Compare(System.String, System.String, System.StringComparison)
       test      eax,eax
       jne       near ptr M02_L16
       mov       rcx,r15
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[r15]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.IDictionary
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r12,rax
       test      r12,r12
       je        near ptr M02_L17
       mov       rcx,r12
       mov       r11,7FFA7EB70460
       call      qword ptr [7FFA7EF30460]
       test      eax,eax
       jle       near ptr M02_L17
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       mov       rcx,r12
       mov       edx,2C
       call      dotNetTips.Spargine.Core.Extensions.ToDelimitedString(System.Collections.IDictionary, Char)
       lea       r8,[rsp+38]
       mov       [r8],r15
       mov       [r8+8],rax
       lea       r8,[rsp+38]
       mov       rdx,rbx
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Extensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0)
       call      dotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       jmp       short M02_L17
M02_L16:
       mov       rcx,r15
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[r15]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       mov       r12,rax
       test      r12,r12
       je        short M02_L17
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       lea       r8,[rsp+38]
       mov       [r8],r15
       mov       [r8+8],rax
       lea       r8,[rsp+38]
       mov       rdx,rbx
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Extensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0)
       call      dotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
M02_L17:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M02_L15
M02_L18:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Collections.Immutable.ImmutableDictionary.ToImmutableDictionary(System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<!!0,!!1>>, System.Collections.Generic.IEqualityComparer`1<!!0>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       xor       r8d,r8d
       xor       r9d,r9d
       call      System.Collections.Immutable.ImmutableDictionary.ToImmutableDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L19:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 1064
```

