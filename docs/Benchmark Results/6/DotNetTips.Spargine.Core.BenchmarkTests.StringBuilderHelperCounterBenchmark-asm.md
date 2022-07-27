## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      000000000000A700
       test      rax,rax
       jne       short 0000000000000B1A
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [0B68]
       call      000000000000E348
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      000000000000A710
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      000000000000A700
       test      rax,rax
       je        short 0000000000000B56
       mov       rcx,[rax]
       mov       edx,2C
       call      0000000000009118
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       ecx,1
       call      000000000000F8A8
       int       3
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short 000000000000FC5B
       cmp       qword ptr [rbx+28],0
       je        near ptr 000000000000FCFE
       jmp       near ptr 000000000000FCFE
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr 000000000000FD03
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr 000000000000FDB2
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
       cmp       r8d,ecx
       jbe       short 000000000000FC4B
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short 000000000000FCD8
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short 000000000000FCEA
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr 000000000000FDA4
       jmp       short 000000000000FCB1
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
       xor       r14d,r14d
       jmp       short 000000000000FCEA
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FF82EE80560
       call      qword ptr [560]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short 000000000000FDB2
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
       cmp       [r12+8],r15d
       jbe       near ptr 000000000000FC4B
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short 000000000000FD96
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FF82EE80568
       call      qword ptr [568]
       test      eax,eax
       jne       short 000000000000FDAA
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short 000000000000FD58
       call      0000000000009748
       int       3
       mov       r14,r15
       jmp       near ptr 000000000000FCEA
       call      000000000000F130
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short 0000000000007A27
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      000000000000E520
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      000000000000B2D0
       mov       [rbp+0FFD0],rax
       call      0000000000002068
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      0000000000008818
       mov       [rbp+0FFC0],rax
       mov       r9,20C7AF724D8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7BB8]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      0000000000007248
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7BC0]
       call      0000000000001068
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      000000000000B400
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      0000000000008218
       mov       rdx,20C5AF75E08
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      0000000000009718
       mov       rcx,20C5AF75E10
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short 0000000000007B5B
       mov       rcx,rsp
       call      0000000000007B77
       nop
       lea       rcx,[rbp+0FFF0]
       call      00000000000082F0
       nop
       add       rsp,0A0
       pop       rbp
       ret
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short 0000000000007BA2
       mov       rcx,[rbp+0FFE8]
       call      0000000000005CD0
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short 000000000000761D
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [5AF0]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr 00000000000078C7
       mov       r12d,edi
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr 00000000000078E1
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr 000000000000780C
       cmp       [r14+8],r8d
       ja        short 00000000000076F7
       cmp       dword ptr [rsi+40],0
       jg        near ptr 0000000000007783
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr 0000000000007728
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
       cmp       r15d,[r14+8]
       jae       near ptr 00000000000078E1
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
       mov       eax,1
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
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr 00000000000077AF
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr 00000000000078C0
       jmp       near ptr 0000000000007678
       mov       ecx,[rsi+38]
       call      qword ptr [4AF0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [5B00]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr 00000000000078E1
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr 0000000000007696
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr 00000000000078E1
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr 00000000000076A1
       mov       [rsp+28],rax
       call      qword ptr [1340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr 0000000000007712
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short 00000000000077FD
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [588]
       jmp       near ptr 00000000000076E1
       cmp       bpl,2
       jne       near ptr 0000000000007894
       jmp       near ptr 000000000000788B
       cmp       [r14+8],r8d
       jbe       near ptr 000000000000767E
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr 00000000000078A7
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[0FDC0]
       call      qword ptr [0FDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short 000000000000787E
       cmp       bpl,1
       jne       short 0000000000007885
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [588]
       jmp       near ptr 00000000000076E1
       mov       r8d,[rsp+34]
       jmp       short 00000000000078A7
       cmp       bpl,2
       jne       short 0000000000007894
       mov       ecx,edi
       call      qword ptr [9258]
       int       3
       xor       eax,eax
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
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr 000000000000780C
       call      qword ptr [0D150]
       int       3
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[0FDC8]
       call      qword ptr [0FDC8]
       mov       r12d,eax
       jmp       near ptr 0000000000007631
       call      qword ptr [578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short 0000000000000CF4
       mov       rcx,rsi
       call      0000000000009170
       test      rax,rax
       jne       short 0000000000000D09
       mov       rax,20C5AF71028
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,offset MT_System.Text.StringBuilder
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rsi
       call      000000000000A188
       imul      edx,eax,0A
       jo        near ptr 0000000000000E2D
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      000000000000CC88
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      000000000000AEB0
       mov       rcx,offset MT_System.Action`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rsi
       call      0000000000009190
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      000000000000AEB0
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      00000000000078D8
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [2180]
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr 0000000000000E26
       cmp       dword ptr [rcx+8],0
       je        short 0000000000000E26
       xor       eax,eax
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 0000000000000DE1
       call      0000000000001630
       mov       rsi,rax
       mov       ecx,333
       mov       rdx,7FF82F276E38
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000004E0
       int       3
       cmp       [rcx],ecx
       mov       edx,3
       call      0000000000008468
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,2
       call      0000000000008468
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      0000000000008468
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short 0000000000000E2D
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr 000000000000CCC8
       mov       eax,1
       jmp       short 0000000000000DAD
       call      000000000000ECD0
       int       3
; Total bytes of code 371
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7960]
       test      rax,rax
       jne       short 000000000000EC3E
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [0EC88]
       call      qword ptr [1060]
       mov       r8,rax
       cmp       [rdi],dil
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      qword ptr [7990]
       mov       rcx,[rsi+8]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7960]
       test      rax,rax
       je        short 000000000000EC7A
       mov       rcx,[rax]
       mov       edx,2C
       call      qword ptr [1EB8]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       ecx,1
       call      qword ptr [9390]
       int       3
; Total bytes of code 150
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi+8]
       test      rax,rax
       jne       short 000000000000E14C
       xor       ebp,ebp
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rbx,[rsi+18]
       test      rbx,rbx
       jne       short 000000000000E1C5
       mov       ecx,edi
       mov       edx,[rax+8]
       mov       r11d,edx
       mov       r8d,ecx
       imul      r8,[rsi+30]
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr 000000000000E268
       mov       edx,r11d
       lea       rax,[rax+rdx*4+10]
       mov       eax,[rax]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       eax
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short 000000000000E13A
       mov       eax,eax
       lea       rax,[rax+rax*2]
       lea       rbp,[rdx+rax*8+10]
       cmp       [rbp+8],edi
       jne       short 000000000000E1B5
       mov       eax,[rbp+10]
       cmp       eax,ecx
       jne       short 000000000000E1B5
       jmp       short 000000000000E13C
       mov       eax,[rbp+0C]
       inc       r11d
       cmp       r8d,r11d
       jae       short 000000000000E197
       jmp       near ptr 000000000000E259
       mov       rcx,rbx
       mov       edx,edi
       mov       r11,7FF82E9905B8
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8d,ebp
       imul      r8,[rsi+30]
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short 000000000000E268
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r14d,[rdx]
       mov       rsi,[rsi+10]
       xor       r15d,r15d
       dec       r14d
       cmp       [rsi+8],r14d
       jbe       near ptr 000000000000E13A
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rsi+rdx*8+10]
       mov       r14,rdx
       cmp       [r14+8],ebp
       jne       short 000000000000E24C
       mov       edx,[r14+10]
       mov       rcx,rbx
       mov       r8d,edi
       mov       r11,7FF82E9905C0
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000E260
       mov       r14d,[r14+0C]
       inc       r15d
       cmp       [rsi+8],r15d
       jae       short 000000000000E212
       call      qword ptr [7648]
       int       3
       mov       rbp,r14
       jmp       near ptr 000000000000E1B3
       call      00000000000023D0
       int       3
; Total bytes of code 334
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short 000000000000EE05
       mov       rcx,rsi
       call      qword ptr [1F60]
       test      rax,rax
       jne       short 000000000000EE1A
       mov       rax,21C14802028
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,offset MT_System.Text.StringBuilder
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rsi
       call      qword ptr [1C00]
       imul      edx,eax,0A
       jo        near ptr 000000000000EFC3
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      qword ptr [71F8]
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      0000000000000010
       mov       rcx,offset MT_System.Action`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rsi
       call      qword ptr [1F90]
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      0000000000000010
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [57E0]
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [0E838]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000EECE
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short 000000000000EED0
       jmp       short 000000000000EED0
       xor       edx,edx
       test      edx,edx
       jne       near ptr 000000000000EF7A
       call      qword ptr [9C48]
       mov       rsi,rax
       mov       ecx,333
       mov       rdx,7FF82EEC8D40
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF82EEC9C18
       call      000000000000F510
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82EEC9C18
       call      000000000000F510
       mov       rcx,rdi
       mov       r9,rbx
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
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rcx,rax
       cmp       [rcx],cl
       mov       edx,2
       call      qword ptr [0D4E0]
       cmp       [rax],al
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [0D4E0]
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short 000000000000EFC3
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [72B8]
       call      0000000000002090
       int       3
; Total bytes of code 505
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      000000000000A700
       test      rax,rax
       jne       short 0000000000000B1A
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [0B68]
       call      000000000000E348
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      000000000000A710
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      000000000000A700
       test      rax,rax
       je        short 0000000000000B56
       mov       rcx,[rax]
       mov       edx,2C
       call      0000000000009118
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       ecx,1
       call      000000000000F898
       int       3
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short 000000000000FC5B
       cmp       qword ptr [rbx+28],0
       je        near ptr 000000000000FCFE
       jmp       near ptr 000000000000FCFE
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr 000000000000FD03
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr 000000000000FDB2
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
       cmp       r8d,ecx
       jbe       short 000000000000FC4B
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short 000000000000FCD8
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short 000000000000FCEA
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr 000000000000FDA4
       jmp       short 000000000000FCB1
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
       xor       r14d,r14d
       jmp       short 000000000000FCEA
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FF82EE70560
       call      qword ptr [560]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short 000000000000FDB2
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
       cmp       [r12+8],r15d
       jbe       near ptr 000000000000FC4B
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short 000000000000FD96
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FF82EE70568
       call      qword ptr [568]
       test      eax,eax
       jne       short 000000000000FDAA
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short 000000000000FD58
       call      0000000000009748
       int       3
       mov       r14,r15
       jmp       near ptr 000000000000FCEA
       call      000000000000F130
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short 0000000000007A27
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      000000000000E520
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      000000000000B2D0
       mov       [rbp+0FFD0],rax
       call      0000000000002068
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      0000000000008818
       mov       [rbp+0FFC0],rax
       mov       r9,1EB41D2B0D0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7BB8]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      0000000000007248
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7BC0]
       call      0000000000001068
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      000000000000B400
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      0000000000008218
       mov       rdx,1EB41D27E00
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      0000000000009718
       mov       rcx,1EB41D27E08
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short 0000000000007B5B
       mov       rcx,rsp
       call      0000000000007B77
       nop
       lea       rcx,[rbp+0FFF0]
       call      00000000000082F0
       nop
       add       rsp,0A0
       pop       rbp
       ret
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short 0000000000007BA2
       mov       rcx,[rbp+0FFE8]
       call      0000000000005CD0
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short 000000000000761D
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [5AF0]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr 00000000000078C7
       mov       r12d,edi
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr 00000000000078E1
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr 000000000000780C
       cmp       [r14+8],r8d
       ja        short 00000000000076F7
       cmp       dword ptr [rsi+40],0
       jg        near ptr 0000000000007783
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr 0000000000007728
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
       cmp       r15d,[r14+8]
       jae       near ptr 00000000000078E1
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
       mov       eax,1
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
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr 00000000000077AF
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr 00000000000078C0
       jmp       near ptr 0000000000007678
       mov       ecx,[rsi+38]
       call      qword ptr [4AF0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [5B00]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr 00000000000078E1
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr 0000000000007696
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr 00000000000078E1
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr 00000000000076A1
       mov       [rsp+28],rax
       call      qword ptr [1340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr 0000000000007712
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short 00000000000077FD
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [588]
       jmp       near ptr 00000000000076E1
       cmp       bpl,2
       jne       near ptr 0000000000007894
       jmp       near ptr 000000000000788B
       cmp       [r14+8],r8d
       jbe       near ptr 000000000000767E
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr 00000000000078A7
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[0FDC0]
       call      qword ptr [0FDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short 000000000000787E
       cmp       bpl,1
       jne       short 0000000000007885
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [588]
       jmp       near ptr 00000000000076E1
       mov       r8d,[rsp+34]
       jmp       short 00000000000078A7
       cmp       bpl,2
       jne       short 0000000000007894
       mov       ecx,edi
       call      qword ptr [9258]
       int       3
       xor       eax,eax
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
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr 000000000000780C
       call      qword ptr [0D150]
       int       3
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[0FDC8]
       call      qword ptr [0FDC8]
       mov       r12d,eax
       jmp       near ptr 0000000000007631
       call      qword ptr [578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short 0000000000000CF4
       mov       rcx,rsi
       call      0000000000009170
       test      rax,rax
       jne       short 0000000000000D09
       mov       rax,1EB41D23020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,offset MT_System.Text.StringBuilder
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rsi
       call      000000000000A188
       imul      edx,eax,0A
       jo        near ptr 0000000000000E2D
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      000000000000CC88
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      000000000000AEB0
       mov       rcx,offset MT_System.Action`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rsi
       call      0000000000009190
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      000000000000AEB0
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      00000000000078D8
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [2180]
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr 0000000000000E26
       cmp       dword ptr [rcx+8],0
       je        short 0000000000000E26
       xor       eax,eax
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 0000000000000DE1
       call      0000000000001630
       mov       rsi,rax
       mov       ecx,333
       mov       rdx,7FF82F266E38
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000004E0
       int       3
       cmp       [rcx],ecx
       mov       edx,3
       call      0000000000008468
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,2
       call      0000000000008468
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      0000000000008468
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short 0000000000000E2D
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr 000000000000CCC8
       mov       eax,1
       jmp       short 0000000000000DAD
       call      000000000000ECD0
       int       3
; Total bytes of code 371
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7960]
       test      rax,rax
       jne       short 000000000000EC3E
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [0EC88]
       call      qword ptr [1060]
       mov       r8,rax
       cmp       [rdi],dil
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      qword ptr [7990]
       mov       rcx,[rsi+8]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7960]
       test      rax,rax
       je        short 000000000000EC7A
       mov       rcx,[rax]
       mov       edx,2C
       call      qword ptr [1EB8]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       ecx,1
       call      qword ptr [9888]
       int       3
; Total bytes of code 150
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi+8]
       test      rax,rax
       jne       short 000000000000E14C
       xor       ebp,ebp
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rbx,[rsi+18]
       test      rbx,rbx
       jne       short 000000000000E1C5
       mov       ecx,edi
       mov       edx,[rax+8]
       mov       r11d,edx
       mov       r8d,ecx
       imul      r8,[rsi+30]
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr 000000000000E268
       mov       edx,r11d
       lea       rax,[rax+rdx*4+10]
       mov       eax,[rax]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       eax
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short 000000000000E13A
       mov       eax,eax
       lea       rax,[rax+rax*2]
       lea       rbp,[rdx+rax*8+10]
       cmp       [rbp+8],edi
       jne       short 000000000000E1B5
       mov       eax,[rbp+10]
       cmp       eax,ecx
       jne       short 000000000000E1B5
       jmp       short 000000000000E13C
       mov       eax,[rbp+0C]
       inc       r11d
       cmp       r8d,r11d
       jae       short 000000000000E197
       jmp       near ptr 000000000000E259
       mov       rcx,rbx
       mov       edx,edi
       mov       r11,7FF82E9905B8
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8d,ebp
       imul      r8,[rsi+30]
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short 000000000000E268
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r14d,[rdx]
       mov       rsi,[rsi+10]
       xor       r15d,r15d
       dec       r14d
       cmp       [rsi+8],r14d
       jbe       near ptr 000000000000E13A
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rsi+rdx*8+10]
       mov       r14,rdx
       cmp       [r14+8],ebp
       jne       short 000000000000E24C
       mov       edx,[r14+10]
       mov       rcx,rbx
       mov       r8d,edi
       mov       r11,7FF82E9905C0
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000E260
       mov       r14d,[r14+0C]
       inc       r15d
       cmp       [rsi+8],r15d
       jae       short 000000000000E212
       call      qword ptr [7648]
       int       3
       mov       rbp,r14
       jmp       near ptr 000000000000E1B3
       call      00000000000023D0
       int       3
; Total bytes of code 334
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short 000000000000EE05
       mov       rcx,rsi
       call      qword ptr [1F60]
       test      rax,rax
       jne       short 000000000000EE1A
       mov       rax,2CD70402028
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,offset MT_System.Text.StringBuilder
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rsi
       call      qword ptr [1C00]
       imul      edx,eax,0A
       jo        near ptr 000000000000EFC3
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      qword ptr [71F8]
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      0000000000000010
       mov       rcx,offset MT_System.Action`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rsi
       call      qword ptr [1F90]
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      0000000000000010
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [57E0]
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [0E838]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000EECE
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short 000000000000EED0
       jmp       short 000000000000EED0
       xor       edx,edx
       test      edx,edx
       jne       near ptr 000000000000EF7A
       call      qword ptr [9C48]
       mov       rsi,rax
       mov       ecx,333
       mov       rdx,7FF82EEC8D40
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF82EEC9C18
       call      000000000000F510
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82EEC9C18
       call      000000000000F510
       mov       rcx,rdi
       mov       r9,rbx
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
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rcx,rax
       cmp       [rcx],cl
       mov       edx,2
       call      qword ptr [0D4E0]
       cmp       [rax],al
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [0D4E0]
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short 000000000000EFC3
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [72B8]
       call      0000000000002090
       int       3
; Total bytes of code 505
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      000000000000A700
       test      rax,rax
       jne       short 0000000000000B1A
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [0B68]
       call      000000000000E348
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      000000000000A710
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      000000000000A700
       test      rax,rax
       je        short 0000000000000B56
       mov       rcx,[rax]
       mov       edx,2C
       call      0000000000009118
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       ecx,1
       call      000000000000F8A8
       int       3
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short 000000000000FC5B
       cmp       qword ptr [rbx+28],0
       je        near ptr 000000000000FCFE
       jmp       near ptr 000000000000FCFE
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr 000000000000FD03
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr 000000000000FDB2
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
       cmp       r8d,ecx
       jbe       short 000000000000FC4B
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short 000000000000FCD8
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short 000000000000FCEA
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr 000000000000FDA4
       jmp       short 000000000000FCB1
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
       xor       r14d,r14d
       jmp       short 000000000000FCEA
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FF82EEA0560
       call      qword ptr [560]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short 000000000000FDB2
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
       cmp       [r12+8],r15d
       jbe       near ptr 000000000000FC4B
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short 000000000000FD96
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FF82EEA0568
       call      qword ptr [568]
       test      eax,eax
       jne       short 000000000000FDAA
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short 000000000000FD58
       call      0000000000009748
       int       3
       mov       r14,r15
       jmp       near ptr 000000000000FCEA
       call      000000000000F130
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short 0000000000007A27
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      000000000000E520
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      000000000000B2D0
       mov       [rbp+0FFD0],rax
       call      0000000000002068
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      0000000000008818
       mov       [rbp+0FFC0],rax
       mov       r9,2871B55B0D0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7BB8]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      0000000000007248
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7BC0]
       call      0000000000001068
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      000000000000B400
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      0000000000008218
       mov       rdx,2871B557E00
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      0000000000009718
       mov       rcx,2871B557E08
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short 0000000000007B5B
       mov       rcx,rsp
       call      0000000000007B77
       nop
       lea       rcx,[rbp+0FFF0]
       call      00000000000082F0
       nop
       add       rsp,0A0
       pop       rbp
       ret
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short 0000000000007BA2
       mov       rcx,[rbp+0FFE8]
       call      0000000000005CD0
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short 000000000000761D
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [5AF0]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr 00000000000078C7
       mov       r12d,edi
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr 00000000000078E1
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr 000000000000780C
       cmp       [r14+8],r8d
       ja        short 00000000000076F7
       cmp       dword ptr [rsi+40],0
       jg        near ptr 0000000000007783
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr 0000000000007728
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
       cmp       r15d,[r14+8]
       jae       near ptr 00000000000078E1
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
       mov       eax,1
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
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr 00000000000077AF
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr 00000000000078C0
       jmp       near ptr 0000000000007678
       mov       ecx,[rsi+38]
       call      qword ptr [4AF0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [5B00]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr 00000000000078E1
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr 0000000000007696
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr 00000000000078E1
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr 00000000000076A1
       mov       [rsp+28],rax
       call      qword ptr [1340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr 0000000000007712
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short 00000000000077FD
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [588]
       jmp       near ptr 00000000000076E1
       cmp       bpl,2
       jne       near ptr 0000000000007894
       jmp       near ptr 000000000000788B
       cmp       [r14+8],r8d
       jbe       near ptr 000000000000767E
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr 00000000000078A7
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[0FDC0]
       call      qword ptr [0FDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short 000000000000787E
       cmp       bpl,1
       jne       short 0000000000007885
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [588]
       jmp       near ptr 00000000000076E1
       mov       r8d,[rsp+34]
       jmp       short 00000000000078A7
       cmp       bpl,2
       jne       short 0000000000007894
       mov       ecx,edi
       call      qword ptr [9258]
       int       3
       xor       eax,eax
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
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr 000000000000780C
       call      qword ptr [0D150]
       int       3
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[0FDC8]
       call      qword ptr [0FDC8]
       mov       r12d,eax
       jmp       near ptr 0000000000007631
       call      qword ptr [578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short 0000000000000CF4
       mov       rcx,rsi
       call      0000000000009170
       test      rax,rax
       jne       short 0000000000000D09
       mov       rax,2871B553020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,offset MT_System.Text.StringBuilder
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rsi
       call      000000000000A188
       imul      edx,eax,0A
       jo        near ptr 0000000000000E2D
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      000000000000CC88
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      000000000000AEB0
       mov       rcx,offset MT_System.Action`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rsi
       call      0000000000009190
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      000000000000AEB0
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      00000000000078D8
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [2180]
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr 0000000000000E26
       cmp       dword ptr [rcx+8],0
       je        short 0000000000000E26
       xor       eax,eax
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 0000000000000DE1
       call      0000000000001630
       mov       rsi,rax
       mov       ecx,333
       mov       rdx,7FF82F296E38
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000004E0
       int       3
       cmp       [rcx],ecx
       mov       edx,3
       call      0000000000008468
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,2
       call      0000000000008468
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      0000000000008468
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short 0000000000000E2D
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr 000000000000CCC8
       mov       eax,1
       jmp       short 0000000000000DAD
       call      000000000000ECD0
       int       3
; Total bytes of code 371
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7960]
       test      rax,rax
       jne       short 000000000000EC3E
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [0EC88]
       call      qword ptr [1060]
       mov       r8,rax
       cmp       [rdi],dil
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      qword ptr [7990]
       mov       rcx,[rsi+8]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7960]
       test      rax,rax
       je        short 000000000000EC7A
       mov       rcx,[rax]
       mov       edx,2C
       call      qword ptr [3300]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       ecx,1
       call      qword ptr [9BA0]
       int       3
; Total bytes of code 150
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi+8]
       test      rax,rax
       jne       short 000000000000E14C
       xor       ebp,ebp
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rbx,[rsi+18]
       test      rbx,rbx
       jne       short 000000000000E1C5
       mov       ecx,edi
       mov       edx,[rax+8]
       mov       r11d,edx
       mov       r8d,ecx
       imul      r8,[rsi+30]
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr 000000000000E268
       mov       edx,r11d
       lea       rax,[rax+rdx*4+10]
       mov       eax,[rax]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       eax
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short 000000000000E13A
       mov       eax,eax
       lea       rax,[rax+rax*2]
       lea       rbp,[rdx+rax*8+10]
       cmp       [rbp+8],edi
       jne       short 000000000000E1B5
       mov       eax,[rbp+10]
       cmp       eax,ecx
       jne       short 000000000000E1B5
       jmp       short 000000000000E13C
       mov       eax,[rbp+0C]
       inc       r11d
       cmp       r8d,r11d
       jae       short 000000000000E197
       jmp       near ptr 000000000000E259
       mov       rcx,rbx
       mov       edx,edi
       mov       r11,7FF8428305B8
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8d,ebp
       imul      r8,[rsi+30]
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short 000000000000E268
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r14d,[rdx]
       mov       rsi,[rsi+10]
       xor       r15d,r15d
       dec       r14d
       cmp       [rsi+8],r14d
       jbe       near ptr 000000000000E13A
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rsi+rdx*8+10]
       mov       r14,rdx
       cmp       [r14+8],ebp
       jne       short 000000000000E24C
       mov       edx,[r14+10]
       mov       rcx,rbx
       mov       r8d,edi
       mov       r11,7FF8428305C0
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000E260
       mov       r14d,[r14+0C]
       inc       r15d
       cmp       [rsi+8],r15d
       jae       short 000000000000E212
       call      qword ptr [7648]
       int       3
       mov       rbp,r14
       jmp       near ptr 000000000000E1B3
       call      00000000000023D0
       int       3
; Total bytes of code 334
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short 000000000000EE05
       mov       rcx,rsi
       call      qword ptr [33A8]
       test      rax,rax
       jne       short 000000000000EE1A
       mov       rax,2AFDFC02028
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,offset MT_System.Text.StringBuilder
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rsi
       call      qword ptr [3048]
       imul      edx,eax,0A
       jo        near ptr 000000000000EFC3
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      qword ptr [71F8]
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      0000000000000010
       mov       rcx,offset MT_System.Action`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rsi
       call      qword ptr [33D8]
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      0000000000000010
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [57E0]
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [0E838]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000EECE
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short 000000000000EED0
       jmp       short 000000000000EED0
       xor       edx,edx
       test      edx,edx
       jne       near ptr 000000000000EF7A
       call      qword ptr [9C48]
       mov       rsi,rax
       mov       ecx,333
       mov       rdx,7FF842D68D40
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF842D69C18
       call      000000000000F510
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF842D69C18
       call      000000000000F510
       mov       rcx,rdi
       mov       r9,rbx
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
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rcx,rax
       cmp       [rcx],cl
       mov       edx,2
       call      qword ptr [0D4E0]
       cmp       [rax],al
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [0D4E0]
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short 000000000000EFC3
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [72B8]
       call      0000000000002090
       int       3
; Total bytes of code 505
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      000000000000A700
       test      rax,rax
       jne       short 0000000000000B1A
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [0B68]
       call      000000000000E348
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      000000000000A710
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      000000000000A700
       test      rax,rax
       je        short 0000000000000B56
       mov       rcx,[rax]
       mov       edx,2C
       call      0000000000009118
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       ecx,1
       call      000000000000F8A8
       int       3
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short 000000000000FC5B
       cmp       qword ptr [rbx+28],0
       je        near ptr 000000000000FCFE
       jmp       near ptr 000000000000FCFE
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr 000000000000FD03
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr 000000000000FDB2
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
       cmp       r8d,ecx
       jbe       short 000000000000FC4B
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short 000000000000FCD8
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short 000000000000FCEA
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr 000000000000FDA4
       jmp       short 000000000000FCB1
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
       xor       r14d,r14d
       jmp       short 000000000000FCEA
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FF82EE80560
       call      qword ptr [560]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short 000000000000FDB2
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
       cmp       [r12+8],r15d
       jbe       near ptr 000000000000FC4B
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short 000000000000FD96
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FF82EE80568
       call      qword ptr [568]
       test      eax,eax
       jne       short 000000000000FDAA
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short 000000000000FD58
       call      0000000000009748
       int       3
       mov       r14,r15
       jmp       near ptr 000000000000FCEA
       call      000000000000F130
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short 0000000000007A27
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      000000000000E520
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      000000000000B2D0
       mov       [rbp+0FFD0],rax
       call      0000000000002068
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      0000000000008818
       mov       [rbp+0FFC0],rax
       mov       r9,1E304CF24D8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7BB8]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      0000000000007248
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7BC0]
       call      0000000000001068
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      000000000000B400
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      0000000000008218
       mov       rdx,1E2F4CF7E00
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      0000000000009718
       mov       rcx,1E2F4CF7E08
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short 0000000000007B5B
       mov       rcx,rsp
       call      0000000000007B77
       nop
       lea       rcx,[rbp+0FFF0]
       call      00000000000082F0
       nop
       add       rsp,0A0
       pop       rbp
       ret
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short 0000000000007BA2
       mov       rcx,[rbp+0FFE8]
       call      0000000000005CD0
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short 000000000000761D
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [5AF0]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr 00000000000078C7
       mov       r12d,edi
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr 00000000000078E1
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr 000000000000780C
       cmp       [r14+8],r8d
       ja        short 00000000000076F7
       cmp       dword ptr [rsi+40],0
       jg        near ptr 0000000000007783
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr 0000000000007728
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
       cmp       r15d,[r14+8]
       jae       near ptr 00000000000078E1
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
       mov       eax,1
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
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr 00000000000077AF
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr 00000000000078C0
       jmp       near ptr 0000000000007678
       mov       ecx,[rsi+38]
       call      qword ptr [4AF0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [5B00]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr 00000000000078E1
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr 0000000000007696
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr 00000000000078E1
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr 00000000000076A1
       mov       [rsp+28],rax
       call      qword ptr [1340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr 0000000000007712
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short 00000000000077FD
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [588]
       jmp       near ptr 00000000000076E1
       cmp       bpl,2
       jne       near ptr 0000000000007894
       jmp       near ptr 000000000000788B
       cmp       [r14+8],r8d
       jbe       near ptr 000000000000767E
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr 00000000000078A7
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[0FDC0]
       call      qword ptr [0FDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short 000000000000787E
       cmp       bpl,1
       jne       short 0000000000007885
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [588]
       jmp       near ptr 00000000000076E1
       mov       r8d,[rsp+34]
       jmp       short 00000000000078A7
       cmp       bpl,2
       jne       short 0000000000007894
       mov       ecx,edi
       call      qword ptr [9258]
       int       3
       xor       eax,eax
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
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr 000000000000780C
       call      qword ptr [0D150]
       int       3
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[0FDC8]
       call      qword ptr [0FDC8]
       mov       r12d,eax
       jmp       near ptr 0000000000007631
       call      qword ptr [578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short 0000000000000CF4
       mov       rcx,rsi
       call      0000000000009170
       test      rax,rax
       jne       short 0000000000000D09
       mov       rax,1E2F4CF3020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,offset MT_System.Text.StringBuilder
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rsi
       call      000000000000A188
       imul      edx,eax,0A
       jo        near ptr 0000000000000E2D
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      000000000000CC88
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      000000000000AEB0
       mov       rcx,offset MT_System.Action`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rsi
       call      0000000000009190
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      000000000000AEB0
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      00000000000078D8
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [2180]
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr 0000000000000E26
       cmp       dword ptr [rcx+8],0
       je        short 0000000000000E26
       xor       eax,eax
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 0000000000000DE1
       call      0000000000001630
       mov       rsi,rax
       mov       ecx,333
       mov       rdx,7FF82F276E38
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000004E0
       int       3
       cmp       [rcx],ecx
       mov       edx,3
       call      0000000000008468
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,2
       call      0000000000008468
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      0000000000008468
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short 0000000000000E2D
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr 000000000000CCC8
       mov       eax,1
       jmp       short 0000000000000DAD
       call      000000000000ECD0
       int       3
; Total bytes of code 371
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7960]
       test      rax,rax
       jne       short 000000000000EC3E
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [0EC88]
       call      qword ptr [1060]
       mov       r8,rax
       cmp       [rdi],dil
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      qword ptr [7990]
       mov       rcx,[rsi+8]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7960]
       test      rax,rax
       je        short 000000000000EC7A
       mov       rcx,[rax]
       mov       edx,2C
       call      qword ptr [3300]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       ecx,1
       call      qword ptr [0B2E8]
       int       3
; Total bytes of code 150
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi+8]
       test      rax,rax
       jne       short 000000000000E14C
       xor       ebp,ebp
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rbx,[rsi+18]
       test      rbx,rbx
       jne       short 000000000000E1C5
       mov       ecx,edi
       mov       edx,[rax+8]
       mov       r11d,edx
       mov       r8d,ecx
       imul      r8,[rsi+30]
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr 000000000000E268
       mov       edx,r11d
       lea       rax,[rax+rdx*4+10]
       mov       eax,[rax]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       eax
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short 000000000000E13A
       mov       eax,eax
       lea       rax,[rax+rax*2]
       lea       rbp,[rdx+rax*8+10]
       cmp       [rbp+8],edi
       jne       short 000000000000E1B5
       mov       eax,[rbp+10]
       cmp       eax,ecx
       jne       short 000000000000E1B5
       jmp       short 000000000000E13C
       mov       eax,[rbp+0C]
       inc       r11d
       cmp       r8d,r11d
       jae       short 000000000000E197
       jmp       near ptr 000000000000E259
       mov       rcx,rbx
       mov       edx,edi
       mov       r11,7FF842A805B8
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8d,ebp
       imul      r8,[rsi+30]
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short 000000000000E268
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r14d,[rdx]
       mov       rsi,[rsi+10]
       xor       r15d,r15d
       dec       r14d
       cmp       [rsi+8],r14d
       jbe       near ptr 000000000000E13A
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rsi+rdx*8+10]
       mov       r14,rdx
       cmp       [r14+8],ebp
       jne       short 000000000000E24C
       mov       edx,[r14+10]
       mov       rcx,rbx
       mov       r8d,edi
       mov       r11,7FF842A805C0
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000E260
       mov       r14d,[r14+0C]
       inc       r15d
       cmp       [rsi+8],r15d
       jae       short 000000000000E212
       call      qword ptr [7648]
       int       3
       mov       rbp,r14
       jmp       near ptr 000000000000E1B3
       call      00000000000023D0
       int       3
; Total bytes of code 334
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short 000000000000EE05
       mov       rcx,rsi
       call      qword ptr [33A8]
       test      rax,rax
       jne       short 000000000000EE1A
       mov       rax,18DC3002028
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,offset MT_System.Text.StringBuilder
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rsi
       call      qword ptr [3048]
       imul      edx,eax,0A
       jo        near ptr 000000000000EFC3
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      qword ptr [71F8]
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      0000000000000010
       mov       rcx,offset MT_System.Action`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rsi
       call      qword ptr [33D8]
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      0000000000000010
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [57E0]
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [0E838]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000EECE
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short 000000000000EED0
       jmp       short 000000000000EED0
       xor       edx,edx
       test      edx,edx
       jne       near ptr 000000000000EF7A
       call      qword ptr [9C48]
       mov       rsi,rax
       mov       ecx,333
       mov       rdx,7FF842FB8D40
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF842FB9C18
       call      000000000000F510
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF842FB9C18
       call      000000000000F510
       mov       rcx,rdi
       mov       r9,rbx
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
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rcx,rax
       cmp       [rcx],cl
       mov       edx,2
       call      qword ptr [0D4E0]
       cmp       [rax],al
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [0D4E0]
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short 000000000000EFC3
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [72B8]
       call      0000000000002090
       int       3
; Total bytes of code 505
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      000000000000A700
       test      rax,rax
       jne       short 0000000000000B1A
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [0B68]
       call      000000000000E348
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      000000000000A710
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      000000000000A700
       test      rax,rax
       je        short 0000000000000B56
       mov       rcx,[rax]
       mov       edx,2C
       call      0000000000009118
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       ecx,1
       call      000000000000F8A8
       int       3
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short 000000000000FC5B
       cmp       qword ptr [rbx+28],0
       je        near ptr 000000000000FCFE
       jmp       near ptr 000000000000FCFE
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr 000000000000FD03
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr 000000000000FDB2
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
       cmp       r8d,ecx
       jbe       short 000000000000FC4B
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short 000000000000FCD8
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short 000000000000FCEA
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr 000000000000FDA4
       jmp       short 000000000000FCB1
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
       xor       r14d,r14d
       jmp       short 000000000000FCEA
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FF82EEA0560
       call      qword ptr [560]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short 000000000000FDB2
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
       cmp       [r12+8],r15d
       jbe       near ptr 000000000000FC4B
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short 000000000000FD96
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FF82EEA0568
       call      qword ptr [568]
       test      eax,eax
       jne       short 000000000000FDAA
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short 000000000000FD58
       call      0000000000009748
       int       3
       mov       r14,r15
       jmp       near ptr 000000000000FCEA
       call      000000000000F130
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short 0000000000007A27
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      000000000000E520
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      000000000000B2D0
       mov       [rbp+0FFD0],rax
       call      0000000000002068
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      0000000000008818
       mov       [rbp+0FFC0],rax
       mov       r9,221090A6CC8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7BB8]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      0000000000007248
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7BC0]
       call      0000000000001068
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      000000000000B400
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      0000000000008218
       mov       rdx,221090A39F8
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      0000000000009718
       mov       rcx,221090A3A00
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short 0000000000007B5B
       mov       rcx,rsp
       call      0000000000007B77
       nop
       lea       rcx,[rbp+0FFF0]
       call      00000000000082F0
       nop
       add       rsp,0A0
       pop       rbp
       ret
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short 0000000000007BA2
       mov       rcx,[rbp+0FFE8]
       call      0000000000005CD0
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short 000000000000761D
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [5AF0]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr 00000000000078C7
       mov       r12d,edi
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr 00000000000078E1
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr 000000000000780C
       cmp       [r14+8],r8d
       ja        short 00000000000076F7
       cmp       dword ptr [rsi+40],0
       jg        near ptr 0000000000007783
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr 0000000000007728
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
       cmp       r15d,[r14+8]
       jae       near ptr 00000000000078E1
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
       mov       eax,1
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
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr 00000000000077AF
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr 00000000000078C0
       jmp       near ptr 0000000000007678
       mov       ecx,[rsi+38]
       call      qword ptr [4AF0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [5B00]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr 00000000000078E1
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr 0000000000007696
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr 00000000000078E1
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr 00000000000076A1
       mov       [rsp+28],rax
       call      qword ptr [1340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr 0000000000007712
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short 00000000000077FD
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [588]
       jmp       near ptr 00000000000076E1
       cmp       bpl,2
       jne       near ptr 0000000000007894
       jmp       near ptr 000000000000788B
       cmp       [r14+8],r8d
       jbe       near ptr 000000000000767E
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr 00000000000078A7
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[0FDC0]
       call      qword ptr [0FDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short 000000000000787E
       cmp       bpl,1
       jne       short 0000000000007885
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [588]
       jmp       near ptr 00000000000076E1
       mov       r8d,[rsp+34]
       jmp       short 00000000000078A7
       cmp       bpl,2
       jne       short 0000000000007894
       mov       ecx,edi
       call      qword ptr [9258]
       int       3
       xor       eax,eax
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
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr 000000000000780C
       call      qword ptr [0D150]
       int       3
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[0FDC8]
       call      qword ptr [0FDC8]
       mov       r12d,eax
       jmp       near ptr 0000000000007631
       call      qword ptr [578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short 0000000000000CF4
       mov       rcx,rsi
       call      0000000000009170
       test      rax,rax
       jne       short 0000000000000D09
       mov       rax,221190A3020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,offset MT_System.Text.StringBuilder
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rsi
       call      000000000000A188
       imul      edx,eax,0A
       jo        near ptr 0000000000000E2D
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      000000000000CC88
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      000000000000AEB0
       mov       rcx,offset MT_System.Action`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rsi
       call      0000000000009190
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      000000000000AEB0
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      00000000000078D8
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [2180]
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr 0000000000000E26
       cmp       dword ptr [rcx+8],0
       je        short 0000000000000E26
       xor       eax,eax
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 0000000000000DE1
       call      0000000000001630
       mov       rsi,rax
       mov       ecx,333
       mov       rdx,7FF82F296E38
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000004E0
       int       3
       cmp       [rcx],ecx
       mov       edx,3
       call      0000000000008468
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,2
       call      0000000000008468
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      0000000000008468
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short 0000000000000E2D
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr 000000000000CCC8
       mov       eax,1
       jmp       short 0000000000000DAD
       call      000000000000ECD0
       int       3
; Total bytes of code 371
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7960]
       test      rax,rax
       jne       short 000000000000EC3E
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [0EC88]
       call      qword ptr [1060]
       mov       r8,rax
       cmp       [rdi],dil
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      qword ptr [7990]
       mov       rcx,[rsi+8]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7960]
       test      rax,rax
       je        short 000000000000EC7A
       mov       rcx,[rax]
       mov       edx,2C
       call      qword ptr [3300]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       ecx,1
       call      qword ptr [0B2E8]
       int       3
; Total bytes of code 150
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi+8]
       test      rax,rax
       jne       short 000000000000E14C
       xor       ebp,ebp
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rbx,[rsi+18]
       test      rbx,rbx
       jne       short 000000000000E1C5
       mov       ecx,edi
       mov       edx,[rax+8]
       mov       r11d,edx
       mov       r8d,ecx
       imul      r8,[rsi+30]
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr 000000000000E268
       mov       edx,r11d
       lea       rax,[rax+rdx*4+10]
       mov       eax,[rax]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       eax
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short 000000000000E13A
       mov       eax,eax
       lea       rax,[rax+rax*2]
       lea       rbp,[rdx+rax*8+10]
       cmp       [rbp+8],edi
       jne       short 000000000000E1B5
       mov       eax,[rbp+10]
       cmp       eax,ecx
       jne       short 000000000000E1B5
       jmp       short 000000000000E13C
       mov       eax,[rbp+0C]
       inc       r11d
       cmp       r8d,r11d
       jae       short 000000000000E197
       jmp       near ptr 000000000000E259
       mov       rcx,rbx
       mov       edx,edi
       mov       r11,7FF842A905B8
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8d,ebp
       imul      r8,[rsi+30]
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short 000000000000E268
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r14d,[rdx]
       mov       rsi,[rsi+10]
       xor       r15d,r15d
       dec       r14d
       cmp       [rsi+8],r14d
       jbe       near ptr 000000000000E13A
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rsi+rdx*8+10]
       mov       r14,rdx
       cmp       [r14+8],ebp
       jne       short 000000000000E24C
       mov       edx,[r14+10]
       mov       rcx,rbx
       mov       r8d,edi
       mov       r11,7FF842A905C0
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000E260
       mov       r14d,[r14+0C]
       inc       r15d
       cmp       [rsi+8],r15d
       jae       short 000000000000E212
       call      qword ptr [7648]
       int       3
       mov       rbp,r14
       jmp       near ptr 000000000000E1B3
       call      00000000000023D0
       int       3
; Total bytes of code 334
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short 000000000000EE05
       mov       rcx,rsi
       call      qword ptr [33A8]
       test      rax,rax
       jne       short 000000000000EE1A
       mov       rax,2B0A9402028
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,offset MT_System.Text.StringBuilder
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rsi
       call      qword ptr [3048]
       imul      edx,eax,0A
       jo        near ptr 000000000000EFC3
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      qword ptr [71F8]
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      0000000000000010
       mov       rcx,offset MT_System.Action`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rsi
       call      qword ptr [33D8]
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      0000000000000010
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [57E0]
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [0E838]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000EECE
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short 000000000000EED0
       jmp       short 000000000000EED0
       xor       edx,edx
       test      edx,edx
       jne       near ptr 000000000000EF7A
       call      qword ptr [9C48]
       mov       rsi,rax
       mov       ecx,333
       mov       rdx,7FF842FC8D40
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF842FC9C18
       call      000000000000F510
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF842FC9C18
       call      000000000000F510
       mov       rcx,rdi
       mov       r9,rbx
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
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rcx,rax
       cmp       [rcx],cl
       mov       edx,2
       call      qword ptr [0D4E0]
       cmp       [rax],al
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [0D4E0]
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short 000000000000EFC3
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [72B8]
       call      0000000000002090
       int       3
; Total bytes of code 505
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      000000000000A700
       test      rax,rax
       jne       short 0000000000000B1A
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [0B68]
       call      000000000000E348
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      000000000000A710
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      000000000000A700
       test      rax,rax
       je        short 0000000000000B56
       mov       rcx,[rax]
       mov       edx,2C
       call      0000000000009118
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       ecx,1
       call      000000000000F898
       int       3
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short 000000000000FC5B
       cmp       qword ptr [rbx+28],0
       je        near ptr 000000000000FCFE
       jmp       near ptr 000000000000FCFE
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr 000000000000FD03
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr 000000000000FDB2
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
       cmp       r8d,ecx
       jbe       short 000000000000FC4B
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short 000000000000FCD8
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short 000000000000FCEA
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr 000000000000FDA4
       jmp       short 000000000000FCB1
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
       xor       r14d,r14d
       jmp       short 000000000000FCEA
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FF82EE90560
       call      qword ptr [560]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short 000000000000FDB2
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
       cmp       [r12+8],r15d
       jbe       near ptr 000000000000FC4B
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short 000000000000FD96
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FF82EE90568
       call      qword ptr [568]
       test      eax,eax
       jne       short 000000000000FDAA
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short 000000000000FD58
       call      0000000000009748
       int       3
       mov       r14,r15
       jmp       near ptr 000000000000FCEA
       call      000000000000F130
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short 0000000000007A27
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      000000000000E520
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      000000000000B2D0
       mov       [rbp+0FFD0],rax
       call      0000000000002068
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      0000000000008818
       mov       [rbp+0FFC0],rax
       mov       r9,1FA6C0124D8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7BB8]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      0000000000007248
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7BC0]
       call      0000000000001068
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      000000000000B400
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      0000000000008218
       mov       rdx,1FA5C017E00
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      0000000000009718
       mov       rcx,1FA5C017E08
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short 0000000000007B5B
       mov       rcx,rsp
       call      0000000000007B77
       nop
       lea       rcx,[rbp+0FFF0]
       call      00000000000082F0
       nop
       add       rsp,0A0
       pop       rbp
       ret
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short 0000000000007BA2
       mov       rcx,[rbp+0FFE8]
       call      0000000000005CD0
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short 000000000000761D
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [5AF0]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr 00000000000078C7
       mov       r12d,edi
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr 00000000000078E1
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr 000000000000780C
       cmp       [r14+8],r8d
       ja        short 00000000000076F7
       cmp       dword ptr [rsi+40],0
       jg        near ptr 0000000000007783
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr 0000000000007728
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
       cmp       r15d,[r14+8]
       jae       near ptr 00000000000078E1
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
       mov       eax,1
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
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr 00000000000077AF
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr 00000000000078C0
       jmp       near ptr 0000000000007678
       mov       ecx,[rsi+38]
       call      qword ptr [4AF0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [5B00]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr 00000000000078E1
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr 0000000000007696
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr 00000000000078E1
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr 00000000000076A1
       mov       [rsp+28],rax
       call      qword ptr [1340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr 0000000000007712
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short 00000000000077FD
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [588]
       jmp       near ptr 00000000000076E1
       cmp       bpl,2
       jne       near ptr 0000000000007894
       jmp       near ptr 000000000000788B
       cmp       [r14+8],r8d
       jbe       near ptr 000000000000767E
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr 00000000000078A7
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[0FDC0]
       call      qword ptr [0FDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short 000000000000787E
       cmp       bpl,1
       jne       short 0000000000007885
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [588]
       jmp       near ptr 00000000000076E1
       mov       r8d,[rsp+34]
       jmp       short 00000000000078A7
       cmp       bpl,2
       jne       short 0000000000007894
       mov       ecx,edi
       call      qword ptr [9258]
       int       3
       xor       eax,eax
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
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr 000000000000780C
       call      qword ptr [0D150]
       int       3
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[0FDC8]
       call      qword ptr [0FDC8]
       mov       r12d,eax
       jmp       near ptr 0000000000007631
       call      qword ptr [578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short 0000000000000CF4
       mov       rcx,rsi
       call      0000000000009170
       test      rax,rax
       jne       short 0000000000000D09
       mov       rax,1FA5C013020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,offset MT_System.Text.StringBuilder
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rsi
       call      000000000000A188
       imul      edx,eax,0A
       jo        near ptr 0000000000000E2D
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      000000000000CC88
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      000000000000AEB0
       mov       rcx,offset MT_System.Action`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rsi
       call      0000000000009190
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      000000000000AEB0
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      00000000000078D8
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [2180]
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr 0000000000000E26
       cmp       dword ptr [rcx+8],0
       je        short 0000000000000E26
       xor       eax,eax
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 0000000000000DE1
       call      0000000000001630
       mov       rsi,rax
       mov       ecx,333
       mov       rdx,7FF82F286E38
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000004E0
       int       3
       cmp       [rcx],ecx
       mov       edx,3
       call      0000000000008468
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,2
       call      0000000000008468
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      0000000000008468
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short 0000000000000E2D
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr 000000000000CCC8
       mov       eax,1
       jmp       short 0000000000000DAD
       call      000000000000ECD0
       int       3
; Total bytes of code 371
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7960]
       test      rax,rax
       jne       short 000000000000EC3E
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [0EC88]
       call      qword ptr [1060]
       mov       r8,rax
       cmp       [rdi],dil
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      qword ptr [7990]
       mov       rcx,[rsi+8]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7960]
       test      rax,rax
       je        short 000000000000EC7A
       mov       rcx,[rax]
       mov       edx,2C
       call      qword ptr [3300]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       ecx,1
       call      qword ptr [9BA0]
       int       3
; Total bytes of code 150
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi+8]
       test      rax,rax
       jne       short 000000000000E14C
       xor       ebp,ebp
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rbx,[rsi+18]
       test      rbx,rbx
       jne       short 000000000000E1C5
       mov       ecx,edi
       mov       edx,[rax+8]
       mov       r11d,edx
       mov       r8d,ecx
       imul      r8,[rsi+30]
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr 000000000000E268
       mov       edx,r11d
       lea       rax,[rax+rdx*4+10]
       mov       eax,[rax]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       eax
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short 000000000000E13A
       mov       eax,eax
       lea       rax,[rax+rax*2]
       lea       rbp,[rdx+rax*8+10]
       cmp       [rbp+8],edi
       jne       short 000000000000E1B5
       mov       eax,[rbp+10]
       cmp       eax,ecx
       jne       short 000000000000E1B5
       jmp       short 000000000000E13C
       mov       eax,[rbp+0C]
       inc       r11d
       cmp       r8d,r11d
       jae       short 000000000000E197
       jmp       near ptr 000000000000E259
       mov       rcx,rbx
       mov       edx,edi
       mov       r11,7FF842A605B8
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8d,ebp
       imul      r8,[rsi+30]
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short 000000000000E268
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r14d,[rdx]
       mov       rsi,[rsi+10]
       xor       r15d,r15d
       dec       r14d
       cmp       [rsi+8],r14d
       jbe       near ptr 000000000000E13A
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rsi+rdx*8+10]
       mov       r14,rdx
       cmp       [r14+8],ebp
       jne       short 000000000000E24C
       mov       edx,[r14+10]
       mov       rcx,rbx
       mov       r8d,edi
       mov       r11,7FF842A605C0
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000E260
       mov       r14d,[r14+0C]
       inc       r15d
       cmp       [rsi+8],r15d
       jae       short 000000000000E212
       call      qword ptr [7648]
       int       3
       mov       rbp,r14
       jmp       near ptr 000000000000E1B3
       call      00000000000023D0
       int       3
; Total bytes of code 334
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short 000000000000EE05
       mov       rcx,rsi
       call      qword ptr [33A8]
       test      rax,rax
       jne       short 000000000000EE1A
       mov       rax,22A01C02028
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,offset MT_System.Text.StringBuilder
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rsi
       call      qword ptr [3048]
       imul      edx,eax,0A
       jo        near ptr 000000000000EFC3
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      qword ptr [71F8]
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      0000000000000010
       mov       rcx,offset MT_System.Action`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rsi
       call      qword ptr [33D8]
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      0000000000000010
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [57E0]
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [0E838]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000EECE
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short 000000000000EED0
       jmp       short 000000000000EED0
       xor       edx,edx
       test      edx,edx
       jne       near ptr 000000000000EF7A
       call      qword ptr [9C48]
       mov       rsi,rax
       mov       ecx,333
       mov       rdx,7FF842F98D40
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF842F99C18
       call      000000000000F510
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF842F99C18
       call      000000000000F510
       mov       rcx,rdi
       mov       r9,rbx
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
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rcx,rax
       cmp       [rcx],cl
       mov       edx,2
       call      qword ptr [0D4E0]
       cmp       [rax],al
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [0D4E0]
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short 000000000000EFC3
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [72B8]
       call      0000000000002090
       int       3
; Total bytes of code 505
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      000000000000A700
       test      rax,rax
       jne       short 0000000000000B1A
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [0B68]
       call      000000000000E348
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      000000000000A710
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      000000000000A700
       test      rax,rax
       je        short 0000000000000B56
       mov       rcx,[rax]
       mov       edx,2C
       call      0000000000009118
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       ecx,1
       call      000000000000F8A8
       int       3
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short 000000000000FC5B
       cmp       qword ptr [rbx+28],0
       je        near ptr 000000000000FCFE
       jmp       near ptr 000000000000FCFE
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr 000000000000FD03
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr 000000000000FDB2
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
       cmp       r8d,ecx
       jbe       short 000000000000FC4B
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short 000000000000FCD8
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short 000000000000FCEA
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr 000000000000FDA4
       jmp       short 000000000000FCB1
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
       xor       r14d,r14d
       jmp       short 000000000000FCEA
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FF82EE80560
       call      qword ptr [560]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short 000000000000FDB2
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
       cmp       [r12+8],r15d
       jbe       near ptr 000000000000FC4B
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short 000000000000FD96
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FF82EE80568
       call      qword ptr [568]
       test      eax,eax
       jne       short 000000000000FDAA
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short 000000000000FD58
       call      0000000000009748
       int       3
       mov       r14,r15
       jmp       near ptr 000000000000FCEA
       call      000000000000F130
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short 0000000000007A27
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      000000000000E520
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      000000000000B2D0
       mov       [rbp+0FFD0],rax
       call      0000000000002068
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      0000000000008818
       mov       [rbp+0FFC0],rax
       mov       r9,1B6707C14C0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7BB8]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      0000000000007248
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7BC0]
       call      0000000000001068
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      000000000000B400
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      0000000000008218
       mov       rdx,1B6607C7E00
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      0000000000009718
       mov       rcx,1B6607C7E08
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short 0000000000007B5B
       mov       rcx,rsp
       call      0000000000007B77
       nop
       lea       rcx,[rbp+0FFF0]
       call      00000000000082F0
       nop
       add       rsp,0A0
       pop       rbp
       ret
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short 0000000000007BA2
       mov       rcx,[rbp+0FFE8]
       call      0000000000005CD0
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short 000000000000761D
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [5AF0]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr 00000000000078C7
       mov       r12d,edi
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr 00000000000078E1
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr 000000000000780C
       cmp       [r14+8],r8d
       ja        short 00000000000076F7
       cmp       dword ptr [rsi+40],0
       jg        near ptr 0000000000007783
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr 0000000000007728
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
       cmp       r15d,[r14+8]
       jae       near ptr 00000000000078E1
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
       mov       eax,1
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
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr 00000000000077AF
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr 00000000000078C0
       jmp       near ptr 0000000000007678
       mov       ecx,[rsi+38]
       call      qword ptr [4AF0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [5B00]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr 00000000000078E1
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr 0000000000007696
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr 00000000000078E1
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr 00000000000076A1
       mov       [rsp+28],rax
       call      qword ptr [1340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr 0000000000007712
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short 00000000000077FD
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [588]
       jmp       near ptr 00000000000076E1
       cmp       bpl,2
       jne       near ptr 0000000000007894
       jmp       near ptr 000000000000788B
       cmp       [r14+8],r8d
       jbe       near ptr 000000000000767E
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr 00000000000078A7
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[0FDC0]
       call      qword ptr [0FDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short 000000000000787E
       cmp       bpl,1
       jne       short 0000000000007885
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [588]
       jmp       near ptr 00000000000076E1
       mov       r8d,[rsp+34]
       jmp       short 00000000000078A7
       cmp       bpl,2
       jne       short 0000000000007894
       mov       ecx,edi
       call      qword ptr [9258]
       int       3
       xor       eax,eax
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
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr 000000000000780C
       call      qword ptr [0D150]
       int       3
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[0FDC8]
       call      qword ptr [0FDC8]
       mov       r12d,eax
       jmp       near ptr 0000000000007631
       call      qword ptr [578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short 0000000000000CF4
       mov       rcx,rsi
       call      0000000000009170
       test      rax,rax
       jne       short 0000000000000D09
       mov       rax,1B6607C3020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,offset MT_System.Text.StringBuilder
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rsi
       call      000000000000A188
       imul      edx,eax,0A
       jo        near ptr 0000000000000E2D
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      000000000000CC88
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      000000000000AEB0
       mov       rcx,offset MT_System.Action`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rsi
       call      0000000000009190
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      000000000000AEB0
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      00000000000078D8
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [2180]
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr 0000000000000E26
       cmp       dword ptr [rcx+8],0
       je        short 0000000000000E26
       xor       eax,eax
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 0000000000000DE1
       call      0000000000001630
       mov       rsi,rax
       mov       ecx,333
       mov       rdx,7FF82F276E38
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000004E0
       int       3
       cmp       [rcx],ecx
       mov       edx,3
       call      0000000000008468
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,2
       call      0000000000008468
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      0000000000008468
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short 0000000000000E2D
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr 000000000000CCC8
       mov       eax,1
       jmp       short 0000000000000DAD
       call      000000000000ECD0
       int       3
; Total bytes of code 371
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7960]
       test      rax,rax
       jne       short 000000000000EC3E
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [0EC88]
       call      qword ptr [1060]
       mov       r8,rax
       cmp       [rdi],dil
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      qword ptr [7990]
       mov       rcx,[rsi+8]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7960]
       test      rax,rax
       je        short 000000000000EC7A
       mov       rcx,[rax]
       mov       edx,2C
       call      qword ptr [3300]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       ecx,1
       call      qword ptr [9BA0]
       int       3
; Total bytes of code 150
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi+8]
       test      rax,rax
       jne       short 000000000000E14C
       xor       ebp,ebp
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rbx,[rsi+18]
       test      rbx,rbx
       jne       short 000000000000E1C5
       mov       ecx,edi
       mov       edx,[rax+8]
       mov       r11d,edx
       mov       r8d,ecx
       imul      r8,[rsi+30]
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr 000000000000E268
       mov       edx,r11d
       lea       rax,[rax+rdx*4+10]
       mov       eax,[rax]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       eax
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short 000000000000E13A
       mov       eax,eax
       lea       rax,[rax+rax*2]
       lea       rbp,[rdx+rax*8+10]
       cmp       [rbp+8],edi
       jne       short 000000000000E1B5
       mov       eax,[rbp+10]
       cmp       eax,ecx
       jne       short 000000000000E1B5
       jmp       short 000000000000E13C
       mov       eax,[rbp+0C]
       inc       r11d
       cmp       r8d,r11d
       jae       short 000000000000E197
       jmp       near ptr 000000000000E259
       mov       rcx,rbx
       mov       edx,edi
       mov       r11,7FF842A805B8
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8d,ebp
       imul      r8,[rsi+30]
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short 000000000000E268
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r14d,[rdx]
       mov       rsi,[rsi+10]
       xor       r15d,r15d
       dec       r14d
       cmp       [rsi+8],r14d
       jbe       near ptr 000000000000E13A
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rsi+rdx*8+10]
       mov       r14,rdx
       cmp       [r14+8],ebp
       jne       short 000000000000E24C
       mov       edx,[r14+10]
       mov       rcx,rbx
       mov       r8d,edi
       mov       r11,7FF842A805C0
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000E260
       mov       r14d,[r14+0C]
       inc       r15d
       cmp       [rsi+8],r15d
       jae       short 000000000000E212
       call      qword ptr [7648]
       int       3
       mov       rbp,r14
       jmp       near ptr 000000000000E1B3
       call      00000000000023D0
       int       3
; Total bytes of code 334
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short 000000000000EE05
       mov       rcx,rsi
       call      qword ptr [33A8]
       test      rax,rax
       jne       short 000000000000EE1A
       mov       rax,1A227000030
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,offset MT_System.Text.StringBuilder
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rsi
       call      qword ptr [3048]
       imul      edx,eax,0A
       jo        near ptr 000000000000EFC3
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      qword ptr [71F8]
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      0000000000000010
       mov       rcx,offset MT_System.Action`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rsi
       call      qword ptr [33D8]
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      0000000000000010
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [57E0]
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [0E838]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000EECE
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short 000000000000EED0
       jmp       short 000000000000EED0
       xor       edx,edx
       test      edx,edx
       jne       near ptr 000000000000EF7A
       call      qword ptr [9C48]
       mov       rsi,rax
       mov       ecx,333
       mov       rdx,7FF842FB8D40
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF842FB9C18
       call      000000000000F510
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF842FB9C18
       call      000000000000F510
       mov       rcx,rdi
       mov       r9,rbx
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
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rcx,rax
       cmp       [rcx],cl
       mov       edx,2
       call      qword ptr [0D4E0]
       cmp       [rax],al
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [0D4E0]
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short 000000000000EFC3
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [72B8]
       call      0000000000002090
       int       3
; Total bytes of code 505
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      000000000000A700
       test      rax,rax
       jne       short 0000000000000B1A
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [0B68]
       call      000000000000E348
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      000000000000A710
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      000000000000A700
       test      rax,rax
       je        short 0000000000000B56
       mov       rcx,[rax]
       mov       edx,2C
       call      0000000000009118
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       ecx,1
       call      000000000000F8A8
       int       3
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short 000000000000FC5B
       cmp       qword ptr [rbx+28],0
       je        near ptr 000000000000FCFE
       jmp       near ptr 000000000000FCFE
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr 000000000000FD03
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr 000000000000FDB2
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
       cmp       r8d,ecx
       jbe       short 000000000000FC4B
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short 000000000000FCD8
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short 000000000000FCEA
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr 000000000000FDA4
       jmp       short 000000000000FCB1
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
       xor       r14d,r14d
       jmp       short 000000000000FCEA
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FF82EE70560
       call      qword ptr [560]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short 000000000000FDB2
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
       cmp       [r12+8],r15d
       jbe       near ptr 000000000000FC4B
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short 000000000000FD96
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FF82EE70568
       call      qword ptr [568]
       test      eax,eax
       jne       short 000000000000FDAA
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short 000000000000FD58
       call      0000000000009748
       int       3
       mov       r14,r15
       jmp       near ptr 000000000000FCEA
       call      000000000000F130
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short 0000000000007A27
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      000000000000E520
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      000000000000B2D0
       mov       [rbp+0FFD0],rax
       call      0000000000002068
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      0000000000008818
       mov       [rbp+0FFC0],rax
       mov       r9,1A8315524D8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7BB8]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      0000000000007248
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7BC0]
       call      0000000000001068
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      000000000000B400
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      0000000000008218
       mov       rdx,1A851557E00
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      0000000000009718
       mov       rcx,1A851557E08
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short 0000000000007B5B
       mov       rcx,rsp
       call      0000000000007B77
       nop
       lea       rcx,[rbp+0FFF0]
       call      00000000000082F0
       nop
       add       rsp,0A0
       pop       rbp
       ret
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short 0000000000007BA2
       mov       rcx,[rbp+0FFE8]
       call      0000000000005CD0
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short 000000000000761D
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [5AF0]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr 00000000000078C7
       mov       r12d,edi
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr 00000000000078E1
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr 000000000000780C
       cmp       [r14+8],r8d
       ja        short 00000000000076F7
       cmp       dword ptr [rsi+40],0
       jg        near ptr 0000000000007783
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr 0000000000007728
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
       cmp       r15d,[r14+8]
       jae       near ptr 00000000000078E1
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
       mov       eax,1
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
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr 00000000000077AF
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr 00000000000078C0
       jmp       near ptr 0000000000007678
       mov       ecx,[rsi+38]
       call      qword ptr [4AF0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [5B00]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr 00000000000078E1
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr 0000000000007696
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr 00000000000078E1
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr 00000000000076A1
       mov       [rsp+28],rax
       call      qword ptr [1340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr 0000000000007712
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short 00000000000077FD
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [588]
       jmp       near ptr 00000000000076E1
       cmp       bpl,2
       jne       near ptr 0000000000007894
       jmp       near ptr 000000000000788B
       cmp       [r14+8],r8d
       jbe       near ptr 000000000000767E
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr 00000000000078A7
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[0FDC0]
       call      qword ptr [0FDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short 000000000000787E
       cmp       bpl,1
       jne       short 0000000000007885
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [588]
       jmp       near ptr 00000000000076E1
       mov       r8d,[rsp+34]
       jmp       short 00000000000078A7
       cmp       bpl,2
       jne       short 0000000000007894
       mov       ecx,edi
       call      qword ptr [9258]
       int       3
       xor       eax,eax
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
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr 000000000000780C
       call      qword ptr [0D150]
       int       3
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[0FDC8]
       call      qword ptr [0FDC8]
       mov       r12d,eax
       jmp       near ptr 0000000000007631
       call      qword ptr [578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short 0000000000000CF4
       mov       rcx,rsi
       call      0000000000009170
       test      rax,rax
       jne       short 0000000000000D09
       mov       rax,1A851553020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,offset MT_System.Text.StringBuilder
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rsi
       call      000000000000A188
       imul      edx,eax,0A
       jo        near ptr 0000000000000E2D
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      000000000000CC88
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      000000000000AEB0
       mov       rcx,offset MT_System.Action`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rsi
       call      0000000000009190
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      000000000000AEB0
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      00000000000078D8
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [2180]
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr 0000000000000E26
       cmp       dword ptr [rcx+8],0
       je        short 0000000000000E26
       xor       eax,eax
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 0000000000000DE1
       call      0000000000001630
       mov       rsi,rax
       mov       ecx,333
       mov       rdx,7FF82F266E38
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000004E0
       int       3
       cmp       [rcx],ecx
       mov       edx,3
       call      0000000000008468
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,2
       call      0000000000008468
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      0000000000008468
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short 0000000000000E2D
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr 000000000000CCC8
       mov       eax,1
       jmp       short 0000000000000DAD
       call      000000000000ECD0
       int       3
; Total bytes of code 371
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7960]
       test      rax,rax
       jne       short 000000000000EC3E
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [0EC88]
       call      qword ptr [1060]
       mov       r8,rax
       cmp       [rdi],dil
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      qword ptr [7990]
       mov       rcx,[rsi+8]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7960]
       test      rax,rax
       je        short 000000000000EC7A
       mov       rcx,[rax]
       mov       edx,2C
       call      qword ptr [3300]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       ecx,1
       call      qword ptr [9BA0]
       int       3
; Total bytes of code 150
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi+8]
       test      rax,rax
       jne       short 000000000000E14C
       xor       ebp,ebp
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rbx,[rsi+18]
       test      rbx,rbx
       jne       short 000000000000E1C5
       mov       ecx,edi
       mov       edx,[rax+8]
       mov       r11d,edx
       mov       r8d,ecx
       imul      r8,[rsi+30]
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr 000000000000E268
       mov       edx,r11d
       lea       rax,[rax+rdx*4+10]
       mov       eax,[rax]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       eax
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short 000000000000E13A
       mov       eax,eax
       lea       rax,[rax+rax*2]
       lea       rbp,[rdx+rax*8+10]
       cmp       [rbp+8],edi
       jne       short 000000000000E1B5
       mov       eax,[rbp+10]
       cmp       eax,ecx
       jne       short 000000000000E1B5
       jmp       short 000000000000E13C
       mov       eax,[rbp+0C]
       inc       r11d
       cmp       r8d,r11d
       jae       short 000000000000E197
       jmp       near ptr 000000000000E259
       mov       rcx,rbx
       mov       edx,edi
       mov       r11,7FF842A505B8
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8d,ebp
       imul      r8,[rsi+30]
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short 000000000000E268
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r14d,[rdx]
       mov       rsi,[rsi+10]
       xor       r15d,r15d
       dec       r14d
       cmp       [rsi+8],r14d
       jbe       near ptr 000000000000E13A
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rsi+rdx*8+10]
       mov       r14,rdx
       cmp       [r14+8],ebp
       jne       short 000000000000E24C
       mov       edx,[r14+10]
       mov       rcx,rbx
       mov       r8d,edi
       mov       r11,7FF842A505C0
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000E260
       mov       r14d,[r14+0C]
       inc       r15d
       cmp       [rsi+8],r15d
       jae       short 000000000000E212
       call      qword ptr [7648]
       int       3
       mov       rbp,r14
       jmp       near ptr 000000000000E1B3
       call      00000000000023D0
       int       3
; Total bytes of code 334
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short 000000000000EE05
       mov       rcx,rsi
       call      qword ptr [33A8]
       test      rax,rax
       jne       short 000000000000EE1A
       mov       rax,1A150802028
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,offset MT_System.Text.StringBuilder
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rsi
       call      qword ptr [3048]
       imul      edx,eax,0A
       jo        near ptr 000000000000EFC3
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      qword ptr [71F8]
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      0000000000000010
       mov       rcx,offset MT_System.Action`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rsi
       call      qword ptr [33D8]
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      0000000000000010
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [57E0]
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [0E838]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000EECE
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short 000000000000EED0
       jmp       short 000000000000EED0
       xor       edx,edx
       test      edx,edx
       jne       near ptr 000000000000EF7A
       call      qword ptr [9C48]
       mov       rsi,rax
       mov       ecx,333
       mov       rdx,7FF842F88D40
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF842F89C18
       call      000000000000F510
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF842F89C18
       call      000000000000F510
       mov       rcx,rdi
       mov       r9,rbx
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
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rcx,rax
       cmp       [rcx],cl
       mov       edx,2
       call      qword ptr [0D4E0]
       cmp       [rax],al
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [0D4E0]
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short 000000000000EFC3
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [72B8]
       call      0000000000002090
       int       3
; Total bytes of code 505
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      000000000000A700
       test      rax,rax
       jne       short 0000000000000B1A
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [0B68]
       call      000000000000E348
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      000000000000A710
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      000000000000A700
       test      rax,rax
       je        short 0000000000000B56
       mov       rcx,[rax]
       mov       edx,2C
       call      0000000000009118
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       ecx,1
       call      000000000000F8A8
       int       3
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short 000000000000FC5B
       cmp       qword ptr [rbx+28],0
       je        near ptr 000000000000FCFE
       jmp       near ptr 000000000000FCFE
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr 000000000000FD03
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr 000000000000FDB2
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
       cmp       r8d,ecx
       jbe       short 000000000000FC4B
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short 000000000000FCD8
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short 000000000000FCEA
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr 000000000000FDA4
       jmp       short 000000000000FCB1
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
       xor       r14d,r14d
       jmp       short 000000000000FCEA
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FF82EE80560
       call      qword ptr [560]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short 000000000000FDB2
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
       cmp       [r12+8],r15d
       jbe       near ptr 000000000000FC4B
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short 000000000000FD96
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FF82EE80568
       call      qword ptr [568]
       test      eax,eax
       jne       short 000000000000FDAA
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short 000000000000FD58
       call      0000000000009748
       int       3
       mov       r14,r15
       jmp       near ptr 000000000000FCEA
       call      000000000000F130
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short 0000000000007A27
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      000000000000E520
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      000000000000B2D0
       mov       [rbp+0FFD0],rax
       call      0000000000002068
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      0000000000008818
       mov       [rbp+0FFC0],rax
       mov       r9,1B5A6ADB0D0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7BB8]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      0000000000007248
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7BC0]
       call      0000000000001068
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      000000000000B400
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      0000000000008218
       mov       rdx,1B5A6AD7E00
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      0000000000009718
       mov       rcx,1B5A6AD7E08
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short 0000000000007B5B
       mov       rcx,rsp
       call      0000000000007B77
       nop
       lea       rcx,[rbp+0FFF0]
       call      00000000000082F0
       nop
       add       rsp,0A0
       pop       rbp
       ret
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short 0000000000007BA2
       mov       rcx,[rbp+0FFE8]
       call      0000000000005CD0
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short 000000000000761D
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [5AF0]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr 00000000000078C7
       mov       r12d,edi
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr 00000000000078E1
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr 000000000000780C
       cmp       [r14+8],r8d
       ja        short 00000000000076F7
       cmp       dword ptr [rsi+40],0
       jg        near ptr 0000000000007783
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr 0000000000007728
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
       cmp       r15d,[r14+8]
       jae       near ptr 00000000000078E1
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
       mov       eax,1
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
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr 00000000000077AF
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr 00000000000078C0
       jmp       near ptr 0000000000007678
       mov       ecx,[rsi+38]
       call      qword ptr [4AF0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [5B00]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr 00000000000078E1
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr 0000000000007696
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr 00000000000078E1
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr 00000000000076A1
       mov       [rsp+28],rax
       call      qword ptr [1340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr 0000000000007712
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short 00000000000077FD
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [588]
       jmp       near ptr 00000000000076E1
       cmp       bpl,2
       jne       near ptr 0000000000007894
       jmp       near ptr 000000000000788B
       cmp       [r14+8],r8d
       jbe       near ptr 000000000000767E
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr 00000000000078A7
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[0FDC0]
       call      qword ptr [0FDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short 000000000000787E
       cmp       bpl,1
       jne       short 0000000000007885
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [588]
       jmp       near ptr 00000000000076E1
       mov       r8d,[rsp+34]
       jmp       short 00000000000078A7
       cmp       bpl,2
       jne       short 0000000000007894
       mov       ecx,edi
       call      qword ptr [9258]
       int       3
       xor       eax,eax
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
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr 000000000000780C
       call      qword ptr [0D150]
       int       3
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[0FDC8]
       call      qword ptr [0FDC8]
       mov       r12d,eax
       jmp       near ptr 0000000000007631
       call      qword ptr [578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short 0000000000000CF4
       mov       rcx,rsi
       call      0000000000009170
       test      rax,rax
       jne       short 0000000000000D09
       mov       rax,1B5A6AD3020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,offset MT_System.Text.StringBuilder
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rsi
       call      000000000000A188
       imul      edx,eax,0A
       jo        near ptr 0000000000000E2D
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      000000000000CC88
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      000000000000AEB0
       mov       rcx,offset MT_System.Action`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rsi
       call      0000000000009190
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      000000000000AEB0
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      00000000000078D8
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [2180]
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr 0000000000000E26
       cmp       dword ptr [rcx+8],0
       je        short 0000000000000E26
       xor       eax,eax
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 0000000000000DE1
       call      0000000000001630
       mov       rsi,rax
       mov       ecx,333
       mov       rdx,7FF82F276E38
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000004E0
       int       3
       cmp       [rcx],ecx
       mov       edx,3
       call      0000000000008468
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,2
       call      0000000000008468
       cmp       [rax],eax
       mov       rcx,rax
       mov       edx,1
       call      0000000000008468
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short 0000000000000E2D
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr 000000000000CCC8
       mov       eax,1
       jmp       short 0000000000000DAD
       call      000000000000ECD0
       int       3
; Total bytes of code 371
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
; 			var bytes = base.GetByteArray(1).AsEnumerable();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = bytes.ToDelimitedString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7960]
       test      rax,rax
       jne       short 000000000000EC3E
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [0EC88]
       call      qword ptr [1060]
       mov       r8,rax
       cmp       [rdi],dil
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      qword ptr [7990]
       mov       rcx,[rsi+8]
       cmp       [rcx],cl
       mov       edx,1
       call      qword ptr [7960]
       test      rax,rax
       je        short 000000000000EC7A
       mov       rcx,[rax]
       mov       edx,2C
       call      qword ptr [1EB8]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       ecx,1
       call      qword ptr [9888]
       int       3
; Total bytes of code 150
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi+8]
       test      rax,rax
       jne       short 000000000000E14C
       xor       ebp,ebp
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rbx,[rsi+18]
       test      rbx,rbx
       jne       short 000000000000E1C5
       mov       ecx,edi
       mov       edx,[rax+8]
       mov       r11d,edx
       mov       r8d,ecx
       imul      r8,[rsi+30]
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr 000000000000E268
       mov       edx,r11d
       lea       rax,[rax+rdx*4+10]
       mov       eax,[rax]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       eax
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short 000000000000E13A
       mov       eax,eax
       lea       rax,[rax+rax*2]
       lea       rbp,[rdx+rax*8+10]
       cmp       [rbp+8],edi
       jne       short 000000000000E1B5
       mov       eax,[rbp+10]
       cmp       eax,ecx
       jne       short 000000000000E1B5
       jmp       short 000000000000E13C
       mov       eax,[rbp+0C]
       inc       r11d
       cmp       r8d,r11d
       jae       short 000000000000E197
       jmp       near ptr 000000000000E259
       mov       rcx,rbx
       mov       edx,edi
       mov       r11,7FF842A805B8
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8d,ebp
       imul      r8,[rsi+30]
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short 000000000000E268
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r14d,[rdx]
       mov       rsi,[rsi+10]
       xor       r15d,r15d
       dec       r14d
       cmp       [rsi+8],r14d
       jbe       near ptr 000000000000E13A
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rsi+rdx*8+10]
       mov       r14,rdx
       cmp       [r14+8],ebp
       jne       short 000000000000E24C
       mov       edx,[r14+10]
       mov       rcx,rbx
       mov       r8d,edi
       mov       r11,7FF842A805C0
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000E260
       mov       r14d,[r14+0C]
       inc       r15d
       cmp       [rsi+8],r15d
       jae       short 000000000000E212
       call      qword ptr [7648]
       int       3
       mov       rbp,r14
       jmp       near ptr 000000000000E1B3
       call      00000000000023D0
       int       3
; Total bytes of code 334
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Byte, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Byte>, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       [rbx+10],di
       test      rsi,rsi
       je        short 000000000000EE05
       mov       rcx,rsi
       call      qword ptr [1F60]
       test      rax,rax
       jne       short 000000000000EE1A
       mov       rax,24DA8002028
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,offset MT_System.Text.StringBuilder
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rsi
       call      qword ptr [1C00]
       imul      edx,eax,0A
       jo        near ptr 000000000000EFC3
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      qword ptr [71F8]
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      0000000000000010
       mov       rcx,offset MT_System.Action`1[[System.Byte, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rsi
       call      qword ptr [1F90]
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      0000000000000010
       mov       rcx,offset DotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass27_0`1[[System.Byte, System.Private.CoreLib]].<ToDelimitedString>b__0(Byte)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [57E0]
       mov       rcx,[rbx+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [0E838]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000EECE
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short 000000000000EED0
       jmp       short 000000000000EED0
       xor       edx,edx
       test      edx,edx
       jne       near ptr 000000000000EF7A
       call      qword ptr [9C48]
       mov       rsi,rax
       mov       ecx,333
       mov       rdx,7FF842FB8D40
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF842FB9C18
       call      000000000000F510
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF842FB9C18
       call      000000000000F510
       mov       rcx,rdi
       mov       r9,rbx
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
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rcx,rax
       cmp       [rcx],cl
       mov       edx,2
       call      qword ptr [0D4E0]
       cmp       [rax],al
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [0D4E0]
       mov       r8d,[rax+8]
       sub       r8d,1
       jo        short 000000000000EFC3
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [72B8]
       call      0000000000002090
       int       3
; Total bytes of code 505
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0B8]
       mov       rcx,rsi
       call      00000000000021D8
       mov       rcx,rax
       call      000000000000AF88
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       mov       edx,esi
       call      000000000000A780
       test      rax,rax
       jne       short 0000000000002B77
       mov       rbx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       call      0000000000000218
       mov       r8,rax
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,esi
       mov       r9d,2
       call      000000000000A790
       mov       rcx,[rdi+8]
       mov       edx,esi
       mov       rax,[3498]
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short 000000000000C539
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      000000000000B028
       test      eax,eax
       je        short 000000000000C539
       cmp       dword ptr [rsp+20],0
       setg      cl
       movzx     ecx,cl
       jmp       short 000000000000C53B
       xor       ecx,ecx
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000C62B
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
       mov       rdx,29409E86900
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      000000000000CDD0
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short 000000000000C5E1
       mov       rdx,293E9E81568
       mov       r14,[rdx]
       mov       rdx,29409E86908
       mov       r15,[rdx]
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      0000000000000BA8
       mov       rdx,rax
       mov       rcx,rdi
       call      000000000000CDD0
       add       ebx,1
       jo        short 000000000000C626
       cmp       ebp,ebx
       jg        short 000000000000C5B7
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short 000000000000C5FC
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short 000000000000C60F
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      000000000000CDC0
       mov       rcx,rdi
       call      qword ptr [2180]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       call      000000000000ECD0
       call      00000000000033A0
       mov       rsi,rax
       mov       rax,293E9E831E0
       mov       rdi,[rax]
       cmp       dword ptr [rdi+8],0
       je        short 000000000000C64A
       xor       eax,eax
       jmp       short 000000000000C64F
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 000000000000C675
       call      00000000000034C0
       mov       rcx,rax
       mov       rdx,29409E868F8
       mov       rdx,[rdx]
       call      00000000000025C8
       mov       rcx,rdi
       mov       edx,3
       call      0000000000008468
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rbx,rax
       call      0000000000003378
       mov       rdx,rax
       mov       rcx,rsi
       call      0000000000002598
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      00000000000001E8
       mov       rcx,rbx
       call      00000000000055B0
       int       3
; Total bytes of code 446
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0B4]
       mov       rcx,rsi
       call      qword ptr [0BD38]
       mov       rcx,rax
       call      qword ptr [3000]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       rcx,[rdi+8]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7960]
       test      rax,rax
       jne       short 0000000000000E4A
       mov       rbx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       call      qword ptr [1060]
       mov       r8,rax
       cmp       [rbx],bl
       mov       rcx,rbx
       mov       edx,esi
       mov       r9d,2
       call      qword ptr [7990]
       mov       rcx,[rdi+8]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7960]
       test      rax,rax
       je        short 0000000000000E68
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       ecx,esi
       call      qword ptr [7F90]
       int       3
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short 0000000000000F35
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [30F0]
       test      eax,eax
       je        short 0000000000000F35
       xor       ecx,ecx
       cmp       dword ptr [rsp+20],0
       setg      cl
       jmp       short 0000000000000F37
       xor       ecx,ecx
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 0000000000001039
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
       mov       rdx,21ABD8055D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7AC8]
       xor       ebx,ebx
       cmp       dword ptr [rsi+8],0
       jle       short 0000000000000FF3
       mov       rdx,21ABD800558
       mov       rbp,[rdx]
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,21ABD8055E0
       mov       rdx,[rdx]
       call      qword ptr [7FC0]
       mov       rdx,rax
       test      rdx,rdx
       je        short 0000000000000FE9
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7AC8]
       add       ebx,1
       jo        short 0000000000001034
       cmp       [rsi+8],ebx
       jg        short 0000000000000FB0
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short 000000000000101E
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       mov       rcx,rdi
       call      qword ptr [0E838]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7360]
       jmp       short 000000000000100B
       call      0000000000002090
       call      qword ptr [98E8]
       mov       rsi,rax
       mov       rax,21ABD8021D8
       mov       rdi,[rax]
       xor       eax,eax
       cmp       dword ptr [rdi+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 0000000000001080
       call      qword ptr [9C48]
       mov       rcx,rax
       mov       rdx,21ABD8055F8
       mov       rdx,[rdx]
       call      qword ptr [9D98]
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [0D4E0]
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
       int       3
; Total bytes of code 461
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0B8]
       mov       rcx,rsi
       call      00000000000021D8
       mov       rcx,rax
       call      0000000000009108
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       mov       edx,esi
       call      000000000000A700
       test      rax,rax
       jne       short 000000000000EE57
       mov       rbx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       call      000000000000E348
       mov       r8,rax
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,esi
       mov       r9d,2
       call      000000000000A710
       mov       rcx,[rdi+8]
       mov       edx,esi
       mov       rax,[3498]
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short 000000000000A659
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      00000000000091A8
       test      eax,eax
       je        short 000000000000A659
       cmp       dword ptr [rsp+20],0
       setg      cl
       movzx     ecx,cl
       jmp       short 000000000000A65B
       xor       ecx,ecx
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000A74B
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
       mov       rdx,284DBAB1910
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      000000000000CD10
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short 000000000000A701
       mov       rdx,284CBAB1568
       mov       r14,[rdx]
       mov       rdx,284DBAB1918
       mov       r15,[rdx]
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      00000000000010B0
       mov       rdx,rax
       mov       rcx,rdi
       call      000000000000CD10
       add       ebx,1
       jo        short 000000000000A746
       cmp       ebp,ebx
       jg        short 000000000000A6D7
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short 000000000000A71C
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short 000000000000A72F
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      000000000000CD00
       mov       rcx,rdi
       call      qword ptr [2180]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       call      000000000000ECD0
       call      0000000000001510
       mov       rsi,rax
       mov       rax,284CBAB31E0
       mov       rdi,[rax]
       cmp       dword ptr [rdi+8],0
       je        short 000000000000A76A
       xor       eax,eax
       jmp       short 000000000000A76F
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 000000000000A795
       call      0000000000001630
       mov       rcx,rax
       mov       rdx,284DBAB1908
       mov       rdx,[rdx]
       call      00000000000004E0
       mov       rcx,rdi
       mov       edx,3
       call      0000000000008468
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rbx,rax
       call      00000000000014E8
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000004B0
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      00000000000001E8
       mov       rcx,rbx
       call      00000000000055B0
       int       3
; Total bytes of code 446
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0B4]
       mov       rcx,rsi
       call      qword ptr [0BD38]
       mov       rcx,rax
       call      qword ptr [3000]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       rcx,[rdi+8]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7960]
       test      rax,rax
       jne       short 000000000000D70A
       mov       rbx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       call      qword ptr [1060]
       mov       r8,rax
       cmp       [rbx],bl
       mov       rcx,rbx
       mov       edx,esi
       mov       r9d,2
       call      qword ptr [7990]
       mov       rcx,[rdi+8]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7960]
       test      rax,rax
       je        short 000000000000D728
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       ecx,esi
       call      qword ptr [58B8]
       int       3
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short 000000000000D7F5
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [30F0]
       test      eax,eax
       je        short 000000000000D7F5
       xor       ecx,ecx
       cmp       dword ptr [rsp+20],0
       setg      cl
       jmp       short 000000000000D7F7
       xor       ecx,ecx
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000D8F9
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
       mov       rdx,18A630095B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7AC8]
       xor       ebx,ebx
       cmp       dword ptr [rsi+8],0
       jle       short 000000000000D8B3
       mov       rdx,18A63000558
       mov       rbp,[rdx]
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,18A630095B8
       mov       rdx,[rdx]
       call      qword ptr [7FC0]
       mov       rdx,rax
       test      rdx,rdx
       je        short 000000000000D8A9
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7AC8]
       add       ebx,1
       jo        short 000000000000D8F4
       cmp       [rsi+8],ebx
       jg        short 000000000000D870
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short 000000000000D8DE
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       mov       rcx,rdi
       call      qword ptr [0E838]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7360]
       jmp       short 000000000000D8CB
       call      0000000000002090
       call      qword ptr [98E8]
       mov       rsi,rax
       mov       rax,18A630021D8
       mov       rdi,[rax]
       xor       eax,eax
       cmp       dword ptr [rdi+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 000000000000D940
       call      qword ptr [9C48]
       mov       rcx,rax
       mov       rdx,18A630095C0
       mov       rdx,[rdx]
       call      qword ptr [9D98]
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [0D4E0]
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
       int       3
; Total bytes of code 461
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0B8]
       mov       rcx,rsi
       call      00000000000021D8
       mov       rcx,rax
       call      0000000000009108
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       mov       edx,esi
       call      000000000000A700
       test      rax,rax
       jne       short 000000000000EE67
       mov       rbx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       call      000000000000E348
       mov       r8,rax
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,esi
       mov       r9d,2
       call      000000000000A710
       mov       rcx,[rdi+8]
       mov       edx,esi
       mov       rax,[3498]
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short 000000000000A659
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      00000000000091A8
       test      eax,eax
       je        short 000000000000A659
       cmp       dword ptr [rsp+20],0
       setg      cl
       movzx     ecx,cl
       jmp       short 000000000000A65B
       xor       ecx,ecx
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000A74B
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
       mov       rdx,1F4038A2128
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      000000000000CD10
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short 000000000000A701
       mov       rdx,1F3F38A1568
       mov       r14,[rdx]
       mov       rdx,1F4038A2130
       mov       r15,[rdx]
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      00000000000010B0
       mov       rdx,rax
       mov       rcx,rdi
       call      000000000000CD10
       add       ebx,1
       jo        short 000000000000A746
       cmp       ebp,ebx
       jg        short 000000000000A6D7
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short 000000000000A71C
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short 000000000000A72F
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      000000000000CD00
       mov       rcx,rdi
       call      qword ptr [2180]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       call      000000000000ECD0
       call      0000000000001510
       mov       rsi,rax
       mov       rax,1F3F38A31E0
       mov       rdi,[rax]
       cmp       dword ptr [rdi+8],0
       je        short 000000000000A76A
       xor       eax,eax
       jmp       short 000000000000A76F
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 000000000000A795
       call      0000000000001630
       mov       rcx,rax
       mov       rdx,1F4038A2120
       mov       rdx,[rdx]
       call      00000000000004E0
       mov       rcx,rdi
       mov       edx,3
       call      0000000000008468
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rbx,rax
       call      00000000000014E8
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000004B0
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      00000000000001E8
       mov       rcx,rbx
       call      00000000000055B0
       int       3
; Total bytes of code 446
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0B4]
       mov       rcx,rsi
       call      qword ptr [0BD38]
       mov       rcx,rax
       call      qword ptr [3000]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       rcx,[rdi+8]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7960]
       test      rax,rax
       jne       short 000000000000D6EA
       mov       rbx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       call      qword ptr [1060]
       mov       r8,rax
       cmp       [rbx],bl
       mov       rcx,rbx
       mov       edx,esi
       mov       r9d,2
       call      qword ptr [7990]
       mov       rcx,[rdi+8]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7960]
       test      rax,rax
       je        short 000000000000D708
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       ecx,esi
       call      qword ptr [58B8]
       int       3
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short 000000000000D7D5
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [30F0]
       test      eax,eax
       je        short 000000000000D7D5
       xor       ecx,ecx
       cmp       dword ptr [rsp+20],0
       setg      cl
       jmp       short 000000000000D7D7
       xor       ecx,ecx
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000D8D9
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
       mov       rdx,14B9C0009B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7AC8]
       xor       ebx,ebx
       cmp       dword ptr [rsi+8],0
       jle       short 000000000000D893
       mov       rdx,14B98000558
       mov       rbp,[rdx]
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,14B9C0009C0
       mov       rdx,[rdx]
       call      qword ptr [7FC0]
       mov       rdx,rax
       test      rdx,rdx
       je        short 000000000000D889
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7AC8]
       add       ebx,1
       jo        short 000000000000D8D4
       cmp       [rsi+8],ebx
       jg        short 000000000000D850
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short 000000000000D8BE
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       mov       rcx,rdi
       call      qword ptr [0E838]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7360]
       jmp       short 000000000000D8AB
       call      0000000000002090
       call      qword ptr [98E8]
       mov       rsi,rax
       mov       rax,14B980021D8
       mov       rdi,[rax]
       xor       eax,eax
       cmp       dword ptr [rdi+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 000000000000D920
       call      qword ptr [9C48]
       mov       rcx,rax
       mov       rdx,14B9C0009C8
       mov       rdx,[rdx]
       call      qword ptr [9D98]
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [0D4E0]
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
       int       3
; Total bytes of code 461
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0B8]
       mov       rcx,rsi
       call      00000000000021D8
       mov       rcx,rax
       call      0000000000009108
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       mov       edx,esi
       call      000000000000A700
       test      rax,rax
       jne       short 000000000000EC97
       mov       rbx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       call      000000000000E348
       mov       r8,rax
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,esi
       mov       r9d,2
       call      000000000000A710
       mov       rcx,[rdi+8]
       mov       edx,esi
       mov       rax,[3498]
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short 000000000000A659
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      00000000000091A8
       test      eax,eax
       je        short 000000000000A659
       cmp       dword ptr [rsp+20],0
       setg      cl
       movzx     ecx,cl
       jmp       short 000000000000A65B
       xor       ecx,ecx
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000A74B
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
       mov       rdx,27878B59CF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      000000000000CD10
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short 000000000000A701
       mov       rdx,27878B51568
       mov       r14,[rdx]
       mov       rdx,27878B59CF8
       mov       r15,[rdx]
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      00000000000010B0
       mov       rdx,rax
       mov       rcx,rdi
       call      000000000000CD10
       add       ebx,1
       jo        short 000000000000A746
       cmp       ebp,ebx
       jg        short 000000000000A6D7
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short 000000000000A71C
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short 000000000000A72F
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      000000000000CD00
       mov       rcx,rdi
       call      qword ptr [2180]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       call      000000000000ECD0
       call      0000000000001510
       mov       rsi,rax
       mov       rax,27878B531E0
       mov       rdi,[rax]
       cmp       dword ptr [rdi+8],0
       je        short 000000000000A76A
       xor       eax,eax
       jmp       short 000000000000A76F
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 000000000000A795
       call      0000000000001630
       mov       rcx,rax
       mov       rdx,27878B59CE8
       mov       rdx,[rdx]
       call      00000000000004E0
       mov       rcx,rdi
       mov       edx,3
       call      0000000000008468
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rbx,rax
       call      00000000000014E8
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000004B0
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      00000000000001E8
       mov       rcx,rbx
       call      00000000000055B0
       int       3
; Total bytes of code 446
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0B4]
       mov       rcx,rsi
       call      qword ptr [0BD38]
       mov       rcx,rax
       call      qword ptr [1BA0]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       rcx,[rdi+8]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7960]
       test      rax,rax
       jne       short 000000000000D74A
       mov       rbx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       call      qword ptr [1060]
       mov       r8,rax
       cmp       [rbx],bl
       mov       rcx,rbx
       mov       edx,esi
       mov       r9d,2
       call      qword ptr [7990]
       mov       rcx,[rdi+8]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7960]
       test      rax,rax
       je        short 000000000000D768
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       ecx,esi
       call      qword ptr [58B8]
       int       3
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short 000000000000D835
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [1C90]
       test      eax,eax
       je        short 000000000000D835
       xor       ecx,ecx
       cmp       dword ptr [rsp+20],0
       setg      cl
       jmp       short 000000000000D837
       xor       ecx,ecx
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000D939
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
       mov       rdx,1CD8E4009B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7AC8]
       xor       ebx,ebx
       cmp       dword ptr [rsi+8],0
       jle       short 000000000000D8F3
       mov       rdx,1CD8A400558
       mov       rbp,[rdx]
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,1CD8E4009C0
       mov       rdx,[rdx]
       call      qword ptr [7FC0]
       mov       rdx,rax
       test      rdx,rdx
       je        short 000000000000D8E9
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7AC8]
       add       ebx,1
       jo        short 000000000000D934
       cmp       [rsi+8],ebx
       jg        short 000000000000D8B0
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short 000000000000D91E
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       mov       rcx,rdi
       call      qword ptr [0E838]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7360]
       jmp       short 000000000000D90B
       call      0000000000002090
       call      qword ptr [98E8]
       mov       rsi,rax
       mov       rax,1CD8A4021D8
       mov       rdi,[rax]
       xor       eax,eax
       cmp       dword ptr [rdi+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 000000000000D980
       call      qword ptr [9C48]
       mov       rcx,rax
       mov       rdx,1CD8E4009C8
       mov       rdx,[rdx]
       call      qword ptr [9D98]
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [0D4E0]
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
       int       3
; Total bytes of code 461
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0B8]
       mov       rcx,rsi
       call      00000000000021D8
       mov       rcx,rax
       call      0000000000009108
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       mov       edx,esi
       call      000000000000A700
       test      rax,rax
       jne       short 000000000000EDC7
       mov       rbx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       call      000000000000E348
       mov       r8,rax
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,esi
       mov       r9d,2
       call      000000000000A710
       mov       rcx,[rdi+8]
       mov       edx,esi
       mov       rax,[3498]
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short 000000000000A659
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      00000000000091A8
       test      eax,eax
       je        short 000000000000A659
       cmp       dword ptr [rsp+20],0
       setg      cl
       movzx     ecx,cl
       jmp       short 000000000000A65B
       xor       ecx,ecx
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000A74B
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
       mov       rdx,17AE9012928
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      000000000000CD10
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short 000000000000A701
       mov       rdx,17AD9011568
       mov       r14,[rdx]
       mov       rdx,17AE9012930
       mov       r15,[rdx]
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      00000000000010B0
       mov       rdx,rax
       mov       rcx,rdi
       call      000000000000CD10
       add       ebx,1
       jo        short 000000000000A746
       cmp       ebp,ebx
       jg        short 000000000000A6D7
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short 000000000000A71C
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short 000000000000A72F
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      000000000000CD00
       mov       rcx,rdi
       call      qword ptr [2180]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       call      000000000000ECD0
       call      0000000000001510
       mov       rsi,rax
       mov       rax,17AD90131E0
       mov       rdi,[rax]
       cmp       dword ptr [rdi+8],0
       je        short 000000000000A76A
       xor       eax,eax
       jmp       short 000000000000A76F
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 000000000000A795
       call      0000000000001630
       mov       rcx,rax
       mov       rdx,17AE9012920
       mov       rdx,[rdx]
       call      00000000000004E0
       mov       rcx,rdi
       mov       edx,3
       call      0000000000008468
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rbx,rax
       call      00000000000014E8
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000004B0
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      00000000000001E8
       mov       rcx,rbx
       call      00000000000055B0
       int       3
; Total bytes of code 446
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0B4]
       mov       rcx,rsi
       call      qword ptr [0BD38]
       mov       rcx,rax
       call      qword ptr [3000]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       rcx,[rdi+8]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7960]
       test      rax,rax
       jne       short 000000000000D6EA
       mov       rbx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       call      qword ptr [1060]
       mov       r8,rax
       cmp       [rbx],bl
       mov       rcx,rbx
       mov       edx,esi
       mov       r9d,2
       call      qword ptr [7990]
       mov       rcx,[rdi+8]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7960]
       test      rax,rax
       je        short 000000000000D708
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       ecx,esi
       call      qword ptr [5978]
       int       3
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short 000000000000D7D5
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [30F0]
       test      eax,eax
       je        short 000000000000D7D5
       xor       ecx,ecx
       cmp       dword ptr [rsp+20],0
       setg      cl
       jmp       short 000000000000D7D7
       xor       ecx,ecx
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000D8D9
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
       mov       rdx,29CFFC021E8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7AC8]
       xor       ebx,ebx
       cmp       dword ptr [rsi+8],0
       jle       short 000000000000D893
       mov       rdx,29CFDC00558
       mov       rbp,[rdx]
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,29CFFC021F0
       mov       rdx,[rdx]
       call      qword ptr [7FC0]
       mov       rdx,rax
       test      rdx,rdx
       je        short 000000000000D889
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7AC8]
       add       ebx,1
       jo        short 000000000000D8D4
       cmp       [rsi+8],ebx
       jg        short 000000000000D850
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short 000000000000D8BE
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       mov       rcx,rdi
       call      qword ptr [0E838]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7360]
       jmp       short 000000000000D8AB
       call      0000000000002090
       call      qword ptr [98E8]
       mov       rsi,rax
       mov       rax,29CFDC021D8
       mov       rdi,[rax]
       xor       eax,eax
       cmp       dword ptr [rdi+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 000000000000D920
       call      qword ptr [9C48]
       mov       rcx,rax
       mov       rdx,29CFFC021F8
       mov       rdx,[rdx]
       call      qword ptr [9D98]
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [0D4E0]
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
       int       3
; Total bytes of code 461
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0B8]
       mov       rcx,rsi
       call      00000000000021D8
       mov       rcx,rax
       call      0000000000009108
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       mov       edx,esi
       call      000000000000A700
       test      rax,rax
       jne       short 000000000000EDC7
       mov       rbx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       call      000000000000E348
       mov       r8,rax
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,esi
       mov       r9d,2
       call      000000000000A710
       mov       rcx,[rdi+8]
       mov       edx,esi
       mov       rax,[3498]
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short 000000000000A659
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      00000000000091A8
       test      eax,eax
       je        short 000000000000A659
       cmp       dword ptr [rsp+20],0
       setg      cl
       movzx     ecx,cl
       jmp       short 000000000000A65B
       xor       ecx,ecx
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000A74B
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
       mov       rdx,265098E2128
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      000000000000CD10
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short 000000000000A701
       mov       rdx,264F98E1568
       mov       r14,[rdx]
       mov       rdx,265098E2130
       mov       r15,[rdx]
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      00000000000010B0
       mov       rdx,rax
       mov       rcx,rdi
       call      000000000000CD10
       add       ebx,1
       jo        short 000000000000A746
       cmp       ebp,ebx
       jg        short 000000000000A6D7
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short 000000000000A71C
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short 000000000000A72F
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      000000000000CD00
       mov       rcx,rdi
       call      qword ptr [2180]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       call      000000000000ECD0
       call      0000000000001510
       mov       rsi,rax
       mov       rax,264F98E31E0
       mov       rdi,[rax]
       cmp       dword ptr [rdi+8],0
       je        short 000000000000A76A
       xor       eax,eax
       jmp       short 000000000000A76F
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 000000000000A795
       call      0000000000001630
       mov       rcx,rax
       mov       rdx,265098E2120
       mov       rdx,[rdx]
       call      00000000000004E0
       mov       rcx,rdi
       mov       edx,3
       call      0000000000008468
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rbx,rax
       call      00000000000014E8
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000004B0
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      00000000000001E8
       mov       rcx,rbx
       call      00000000000055B0
       int       3
; Total bytes of code 446
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0B4]
       mov       rcx,rsi
       call      qword ptr [0BD38]
       mov       rcx,rax
       call      qword ptr [3000]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       rcx,[rdi+8]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7960]
       test      rax,rax
       jne       short 000000000000D74A
       mov       rbx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       call      qword ptr [1060]
       mov       r8,rax
       cmp       [rbx],bl
       mov       rcx,rbx
       mov       edx,esi
       mov       r9d,2
       call      qword ptr [7990]
       mov       rcx,[rdi+8]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7960]
       test      rax,rax
       je        short 000000000000D768
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       ecx,esi
       call      qword ptr [58B8]
       int       3
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short 000000000000D835
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [30F0]
       test      eax,eax
       je        short 000000000000D835
       xor       ecx,ecx
       cmp       dword ptr [rsp+20],0
       setg      cl
       jmp       short 000000000000D837
       xor       ecx,ecx
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000D939
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
       mov       rdx,1A5C8C09DB0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7AC8]
       xor       ebx,ebx
       cmp       dword ptr [rsi+8],0
       jle       short 000000000000D8F3
       mov       rdx,1A5C8C00558
       mov       rbp,[rdx]
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,1A5C8C09DB8
       mov       rdx,[rdx]
       call      qword ptr [7FC0]
       mov       rdx,rax
       test      rdx,rdx
       je        short 000000000000D8E9
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7AC8]
       add       ebx,1
       jo        short 000000000000D934
       cmp       [rsi+8],ebx
       jg        short 000000000000D8B0
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short 000000000000D91E
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       mov       rcx,rdi
       call      qword ptr [0E838]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7360]
       jmp       short 000000000000D90B
       call      0000000000002090
       call      qword ptr [98E8]
       mov       rsi,rax
       mov       rax,1A5C8C021D8
       mov       rdi,[rax]
       xor       eax,eax
       cmp       dword ptr [rdi+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 000000000000D980
       call      qword ptr [9C48]
       mov       rcx,rax
       mov       rdx,1A5C8C09DC0
       mov       rdx,[rdx]
       call      qword ptr [9D98]
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [0D4E0]
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
       int       3
; Total bytes of code 461
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0B8]
       mov       rcx,rsi
       call      00000000000021D8
       mov       rcx,rax
       call      0000000000009108
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       mov       edx,esi
       call      000000000000A700
       test      rax,rax
       jne       short 000000000000EDC7
       mov       rbx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       call      000000000000E348
       mov       r8,rax
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,esi
       mov       r9d,2
       call      000000000000A710
       mov       rcx,[rdi+8]
       mov       edx,esi
       mov       rax,[3498]
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short 000000000000A659
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      00000000000091A8
       test      eax,eax
       je        short 000000000000A659
       cmp       dword ptr [rsp+20],0
       setg      cl
       movzx     ecx,cl
       jmp       short 000000000000A65B
       xor       ecx,ecx
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000A74B
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
       mov       rdx,17BE2CC2128
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      000000000000CD10
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short 000000000000A701
       mov       rdx,17BD2CC1568
       mov       r14,[rdx]
       mov       rdx,17BE2CC2130
       mov       r15,[rdx]
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      00000000000010B0
       mov       rdx,rax
       mov       rcx,rdi
       call      000000000000CD10
       add       ebx,1
       jo        short 000000000000A746
       cmp       ebp,ebx
       jg        short 000000000000A6D7
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short 000000000000A71C
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short 000000000000A72F
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      000000000000CD00
       mov       rcx,rdi
       call      qword ptr [2180]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       call      000000000000ECD0
       call      0000000000001510
       mov       rsi,rax
       mov       rax,17BD2CC31E0
       mov       rdi,[rax]
       cmp       dword ptr [rdi+8],0
       je        short 000000000000A76A
       xor       eax,eax
       jmp       short 000000000000A76F
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 000000000000A795
       call      0000000000001630
       mov       rcx,rax
       mov       rdx,17BE2CC2120
       mov       rdx,[rdx]
       call      00000000000004E0
       mov       rcx,rdi
       mov       edx,3
       call      0000000000008468
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rbx,rax
       call      00000000000014E8
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000004B0
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      00000000000001E8
       mov       rcx,rbx
       call      00000000000055B0
       int       3
; Total bytes of code 446
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0B4]
       mov       rcx,rsi
       call      qword ptr [0BD38]
       mov       rcx,rax
       call      qword ptr [1BA0]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       rcx,[rdi+8]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7960]
       test      rax,rax
       jne       short 000000000000D6EA
       mov       rbx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       call      qword ptr [1060]
       mov       r8,rax
       cmp       [rbx],bl
       mov       rcx,rbx
       mov       edx,esi
       mov       r9d,2
       call      qword ptr [7990]
       mov       rcx,[rdi+8]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7960]
       test      rax,rax
       je        short 000000000000D708
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       ecx,esi
       call      qword ptr [5978]
       int       3
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short 000000000000D7D5
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [1C90]
       test      eax,eax
       je        short 000000000000D7D5
       xor       ecx,ecx
       cmp       dword ptr [rsp+20],0
       setg      cl
       jmp       short 000000000000D7D7
       xor       ecx,ecx
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000D8D9
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
       mov       rdx,2A0ABC019D0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7AC8]
       xor       ebx,ebx
       cmp       dword ptr [rsi+8],0
       jle       short 000000000000D893
       mov       rdx,2A0ADC00558
       mov       rbp,[rdx]
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,2A0ABC019D8
       mov       rdx,[rdx]
       call      qword ptr [7FC0]
       mov       rdx,rax
       test      rdx,rdx
       je        short 000000000000D889
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7AC8]
       add       ebx,1
       jo        short 000000000000D8D4
       cmp       [rsi+8],ebx
       jg        short 000000000000D850
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short 000000000000D8BE
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       mov       rcx,rdi
       call      qword ptr [0E838]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7360]
       jmp       short 000000000000D8AB
       call      0000000000002090
       call      qword ptr [98E8]
       mov       rsi,rax
       mov       rax,2A0ADC021D8
       mov       rdi,[rax]
       xor       eax,eax
       cmp       dword ptr [rdi+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 000000000000D920
       call      qword ptr [9C48]
       mov       rcx,rax
       mov       rdx,2A0ABC019E0
       mov       rdx,[rdx]
       call      qword ptr [9D98]
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [0D4E0]
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
       int       3
; Total bytes of code 461
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0B8]
       mov       rcx,rsi
       call      00000000000021D8
       mov       rcx,rax
       call      0000000000009108
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       mov       edx,esi
       call      000000000000A700
       test      rax,rax
       jne       short 000000000000EDC7
       mov       rbx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       call      000000000000E348
       mov       r8,rax
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,esi
       mov       r9d,2
       call      000000000000A710
       mov       rcx,[rdi+8]
       mov       edx,esi
       mov       rax,[3498]
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short 000000000000A659
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      00000000000091A8
       test      eax,eax
       je        short 000000000000A659
       cmp       dword ptr [rsp+20],0
       setg      cl
       movzx     ecx,cl
       jmp       short 000000000000A65B
       xor       ecx,ecx
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000A74B
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
       mov       rdx,2194EC41910
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      000000000000CD10
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short 000000000000A701
       mov       rdx,2193EC41568
       mov       r14,[rdx]
       mov       rdx,2194EC41918
       mov       r15,[rdx]
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      00000000000010B0
       mov       rdx,rax
       mov       rcx,rdi
       call      000000000000CD10
       add       ebx,1
       jo        short 000000000000A746
       cmp       ebp,ebx
       jg        short 000000000000A6D7
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short 000000000000A71C
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short 000000000000A72F
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      000000000000CD00
       mov       rcx,rdi
       call      qword ptr [2180]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       call      000000000000ECD0
       call      0000000000001510
       mov       rsi,rax
       mov       rax,2193EC431E0
       mov       rdi,[rax]
       cmp       dword ptr [rdi+8],0
       je        short 000000000000A76A
       xor       eax,eax
       jmp       short 000000000000A76F
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 000000000000A795
       call      0000000000001630
       mov       rcx,rax
       mov       rdx,2194EC41908
       mov       rdx,[rdx]
       call      00000000000004E0
       mov       rcx,rdi
       mov       edx,3
       call      0000000000008468
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rbx,rax
       call      00000000000014E8
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000004B0
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      00000000000001E8
       mov       rcx,rbx
       call      00000000000055B0
       int       3
; Total bytes of code 446
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0B4]
       mov       rcx,rsi
       call      qword ptr [0BD38]
       mov       rcx,rax
       call      qword ptr [1BA0]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       rcx,[rdi+8]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7960]
       test      rax,rax
       jne       short 000000000000D6EA
       mov       rbx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       call      qword ptr [1060]
       mov       r8,rax
       cmp       [rbx],bl
       mov       rcx,rbx
       mov       edx,esi
       mov       r9d,2
       call      qword ptr [7990]
       mov       rcx,[rdi+8]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7960]
       test      rax,rax
       je        short 000000000000D708
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       ecx,esi
       call      qword ptr [5978]
       int       3
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short 000000000000D7D5
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [1C90]
       test      eax,eax
       je        short 000000000000D7D5
       xor       ecx,ecx
       cmp       dword ptr [rsp+20],0
       setg      cl
       jmp       short 000000000000D7D7
       xor       ecx,ecx
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000D8D9
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
       mov       rdx,255A3009DB0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7AC8]
       xor       ebx,ebx
       cmp       dword ptr [rsi+8],0
       jle       short 000000000000D893
       mov       rdx,255A3000558
       mov       rbp,[rdx]
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,255A3009DB8
       mov       rdx,[rdx]
       call      qword ptr [7FC0]
       mov       rdx,rax
       test      rdx,rdx
       je        short 000000000000D889
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7AC8]
       add       ebx,1
       jo        short 000000000000D8D4
       cmp       [rsi+8],ebx
       jg        short 000000000000D850
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short 000000000000D8BE
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       mov       rcx,rdi
       call      qword ptr [0E838]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7360]
       jmp       short 000000000000D8AB
       call      0000000000002090
       call      qword ptr [98E8]
       mov       rsi,rax
       mov       rax,255A30021D8
       mov       rdi,[rax]
       xor       eax,eax
       cmp       dword ptr [rdi+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 000000000000D920
       call      qword ptr [9C48]
       mov       rcx,rax
       mov       rdx,255A3009DC0
       mov       rdx,[rdx]
       call      qword ptr [9D98]
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [0D4E0]
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
       int       3
; Total bytes of code 461
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0B8]
       mov       rcx,rsi
       call      00000000000021D8
       mov       rcx,rax
       call      0000000000009108
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       mov       edx,esi
       call      000000000000A700
       test      rax,rax
       jne       short 000000000000EEA7
       mov       rbx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       call      000000000000E348
       mov       r8,rax
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,esi
       mov       r9d,2
       call      000000000000A710
       mov       rcx,[rdi+8]
       mov       edx,esi
       mov       rax,[3498]
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short 000000000000A659
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      00000000000091A8
       test      eax,eax
       je        short 000000000000A659
       cmp       dword ptr [rsp+20],0
       setg      cl
       movzx     ecx,cl
       jmp       short 000000000000A65B
       xor       ecx,ecx
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000A74B
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
       mov       rdx,20DC7332928
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      000000000000CD10
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short 000000000000A701
       mov       rdx,20DD7331568
       mov       r14,[rdx]
       mov       rdx,20DC7332930
       mov       r15,[rdx]
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      00000000000010B0
       mov       rdx,rax
       mov       rcx,rdi
       call      000000000000CD10
       add       ebx,1
       jo        short 000000000000A746
       cmp       ebp,ebx
       jg        short 000000000000A6D7
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short 000000000000A71C
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short 000000000000A72F
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      000000000000CD00
       mov       rcx,rdi
       call      qword ptr [2180]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       call      000000000000ECD0
       call      0000000000001510
       mov       rsi,rax
       mov       rax,20DD73331E0
       mov       rdi,[rax]
       cmp       dword ptr [rdi+8],0
       je        short 000000000000A76A
       xor       eax,eax
       jmp       short 000000000000A76F
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 000000000000A795
       call      0000000000001630
       mov       rcx,rax
       mov       rdx,20DC7332920
       mov       rdx,[rdx]
       call      00000000000004E0
       mov       rcx,rdi
       mov       edx,3
       call      0000000000008468
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rbx,rax
       call      00000000000014E8
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000004B0
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      00000000000001E8
       mov       rcx,rbx
       call      00000000000055B0
       int       3
; Total bytes of code 446
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString01()
; 			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0B4]
       mov       rcx,rsi
       call      qword ptr [0BD38]
       mov       rcx,rax
       call      qword ptr [3000]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetByteArray(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rdi,rcx
       mov       esi,edx
       mov       rcx,[rdi+8]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7960]
       test      rax,rax
       jne       short 000000000000D79A
       mov       rbx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       call      qword ptr [1060]
       mov       r8,rax
       cmp       [rbx],bl
       mov       rcx,rbx
       mov       edx,esi
       mov       r9d,2
       call      qword ptr [7990]
       mov       rcx,[rdi+8]
       cmp       [rcx],cl
       mov       edx,esi
       call      qword ptr [7960]
       test      rax,rax
       je        short 000000000000D7B8
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       ecx,esi
       call      qword ptr [59F0]
       int       3
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short 000000000000D895
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [30F0]
       test      eax,eax
       je        short 000000000000D895
       xor       ecx,ecx
       cmp       dword ptr [rsp+20],0
       setg      cl
       jmp       short 000000000000D897
       xor       ecx,ecx
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000D999
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
       mov       rdx,279184021E8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7AC8]
       xor       ebx,ebx
       cmp       dword ptr [rsi+8],0
       jle       short 000000000000D953
       mov       rdx,2791C400558
       mov       rbp,[rdx]
       mov       edx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,279184021F0
       mov       rdx,[rdx]
       call      qword ptr [7FC0]
       mov       rdx,rax
       test      rdx,rdx
       je        short 000000000000D949
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rdi
       call      qword ptr [7AC8]
       add       ebx,1
       jo        short 000000000000D994
       cmp       [rsi+8],ebx
       jg        short 000000000000D910
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short 000000000000D97E
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       mov       rcx,rdi
       call      qword ptr [0E838]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      qword ptr [7360]
       jmp       short 000000000000D96B
       call      0000000000002090
       call      qword ptr [98E8]
       mov       rsi,rax
       mov       rax,2791C4021D8
       mov       rdi,[rax]
       xor       eax,eax
       cmp       dword ptr [rdi+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 000000000000D9E0
       call      qword ptr [9C48]
       mov       rcx,rax
       mov       rdx,279184021F8
       mov       rdx,[rdx]
       call      qword ptr [9D98]
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [0D4E0]
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
       int       3
; Total bytes of code 461
```

