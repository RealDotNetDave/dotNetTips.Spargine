## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       r8,1E618482FF0
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      0000000000006928
       mov       rsi,[rsi+20]
       mov       rcx,1E61848C718
       mov       r8,[rcx]
       test      r8,r8
       jne       short 000000000000F02C
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rdi,rax
       mov       rdx,1E61848C710
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      000000000000AEB0
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rdi+18],rdx
       mov       rcx,1E61848C718
       mov       rdx,rdi
       call      000000000000B010
       mov       r8,rdi
       test      r8,r8
       jne       short 000000000000F035
       xor       edi,edi
       jmp       short 000000000000F049
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      0000000000001AE0
       mov       edi,eax
       mov       [rsi+54],dil
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 197
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000FB4F
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       je        near ptr 000000000000FB96
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short 000000000000F817
       jmp       short 000000000000F829
       mov       rdx,7FF82F4EBF48
       call      0000000000002740
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000007440
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000F851
       mov       rcx,r14
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr 000000000000FAB3
       jmp       near ptr 000000000000FAC5
       mov       rcx,r14
       mov       rax,[r15+88]
       test      rax,rax
       je        short 000000000000F862
       jmp       short 000000000000F871
       mov       rdx,7FF82F4EC660
       call      0000000000002740
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000F83C
       mov       rcx,rdi
       mov       rdx,r12
       call      0000000000006A60
       test      eax,eax
       je        short 000000000000F83C
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000FA9B
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000FBCF
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
       mov       rdx,7FF82F4EBFD8
       call      0000000000002740
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      0000000000006BA8
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000FA81
       test      rbp,rbp
       je        near ptr 000000000000F9D1
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr 000000000000F9D1
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000FBF7
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+80]
       test      r11,r11
       je        short 000000000000F967
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000F983
       mov       rdx,7FF82F4EBFF8
       call      0000000000002740
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000F9BE
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000FBF7
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000F91F
       jmp       near ptr 000000000000FA81
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr 000000000000FBF7
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000FBF7
       lea       ecx,[r12+0FFFF]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+80]
       test      r11,r11
       je        short 000000000000FA21
       mov       rax,[rsp+30]
       jmp       short 000000000000FA38
       mov       rdx,7FF82F4EBFF8
       call      0000000000002740
       mov       r11,rax
       mov       rax,[rsp+30]
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000FA73
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000FBF7
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000F9D1
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+68]
       test      r15,r15
       je        short 000000000000FAFF
       jmp       short 000000000000FB10
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000F89C
       mov       rdx,7FF82F4EBF88
       call      0000000000002740
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000006B88
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000FB3E
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+78]
       test      r12,r12
       je        near ptr 000000000000F8B9
       mov       rax,r12
       jmp       near ptr 000000000000F8C8
       mov       rdx,7FF82F4EBF48
       call      0000000000002740
       jmp       short 000000000000FB13
       mov       rax,r15
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      0000000000006A70
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+60],0
       je        short 000000000000FB6A
       mov       rcx,[r15+60]
       jmp       short 000000000000FB7C
       mov       rdx,7FF82F4EBEE0
       call      0000000000002740
       mov       rcx,rax
       call      0000000000007360
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       jne       near ptr 000000000000F7FF
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FF82F16BD88
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      0000000000007FA8
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       jmp       near ptr 000000000000F8A8
       call      000000000000F130
       int       3
; Total bytes of code 1085
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			                                           ^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      0000000000000538
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,0FFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,0
       or        rax,rdx
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,0
       or        rdx,rcx
       mov       rcx,0FFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[0EC18]
       vucomisd  xmm0,qword ptr [0EC20]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr 000000000000DAAA
       test      rdi,rdi
       je        near ptr 000000000000DAB5
       mov       r14,[rsi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short 000000000000D9E1
       jmp       short 000000000000D9F6
       mov       rcx,rsi
       mov       rdx,7FF82F4EA870
       call      0000000000004920
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
       mov       r11,7FF82EE80720
       call      qword ptr [720]
       test      eax,eax
       je        short 000000000000DA72
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000DA22
       jmp       short 000000000000DA37
       mov       rcx,rsi
       mov       rdx,7FF82F4EA948
       call      0000000000004920
       mov       r11,rax
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short 000000000000DA69
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82EE80720
       call      qword ptr [720]
       test      eax,eax
       jne       short 000000000000DA17
       jmp       short 000000000000DA72
       mov       dword ptr [rbp+0FFD4],1
       jmp       short 000000000000DA93
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82EE80728
       call      qword ptr [728]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       rcx,rsp
       call      000000000000DAC0
       nop
       mov       eax,[rbp+0FFD4]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       ecx,10
       call      000000000000B010
       int       3
       mov       ecx,0C
       call      000000000000B010
       int       3
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFC8]
       test      rcx,rcx
       je        short 000000000000DAF0
       mov       r11,7FF82EE80728
       call      qword ptr [728]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 348
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       r8,20029003C10
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [5708]
       mov       rsi,[rsi+20]
       mov       rdi,20029001F78
       mov       r8,[rdi]
       test      r8,r8
       jne       short 0000000000000977
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rbp,rax
       mov       rdx,20029001F70
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      0000000000000010
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbp+18],rdx
       mov       rcx,rdi
       mov       rdx,rbp
       call      0000000000000010
       mov       r8,rbp
       test      r8,r8
       jne       short 0000000000000980
       xor       edi,edi
       jmp       short 0000000000000995
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      qword ptr [74F8]
       mov       edi,eax
       mov       [rsi+54],dil
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 194
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000109F
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       je        near ptr 00000000000010E7
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short 0000000000000E37
       jmp       short 0000000000000E49
       mov       rdx,7FF82F1BF0B8
       call      00000000000087F0
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5828]
       mov       r12,rax
       test      r12,r12
       jne       short 0000000000000E72
       mov       rcx,r14
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr 0000000000000FEB
       jmp       near ptr 0000000000000FFD
       mov       rcx,r14
       mov       rax,[r15+88]
       test      rax,rax
       je        short 0000000000000E83
       jmp       short 0000000000000E92
       mov       rdx,7FF82F1BF7D0
       call      00000000000087F0
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 0000000000000E5D
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [5AB0]
       test      eax,eax
       je        short 0000000000000E5D
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 0000000000000F6B
       cmp       dword ptr [r12+20],0
       jg        near ptr 0000000000001105
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
       mov       rdx,7FF82F1BF148
       call      00000000000087F0
       mov       rdx,rax
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [5EA0]
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 0000000000001049
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr 000000000000112E
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000112E
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+80]
       test      r11,r11
       je        short 0000000000000F83
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 0000000000000F9F
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 0000000000000EBE
       mov       rdx,7FF82F1BF168
       call      00000000000087F0
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 0000000000000FDD
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr 000000000000112E
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      0000000000000010
       mov       r12d,[rsp+44]
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr 0000000000000F1A
       jmp       short 0000000000001049
       mov       rdx,7FF82F1BF0F8
       call      00000000000087F0
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5E70]
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000108E
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+78]
       test      rdx,rdx
       je        near ptr 0000000000000EDB
       jmp       near ptr 0000000000000EED
       mov       rdx,7FF82F1BF0B8
       call      00000000000087F0
       mov       rdx,rax
       jmp       short 0000000000001062
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short 0000000000001035
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [5AE0]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+60],0
       je        short 00000000000010BA
       mov       rcx,[r15+60]
       jmp       short 00000000000010CC
       mov       rdx,7FF82F1BF050
       call      00000000000087F0
       mov       rcx,rax
       call      qword ptr [3780]
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       jne       near ptr 0000000000000E1F
       mov       ecx,825
       mov       rdx,7FF82EE01A08
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [0B450]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       jmp       near ptr 0000000000000ECA
       call      00000000000023D0
       int       3
; Total bytes of code 852
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			                                           ^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],sil
       call      qword ptr [3918]
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,0FFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,0
       or        rax,rdx
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,0
       or        rdx,rcx
       mov       rcx,0FFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[558]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [560]
       seta      al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr 000000000000FC3E
       test      rsi,rsi
       je        near ptr 000000000000FC4A
       mov       r14,[rdi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short 000000000000FB81
       jmp       short 000000000000FB96
       mov       rcx,rdi
       mov       rdx,7FF82F1BD6C8
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
       mov       r11,7FF82E9B07D0
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000FC09
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000FBBF
       jmp       short 000000000000FBD4
       mov       rcx,rdi
       mov       rdx,7FF82F1BD7A0
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short 000000000000FC00
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82E9B07D0
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000FBB4
       jmp       short 000000000000FC09
       mov       dword ptr [rbp+0FFD4],1
       jmp       short 000000000000FC27
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82E9B07D8
       call      qword ptr [r11]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       rcx,rsp
       call      000000000000FC56
       nop
       mov       eax,[rbp+0FFD4]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       ecx,10
       call      qword ptr [0B780]
       int       3
       mov       ecx,0C
       call      qword ptr [0B780]
       int       3
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFC8]
       test      rcx,rcx
       je        short 000000000000FC83
       mov       r11,7FF82E9B07D8
       call      qword ptr [r11]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 335
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       r8,2666C252FF0
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      00000000000068D8
       mov       rsi,[rsi+20]
       mov       rcx,2666C25C718
       mov       r8,[rcx]
       test      r8,r8
       jne       short 000000000000F4CC
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rdi,rax
       mov       rdx,2666C25C710
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      000000000000AEB0
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rdi+18],rdx
       mov       rcx,2666C25C718
       mov       rdx,rdi
       call      000000000000B010
       mov       r8,rdi
       test      r8,r8
       jne       short 000000000000F4D5
       xor       edi,edi
       jmp       short 000000000000F4E9
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      0000000000001AE0
       mov       edi,eax
       mov       [rsi+54],dil
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 197
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000FD8F
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       je        near ptr 000000000000FDD6
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short 000000000000FA57
       jmp       short 000000000000FA69
       mov       rdx,7FF82F4EC480
       call      0000000000002740
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000007440
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000FA91
       mov       rcx,r14
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr 000000000000FCF3
       jmp       near ptr 000000000000FD05
       mov       rcx,r14
       mov       rax,[r15+88]
       test      rax,rax
       je        short 000000000000FAA2
       jmp       short 000000000000FAB1
       mov       rdx,7FF82F4ECB98
       call      0000000000002740
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000FA7C
       mov       rcx,rdi
       mov       rdx,r12
       call      0000000000006A10
       test      eax,eax
       je        short 000000000000FA7C
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000FCDB
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000FE0F
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
       mov       rdx,7FF82F4EC510
       call      0000000000002740
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      0000000000007158
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000FCC1
       test      rbp,rbp
       je        near ptr 000000000000FC11
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr 000000000000FC11
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000FE37
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+80]
       test      r11,r11
       je        short 000000000000FBA7
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000FBC3
       mov       rdx,7FF82F4EC530
       call      0000000000002740
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000FBFE
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000FE37
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000FB5F
       jmp       near ptr 000000000000FCC1
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr 000000000000FE37
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000FE37
       lea       ecx,[r12+0FFFF]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+80]
       test      r11,r11
       je        short 000000000000FC61
       mov       rax,[rsp+30]
       jmp       short 000000000000FC78
       mov       rdx,7FF82F4EC530
       call      0000000000002740
       mov       r11,rax
       mov       rax,[rsp+30]
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000FCB3
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000FE37
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000FC11
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+68]
       test      r15,r15
       je        short 000000000000FD3F
       jmp       short 000000000000FD50
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000FADC
       mov       rdx,7FF82F4EC4C0
       call      0000000000002740
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000007138
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000FD7E
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+78]
       test      r12,r12
       je        near ptr 000000000000FAF9
       mov       rax,r12
       jmp       near ptr 000000000000FB08
       mov       rdx,7FF82F4EC480
       call      0000000000002740
       jmp       short 000000000000FD53
       mov       rax,r15
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      0000000000006A20
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+60],0
       je        short 000000000000FDAA
       mov       rcx,[r15+60]
       jmp       short 000000000000FDBC
       mov       rdx,7FF82F4EC418
       call      0000000000002740
       mov       rcx,rax
       call      0000000000007360
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       jne       near ptr 000000000000FA3F
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FF82F16BD88
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      0000000000007EF8
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       jmp       near ptr 000000000000FAE8
       call      000000000000F130
       int       3
; Total bytes of code 1085
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			                                           ^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      0000000000000538
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,0FFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,0
       or        rax,rdx
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,0
       or        rdx,rcx
       mov       rcx,0FFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[0F0B8]
       vucomisd  xmm0,qword ptr [0F0C0]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr 000000000000E10A
       test      rdi,rdi
       je        near ptr 000000000000E115
       mov       r14,[rsi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short 000000000000E041
       jmp       short 000000000000E056
       mov       rcx,rsi
       mov       rdx,7FF82F4EADA8
       call      0000000000004920
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
       mov       r11,7FF82EE80720
       call      qword ptr [720]
       test      eax,eax
       je        short 000000000000E0D2
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000E082
       jmp       short 000000000000E097
       mov       rcx,rsi
       mov       rdx,7FF82F4EAE80
       call      0000000000004920
       mov       r11,rax
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short 000000000000E0C9
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82EE80720
       call      qword ptr [720]
       test      eax,eax
       jne       short 000000000000E077
       jmp       short 000000000000E0D2
       mov       dword ptr [rbp+0FFD4],1
       jmp       short 000000000000E0F3
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82EE80728
       call      qword ptr [728]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       rcx,rsp
       call      000000000000E120
       nop
       mov       eax,[rbp+0FFD4]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       ecx,10
       call      000000000000B010
       int       3
       mov       ecx,0C
       call      000000000000B010
       int       3
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFC8]
       test      rcx,rcx
       je        short 000000000000E150
       mov       r11,7FF82EE80728
       call      qword ptr [728]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 348
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       r8,1A02700D3C8
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7708]
       mov       rsi,[rsi+20]
       mov       rdi,1A02700B730
       mov       r8,[rdi]
       test      r8,r8
       jne       short 0000000000000FF7
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rbp,rax
       mov       rdx,1A02700B728
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      0000000000000010
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbp+18],rdx
       mov       rcx,rdi
       mov       rdx,rbp
       call      0000000000000010
       mov       r8,rbp
       test      r8,r8
       jne       short 0000000000001000
       xor       edi,edi
       jmp       short 0000000000001015
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      qword ptr [9B28]
       mov       edi,eax
       mov       [rsi+54],dil
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 194
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000171F
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       je        near ptr 0000000000001767
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short 00000000000014B7
       jmp       short 00000000000014C9
       mov       rdx,7FF82F1CE9A0
       call      00000000000087F0
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5828]
       mov       r12,rax
       test      r12,r12
       jne       short 00000000000014F2
       mov       rcx,r14
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr 000000000000166B
       jmp       near ptr 000000000000167D
       mov       rcx,r14
       mov       rax,[r15+88]
       test      rax,rax
       je        short 0000000000001503
       jmp       short 0000000000001512
       mov       rdx,7FF82F1CF0B8
       call      00000000000087F0
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 00000000000014DD
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7AB0]
       test      eax,eax
       je        short 00000000000014DD
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 00000000000015EB
       cmp       dword ptr [r12+20],0
       jg        near ptr 0000000000001785
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
       mov       rdx,7FF82F1CEA30
       call      00000000000087F0
       mov       rdx,rax
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7EA0]
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 00000000000016C9
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr 00000000000017AE
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 00000000000017AE
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+80]
       test      r11,r11
       je        short 0000000000001603
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000161F
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000153E
       mov       rdx,7FF82F1CEA50
       call      00000000000087F0
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000165D
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr 00000000000017AE
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      0000000000000010
       mov       r12d,[rsp+44]
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr 000000000000159A
       jmp       short 00000000000016C9
       mov       rdx,7FF82F1CE9E0
       call      00000000000087F0
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7E70]
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000170E
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+78]
       test      rdx,rdx
       je        near ptr 000000000000155B
       jmp       near ptr 000000000000156D
       mov       rdx,7FF82F1CE9A0
       call      00000000000087F0
       mov       rdx,rax
       jmp       short 00000000000016E2
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short 00000000000016B5
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [7AE0]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+60],0
       je        short 000000000000173A
       mov       rcx,[r15+60]
       jmp       short 000000000000174C
       mov       rdx,7FF82F1CE938
       call      00000000000087F0
       mov       rcx,rax
       call      qword ptr [3780]
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       jne       near ptr 000000000000149F
       mov       ecx,825
       mov       rdx,7FF82EE11A08
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [0D450]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       jmp       near ptr 000000000000154A
       call      00000000000023D0
       int       3
; Total bytes of code 852
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			                                           ^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],sil
       call      qword ptr [3918]
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,0FFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,0
       or        rax,rdx
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,0
       or        rdx,rcx
       mov       rcx,0FFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[0BD8]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [0BE0]
       seta      al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr 00000000000002BE
       test      rsi,rsi
       je        near ptr 00000000000002CA
       mov       r14,[rdi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short 0000000000000201
       jmp       short 0000000000000216
       mov       rcx,rdi
       mov       rdx,7FF82F1CCFB0
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
       mov       r11,7FF82E9C07D0
       call      qword ptr [r11]
       test      eax,eax
       je        short 0000000000000289
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000023F
       jmp       short 0000000000000254
       mov       rcx,rdi
       mov       rdx,7FF82F1CD088
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short 0000000000000280
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82E9C07D0
       call      qword ptr [r11]
       test      eax,eax
       jne       short 0000000000000234
       jmp       short 0000000000000289
       mov       dword ptr [rbp+0FFD4],1
       jmp       short 00000000000002A7
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82E9C07D8
       call      qword ptr [r11]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       rcx,rsp
       call      00000000000002D6
       nop
       mov       eax,[rbp+0FFD4]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       ecx,10
       call      qword ptr [0B780]
       int       3
       mov       ecx,0C
       call      qword ptr [0B780]
       int       3
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFC8]
       test      rcx,rcx
       je        short 0000000000000303
       mov       r11,7FF82E9C07D8
       call      qword ptr [r11]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 335
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       r8,25609AB2FF0
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      0000000000006928
       mov       rsi,[rsi+20]
       mov       rcx,25619AB8310
       mov       r8,[rcx]
       test      r8,r8
       jne       short 000000000000F38C
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rdi,rax
       mov       rdx,25619AB8308
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      000000000000AEB0
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rdi+18],rdx
       mov       rcx,25619AB8310
       mov       rdx,rdi
       call      000000000000B010
       mov       r8,rdi
       test      r8,r8
       jne       short 000000000000F395
       xor       edi,edi
       jmp       short 000000000000F3A9
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      0000000000001AE0
       mov       edi,eax
       mov       [rsi+54],dil
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 197
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000FEAF
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       je        near ptr 000000000000FEF6
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short 000000000000FB77
       jmp       short 000000000000FB89
       mov       rdx,7FF82F4EC480
       call      0000000000002740
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000007440
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000FBB1
       mov       rcx,r14
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr 000000000000FE13
       jmp       near ptr 000000000000FE25
       mov       rcx,r14
       mov       rax,[r15+88]
       test      rax,rax
       je        short 000000000000FBC2
       jmp       short 000000000000FBD1
       mov       rdx,7FF82F4ECB98
       call      0000000000002740
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000FB9C
       mov       rcx,rdi
       mov       rdx,r12
       call      0000000000006A60
       test      eax,eax
       je        short 000000000000FB9C
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000FDFB
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000FF2F
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
       mov       rdx,7FF82F4EC510
       call      0000000000002740
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      0000000000006BA8
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000FDE1
       test      rbp,rbp
       je        near ptr 000000000000FD31
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr 000000000000FD31
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000FF57
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+80]
       test      r11,r11
       je        short 000000000000FCC7
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000FCE3
       mov       rdx,7FF82F4EC530
       call      0000000000002740
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000FD1E
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000FF57
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000FC7F
       jmp       near ptr 000000000000FDE1
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr 000000000000FF57
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000FF57
       lea       ecx,[r12+0FFFF]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+80]
       test      r11,r11
       je        short 000000000000FD81
       mov       rax,[rsp+30]
       jmp       short 000000000000FD98
       mov       rdx,7FF82F4EC530
       call      0000000000002740
       mov       r11,rax
       mov       rax,[rsp+30]
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000FDD3
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000FF57
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000FD31
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+68]
       test      r15,r15
       je        short 000000000000FE5F
       jmp       short 000000000000FE70
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000FBFC
       mov       rdx,7FF82F4EC4C0
       call      0000000000002740
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000006B88
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000FE9E
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+78]
       test      r12,r12
       je        near ptr 000000000000FC19
       mov       rax,r12
       jmp       near ptr 000000000000FC28
       mov       rdx,7FF82F4EC480
       call      0000000000002740
       jmp       short 000000000000FE73
       mov       rax,r15
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      0000000000006A70
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+60],0
       je        short 000000000000FECA
       mov       rcx,[r15+60]
       jmp       short 000000000000FEDC
       mov       rdx,7FF82F4EC418
       call      0000000000002740
       mov       rcx,rax
       call      0000000000007360
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       jne       near ptr 000000000000FB5F
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FF82F16BD88
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      0000000000007FA8
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       jmp       near ptr 000000000000FC08
       call      000000000000F130
       int       3
; Total bytes of code 1085
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			                                           ^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      0000000000000538
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,0FFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,0
       or        rax,rdx
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,0
       or        rdx,rcx
       mov       rcx,0FFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[0EF78]
       vucomisd  xmm0,qword ptr [0EF80]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr 000000000000E20A
       test      rdi,rdi
       je        near ptr 000000000000E215
       mov       r14,[rsi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short 000000000000E141
       jmp       short 000000000000E156
       mov       rcx,rsi
       mov       rdx,7FF82F4EADA8
       call      0000000000004920
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
       mov       r11,7FF82EE80720
       call      qword ptr [720]
       test      eax,eax
       je        short 000000000000E1D2
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000E182
       jmp       short 000000000000E197
       mov       rcx,rsi
       mov       rdx,7FF82F4EAE80
       call      0000000000004920
       mov       r11,rax
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short 000000000000E1C9
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82EE80720
       call      qword ptr [720]
       test      eax,eax
       jne       short 000000000000E177
       jmp       short 000000000000E1D2
       mov       dword ptr [rbp+0FFD4],1
       jmp       short 000000000000E1F3
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82EE80728
       call      qword ptr [728]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       rcx,rsp
       call      000000000000E220
       nop
       mov       eax,[rbp+0FFD4]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       ecx,10
       call      000000000000B010
       int       3
       mov       ecx,0C
       call      000000000000B010
       int       3
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFC8]
       test      rcx,rcx
       je        short 000000000000E250
       mov       r11,7FF82EE80728
       call      qword ptr [728]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 348
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       r8,1924400D3C8
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [9048]
       mov       rsi,[rsi+20]
       mov       rdi,1924400B730
       mov       r8,[rdi]
       test      r8,r8
       jne       short 0000000000001217
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rbp,rax
       mov       rdx,1924400B728
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      0000000000000010
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbp+18],rdx
       mov       rcx,rdi
       mov       rdx,rbp
       call      0000000000000010
       mov       r8,rbp
       test      r8,r8
       jne       short 0000000000001220
       xor       edi,edi
       jmp       short 0000000000001235
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      qword ptr [9B28]
       mov       edi,eax
       mov       [rsi+54],dil
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 194
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000193F
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       je        near ptr 0000000000001987
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short 00000000000016D7
       jmp       short 00000000000016E9
       mov       rdx,7FF82F1CEAC0
       call      00000000000087F0
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5828]
       mov       r12,rax
       test      r12,r12
       jne       short 0000000000001712
       mov       rcx,r14
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr 000000000000188B
       jmp       near ptr 000000000000189D
       mov       rcx,r14
       mov       rax,[r15+88]
       test      rax,rax
       je        short 0000000000001723
       jmp       short 0000000000001732
       mov       rdx,7FF82F1CF1D8
       call      00000000000087F0
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 00000000000016FD
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [93F0]
       test      eax,eax
       je        short 00000000000016FD
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000180B
       cmp       dword ptr [r12+20],0
       jg        near ptr 00000000000019A5
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
       mov       rdx,7FF82F1CEB50
       call      00000000000087F0
       mov       rdx,rax
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [97E0]
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 00000000000018E9
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr 00000000000019CE
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 00000000000019CE
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+80]
       test      r11,r11
       je        short 0000000000001823
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000183F
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000175E
       mov       rdx,7FF82F1CEB70
       call      00000000000087F0
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000187D
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr 00000000000019CE
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      0000000000000010
       mov       r12d,[rsp+44]
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr 00000000000017BA
       jmp       short 00000000000018E9
       mov       rdx,7FF82F1CEB00
       call      00000000000087F0
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [97B0]
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000192E
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+78]
       test      rdx,rdx
       je        near ptr 000000000000177B
       jmp       near ptr 000000000000178D
       mov       rdx,7FF82F1CEAC0
       call      00000000000087F0
       mov       rdx,rax
       jmp       short 0000000000001902
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short 00000000000018D5
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [9420]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+60],0
       je        short 000000000000195A
       mov       rcx,[r15+60]
       jmp       short 000000000000196C
       mov       rdx,7FF82F1CEA58
       call      00000000000087F0
       mov       rcx,rax
       call      qword ptr [3780]
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       jne       near ptr 00000000000016BF
       mov       ecx,825
       mov       rdx,7FF82EE11A08
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [0DD98]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       jmp       near ptr 000000000000176A
       call      00000000000023D0
       int       3
; Total bytes of code 852
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			                                           ^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],sil
       call      qword ptr [3918]
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,0FFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,0
       or        rax,rdx
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,0
       or        rdx,rcx
       mov       rcx,0FFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[0DF8]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [0E00]
       seta      al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr 00000000000004DE
       test      rsi,rsi
       je        near ptr 00000000000004EA
       mov       r14,[rdi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short 0000000000000421
       jmp       short 0000000000000436
       mov       rcx,rdi
       mov       rdx,7FF82F1CD0D0
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
       mov       r11,7FF82E9C07D0
       call      qword ptr [r11]
       test      eax,eax
       je        short 00000000000004A9
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000045F
       jmp       short 0000000000000474
       mov       rcx,rdi
       mov       rdx,7FF82F1CD1A8
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short 00000000000004A0
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82E9C07D0
       call      qword ptr [r11]
       test      eax,eax
       jne       short 0000000000000454
       jmp       short 00000000000004A9
       mov       dword ptr [rbp+0FFD4],1
       jmp       short 00000000000004C7
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82E9C07D8
       call      qword ptr [r11]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       rcx,rsp
       call      00000000000004F6
       nop
       mov       eax,[rbp+0FFD4]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       ecx,10
       call      qword ptr [0B780]
       int       3
       mov       ecx,0C
       call      qword ptr [0B780]
       int       3
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFC8]
       test      rcx,rcx
       je        short 0000000000000523
       mov       r11,7FF82E9C07D8
       call      qword ptr [r11]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 335
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       r8,20E27682FF0
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      0000000000006928
       mov       rsi,[rsi+20]
       mov       rcx,20E47688310
       mov       r8,[rcx]
       test      r8,r8
       jne       short 000000000000F38C
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rdi,rax
       mov       rdx,20E47688308
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      000000000000AEB0
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rdi+18],rdx
       mov       rcx,20E47688310
       mov       rdx,rdi
       call      000000000000B010
       mov       r8,rdi
       test      r8,r8
       jne       short 000000000000F395
       xor       edi,edi
       jmp       short 000000000000F3A9
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      0000000000001AE0
       mov       edi,eax
       mov       [rsi+54],dil
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 197
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000FEAF
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       je        near ptr 000000000000FEF6
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short 000000000000FB77
       jmp       short 000000000000FB89
       mov       rdx,7FF82F52C480
       call      0000000000002740
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000007440
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000FBB1
       mov       rcx,r14
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr 000000000000FE13
       jmp       near ptr 000000000000FE25
       mov       rcx,r14
       mov       rax,[r15+88]
       test      rax,rax
       je        short 000000000000FBC2
       jmp       short 000000000000FBD1
       mov       rdx,7FF82F52CB98
       call      0000000000002740
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000FB9C
       mov       rcx,rdi
       mov       rdx,r12
       call      0000000000006A60
       test      eax,eax
       je        short 000000000000FB9C
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000FDFB
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000FF2F
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
       mov       rdx,7FF82F52C510
       call      0000000000002740
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      0000000000006BA8
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000FDE1
       test      rbp,rbp
       je        near ptr 000000000000FD31
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr 000000000000FD31
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000FF57
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+80]
       test      r11,r11
       je        short 000000000000FCC7
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000FCE3
       mov       rdx,7FF82F52C530
       call      0000000000002740
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000FD1E
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000FF57
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000FC7F
       jmp       near ptr 000000000000FDE1
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr 000000000000FF57
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000FF57
       lea       ecx,[r12+0FFFF]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+80]
       test      r11,r11
       je        short 000000000000FD81
       mov       rax,[rsp+30]
       jmp       short 000000000000FD98
       mov       rdx,7FF82F52C530
       call      0000000000002740
       mov       r11,rax
       mov       rax,[rsp+30]
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000FDD3
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000FF57
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000FD31
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+68]
       test      r15,r15
       je        short 000000000000FE5F
       jmp       short 000000000000FE70
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000FBFC
       mov       rdx,7FF82F52C4C0
       call      0000000000002740
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000006B88
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000FE9E
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+78]
       test      r12,r12
       je        near ptr 000000000000FC19
       mov       rax,r12
       jmp       near ptr 000000000000FC28
       mov       rdx,7FF82F52C480
       call      0000000000002740
       jmp       short 000000000000FE73
       mov       rax,r15
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      0000000000006A70
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+60],0
       je        short 000000000000FECA
       mov       rcx,[r15+60]
       jmp       short 000000000000FEDC
       mov       rdx,7FF82F52C418
       call      0000000000002740
       mov       rcx,rax
       call      0000000000007360
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       jne       near ptr 000000000000FB5F
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FF82F1ABD88
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      0000000000007FA8
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       jmp       near ptr 000000000000FC08
       call      000000000000F130
       int       3
; Total bytes of code 1085
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			                                           ^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      0000000000000538
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,0FFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,0
       or        rax,rdx
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,0
       or        rdx,rcx
       mov       rcx,0FFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[0EF78]
       vucomisd  xmm0,qword ptr [0EF80]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr 000000000000E20A
       test      rdi,rdi
       je        near ptr 000000000000E215
       mov       r14,[rsi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short 000000000000E141
       jmp       short 000000000000E156
       mov       rcx,rsi
       mov       rdx,7FF82F52ADA8
       call      0000000000004920
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
       mov       r11,7FF82EEC0720
       call      qword ptr [720]
       test      eax,eax
       je        short 000000000000E1D2
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000E182
       jmp       short 000000000000E197
       mov       rcx,rsi
       mov       rdx,7FF82F52AE80
       call      0000000000004920
       mov       r11,rax
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short 000000000000E1C9
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82EEC0720
       call      qword ptr [720]
       test      eax,eax
       jne       short 000000000000E177
       jmp       short 000000000000E1D2
       mov       dword ptr [rbp+0FFD4],1
       jmp       short 000000000000E1F3
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82EEC0728
       call      qword ptr [728]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       rcx,rsp
       call      000000000000E220
       nop
       mov       eax,[rbp+0FFD4]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       ecx,10
       call      000000000000B010
       int       3
       mov       ecx,0C
       call      000000000000B010
       int       3
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFC8]
       test      rcx,rcx
       je        short 000000000000E250
       mov       r11,7FF82EEC0728
       call      qword ptr [728]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 348
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       r8,202F800D3C8
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [9048]
       mov       rsi,[rsi+20]
       mov       rdi,202F800B730
       mov       r8,[rdi]
       test      r8,r8
       jne       short 0000000000001017
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rbp,rax
       mov       rdx,202F800B728
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      0000000000000010
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbp+18],rdx
       mov       rcx,rdi
       mov       rdx,rbp
       call      0000000000000010
       mov       r8,rbp
       test      r8,r8
       jne       short 0000000000001020
       xor       edi,edi
       jmp       short 0000000000001035
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      qword ptr [9B28]
       mov       edi,eax
       mov       [rsi+54],dil
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 194
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000173F
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       je        near ptr 0000000000001787
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short 00000000000014D7
       jmp       short 00000000000014E9
       mov       rdx,7FF82F1DE9A0
       call      00000000000087F0
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5828]
       mov       r12,rax
       test      r12,r12
       jne       short 0000000000001512
       mov       rcx,r14
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr 000000000000168B
       jmp       near ptr 000000000000169D
       mov       rcx,r14
       mov       rax,[r15+88]
       test      rax,rax
       je        short 0000000000001523
       jmp       short 0000000000001532
       mov       rdx,7FF82F1DF0B8
       call      00000000000087F0
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 00000000000014FD
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [93F0]
       test      eax,eax
       je        short 00000000000014FD
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000160B
       cmp       dword ptr [r12+20],0
       jg        near ptr 00000000000017A5
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
       mov       rdx,7FF82F1DEA30
       call      00000000000087F0
       mov       rdx,rax
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [97E0]
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 00000000000016E9
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr 00000000000017CE
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 00000000000017CE
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+80]
       test      r11,r11
       je        short 0000000000001623
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000163F
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000155E
       mov       rdx,7FF82F1DEA50
       call      00000000000087F0
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000167D
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr 00000000000017CE
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      0000000000000010
       mov       r12d,[rsp+44]
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr 00000000000015BA
       jmp       short 00000000000016E9
       mov       rdx,7FF82F1DE9E0
       call      00000000000087F0
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [97B0]
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000172E
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+78]
       test      rdx,rdx
       je        near ptr 000000000000157B
       jmp       near ptr 000000000000158D
       mov       rdx,7FF82F1DE9A0
       call      00000000000087F0
       mov       rdx,rax
       jmp       short 0000000000001702
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short 00000000000016D5
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [9420]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+60],0
       je        short 000000000000175A
       mov       rcx,[r15+60]
       jmp       short 000000000000176C
       mov       rdx,7FF82F1DE938
       call      00000000000087F0
       mov       rcx,rax
       call      qword ptr [3780]
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       jne       near ptr 00000000000014BF
       mov       ecx,825
       mov       rdx,7FF82EE21A08
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [0DD98]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       jmp       near ptr 000000000000156A
       call      00000000000023D0
       int       3
; Total bytes of code 852
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			                                           ^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],sil
       call      qword ptr [3918]
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,0FFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,0
       or        rax,rdx
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,0
       or        rdx,rcx
       mov       rcx,0FFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[0BF8]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [0C00]
       seta      al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr 00000000000002DE
       test      rsi,rsi
       je        near ptr 00000000000002EA
       mov       r14,[rdi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short 0000000000000221
       jmp       short 0000000000000236
       mov       rcx,rdi
       mov       rdx,7FF82F1DCFB0
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
       mov       r11,7FF82E9D07D0
       call      qword ptr [r11]
       test      eax,eax
       je        short 00000000000002A9
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000025F
       jmp       short 0000000000000274
       mov       rcx,rdi
       mov       rdx,7FF82F1DD088
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short 00000000000002A0
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82E9D07D0
       call      qword ptr [r11]
       test      eax,eax
       jne       short 0000000000000254
       jmp       short 00000000000002A9
       mov       dword ptr [rbp+0FFD4],1
       jmp       short 00000000000002C7
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82E9D07D8
       call      qword ptr [r11]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       rcx,rsp
       call      00000000000002F6
       nop
       mov       eax,[rbp+0FFD4]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       ecx,10
       call      qword ptr [0B780]
       int       3
       mov       ecx,0C
       call      qword ptr [0B780]
       int       3
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFC8]
       test      rcx,rcx
       je        short 0000000000000323
       mov       r11,7FF82E9D07D8
       call      qword ptr [r11]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 335
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       r8,276F61C2FF0
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      0000000000006928
       mov       rsi,[rsi+20]
       mov       rcx,276F61CC718
       mov       r8,[rcx]
       test      r8,r8
       jne       short 000000000000F37C
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rdi,rax
       mov       rdx,276F61CC710
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      000000000000AEB0
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rdi+18],rdx
       mov       rcx,276F61CC718
       mov       rdx,rdi
       call      000000000000B010
       mov       r8,rdi
       test      r8,r8
       jne       short 000000000000F385
       xor       edi,edi
       jmp       short 000000000000F399
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      0000000000001AE0
       mov       edi,eax
       mov       [rsi+54],dil
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 197
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000FE8F
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       je        near ptr 000000000000FED6
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short 000000000000FB57
       jmp       short 000000000000FB69
       mov       rdx,7FF82F52C480
       call      0000000000002740
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000007440
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000FB91
       mov       rcx,r14
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr 000000000000FDF3
       jmp       near ptr 000000000000FE05
       mov       rcx,r14
       mov       rax,[r15+88]
       test      rax,rax
       je        short 000000000000FBA2
       jmp       short 000000000000FBB1
       mov       rdx,7FF82F52CB98
       call      0000000000002740
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000FB7C
       mov       rcx,rdi
       mov       rdx,r12
       call      0000000000006A60
       test      eax,eax
       je        short 000000000000FB7C
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000FDDB
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000FF0F
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
       mov       rdx,7FF82F52C510
       call      0000000000002740
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      0000000000006BA8
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000FDC1
       test      rbp,rbp
       je        near ptr 000000000000FD11
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr 000000000000FD11
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000FF37
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+80]
       test      r11,r11
       je        short 000000000000FCA7
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000FCC3
       mov       rdx,7FF82F52C530
       call      0000000000002740
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000FCFE
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000FF37
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000FC5F
       jmp       near ptr 000000000000FDC1
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr 000000000000FF37
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000FF37
       lea       ecx,[r12+0FFFF]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+80]
       test      r11,r11
       je        short 000000000000FD61
       mov       rax,[rsp+30]
       jmp       short 000000000000FD78
       mov       rdx,7FF82F52C530
       call      0000000000002740
       mov       r11,rax
       mov       rax,[rsp+30]
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000FDB3
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000FF37
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000FD11
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+68]
       test      r15,r15
       je        short 000000000000FE3F
       jmp       short 000000000000FE50
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000FBDC
       mov       rdx,7FF82F52C4C0
       call      0000000000002740
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000006B88
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000FE7E
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+78]
       test      r12,r12
       je        near ptr 000000000000FBF9
       mov       rax,r12
       jmp       near ptr 000000000000FC08
       mov       rdx,7FF82F52C480
       call      0000000000002740
       jmp       short 000000000000FE53
       mov       rax,r15
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      0000000000006A70
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+60],0
       je        short 000000000000FEAA
       mov       rcx,[r15+60]
       jmp       short 000000000000FEBC
       mov       rdx,7FF82F52C418
       call      0000000000002740
       mov       rcx,rax
       call      0000000000007360
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       jne       near ptr 000000000000FB3F
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FF82F1ABD88
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      0000000000007FA8
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       jmp       near ptr 000000000000FBE8
       call      000000000000F130
       int       3
; Total bytes of code 1085
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			                                           ^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      0000000000000538
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,0FFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,0
       or        rax,rdx
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,0
       or        rdx,rcx
       mov       rcx,0FFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[0F038]
       vucomisd  xmm0,qword ptr [0F040]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr 000000000000E2CA
       test      rdi,rdi
       je        near ptr 000000000000E2D5
       mov       r14,[rsi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short 000000000000E201
       jmp       short 000000000000E216
       mov       rcx,rsi
       mov       rdx,7FF82F52AED0
       call      0000000000004920
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
       mov       r11,7FF82EEC0720
       call      qword ptr [720]
       test      eax,eax
       je        short 000000000000E292
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000E242
       jmp       short 000000000000E257
       mov       rcx,rsi
       mov       rdx,7FF82F52AFA8
       call      0000000000004920
       mov       r11,rax
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short 000000000000E289
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82EEC0720
       call      qword ptr [720]
       test      eax,eax
       jne       short 000000000000E237
       jmp       short 000000000000E292
       mov       dword ptr [rbp+0FFD4],1
       jmp       short 000000000000E2B3
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82EEC0728
       call      qword ptr [728]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       rcx,rsp
       call      000000000000E2E0
       nop
       mov       eax,[rbp+0FFD4]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       ecx,10
       call      000000000000B010
       int       3
       mov       ecx,0C
       call      000000000000B010
       int       3
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFC8]
       test      rcx,rcx
       je        short 000000000000E310
       mov       r11,7FF82EEC0728
       call      qword ptr [728]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 348
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       r8,23D6F003C10
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7708]
       mov       rsi,[rsi+20]
       mov       rdi,23D6F001F78
       mov       r8,[rdi]
       test      r8,r8
       jne       short 0000000000001207
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rbp,rax
       mov       rdx,23D6F001F70
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      0000000000000010
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbp+18],rdx
       mov       rcx,rdi
       mov       rdx,rbp
       call      0000000000000010
       mov       r8,rbp
       test      r8,r8
       jne       short 0000000000001210
       xor       edi,edi
       jmp       short 0000000000001225
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      qword ptr [9B28]
       mov       edi,eax
       mov       [rsi+54],dil
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 194
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000193F
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       je        near ptr 0000000000001987
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short 00000000000016D7
       jmp       short 00000000000016E9
       mov       rdx,7FF82F1CEAD0
       call      00000000000087F0
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5828]
       mov       r12,rax
       test      r12,r12
       jne       short 0000000000001712
       mov       rcx,r14
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr 000000000000188B
       jmp       near ptr 000000000000189D
       mov       rcx,r14
       mov       rax,[r15+88]
       test      rax,rax
       je        short 0000000000001723
       jmp       short 0000000000001732
       mov       rdx,7FF82F1CF1E8
       call      00000000000087F0
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 00000000000016FD
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7AB0]
       test      eax,eax
       je        short 00000000000016FD
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000180B
       cmp       dword ptr [r12+20],0
       jg        near ptr 00000000000019A5
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
       mov       rdx,7FF82F1CEB60
       call      00000000000087F0
       mov       rdx,rax
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7EA0]
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 00000000000018E9
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr 00000000000019CE
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 00000000000019CE
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+80]
       test      r11,r11
       je        short 0000000000001823
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000183F
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000175E
       mov       rdx,7FF82F1CEB80
       call      00000000000087F0
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000187D
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr 00000000000019CE
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      0000000000000010
       mov       r12d,[rsp+44]
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr 00000000000017BA
       jmp       short 00000000000018E9
       mov       rdx,7FF82F1CEB10
       call      00000000000087F0
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7E70]
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000192E
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+78]
       test      rdx,rdx
       je        near ptr 000000000000177B
       jmp       near ptr 000000000000178D
       mov       rdx,7FF82F1CEAD0
       call      00000000000087F0
       mov       rdx,rax
       jmp       short 0000000000001902
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short 00000000000018D5
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [7AE0]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+60],0
       je        short 000000000000195A
       mov       rcx,[r15+60]
       jmp       short 000000000000196C
       mov       rdx,7FF82F1CEA68
       call      00000000000087F0
       mov       rcx,rax
       call      qword ptr [3780]
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       jne       near ptr 00000000000016BF
       mov       ecx,825
       mov       rdx,7FF82EE11A08
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [0D450]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       jmp       near ptr 000000000000176A
       call      00000000000023D0
       int       3
; Total bytes of code 852
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			                                           ^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],sil
       call      qword ptr [3918]
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,0FFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,0
       or        rax,rdx
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,0
       or        rdx,rcx
       mov       rcx,0FFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[0E78]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [0E80]
       seta      al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr 000000000000055E
       test      rsi,rsi
       je        near ptr 000000000000056A
       mov       r14,[rdi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short 00000000000004A1
       jmp       short 00000000000004B6
       mov       rcx,rdi
       mov       rdx,7FF82F1CD1B0
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
       mov       r11,7FF82E9C07D0
       call      qword ptr [r11]
       test      eax,eax
       je        short 0000000000000529
       mov       r11,[r14+28]
       test      r11,r11
       je        short 00000000000004DF
       jmp       short 00000000000004F4
       mov       rcx,rdi
       mov       rdx,7FF82F1CD288
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short 0000000000000520
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82E9C07D0
       call      qword ptr [r11]
       test      eax,eax
       jne       short 00000000000004D4
       jmp       short 0000000000000529
       mov       dword ptr [rbp+0FFD4],1
       jmp       short 0000000000000547
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82E9C07D8
       call      qword ptr [r11]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       rcx,rsp
       call      0000000000000576
       nop
       mov       eax,[rbp+0FFD4]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       ecx,10
       call      qword ptr [0B780]
       int       3
       mov       ecx,0C
       call      qword ptr [0B780]
       int       3
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFC8]
       test      rcx,rcx
       je        short 00000000000005A3
       mov       r11,7FF82E9C07D8
       call      qword ptr [r11]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 335
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       r8,1C25DCA2FF0
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      0000000000006928
       mov       rsi,[rsi+20]
       mov       rcx,1C25DCAC718
       mov       r8,[rcx]
       test      r8,r8
       jne       short 000000000000EBBC
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rdi,rax
       mov       rdx,1C25DCAC710
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      000000000000AEB0
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rdi+18],rdx
       mov       rcx,1C25DCAC718
       mov       rdx,rdi
       call      000000000000B010
       mov       r8,rdi
       test      r8,r8
       jne       short 000000000000EBC5
       xor       edi,edi
       jmp       short 000000000000EBD9
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      0000000000001B08
       mov       edi,eax
       mov       [rsi+54],dil
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 197
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000F66F
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       je        near ptr 000000000000F6B6
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short 000000000000F337
       jmp       short 000000000000F349
       mov       rdx,7FF82F50B7A0
       call      0000000000002740
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000007440
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000F371
       mov       rcx,r14
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr 000000000000F5D3
       jmp       near ptr 000000000000F5E5
       mov       rcx,r14
       mov       rax,[r15+88]
       test      rax,rax
       je        short 000000000000F382
       jmp       short 000000000000F391
       mov       rdx,7FF82F50BEB8
       call      0000000000002740
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000F35C
       mov       rcx,rdi
       mov       rdx,r12
       call      0000000000006A60
       test      eax,eax
       je        short 000000000000F35C
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000F5BB
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000F6EF
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
       mov       rdx,7FF82F50B830
       call      0000000000002740
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      0000000000006BA8
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000F5A1
       test      rbp,rbp
       je        near ptr 000000000000F4F1
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr 000000000000F4F1
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000F717
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+80]
       test      r11,r11
       je        short 000000000000F487
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000F4A3
       mov       rdx,7FF82F50B850
       call      0000000000002740
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000F4DE
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000F717
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000F43F
       jmp       near ptr 000000000000F5A1
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr 000000000000F717
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000F717
       lea       ecx,[r12+0FFFF]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+80]
       test      r11,r11
       je        short 000000000000F541
       mov       rax,[rsp+30]
       jmp       short 000000000000F558
       mov       rdx,7FF82F50B850
       call      0000000000002740
       mov       r11,rax
       mov       rax,[rsp+30]
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000F593
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000F717
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000F4F1
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+68]
       test      r15,r15
       je        short 000000000000F61F
       jmp       short 000000000000F630
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000F3BC
       mov       rdx,7FF82F50B7E0
       call      0000000000002740
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000006B88
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000F65E
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+78]
       test      r12,r12
       je        near ptr 000000000000F3D9
       mov       rax,r12
       jmp       near ptr 000000000000F3E8
       mov       rdx,7FF82F50B7A0
       call      0000000000002740
       jmp       short 000000000000F633
       mov       rax,r15
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      0000000000006A70
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+60],0
       je        short 000000000000F68A
       mov       rcx,[r15+60]
       jmp       short 000000000000F69C
       mov       rdx,7FF82F50B738
       call      0000000000002740
       mov       rcx,rax
       call      0000000000007360
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       jne       near ptr 000000000000F31F
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FF82F18BD88
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      0000000000007FA8
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       jmp       near ptr 000000000000F3C8
       call      000000000000F130
       int       3
; Total bytes of code 1085
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			                                           ^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      0000000000000538
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,0FFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,0
       or        rax,rdx
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,0
       or        rdx,rcx
       mov       rcx,0FFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[0E878]
       vucomisd  xmm0,qword ptr [0E880]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr 000000000000D5CA
       test      rdi,rdi
       je        near ptr 000000000000D5D5
       mov       r14,[rsi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short 000000000000D501
       jmp       short 000000000000D516
       mov       rcx,rsi
       mov       rdx,7FF82F50A088
       call      0000000000004920
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
       mov       r11,7FF82EEA0718
       call      qword ptr [718]
       test      eax,eax
       je        short 000000000000D592
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000D542
       jmp       short 000000000000D557
       mov       rcx,rsi
       mov       rdx,7FF82F50A160
       call      0000000000004920
       mov       r11,rax
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short 000000000000D589
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82EEA0718
       call      qword ptr [718]
       test      eax,eax
       jne       short 000000000000D537
       jmp       short 000000000000D592
       mov       dword ptr [rbp+0FFD4],1
       jmp       short 000000000000D5B3
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82EEA0720
       call      qword ptr [720]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       rcx,rsp
       call      000000000000D5E0
       nop
       mov       eax,[rbp+0FFD4]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       ecx,10
       call      000000000000B010
       int       3
       mov       ecx,0C
       call      000000000000B010
       int       3
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFC8]
       test      rcx,rcx
       je        short 000000000000D610
       mov       r11,7FF82EEA0720
       call      qword ptr [720]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 348
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       r8,21D7900D3C8
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7708]
       mov       rsi,[rsi+20]
       mov       rdi,21D7900B730
       mov       r8,[rdi]
       test      r8,r8
       jne       short 0000000000001017
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rbp,rax
       mov       rdx,21D7900B728
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      0000000000000010
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbp+18],rdx
       mov       rcx,rdi
       mov       rdx,rbp
       call      0000000000000010
       mov       r8,rbp
       test      r8,r8
       jne       short 0000000000001020
       xor       edi,edi
       jmp       short 0000000000001035
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      qword ptr [9B28]
       mov       edi,eax
       mov       [rsi+54],dil
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 194
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000173F
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       je        near ptr 0000000000001787
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short 00000000000014D7
       jmp       short 00000000000014E9
       mov       rdx,7FF82F1CE9D0
       call      00000000000087F0
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5828]
       mov       r12,rax
       test      r12,r12
       jne       short 0000000000001512
       mov       rcx,r14
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr 000000000000168B
       jmp       near ptr 000000000000169D
       mov       rcx,r14
       mov       rax,[r15+88]
       test      rax,rax
       je        short 0000000000001523
       jmp       short 0000000000001532
       mov       rdx,7FF82F1CF0E8
       call      00000000000087F0
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 00000000000014FD
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7AB0]
       test      eax,eax
       je        short 00000000000014FD
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000160B
       cmp       dword ptr [r12+20],0
       jg        near ptr 00000000000017A5
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
       mov       rdx,7FF82F1CEA60
       call      00000000000087F0
       mov       rdx,rax
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7EA0]
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 00000000000016E9
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr 00000000000017CE
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 00000000000017CE
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+80]
       test      r11,r11
       je        short 0000000000001623
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000163F
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000155E
       mov       rdx,7FF82F1CEA80
       call      00000000000087F0
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000167D
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr 00000000000017CE
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      0000000000000010
       mov       r12d,[rsp+44]
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr 00000000000015BA
       jmp       short 00000000000016E9
       mov       rdx,7FF82F1CEA10
       call      00000000000087F0
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7E70]
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000172E
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+78]
       test      rdx,rdx
       je        near ptr 000000000000157B
       jmp       near ptr 000000000000158D
       mov       rdx,7FF82F1CE9D0
       call      00000000000087F0
       mov       rdx,rax
       jmp       short 0000000000001702
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short 00000000000016D5
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [7AE0]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+60],0
       je        short 000000000000175A
       mov       rcx,[r15+60]
       jmp       short 000000000000176C
       mov       rdx,7FF82F1CE968
       call      00000000000087F0
       mov       rcx,rax
       call      qword ptr [3780]
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       jne       near ptr 00000000000014BF
       mov       ecx,825
       mov       rdx,7FF82EE11A08
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [0D450]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       jmp       near ptr 000000000000156A
       call      00000000000023D0
       int       3
; Total bytes of code 852
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			                                           ^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],sil
       call      qword ptr [3918]
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,0FFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,0
       or        rax,rdx
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,0
       or        rdx,rcx
       mov       rcx,0FFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[0CD8]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [0CE0]
       seta      al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr 00000000000003BE
       test      rsi,rsi
       je        near ptr 00000000000003CA
       mov       r14,[rdi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short 0000000000000301
       jmp       short 0000000000000316
       mov       rcx,rdi
       mov       rdx,7FF82F1CD100
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
       mov       r11,7FF82E9C07D0
       call      qword ptr [r11]
       test      eax,eax
       je        short 0000000000000389
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000033F
       jmp       short 0000000000000354
       mov       rcx,rdi
       mov       rdx,7FF82F1CD1D8
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short 0000000000000380
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82E9C07D0
       call      qword ptr [r11]
       test      eax,eax
       jne       short 0000000000000334
       jmp       short 0000000000000389
       mov       dword ptr [rbp+0FFD4],1
       jmp       short 00000000000003A7
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82E9C07D8
       call      qword ptr [r11]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       rcx,rsp
       call      00000000000003D6
       nop
       mov       eax,[rbp+0FFD4]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       ecx,10
       call      qword ptr [0B780]
       int       3
       mov       ecx,0C
       call      qword ptr [0B780]
       int       3
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFC8]
       test      rcx,rcx
       je        short 0000000000000403
       mov       r11,7FF82E9C07D8
       call      qword ptr [r11]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 335
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       r8,276C4952FF8
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      000000000000D578
       mov       rsi,[rsi+20]
       mov       rcx,276C495C718
       mov       r8,[rcx]
       test      r8,r8
       jne       short 000000000000DDDC
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rdi,rax
       mov       rdx,276C495C710
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      000000000000AEB0
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rdi+18],rdx
       mov       rcx,276C495C718
       mov       rdx,rdi
       call      000000000000B010
       mov       r8,rdi
       test      r8,r8
       jne       short 000000000000DDE5
       xor       edi,edi
       jmp       short 000000000000DDF9
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      0000000000003248
       mov       edi,eax
       mov       [rsi+54],dil
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 197
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000E62F
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       je        near ptr 000000000000E676
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short 000000000000E2F7
       jmp       short 000000000000E309
       mov       rdx,7FF82F524090
       call      0000000000002740
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000007440
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000E331
       mov       rcx,r14
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr 000000000000E593
       jmp       near ptr 000000000000E5A5
       mov       rcx,r14
       mov       rax,[r15+88]
       test      rax,rax
       je        short 000000000000E342
       jmp       short 000000000000E351
       mov       rdx,7FF82F5247A8
       call      0000000000002740
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000E31C
       mov       rcx,rdi
       mov       rdx,r12
       call      000000000000D6B0
       test      eax,eax
       je        short 000000000000E31C
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000E57B
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000E6AF
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
       mov       rdx,7FF82F524120
       call      0000000000002740
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      000000000000D820
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000E561
       test      rbp,rbp
       je        near ptr 000000000000E4B1
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr 000000000000E4B1
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000E6D7
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+80]
       test      r11,r11
       je        short 000000000000E447
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000E463
       mov       rdx,7FF82F524140
       call      0000000000002740
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000E49E
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000E6D7
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000E3FF
       jmp       near ptr 000000000000E561
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr 000000000000E6D7
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000E6D7
       lea       ecx,[r12+0FFFF]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+80]
       test      r11,r11
       je        short 000000000000E501
       mov       rax,[rsp+30]
       jmp       short 000000000000E518
       mov       rdx,7FF82F524140
       call      0000000000002740
       mov       r11,rax
       mov       rax,[rsp+30]
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000E553
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000E6D7
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000E4B1
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+68]
       test      r15,r15
       je        short 000000000000E5DF
       jmp       short 000000000000E5F0
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000E37C
       mov       rdx,7FF82F5240D0
       call      0000000000002740
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      000000000000D800
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000E61E
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+78]
       test      r12,r12
       je        near ptr 000000000000E399
       mov       rax,r12
       jmp       near ptr 000000000000E3A8
       mov       rdx,7FF82F524090
       call      0000000000002740
       jmp       short 000000000000E5F3
       mov       rax,r15
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      000000000000D6C0
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+60],0
       je        short 000000000000E64A
       mov       rcx,[r15+60]
       jmp       short 000000000000E65C
       mov       rdx,7FF82F524028
       call      0000000000002740
       mov       rcx,rax
       call      0000000000007360
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       jne       near ptr 000000000000E2DF
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FF82F17BD88
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      000000000000EB38
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       jmp       near ptr 000000000000E388
       call      000000000000F130
       int       3
; Total bytes of code 1085
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			                                           ^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      0000000000000538
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,0FFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,0
       or        rax,rdx
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,0
       or        rdx,rcx
       mov       rcx,0FFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[0DA98]
       vucomisd  xmm0,qword ptr [0DAA0]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr 000000000000CAEA
       test      rdi,rdi
       je        near ptr 000000000000CAF5
       mov       r14,[rsi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short 000000000000CA21
       jmp       short 000000000000CA36
       mov       rcx,rsi
       mov       rdx,7FF82F522B80
       call      0000000000004920
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
       mov       r11,7FF82EE90848
       call      qword ptr [848]
       test      eax,eax
       je        short 000000000000CAB2
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000CA62
       jmp       short 000000000000CA77
       mov       rcx,rsi
       mov       rdx,7FF82F522C58
       call      0000000000004920
       mov       r11,rax
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short 000000000000CAA9
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82EE90848
       call      qword ptr [848]
       test      eax,eax
       jne       short 000000000000CA57
       jmp       short 000000000000CAB2
       mov       dword ptr [rbp+0FFD4],1
       jmp       short 000000000000CAD3
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82EE90850
       call      qword ptr [850]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       rcx,rsp
       call      000000000000CB00
       nop
       mov       eax,[rbp+0FFD4]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       ecx,10
       call      000000000000B010
       int       3
       mov       ecx,0C
       call      000000000000B010
       int       3
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFC8]
       test      rcx,rcx
       je        short 000000000000CB30
       mov       r11,7FF82EE90850
       call      qword ptr [850]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 348
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       r8,1AD9EC03C10
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7708]
       mov       rsi,[rsi+20]
       mov       rdi,1AD9EC01F78
       mov       r8,[rdi]
       test      r8,r8
       jne       short 00000000000011D7
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rbp,rax
       mov       rdx,1AD9EC01F70
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      0000000000000010
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbp+18],rdx
       mov       rcx,rdi
       mov       rdx,rbp
       call      0000000000000010
       mov       r8,rbp
       test      r8,r8
       jne       short 00000000000011E0
       xor       edi,edi
       jmp       short 00000000000011F5
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      qword ptr [9B28]
       mov       edi,eax
       mov       [rsi+54],dil
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 194
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000155F
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       je        near ptr 00000000000015A7
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short 00000000000012F7
       jmp       short 0000000000001309
       mov       rdx,7FF82F1ADE48
       call      00000000000087F0
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5828]
       mov       r12,rax
       test      r12,r12
       jne       short 0000000000001332
       mov       rcx,r14
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr 00000000000014AB
       jmp       near ptr 00000000000014BD
       mov       rcx,r14
       mov       rax,[r15+88]
       test      rax,rax
       je        short 0000000000001343
       jmp       short 0000000000001352
       mov       rdx,7FF82F1AE560
       call      00000000000087F0
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000131D
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7AB0]
       test      eax,eax
       je        short 000000000000131D
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000142B
       cmp       dword ptr [r12+20],0
       jg        near ptr 00000000000015C5
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
       mov       rdx,7FF82F1ADED8
       call      00000000000087F0
       mov       rdx,rax
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7EA0]
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 0000000000001509
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr 00000000000015EE
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 00000000000015EE
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+80]
       test      r11,r11
       je        short 0000000000001443
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000145F
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000137E
       mov       rdx,7FF82F1ADEF8
       call      00000000000087F0
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000149D
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr 00000000000015EE
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      0000000000000010
       mov       r12d,[rsp+44]
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr 00000000000013DA
       jmp       short 0000000000001509
       mov       rdx,7FF82F1ADE88
       call      00000000000087F0
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7E70]
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000154E
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+78]
       test      rdx,rdx
       je        near ptr 000000000000139B
       jmp       near ptr 00000000000013AD
       mov       rdx,7FF82F1ADE48
       call      00000000000087F0
       mov       rdx,rax
       jmp       short 0000000000001522
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short 00000000000014F5
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [7AE0]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+60],0
       je        short 000000000000157A
       mov       rcx,[r15+60]
       jmp       short 000000000000158C
       mov       rdx,7FF82F1ADDE0
       call      00000000000087F0
       mov       rcx,rax
       call      qword ptr [3780]
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       jne       near ptr 00000000000012DF
       mov       ecx,825
       mov       rdx,7FF82EDF1A08
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [0D450]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       jmp       near ptr 000000000000138A
       call      00000000000023D0
       int       3
; Total bytes of code 852
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			                                           ^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],sil
       call      qword ptr [3918]
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,0FFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,0
       or        rax,rdx
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,0
       or        rdx,rcx
       mov       rcx,0FFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[0E98]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [0EA0]
       seta      al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr 00000000000000FE
       test      rsi,rsi
       je        near ptr 000000000000010A
       mov       r14,[rdi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short 0000000000000041
       jmp       short 0000000000000056
       mov       rcx,rdi
       mov       rdx,7FF82F1AC3C0
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
       mov       r11,7FF82E9A07C8
       call      qword ptr [r11]
       test      eax,eax
       je        short 00000000000000C9
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000007F
       jmp       short 0000000000000094
       mov       rcx,rdi
       mov       rdx,7FF82F1AC498
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short 00000000000000C0
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82E9A07C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short 0000000000000074
       jmp       short 00000000000000C9
       mov       dword ptr [rbp+0FFD4],1
       jmp       short 00000000000000E7
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82E9A07D0
       call      qword ptr [r11]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       rcx,rsp
       call      0000000000000116
       nop
       mov       eax,[rbp+0FFD4]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       ecx,10
       call      qword ptr [0B780]
       int       3
       mov       ecx,0C
       call      qword ptr [0B780]
       int       3
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFC8]
       test      rcx,rcx
       je        short 0000000000000143
       mov       r11,7FF82E9A07D0
       call      qword ptr [r11]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 335
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       r8,174BDF22FF8
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      0000000000000CE8
       mov       rsi,[rsi+20]
       mov       rcx,174BDF2C718
       mov       r8,[rcx]
       test      r8,r8
       jne       short 000000000000BB3C
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rdi,rax
       mov       rdx,174BDF2C710
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      000000000000AEB0
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rdi+18],rdx
       mov       rcx,174BDF2C718
       mov       rdx,rdi
       call      000000000000B010
       mov       r8,rdi
       test      r8,r8
       jne       short 000000000000BB45
       xor       edi,edi
       jmp       short 000000000000BB59
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      00000000000069B8
       mov       edi,eax
       mov       [rsi+54],dil
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 197
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000C64F
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       je        near ptr 000000000000C696
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short 000000000000C317
       jmp       short 000000000000C329
       mov       rdx,7FF82F5240C0
       call      0000000000002740
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000007440
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000C351
       mov       rcx,r14
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr 000000000000C5B3
       jmp       near ptr 000000000000C5C5
       mov       rcx,r14
       mov       rax,[r15+88]
       test      rax,rax
       je        short 000000000000C362
       jmp       short 000000000000C371
       mov       rdx,7FF82F5247D8
       call      0000000000002740
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000C33C
       mov       rcx,rdi
       mov       rdx,r12
       call      0000000000000E20
       test      eax,eax
       je        short 000000000000C33C
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000C59B
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000C6CF
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
       mov       rdx,7FF82F524150
       call      0000000000002740
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      0000000000000F90
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000C581
       test      rbp,rbp
       je        near ptr 000000000000C4D1
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr 000000000000C4D1
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000C6F7
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+80]
       test      r11,r11
       je        short 000000000000C467
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000C483
       mov       rdx,7FF82F524170
       call      0000000000002740
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000C4BE
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000C6F7
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000C41F
       jmp       near ptr 000000000000C581
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr 000000000000C6F7
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000C6F7
       lea       ecx,[r12+0FFFF]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+80]
       test      r11,r11
       je        short 000000000000C521
       mov       rax,[rsp+30]
       jmp       short 000000000000C538
       mov       rdx,7FF82F524170
       call      0000000000002740
       mov       r11,rax
       mov       rax,[rsp+30]
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000C573
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000C6F7
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000C4D1
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+68]
       test      r15,r15
       je        short 000000000000C5FF
       jmp       short 000000000000C610
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000C39C
       mov       rdx,7FF82F524100
       call      0000000000002740
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000000F70
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000C63E
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+78]
       test      r12,r12
       je        near ptr 000000000000C3B9
       mov       rax,r12
       jmp       near ptr 000000000000C3C8
       mov       rdx,7FF82F5240C0
       call      0000000000002740
       jmp       short 000000000000C613
       mov       rax,r15
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      0000000000000E30
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+60],0
       je        short 000000000000C66A
       mov       rcx,[r15+60]
       jmp       short 000000000000C67C
       mov       rdx,7FF82F524058
       call      0000000000002740
       mov       rcx,rax
       call      0000000000007360
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       jne       near ptr 000000000000C2FF
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FF82F17BD88
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      0000000000002368
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       jmp       near ptr 000000000000C3A8
       call      000000000000F130
       int       3
; Total bytes of code 1085
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			                                           ^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      0000000000000538
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,0FFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,0
       or        rax,rdx
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,0
       or        rdx,rcx
       mov       rcx,0FFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[0B7F8]
       vucomisd  xmm0,qword ptr [0B800]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr 000000000000AA8A
       test      rdi,rdi
       je        near ptr 000000000000AA95
       mov       r14,[rsi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short 000000000000A9C1
       jmp       short 000000000000A9D6
       mov       rcx,rsi
       mov       rdx,7FF82F522B10
       call      0000000000004920
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
       mov       r11,7FF82EE90848
       call      qword ptr [848]
       test      eax,eax
       je        short 000000000000AA52
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000AA02
       jmp       short 000000000000AA17
       mov       rcx,rsi
       mov       rdx,7FF82F522BE8
       call      0000000000004920
       mov       r11,rax
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short 000000000000AA49
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82EE90848
       call      qword ptr [848]
       test      eax,eax
       jne       short 000000000000A9F7
       jmp       short 000000000000AA52
       mov       dword ptr [rbp+0FFD4],1
       jmp       short 000000000000AA73
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82EE90850
       call      qword ptr [850]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       rcx,rsp
       call      000000000000AAA0
       nop
       mov       eax,[rbp+0FFD4]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       ecx,10
       call      000000000000B010
       int       3
       mov       ecx,0C
       call      000000000000B010
       int       3
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFC8]
       test      rcx,rcx
       je        short 000000000000AAD0
       mov       r11,7FF82EE90850
       call      qword ptr [850]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 348
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       r8,2794B408FC8
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [0F708]
       mov       rsi,[rsi+20]
       mov       rdi,2794B407328
       mov       r8,[rdi]
       test      r8,r8
       jne       short 000000000000D037
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rbp,rax
       mov       rdx,2794B407320
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      0000000000000010
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbp+18],rdx
       mov       rcx,rdi
       mov       rdx,rbp
       call      0000000000000010
       mov       r8,rbp
       test      r8,r8
       jne       short 000000000000D040
       xor       edi,edi
       jmp       short 000000000000D055
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Any(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      qword ptr [34F8]
       mov       edi,eax
       mov       [rsi+54],dil
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 194
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000D75C
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       je        near ptr 000000000000D7A4
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        short 000000000000D4F7
       jmp       short 000000000000D509
       mov       rdx,7FF82F226880
       call      00000000000087F0
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5828]
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000D532
       mov       rcx,r14
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr 000000000000D6A8
       jmp       near ptr 000000000000D6BA
       mov       rcx,r14
       mov       rax,[r15+80]
       test      rax,rax
       je        short 000000000000D543
       jmp       short 000000000000D552
       mov       rdx,7FF82F226F98
       call      00000000000087F0
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000D51D
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [0FAB0]
       test      eax,eax
       je        short 000000000000D51D
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000D628
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000D7C2
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
       mov       rdx,7FF82F226910
       call      00000000000087F0
       mov       rdx,rax
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [0FEA0]
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000D706
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr 000000000000D7EB
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000D7EB
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+78]
       test      r11,r11
       je        short 000000000000D640
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000D65C
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000D57E
       mov       rdx,7FF82F226930
       call      00000000000087F0
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000D69A
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr 000000000000D7EB
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      0000000000000010
       mov       r12d,[rsp+44]
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr 000000000000D5DA
       jmp       short 000000000000D706
       mov       rdx,7FF82F2268C0
       call      00000000000087F0
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [0FE70]
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000D74B
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr 000000000000D59B
       jmp       near ptr 000000000000D5AD
       mov       rdx,7FF82F226880
       call      00000000000087F0
       mov       rdx,rax
       jmp       short 000000000000D71F
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        short 000000000000D6F2
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [0FAE0]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+58],0
       je        short 000000000000D777
       mov       rcx,[r15+58]
       jmp       short 000000000000D789
       mov       rdx,7FF82F226818
       call      00000000000087F0
       mov       rcx,rax
       call      qword ptr [3780]
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       jne       near ptr 000000000000D4DF
       mov       ecx,825
       mov       rdx,7FF82EDF1A08
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [5450]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       jmp       near ptr 000000000000D58A
       call      00000000000023D0
       int       3
; Total bytes of code 849
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
; 			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 5));
; 			                                           ^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],sil
       call      qword ptr [3918]
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,0FFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,0
       or        rax,rdx
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,0
       or        rdx,rcx
       mov       rcx,0FFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[0EB38]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [0EB40]
       seta      al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr 000000000000E21E
       test      rsi,rsi
       je        near ptr 000000000000E22A
       mov       r14,[rdi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short 000000000000E161
       jmp       short 000000000000E176
       mov       rcx,rdi
       mov       rdx,7FF82F2287A0
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
       mov       r11,7FF82E9A08F8
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000E1E9
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000E19F
       jmp       short 000000000000E1B4
       mov       rcx,rdi
       mov       rdx,7FF82F228878
       call      0000000000000CA0
       mov       r11,rax
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short 000000000000E1E0
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82E9A08F8
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000E194
       jmp       short 000000000000E1E9
       mov       dword ptr [rbp+0FFD4],1
       jmp       short 000000000000E207
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF82E9A0900
       call      qword ptr [r11]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       rcx,rsp
       call      000000000000E236
       nop
       mov       eax,[rbp+0FFD4]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       ecx,10
       call      qword ptr [0B780]
       int       3
       mov       ecx,0C
       call      qword ptr [0B780]
       int       3
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFC8]
       test      rcx,rcx
       je        short 000000000000E263
       mov       r11,7FF82E9A0900
       call      qword ptr [r11]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 335
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.DoesNotHaveItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       r8,1B4A0992FF0
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      0000000000006928
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      0000000000001020
       test      eax,eax
       setle     al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 90
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000E026
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       je        near ptr 000000000000E06D
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000DCF7
       jmp       short 000000000000DD09
       mov       rdx,7FF82F51A378
       call      0000000000002740
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000007440
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000DD31
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 000000000000DF8A
       jmp       near ptr 000000000000DF9C
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 000000000000DD3F
       jmp       short 000000000000DD4E
       mov       rdx,7FF82F51AA90
       call      0000000000002740
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000DD1C
       mov       rcx,rdi
       mov       rdx,r12
       call      0000000000006A60
       test      eax,eax
       je        short 000000000000DD1C
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000DF72
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000E0A6
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
       mov       rdx,7FF82F51A408
       call      0000000000002740
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      0000000000006B98
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000DF58
       test      rbp,rbp
       je        near ptr 000000000000DEAB
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr 000000000000DEAB
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000E0CE
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000DE41
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000DE5D
       mov       rdx,7FF82F51A428
       call      0000000000002740
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000DE98
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000E0CE
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000DDFC
       jmp       near ptr 000000000000DF58
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr 000000000000E0CE
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000E0CE
       lea       ecx,[r12+0FFFF]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000DEF8
       mov       rax,[rsp+30]
       jmp       short 000000000000DF0F
       mov       rdx,7FF82F51A428
       call      0000000000002740
       mov       r11,rax
       mov       rax,[rsp+30]
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000DF4A
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000E0CE
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000DEAB
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+58]
       test      r15,r15
       je        short 000000000000DFD6
       jmp       short 000000000000DFE7
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000DD79
       mov       rdx,7FF82F51A3B8
       call      0000000000002740
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000006B78
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000E015
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+68]
       test      r12,r12
       je        near ptr 000000000000DD96
       mov       rax,r12
       jmp       near ptr 000000000000DDA5
       mov       rdx,7FF82F51A378
       call      0000000000002740
       jmp       short 000000000000DFEA
       mov       rax,r15
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      0000000000006A70
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 000000000000E041
       mov       rcx,[r15+50]
       jmp       short 000000000000E053
       mov       rdx,7FF82F51A310
       call      0000000000002740
       mov       rcx,rax
       call      0000000000007360
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       jne       near ptr 000000000000DCDF
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FF82F19BD88
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      0000000000007EB8
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       jmp       near ptr 000000000000DD85
       call      000000000000F130
       int       3
; Total bytes of code 1076
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 00000000000081F7
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      0000000000007438
       test      rax,rax
       je        short 000000000000822B
       mov       rcx,rax
       mov       r11,7FF82EEB06E0
       mov       rax,[6E0]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82EEB06D0
       call      qword ptr [6D0]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82EEB06D8
       call      qword ptr [6D8]
       test      eax,eax
       je        short 0000000000008276
       add       edi,1
       jo        short 000000000000827F
       mov       rcx,rsi
       mov       r11,7FF82EEB06D8
       call      qword ptr [6D8]
       test      eax,eax
       jne       short 000000000000825A
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      000000000000ECD0
       int       3
; Total bytes of code 165
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.DoesNotHaveItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       r8,1936D003C10
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [5708]
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      qword ptr [3048]
       test      eax,eax
       setle     al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 92
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000FD59
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       je        near ptr 000000000000FDA1
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000FAF7
       jmp       short 000000000000FB09
       mov       rdx,7FF82F1DD580
       call      00000000000087F0
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5828]
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000FB32
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 000000000000FCA5
       jmp       near ptr 000000000000FCB7
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 000000000000FB40
       jmp       short 000000000000FB4F
       mov       rdx,7FF82F1DDC98
       call      00000000000087F0
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000FB1D
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [5AB0]
       test      eax,eax
       je        short 000000000000FB1D
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000FC25
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000FDBF
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
       mov       rdx,7FF82F1DD610
       call      00000000000087F0
       mov       rdx,rax
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [5E58]
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000FD03
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr 000000000000FDE8
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000FDE8
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000FC3D
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000FC59
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000FB7B
       mov       rdx,7FF82F1DD630
       call      00000000000087F0
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000FC97
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr 000000000000FDE8
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      0000000000000010
       mov       r12d,[rsp+44]
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr 000000000000FBD7
       jmp       short 000000000000FD03
       mov       rdx,7FF82F1DD5C0
       call      00000000000087F0
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5E28]
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000FD48
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr 000000000000FB98
       jmp       near ptr 000000000000FBAA
       mov       rdx,7FF82F1DD580
       call      00000000000087F0
       mov       rdx,rax
       jmp       short 000000000000FD1C
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000FCEF
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [5AE0]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 000000000000FD74
       mov       rcx,[r15+50]
       jmp       short 000000000000FD86
       mov       rdx,7FF82F1DD518
       call      00000000000087F0
       mov       rcx,rax
       call      qword ptr [3780]
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       jne       near ptr 000000000000FADF
       mov       ecx,825
       mov       rdx,7FF82EE21A08
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [0B450]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       jmp       near ptr 000000000000FB87
       call      00000000000023D0
       int       3
; Total bytes of code 846
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 000000000000F4D7
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [5810]
       test      rax,rax
       je        short 000000000000F505
       mov       rcx,rax
       mov       r11,7FF82E9D07E8
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82E9D07D8
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82E9D07E0
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000F547
       add       edi,1
       jo        short 000000000000F550
       mov       rcx,rsi
       mov       r11,7FF82E9D07E0
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000F52E
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      0000000000002090
       int       3
; Total bytes of code 150
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.DoesNotHaveItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       r8,1C821AF2FF0
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      0000000000006928
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      0000000000001020
       test      eax,eax
       setle     al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 90
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000D586
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       je        near ptr 000000000000D5CD
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000D257
       jmp       short 000000000000D269
       mov       rdx,7FF82F4F90C0
       call      0000000000002740
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000007440
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000D291
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 000000000000D4EA
       jmp       near ptr 000000000000D4FC
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 000000000000D29F
       jmp       short 000000000000D2AE
       mov       rdx,7FF82F4F97D8
       call      0000000000002740
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000D27C
       mov       rcx,rdi
       mov       rdx,r12
       call      0000000000006A60
       test      eax,eax
       je        short 000000000000D27C
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000D4D2
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000D606
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
       mov       rdx,7FF82F4F9150
       call      0000000000002740
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      0000000000006B98
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000D4B8
       test      rbp,rbp
       je        near ptr 000000000000D40B
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr 000000000000D40B
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000D62E
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000D3A1
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000D3BD
       mov       rdx,7FF82F4F9170
       call      0000000000002740
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000D3F8
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000D62E
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000D35C
       jmp       near ptr 000000000000D4B8
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr 000000000000D62E
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000D62E
       lea       ecx,[r12+0FFFF]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000D458
       mov       rax,[rsp+30]
       jmp       short 000000000000D46F
       mov       rdx,7FF82F4F9170
       call      0000000000002740
       mov       r11,rax
       mov       rax,[rsp+30]
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000D4AA
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000D62E
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000D40B
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+58]
       test      r15,r15
       je        short 000000000000D536
       jmp       short 000000000000D547
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000D2D9
       mov       rdx,7FF82F4F9100
       call      0000000000002740
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000006B78
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000D575
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+68]
       test      r12,r12
       je        near ptr 000000000000D2F6
       mov       rax,r12
       jmp       near ptr 000000000000D305
       mov       rdx,7FF82F4F90C0
       call      0000000000002740
       jmp       short 000000000000D54A
       mov       rax,r15
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      0000000000006A70
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 000000000000D5A1
       mov       rcx,[r15+50]
       jmp       short 000000000000D5B3
       mov       rdx,7FF82F4F9058
       call      0000000000002740
       mov       rcx,rax
       call      0000000000007360
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       jne       near ptr 000000000000D23F
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FF82F17BD88
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      0000000000007EB8
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       jmp       near ptr 000000000000D2E5
       call      000000000000F130
       int       3
; Total bytes of code 1076
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 00000000000081F7
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      0000000000007438
       test      rax,rax
       je        short 000000000000822B
       mov       rcx,rax
       mov       r11,7FF82EE906E0
       mov       rax,[6E0]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82EE906D0
       call      qword ptr [6D0]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82EE906D8
       call      qword ptr [6D8]
       test      eax,eax
       je        short 0000000000008276
       add       edi,1
       jo        short 000000000000827F
       mov       rcx,rsi
       mov       r11,7FF82EE906D8
       call      qword ptr [6D8]
       test      eax,eax
       jne       short 000000000000825A
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      000000000000ECD0
       int       3
; Total bytes of code 165
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.DoesNotHaveItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       r8,18298405C08
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [9048]
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      qword ptr [3048]
       test      eax,eax
       setle     al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 92
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 00000000000003F9
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       je        near ptr 0000000000000441
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 0000000000000197
       jmp       short 00000000000001A9
       mov       rdx,7FF82F1BCE68
       call      00000000000087F0
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5828]
       mov       r12,rax
       test      r12,r12
       jne       short 00000000000001D2
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 0000000000000345
       jmp       near ptr 0000000000000357
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 00000000000001E0
       jmp       short 00000000000001EF
       mov       rdx,7FF82F1BD580
       call      00000000000087F0
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 00000000000001BD
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [93F0]
       test      eax,eax
       je        short 00000000000001BD
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 00000000000002C5
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000045F
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
       mov       rdx,7FF82F1BCEF8
       call      00000000000087F0
       mov       rdx,rax
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [9798]
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 00000000000003A3
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr 0000000000000488
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 0000000000000488
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 00000000000002DD
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 00000000000002F9
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000021B
       mov       rdx,7FF82F1BCF18
       call      00000000000087F0
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 0000000000000337
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr 0000000000000488
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      0000000000000010
       mov       r12d,[rsp+44]
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr 0000000000000277
       jmp       short 00000000000003A3
       mov       rdx,7FF82F1BCEA8
       call      00000000000087F0
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [9768]
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 00000000000003E8
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr 0000000000000238
       jmp       near ptr 000000000000024A
       mov       rdx,7FF82F1BCE68
       call      00000000000087F0
       mov       rdx,rax
       jmp       short 00000000000003BC
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000038F
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [9420]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 0000000000000414
       mov       rcx,[r15+50]
       jmp       short 0000000000000426
       mov       rdx,7FF82F1BCE00
       call      00000000000087F0
       mov       rcx,rax
       call      qword ptr [3780]
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       jne       near ptr 000000000000017F
       mov       ecx,825
       mov       rdx,7FF82EE01A08
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [0DD98]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       jmp       near ptr 0000000000000227
       call      00000000000023D0
       int       3
; Total bytes of code 846
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 000000000000FB77
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [5810]
       test      rax,rax
       je        short 000000000000FBA5
       mov       rcx,rax
       mov       r11,7FF82E9B07E8
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82E9B07D8
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82E9B07E0
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000FBE7
       add       edi,1
       jo        short 000000000000FBF0
       mov       rcx,rsi
       mov       r11,7FF82E9B07E0
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000FBCE
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      0000000000002090
       int       3
; Total bytes of code 150
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.DoesNotHaveItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       r8,1390EE72FF0
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      0000000000006928
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      0000000000001020
       test      eax,eax
       setle     al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 90
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000E5C6
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       je        near ptr 000000000000E60D
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000E297
       jmp       short 000000000000E2A9
       mov       rdx,7FF82F51A8B0
       call      0000000000002740
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000007440
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000E2D1
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 000000000000E52A
       jmp       near ptr 000000000000E53C
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 000000000000E2DF
       jmp       short 000000000000E2EE
       mov       rdx,7FF82F51AFC8
       call      0000000000002740
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000E2BC
       mov       rcx,rdi
       mov       rdx,r12
       call      0000000000006A60
       test      eax,eax
       je        short 000000000000E2BC
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000E512
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000E646
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
       mov       rdx,7FF82F51A940
       call      0000000000002740
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      0000000000006B98
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000E4F8
       test      rbp,rbp
       je        near ptr 000000000000E44B
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr 000000000000E44B
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000E66E
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000E3E1
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000E3FD
       mov       rdx,7FF82F51A960
       call      0000000000002740
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000E438
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000E66E
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000E39C
       jmp       near ptr 000000000000E4F8
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr 000000000000E66E
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000E66E
       lea       ecx,[r12+0FFFF]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000E498
       mov       rax,[rsp+30]
       jmp       short 000000000000E4AF
       mov       rdx,7FF82F51A960
       call      0000000000002740
       mov       r11,rax
       mov       rax,[rsp+30]
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000E4EA
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000E66E
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000E44B
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+58]
       test      r15,r15
       je        short 000000000000E576
       jmp       short 000000000000E587
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000E319
       mov       rdx,7FF82F51A8F0
       call      0000000000002740
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000006B78
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000E5B5
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+68]
       test      r12,r12
       je        near ptr 000000000000E336
       mov       rax,r12
       jmp       near ptr 000000000000E345
       mov       rdx,7FF82F51A8B0
       call      0000000000002740
       jmp       short 000000000000E58A
       mov       rax,r15
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      0000000000006A70
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 000000000000E5E1
       mov       rcx,[r15+50]
       jmp       short 000000000000E5F3
       mov       rdx,7FF82F51A848
       call      0000000000002740
       mov       rcx,rax
       call      0000000000007360
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       jne       near ptr 000000000000E27F
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FF82F19BD88
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      0000000000007EB8
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       jmp       near ptr 000000000000E325
       call      000000000000F130
       int       3
; Total bytes of code 1076
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 00000000000081F7
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      0000000000007438
       test      rax,rax
       je        short 000000000000822B
       mov       rcx,rax
       mov       r11,7FF82EEB06E0
       mov       rax,[6E0]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82EEB06D0
       call      qword ptr [6D0]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82EEB06D8
       call      qword ptr [6D8]
       test      eax,eax
       je        short 0000000000008276
       add       edi,1
       jo        short 000000000000827F
       mov       rcx,rsi
       mov       r11,7FF82EEB06D8
       call      qword ptr [6D8]
       test      eax,eax
       jne       short 000000000000825A
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      000000000000ECD0
       int       3
; Total bytes of code 165
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.DoesNotHaveItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       r8,1F828403C10
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [9048]
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      qword ptr [3048]
       test      eax,eax
       setle     al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 92
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 00000000000003F9
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       je        near ptr 0000000000000441
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 0000000000000197
       jmp       short 00000000000001A9
       mov       rdx,7FF82F1CCE68
       call      00000000000087F0
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5828]
       mov       r12,rax
       test      r12,r12
       jne       short 00000000000001D2
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 0000000000000345
       jmp       near ptr 0000000000000357
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 00000000000001E0
       jmp       short 00000000000001EF
       mov       rdx,7FF82F1CD580
       call      00000000000087F0
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 00000000000001BD
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [93F0]
       test      eax,eax
       je        short 00000000000001BD
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 00000000000002C5
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000045F
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
       mov       rdx,7FF82F1CCEF8
       call      00000000000087F0
       mov       rdx,rax
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [9798]
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 00000000000003A3
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr 0000000000000488
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 0000000000000488
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 00000000000002DD
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 00000000000002F9
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000021B
       mov       rdx,7FF82F1CCF18
       call      00000000000087F0
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 0000000000000337
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr 0000000000000488
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      0000000000000010
       mov       r12d,[rsp+44]
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr 0000000000000277
       jmp       short 00000000000003A3
       mov       rdx,7FF82F1CCEA8
       call      00000000000087F0
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [9768]
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 00000000000003E8
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr 0000000000000238
       jmp       near ptr 000000000000024A
       mov       rdx,7FF82F1CCE68
       call      00000000000087F0
       mov       rdx,rax
       jmp       short 00000000000003BC
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000038F
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [9420]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 0000000000000414
       mov       rcx,[r15+50]
       jmp       short 0000000000000426
       mov       rdx,7FF82F1CCE00
       call      00000000000087F0
       mov       rcx,rax
       call      qword ptr [3780]
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       jne       near ptr 000000000000017F
       mov       ecx,825
       mov       rdx,7FF82EE11A08
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [0DD98]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       jmp       near ptr 0000000000000227
       call      00000000000023D0
       int       3
; Total bytes of code 846
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 000000000000FB77
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [5810]
       test      rax,rax
       je        short 000000000000FBA5
       mov       rcx,rax
       mov       r11,7FF82E9C07E8
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82E9C07D8
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82E9C07E0
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000FBE7
       add       edi,1
       jo        short 000000000000FBF0
       mov       rcx,rsi
       mov       r11,7FF82E9C07E0
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000FBCE
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      0000000000002090
       int       3
; Total bytes of code 150
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.DoesNotHaveItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       r8,1EE4E222FF0
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      00000000000068D8
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      0000000000001020
       test      eax,eax
       setle     al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 90
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000E506
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       je        near ptr 000000000000E54D
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000E1D7
       jmp       short 000000000000E1E9
       mov       rdx,7FF82F50A8B0
       call      0000000000002740
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000007440
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000E211
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 000000000000E46A
       jmp       near ptr 000000000000E47C
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 000000000000E21F
       jmp       short 000000000000E22E
       mov       rdx,7FF82F50AFC8
       call      0000000000002740
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000E1FC
       mov       rcx,rdi
       mov       rdx,r12
       call      0000000000006A10
       test      eax,eax
       je        short 000000000000E1FC
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000E452
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000E586
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
       mov       rdx,7FF82F50A940
       call      0000000000002740
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      0000000000007050
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000E438
       test      rbp,rbp
       je        near ptr 000000000000E38B
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr 000000000000E38B
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000E5AE
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000E321
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000E33D
       mov       rdx,7FF82F50A960
       call      0000000000002740
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000E378
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000E5AE
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000E2DC
       jmp       near ptr 000000000000E438
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr 000000000000E5AE
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000E5AE
       lea       ecx,[r12+0FFFF]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000E3D8
       mov       rax,[rsp+30]
       jmp       short 000000000000E3EF
       mov       rdx,7FF82F50A960
       call      0000000000002740
       mov       r11,rax
       mov       rax,[rsp+30]
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000E42A
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000E5AE
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000E38B
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+58]
       test      r15,r15
       je        short 000000000000E4B6
       jmp       short 000000000000E4C7
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000E259
       mov       rdx,7FF82F50A8F0
       call      0000000000002740
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000006B60
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000E4F5
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+68]
       test      r12,r12
       je        near ptr 000000000000E276
       mov       rax,r12
       jmp       near ptr 000000000000E285
       mov       rdx,7FF82F50A8B0
       call      0000000000002740
       jmp       short 000000000000E4CA
       mov       rax,r15
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      0000000000006A20
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 000000000000E521
       mov       rcx,[r15+50]
       jmp       short 000000000000E533
       mov       rdx,7FF82F50A848
       call      0000000000002740
       mov       rcx,rax
       call      0000000000007360
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       jne       near ptr 000000000000E1BF
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FF82F18BD88
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      0000000000007E08
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       jmp       near ptr 000000000000E265
       call      000000000000F130
       int       3
; Total bytes of code 1076
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 0000000000008137
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      0000000000007438
       test      rax,rax
       je        short 000000000000816B
       mov       rcx,rax
       mov       r11,7FF82EEA06E0
       mov       rax,[6E0]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82EEA06D0
       call      qword ptr [6D0]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82EEA06D8
       call      qword ptr [6D8]
       test      eax,eax
       je        short 00000000000081B6
       add       edi,1
       jo        short 00000000000081BF
       mov       rcx,rsi
       mov       r11,7FF82EEA06D8
       call      qword ptr [6D8]
       test      eax,eax
       jne       short 000000000000819A
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      000000000000ECD0
       int       3
; Total bytes of code 165
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.DoesNotHaveItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       r8,1F2D780B3D0
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7708]
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      qword ptr [3048]
       test      eax,eax
       setle     al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 92
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 00000000000003F9
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       je        near ptr 0000000000000441
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 0000000000000197
       jmp       short 00000000000001A9
       mov       rdx,7FF82F1BCE68
       call      00000000000087F0
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5828]
       mov       r12,rax
       test      r12,r12
       jne       short 00000000000001D2
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 0000000000000345
       jmp       near ptr 0000000000000357
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 00000000000001E0
       jmp       short 00000000000001EF
       mov       rdx,7FF82F1BD580
       call      00000000000087F0
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 00000000000001BD
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7AB0]
       test      eax,eax
       je        short 00000000000001BD
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 00000000000002C5
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000045F
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
       mov       rdx,7FF82F1BCEF8
       call      00000000000087F0
       mov       rdx,rax
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7E58]
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 00000000000003A3
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr 0000000000000488
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 0000000000000488
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 00000000000002DD
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 00000000000002F9
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000021B
       mov       rdx,7FF82F1BCF18
       call      00000000000087F0
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 0000000000000337
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr 0000000000000488
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      0000000000000010
       mov       r12d,[rsp+44]
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr 0000000000000277
       jmp       short 00000000000003A3
       mov       rdx,7FF82F1BCEA8
       call      00000000000087F0
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7E28]
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 00000000000003E8
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr 0000000000000238
       jmp       near ptr 000000000000024A
       mov       rdx,7FF82F1BCE68
       call      00000000000087F0
       mov       rdx,rax
       jmp       short 00000000000003BC
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000038F
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [7AE0]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 0000000000000414
       mov       rcx,[r15+50]
       jmp       short 0000000000000426
       mov       rdx,7FF82F1BCE00
       call      00000000000087F0
       mov       rcx,rax
       call      qword ptr [3780]
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       jne       near ptr 000000000000017F
       mov       ecx,825
       mov       rdx,7FF82EE01A08
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [0D450]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       jmp       near ptr 0000000000000227
       call      00000000000023D0
       int       3
; Total bytes of code 846
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 000000000000FB77
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [5810]
       test      rax,rax
       je        short 000000000000FBA5
       mov       rcx,rax
       mov       r11,7FF82E9B07E8
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82E9B07D8
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82E9B07E0
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000FBE7
       add       edi,1
       jo        short 000000000000FBF0
       mov       rcx,rsi
       mov       r11,7FF82E9B07E0
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000FBCE
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      0000000000002090
       int       3
; Total bytes of code 150
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.DoesNotHaveItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       r8,2922A522FF0
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      00000000000068D8
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      0000000000001020
       test      eax,eax
       setle     al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 90
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000E506
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       je        near ptr 000000000000E54D
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000E1D7
       jmp       short 000000000000E1E9
       mov       rdx,7FF82F4FA8B0
       call      0000000000002740
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000007440
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000E211
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 000000000000E46A
       jmp       near ptr 000000000000E47C
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 000000000000E21F
       jmp       short 000000000000E22E
       mov       rdx,7FF82F4FAFC8
       call      0000000000002740
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000E1FC
       mov       rcx,rdi
       mov       rdx,r12
       call      0000000000006A10
       test      eax,eax
       je        short 000000000000E1FC
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000E452
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000E586
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
       mov       rdx,7FF82F4FA940
       call      0000000000002740
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      0000000000007050
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000E438
       test      rbp,rbp
       je        near ptr 000000000000E38B
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr 000000000000E38B
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000E5AE
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000E321
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000E33D
       mov       rdx,7FF82F4FA960
       call      0000000000002740
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000E378
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000E5AE
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000E2DC
       jmp       near ptr 000000000000E438
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr 000000000000E5AE
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000E5AE
       lea       ecx,[r12+0FFFF]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000E3D8
       mov       rax,[rsp+30]
       jmp       short 000000000000E3EF
       mov       rdx,7FF82F4FA960
       call      0000000000002740
       mov       r11,rax
       mov       rax,[rsp+30]
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000E42A
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000E5AE
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000E38B
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+58]
       test      r15,r15
       je        short 000000000000E4B6
       jmp       short 000000000000E4C7
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000E259
       mov       rdx,7FF82F4FA8F0
       call      0000000000002740
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000006B60
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000E4F5
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+68]
       test      r12,r12
       je        near ptr 000000000000E276
       mov       rax,r12
       jmp       near ptr 000000000000E285
       mov       rdx,7FF82F4FA8B0
       call      0000000000002740
       jmp       short 000000000000E4CA
       mov       rax,r15
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      0000000000006A20
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 000000000000E521
       mov       rcx,[r15+50]
       jmp       short 000000000000E533
       mov       rdx,7FF82F4FA848
       call      0000000000002740
       mov       rcx,rax
       call      0000000000007360
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       jne       near ptr 000000000000E1BF
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FF82F17BD88
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      0000000000007E08
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       jmp       near ptr 000000000000E265
       call      000000000000F130
       int       3
; Total bytes of code 1076
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 0000000000008137
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      0000000000007438
       test      rax,rax
       je        short 000000000000816B
       mov       rcx,rax
       mov       r11,7FF82EE906E0
       mov       rax,[6E0]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82EE906D0
       call      qword ptr [6D0]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82EE906D8
       call      qword ptr [6D8]
       test      eax,eax
       je        short 00000000000081B6
       add       edi,1
       jo        short 00000000000081BF
       mov       rcx,rsi
       mov       r11,7FF82EE906D8
       call      qword ptr [6D8]
       test      eax,eax
       jne       short 000000000000819A
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      000000000000ECD0
       int       3
; Total bytes of code 165
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.DoesNotHaveItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       r8,21F75008FC0
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7708]
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      qword ptr [3048]
       test      eax,eax
       setle     al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 92
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 00000000000003D9
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       je        near ptr 0000000000000421
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 0000000000000177
       jmp       short 0000000000000189
       mov       rdx,7FF82F1DCE78
       call      00000000000087F0
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5828]
       mov       r12,rax
       test      r12,r12
       jne       short 00000000000001B2
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 0000000000000325
       jmp       near ptr 0000000000000337
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 00000000000001C0
       jmp       short 00000000000001CF
       mov       rdx,7FF82F1DD590
       call      00000000000087F0
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000019D
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7AB0]
       test      eax,eax
       je        short 000000000000019D
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 00000000000002A5
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000043F
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
       mov       rdx,7FF82F1DCF08
       call      00000000000087F0
       mov       rdx,rax
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7E58]
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 0000000000000383
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr 0000000000000468
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 0000000000000468
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 00000000000002BD
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 00000000000002D9
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 00000000000001FB
       mov       rdx,7FF82F1DCF28
       call      00000000000087F0
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 0000000000000317
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr 0000000000000468
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      0000000000000010
       mov       r12d,[rsp+44]
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr 0000000000000257
       jmp       short 0000000000000383
       mov       rdx,7FF82F1DCEB8
       call      00000000000087F0
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7E28]
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 00000000000003C8
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr 0000000000000218
       jmp       near ptr 000000000000022A
       mov       rdx,7FF82F1DCE78
       call      00000000000087F0
       mov       rdx,rax
       jmp       short 000000000000039C
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000036F
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [7AE0]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 00000000000003F4
       mov       rcx,[r15+50]
       jmp       short 0000000000000406
       mov       rdx,7FF82F1DCE10
       call      00000000000087F0
       mov       rcx,rax
       call      qword ptr [3780]
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       jne       near ptr 000000000000015F
       mov       ecx,825
       mov       rdx,7FF82EE21A08
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [0D450]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       jmp       near ptr 0000000000000207
       call      00000000000023D0
       int       3
; Total bytes of code 846
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 000000000000FB57
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [5810]
       test      rax,rax
       je        short 000000000000FB85
       mov       rcx,rax
       mov       r11,7FF82E9D07E8
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82E9D07D8
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82E9D07E0
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000FBC7
       add       edi,1
       jo        short 000000000000FBD0
       mov       rcx,rsi
       mov       r11,7FF82E9D07E0
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000FBAE
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      0000000000002090
       int       3
; Total bytes of code 150
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.DoesNotHaveItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       r8,2BD073A2FF0
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      00000000000068D8
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      0000000000001020
       test      eax,eax
       setle     al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 90
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000DCC6
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       je        near ptr 000000000000DD0D
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000D997
       jmp       short 000000000000D9A9
       mov       rdx,7FF82F509BD0
       call      0000000000002740
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000007440
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000D9D1
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 000000000000DC2A
       jmp       near ptr 000000000000DC3C
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 000000000000D9DF
       jmp       short 000000000000D9EE
       mov       rdx,7FF82F50A2E8
       call      0000000000002740
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000D9BC
       mov       rcx,rdi
       mov       rdx,r12
       call      0000000000006A10
       test      eax,eax
       je        short 000000000000D9BC
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000DC12
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000DD46
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
       mov       rdx,7FF82F509C60
       call      0000000000002740
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      0000000000007050
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000DBF8
       test      rbp,rbp
       je        near ptr 000000000000DB4B
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr 000000000000DB4B
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000DD6E
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000DAE1
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000DAFD
       mov       rdx,7FF82F509C80
       call      0000000000002740
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000DB38
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000DD6E
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000DA9C
       jmp       near ptr 000000000000DBF8
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr 000000000000DD6E
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000DD6E
       lea       ecx,[r12+0FFFF]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000DB98
       mov       rax,[rsp+30]
       jmp       short 000000000000DBAF
       mov       rdx,7FF82F509C80
       call      0000000000002740
       mov       r11,rax
       mov       rax,[rsp+30]
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000DBEA
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000DD6E
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000DB4B
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+58]
       test      r15,r15
       je        short 000000000000DC76
       jmp       short 000000000000DC87
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000DA19
       mov       rdx,7FF82F509C10
       call      0000000000002740
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000006B60
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000DCB5
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+68]
       test      r12,r12
       je        near ptr 000000000000DA36
       mov       rax,r12
       jmp       near ptr 000000000000DA45
       mov       rdx,7FF82F509BD0
       call      0000000000002740
       jmp       short 000000000000DC8A
       mov       rax,r15
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      0000000000006A20
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 000000000000DCE1
       mov       rcx,[r15+50]
       jmp       short 000000000000DCF3
       mov       rdx,7FF82F509B68
       call      0000000000002740
       mov       rcx,rax
       call      0000000000007360
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       jne       near ptr 000000000000D97F
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FF82F18BD88
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      0000000000007E08
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       jmp       near ptr 000000000000DA25
       call      000000000000F130
       int       3
; Total bytes of code 1076
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 0000000000008137
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      0000000000007438
       test      rax,rax
       je        short 000000000000816B
       mov       rcx,rax
       mov       r11,7FF82EEA06E0
       mov       rax,[6E0]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82EEA06D0
       call      qword ptr [6D0]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82EEA06D8
       call      qword ptr [6D8]
       test      eax,eax
       je        short 00000000000081B6
       add       edi,1
       jo        short 00000000000081BF
       mov       rcx,rsi
       mov       r11,7FF82EEA06D8
       call      qword ptr [6D8]
       test      eax,eax
       jne       short 000000000000819A
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      000000000000ECD0
       int       3
; Total bytes of code 165
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.DoesNotHaveItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       r8,1BA65008FC0
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7708]
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      qword ptr [3048]
       test      eax,eax
       setle     al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 92
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 0000000000000219
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       je        near ptr 0000000000000261
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000FFB7
       jmp       short 000000000000FFC9
       mov       rdx,7FF82F1CC238
       call      00000000000087F0
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5828]
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000FFF2
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 0000000000000165
       jmp       near ptr 0000000000000177
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 0
       jmp       short 000000000000000F
       mov       rdx,7FF82F1CC950
       call      00000000000087F0
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000FFDD
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7AB0]
       test      eax,eax
       je        short 000000000000FFDD
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 00000000000000E5
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000027F
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
       mov       rdx,7FF82F1CC2C8
       call      00000000000087F0
       mov       rdx,rax
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7E58]
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 00000000000001C3
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr 00000000000002A8
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 00000000000002A8
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 00000000000000FD
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 0000000000000119
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000003B
       mov       rdx,7FF82F1CC2E8
       call      00000000000087F0
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 0000000000000157
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr 00000000000002A8
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      0000000000000010
       mov       r12d,[rsp+44]
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr 0000000000000097
       jmp       short 00000000000001C3
       mov       rdx,7FF82F1CC278
       call      00000000000087F0
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7E28]
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 0000000000000208
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr 0000000000000058
       jmp       near ptr 000000000000006A
       mov       rdx,7FF82F1CC238
       call      00000000000087F0
       mov       rdx,rax
       jmp       short 00000000000001DC
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 00000000000001AF
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [7AE0]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 0000000000000234
       mov       rcx,[r15+50]
       jmp       short 0000000000000246
       mov       rdx,7FF82F1CC1D0
       call      00000000000087F0
       mov       rcx,rax
       call      qword ptr [3780]
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       jne       near ptr 000000000000FF9F
       mov       ecx,825
       mov       rdx,7FF82EE11A08
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [0D450]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       jmp       near ptr 0000000000000047
       call      00000000000023D0
       int       3
; Total bytes of code 846
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 000000000000FD37
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [5810]
       test      rax,rax
       je        short 000000000000FD65
       mov       rcx,rax
       mov       r11,7FF82E9C07E0
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82E9C07D0
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82E9C07D8
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000FDA7
       add       edi,1
       jo        short 000000000000FDB0
       mov       rcx,rsi
       mov       r11,7FF82E9C07D8
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000FD8E
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      0000000000002090
       int       3
; Total bytes of code 150
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.DoesNotHaveItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       r8,20413F72FF0
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      0000000000006928
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      0000000000001020
       test      eax,eax
       setle     al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 90
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000DD86
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       je        near ptr 000000000000DDCD
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000DA57
       jmp       short 000000000000DA69
       mov       rdx,7FF82F4F9BD0
       call      0000000000002740
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000007440
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000DA91
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 000000000000DCEA
       jmp       near ptr 000000000000DCFC
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 000000000000DA9F
       jmp       short 000000000000DAAE
       mov       rdx,7FF82F4FA2E8
       call      0000000000002740
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000DA7C
       mov       rcx,rdi
       mov       rdx,r12
       call      0000000000006A60
       test      eax,eax
       je        short 000000000000DA7C
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000DCD2
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000DE06
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
       mov       rdx,7FF82F4F9C60
       call      0000000000002740
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      0000000000006B98
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000DCB8
       test      rbp,rbp
       je        near ptr 000000000000DC0B
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr 000000000000DC0B
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000DE2E
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000DBA1
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000DBBD
       mov       rdx,7FF82F4F9C80
       call      0000000000002740
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000DBF8
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000DE2E
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000DB5C
       jmp       near ptr 000000000000DCB8
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr 000000000000DE2E
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000DE2E
       lea       ecx,[r12+0FFFF]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000DC58
       mov       rax,[rsp+30]
       jmp       short 000000000000DC6F
       mov       rdx,7FF82F4F9C80
       call      0000000000002740
       mov       r11,rax
       mov       rax,[rsp+30]
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000DCAA
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000DE2E
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000DC0B
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+58]
       test      r15,r15
       je        short 000000000000DD36
       jmp       short 000000000000DD47
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000DAD9
       mov       rdx,7FF82F4F9C10
       call      0000000000002740
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000006B78
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000DD75
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+68]
       test      r12,r12
       je        near ptr 000000000000DAF6
       mov       rax,r12
       jmp       near ptr 000000000000DB05
       mov       rdx,7FF82F4F9BD0
       call      0000000000002740
       jmp       short 000000000000DD4A
       mov       rax,r15
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      0000000000006A70
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 000000000000DDA1
       mov       rcx,[r15+50]
       jmp       short 000000000000DDB3
       mov       rdx,7FF82F4F9B68
       call      0000000000002740
       mov       rcx,rax
       call      0000000000007360
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       jne       near ptr 000000000000DA3F
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FF82F17BD88
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      0000000000007EB8
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       jmp       near ptr 000000000000DAE5
       call      000000000000F130
       int       3
; Total bytes of code 1076
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 00000000000081F7
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      0000000000007438
       test      rax,rax
       je        short 000000000000822B
       mov       rcx,rax
       mov       r11,7FF82EE906E0
       mov       rax,[6E0]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82EE906D0
       call      qword ptr [6D0]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82EE906D8
       call      qword ptr [6D8]
       test      eax,eax
       je        short 0000000000008276
       add       edi,1
       jo        short 000000000000827F
       mov       rcx,rsi
       mov       r11,7FF82EE906D8
       call      qword ptr [6D8]
       test      eax,eax
       jne       short 000000000000825A
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      000000000000ECD0
       int       3
; Total bytes of code 165
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.DoesNotHaveItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       r8,2283E00D3C8
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7708]
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      qword ptr [3048]
       test      eax,eax
       setle     al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 92
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 0000000000000219
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       je        near ptr 0000000000000261
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000FFB7
       jmp       short 000000000000FFC9
       mov       rdx,7FF82F1CC298
       call      00000000000087F0
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5828]
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000FFF2
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 0000000000000165
       jmp       near ptr 0000000000000177
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 0
       jmp       short 000000000000000F
       mov       rdx,7FF82F1CC9B0
       call      00000000000087F0
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000FFDD
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7AB0]
       test      eax,eax
       je        short 000000000000FFDD
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 00000000000000E5
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000027F
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
       mov       rdx,7FF82F1CC328
       call      00000000000087F0
       mov       rdx,rax
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7E58]
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 00000000000001C3
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr 00000000000002A8
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 00000000000002A8
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 00000000000000FD
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 0000000000000119
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000003B
       mov       rdx,7FF82F1CC348
       call      00000000000087F0
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 0000000000000157
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr 00000000000002A8
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      0000000000000010
       mov       r12d,[rsp+44]
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr 0000000000000097
       jmp       short 00000000000001C3
       mov       rdx,7FF82F1CC2D8
       call      00000000000087F0
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7E28]
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 0000000000000208
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr 0000000000000058
       jmp       near ptr 000000000000006A
       mov       rdx,7FF82F1CC298
       call      00000000000087F0
       mov       rdx,rax
       jmp       short 00000000000001DC
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 00000000000001AF
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [7AE0]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 0000000000000234
       mov       rcx,[r15+50]
       jmp       short 0000000000000246
       mov       rdx,7FF82F1CC230
       call      00000000000087F0
       mov       rcx,rax
       call      qword ptr [3780]
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       jne       near ptr 000000000000FF9F
       mov       ecx,825
       mov       rdx,7FF82EE11A08
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [0D450]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       jmp       near ptr 0000000000000047
       call      00000000000023D0
       int       3
; Total bytes of code 846
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 000000000000FD37
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [5810]
       test      rax,rax
       je        short 000000000000FD65
       mov       rcx,rax
       mov       r11,7FF82E9C07E0
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82E9C07D0
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82E9C07D8
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000FDA7
       add       edi,1
       jo        short 000000000000FDB0
       mov       rcx,rsi
       mov       r11,7FF82E9C07D8
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000FD8E
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      0000000000002090
       int       3
; Total bytes of code 150
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.DoesNotHaveItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       r8,15CA06D2FF8
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      0000000000000F88
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      0000000000001020
       test      eax,eax
       setle     al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 90
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000B386
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       je        near ptr 000000000000B3CD
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000B057
       jmp       short 000000000000B069
       mov       rdx,7FF82F542758
       call      0000000000002740
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000007440
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000B091
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 000000000000B2EA
       jmp       near ptr 000000000000B2FC
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 000000000000B09F
       jmp       short 000000000000B0AE
       mov       rdx,7FF82F542E70
       call      0000000000002740
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000B07C
       mov       rcx,rdi
       mov       rdx,r12
       call      00000000000010C0
       test      eax,eax
       je        short 000000000000B07C
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000B2D2
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000B406
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
       mov       rdx,7FF82F5427E8
       call      0000000000002740
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      0000000000001208
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000B2B8
       test      rbp,rbp
       je        near ptr 000000000000B20B
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr 000000000000B20B
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000B42E
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000B1A1
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000B1BD
       mov       rdx,7FF82F542808
       call      0000000000002740
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000B1F8
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000B42E
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000B15C
       jmp       near ptr 000000000000B2B8
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr 000000000000B42E
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000B42E
       lea       ecx,[r12+0FFFF]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000B258
       mov       rax,[rsp+30]
       jmp       short 000000000000B26F
       mov       rdx,7FF82F542808
       call      0000000000002740
       mov       r11,rax
       mov       rax,[rsp+30]
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000B2AA
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000B42E
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000B20B
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+58]
       test      r15,r15
       je        short 000000000000B336
       jmp       short 000000000000B347
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000B0D9
       mov       rdx,7FF82F542798
       call      0000000000002740
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      00000000000011E8
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000B375
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+68]
       test      r12,r12
       je        near ptr 000000000000B0F6
       mov       rax,r12
       jmp       near ptr 000000000000B105
       mov       rdx,7FF82F542758
       call      0000000000002740
       jmp       short 000000000000B34A
       mov       rax,r15
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      00000000000010D0
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 000000000000B3A1
       mov       rcx,[r15+50]
       jmp       short 000000000000B3B3
       mov       rdx,7FF82F5426F0
       call      0000000000002740
       mov       rcx,rax
       call      0000000000007360
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       jne       near ptr 000000000000B03F
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FF82F19BD88
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      0000000000002518
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       jmp       near ptr 000000000000B0E5
       call      000000000000F130
       int       3
; Total bytes of code 1076
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 0000000000002857
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      0000000000007438
       test      rax,rax
       je        short 000000000000288B
       mov       rcx,rax
       mov       r11,7FF82EEB06E0
       mov       rax,[6E0]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82EEB06D0
       call      qword ptr [6D0]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82EEB06D8
       call      qword ptr [6D8]
       test      eax,eax
       je        short 00000000000028D6
       add       edi,1
       jo        short 00000000000028DF
       mov       rcx,rsi
       mov       r11,7FF82EEB06D8
       call      qword ptr [6D8]
       test      eax,eax
       jne       short 00000000000028BA
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      000000000000ECD0
       int       3
; Total bytes of code 165
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.DoesNotHaveItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       r8,26E2F408FC8
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [1048]
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      qword ptr [3048]
       test      eax,eax
       setle     al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 92
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000DB99
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       je        near ptr 000000000000DBE1
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000D937
       jmp       short 000000000000D949
       mov       rdx,7FF82F236B50
       call      00000000000087F0
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5828]
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000D972
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 000000000000DAE5
       jmp       near ptr 000000000000DAF7
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 000000000000D980
       jmp       short 000000000000D98F
       mov       rdx,7FF82F237268
       call      00000000000087F0
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000D95D
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [13F0]
       test      eax,eax
       je        short 000000000000D95D
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000DA65
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000DBFF
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
       mov       rdx,7FF82F236BE0
       call      00000000000087F0
       mov       rdx,rax
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [1798]
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000DB43
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr 000000000000DC28
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000DC28
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000DA7D
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000DA99
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000D9BB
       mov       rdx,7FF82F236C00
       call      00000000000087F0
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000DAD7
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr 000000000000DC28
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      0000000000000010
       mov       r12d,[rsp+44]
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr 000000000000DA17
       jmp       short 000000000000DB43
       mov       rdx,7FF82F236B90
       call      00000000000087F0
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [1768]
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000DB88
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr 000000000000D9D8
       jmp       near ptr 000000000000D9EA
       mov       rdx,7FF82F236B50
       call      00000000000087F0
       mov       rdx,rax
       jmp       short 000000000000DB5C
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000DB2F
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [1420]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 000000000000DBB4
       mov       rcx,[r15+50]
       jmp       short 000000000000DBC6
       mov       rdx,7FF82F236AE8
       call      00000000000087F0
       mov       rcx,rax
       call      qword ptr [3780]
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       jne       near ptr 000000000000D91F
       mov       ecx,825
       mov       rdx,7FF82EDF1A08
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [5D98]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       jmp       near ptr 000000000000D9C7
       call      00000000000023D0
       int       3
; Total bytes of code 846
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 000000000000D317
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [5810]
       test      rax,rax
       je        short 000000000000D345
       mov       rcx,rax
       mov       r11,7FF82E9A08B0
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82E9A08A0
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82E9A08A8
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000D387
       add       edi,1
       jo        short 000000000000D390
       mov       rcx,rsi
       mov       r11,7FF82E9A08A8
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000D36E
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      0000000000002090
       int       3
; Total bytes of code 150
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       r8,2ADB8352FF0
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      00000000000068D8
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      0000000000001020
       test      eax,eax
       setg      al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 90
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000DF66
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       je        near ptr 000000000000DFAD
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000DC37
       jmp       short 000000000000DC49
       mov       rdx,7FF82F4FA378
       call      0000000000002740
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000007440
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000DC71
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 000000000000DECA
       jmp       near ptr 000000000000DEDC
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 000000000000DC7F
       jmp       short 000000000000DC8E
       mov       rdx,7FF82F4FAA90
       call      0000000000002740
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000DC5C
       mov       rcx,rdi
       mov       rdx,r12
       call      0000000000006A10
       test      eax,eax
       je        short 000000000000DC5C
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000DEB2
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000DFE6
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
       mov       rdx,7FF82F4FA408
       call      0000000000002740
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      0000000000007050
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000DE98
       test      rbp,rbp
       je        near ptr 000000000000DDEB
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr 000000000000DDEB
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000E00E
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000DD81
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000DD9D
       mov       rdx,7FF82F4FA428
       call      0000000000002740
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000DDD8
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000E00E
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000DD3C
       jmp       near ptr 000000000000DE98
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr 000000000000E00E
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000E00E
       lea       ecx,[r12+0FFFF]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000DE38
       mov       rax,[rsp+30]
       jmp       short 000000000000DE4F
       mov       rdx,7FF82F4FA428
       call      0000000000002740
       mov       r11,rax
       mov       rax,[rsp+30]
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000DE8A
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000E00E
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000DDEB
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+58]
       test      r15,r15
       je        short 000000000000DF16
       jmp       short 000000000000DF27
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000DCB9
       mov       rdx,7FF82F4FA3B8
       call      0000000000002740
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000006B60
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000DF55
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+68]
       test      r12,r12
       je        near ptr 000000000000DCD6
       mov       rax,r12
       jmp       near ptr 000000000000DCE5
       mov       rdx,7FF82F4FA378
       call      0000000000002740
       jmp       short 000000000000DF2A
       mov       rax,r15
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      0000000000006A20
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 000000000000DF81
       mov       rcx,[r15+50]
       jmp       short 000000000000DF93
       mov       rdx,7FF82F4FA310
       call      0000000000002740
       mov       rcx,rax
       call      0000000000007360
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       jne       near ptr 000000000000DC1F
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FF82F17BD88
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      0000000000007E08
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       jmp       near ptr 000000000000DCC5
       call      000000000000F130
       int       3
; Total bytes of code 1076
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 0000000000008137
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      0000000000007438
       test      rax,rax
       je        short 000000000000816B
       mov       rcx,rax
       mov       r11,7FF82EE906E0
       mov       rax,[6E0]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82EE906D0
       call      qword ptr [6D0]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82EE906D8
       call      qword ptr [6D8]
       test      eax,eax
       je        short 00000000000081B6
       add       edi,1
       jo        short 00000000000081BF
       mov       rcx,rsi
       mov       r11,7FF82EE906D8
       call      qword ptr [6D8]
       test      eax,eax
       jne       short 000000000000819A
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      000000000000ECD0
       int       3
; Total bytes of code 165
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       r8,1883C40D3C8
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [5708]
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      qword ptr [3048]
       test      eax,eax
       setg      al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 92
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000FD59
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       je        near ptr 000000000000FDA1
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000FAF7
       jmp       short 000000000000FB09
       mov       rdx,7FF82F1BD580
       call      00000000000087F0
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5828]
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000FB32
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 000000000000FCA5
       jmp       near ptr 000000000000FCB7
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 000000000000FB40
       jmp       short 000000000000FB4F
       mov       rdx,7FF82F1BDC98
       call      00000000000087F0
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000FB1D
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [5AB0]
       test      eax,eax
       je        short 000000000000FB1D
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000FC25
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000FDBF
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
       mov       rdx,7FF82F1BD610
       call      00000000000087F0
       mov       rdx,rax
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [5E58]
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000FD03
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr 000000000000FDE8
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000FDE8
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000FC3D
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000FC59
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000FB7B
       mov       rdx,7FF82F1BD630
       call      00000000000087F0
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000FC97
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr 000000000000FDE8
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      0000000000000010
       mov       r12d,[rsp+44]
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr 000000000000FBD7
       jmp       short 000000000000FD03
       mov       rdx,7FF82F1BD5C0
       call      00000000000087F0
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5E28]
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000FD48
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr 000000000000FB98
       jmp       near ptr 000000000000FBAA
       mov       rdx,7FF82F1BD580
       call      00000000000087F0
       mov       rdx,rax
       jmp       short 000000000000FD1C
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000FCEF
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [5AE0]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 000000000000FD74
       mov       rcx,[r15+50]
       jmp       short 000000000000FD86
       mov       rdx,7FF82F1BD518
       call      00000000000087F0
       mov       rcx,rax
       call      qword ptr [3780]
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       jne       near ptr 000000000000FADF
       mov       ecx,825
       mov       rdx,7FF82EE01A08
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [0B450]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       jmp       near ptr 000000000000FB87
       call      00000000000023D0
       int       3
; Total bytes of code 846
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 000000000000F4D7
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [5810]
       test      rax,rax
       je        short 000000000000F505
       mov       rcx,rax
       mov       r11,7FF82E9B07E8
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82E9B07D8
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82E9B07E0
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000F547
       add       edi,1
       jo        short 000000000000F550
       mov       rcx,rsi
       mov       r11,7FF82E9B07E0
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000F52E
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      0000000000002090
       int       3
; Total bytes of code 150
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       r8,2688B032FF0
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      0000000000006928
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      0000000000001020
       test      eax,eax
       setg      al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 90
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000E5E6
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       je        near ptr 000000000000E62D
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000E2B7
       jmp       short 000000000000E2C9
       mov       rdx,7FF82F4FA8B0
       call      0000000000002740
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000007440
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000E2F1
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 000000000000E54A
       jmp       near ptr 000000000000E55C
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 000000000000E2FF
       jmp       short 000000000000E30E
       mov       rdx,7FF82F4FAFC8
       call      0000000000002740
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000E2DC
       mov       rcx,rdi
       mov       rdx,r12
       call      0000000000006A60
       test      eax,eax
       je        short 000000000000E2DC
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000E532
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000E666
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
       mov       rdx,7FF82F4FA940
       call      0000000000002740
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      0000000000006B98
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000E518
       test      rbp,rbp
       je        near ptr 000000000000E46B
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr 000000000000E46B
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000E68E
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000E401
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000E41D
       mov       rdx,7FF82F4FA960
       call      0000000000002740
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000E458
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000E68E
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000E3BC
       jmp       near ptr 000000000000E518
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr 000000000000E68E
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000E68E
       lea       ecx,[r12+0FFFF]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000E4B8
       mov       rax,[rsp+30]
       jmp       short 000000000000E4CF
       mov       rdx,7FF82F4FA960
       call      0000000000002740
       mov       r11,rax
       mov       rax,[rsp+30]
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000E50A
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000E68E
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000E46B
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+58]
       test      r15,r15
       je        short 000000000000E596
       jmp       short 000000000000E5A7
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000E339
       mov       rdx,7FF82F4FA8F0
       call      0000000000002740
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000006B78
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000E5D5
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+68]
       test      r12,r12
       je        near ptr 000000000000E356
       mov       rax,r12
       jmp       near ptr 000000000000E365
       mov       rdx,7FF82F4FA8B0
       call      0000000000002740
       jmp       short 000000000000E5AA
       mov       rax,r15
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      0000000000006A70
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 000000000000E601
       mov       rcx,[r15+50]
       jmp       short 000000000000E613
       mov       rdx,7FF82F4FA848
       call      0000000000002740
       mov       rcx,rax
       call      0000000000007360
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       jne       near ptr 000000000000E29F
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FF82F17BD88
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      0000000000007EB8
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       jmp       near ptr 000000000000E345
       call      000000000000F130
       int       3
; Total bytes of code 1076
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 00000000000081F7
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      0000000000007438
       test      rax,rax
       je        short 000000000000822B
       mov       rcx,rax
       mov       r11,7FF82EE906E0
       mov       rax,[6E0]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82EE906D0
       call      qword ptr [6D0]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82EE906D8
       call      qword ptr [6D8]
       test      eax,eax
       je        short 0000000000008276
       add       edi,1
       jo        short 000000000000827F
       mov       rcx,rsi
       mov       r11,7FF82EE906D8
       call      qword ptr [6D8]
       test      eax,eax
       jne       short 000000000000825A
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      000000000000ECD0
       int       3
; Total bytes of code 165
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       r8,11CDC40D3C8
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [5708]
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      qword ptr [3048]
       test      eax,eax
       setg      al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 92
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000FFF9
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       je        near ptr 0000000000000041
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000FD97
       jmp       short 000000000000FDA9
       mov       rdx,7FF82F1CD9A8
       call      00000000000087F0
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5828]
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000FDD2
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 000000000000FF45
       jmp       near ptr 000000000000FF57
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 000000000000FDE0
       jmp       short 000000000000FDEF
       mov       rdx,7FF82F1CE0C0
       call      00000000000087F0
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000FDBD
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [5AB0]
       test      eax,eax
       je        short 000000000000FDBD
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000FEC5
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000005F
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
       mov       rdx,7FF82F1CDA38
       call      00000000000087F0
       mov       rdx,rax
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [5E58]
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000FFA3
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr 0000000000000088
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 0000000000000088
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000FEDD
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000FEF9
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000FE1B
       mov       rdx,7FF82F1CDA58
       call      00000000000087F0
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000FF37
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr 0000000000000088
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      0000000000000010
       mov       r12d,[rsp+44]
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr 000000000000FE77
       jmp       short 000000000000FFA3
       mov       rdx,7FF82F1CD9E8
       call      00000000000087F0
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5E28]
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000FFE8
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr 000000000000FE38
       jmp       near ptr 000000000000FE4A
       mov       rdx,7FF82F1CD9A8
       call      00000000000087F0
       mov       rdx,rax
       jmp       short 000000000000FFBC
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000FF8F
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [5AE0]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 0000000000000014
       mov       rcx,[r15+50]
       jmp       short 0000000000000026
       mov       rdx,7FF82F1CD940
       call      00000000000087F0
       mov       rcx,rax
       call      qword ptr [3780]
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       jne       near ptr 000000000000FD7F
       mov       ecx,825
       mov       rdx,7FF82EE11A08
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [0B450]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       jmp       near ptr 000000000000FE27
       call      00000000000023D0
       int       3
; Total bytes of code 846
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 000000000000F777
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [5810]
       test      rax,rax
       je        short 000000000000F7A5
       mov       rcx,rax
       mov       r11,7FF82E9C07E8
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82E9C07D8
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82E9C07E0
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000F7E7
       add       edi,1
       jo        short 000000000000F7F0
       mov       rcx,rsi
       mov       r11,7FF82E9C07E0
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000F7CE
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      0000000000002090
       int       3
; Total bytes of code 150
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       r8,1E9D8692FF0
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      00000000000068D8
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      0000000000001020
       test      eax,eax
       setg      al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 90
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000E506
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       je        near ptr 000000000000E54D
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000E1D7
       jmp       short 000000000000E1E9
       mov       rdx,7FF82F4FA8B0
       call      0000000000002740
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000007440
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000E211
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 000000000000E46A
       jmp       near ptr 000000000000E47C
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 000000000000E21F
       jmp       short 000000000000E22E
       mov       rdx,7FF82F4FAFC8
       call      0000000000002740
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000E1FC
       mov       rcx,rdi
       mov       rdx,r12
       call      0000000000006A10
       test      eax,eax
       je        short 000000000000E1FC
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000E452
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000E586
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
       mov       rdx,7FF82F4FA940
       call      0000000000002740
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      0000000000007050
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000E438
       test      rbp,rbp
       je        near ptr 000000000000E38B
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr 000000000000E38B
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000E5AE
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000E321
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000E33D
       mov       rdx,7FF82F4FA960
       call      0000000000002740
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000E378
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000E5AE
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000E2DC
       jmp       near ptr 000000000000E438
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr 000000000000E5AE
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000E5AE
       lea       ecx,[r12+0FFFF]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000E3D8
       mov       rax,[rsp+30]
       jmp       short 000000000000E3EF
       mov       rdx,7FF82F4FA960
       call      0000000000002740
       mov       r11,rax
       mov       rax,[rsp+30]
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000E42A
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000E5AE
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000E38B
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+58]
       test      r15,r15
       je        short 000000000000E4B6
       jmp       short 000000000000E4C7
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000E259
       mov       rdx,7FF82F4FA8F0
       call      0000000000002740
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000006B60
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000E4F5
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+68]
       test      r12,r12
       je        near ptr 000000000000E276
       mov       rax,r12
       jmp       near ptr 000000000000E285
       mov       rdx,7FF82F4FA8B0
       call      0000000000002740
       jmp       short 000000000000E4CA
       mov       rax,r15
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      0000000000006A20
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 000000000000E521
       mov       rcx,[r15+50]
       jmp       short 000000000000E533
       mov       rdx,7FF82F4FA848
       call      0000000000002740
       mov       rcx,rax
       call      0000000000007360
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       jne       near ptr 000000000000E1BF
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FF82F17BD88
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      0000000000007E08
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       jmp       near ptr 000000000000E265
       call      000000000000F130
       int       3
; Total bytes of code 1076
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 0000000000008137
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      0000000000007438
       test      rax,rax
       je        short 000000000000816B
       mov       rcx,rax
       mov       r11,7FF82EE906E0
       mov       rax,[6E0]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82EE906D0
       call      qword ptr [6D0]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82EE906D8
       call      qword ptr [6D8]
       test      eax,eax
       je        short 00000000000081B6
       add       edi,1
       jo        short 00000000000081BF
       mov       rcx,rsi
       mov       r11,7FF82EE906D8
       call      qword ptr [6D8]
       test      eax,eax
       jne       short 000000000000819A
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      000000000000ECD0
       int       3
; Total bytes of code 165
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       r8,1F5BF403C10
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7708]
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      qword ptr [3048]
       test      eax,eax
       setg      al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 92
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 00000000000003F9
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       je        near ptr 0000000000000441
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 0000000000000197
       jmp       short 00000000000001A9
       mov       rdx,7FF82F1ACE68
       call      00000000000087F0
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5828]
       mov       r12,rax
       test      r12,r12
       jne       short 00000000000001D2
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 0000000000000345
       jmp       near ptr 0000000000000357
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 00000000000001E0
       jmp       short 00000000000001EF
       mov       rdx,7FF82F1AD580
       call      00000000000087F0
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 00000000000001BD
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7AB0]
       test      eax,eax
       je        short 00000000000001BD
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 00000000000002C5
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000045F
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
       mov       rdx,7FF82F1ACEF8
       call      00000000000087F0
       mov       rdx,rax
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7E58]
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 00000000000003A3
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr 0000000000000488
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 0000000000000488
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 00000000000002DD
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 00000000000002F9
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000021B
       mov       rdx,7FF82F1ACF18
       call      00000000000087F0
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 0000000000000337
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr 0000000000000488
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      0000000000000010
       mov       r12d,[rsp+44]
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr 0000000000000277
       jmp       short 00000000000003A3
       mov       rdx,7FF82F1ACEA8
       call      00000000000087F0
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7E28]
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 00000000000003E8
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr 0000000000000238
       jmp       near ptr 000000000000024A
       mov       rdx,7FF82F1ACE68
       call      00000000000087F0
       mov       rdx,rax
       jmp       short 00000000000003BC
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000038F
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [7AE0]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 0000000000000414
       mov       rcx,[r15+50]
       jmp       short 0000000000000426
       mov       rdx,7FF82F1ACE00
       call      00000000000087F0
       mov       rcx,rax
       call      qword ptr [3780]
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       jne       near ptr 000000000000017F
       mov       ecx,825
       mov       rdx,7FF82EDF1A08
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [0D450]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       jmp       near ptr 0000000000000227
       call      00000000000023D0
       int       3
; Total bytes of code 846
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 000000000000FB77
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [5810]
       test      rax,rax
       je        short 000000000000FBA5
       mov       rcx,rax
       mov       r11,7FF82E9A07E8
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82E9A07D8
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82E9A07E0
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000FBE7
       add       edi,1
       jo        short 000000000000FBF0
       mov       rcx,rsi
       mov       r11,7FF82E9A07E0
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000FBCE
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      0000000000002090
       int       3
; Total bytes of code 150
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       r8,27653702FF0
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      00000000000068D8
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      0000000000001020
       test      eax,eax
       setg      al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 90
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000E506
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       je        near ptr 000000000000E54D
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000E1D7
       jmp       short 000000000000E1E9
       mov       rdx,7FF82F50A8B0
       call      0000000000002740
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000007440
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000E211
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 000000000000E46A
       jmp       near ptr 000000000000E47C
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 000000000000E21F
       jmp       short 000000000000E22E
       mov       rdx,7FF82F50AFC8
       call      0000000000002740
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000E1FC
       mov       rcx,rdi
       mov       rdx,r12
       call      0000000000006A10
       test      eax,eax
       je        short 000000000000E1FC
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000E452
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000E586
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
       mov       rdx,7FF82F50A940
       call      0000000000002740
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      0000000000007050
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000E438
       test      rbp,rbp
       je        near ptr 000000000000E38B
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr 000000000000E38B
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000E5AE
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000E321
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000E33D
       mov       rdx,7FF82F50A960
       call      0000000000002740
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000E378
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000E5AE
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000E2DC
       jmp       near ptr 000000000000E438
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr 000000000000E5AE
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000E5AE
       lea       ecx,[r12+0FFFF]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000E3D8
       mov       rax,[rsp+30]
       jmp       short 000000000000E3EF
       mov       rdx,7FF82F50A960
       call      0000000000002740
       mov       r11,rax
       mov       rax,[rsp+30]
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000E42A
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000E5AE
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000E38B
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+58]
       test      r15,r15
       je        short 000000000000E4B6
       jmp       short 000000000000E4C7
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000E259
       mov       rdx,7FF82F50A8F0
       call      0000000000002740
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000006B60
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000E4F5
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+68]
       test      r12,r12
       je        near ptr 000000000000E276
       mov       rax,r12
       jmp       near ptr 000000000000E285
       mov       rdx,7FF82F50A8B0
       call      0000000000002740
       jmp       short 000000000000E4CA
       mov       rax,r15
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      0000000000006A20
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 000000000000E521
       mov       rcx,[r15+50]
       jmp       short 000000000000E533
       mov       rdx,7FF82F50A848
       call      0000000000002740
       mov       rcx,rax
       call      0000000000007360
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       jne       near ptr 000000000000E1BF
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FF82F18BD88
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      0000000000007E08
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       jmp       near ptr 000000000000E265
       call      000000000000F130
       int       3
; Total bytes of code 1076
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 0000000000008137
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      0000000000007438
       test      rax,rax
       je        short 000000000000816B
       mov       rcx,rax
       mov       r11,7FF82EEA06E0
       mov       rax,[6E0]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82EEA06D0
       call      qword ptr [6D0]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82EEA06D8
       call      qword ptr [6D8]
       test      eax,eax
       je        short 00000000000081B6
       add       edi,1
       jo        short 00000000000081BF
       mov       rcx,rsi
       mov       r11,7FF82EEA06D8
       call      qword ptr [6D8]
       test      eax,eax
       jne       short 000000000000819A
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      000000000000ECD0
       int       3
; Total bytes of code 165
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       r8,153AAC03C10
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [9048]
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      qword ptr [3048]
       test      eax,eax
       setg      al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 92
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 00000000000003F9
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       je        near ptr 0000000000000441
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 0000000000000197
       jmp       short 00000000000001A9
       mov       rdx,7FF82F1CCE68
       call      00000000000087F0
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5828]
       mov       r12,rax
       test      r12,r12
       jne       short 00000000000001D2
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 0000000000000345
       jmp       near ptr 0000000000000357
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 00000000000001E0
       jmp       short 00000000000001EF
       mov       rdx,7FF82F1CD580
       call      00000000000087F0
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 00000000000001BD
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [93F0]
       test      eax,eax
       je        short 00000000000001BD
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 00000000000002C5
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000045F
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
       mov       rdx,7FF82F1CCEF8
       call      00000000000087F0
       mov       rdx,rax
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [9798]
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 00000000000003A3
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr 0000000000000488
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 0000000000000488
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 00000000000002DD
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 00000000000002F9
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000021B
       mov       rdx,7FF82F1CCF18
       call      00000000000087F0
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 0000000000000337
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr 0000000000000488
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      0000000000000010
       mov       r12d,[rsp+44]
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr 0000000000000277
       jmp       short 00000000000003A3
       mov       rdx,7FF82F1CCEA8
       call      00000000000087F0
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [9768]
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 00000000000003E8
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr 0000000000000238
       jmp       near ptr 000000000000024A
       mov       rdx,7FF82F1CCE68
       call      00000000000087F0
       mov       rdx,rax
       jmp       short 00000000000003BC
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000038F
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [9420]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 0000000000000414
       mov       rcx,[r15+50]
       jmp       short 0000000000000426
       mov       rdx,7FF82F1CCE00
       call      00000000000087F0
       mov       rcx,rax
       call      qword ptr [3780]
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       jne       near ptr 000000000000017F
       mov       ecx,825
       mov       rdx,7FF82EE11A08
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [0DD98]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       jmp       near ptr 0000000000000227
       call      00000000000023D0
       int       3
; Total bytes of code 846
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 000000000000FB77
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [5810]
       test      rax,rax
       je        short 000000000000FBA5
       mov       rcx,rax
       mov       r11,7FF82E9C07E8
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82E9C07D8
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82E9C07E0
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000FBE7
       add       edi,1
       jo        short 000000000000FBF0
       mov       rcx,rsi
       mov       r11,7FF82E9C07E0
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000FBCE
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      0000000000002090
       int       3
; Total bytes of code 150
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       r8,26303EE2FF0
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      0000000000006928
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      0000000000001020
       test      eax,eax
       setg      al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 90
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000D8A6
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       je        near ptr 000000000000D8ED
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000D577
       jmp       short 000000000000D589
       mov       rdx,7FF82F519758
       call      0000000000002740
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000007440
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000D5B1
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 000000000000D80A
       jmp       near ptr 000000000000D81C
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 000000000000D5BF
       jmp       short 000000000000D5CE
       mov       rdx,7FF82F519E70
       call      0000000000002740
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000D59C
       mov       rcx,rdi
       mov       rdx,r12
       call      0000000000006A60
       test      eax,eax
       je        short 000000000000D59C
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000D7F2
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000D926
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
       mov       rdx,7FF82F5197E8
       call      0000000000002740
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      0000000000006B98
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000D7D8
       test      rbp,rbp
       je        near ptr 000000000000D72B
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr 000000000000D72B
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000D94E
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000D6C1
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000D6DD
       mov       rdx,7FF82F519808
       call      0000000000002740
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000D718
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000D94E
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000D67C
       jmp       near ptr 000000000000D7D8
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr 000000000000D94E
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000D94E
       lea       ecx,[r12+0FFFF]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000D778
       mov       rax,[rsp+30]
       jmp       short 000000000000D78F
       mov       rdx,7FF82F519808
       call      0000000000002740
       mov       r11,rax
       mov       rax,[rsp+30]
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000D7CA
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000D94E
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000D72B
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+58]
       test      r15,r15
       je        short 000000000000D856
       jmp       short 000000000000D867
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000D5F9
       mov       rdx,7FF82F519798
       call      0000000000002740
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000006B78
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000D895
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+68]
       test      r12,r12
       je        near ptr 000000000000D616
       mov       rax,r12
       jmp       near ptr 000000000000D625
       mov       rdx,7FF82F519758
       call      0000000000002740
       jmp       short 000000000000D86A
       mov       rax,r15
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      0000000000006A70
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 000000000000D8C1
       mov       rcx,[r15+50]
       jmp       short 000000000000D8D3
       mov       rdx,7FF82F5196F0
       call      0000000000002740
       mov       rcx,rax
       call      0000000000007360
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       jne       near ptr 000000000000D55F
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FF82F19BD88
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      0000000000007EB8
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       jmp       near ptr 000000000000D605
       call      000000000000F130
       int       3
; Total bytes of code 1076
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 00000000000081F7
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      0000000000007438
       test      rax,rax
       je        short 000000000000822B
       mov       rcx,rax
       mov       r11,7FF82EEB06E0
       mov       rax,[6E0]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82EEB06D0
       call      qword ptr [6D0]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82EEB06D8
       call      qword ptr [6D8]
       test      eax,eax
       je        short 0000000000008276
       add       edi,1
       jo        short 000000000000827F
       mov       rcx,rsi
       mov       r11,7FF82EEB06D8
       call      qword ptr [6D8]
       test      eax,eax
       jne       short 000000000000825A
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      000000000000ECD0
       int       3
; Total bytes of code 165
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       r8,2142A40D3C8
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7708]
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      qword ptr [3048]
       test      eax,eax
       setg      al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 92
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 00000000000003D9
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       je        near ptr 0000000000000421
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 0000000000000177
       jmp       short 0000000000000189
       mov       rdx,7FF82F1BCE78
       call      00000000000087F0
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5828]
       mov       r12,rax
       test      r12,r12
       jne       short 00000000000001B2
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 0000000000000325
       jmp       near ptr 0000000000000337
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 00000000000001C0
       jmp       short 00000000000001CF
       mov       rdx,7FF82F1BD590
       call      00000000000087F0
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000019D
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7AB0]
       test      eax,eax
       je        short 000000000000019D
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 00000000000002A5
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000043F
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
       mov       rdx,7FF82F1BCF08
       call      00000000000087F0
       mov       rdx,rax
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7E58]
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 0000000000000383
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr 0000000000000468
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 0000000000000468
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 00000000000002BD
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 00000000000002D9
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 00000000000001FB
       mov       rdx,7FF82F1BCF28
       call      00000000000087F0
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 0000000000000317
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr 0000000000000468
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      0000000000000010
       mov       r12d,[rsp+44]
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr 0000000000000257
       jmp       short 0000000000000383
       mov       rdx,7FF82F1BCEB8
       call      00000000000087F0
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7E28]
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 00000000000003C8
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr 0000000000000218
       jmp       near ptr 000000000000022A
       mov       rdx,7FF82F1BCE78
       call      00000000000087F0
       mov       rdx,rax
       jmp       short 000000000000039C
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000036F
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [7AE0]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 00000000000003F4
       mov       rcx,[r15+50]
       jmp       short 0000000000000406
       mov       rdx,7FF82F1BCE10
       call      00000000000087F0
       mov       rcx,rax
       call      qword ptr [3780]
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       jne       near ptr 000000000000015F
       mov       ecx,825
       mov       rdx,7FF82EE01A08
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [0D450]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       jmp       near ptr 0000000000000207
       call      00000000000023D0
       int       3
; Total bytes of code 846
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 000000000000FB57
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [5810]
       test      rax,rax
       je        short 000000000000FB85
       mov       rcx,rax
       mov       r11,7FF82E9B07E8
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82E9B07D8
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82E9B07E0
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000FBC7
       add       edi,1
       jo        short 000000000000FBD0
       mov       rcx,rsi
       mov       r11,7FF82E9B07E0
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000FBAE
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      0000000000002090
       int       3
; Total bytes of code 150
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       r8,2749F582FF0
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      0000000000006928
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      0000000000001020
       test      eax,eax
       setg      al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 90
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000DD86
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       je        near ptr 000000000000DDCD
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000DA57
       jmp       short 000000000000DA69
       mov       rdx,7FF82F509BD0
       call      0000000000002740
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000007440
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000DA91
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 000000000000DCEA
       jmp       near ptr 000000000000DCFC
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 000000000000DA9F
       jmp       short 000000000000DAAE
       mov       rdx,7FF82F50A2E8
       call      0000000000002740
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000DA7C
       mov       rcx,rdi
       mov       rdx,r12
       call      0000000000006A60
       test      eax,eax
       je        short 000000000000DA7C
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000DCD2
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000DE06
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
       mov       rdx,7FF82F509C60
       call      0000000000002740
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      0000000000006B98
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000DCB8
       test      rbp,rbp
       je        near ptr 000000000000DC0B
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr 000000000000DC0B
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000DE2E
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000DBA1
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000DBBD
       mov       rdx,7FF82F509C80
       call      0000000000002740
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000DBF8
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000DE2E
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000DB5C
       jmp       near ptr 000000000000DCB8
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr 000000000000DE2E
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000DE2E
       lea       ecx,[r12+0FFFF]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000DC58
       mov       rax,[rsp+30]
       jmp       short 000000000000DC6F
       mov       rdx,7FF82F509C80
       call      0000000000002740
       mov       r11,rax
       mov       rax,[rsp+30]
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000DCAA
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000DE2E
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000DC0B
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+58]
       test      r15,r15
       je        short 000000000000DD36
       jmp       short 000000000000DD47
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000DAD9
       mov       rdx,7FF82F509C10
       call      0000000000002740
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000006B78
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000DD75
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+68]
       test      r12,r12
       je        near ptr 000000000000DAF6
       mov       rax,r12
       jmp       near ptr 000000000000DB05
       mov       rdx,7FF82F509BD0
       call      0000000000002740
       jmp       short 000000000000DD4A
       mov       rax,r15
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      0000000000006A70
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 000000000000DDA1
       mov       rcx,[r15+50]
       jmp       short 000000000000DDB3
       mov       rdx,7FF82F509B68
       call      0000000000002740
       mov       rcx,rax
       call      0000000000007360
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       jne       near ptr 000000000000DA3F
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FF82F18BD88
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      0000000000007EB8
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       jmp       near ptr 000000000000DAE5
       call      000000000000F130
       int       3
; Total bytes of code 1076
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 00000000000081F7
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      0000000000007438
       test      rax,rax
       je        short 000000000000822B
       mov       rcx,rax
       mov       r11,7FF82EEA06E0
       mov       rax,[6E0]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82EEA06D0
       call      qword ptr [6D0]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82EEA06D8
       call      qword ptr [6D8]
       test      eax,eax
       je        short 0000000000008276
       add       edi,1
       jo        short 000000000000827F
       mov       rcx,rsi
       mov       r11,7FF82EEA06D8
       call      qword ptr [6D8]
       test      eax,eax
       jne       short 000000000000825A
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      000000000000ECD0
       int       3
; Total bytes of code 165
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       r8,1F195C05C08
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [9048]
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      qword ptr [3048]
       test      eax,eax
       setg      al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 92
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 00000000000003D9
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       je        near ptr 0000000000000421
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 0000000000000177
       jmp       short 0000000000000189
       mov       rdx,7FF82F1BCE78
       call      00000000000087F0
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5828]
       mov       r12,rax
       test      r12,r12
       jne       short 00000000000001B2
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 0000000000000325
       jmp       near ptr 0000000000000337
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 00000000000001C0
       jmp       short 00000000000001CF
       mov       rdx,7FF82F1BD590
       call      00000000000087F0
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000019D
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [93F0]
       test      eax,eax
       je        short 000000000000019D
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 00000000000002A5
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000043F
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
       mov       rdx,7FF82F1BCF08
       call      00000000000087F0
       mov       rdx,rax
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [9798]
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 0000000000000383
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr 0000000000000468
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 0000000000000468
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 00000000000002BD
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 00000000000002D9
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 00000000000001FB
       mov       rdx,7FF82F1BCF28
       call      00000000000087F0
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 0000000000000317
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr 0000000000000468
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      0000000000000010
       mov       r12d,[rsp+44]
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr 0000000000000257
       jmp       short 0000000000000383
       mov       rdx,7FF82F1BCEB8
       call      00000000000087F0
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [9768]
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 00000000000003C8
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr 0000000000000218
       jmp       near ptr 000000000000022A
       mov       rdx,7FF82F1BCE78
       call      00000000000087F0
       mov       rdx,rax
       jmp       short 000000000000039C
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000036F
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [9420]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 00000000000003F4
       mov       rcx,[r15+50]
       jmp       short 0000000000000406
       mov       rdx,7FF82F1BCE10
       call      00000000000087F0
       mov       rcx,rax
       call      qword ptr [3780]
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       jne       near ptr 000000000000015F
       mov       ecx,825
       mov       rdx,7FF82EE01A08
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [0DD98]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       jmp       near ptr 0000000000000207
       call      00000000000023D0
       int       3
; Total bytes of code 846
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 000000000000FB57
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [5810]
       test      rax,rax
       je        short 000000000000FB85
       mov       rcx,rax
       mov       r11,7FF82E9B07E8
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82E9B07D8
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82E9B07E0
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000FBC7
       add       edi,1
       jo        short 000000000000FBD0
       mov       rcx,rsi
       mov       r11,7FF82E9B07E0
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000FBAE
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      0000000000002090
       int       3
; Total bytes of code 150
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       r8,17450FC2FF0
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      00000000000068D8
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      0000000000001020
       test      eax,eax
       setg      al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 90
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000DCA6
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       je        near ptr 000000000000DCED
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000D977
       jmp       short 000000000000D989
       mov       rdx,7FF82F509B28
       call      0000000000002740
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000007440
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000D9B1
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 000000000000DC0A
       jmp       near ptr 000000000000DC1C
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 000000000000D9BF
       jmp       short 000000000000D9CE
       mov       rdx,7FF82F50A240
       call      0000000000002740
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000D99C
       mov       rcx,rdi
       mov       rdx,r12
       call      0000000000006A10
       test      eax,eax
       je        short 000000000000D99C
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000DBF2
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000DD26
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
       mov       rdx,7FF82F509BB8
       call      0000000000002740
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      0000000000007050
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000DBD8
       test      rbp,rbp
       je        near ptr 000000000000DB2B
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr 000000000000DB2B
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000DD4E
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000DAC1
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000DADD
       mov       rdx,7FF82F509BD8
       call      0000000000002740
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000DB18
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000DD4E
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000DA7C
       jmp       near ptr 000000000000DBD8
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr 000000000000DD4E
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000DD4E
       lea       ecx,[r12+0FFFF]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000DB78
       mov       rax,[rsp+30]
       jmp       short 000000000000DB8F
       mov       rdx,7FF82F509BD8
       call      0000000000002740
       mov       r11,rax
       mov       rax,[rsp+30]
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000DBCA
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000DD4E
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000DB2B
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+58]
       test      r15,r15
       je        short 000000000000DC56
       jmp       short 000000000000DC67
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000D9F9
       mov       rdx,7FF82F509B68
       call      0000000000002740
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000006B60
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000DC95
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+68]
       test      r12,r12
       je        near ptr 000000000000DA16
       mov       rax,r12
       jmp       near ptr 000000000000DA25
       mov       rdx,7FF82F509B28
       call      0000000000002740
       jmp       short 000000000000DC6A
       mov       rax,r15
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      0000000000006A20
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 000000000000DCC1
       mov       rcx,[r15+50]
       jmp       short 000000000000DCD3
       mov       rdx,7FF82F509AC0
       call      0000000000002740
       mov       rcx,rax
       call      0000000000007360
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       jne       near ptr 000000000000D95F
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FF82F18BD88
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      0000000000007E08
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       jmp       near ptr 000000000000DA05
       call      000000000000F130
       int       3
; Total bytes of code 1076
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 0000000000008137
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      0000000000007438
       test      rax,rax
       je        short 000000000000816B
       mov       rcx,rax
       mov       r11,7FF82EEA06E0
       mov       rax,[6E0]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82EEA06D0
       call      qword ptr [6D0]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82EEA06D8
       call      qword ptr [6D8]
       test      eax,eax
       je        short 00000000000081B6
       add       edi,1
       jo        short 00000000000081BF
       mov       rcx,rsi
       mov       r11,7FF82EEA06D8
       call      qword ptr [6D8]
       test      eax,eax
       jne       short 000000000000819A
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      000000000000ECD0
       int       3
; Total bytes of code 165
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       r8,2C9C9808FC0
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7708]
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      qword ptr [3048]
       test      eax,eax
       setg      al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 92
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 0000000000000019
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       je        near ptr 0000000000000061
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000FDB7
       jmp       short 000000000000FDC9
       mov       rdx,7FF82F1DC168
       call      00000000000087F0
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5828]
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000FDF2
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 000000000000FF65
       jmp       near ptr 000000000000FF77
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 000000000000FE00
       jmp       short 000000000000FE0F
       mov       rdx,7FF82F1DC880
       call      00000000000087F0
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000FDDD
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7AB0]
       test      eax,eax
       je        short 000000000000FDDD
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000FEE5
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000007F
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
       mov       rdx,7FF82F1DC1F8
       call      00000000000087F0
       mov       rdx,rax
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7E58]
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000FFC3
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr 00000000000000A8
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 00000000000000A8
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000FEFD
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000FF19
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000FE3B
       mov       rdx,7FF82F1DC218
       call      00000000000087F0
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000FF57
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr 00000000000000A8
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      0000000000000010
       mov       r12d,[rsp+44]
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr 000000000000FE97
       jmp       short 000000000000FFC3
       mov       rdx,7FF82F1DC1A8
       call      00000000000087F0
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7E28]
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 8
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr 000000000000FE58
       jmp       near ptr 000000000000FE6A
       mov       rdx,7FF82F1DC168
       call      00000000000087F0
       mov       rdx,rax
       jmp       short 000000000000FFDC
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000FFAF
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [7AE0]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 0000000000000034
       mov       rcx,[r15+50]
       jmp       short 0000000000000046
       mov       rdx,7FF82F1DC100
       call      00000000000087F0
       mov       rcx,rax
       call      qword ptr [3780]
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       jne       near ptr 000000000000FD9F
       mov       ecx,825
       mov       rdx,7FF82EE21A08
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [0D450]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       jmp       near ptr 000000000000FE47
       call      00000000000023D0
       int       3
; Total bytes of code 846
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 000000000000FB37
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [5810]
       test      rax,rax
       je        short 000000000000FB65
       mov       rcx,rax
       mov       r11,7FF82E9D07E0
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82E9D07D0
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82E9D07D8
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000FBA7
       add       edi,1
       jo        short 000000000000FBB0
       mov       rcx,rsi
       mov       r11,7FF82E9D07D8
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000FB8E
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      0000000000002090
       int       3
; Total bytes of code 150
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000B2D0
       mov       rbx,rax
       mov       r8,1FF62FA2FF8
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      0000000000000CE8
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      0000000000001020
       test      eax,eax
       setg      al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 90
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000ADC6
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       je        near ptr 000000000000AE0D
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000AA97
       jmp       short 000000000000AAA9
       mov       rdx,7FF82F532540
       call      0000000000002740
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000007440
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000AAD1
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 000000000000AD2A
       jmp       near ptr 000000000000AD3C
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 000000000000AADF
       jmp       short 000000000000AAEE
       mov       rdx,7FF82F532C58
       call      0000000000002740
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000AABC
       mov       rcx,rdi
       mov       rdx,r12
       call      0000000000000E20
       test      eax,eax
       je        short 000000000000AABC
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000AD12
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000AE46
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
       mov       rdx,7FF82F5325D0
       call      0000000000002740
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      0000000000000F68
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000ACF8
       test      rbp,rbp
       je        near ptr 000000000000AC4B
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr 000000000000AC4B
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000AE6E
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000ABE1
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000ABFD
       mov       rdx,7FF82F5325F0
       call      0000000000002740
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000AC38
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000AE6E
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000AB9C
       jmp       near ptr 000000000000ACF8
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr 000000000000AE6E
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000AE6E
       lea       ecx,[r12+0FFFF]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000AC98
       mov       rax,[rsp+30]
       jmp       short 000000000000ACAF
       mov       rdx,7FF82F5325F0
       call      0000000000002740
       mov       r11,rax
       mov       rax,[rsp+30]
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000ACEA
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr 000000000000AE6E
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      000000000000AEB0
       mov       ebx,[rsp+44]
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr 000000000000AC4B
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+58]
       test      r15,r15
       je        short 000000000000AD76
       jmp       short 000000000000AD87
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000AB19
       mov       rdx,7FF82F532580
       call      0000000000002740
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      0000000000000F48
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000ADB5
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+68]
       test      r12,r12
       je        near ptr 000000000000AB36
       mov       rax,r12
       jmp       near ptr 000000000000AB45
       mov       rdx,7FF82F532540
       call      0000000000002740
       jmp       short 000000000000AD8A
       mov       rax,r15
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      0000000000000E30
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 000000000000ADE1
       mov       rcx,[r15+50]
       jmp       short 000000000000ADF3
       mov       rdx,7FF82F5324D8
       call      0000000000002740
       mov       rcx,rax
       call      0000000000007360
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      000000000000AEB0
       test      rbx,rbx
       jne       near ptr 000000000000AA7F
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FF82F18BD88
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      0000000000002278
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      000000000000AEB0
       jmp       near ptr 000000000000AB25
       call      000000000000F130
       int       3
; Total bytes of code 1076
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 00000000000025B7
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      0000000000007438
       test      rax,rax
       je        short 00000000000025EB
       mov       rcx,rax
       mov       r11,7FF82EEA06E0
       mov       rax,[6E0]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82EEA06D0
       call      qword ptr [6D0]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82EEA06D8
       call      qword ptr [6D8]
       test      eax,eax
       je        short 0000000000002636
       add       edi,1
       jo        short 000000000000263F
       mov       rcx,rsi
       mov       r11,7FF82EEA06D8
       call      qword ptr [6D8]
       test      eax,eax
       jne       short 000000000000261A
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      000000000000ECD0
       int       3
; Total bytes of code 165
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
; 			var people = new SortedSet<PersonProper>(this.GetPersonProperArray(Core.Tristate.False));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(people.HasItems());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+110]
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       r8,26246403C18
       mov       r8,[r8]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [1708]
       mov       rcx,rbx
       mov       rsi,[rsi+20]
       call      qword ptr [3048]
       test      eax,eax
       setg      al
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 92
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr 000000000000DBB9
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       je        near ptr 000000000000DC01
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000D957
       jmp       short 000000000000D969
       mov       rdx,7FF82F246B50
       call      00000000000087F0
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [5828]
       mov       r12,rax
       test      r12,r12
       jne       short 000000000000D992
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr 000000000000DB05
       jmp       near ptr 000000000000DB17
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short 000000000000D9A0
       jmp       short 000000000000D9AF
       mov       rdx,7FF82F247268
       call      00000000000087F0
       mov       rcx,r12
       cmp       [rcx],rax
       je        short 000000000000D97D
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [1AB0]
       test      eax,eax
       je        short 000000000000D97D
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr 000000000000DA85
       cmp       dword ptr [r12+20],0
       jg        near ptr 000000000000DC1F
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
       mov       rdx,7FF82F246BE0
       call      00000000000087F0
       mov       rdx,rax
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [1E58]
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr 000000000000DB63
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr 000000000000DC48
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx+0FFFF]
       cmp       ecx,r13d
       jae       near ptr 000000000000DC48
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+70]
       test      r11,r11
       je        short 000000000000DA9D
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short 000000000000DAB9
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr 000000000000D9DB
       mov       rdx,7FF82F246C00
       call      00000000000087F0
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000DAF7
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr 000000000000DC48
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      0000000000000010
       mov       r12d,[rsp+44]
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr 000000000000DA37
       jmp       short 000000000000DB63
       mov       rdx,7FF82F246B90
       call      00000000000087F0
       mov       rdx,rax
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [1E28]
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short 000000000000DBA8
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr 000000000000D9F8
       jmp       near ptr 000000000000DA0A
       mov       rdx,7FF82F246B50
       call      00000000000087F0
       mov       rdx,rax
       jmp       short 000000000000DB7C
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short 000000000000DB4F
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [1AE0]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
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
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+50],0
       je        short 000000000000DBD4
       mov       rcx,[r15+50]
       jmp       short 000000000000DBE6
       mov       rdx,7FF82F246AE8
       call      00000000000087F0
       mov       rcx,rax
       call      qword ptr [3780]
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      0000000000000010
       test      rbx,rbx
       jne       near ptr 000000000000D93F
       mov       ecx,825
       mov       rdx,7FF82EE01A08
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7450]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      0000000000000010
       jmp       near ptr 000000000000D9E7
       call      00000000000023D0
       int       3
; Total bytes of code 846
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 000000000000D337
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [5810]
       test      rax,rax
       je        short 000000000000D365
       mov       rcx,rax
       mov       r11,7FF82E9B08D0
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF82E9B08C0
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rcx,rsi
       mov       r11,7FF82E9B08C8
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000D3A7
       add       edi,1
       jo        short 000000000000D3B0
       mov       rcx,rsi
       mov       r11,7FF82E9B08C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short 000000000000D38E
       mov       eax,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       call      0000000000002090
       int       3
; Total bytes of code 150
```

