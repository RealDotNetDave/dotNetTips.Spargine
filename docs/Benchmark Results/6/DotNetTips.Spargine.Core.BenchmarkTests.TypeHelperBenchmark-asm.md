## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
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
       call      000000000000B2D0
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      000000000000B400
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
; 			foreach (var person in this._people)
; 			                       ^^^^^^^^^^^^
       mov       rbx,[rsi+0B8]
       mov       ebp,[rbx+14]
       xor       r14d,r14d
       jmp       short 000000000000ACFB
       mov       rdx,22F30821568
       mov       rdx,[rdx]
       mov       r8,[rcx+30]
       mov       rcx,[rcx+58]
       xor       r9d,r9d
       mov       rax,22F30821388
       mov       rax,[rax]
       mov       r10,22F3082B518
       mov       r10,[r10]
       mov       [rsp+20],r8
       mov       [rsp+28],rcx
       mov       [rsp+30],r9
       mov       [rsp+38],rax
       mov       rcx,rdi
       mov       r8,r10
       lea       r9,[rsp+20]
       call      000000000000C088
       mov       rcx,rbx
       cmp       ebp,[rcx+14]
       jne       short 000000000000AD25
       cmp       r14d,[rbx+10]
       jae       short 000000000000AD2A
       mov       rcx,[rbx+8]
       cmp       r14d,[rcx+8]
       jae       short 000000000000AD6A
       movsxd    rdx,r14d
       mov       rcx,[rcx+rdx*8+10]
       inc       r14d
       mov       edx,1
       jmp       short 000000000000AD35
       cmp       ebp,[rbx+14]
       jne       short 000000000000AD64
       mov       r14d,[rbx+10]
       inc       r14d
       xor       ecx,ecx
       xor       edx,edx
       test      edx,edx
       jne       near ptr 000000000000ACA5
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [2180]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
       call      0000000000009730
       int       3
       call      000000000000F130
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
       je        near ptr 000000000000E47C
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       mov       r12d,r15d
       xor       r13d,r13d
       test      rbp,rbp
       je        short 000000000000DD17
       mov       rcx,offset MT_System.ICustomFormatter
       call      0000000000004F40
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EE80560
       call      qword ptr [560]
       mov       rdx,rax
       mov       rcx,offset MT_System.ICustomFormatter
       call      0000000000007460
       mov       r13,rax
       cmp       r14d,r12d
       jge       short 000000000000DD86
       cmp       r14d,r15d
       jae       near ptr 000000000000E687
       movsxd    rcx,r14d
       movzx     eax,word ptr [rsi+rcx*2+0C]
       inc       r14d
       cmp       eax,7D
       je        near ptr 000000000000E4B5
       cmp       eax,7B
       jne       short 000000000000DD60
       cmp       r14d,r12d
       jge       short 000000000000DD5B
       cmp       r14d,r15d
       jae       near ptr 000000000000E687
       movsxd    rcx,r14d
       cmp       word ptr [rsi+rcx*2+0C],7B
       je        near ptr 000000000000E4DE
       dec       r14d
       jmp       short 000000000000DD86
       mov       ecx,[rdi+18]
       mov       edx,ecx
       mov       r8,[rdi+8]
       cmp       [r8+8],edx
       jbe       near ptr 000000000000DF2F
       movsxd    rdx,edx
       mov       [r8+rdx*2+10],ax
       inc       ecx
       mov       [rdi+18],ecx
       cmp       r14d,r12d
       jl        short 000000000000DD1C
       cmp       r14d,r12d
       je        near ptr 000000000000E209
       inc       r14d
       cmp       r14d,r12d
       je        near ptr 000000000000E661
       cmp       r14d,r15d
       jae       near ptr 000000000000E687
       movsxd    rax,r14d
       movzx     eax,word ptr [rsi+rax*2+0C]
       cmp       eax,30
       jl        near ptr 000000000000E661
       cmp       eax,39
       jg        near ptr 000000000000E661
       xor       edx,edx
       lea       edx,[rdx+rdx*4]
       lea       edx,[rax+rdx*2+0FFD0]
       inc       r14d
       cmp       r14d,r12d
       je        near ptr 000000000000E661
       cmp       r14d,r15d
       jae       near ptr 000000000000E687
       movsxd    rax,r14d
       movzx     eax,word ptr [rsi+rax*2+0C]
       cmp       eax,30
       jl        short 000000000000DDF6
       cmp       eax,39
       jg        short 000000000000DDF6
       cmp       edx,0F4240
       jl        short 000000000000DDC0
       mov       rcx,[rbx+18]
       cmp       [rcx+8],edx
       jle       near ptr 000000000000E4E6
       cmp       r14d,r12d
       jge       short 000000000000DE23
       cmp       r14d,r15d
       jae       near ptr 000000000000E687
       movsxd    rax,r14d
       movzx     eax,word ptr [rsi+rax*2+0C]
       cmp       eax,20
       jne       short 000000000000DE23
       inc       r14d
       jmp       short 000000000000DE03
       xor       r8d,r8d
       mov       [rsp+0B0],r8d
       xor       r9d,r9d
       mov       [rsp+0AC],r9d
       cmp       eax,2C
       je        near ptr 000000000000E527
       cmp       r14d,r12d
       jge       short 000000000000DE6F
       cmp       r14d,r15d
       jae       near ptr 000000000000E687
       movsxd    rax,r14d
       movzx     eax,word ptr [rsi+rax*2+0C]
       mov       [rsp+0B4],eax
       cmp       eax,20
       mov       eax,[rsp+0B4]
       je        near ptr 000000000000E614
       test      edx,edx
       jne       near ptr 000000000000DF11
       mov       r10,[rbx]
       mov       [rsp+50],r10
       xor       r11d,r11d
       xor       edx,edx
       cmp       eax,3A
       jne       near ptr 000000000000E09D
       inc       r14d
       mov       ecx,r14d
       cmp       r14d,r12d
       je        near ptr 000000000000E661
       cmp       r14d,r15d
       jae       near ptr 000000000000E687
       movsxd    rax,r14d
       movzx     eax,word ptr [rsi+rax*2+0C]
       cmp       eax,7D
       je        near ptr 000000000000E05B
       cmp       eax,7B
       je        near ptr 000000000000E661
       inc       r14d
       jmp       short 000000000000DE93
       mov       rcx,r13
       mov       r9,rbp
       mov       [rsp+40],rax
       mov       rdx,rax
       mov       r8,r10
       mov       r11,7FF82EE80558
       call      qword ptr [558]
       mov       r10,rax
       mov       rcx,r10
       mov       rax,[rsp+40]
       mov       edx,[rsp+94]
       mov       r10,[rsp+50]
       mov       r11,[rsp+30]
       mov       [rsp+48],rcx
       test      rcx,rcx
       jne       near ptr 000000000000E40B
       jmp       short 000000000000DF44
       mov       [rsp+0B4],eax
       mov       rcx,rbx
       call      0000000000008E98
       mov       r10,rax
       mov       eax,[rsp+0B4]
       jmp       near ptr 000000000000DE7A
       mov       rcx,rdi
       mov       edx,eax
       mov       r8d,1
       call      000000000000CD00
       jmp       near ptr 000000000000DD81
       mov       [rsp+94],edx
       mov       [rsp+30],r11
       mov       [rsp+40],rax
       mov       rdx,r10
       mov       rcx,offset MT_System.ISpanFormattable
       call      0000000000007438
       test      rax,rax
       je        near ptr 000000000000E286
       cmp       dword ptr [rsp+0B0],0
       jne       near ptr 000000000000E03A
       cmp       dword ptr [rsp+0AC],0
       jne       near ptr 000000000000E286
       mov       [rsp+58],r13
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
       ja        near ptr 000000000000E65B
       add       r9,10
       mov       edx,r11d
       lea       r11,[r9+rdx*2]
       mov       r9,offset MT_System.Byte
       cmp       [rax],r9
       jne       near ptr 000000000000E220
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
       jne       near ptr 000000000000E2AD
       mov       [rsp+8C],edx
       mov       ecx,eax
       mov       edx,1
       cmp       eax,186A0
       jae       short 000000000000E044
       cmp       ecx,0A
       jb        near ptr 000000000000E100
       cmp       ecx,64
       jae       near ptr 000000000000E0E3
       inc       edx
       jmp       near ptr 000000000000E100
       mov       [rsp+58],r13
       jmp       near ptr 000000000000DF91
       mov       ecx,eax
       shr       ecx,5
       imul      rcx,0A7C5AC5
       shr       rcx,27
       mov       edx,6
       jmp       short 000000000000E021
       cmp       r14d,ecx
       jle       short 000000000000E0A6
       mov       edx,r14d
       sub       edx,ecx
       mov       r11d,ecx
       mov       eax,edx
       add       rax,r11
       mov       r11d,r15d
       cmp       rax,r11
       ja        near ptr 000000000000E61C
       lea       rax,[rsi+0C]
       mov       ecx,ecx
       lea       r11,[rax+rcx*2]
       mov       [rsp+30],r11
       mov       [rsp+94],edx
       mov       edx,[rsp+94]
       mov       r11,[rsp+30]
       jmp       short 000000000000E0A6
       cmp       eax,7D
       jne       near ptr 000000000000E661
       inc       r14d
       xor       ecx,ecx
       xor       eax,eax
       mov       [rsp+40],rax
       mov       [rsp+58],r13
       test      r13,r13
       mov       rax,[rsp+40]
       mov       r13,[rsp+58]
       je        near ptr 000000000000DF01
       mov       [rsp+94],edx
       test      edx,edx
       jne       near ptr 000000000000E627
       mov       [rsp+30],r11
       jmp       near ptr 000000000000DEC4
       cmp       ecx,3E8
       jae       short 000000000000E0F0
       add       edx,2
       jmp       short 000000000000E100
       cmp       ecx,2710
       jae       short 000000000000E0FD
       add       edx,3
       jmp       short 000000000000E100
       add       edx,4
       cmp       edx,0FFFFFFFF
       jle       short 000000000000E109
       mov       ecx,edx
       jmp       short 000000000000E10E
       mov       ecx,0FFFFFFFF
       mov       edx,[rsp+8C]
       cmp       ecx,edx
       jg        near ptr 000000000000E1F9
       mov       [rsp+0A0],ecx
       mov       [rsp+98],r11
       movsxd    rcx,ecx
       lea       rcx,[r11+rcx*2]
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
       jne       short 000000000000E133
       xor       eax,eax
       mov       [rsp+98],rax
       mov       r11d,1
       xor       eax,eax
       mov       [rsp+98],rax
       test      r11d,r11d
       mov       [rsp+94],r9d
       je        short 000000000000E1EF
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
       ja        near ptr 000000000000E65B
       cmp       eax,r9d
       ja        near ptr 000000000000E661
       add       edx,[rsp+0A0]
       mov       [rdi+18],edx
       mov       r8d,[rsp+0AC]
       sub       r8d,[rsp+0A0]
       cmp       dword ptr [rsp+0B0],0
       jne       near ptr 000000000000E667
       mov       r13,[rsp+58]
       jmp       near ptr 000000000000DD17
       mov       r13,[rsp+58]
       jmp       near ptr 000000000000E286
       xor       r11d,r11d
       mov       [rsp+0A0],r11d
       jmp       near ptr 000000000000E16D
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
       mov       r11,7FF82EE80550
       call      qword ptr [550]
       mov       r11d,eax
       mov       [rsp+30],r13
       mov       r9d,[rsp+94]
       jmp       near ptr 000000000000E177
       mov       rdx,[rsp+50]
       mov       rcx,offset MT_System.IFormattable
       call      0000000000007438
       mov       [rsp+38],rax
       test      rax,rax
       je        near ptr 000000000000E3EF
       jmp       near ptr 000000000000E35B
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
       call      00000000000010B8
       mov       r11d,eax
       mov       r9d,[rsp+94]
       jmp       near ptr 000000000000E177
       mov       r9d,[rsp+0AC]
       mov       [rsp+48],rcx
       mov       eax,r9d
       sub       eax,[rcx+8]
       cmp       dword ptr [rsp+0B0],0
       jne       short 000000000000E352
       mov       [rsp+0A8],eax
       test      eax,eax
       jg        near ptr 000000000000E435
       mov       rcx,rdi
       mov       rdx,[rsp+48]
       call      000000000000CD10
       cmp       dword ptr [rsp+0B0],0
       jne       near ptr 000000000000E458
       jmp       near ptr 000000000000DD17
       mov       [rsp+0A8],eax
       jmp       short 000000000000E332
       mov       r8d,[rsp+94]
       test      r8d,r8d
       je        short 000000000000E39A
       mov       r9,[rsp+40]
       test      r9,r9
       mov       [rsp+40],r9
       jne       short 000000000000E39A
       mov       r10,[rsp+30]
       mov       [rsp+78],r10
       mov       [rsp+80],r8d
       lea       rdx,[rsp+78]
       xor       ecx,ecx
       call      0000000000008B10
       mov       [rsp+40],rax
       mov       rcx,offset MT_System.Byte
       mov       rax,[rsp+38]
       cmp       [rax],rcx
       jne       short 000000000000E3C7
       add       rax,8
       movzx     ecx,byte ptr [rax]
       mov       rdx,[rsp+40]
       mov       r8,rbp
       call      00000000000011A0
       mov       r10,rax
       jmp       short 000000000000E3E5
       mov       rcx,rax
       mov       r8,rbp
       mov       rdx,[rsp+40]
       mov       r11,7FF82EE80548
       call      qword ptr [548]
       mov       r10,rax
       mov       rax,r10
       mov       [rsp+48],rax
       jmp       short 000000000000E40B
       mov       rdx,[rsp+50]
       test      rdx,rdx
       je        short 000000000000E40B
       mov       rcx,rdx
       mov       rax,[rdx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rsp+48],rax
       mov       rcx,[rsp+48]
       test      rcx,rcx
       jne       near ptr 000000000000E306
       mov       rcx,22F30823020
       mov       rdx,[rcx]
       mov       [rsp+48],rdx
       mov       rcx,[rsp+48]
       jmp       near ptr 000000000000E306
       mov       eax,[rsp+0A8]
       mov       rcx,rdi
       mov       [rsp+0A8],eax
       mov       r8d,eax
       mov       edx,20
       call      000000000000CD00
       jmp       near ptr 000000000000E332
       mov       edx,[rsp+0A8]
       test      edx,edx
       jle       near ptr 000000000000DD17
       mov       rcx,rdi
       mov       r8d,edx
       mov       edx,20
       call      000000000000CD00
       jmp       near ptr 000000000000DD17
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       r14,rax
       mov       ecx,31B
       mov       rdx,7FF82EE74000
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,r14
       call      00000000000001D8
       mov       rcx,r14
       call      00000000000055B0
       cmp       r14d,r12d
       jge       near ptr 000000000000E661
       cmp       r14d,r15d
       jae       near ptr 000000000000E687
       movsxd    rcx,r14d
       cmp       word ptr [rsi+rcx*2+0C],7D
       jne       near ptr 000000000000E661
       inc       r14d
       jmp       near ptr 000000000000DD60
       inc       r14d
       jmp       near ptr 000000000000DD60
       mov       rcx,offset MT_System.FormatException
       call      000000000000B2D0
       mov       r14,rax
       mov       ecx,0C5F3
       mov       rdx,7FF82EE74000
       call      0000000000000390
       mov       rcx,rax
       call      0000000000002398
       mov       rdx,rax
       mov       rcx,r14
       call      000000000000E198
       mov       rcx,r14
       call      00000000000055B0
       inc       r14d
       jmp       short 000000000000E52F
       inc       r14d
       cmp       r14d,r12d
       jge       short 000000000000E548
       cmp       r14d,r15d
       jae       near ptr 000000000000E687
       movsxd    rcx,r14d
       cmp       word ptr [rsi+rcx*2+0C],20
       je        short 000000000000E52C
       cmp       r14d,r12d
       je        near ptr 000000000000E661
       cmp       r14d,r15d
       jae       near ptr 000000000000E687
       movsxd    rcx,r14d
       movzx     eax,word ptr [rsi+rcx*2+0C]
       mov       ecx,eax
       cmp       ecx,2D
       jne       short 000000000000E594
       mov       r8d,1
       inc       r14d
       cmp       r14d,r12d
       je        near ptr 000000000000E661
       cmp       r14d,r15d
       jae       near ptr 000000000000E687
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       mov       [rsp+0B0],r8d
       cmp       ecx,30
       jl        near ptr 000000000000E661
       cmp       ecx,39
       jg        near ptr 000000000000E661
       mov       r9d,[rsp+0AC]
       lea       r9d,[r9+r9*4]
       lea       r9d,[rcx+r9*2+0FFD0]
       mov       eax,r9d
       inc       r14d
       cmp       r14d,r12d
       je        near ptr 000000000000E661
       cmp       r14d,r15d
       jae       near ptr 000000000000E687
       movsxd    rcx,r14d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,30
       mov       [rsp+0AC],eax
       mov       eax,ecx
       jl        near ptr 000000000000DE42
       cmp       eax,39
       jg        near ptr 000000000000DE42
       mov       r9d,[rsp+0AC]
       cmp       r9d,0F4240
       mov       [rsp+0AC],r9d
       mov       ecx,eax
       jl        short 000000000000E5A6
       mov       eax,ecx
       jmp       near ptr 000000000000DE42
       inc       r14d
       jmp       near ptr 000000000000DE42
       mov       ecx,21
       call      0000000000009668
       int       3
       mov       [rsp+30],r11
       mov       [rsp+78],r11
       mov       edx,[rsp+94]
       mov       [rsp+80],edx
       lea       rdx,[rsp+78]
       xor       ecx,ecx
       call      0000000000008B10
       mov       rdx,rax
       mov       rax,rdx
       mov       r10,[rsp+50]
       jmp       near ptr 000000000000DEC4
       call      0000000000009580
       int       3
       call      000000000000C080
       int       3
       test      r8d,r8d
       mov       r13,[rsp+58]
       jle       near ptr 000000000000DD17
       mov       rcx,rdi
       mov       edx,20
       call      000000000000CD00
       jmp       near ptr 000000000000DD17
       call      000000000000F130
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
       je        short 000000000000F0A5
       call      00000000000088D0
       mov       rdi,rax
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short 000000000000F092
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short 000000000000F0B9
       cmp       [rdx+8],r8d
       jb        short 000000000000F0B9
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      000000000000E808
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short 000000000000F059
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rax,22F30823020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,1747F
       mov       rdx,7FF82EE74000
       call      0000000000000390
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF82EE74000
       call      0000000000000390
       mov       rcx,rax
       call      0000000000002398
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      0000000000005760
       mov       rcx,rsi
       call      00000000000055B0
       int       3
; Total bytes of code 213
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.CreateStringBuilder01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			foreach (var person in this._people)
; 			                       ^^^^^^^^^^^^
; 				_ = sb.AppendFormat(CultureInfo.InvariantCulture, "{0}={1}", person.Email, person.PostalCode);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,offset MT_System.Text.StringBuilder
       call      000000000000EFB0
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      000000000000F0D0
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       mov       rbx,[rsi+0B8]
       mov       ebp,[rbx+14]
       xor       r14d,r14d
       jmp       short 000000000000D811
       mov       rdx,25DC6800558
       mov       rdx,[rdx]
       mov       r8,[rcx+30]
       mov       rcx,[rcx+58]
       mov       [rsp+30],r8
       mov       [rsp+38],rcx
       lea       rcx,[rsp+30]
       mov       r8,25DC68031C8
       mov       r8,[r8]
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],2
       mov       rcx,rdi
       lea       r9,[rsp+20]
       call      qword ptr [7A08]
       mov       rcx,rbx
       cmp       ebp,[rcx+14]
       jne       short 000000000000D862
       cmp       r14d,[rbx+10]
       jae       short 000000000000D867
       mov       rcx,[rbx+8]
       cmp       r14d,[rcx+8]
       jae       short 000000000000D87B
       mov       edx,r14d
       mov       rcx,[rcx+rdx*8+10]
       inc       r14d
       mov       edx,1
       test      edx,edx
       jne       short 000000000000D7C5
       mov       rsi,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [0E838]
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
       cmp       ebp,[rbx+14]
       jne       short 000000000000D874
       mov       r14d,[rbx+10]
       inc       r14d
       xor       ecx,ecx
       xor       edx,edx
       jmp       short 000000000000D839
       call      qword ptr [7600]
       int       3
       call      00000000000023D0
       int       3
; Total bytes of code 289
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
       sub       rsp,98
       xor       eax,eax
       mov       [rsp+58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,[r9]
       mov       r14d,[r9+8]
       test      rsi,rsi
       je        near ptr 000000000000D176
       test      rbx,rbx
       jne       short 000000000000CAAD
       xor       edx,edx
       jmp       short 000000000000CAD2
       mov       rcx,offset MT_System.ICustomFormatter
       call      0000000000003330
       mov       rdx,rax
       mov       rcx,rbx
       mov       r11,7FF819280580
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,offset MT_System.ICustomFormatter
       call      qword ptr [5888]
       mov       r15,rax
       xor       r12d,r12d
       mov       r13d,[rsi+8]
       cmp       r13d,r12d
       jbe       near ptr 000000000000D0D5
       mov       ecx,r12d
       cmp       r13d,ecx
       jb        near ptr 000000000000D119
       mov       edx,ecx
       lea       rax,[rsi+rdx*2+0C]
       mov       r10d,r13d
       sub       r10d,ecx
       mov       rdx,rax
       mov       [rsp+28],rdx
       mov       eax,r10d
       mov       [rsp+78],eax
       mov       rcx,rdx
       mov       edx,7B
       mov       r8d,7D
       mov       r9d,eax
       call      qword ptr [9420]
       mov       [rsp+8C],eax
       test      eax,eax
       jl        near ptr 000000000000D0EC
       cmp       eax,[rsp+78]
       ja        near ptr 000000000000D168
       mov       rdx,[rsp+28]
       mov       rcx,rdi
       mov       r8d,eax
       call      qword ptr [7AC8]
       add       r12d,[rsp+8C]
       cmp       r12d,r13d
       jae       near ptr 000000000000D194
       mov       ecx,r12d
       movzx     eax,word ptr [rsi+rcx*2+0C]
       inc       r12d
       cmp       r13d,r12d
       jbe       near ptr 000000000000D16F
       mov       ecx,r12d
       movzx     edx,word ptr [rsi+rcx*2+0C]
       cmp       eax,edx
       jne       short 000000000000CBD7
       mov       ecx,[rdi+18]
       mov       r8,[rdi+8]
       mov       eax,[r8+8]
       cmp       eax,ecx
       jbe       short 000000000000CBC6
       mov       ecx,ecx
       mov       [r8+rcx*2+10],dx
       inc       dword ptr [rdi+18]
       inc       r12d
       jmp       near ptr 000000000000CAE8
       lea       edx,[rdx+rdx*4]
       lea       edx,[rcx+rdx*2+0FFD0]
       inc       r12d
       cmp       r13d,r12d
       jbe       near ptr 000000000000D16F
       jmp       short 000000000000CC21
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7360]
       jmp       short 000000000000CBA9
       cmp       eax,7B
       jne       near ptr 000000000000D16F
       xor       eax,eax
       mov       [rsp+94],eax
       mov       [rsp+90],eax
       xor       r9d,r9d
       xor       r10d,r10d
       add       edx,0FFFFFFD0
       cmp       edx,0A
       jae       near ptr 000000000000D16F
       inc       r12d
       cmp       r13d,r12d
       jbe       near ptr 000000000000D16F
       mov       ecx,r12d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,7D
       je        near ptr 000000000000CD92
       jmp       short 000000000000CC29
       mov       ecx,r12d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       lea       r11d,[rcx+0FFD0]
       cmp       r11d,9
       ja        short 000000000000CC3F
       cmp       edx,0F4240
       jl        near ptr 000000000000CBB1
       cmp       ecx,20
       jne       short 000000000000CC5D
       inc       r12d
       cmp       r13d,r12d
       jbe       near ptr 000000000000D16F
       mov       ecx,r12d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,20
       je        short 000000000000CC44
       cmp       ecx,2C
       jne       near ptr 000000000000CD21
       inc       r12d
       cmp       r13d,r12d
       jbe       near ptr 000000000000D16F
       mov       ecx,r12d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,20
       je        short 000000000000CC66
       cmp       ecx,2D
       jne       short 000000000000CCA4
       mov       eax,1
       inc       r12d
       cmp       r13d,r12d
       jbe       near ptr 000000000000D16F
       mov       ecx,r12d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       mov       [rsp+90],eax
       lea       r8d,[rcx+0FFD0]
       cmp       r8d,0A
       jae       near ptr 000000000000D16F
       inc       r12d
       cmp       r13d,r12d
       jbe       near ptr 000000000000D16F
       mov       ecx,r12d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       jmp       short 000000000000CCE8
       nop       dword ptr [rax]
       lea       r8d,[r8+r8*4]
       lea       r8d,[rcx+r8*2+0FFD0]
       inc       r12d
       cmp       r13d,r12d
       jbe       near ptr 000000000000D16F
       mov       ecx,r12d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       lea       r11d,[rcx+0FFD0]
       cmp       r11d,9
       ja        short 000000000000CCFB
       cmp       r8d,0F4240
       jl        short 000000000000CCCB
       cmp       ecx,20
       jne       short 000000000000CD56
       inc       r12d
       cmp       r13d,r12d
       jbe       near ptr 000000000000D16F
       mov       ecx,r12d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,20
       je        short 000000000000CD00
       mov       [rsp+94],r8d
       cmp       ecx,7D
       je        short 000000000000CD92
       cmp       ecx,3A
       jne       near ptr 000000000000D16F
       mov       r9d,r12d
       inc       r12d
       cmp       r13d,r12d
       jbe       near ptr 000000000000D16F
       mov       ecx,r12d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,7D
       je        short 000000000000CD60
       cmp       ecx,7B
       je        near ptr 000000000000D16F
       jmp       short 000000000000CD32
       mov       [rsp+94],r8d
       jmp       short 000000000000CD21
       inc       r9d
       mov       r10d,r12d
       sub       r10d,r9d
       mov       ecx,r9d
       mov       r11d,r10d
       add       rcx,r11
       mov       r11d,r13d
       cmp       rcx,r11
       ja        near ptr 000000000000D119
       mov       ecx,r9d
       lea       r9,[rsi+rcx*2+0C]
       mov       r13,r9
       mov       r9d,r10d
       mov       r10d,r9d
       mov       r9,r13
       inc       r12d
       xor       r13d,r13d
       xor       r11d,r11d
       cmp       edx,r14d
       jae       near ptr 000000000000D125
       mov       ecx,edx
       mov       rdx,[rbp+rcx*8]
       mov       [rsp+40],rdx
       test      r15,r15
       je        short 000000000000CE14
       test      r10d,r10d
       je        near ptr 000000000000CF76
       mov       [rsp+30],r9
       mov       [rsp+68],r9
       mov       [rsp+7C],r10d
       mov       [rsp+70],r10d
       lea       rcx,[rsp+68]
       call      000000000000A6C0
       mov       r13,rax
       mov       r11,r13
       mov       rcx,r15
       mov       r9,rbx
       mov       [rsp+48],r11
       mov       rdx,r11
       mov       r8,[rsp+40]
       mov       r11,7FF819280598
       call      qword ptr [r11]
       mov       r13,rax
       mov       r9,[rsp+30]
       mov       r10d,[rsp+7C]
       mov       r11,[rsp+48]
       test      r13,r13
       mov       [rsp+7C],r10d
       mov       [rsp+48],r11
       mov       [rsp+30],r9
       jne       near ptr 000000000000D038
       mov       rdx,[rsp+40]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [5810]
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr 000000000000CF85
       mov       r13d,[rsp+90]
       test      r13d,r13d
       jne       short 000000000000CE68
       cmp       dword ptr [rsp+94],0
       jne       near ptr 000000000000CF6C
       mov       rdx,[rdi+8]
       mov       r9,rdx
       mov       r11d,[rdi+18]
       mov       eax,r11d
       mov       edx,[rdx+8]
       sub       edx,r11d
       mov       r11d,eax
       mov       r10d,edx
       add       r11,r10
       mov       r10d,[r9+8]
       cmp       r11,r10
       ja        near ptr 000000000000D168
       mov       r11d,eax
       lea       r9,[r9+r11*2+10]
       mov       [rsp+58],r9
       mov       [rsp+60],edx
       mov       rax,[rsp+30]
       mov       [rsp+68],rax
       mov       r10d,[rsp+7C]
       mov       [rsp+70],r10d
       mov       [rsp+20],rbx
       lea       rdx,[rsp+58]
       lea       r9,[rsp+68]
       lea       r8,[rsp+80]
       mov       r11,7FF819280590
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr 000000000000CF62
       mov       r8d,[rsp+80]
       mov       rcx,[rdi+8]
       mov       rdx,rcx
       mov       eax,[rdi+18]
       mov       r9d,eax
       mov       ecx,[rcx+8]
       sub       ecx,eax
       mov       r9d,r9d
       mov       r10d,ecx
       add       r9,r10
       mov       edx,[rdx+8]
       cmp       r9,rdx
       ja        near ptr 000000000000D168
       cmp       r8d,ecx
       ja        near ptr 000000000000D16F
       add       eax,[rsp+80]
       mov       [rdi+18],eax
       test      r13d,r13d
       je        near ptr 000000000000CAE8
       mov       r13d,[rsp+94]
       cmp       r13d,[rsp+80]
       jle       near ptr 000000000000CAE8
       mov       r8d,r13d
       sub       r8d,[rsp+80]
       mov       rcx,rdi
       mov       edx,20
       call      qword ptr [7360]
       jmp       near ptr 000000000000CAE8
       mov       [rsp+90],r13d
       jmp       short 000000000000CF85
       mov       [rsp+90],r13d
       jmp       short 000000000000CF85
       mov       [rsp+7C],r10d
       mov       [rsp+30],r9
       jmp       near ptr 000000000000CDE2
       mov       rdx,[rsp+40]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [5810]
       mov       [rsp+38],rax
       test      rax,rax
       je        short 000000000000D002
       mov       rax,[rsp+38]
       mov       edx,[rsp+7C]
       test      edx,edx
       je        short 000000000000CFE5
       mov       r8,[rsp+48]
       test      r8,r8
       mov       [rsp+48],r8
       jne       short 000000000000CFE5
       mov       r9,[rsp+30]
       mov       [rsp+68],r9
       mov       [rsp+70],edx
       lea       rcx,[rsp+68]
       call      000000000000A6C0
       mov       rdx,rax
       mov       [rsp+48],rdx
       mov       rax,[rsp+38]
       mov       rcx,rax
       mov       r8,rbx
       mov       rdx,[rsp+48]
       mov       r11,7FF819280588
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short 000000000000D020
       mov       rdx,[rsp+40]
       test      rdx,rdx
       jne       short 000000000000D010
       xor       edx,edx
       jmp       short 000000000000D020
       mov       rcx,rdx
       mov       rax,[rdx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rdx,rax
       test      rdx,rdx
       mov       r13,rdx
       jne       short 000000000000D038
       mov       rdx,25DC4800030
       mov       rdx,[rdx]
       mov       r13,rdx
       mov       r9d,[r13+8]
       mov       [rsp+54],r9d
       mov       r8d,[rsp+94]
       cmp       r9d,r8d
       jl        short 000000000000D063
       mov       r8d,r9d
       lea       rdx,[r13+0C]
       mov       rcx,rdi
       call      qword ptr [7AC8]
       jmp       near ptr 000000000000CAE8
       cmp       dword ptr [rsp+90],0
       je        short 000000000000D0A3
       mov       eax,r9d
       lea       rdx,[r13+0C]
       mov       rcx,rdi
       mov       r8d,eax
       call      qword ptr [7AC8]
       mov       r13d,[rsp+94]
       mov       r8d,r13d
       sub       r8d,[rsp+54]
       mov       rcx,rdi
       mov       edx,20
       call      qword ptr [7360]
       jmp       near ptr 000000000000CAE8
       mov       r8d,[rsp+94]
       sub       r8d,r9d
       mov       rcx,rdi
       mov       edx,20
       call      qword ptr [7360]
       mov       edx,[rsp+54]
       mov       r8d,edx
       lea       rdx,[r13+0C]
       mov       rcx,rdi
       call      qword ptr [7AC8]
       jmp       near ptr 000000000000CAE8
       mov       rax,rdi
       add       rsp,98
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
       mov       r12,[rsp+28]
       mov       rdx,r12
       mov       rcx,rdi
       mov       r8d,[rsp+78]
       call      qword ptr [7AC8]
       mov       rax,rdi
       add       rsp,98
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
       mov       ecx,21
       call      qword ptr [7390]
       int       3
       mov       rcx,offset MT_System.FormatException
       call      000000000000EFB0
       mov       rsi,rax
       mov       ecx,0C1FA
       mov       rdx,7FF819274000
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [9030]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [5D08]
       mov       rcx,rsi
       call      0000000000006AD0
       call      qword ptr [7048]
       int       3
       call      qword ptr [7738]
       int       3
       mov       ecx,31B
       mov       rdx,7FF819274000
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       call      00000000000023D0
       int       3
; Total bytes of code 1850
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short 000000000000D683
       call      000000000000A000
       mov       rdi,rax
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short 000000000000D670
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short 000000000000D697
       cmp       [rdx+8],r8d
       jb        short 000000000000D697
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [5810]
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short 000000000000D639
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rax,25DC4800030
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000EFB0
       mov       rsi,rax
       mov       ecx,17718
       mov       rdx,7FF819274000
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,99E2
       mov       rdx,7FF819274000
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [9030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [3030]
       mov       rcx,rsi
       call      0000000000006AD0
       int       3
; Total bytes of code 213
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
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
       call      000000000000E5E8
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.TypeHelper.GetPropertyValues(!!0)
       call      000000000000AE08
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
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
       je        short 0000000000008CB9
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       jmp       short 0000000000008CCB
       mov       rdx,7FF82F29EF38
       call      0000000000004920
       mov       rcx,rax
       call      000000000000B438
       mov       rbp,rax
       call      000000000000E5D0
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EE90688
       call      qword ptr [688]
       mov       ecx,esi
       call      000000000000D4A8
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EE90690
       call      qword ptr [690]
       mov       ecx,esi
       call      000000000000D4A8
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EE90698
       call      qword ptr [698]
       call      000000000000D760
       mov       rdx,rax
       lea       rcx,[rsp+50]
       mov       r8d,1
       call      000000000000E078
       mov       ecx,1
       mov       edx,4B
       call      000000000000D418
       imul      ecx,eax,16D
       jo        near ptr 0000000000008F7D
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rax,46DC5D638865
       cmp       rcx,rax
       jg        near ptr 0000000000008F82
       mov       rax,0B923A29C779B
       cmp       rcx,rax
       jl        near ptr 0000000000008F82
       imul      rsi,rcx,2710
       lea       rcx,[rsp+50]
       call      000000000000DE90
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rax
       sub       rdx,rsi
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr 0000000000008FAE
       mov       rcx,0
       and       rcx,rax
       or        rdx,rcx
       mov       ecx,[rsp+50]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr 0000000000008FB6
       mov       r8,0FF29406B2A1B
       cmp       rcx,r8
       jl        near ptr 0000000000008FB6
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+30],xmm0
       lea       rcx,[rsp+30]
       call      000000000000DE40
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rcx,rbp
       lea       rdx,[rsp+20]
       mov       r11,7FF82EE906A0
       call      qword ptr [6A0]
       call      000000000000D458
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EE906A8
       call      qword ptr [6A8]
       mov       ecx,edi
       call      000000000000D4A8
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EE906B0
       call      qword ptr [6B0]
       mov       ecx,ebx
       call      000000000000D4A8
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EE906B8
       call      qword ptr [6B8]
       call      000000000000D3F8
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EE906C0
       call      qword ptr [6C0]
       mov       ecx,[rsp+0B0]
       call      000000000000D4A8
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EE906C8
       call      qword ptr [6C8]
       call      000000000000D458
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EE906D0
       call      qword ptr [6D0]
       mov       ecx,[rsp+0B8]
       call      000000000000D4A8
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EE906D8
       call      qword ptr [6D8]
       mov       ecx,[rsp+0C0]
       call      000000000000D428
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EE906E0
       call      qword ptr [6E0]
       mov       ecx,[rsp+0C8]
       call      000000000000D4A8
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EE906E8
       call      qword ptr [6E8]
       mov       rax,rbp
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
       call      000000000000ECD0
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000B2D0
       mov       rsi,rax
       call      00000000000009A0
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      0000000000005760
       mov       rcx,rsi
       call      00000000000055B0
       xor       ecx,ecx
       call      000000000000DA78
       int       3
       call      0000000000009608
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
       call      000000000000B2D0
       mov       rbx,rax
       mov       rcx,rbx
       xor       edx,edx
       xor       r8d,r8d
       call      0000000000009D38
       mov       rcx,rsi
       call      000000000000F570
       mov       rbp,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Extensions+<GetAllProperties>d__10
       call      000000000000B2D0
       mov       r14,rax
       mov       dword ptr [r14+30],0FFFFFFFE
       call      0000000000001870
       mov       [r14+34],eax
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      000000000000AEB0
       mov       rbp,[rdi+10]
       cmp       qword ptr [rbp+10],0
       je        short 000000000000B811
       mov       rcx,[rbp+10]
       jmp       short 000000000000B826
       mov       rcx,rdi
       mov       rdx,7FF82F2FE3E0
       call      0000000000004920
       mov       rcx,rax
       call      0000000000006100
       mov       r8,[rax+8]
       test      r8,r8
       jne       near ptr 000000000000B8CB
       mov       r15,[rbp+10]
       test      r15,r15
       je        short 000000000000B843
       jmp       short 000000000000B858
       mov       rcx,rdi
       mov       rdx,7FF82F2FE3E0
       call      0000000000004920
       mov       r15,rax
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       r12,rax
       mov       rcx,r15
       call      0000000000006100
       mov       rdx,[rax]
       test      rdx,rdx
       je        near ptr 000000000000BC36
       lea       rcx,[r12+8]
       call      000000000000AEB0
       mov       rcx,offset DotNetTips.Spargine.Core.TypeHelper+<>c__13`1[[System.__Canon, System.Private.CoreLib]].<GetPropertyValues>b__13_0(System.Reflection.PropertyInfo)
       mov       [r12+18],rcx
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short 000000000000B8A2
       jmp       short 000000000000B8B7
       mov       rcx,rdi
       mov       rdx,7FF82F2FE3E0
       call      0000000000004920
       mov       rcx,rax
       call      0000000000006100
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      000000000000AEB0
       mov       r8,r12
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Where(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      00000000000044D8
       mov       r14,rax
       cmp       qword ptr [rbp+10],0
       je        short 000000000000B8ED
       mov       rcx,[rbp+10]
       jmp       short 000000000000B902
       mov       rcx,rdi
       mov       rdx,7FF82F2FE3E0
       call      0000000000004920
       mov       rcx,rax
       call      0000000000006100
       mov       r15,[rax+10]
       test      r15,r15
       jne       near ptr 000000000000B9A7
       mov       r15,[rbp+10]
       test      r15,r15
       je        short 000000000000B91F
       jmp       short 000000000000B934
       mov       rcx,rdi
       mov       rdx,7FF82F2FE3E0
       call      0000000000004920
       mov       r15,rax
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       r12,rax
       mov       rcx,r15
       call      0000000000006100
       mov       rdx,[rax]
       test      rdx,rdx
       je        near ptr 000000000000BC36
       lea       rcx,[r12+8]
       call      000000000000AEB0
       mov       rcx,offset DotNetTips.Spargine.Core.TypeHelper+<>c__13`1[[System.__Canon, System.Private.CoreLib]].<GetPropertyValues>b__13_1(System.Reflection.PropertyInfo)
       mov       [r12+18],rcx
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short 000000000000B97E
       jmp       short 000000000000B993
       mov       rcx,rdi
       mov       rdx,7FF82F2FE3E0
       call      0000000000004920
       mov       rcx,rax
       call      0000000000006100
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      000000000000AEB0
       mov       r15,r12
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      000000000000AEB0
       test      r14,r14
       je        near ptr 000000000000BC47
       test      r15,r15
       je        near ptr 000000000000BC3C
       xor       edx,edx
       mov       [rdi+10],rdx
       lea       rcx,[rdi+18]
       mov       rdx,r15
       call      000000000000AEB0
       mov       rdx,1C0C9122F28
       mov       rdx,[rdx]
       lea       rcx,[rdi+20]
       call      000000000000AEB0
       mov       byte ptr [rdi+28],0
       mov       rcx,rdi
       mov       r11,7FF82EE90528
       call      qword ptr [528]
       mov       rdi,rax
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr 000000000000BC07
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
       mov       rdx,1C0B9121908
       mov       rdx,[rdx]
       mov       r8d,4
       call      00000000000089F8
       test      eax,eax
       je        near ptr 000000000000BB4E
       mov       rcx,r15
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[r12+58]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.IDictionary
       call      0000000000007438
       mov       r13,rax
       test      r13,r13
       je        near ptr 000000000000BBF9
       mov       rcx,r13
       mov       r11,7FF82EE90520
       call      qword ptr [520]
       test      eax,eax
       jle       near ptr 000000000000BBF9
       mov       rcx,r15
       mov       rax,[r12+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       mov       rcx,r13
       mov       edx,2C
       call      0000000000002390
       mov       r12,rax
       mov       rcx,rbx
       mov       r11,7FF82EE90540
       call      qword ptr [540]
       test      eax,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000BC52
       lea       rcx,[rsp+30]
       mov       [rcx],r15
       mov       [rcx+8],r12
       mov       rcx,rbx
       lea       rdx,[rsp+30]
       mov       r11,7FF82EE90530
       call      qword ptr [530]
       test      eax,eax
       jne       near ptr 000000000000BBF9
       lea       rcx,[rsp+30]
       mov       [rcx],r15
       mov       [rcx+8],r12
       mov       rcx,rbx
       lea       rdx,[rsp+30]
       mov       r11,7FF82EE90538
       call      qword ptr [538]
       jmp       near ptr 000000000000BBF9
       mov       rcx,r15
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[r12+58]
       call      qword ptr [rax+30]
       mov       r13,rax
       test      r13,r13
       je        near ptr 000000000000BBF9
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
       mov       r11,7FF82EE90558
       call      qword ptr [558]
       test      eax,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000BD6B
       lea       rcx,[rsp+30]
       mov       [rcx],r15
       mov       [rcx+8],r12
       mov       rcx,rbx
       lea       rdx,[rsp+30]
       mov       r11,7FF82EE90548
       call      qword ptr [548]
       test      eax,eax
       jne       short 000000000000BBF9
       lea       rcx,[rsp+30]
       mov       [rcx],r15
       mov       [rcx+8],r12
       mov       rcx,rbx
       lea       rdx,[rsp+30]
       mov       r11,7FF82EE90550
       call      qword ptr [550]
       add       ebp,1
       jo        short 000000000000BC31
       cmp       r14d,ebp
       jg        near ptr 000000000000BA28
       mov       rdx,rbx
       mov       rcx,offset MD_System.Collections.Immutable.ImmutableDictionary.ToImmutableDictionary(System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<!!0,!!1>>, System.Collections.Generic.IEqualityComparer`1<!!0>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       xor       r8d,r8d
       xor       r9d,r9d
       call      000000000000B6F0
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
       call      000000000000ECD0
       call      0000000000007270
       int       3
       mov       ecx,9
       call      000000000000B010
       int       3
       mov       ecx,10
       call      000000000000B010
       int       3
       call      0000000000001628
       mov       rsi,rax
       call      0000000000001710
       mov       rdx,rax
       mov       rcx,rsi
       call      0000000000000480
       mov       rsi,rax
       mov       rax,1C0B9121910
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short 000000000000BC84
       xor       eax,eax
       jmp       short 000000000000BC89
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000BD36
       call      0000000000001750
       mov       rsi,rax
       mov       ecx,36B
       mov       rdx,7FF82F287CA0
       call      0000000000000390
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF82F287CA0
       call      0000000000000390
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82F287CA0
       call      0000000000000390
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      00000000000002A8
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rbx,rax
       call      0000000000001608
       mov       rdx,rax
       mov       rcx,rsi
       call      0000000000000480
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      00000000000001E8
       mov       rcx,rbx
       call      00000000000055B0
       mov       edx,3
       call      0000000000008468
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentReadOnlyException
       call      000000000000B2D0
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,rsi
       call      000000000000A2E8
       mov       rcx,rbx
       call      00000000000055B0
       call      0000000000001628
       mov       rsi,rax
       call      0000000000001710
       mov       rdx,rax
       mov       rcx,rsi
       call      0000000000000480
       mov       rsi,rax
       mov       rax,1C0B9121910
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short 000000000000BD9D
       xor       eax,eax
       jmp       short 000000000000BDA2
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000BE4F
       call      0000000000001750
       mov       rsi,rax
       mov       ecx,36B
       mov       rdx,7FF82F287CA0
       call      0000000000000390
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF82F287CA0
       call      0000000000000390
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82F287CA0
       call      0000000000000390
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      00000000000002A8
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rbx,rax
       call      0000000000001608
       mov       rdx,rax
       mov       rcx,rsi
       call      0000000000000480
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      00000000000001E8
       mov       rcx,rbx
       call      00000000000055B0
       mov       edx,3
       call      0000000000008468
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentReadOnlyException
       call      000000000000B2D0
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,rsi
       call      000000000000A2E8
       mov       rcx,rbx
       call      00000000000055B0
       int       3
; Total bytes of code 1797
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
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
       call      qword ptr [1C30]
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.TypeHelper.GetPropertyValues(!!0)
       call      qword ptr [52B8]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,48
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 122
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       mov       [rsp+68],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short 0000000000003959
       mov       rcx,[r14+10]
       jmp       short 000000000000396E
       mov       rcx,rsi
       mov       rdx,7FF8197555E0
       call      0000000000000CA0
       mov       rcx,rax
       call      qword ptr [0B318]
       mov       r15,rax
       call      qword ptr [0B258]
       mov       r12,rax
       cmp       qword ptr [r14+18],0
       je        short 000000000000398D
       mov       r11,[r14+18]
       jmp       short 00000000000039A2
       mov       rcx,rsi
       mov       rdx,7FF819755600
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,r12
       call      qword ptr [r11]
       mov       ecx,edi
       call      qword ptr [0DA68]
       mov       r12,rax
       cmp       qword ptr [r14+20],0
       je        short 00000000000039C3
       mov       r11,[r14+20]
       jmp       short 00000000000039D8
       mov       rcx,rsi
       mov       rdx,7FF819755610
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,r12
       call      qword ptr [r11]
       mov       ecx,edi
       call      qword ptr [0DA68]
       mov       rdi,rax
       cmp       qword ptr [r14+28],0
       je        short 00000000000039F9
       mov       r11,[r14+28]
       jmp       short 0000000000003A0E
       mov       rcx,rsi
       mov       rdx,7FF819755620
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [r11]
       call      qword ptr [3918]
       mov       rdx,rax
       lea       rcx,[rsp+58]
       mov       r8d,1
       call      qword ptr [0F768]
       mov       ecx,1
       mov       edx,4B
       call      qword ptr [0D8B8]
       imul      ecx,eax,16D
       jo        near ptr 0000000000003DA1
       movsxd    rcx,ecx
       mov       rax,141DD76000
       imul      rcx,rax
       mov       rax,0CCCCCCCCCCCC
       cmp       rcx,rax
       jg        near ptr 0000000000003DA6
       mov       rax,333333333334
       cmp       rcx,rax
       jl        near ptr 0000000000003DA6
       lea       rdi,[rcx+rcx*4]
       add       rdi,rdi
       lea       rcx,[rsp+58]
       call      qword ptr [0F168]
       mov       [rsp+40],rax
       lea       rcx,[rsp+40]
       mov       rdx,rdi
       call      qword ptr [31B0]
       mov       rdx,rax
       mov       ecx,[rsp+58]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr 0000000000003DA6
       mov       r8,0FF29406B2A1B
       cmp       rcx,r8
       jl        near ptr 0000000000003DA6
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+30],xmm0
       lea       rcx,[rsp+30]
       call      qword ptr [0F048]
       mov       rcx,[rsi+10]
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+48],xmm0
       cmp       qword ptr [rcx+8],30
       jle       short 0000000000003B1F
       mov       rax,[rcx+30]
       test      rax,rax
       je        short 0000000000003B1F
       jmp       short 0000000000003B31
       mov       rcx,rsi
       mov       rdx,7FF819755700
       call      0000000000000CA0
       mov       r11,rax
       vmovupd   xmm0,[rsp+48]
       vmovupd   [rsp+20],xmm0
       mov       rcx,r15
       lea       rdx,[rsp+20]
       call      qword ptr [rax]
       mov       rdi,[rsi+10]
       call      qword ptr [0D978]
       mov       r14,rax
       cmp       qword ptr [rdi+8],38
       jle       short 0000000000003B69
       mov       r11,[rdi+38]
       test      r11,r11
       je        short 0000000000003B69
       jmp       short 0000000000003B7E
       mov       rcx,rsi
       mov       rdx,7FF819755710
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       mov       ecx,ebx
       call      qword ptr [0DA68]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],40
       jle       short 0000000000003BA8
       mov       r11,[rdi+40]
       test      r11,r11
       je        short 0000000000003BA8
       jmp       short 0000000000003BBD
       mov       rcx,rsi
       mov       rdx,7FF819755720
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       mov       ecx,ebp
       call      qword ptr [0DA68]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],48
       jle       short 0000000000003BE7
       mov       r11,[rdi+48]
       test      r11,r11
       je        short 0000000000003BE7
       jmp       short 0000000000003BFC
       mov       rcx,rsi
       mov       rdx,7FF819755730
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       call      qword ptr [0D858]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],50
       jle       short 0000000000003C24
       mov       r11,[rdi+50]
       test      r11,r11
       je        short 0000000000003C24
       jmp       short 0000000000003C39
       mov       rcx,rsi
       mov       rdx,7FF819755848
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       mov       ecx,[rsp+0D0]
       call      qword ptr [0DA68]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],58
       jle       short 0000000000003C68
       mov       r11,[rdi+58]
       test      r11,r11
       je        short 0000000000003C68
       jmp       short 0000000000003C7D
       mov       rcx,rsi
       mov       rdx,7FF819755858
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       call      qword ptr [0D978]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],60
       jle       short 0000000000003CA5
       mov       r11,[rdi+60]
       test      r11,r11
       je        short 0000000000003CA5
       jmp       short 0000000000003CBA
       mov       rcx,rsi
       mov       rdx,7FF819755868
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       mov       ecx,[rsp+0D8]
       call      qword ptr [0DA68]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],68
       jle       short 0000000000003CE9
       mov       r11,[rdi+68]
       test      r11,r11
       je        short 0000000000003CE9
       jmp       short 0000000000003CFE
       mov       rcx,rsi
       mov       rdx,7FF819755878
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       mov       ecx,[rsp+0E0]
       call      qword ptr [0D8E8]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],70
       jle       short 0000000000003D2D
       mov       r11,[rdi+70]
       test      r11,r11
       je        short 0000000000003D2D
       jmp       short 0000000000003D42
       mov       rcx,rsi
       mov       rdx,7FF819755888
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       mov       ecx,[rsp+0E8]
       call      qword ptr [0DA68]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],78
       jle       short 0000000000003D71
       mov       r11,[rdi+78]
       test      r11,r11
       je        short 0000000000003D71
       jmp       short 0000000000003D86
       mov       rcx,rsi
       mov       rdx,7FF819755898
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rax,r15
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
       call      0000000000002090
       call      qword ptr [7228]
       int       3
; Total bytes of code 1181
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
       sub       rsp,68
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       rcx,[rbx+18]
       call      qword ptr [5DC8]
       test      rax,rax
       je        short 000000000000BE61
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      0000000000000010
       mov       rcx,rdi
       call      00000000000053F0
       mov       rbp,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Extensions+<GetAllProperties>d__10
       call      000000000000EFB0
       mov       r14,rax
       mov       dword ptr [r14+30],0FFFFFFFE
       call      0000000000004EA0
       mov       [r14+34],eax
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      0000000000000010
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short 000000000000BEAC
       mov       rcx,[rbp+10]
       jmp       short 000000000000BEC1
       mov       rcx,rsi
       mov       rdx,7FF8198167C8
       call      0000000000000CA0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r8,[rax+8]
       test      r8,r8
       jne       near ptr 000000000000BF66
       mov       r15,[rbp+10]
       test      r15,r15
       je        short 000000000000BEDE
       jmp       short 000000000000BEF3
       mov       rcx,rsi
       mov       rdx,7FF8198167C8
       call      0000000000000CA0
       mov       r15,rax
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       r12,rax
       mov       rcx,r15
       call      000000000000EDE0
       mov       rdx,[rax]
       test      rdx,rdx
       je        near ptr 000000000000C3D2
       lea       rcx,[r12+8]
       call      0000000000000010
       mov       rcx,offset DotNetTips.Spargine.Core.TypeHelper+<>c__13`1[[System.__Canon, System.Private.CoreLib]].<GetPropertyValues>b__13_0(System.Reflection.PropertyInfo)
       mov       [r12+18],rcx
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short 000000000000BF3D
       jmp       short 000000000000BF52
       mov       rcx,rsi
       mov       rdx,7FF8198167C8
       call      0000000000000CA0
       mov       rcx,rax
       call      000000000000EDE0
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      0000000000000010
       mov       r8,r12
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Where(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      qword ptr [1BA0]
       mov       r14,rax
       cmp       qword ptr [rbp+10],0
       je        short 000000000000BF89
       mov       rcx,[rbp+10]
       jmp       short 000000000000BF9E
       mov       rcx,rsi
       mov       rdx,7FF8198167C8
       call      0000000000000CA0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r15,[rax+10]
       test      r15,r15
       jne       near ptr 000000000000C043
       mov       r15,[rbp+10]
       test      r15,r15
       je        short 000000000000BFBB
       jmp       short 000000000000BFD0
       mov       rcx,rsi
       mov       rdx,7FF8198167C8
       call      0000000000000CA0
       mov       r15,rax
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       r12,rax
       mov       rcx,r15
       call      000000000000EDE0
       mov       rdx,[rax]
       test      rdx,rdx
       je        near ptr 000000000000C3D2
       lea       rcx,[r12+8]
       call      0000000000000010
       mov       rcx,offset DotNetTips.Spargine.Core.TypeHelper+<>c__13`1[[System.__Canon, System.Private.CoreLib]].<GetPropertyValues>b__13_1(System.Reflection.PropertyInfo)
       mov       [r12+18],rcx
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short 000000000000C01A
       jmp       short 000000000000C02F
       mov       rcx,rsi
       mov       rdx,7FF8198167C8
       call      0000000000000CA0
       mov       rcx,rax
       call      000000000000EDE0
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      0000000000000010
       mov       r15,r12
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      0000000000000010
       test      r14,r14
       je        near ptr 000000000000C3E5
       test      r15,r15
       je        near ptr 000000000000C3D9
       xor       edx,edx
       mov       [rsi+10],rdx
       lea       rcx,[rsi+18]
       mov       rdx,r15
       call      0000000000000010
       mov       rdx,133BB001FA8
       mov       rdx,[rdx]
       lea       rcx,[rsi+20]
       call      0000000000000010
       mov       byte ptr [rsi+28],0
       mov       rcx,rsi
       call      qword ptr [3A18]
       mov       rsi,rax
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       near ptr 000000000000C322
       mov       ecx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       mov       r12,[r15]
       mov       rax,[r12+50]
       call      qword ptr [rax+10]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       test      rax,rax
       je        near ptr 000000000000C2D4
       cmp       dword ptr [rax+8],0B
       jne       near ptr 000000000000C2D4
       vmovupd   xmm0,[rax+0C]
       vpxor     xmm0,xmm0,[0C6C0]
       vmovupd   xmm1,[rax+12]
       vpxor     xmm1,xmm1,[0C6D0]
       vpor      xmm0,xmm0,xmm1
       vptest    xmm0,xmm0
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000C2D4
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r12,rcx
       jne       near ptr 000000000000C3F1
       mov       rcx,r15
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr 000000000000C22D
       test      rcx,rcx
       je        near ptr 000000000000C423
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rdi
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [3448]
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.IDictionary
       call      qword ptr [5810]
       mov       r13,rax
       test      r13,r13
       je        near ptr 000000000000C2C0
       mov       rcx,r13
       mov       r11,7FF8191F0650
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr 000000000000C2C0
       mov       rcx,r15
       mov       rax,[r12+40]
       call      qword ptr [rax+30]
       mov       r12,rax
       mov       rcx,r13
       mov       edx,2C
       call      qword ptr [0BAE0]
       mov       r15,rax
       mov       rcx,rbx
       mov       r11,7FF8191F0670
       call      qword ptr [r11]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000C466
       mov       [rsp+40],r12
       mov       [rsp+48],r15
       mov       rcx,rbx
       lea       rdx,[rsp+40]
       mov       r11,7FF8191F0660
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr 000000000000C2C0
       mov       [rsp+40],r12
       mov       [rsp+48],r15
       mov       rcx,rbx
       lea       rdx,[rsp+40]
       mov       r11,7FF8191F0668
       call      qword ptr [r11]
       jmp       near ptr 000000000000C2C0
       xor       ecx,ecx
       jmp       near ptr 000000000000C143
       test      r13,r13
       je        near ptr 000000000000C2C0
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
       mov       r11,7FF8191F0688
       call      qword ptr [r11]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000C5AF
       mov       [rsp+40],r15
       mov       [rsp+48],r12
       mov       rcx,rbx
       lea       rdx,[rsp+40]
       mov       r11,7FF8191F0678
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000C2C0
       mov       [rsp+40],r15
       mov       [rsp+48],r12
       mov       rcx,rbx
       lea       rdx,[rsp+40]
       mov       r11,7FF8191F0680
       call      qword ptr [r11]
       add       ebp,1
       jo        near ptr 000000000000C3CD
       cmp       r14d,ebp
       jg        near ptr 000000000000C0BA
       jmp       short 000000000000C322
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r12,rcx
       jne       near ptr 000000000000C40A
       mov       rcx,r15
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short 000000000000C348
       test      rcx,rcx
       je        near ptr 000000000000C56C
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rdi
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [3448]
       mov       r13,rax
       jmp       near ptr 000000000000C234
       mov       rcx,133BB007FC8
       mov       rcx,[rcx]
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [3AC8]
       mov       rdi,rax
       cmp       [rdi],dil
       cmp       dword ptr [rdi+18],0
       jne       short 000000000000C34C
       jmp       short 000000000000C3AC
       xor       ecx,ecx
       jmp       short 000000000000C2F3
       mov       r9,[rdi+8]
       mov       r8,[rdi+10]
       mov       [rsp+30],r9
       mov       [rsp+38],r8
       mov       dword ptr [rsp+20],2
       lea       r9,[rsp+30]
       mov       r8,rbx
       lea       rcx,[rsp+50]
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableDictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      qword ptr [3E88]
       mov       rdx,[rsp+50]
       mov       r8d,[rdi+18]
       add       r8d,[rsp+58]
       mov       rcx,rdi
       call      qword ptr [3EE8]
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
       xor       r8d,r8d
       je        short 000000000000C34C
       mov       r8,[rdi+10]
       mov       rdx,[r8+8]
       mov       r8,[rdi+10]
       mov       r8,[r8+10]
       xor       ecx,ecx
       cmp       [rcx],ecx
       call      qword ptr [3AC8]
       jmp       short 000000000000C39A
       call      0000000000002090
       call      qword ptr [5630]
       int       3
       mov       ecx,9
       call      qword ptr [0B780]
       int       3
       mov       ecx,10
       call      qword ptr [0B780]
       int       3
       mov       rcx,r15
       mov       rdx,rdi
       xor       r8d,r8d
       mov       rax,[r12+58]
       call      qword ptr [rax+30]
       mov       rdx,rax
       jmp       near ptr 000000000000C16D
       mov       rcx,r15
       mov       rdx,rdi
       xor       r8d,r8d
       mov       rax,[r12+58]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       near ptr 000000000000C234
       mov       rcx,offset MT_System.ArgumentException
       call      000000000000EFB0
       mov       rsi,rax
       mov       ecx,3EA4
       mov       rdx,7FF8191E4000
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [33D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [5B88]
       mov       rcx,rsi
       call      0000000000006AD0
       call      qword ptr [98D0]
       mov       rsi,rax
       call      qword ptr [9B88]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [9D08]
       mov       rsi,rax
       mov       rax,133BB00A5D8
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000C535
       call      qword ptr [9C48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF819729B18
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF819729B18
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5270]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [9870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [9D08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentReadOnlyException
       call      000000000000EFB0
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [5BD0]
       mov       rcx,rbx
       call      0000000000006AD0
       mov       rcx,offset MT_System.ArgumentException
       call      000000000000EFB0
       mov       rsi,rax
       mov       ecx,3EA4
       mov       rdx,7FF8191E4000
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [33D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [5B88]
       mov       rcx,rsi
       call      0000000000006AD0
       call      qword ptr [98D0]
       mov       rsi,rax
       call      qword ptr [9B88]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [9D08]
       mov       rsi,rax
       mov       rax,133BB00A5D8
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000C67E
       call      qword ptr [9C48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF819729B18
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF819729B18
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5270]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [9870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [9D08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentReadOnlyException
       call      000000000000EFB0
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [5BD0]
       mov       rcx,rbx
       call      0000000000006AD0
       int       3
; Total bytes of code 2230
```

