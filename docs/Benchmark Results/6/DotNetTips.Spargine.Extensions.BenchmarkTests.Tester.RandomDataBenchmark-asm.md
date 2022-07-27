## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.CreatePerson01()
; 			var person = RandomData.GenerateRefPerson<Person>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(person);
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
       call      000000000000E470
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
; Total bytes of code 104
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
       je        short 0000000000003D49
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       jmp       short 0000000000003D5B
       mov       rdx,7FF82F31F2A8
       call      0000000000004920
       mov       rcx,rax
       call      000000000000B448
       mov       rbp,rax
       call      0000000000001A08
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EE90518
       call      qword ptr [518]
       mov       ecx,esi
       call      000000000000E430
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EE90520
       call      qword ptr [520]
       mov       ecx,esi
       call      000000000000E430
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EE90528
       call      qword ptr [528]
       call      000000000000D800
       mov       rdx,rax
       lea       rcx,[rsp+50]
       mov       r8d,1
       call      000000000000E118
       mov       ecx,1
       mov       edx,4B
       call      000000000000E3A0
       imul      ecx,eax,16D
       jo        near ptr 000000000000400D
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rax,46DC5D638865
       cmp       rcx,rax
       jg        near ptr 0000000000004012
       mov       rax,0B923A29C779B
       cmp       rcx,rax
       jl        near ptr 0000000000004012
       imul      rsi,rcx,2710
       lea       rcx,[rsp+50]
       call      000000000000DF30
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rax
       sub       rdx,rsi
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr 000000000000403E
       mov       rcx,0
       and       rcx,rax
       or        rdx,rcx
       mov       ecx,[rsp+50]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr 0000000000004046
       mov       r8,0FF29406B2A1B
       cmp       rcx,r8
       jl        near ptr 0000000000004046
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+30],xmm0
       lea       rcx,[rsp+30]
       call      000000000000DEE0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rcx,rbp
       lea       rdx,[rsp+20]
       mov       r11,7FF82EE90530
       call      qword ptr [530]
       call      000000000000E3E0
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EE90538
       call      qword ptr [538]
       mov       ecx,edi
       call      000000000000E430
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EE90540
       call      qword ptr [540]
       mov       ecx,ebx
       call      000000000000E430
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EE90548
       call      qword ptr [548]
       call      000000000000E380
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EE90550
       call      qword ptr [550]
       mov       ecx,[rsp+0B0]
       call      000000000000E430
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EE90558
       call      qword ptr [558]
       call      000000000000E3E0
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EE90560
       call      qword ptr [560]
       mov       ecx,[rsp+0B8]
       call      000000000000E430
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EE90568
       call      qword ptr [568]
       mov       ecx,[rsp+0C0]
       call      000000000000E3B0
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EE90570
       call      qword ptr [570]
       mov       ecx,[rsp+0C8]
       call      000000000000E430
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EE90578
       call      qword ptr [578]
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
       call      000000000000DB18
       int       3
       call      0000000000009608
       int       3
; Total bytes of code 828
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.CreatePerson01()
; 			var person = RandomData.GenerateRefPerson<Person>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(person);
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
       call      qword ptr [13C0]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,48
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 103
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
       je        short 0000000000000439
       mov       rcx,[r14+10]
       jmp       short 000000000000044E
       mov       rcx,rsi
       mov       rdx,7FF7EC7B87F8
       call      0000000000000CA0
       mov       rcx,rax
       call      qword ptr [0B318]
       mov       r15,rax
       call      qword ptr [0B258]
       mov       r12,rax
       cmp       qword ptr [r14+18],0
       je        short 000000000000046D
       mov       r11,[r14+18]
       jmp       short 0000000000000482
       mov       rcx,rsi
       mov       rdx,7FF7EC7B8818
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,r12
       call      qword ptr [r11]
       mov       ecx,edi
       call      qword ptr [1318]
       mov       r12,rax
       cmp       qword ptr [r14+20],0
       je        short 00000000000004A3
       mov       r11,[r14+20]
       jmp       short 00000000000004B8
       mov       rcx,rsi
       mov       rdx,7FF7EC7B8828
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,r12
       call      qword ptr [r11]
       mov       ecx,edi
       call      qword ptr [1318]
       mov       rdi,rax
       cmp       qword ptr [r14+28],0
       je        short 00000000000004D9
       mov       r11,[r14+28]
       jmp       short 00000000000004EE
       mov       rcx,rsi
       mov       rdx,7FF7EC7B8838
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
       call      qword ptr [1168]
       imul      ecx,eax,16D
       jo        near ptr 0000000000000881
       movsxd    rcx,ecx
       mov       rax,141DD76000
       imul      rcx,rax
       mov       rax,0CCCCCCCCCCCC
       cmp       rcx,rax
       jg        near ptr 0000000000000886
       mov       rax,333333333334
       cmp       rcx,rax
       jl        near ptr 0000000000000886
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
       jg        near ptr 0000000000000886
       mov       r8,0FF29406B2A1B
       cmp       rcx,r8
       jl        near ptr 0000000000000886
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+30],xmm0
       lea       rcx,[rsp+30]
       call      qword ptr [0F048]
       mov       rcx,[rsi+10]
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+48],xmm0
       cmp       qword ptr [rcx+8],30
       jle       short 00000000000005FF
       mov       rax,[rcx+30]
       test      rax,rax
       je        short 00000000000005FF
       jmp       short 0000000000000611
       mov       rcx,rsi
       mov       rdx,7FF7EC7B8918
       call      0000000000000CA0
       mov       r11,rax
       vmovupd   xmm0,[rsp+48]
       vmovupd   [rsp+20],xmm0
       mov       rcx,r15
       lea       rdx,[rsp+20]
       call      qword ptr [rax]
       mov       rdi,[rsi+10]
       call      qword ptr [1228]
       mov       r14,rax
       cmp       qword ptr [rdi+8],38
       jle       short 0000000000000649
       mov       r11,[rdi+38]
       test      r11,r11
       je        short 0000000000000649
       jmp       short 000000000000065E
       mov       rcx,rsi
       mov       rdx,7FF7EC7B8928
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       mov       ecx,ebx
       call      qword ptr [1318]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],40
       jle       short 0000000000000688
       mov       r11,[rdi+40]
       test      r11,r11
       je        short 0000000000000688
       jmp       short 000000000000069D
       mov       rcx,rsi
       mov       rdx,7FF7EC7B8938
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       mov       ecx,ebp
       call      qword ptr [1318]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],48
       jle       short 00000000000006C7
       mov       r11,[rdi+48]
       test      r11,r11
       je        short 00000000000006C7
       jmp       short 00000000000006DC
       mov       rcx,rsi
       mov       rdx,7FF7EC7B8948
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       call      qword ptr [1108]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],50
       jle       short 0000000000000704
       mov       r11,[rdi+50]
       test      r11,r11
       je        short 0000000000000704
       jmp       short 0000000000000719
       mov       rcx,rsi
       mov       rdx,7FF7EC7B8A60
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       mov       ecx,[rsp+0D0]
       call      qword ptr [1318]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],58
       jle       short 0000000000000748
       mov       r11,[rdi+58]
       test      r11,r11
       je        short 0000000000000748
       jmp       short 000000000000075D
       mov       rcx,rsi
       mov       rdx,7FF7EC7B8A70
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       call      qword ptr [1228]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],60
       jle       short 0000000000000785
       mov       r11,[rdi+60]
       test      r11,r11
       je        short 0000000000000785
       jmp       short 000000000000079A
       mov       rcx,rsi
       mov       rdx,7FF7EC7B8A80
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       mov       ecx,[rsp+0D8]
       call      qword ptr [1318]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],68
       jle       short 00000000000007C9
       mov       r11,[rdi+68]
       test      r11,r11
       je        short 00000000000007C9
       jmp       short 00000000000007DE
       mov       rcx,rsi
       mov       rdx,7FF7EC7B8A90
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       mov       ecx,[rsp+0E0]
       call      qword ptr [1198]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],70
       jle       short 000000000000080D
       mov       r11,[rdi+70]
       test      r11,r11
       je        short 000000000000080D
       jmp       short 0000000000000822
       mov       rcx,rsi
       mov       rdx,7FF7EC7B8AA0
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       mov       ecx,[rsp+0E8]
       call      qword ptr [1318]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],78
       jle       short 0000000000000851
       mov       r11,[rdi+78]
       test      r11,r11
       je        short 0000000000000851
       jmp       short 0000000000000866
       mov       rcx,rsi
       mov       rdx,7FF7EC7B8AB0
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.CreatePerson04()
; 			var person = RandomData.GenerateRefPerson<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(person);
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
       call      000000000000E470
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
; Total bytes of code 104
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
       je        short 00000000000018E9
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       jmp       short 00000000000018FB
       mov       rdx,7FF82F32F2A8
       call      0000000000004920
       mov       rcx,rax
       call      000000000000B448
       mov       rbp,rax
       call      0000000000001A08
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EEA0518
       call      qword ptr [518]
       mov       ecx,esi
       call      000000000000E430
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EEA0520
       call      qword ptr [520]
       mov       ecx,esi
       call      000000000000E430
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EEA0528
       call      qword ptr [528]
       call      000000000000D800
       mov       rdx,rax
       lea       rcx,[rsp+50]
       mov       r8d,1
       call      000000000000E118
       mov       ecx,1
       mov       edx,4B
       call      000000000000E3A0
       imul      ecx,eax,16D
       jo        near ptr 0000000000001BAD
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rax,46DC5D638865
       cmp       rcx,rax
       jg        near ptr 0000000000001BB2
       mov       rax,0B923A29C779B
       cmp       rcx,rax
       jl        near ptr 0000000000001BB2
       imul      rsi,rcx,2710
       lea       rcx,[rsp+50]
       call      000000000000DF30
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rax
       sub       rdx,rsi
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr 0000000000001BDE
       mov       rcx,0
       and       rcx,rax
       or        rdx,rcx
       mov       ecx,[rsp+50]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr 0000000000001BE6
       mov       r8,0FF29406B2A1B
       cmp       rcx,r8
       jl        near ptr 0000000000001BE6
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+30],xmm0
       lea       rcx,[rsp+30]
       call      000000000000DEE0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rcx,rbp
       lea       rdx,[rsp+20]
       mov       r11,7FF82EEA0530
       call      qword ptr [530]
       call      000000000000E3E0
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EEA0538
       call      qword ptr [538]
       mov       ecx,edi
       call      000000000000E430
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EEA0540
       call      qword ptr [540]
       mov       ecx,ebx
       call      000000000000E430
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EEA0548
       call      qword ptr [548]
       call      000000000000E380
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EEA0550
       call      qword ptr [550]
       mov       ecx,[rsp+0B0]
       call      000000000000E430
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EEA0558
       call      qword ptr [558]
       call      000000000000E3E0
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EEA0560
       call      qword ptr [560]
       mov       ecx,[rsp+0B8]
       call      000000000000E430
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EEA0568
       call      qword ptr [568]
       mov       ecx,[rsp+0C0]
       call      000000000000E3B0
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EEA0570
       call      qword ptr [570]
       mov       ecx,[rsp+0C8]
       call      000000000000E430
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EEA0578
       call      qword ptr [578]
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
       call      000000000000DB18
       int       3
       call      0000000000009608
       int       3
; Total bytes of code 828
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.CreatePerson04()
; 			var person = RandomData.GenerateRefPerson<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(person);
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
       call      qword ptr [13C0]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,48
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 103
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
       je        short 0000000000000329
       mov       rcx,[r14+10]
       jmp       short 000000000000033E
       mov       rcx,rsi
       mov       rdx,7FF7EC7887F8
       call      0000000000000CA0
       mov       rcx,rax
       call      qword ptr [0B318]
       mov       r15,rax
       call      qword ptr [0B258]
       mov       r12,rax
       cmp       qword ptr [r14+18],0
       je        short 000000000000035D
       mov       r11,[r14+18]
       jmp       short 0000000000000372
       mov       rcx,rsi
       mov       rdx,7FF7EC788818
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,r12
       call      qword ptr [r11]
       mov       ecx,edi
       call      qword ptr [1318]
       mov       r12,rax
       cmp       qword ptr [r14+20],0
       je        short 0000000000000393
       mov       r11,[r14+20]
       jmp       short 00000000000003A8
       mov       rcx,rsi
       mov       rdx,7FF7EC788828
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,r12
       call      qword ptr [r11]
       mov       ecx,edi
       call      qword ptr [1318]
       mov       rdi,rax
       cmp       qword ptr [r14+28],0
       je        short 00000000000003C9
       mov       r11,[r14+28]
       jmp       short 00000000000003DE
       mov       rcx,rsi
       mov       rdx,7FF7EC788838
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
       call      qword ptr [1168]
       imul      ecx,eax,16D
       jo        near ptr 0000000000000771
       movsxd    rcx,ecx
       mov       rax,141DD76000
       imul      rcx,rax
       mov       rax,0CCCCCCCCCCCC
       cmp       rcx,rax
       jg        near ptr 0000000000000776
       mov       rax,333333333334
       cmp       rcx,rax
       jl        near ptr 0000000000000776
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
       jg        near ptr 0000000000000776
       mov       r8,0FF29406B2A1B
       cmp       rcx,r8
       jl        near ptr 0000000000000776
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+30],xmm0
       lea       rcx,[rsp+30]
       call      qword ptr [0F048]
       mov       rcx,[rsi+10]
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+48],xmm0
       cmp       qword ptr [rcx+8],30
       jle       short 00000000000004EF
       mov       rax,[rcx+30]
       test      rax,rax
       je        short 00000000000004EF
       jmp       short 0000000000000501
       mov       rcx,rsi
       mov       rdx,7FF7EC788918
       call      0000000000000CA0
       mov       r11,rax
       vmovupd   xmm0,[rsp+48]
       vmovupd   [rsp+20],xmm0
       mov       rcx,r15
       lea       rdx,[rsp+20]
       call      qword ptr [rax]
       mov       rdi,[rsi+10]
       call      qword ptr [1228]
       mov       r14,rax
       cmp       qword ptr [rdi+8],38
       jle       short 0000000000000539
       mov       r11,[rdi+38]
       test      r11,r11
       je        short 0000000000000539
       jmp       short 000000000000054E
       mov       rcx,rsi
       mov       rdx,7FF7EC788928
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       mov       ecx,ebx
       call      qword ptr [1318]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],40
       jle       short 0000000000000578
       mov       r11,[rdi+40]
       test      r11,r11
       je        short 0000000000000578
       jmp       short 000000000000058D
       mov       rcx,rsi
       mov       rdx,7FF7EC788938
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       mov       ecx,ebp
       call      qword ptr [1318]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],48
       jle       short 00000000000005B7
       mov       r11,[rdi+48]
       test      r11,r11
       je        short 00000000000005B7
       jmp       short 00000000000005CC
       mov       rcx,rsi
       mov       rdx,7FF7EC788948
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       call      qword ptr [1108]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],50
       jle       short 00000000000005F4
       mov       r11,[rdi+50]
       test      r11,r11
       je        short 00000000000005F4
       jmp       short 0000000000000609
       mov       rcx,rsi
       mov       rdx,7FF7EC788A60
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       mov       ecx,[rsp+0D0]
       call      qword ptr [1318]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],58
       jle       short 0000000000000638
       mov       r11,[rdi+58]
       test      r11,r11
       je        short 0000000000000638
       jmp       short 000000000000064D
       mov       rcx,rsi
       mov       rdx,7FF7EC788A70
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       call      qword ptr [1228]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],60
       jle       short 0000000000000675
       mov       r11,[rdi+60]
       test      r11,r11
       je        short 0000000000000675
       jmp       short 000000000000068A
       mov       rcx,rsi
       mov       rdx,7FF7EC788A80
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       mov       ecx,[rsp+0D8]
       call      qword ptr [1318]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],68
       jle       short 00000000000006B9
       mov       r11,[rdi+68]
       test      r11,r11
       je        short 00000000000006B9
       jmp       short 00000000000006CE
       mov       rcx,rsi
       mov       rdx,7FF7EC788A90
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       mov       ecx,[rsp+0E0]
       call      qword ptr [1198]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],70
       jle       short 00000000000006FD
       mov       r11,[rdi+70]
       test      r11,r11
       je        short 00000000000006FD
       jmp       short 0000000000000712
       mov       rcx,rsi
       mov       rdx,7FF7EC788AA0
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       mov       ecx,[rsp+0E8]
       call      qword ptr [1318]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],78
       jle       short 0000000000000741
       mov       r11,[rdi+78]
       test      r11,r11
       je        short 0000000000000741
       jmp       short 0000000000000756
       mov       rcx,rsi
       mov       rdx,7FF7EC788AB0
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.CreatePerson05()
; 			var person = RandomData.GeneratePersonRecordCollection(count: 1, addressCount: 1).First();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(person);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFF0],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,1
       mov       edx,1
       mov       r8d,0F
       mov       r9d,19
       call      000000000000E3D8
       mov       rdx,rax
       lea       r8,[rbp+0FFF0]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      000000000000DBF8
       mov       rdx,rax
       cmp       byte ptr [rbp+0FFF0],0
       je        short 00000000000033D5
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       call      000000000000B010
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
       call      000000000000B030
       int       3
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0C8
       vzeroupper
       xor       eax,eax
       mov       [rsp+0B0],rax
       mov       [rsp+0B8],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+130]
       mov       r15d,[rsp+138]
       mov       r12d,[rsp+140]
       mov       r13d,[rsp+148]
       test      esi,esi
       jle       short 00000000000056C4
       cmp       esi,7FFFFFFF
       setle     cl
       movzx     ecx,cl
       jmp       short 00000000000056C6
       xor       ecx,ecx
       test      ecx,ecx
       jne       short 00000000000056F2
       call      00000000000015C8
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF82F1DF290
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000004F8
       int       3
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       [rsp+48],rax
       mov       rcx,7FF82EFC4928
       mov       edx,22
       call      000000000000CB10
       mov       rdx,1BF6A472F38
       mov       rdx,[rdx]
       mov       rax,[rsp+48]
       lea       rcx,[rax+8]
       call      000000000000AEB0
       mov       rax,[rsp+60]
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      000000000000AEB0
       mov       rax,[rsp+60]
       mov       [rsp+70],rax
       xor       edx,edx
       mov       [rsp+0C4],edx
       test      esi,esi
       jle       near ptr 0000000000005A7B
       call      000000000000E380
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      000000000000B2D0
       mov       [rsp+50],rax
       call      0000000000001A08
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      000000000000E728
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      000000000000AEB0
       call      000000000000D800
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      000000000000E118
       mov       ecx,1
       mov       edx,4B
       call      000000000000E3A0
       imul      ecx,eax,16D
       jo        near ptr 0000000000005A94
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rdx,46DC5D638865
       cmp       rcx,rdx
       jg        near ptr 0000000000005A99
       mov       rdx,0B923A29C779B
       cmp       rcx,rdx
       jl        near ptr 0000000000005A99
       imul      rax,rcx,2710
       mov       [rsp+88],rax
       mov       rcx,[rsp+0B8]
       mov       edx,[rsp+0B0]
       movsx     rdx,dx
       movsxd    rdx,edx
       imul      rdx,3C
       mov       r8,0D6BF94D5E5
       cmp       rdx,r8
       jg        near ptr 0000000000005AD3
       mov       r8,0FF29406B2A1B
       cmp       rdx,r8
       jl        near ptr 0000000000005AD3
       imul      rdx,989680
       call      000000000000D980
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr 0000000000005AC5
       mov       rcx,0FFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2875F4373FFF
       cmp       rcx,r8
       ja        near ptr 0000000000005ACB
       mov       r8,0
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr 0000000000005AD3
       mov       r8,0FF29406B2A1B
       cmp       rcx,r8
       jl        near ptr 0000000000005AD3
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+90],xmm0
       lea       rcx,[rsp+90]
       call      000000000000DEE0
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      000000000000E708
       mov       ecx,ebx
       call      000000000000E430
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      000000000000E738
       call      000000000000E3E0
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      000000000000E748
       mov       ecx,ebp
       call      000000000000E430
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      000000000000E768
       call      000000000000E3E0
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      000000000000E718
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      000000000000E340
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      000000000000AEB0
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FF82EEC0308
       call      qword ptr [308]
       test      eax,eax
       jne       near ptr 0000000000005AD9
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FF82EEC0310
       call      qword ptr [310]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FF82EEC0318
       call      qword ptr [318]
       mov       edx,[rsp+0C4]
       add       edx,1
       jo        short 0000000000005A94
       cmp       edx,esi
       mov       [rsp+0C4],edx
       jl        near ptr 0000000000005777
       mov       rax,[rsp+70]
       add       rsp,0C8
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
       call      000000000000DB00
       int       3
       xor       ecx,ecx
       call      000000000000DB18
       int       3
       call      0000000000009608
       int       3
       mov       ecx,6
       call      00000000000096B8
       int       3
; Total bytes of code 1156
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp+0FFB0],rax
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr 000000000000312A
       mov       r14,[rsi+10]
       mov       rcx,r14
       mov       r15,[rcx+8]
       cmp       r15,38
       jle       near ptr 0000000000002FB8
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr 0000000000002FB8
       mov       rdx,rdi
       call      0000000000007438
       mov       r12,rax
       test      r12,r12
       jne       short 0000000000002F83
       mov       rcx,r14
       cmp       r15,40
       jle       near ptr 000000000000301C
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        near ptr 000000000000301C
       mov       rdx,rdi
       call      0000000000007438
       mov       r13,rax
       test      r13,r13
       je        near ptr 000000000000306A
       cmp       r15,58
       jle       near ptr 0000000000003036
       mov       r11,[r14+58]
       test      r11,r11
       je        near ptr 0000000000003036
       mov       rcx,r13
       call      qword ptr [r11]
       test      eax,eax
       jg        near ptr 0000000000003000
       mov       byte ptr [rbx],0
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       mov       rcx,r14
       cmp       r15,68
       jle       near ptr 0000000000003050
       mov       r11,[rcx+68]
       test      r11,r11
       je        near ptr 0000000000003050
       mov       rcx,r12
       mov       rdx,rbx
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       mov       rcx,rsi
       mov       rdx,7FF82F3E4B10
       call      0000000000004920
       mov       rcx,rax
       jmp       near ptr 0000000000002F0A
       mov       rcx,rsi
       mov       rdx,7FF82F3E5040
       call      0000000000004920
       mov       rcx,r13
       mov       r11,rax
       xor       edx,edx
       call      qword ptr [rax]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],60
       jle       short 0000000000002FD2
       mov       r11,[rcx+60]
       test      r11,r11
       je        short 0000000000002FD2
       mov       rax,r11
       jmp       short 0000000000002FE4
       mov       rcx,rsi
       mov       rdx,7FF82F3E4D00
       call      0000000000004920
       mov       rcx,rax
       jmp       near ptr 0000000000002F34
       mov       rcx,rsi
       mov       rdx,7FF82F3E5028
       call      0000000000004920
       mov       r11,rax
       jmp       near ptr 0000000000002F5F
       mov       rcx,rsi
       mov       rdx,7FF82F3E5058
       call      0000000000004920
       mov       r11,rax
       jmp       near ptr 0000000000002F9D
       mov       rcx,r14
       cmp       r15,48
       jle       short 00000000000030DC
       mov       r11,[rcx+48]
       test      r11,r11
       je        short 00000000000030DC
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,rax
       mov       r11,7FF82EEC0518
       call      qword ptr [518]
       test      eax,eax
       jne       short 00000000000030AC
       jmp       short 00000000000030F3
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       [rbp+0FFB0],rax
       jmp       short 000000000000310C
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       short 00000000000030C5
       mov       r11,[rcx+50]
       test      r11,r11
       je        short 00000000000030C5
       jmp       short 000000000000309F
       mov       rcx,rsi
       mov       rdx,7FF82F3E4F50
       call      0000000000004920
       mov       r11,rax
       jmp       short 000000000000309F
       mov       rcx,rsi
       mov       rdx,7FF82F3E4E30
       call      0000000000004920
       mov       r11,rax
       jmp       short 000000000000307C
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82EEC0520
       call      qword ptr [520]
       jmp       near ptr 0000000000002F6D
       mov       rcx,rsp
       call      0000000000003135
       nop
       mov       rax,[rbp+0FFB0]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       mov       ecx,10
       call      000000000000B010
       int       3
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
       lea       rbp,[rbp+80]
       mov       rcx,[rbp+0FFB8]
       test      rcx,rcx
       je        short 000000000000316E
       mov       r11,7FF82EEC0520
       call      qword ptr [520]
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
; Total bytes of code 720
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.CreatePerson05()
; 			var person = RandomData.GeneratePersonRecordCollection(count: 1, addressCount: 1).First();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(person);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFF0],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,1
       mov       edx,1
       mov       r8d,0F
       mov       r9d,19
       call      qword ptr [1210]
       mov       rdx,rax
       lea       r8,[rbp+0FFF0]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      qword ptr [0DF48]
       mov       rdx,rax
       cmp       byte ptr [rbp+0FFF0],0
       je        short 0000000000002015
       mov       rcx,[rsi+20]
       lea       rcx,[rcx+10]
       call      0000000000000010
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
       call      qword ptr [0B7E0]
       int       3
; Total bytes of code 156
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       vzeroupper
       xor       eax,eax
       mov       [rsp+78],rax
       mov       [rsp+80],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       test      esi,esi
       jle       short 000000000000207A
       mov       ecx,1
       jmp       short 000000000000207C
       xor       ecx,ecx
       test      ecx,ecx
       je        near ptr 00000000000023AC
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       r15,rax
       mov       rdx,144D5C01FC0
       mov       rdx,[rdx]
       lea       rcx,[r15+8]
       call      0000000000000010
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      0000000000000010
       xor       r15d,r15d
       test      esi,esi
       jle       near ptr 0000000000002390
       call      qword ptr [1108]
       mov       r12,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      000000000000EFB0
       mov       r13,rax
       call      qword ptr [0B258]
       mov       [rsp+40],rax
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [1828]
       lea       rcx,[r13+38]
       mov       rdx,[rsp+40]
       call      0000000000000010
       call      qword ptr [3918]
       mov       rdx,rax
       lea       rcx,[rsp+78]
       mov       r8d,1
       call      qword ptr [0F768]
       mov       ecx,1
       mov       edx,4B
       call      qword ptr [1168]
       imul      ecx,eax,16D
       jo        near ptr 00000000000023A7
       movsxd    rcx,ecx
       mov       rdx,141DD76000
       imul      rcx,rdx
       mov       rdx,0CCCCCCCCCCCC
       cmp       rcx,rdx
       jg        near ptr 00000000000024BF
       mov       rdx,333333333334
       cmp       rcx,rdx
       jl        near ptr 00000000000024BF
       lea       r12,[rcx+rcx*4]
       add       r12,r12
       mov       rcx,[rsp+80]
       mov       edx,[rsp+78]
       movsx     rdx,dx
       movsxd    rdx,edx
       imul      rdx,3C
       mov       rax,0D6BF94D5E5
       cmp       rdx,rax
       jg        near ptr 00000000000024BF
       mov       rax,0FF29406B2A1B
       cmp       rdx,rax
       jl        near ptr 00000000000024BF
       imul      rdx,989680
       call      qword ptr [3450]
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr 00000000000024AF
       mov       rcx,0FFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,r12
       mov       r8,2875F4373FFF
       cmp       rcx,r8
       ja        near ptr 00000000000024B6
       mov       r8,0
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+78]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr 00000000000024BF
       mov       r8,0FF29406B2A1B
       cmp       rcx,r8
       jl        near ptr 00000000000024BF
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+58],xmm0
       lea       rcx,[rsp+58]
       call      qword ptr [0F048]
       vmovupd   xmm0,[rsp+58]
       vmovupd   [rsp+68],xmm0
       vmovupd   xmm0,[rsp+68]
       vmovupd   [rsp+48],xmm0
       mov       rcx,r13
       lea       rdx,[rsp+48]
       call      qword ptr [17C8]
       mov       ecx,ebx
       call      qword ptr [1318]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [1858]
       call      qword ptr [1228]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [1888]
       mov       ecx,ebp
       call      qword ptr [1318]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [18E8]
       call      qword ptr [1228]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [17F8]
       mov       r12d,[rsp+108]
       mov       [rsp+20],r12d
       mov       eax,[rsp+110]
       mov       [rsp+28],eax
       mov       r10d,[rsp+118]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,[rsp+0F0]
       mov       r8d,[rsp+0F8]
       mov       r9d,[rsp+100]
       call      qword ptr [1048]
       lea       rcx,[r13+30]
       mov       rdx,rax
       call      0000000000000010
       mov       rcx,[r14+8]
       mov       r11,7FF7EC1B0590
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr 00000000000024C6
       mov       rcx,[r14+8]
       mov       r11,7FF7EC1B0598
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r13
       mov       r11,7FF7EC1B05A0
       call      qword ptr [r11]
       add       r15d,1
       jo        short 00000000000023A7
       cmp       r15d,esi
       mov       [rsp+108],r12d
       jl        near ptr 00000000000020D5
       mov       rax,r14
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
       call      0000000000002090
       call      qword ptr [9B10]
       mov       rsi,rax
       mov       rax,144D1C00720
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 0000000000002466
       call      qword ptr [9C48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF7EC770A30
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF7EC770A30
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
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [9888]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [9D08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [3030]
       mov       rcx,rbx
       call      0000000000006AD0
       call      qword ptr [1180]
       int       3
       xor       ecx,ecx
       call      qword ptr [11E0]
       int       3
       call      qword ptr [7228]
       int       3
       mov       ecx,7
       call      qword ptr [7498]
       int       3
; Total bytes of code 1170
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFB8],rax
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr 0000000000001D82
       mov       r14,[rsi+10]
       mov       rcx,r14
       mov       r15,[rcx+8]
       cmp       r15,38
       jle       short 0000000000001BC6
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short 0000000000001BC6
       mov       rdx,rdi
       call      qword ptr [5810]
       mov       r12,rax
       test      r12,r12
       je        short 0000000000001BF4
       cmp       r15,68
       jle       short 0000000000001BDD
       mov       r11,[r14+68]
       test      r11,r11
       je        short 0000000000001BDD
       mov       rcx,r12
       mov       rdx,rbx
       call      qword ptr [r11]
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       mov       rcx,rsi
       mov       rdx,7FF7EC85B060
       call      0000000000000CA0
       mov       rcx,rax
       jmp       short 0000000000001B8D
       mov       rcx,rsi
       mov       rdx,7FF7EC85B5A8
       call      0000000000000CA0
       mov       r11,rax
       jmp       short 0000000000001BAD
       mov       rcx,r14
       cmp       r15,40
       jle       near ptr 0000000000001C7E
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short 0000000000001C7E
       mov       rdx,rdi
       call      qword ptr [5810]
       mov       r12,rax
       test      r12,r12
       je        near ptr 0000000000001CAF
       mov       rcx,r14
       cmp       r15,58
       jle       short 0000000000001C98
       mov       r11,[rcx+58]
       test      r11,r11
       je        short 0000000000001C98
       mov       rcx,r12
       call      qword ptr [r11]
       test      eax,eax
       jg        short 0000000000001C4F
       mov       byte ptr [rbx],0
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],60
       jle       short 0000000000001CBA
       mov       r11,[rcx+60]
       test      r11,r11
       je        short 0000000000001CBA
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [r11]
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       mov       rcx,rsi
       mov       rdx,7FF7EC85B250
       call      0000000000000CA0
       mov       rcx,rax
       jmp       near ptr 0000000000001C0A
       mov       rcx,rsi
       mov       rdx,7FF7EC85B578
       call      0000000000000CA0
       mov       r11,rax
       jmp       short 0000000000001C31
       cmp       r15,48
       jle       short 0000000000001CD1
       jmp       near ptr 0000000000001D42
       mov       rcx,rsi
       mov       rdx,7FF7EC85B590
       call      0000000000000CA0
       mov       r11,rax
       jmp       short 0000000000001C66
       mov       rcx,rsi
       mov       rdx,7FF7EC85B380
       call      0000000000000CA0
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FF7EC1B0568
       call      qword ptr [r11]
       test      eax,eax
       jne       short 0000000000001D12
       jmp       short 0000000000001D50
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       jmp       short 0000000000001D66
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       short 0000000000001D2B
       mov       r11,[rcx+50]
       test      r11,r11
       je        short 0000000000001D2B
       jmp       short 0000000000001D05
       mov       rcx,rsi
       mov       rdx,7FF7EC85B4A0
       call      0000000000000CA0
       mov       r11,rax
       jmp       short 0000000000001D05
       mov       rcx,[r14+48]
       test      rcx,rcx
       je        short 0000000000001CD1
       mov       rax,rcx
       jmp       short 0000000000001CE3
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FF7EC1B0570
       call      qword ptr [r11]
       jmp       near ptr 0000000000001C3B
       mov       rcx,rsp
       call      0000000000001D8E
       nop
       mov       rax,[rbp+0FFB8]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       mov       ecx,10
       call      qword ptr [0B780]
       int       3
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
       lea       rbp,[rbp+70]
       mov       rcx,[rbp+0FFC0]
       test      rcx,rcx
       je        short 0000000000001DBF
       mov       r11,7FF7EC1B0570
       call      qword ptr [r11]
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
; Total bytes of code 655
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.PropertiesToString01()
; 			var person = RandomData.GenerateRefPerson<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(person.PropertiesToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       call      000000000000E470
       mov       rcx,rax
       mov       rsi,[rsi+20]
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       r9,143400D2D28
       mov       r9,[r9]
       mov       rdx,143400C3020
       mov       rdx,[rdx]
       mov       r8d,3A
       call      0000000000009168
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,48
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 160
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
       je        short 000000000000CD09
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       jmp       short 000000000000CD1B
       mov       rdx,7FF82F33F2A8
       call      0000000000004920
       mov       rcx,rax
       call      000000000000B448
       mov       rbp,rax
       call      0000000000001A08
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EEB0610
       call      qword ptr [610]
       mov       ecx,esi
       call      000000000000E430
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EEB0618
       call      qword ptr [618]
       mov       ecx,esi
       call      000000000000E430
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EEB0620
       call      qword ptr [620]
       call      000000000000D800
       mov       rdx,rax
       lea       rcx,[rsp+50]
       mov       r8d,1
       call      000000000000E118
       mov       ecx,1
       mov       edx,4B
       call      000000000000E3A0
       imul      ecx,eax,16D
       jo        near ptr 000000000000CFCD
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rax,46DC5D638865
       cmp       rcx,rax
       jg        near ptr 000000000000CFD2
       mov       rax,0B923A29C779B
       cmp       rcx,rax
       jl        near ptr 000000000000CFD2
       imul      rsi,rcx,2710
       lea       rcx,[rsp+50]
       call      000000000000DF30
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rax
       sub       rdx,rsi
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr 000000000000CFFE
       mov       rcx,0
       and       rcx,rax
       or        rdx,rcx
       mov       ecx,[rsp+50]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr 000000000000D006
       mov       r8,0FF29406B2A1B
       cmp       rcx,r8
       jl        near ptr 000000000000D006
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+30],xmm0
       lea       rcx,[rsp+30]
       call      000000000000DEE0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rcx,rbp
       lea       rdx,[rsp+20]
       mov       r11,7FF82EEB0628
       call      qword ptr [628]
       call      000000000000E3E0
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EEB0630
       call      qword ptr [630]
       mov       ecx,edi
       call      000000000000E430
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EEB0638
       call      qword ptr [638]
       mov       ecx,ebx
       call      000000000000E430
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EEB0640
       call      qword ptr [640]
       call      000000000000E380
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EEB0648
       call      qword ptr [648]
       mov       ecx,[rsp+0B0]
       call      000000000000E430
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EEB0650
       call      qword ptr [650]
       call      000000000000E3E0
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EEB0658
       call      qword ptr [658]
       mov       ecx,[rsp+0B8]
       call      000000000000E430
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EEB0660
       call      qword ptr [660]
       mov       ecx,[rsp+0C0]
       call      000000000000E3B0
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EEB0668
       call      qword ptr [668]
       mov       ecx,[rsp+0C8]
       call      000000000000E430
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF82EEB0670
       call      qword ptr [670]
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
       call      000000000000DB18
       int       3
       call      0000000000009608
       int       3
; Total bytes of code 828
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbp,rdx
       mov       ebx,r8d
       mov       rdi,r9
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass12_0
       call      000000000000B2D0
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      000000000000AEB0
       mov       [r14+10],bx
       test      rsi,rsi
       jne       short 0000000000001496
       mov       rax,143400C3020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
       mov       rcx,rsi
       call      000000000000F570
       mov       rcx,rax
       xor       edx,edx
       call      0000000000001A28
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      0000000000004F40
       mov       rcx,rax
       xor       edx,edx
       call      0000000000001A28
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,4
       call      00000000000089F8
       test      eax,eax
       je        short 00000000000014E8
       mov       r8,143500C2920
       mov       rdi,[r8]
       jmp       short 00000000000014FC
       cmp       byte ptr [rsp+78],0
       jne       short 00000000000014FC
       mov       r8,143400C3020
       mov       rdi,[r8]
       mov       ebx,[rsp+70]
       movzx     r8d,bl
       mov       rcx,rsi
       mov       rdx,rdi
       call      0000000000009160
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      000000000000AEB0
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass12_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rsi
       mov       r8,rbp
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate(System.Collections.Generic.IEnumerable`1<!!0>, !!1, System.Func`3<!!1,!!0,!!1>)
       call      000000000000A278
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      0000000000008A58
       test      eax,eax
       jne       short 000000000000157C
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr 00000000000082D8
; Total bytes of code 344
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.PropertiesToString01()
; 			var person = RandomData.GenerateRefPerson<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(person.PropertiesToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       call      qword ptr [13C0]
       mov       rcx,rax
       mov       rsi,[rsi+20]
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       r9,247B98005E0
       mov       r9,[r9]
       mov       rdx,247BD802028
       mov       rdx,[rdx]
       mov       r8d,3A
       call      qword ptr [1CC0]
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,48
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 160
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
       je        short 000000000000B839
       mov       rcx,[r14+10]
       jmp       short 000000000000B84E
       mov       rcx,rsi
       mov       rdx,7FF7EC7887F8
       call      0000000000000CA0
       mov       rcx,rax
       call      qword ptr [0B318]
       mov       r15,rax
       call      qword ptr [0B258]
       mov       r12,rax
       cmp       qword ptr [r14+18],0
       je        short 000000000000B86D
       mov       r11,[r14+18]
       jmp       short 000000000000B882
       mov       rcx,rsi
       mov       rdx,7FF7EC788818
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,r12
       call      qword ptr [r11]
       mov       ecx,edi
       call      qword ptr [1318]
       mov       r12,rax
       cmp       qword ptr [r14+20],0
       je        short 000000000000B8A3
       mov       r11,[r14+20]
       jmp       short 000000000000B8B8
       mov       rcx,rsi
       mov       rdx,7FF7EC788828
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,r12
       call      qword ptr [r11]
       mov       ecx,edi
       call      qword ptr [1318]
       mov       rdi,rax
       cmp       qword ptr [r14+28],0
       je        short 000000000000B8D9
       mov       r11,[r14+28]
       jmp       short 000000000000B8EE
       mov       rcx,rsi
       mov       rdx,7FF7EC788838
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
       call      qword ptr [1168]
       imul      ecx,eax,16D
       jo        near ptr 000000000000BC81
       movsxd    rcx,ecx
       mov       rax,141DD76000
       imul      rcx,rax
       mov       rax,0CCCCCCCCCCCC
       cmp       rcx,rax
       jg        near ptr 000000000000BC86
       mov       rax,333333333334
       cmp       rcx,rax
       jl        near ptr 000000000000BC86
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
       jg        near ptr 000000000000BC86
       mov       r8,0FF29406B2A1B
       cmp       rcx,r8
       jl        near ptr 000000000000BC86
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+30],xmm0
       lea       rcx,[rsp+30]
       call      qword ptr [0F048]
       mov       rcx,[rsi+10]
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+48],xmm0
       cmp       qword ptr [rcx+8],30
       jle       short 000000000000B9FF
       mov       rax,[rcx+30]
       test      rax,rax
       je        short 000000000000B9FF
       jmp       short 000000000000BA11
       mov       rcx,rsi
       mov       rdx,7FF7EC788918
       call      0000000000000CA0
       mov       r11,rax
       vmovupd   xmm0,[rsp+48]
       vmovupd   [rsp+20],xmm0
       mov       rcx,r15
       lea       rdx,[rsp+20]
       call      qword ptr [rax]
       mov       rdi,[rsi+10]
       call      qword ptr [1228]
       mov       r14,rax
       cmp       qword ptr [rdi+8],38
       jle       short 000000000000BA49
       mov       r11,[rdi+38]
       test      r11,r11
       je        short 000000000000BA49
       jmp       short 000000000000BA5E
       mov       rcx,rsi
       mov       rdx,7FF7EC788928
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       mov       ecx,ebx
       call      qword ptr [1318]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],40
       jle       short 000000000000BA88
       mov       r11,[rdi+40]
       test      r11,r11
       je        short 000000000000BA88
       jmp       short 000000000000BA9D
       mov       rcx,rsi
       mov       rdx,7FF7EC788938
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       mov       ecx,ebp
       call      qword ptr [1318]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],48
       jle       short 000000000000BAC7
       mov       r11,[rdi+48]
       test      r11,r11
       je        short 000000000000BAC7
       jmp       short 000000000000BADC
       mov       rcx,rsi
       mov       rdx,7FF7EC788948
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       call      qword ptr [1108]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],50
       jle       short 000000000000BB04
       mov       r11,[rdi+50]
       test      r11,r11
       je        short 000000000000BB04
       jmp       short 000000000000BB19
       mov       rcx,rsi
       mov       rdx,7FF7EC788A60
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       mov       ecx,[rsp+0D0]
       call      qword ptr [1318]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],58
       jle       short 000000000000BB48
       mov       r11,[rdi+58]
       test      r11,r11
       je        short 000000000000BB48
       jmp       short 000000000000BB5D
       mov       rcx,rsi
       mov       rdx,7FF7EC788A70
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       call      qword ptr [1228]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],60
       jle       short 000000000000BB85
       mov       r11,[rdi+60]
       test      r11,r11
       je        short 000000000000BB85
       jmp       short 000000000000BB9A
       mov       rcx,rsi
       mov       rdx,7FF7EC788A80
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       mov       ecx,[rsp+0D8]
       call      qword ptr [1318]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],68
       jle       short 000000000000BBC9
       mov       r11,[rdi+68]
       test      r11,r11
       je        short 000000000000BBC9
       jmp       short 000000000000BBDE
       mov       rcx,rsi
       mov       rdx,7FF7EC788A90
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       mov       ecx,[rsp+0E0]
       call      qword ptr [1198]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],70
       jle       short 000000000000BC0D
       mov       r11,[rdi+70]
       test      r11,r11
       je        short 000000000000BC0D
       jmp       short 000000000000BC22
       mov       rcx,rsi
       mov       rdx,7FF7EC788AA0
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       rdi,[rsi+10]
       mov       ecx,[rsp+0E8]
       call      qword ptr [1318]
       mov       rbx,rax
       cmp       qword ptr [rdi+8],78
       jle       short 000000000000BC51
       mov       r11,[rdi+78]
       test      r11,r11
       je        short 000000000000BC51
       jmp       short 000000000000BC66
       mov       rcx,rsi
       mov       rdx,7FF7EC788AB0
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
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbp,rdx
       mov       ebx,r8d
       mov       rdi,r9
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass12_0
       call      000000000000EFB0
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      0000000000000010
       mov       [r14+10],bx
       test      rsi,rsi
       jne       short 000000000000FCE6
       mov       rax,247BD802028
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
       mov       rcx,rsi
       call      00000000000053F0
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7918]
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      0000000000003330
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7918]
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,4
       call      qword ptr [0B378]
       test      eax,eax
       je        short 000000000000FD3B
       mov       r8,247B98021E8
       mov       rdi,[r8]
       jmp       short 000000000000FD4F
       cmp       byte ptr [rsp+78],0
       jne       short 000000000000FD4F
       mov       r8,247BD802028
       mov       rdi,[r8]
       mov       ebx,[rsp+70]
       movzx     r8d,bl
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [1CA8]
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      0000000000000010
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass12_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rsi
       mov       r8,rbp
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate(System.Collections.Generic.IEnumerable`1<!!0>, !!1, System.Func`3<!!1,!!0,!!1>)
       call      qword ptr [1DE0]
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [0B498]
       test      eax,eax
       jne       short 000000000000FDD2
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [0D030]
; Total bytes of code 351
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.PropertiesToString02()
; 			var person = RandomData.GeneratePersonRecordCollection(count: 1, addressCount: 1).First();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(person.PropertiesToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFF0],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,1
       mov       edx,1
       mov       r8d,0F
       mov       r9d,19
       call      000000000000E3D8
       mov       rdx,rax
       lea       r8,[rbp+0FFF0]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      000000000000DBF8
       mov       rcx,rax
       cmp       byte ptr [rbp+0FFF0],0
       je        short 0000000000002B7D
       mov       rsi,[rsi+20]
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       r9,1D1021B15D8
       mov       r9,[r9]
       mov       rdx,1D1121B3020
       mov       rdx,[rdx]
       mov       r8d,3A
       call      0000000000009168
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
       call      000000000000B030
       int       3
; Total bytes of code 211
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0C8
       vzeroupper
       xor       eax,eax
       mov       [rsp+0B0],rax
       mov       [rsp+0B8],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+130]
       mov       r15d,[rsp+138]
       mov       r12d,[rsp+140]
       mov       r13d,[rsp+148]
       test      esi,esi
       jle       short 00000000000056C4
       cmp       esi,7FFFFFFF
       setle     cl
       movzx     ecx,cl
       jmp       short 00000000000056C6
       xor       ecx,ecx
       test      ecx,ecx
       jne       short 00000000000056F2
       call      00000000000015C8
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF82F1BF290
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000004F8
       int       3
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       [rsp+48],rax
       mov       rcx,7FF82EFA4928
       mov       edx,22
       call      000000000000CB10
       mov       rdx,1D1121B2F38
       mov       rdx,[rdx]
       mov       rax,[rsp+48]
       lea       rcx,[rax+8]
       call      000000000000AEB0
       mov       rax,[rsp+60]
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      000000000000AEB0
       mov       rax,[rsp+60]
       mov       [rsp+70],rax
       xor       edx,edx
       mov       [rsp+0C4],edx
       test      esi,esi
       jle       near ptr 0000000000005A7B
       call      000000000000E380
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      000000000000B2D0
       mov       [rsp+50],rax
       call      0000000000001A08
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      000000000000E728
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      000000000000AEB0
       call      000000000000D800
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      000000000000E118
       mov       ecx,1
       mov       edx,4B
       call      000000000000E3A0
       imul      ecx,eax,16D
       jo        near ptr 0000000000005A94
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rdx,46DC5D638865
       cmp       rcx,rdx
       jg        near ptr 0000000000005A99
       mov       rdx,0B923A29C779B
       cmp       rcx,rdx
       jl        near ptr 0000000000005A99
       imul      rax,rcx,2710
       mov       [rsp+88],rax
       mov       rcx,[rsp+0B8]
       mov       edx,[rsp+0B0]
       movsx     rdx,dx
       movsxd    rdx,edx
       imul      rdx,3C
       mov       r8,0D6BF94D5E5
       cmp       rdx,r8
       jg        near ptr 0000000000005AD3
       mov       r8,0FF29406B2A1B
       cmp       rdx,r8
       jl        near ptr 0000000000005AD3
       imul      rdx,989680
       call      000000000000D980
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr 0000000000005AC5
       mov       rcx,0FFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2875F4373FFF
       cmp       rcx,r8
       ja        near ptr 0000000000005ACB
       mov       r8,0
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr 0000000000005AD3
       mov       r8,0FF29406B2A1B
       cmp       rcx,r8
       jl        near ptr 0000000000005AD3
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+90],xmm0
       lea       rcx,[rsp+90]
       call      000000000000DEE0
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      000000000000E708
       mov       ecx,ebx
       call      000000000000E430
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      000000000000E738
       call      000000000000E3E0
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      000000000000E748
       mov       ecx,ebp
       call      000000000000E430
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      000000000000E768
       call      000000000000E3E0
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      000000000000E718
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      000000000000E340
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      000000000000AEB0
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FF82EEA0308
       call      qword ptr [308]
       test      eax,eax
       jne       near ptr 0000000000005AD9
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FF82EEA0310
       call      qword ptr [310]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FF82EEA0318
       call      qword ptr [318]
       mov       edx,[rsp+0C4]
       add       edx,1
       jo        short 0000000000005A94
       cmp       edx,esi
       mov       [rsp+0C4],edx
       jl        near ptr 0000000000005777
       mov       rax,[rsp+70]
       add       rsp,0C8
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
       call      000000000000DB00
       int       3
       xor       ecx,ecx
       call      000000000000DB18
       int       3
       call      0000000000009608
       int       3
       mov       ecx,6
       call      00000000000096B8
       int       3
; Total bytes of code 1156
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp+0FFB0],rax
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr 000000000000E05A
       mov       r14,[rsi+10]
       mov       rcx,r14
       mov       r15,[rcx+8]
       cmp       r15,38
       jle       near ptr 000000000000DEE8
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr 000000000000DEE8
       mov       rdx,rdi
       call      0000000000007438
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000DEB3
       mov       rcx,r14
       cmp       r15,40
       jle       near ptr 000000000000DF4C
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        near ptr 000000000000DF4C
       mov       rdx,rdi
       call      0000000000007438
       mov       r13,rax
       test      r13,r13
       je        near ptr 000000000000DF9A
       cmp       r15,58
       jle       near ptr 000000000000DF66
       mov       r11,[r14+58]
       test      r11,r11
       je        near ptr 000000000000DF66
       mov       rcx,r13
       call      qword ptr [r11]
       test      eax,eax
       jg        near ptr 000000000000DF30
       mov       byte ptr [rbx],0
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       mov       rcx,r14
       cmp       r15,68
       jle       near ptr 000000000000DF80
       mov       r11,[rcx+68]
       test      r11,r11
       je        near ptr 000000000000DF80
       mov       rcx,r12
       mov       rdx,rbx
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       mov       rcx,rsi
       mov       rdx,7FF82F3E08A8
       call      0000000000004920
       mov       rcx,rax
       jmp       near ptr 000000000000DE3A
       mov       rcx,rsi
       mov       rdx,7FF82F3E0DD8
       call      0000000000004920
       mov       rcx,r13
       mov       r11,rax
       xor       edx,edx
       call      qword ptr [rax]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],60
       jle       short 000000000000DF02
       mov       r11,[rcx+60]
       test      r11,r11
       je        short 000000000000DF02
       mov       rax,r11
       jmp       short 000000000000DF14
       mov       rcx,rsi
       mov       rdx,7FF82F3E0A98
       call      0000000000004920
       mov       rcx,rax
       jmp       near ptr 000000000000DE64
       mov       rcx,rsi
       mov       rdx,7FF82F3E0DC0
       call      0000000000004920
       mov       r11,rax
       jmp       near ptr 000000000000DE8F
       mov       rcx,rsi
       mov       rdx,7FF82F3E0DF0
       call      0000000000004920
       mov       r11,rax
       jmp       near ptr 000000000000DECD
       mov       rcx,r14
       cmp       r15,48
       jle       short 000000000000E00C
       mov       r11,[rcx+48]
       test      r11,r11
       je        short 000000000000E00C
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,rax
       mov       r11,7FF82EEA0620
       call      qword ptr [620]
       test      eax,eax
       jne       short 000000000000DFDC
       jmp       short 000000000000E023
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       [rbp+0FFB0],rax
       jmp       short 000000000000E03C
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       short 000000000000DFF5
       mov       r11,[rcx+50]
       test      r11,r11
       je        short 000000000000DFF5
       jmp       short 000000000000DFCF
       mov       rcx,rsi
       mov       rdx,7FF82F3E0CE8
       call      0000000000004920
       mov       r11,rax
       jmp       short 000000000000DFCF
       mov       rcx,rsi
       mov       rdx,7FF82F3E0BC8
       call      0000000000004920
       mov       r11,rax
       jmp       short 000000000000DFAC
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82EEA0628
       call      qword ptr [628]
       jmp       near ptr 000000000000DE9D
       mov       rcx,rsp
       call      000000000000E065
       nop
       mov       rax,[rbp+0FFB0]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       mov       ecx,10
       call      000000000000B010
       int       3
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
       lea       rbp,[rbp+80]
       mov       rcx,[rbp+0FFB8]
       test      rcx,rcx
       je        short 000000000000E09E
       mov       r11,7FF82EEA0628
       call      qword ptr [628]
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
; Total bytes of code 720
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbp,rdx
       mov       ebx,r8d
       mov       rdi,r9
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass12_0
       call      000000000000B2D0
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      000000000000AEB0
       mov       [r14+10],bx
       test      rsi,rsi
       jne       short 000000000000E286
       mov       rax,1D1121B3020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
       mov       rcx,rsi
       call      000000000000F570
       mov       rcx,rax
       xor       edx,edx
       call      0000000000001A28
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      0000000000004F40
       mov       rcx,rax
       xor       edx,edx
       call      0000000000001A28
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,4
       call      00000000000089F8
       test      eax,eax
       je        short 000000000000E2D8
       mov       r8,1D1221B1908
       mov       rdi,[r8]
       jmp       short 000000000000E2EC
       cmp       byte ptr [rsp+78],0
       jne       short 000000000000E2EC
       mov       r8,1D1121B3020
       mov       rdi,[r8]
       mov       ebx,[rsp+70]
       movzx     r8d,bl
       mov       rcx,rsi
       mov       rdx,rdi
       call      0000000000009160
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      000000000000AEB0
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass12_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rsi
       mov       r8,rbp
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate(System.Collections.Generic.IEnumerable`1<!!0>, !!1, System.Func`3<!!1,!!0,!!1>)
       call      000000000000A298
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      0000000000008A58
       test      eax,eax
       jne       short 000000000000E36C
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr 00000000000082D8
; Total bytes of code 344
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.PropertiesToString02()
; 			var person = RandomData.GeneratePersonRecordCollection(count: 1, addressCount: 1).First();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(person.PropertiesToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFF0],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,1
       mov       edx,1
       mov       r8d,0F
       mov       r9d,19
       call      qword ptr [1210]
       mov       rdx,rax
       lea       r8,[rbp+0FFF0]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      qword ptr [0DF48]
       mov       rcx,rax
       cmp       byte ptr [rbp+0FFF0],0
       je        short 00000000000008DE
       mov       rsi,[rsi+20]
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       r9,22C6C809D98
       mov       r9,[r9]
       mov       rdx,22C6C802028
       mov       rdx,[rdx]
       mov       r8d,3A
       call      qword ptr [3120]
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
       call      qword ptr [0B7E0]
       int       3
; Total bytes of code 213
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       vzeroupper
       xor       eax,eax
       mov       [rsp+78],rax
       mov       [rsp+80],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       test      esi,esi
       jle       short 000000000000093A
       mov       ecx,1
       jmp       short 000000000000093C
       xor       ecx,ecx
       test      ecx,ecx
       je        near ptr 0000000000000C6C
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       r15,rax
       mov       rdx,22C6C801FC0
       mov       rdx,[rdx]
       lea       rcx,[r15+8]
       call      0000000000000010
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      0000000000000010
       xor       r15d,r15d
       test      esi,esi
       jle       near ptr 0000000000000C50
       call      qword ptr [1108]
       mov       r12,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      000000000000EFB0
       mov       r13,rax
       call      qword ptr [0B258]
       mov       [rsp+40],rax
       mov       rcx,r13
       mov       rdx,r12
       call      qword ptr [1828]
       lea       rcx,[r13+38]
       mov       rdx,[rsp+40]
       call      0000000000000010
       call      qword ptr [3918]
       mov       rdx,rax
       lea       rcx,[rsp+78]
       mov       r8d,1
       call      qword ptr [0F768]
       mov       ecx,1
       mov       edx,4B
       call      qword ptr [1168]
       imul      ecx,eax,16D
       jo        near ptr 0000000000000C67
       movsxd    rcx,ecx
       mov       rdx,141DD76000
       imul      rcx,rdx
       mov       rdx,0CCCCCCCCCCCC
       cmp       rcx,rdx
       jg        near ptr 0000000000000D7F
       mov       rdx,333333333334
       cmp       rcx,rdx
       jl        near ptr 0000000000000D7F
       lea       r12,[rcx+rcx*4]
       add       r12,r12
       mov       rcx,[rsp+80]
       mov       edx,[rsp+78]
       movsx     rdx,dx
       movsxd    rdx,edx
       imul      rdx,3C
       mov       rax,0D6BF94D5E5
       cmp       rdx,rax
       jg        near ptr 0000000000000D7F
       mov       rax,0FF29406B2A1B
       cmp       rdx,rax
       jl        near ptr 0000000000000D7F
       imul      rdx,989680
       call      qword ptr [3450]
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr 0000000000000D6F
       mov       rcx,0FFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,r12
       mov       r8,2875F4373FFF
       cmp       rcx,r8
       ja        near ptr 0000000000000D76
       mov       r8,0
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+78]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr 0000000000000D7F
       mov       r8,0FF29406B2A1B
       cmp       rcx,r8
       jl        near ptr 0000000000000D7F
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+58],xmm0
       lea       rcx,[rsp+58]
       call      qword ptr [0F048]
       vmovupd   xmm0,[rsp+58]
       vmovupd   [rsp+68],xmm0
       vmovupd   xmm0,[rsp+68]
       vmovupd   [rsp+48],xmm0
       mov       rcx,r13
       lea       rdx,[rsp+48]
       call      qword ptr [17C8]
       mov       ecx,ebx
       call      qword ptr [1318]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [1858]
       call      qword ptr [1228]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [1888]
       mov       ecx,ebp
       call      qword ptr [1318]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [18E8]
       call      qword ptr [1228]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [17F8]
       mov       r12d,[rsp+108]
       mov       [rsp+20],r12d
       mov       eax,[rsp+110]
       mov       [rsp+28],eax
       mov       r10d,[rsp+118]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,[rsp+0F0]
       mov       r8d,[rsp+0F8]
       mov       r9d,[rsp+100]
       call      qword ptr [1048]
       lea       rcx,[r13+30]
       mov       rdx,rax
       call      0000000000000010
       mov       rcx,[r14+8]
       mov       r11,7FF7EC1D06A8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr 0000000000000D86
       mov       rcx,[r14+8]
       mov       r11,7FF7EC1D06B0
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r13
       mov       r11,7FF7EC1D06B8
       call      qword ptr [r11]
       add       r15d,1
       jo        short 0000000000000C67
       cmp       r15d,esi
       mov       [rsp+108],r12d
       jl        near ptr 0000000000000995
       mov       rax,r14
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
       call      0000000000002090
       call      qword ptr [9B10]
       mov       rsi,rax
       mov       rax,22C6C809ED8
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 0000000000000D26
       call      qword ptr [9C48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF7EC790A30
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF7EC790A30
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
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [9888]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [9D08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [3030]
       mov       rcx,rbx
       call      0000000000006AD0
       call      qword ptr [1180]
       int       3
       xor       ecx,ecx
       call      qword ptr [11E0]
       int       3
       call      qword ptr [7228]
       int       3
       mov       ecx,7
       call      qword ptr [7498]
       int       3
; Total bytes of code 1170
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFB8],rax
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC8],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr 0000000000005142
       mov       r14,[rsi+10]
       mov       rcx,r14
       mov       r15,[rcx+8]
       cmp       r15,38
       jle       short 0000000000004F86
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short 0000000000004F86
       mov       rdx,rdi
       call      qword ptr [5810]
       mov       r12,rax
       test      r12,r12
       je        short 0000000000004FB4
       cmp       r15,68
       jle       short 0000000000004F9D
       mov       r11,[r14+68]
       test      r11,r11
       je        short 0000000000004F9D
       mov       rcx,r12
       mov       rdx,rbx
       call      qword ptr [r11]
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       mov       rcx,rsi
       mov       rdx,7FF7EC97B830
       call      0000000000000CA0
       mov       rcx,rax
       jmp       short 0000000000004F4D
       mov       rcx,rsi
       mov       rdx,7FF7EC97BD78
       call      0000000000000CA0
       mov       r11,rax
       jmp       short 0000000000004F6D
       mov       rcx,r14
       cmp       r15,40
       jle       near ptr 000000000000503E
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short 000000000000503E
       mov       rdx,rdi
       call      qword ptr [5810]
       mov       r12,rax
       test      r12,r12
       je        near ptr 000000000000506F
       mov       rcx,r14
       cmp       r15,58
       jle       short 0000000000005058
       mov       r11,[rcx+58]
       test      r11,r11
       je        short 0000000000005058
       mov       rcx,r12
       call      qword ptr [r11]
       test      eax,eax
       jg        short 000000000000500F
       mov       byte ptr [rbx],0
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],60
       jle       short 000000000000507A
       mov       r11,[rcx+60]
       test      r11,r11
       je        short 000000000000507A
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [r11]
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       mov       rcx,rsi
       mov       rdx,7FF7EC97BA20
       call      0000000000000CA0
       mov       rcx,rax
       jmp       near ptr 0000000000004FCA
       mov       rcx,rsi
       mov       rdx,7FF7EC97BD48
       call      0000000000000CA0
       mov       r11,rax
       jmp       short 0000000000004FF1
       cmp       r15,48
       jle       short 0000000000005091
       jmp       near ptr 0000000000005102
       mov       rcx,rsi
       mov       rdx,7FF7EC97BD60
       call      0000000000000CA0
       mov       r11,rax
       jmp       short 0000000000005026
       mov       rcx,rsi
       mov       rdx,7FF7EC97BB50
       call      0000000000000CA0
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FF7EC1D06C0
       call      qword ptr [r11]
       test      eax,eax
       jne       short 00000000000050D2
       jmp       short 0000000000005110
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       jmp       short 0000000000005126
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       short 00000000000050EB
       mov       r11,[rcx+50]
       test      r11,r11
       je        short 00000000000050EB
       jmp       short 00000000000050C5
       mov       rcx,rsi
       mov       rdx,7FF7EC97BC70
       call      0000000000000CA0
       mov       r11,rax
       jmp       short 00000000000050C5
       mov       rcx,[r14+48]
       test      rcx,rcx
       je        short 0000000000005091
       mov       rax,rcx
       jmp       short 00000000000050A3
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FF7EC1D06C8
       call      qword ptr [r11]
       jmp       near ptr 0000000000004FFB
       mov       rcx,rsp
       call      000000000000514E
       nop
       mov       rax,[rbp+0FFB8]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       mov       ecx,10
       call      qword ptr [0B780]
       int       3
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
       lea       rbp,[rbp+70]
       mov       rcx,[rbp+0FFC0]
       test      rcx,rcx
       je        short 000000000000517F
       mov       r11,7FF7EC1D06C8
       call      qword ptr [r11]
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
; Total bytes of code 655
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbp,rdx
       mov       ebx,r8d
       mov       rdi,r9
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass12_0
       call      000000000000EFB0
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      0000000000000010
       mov       [r14+10],bx
       test      rsi,rsi
       jne       short 0000000000005356
       mov       rax,22C6C802028
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
       mov       rcx,rsi
       call      00000000000053F0
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7918]
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      0000000000003330
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7918]
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,4
       call      qword ptr [0B378]
       test      eax,eax
       je        short 00000000000053AB
       mov       r8,22C6A808950
       mov       rdi,[r8]
       jmp       short 00000000000053BF
       cmp       byte ptr [rsp+78],0
       jne       short 00000000000053BF
       mov       r8,22C6C802028
       mov       rdi,[r8]
       mov       ebx,[rsp+70]
       movzx     r8d,bl
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [3108]
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      0000000000000010
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass12_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rsi
       mov       r8,rbp
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate(System.Collections.Generic.IEnumerable`1<!!0>, !!1, System.Func`3<!!1,!!0,!!1>)
       call      qword ptr [3240]
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [0B498]
       test      eax,eax
       jne       short 0000000000005442
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [0D030]
; Total bytes of code 351
```

