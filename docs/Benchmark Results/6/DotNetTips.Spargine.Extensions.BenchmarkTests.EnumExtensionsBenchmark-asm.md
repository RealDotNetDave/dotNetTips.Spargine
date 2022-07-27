## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumExtensionsBenchmark.GetDescription01()
; 			var result = this._testEnum.GetDescription();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.StringComparison
       call      000000000000B2D0
       mov       ecx,[rsi+0B8]
       mov       [rax+8],ecx
       mov       rcx,rax
       call      00000000000093B0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000EE4E
       mov       rcx,rsi
       call      000000000000F570
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rbx,[rax+40]
       call      qword ptr [rbx+8]
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1C
       cmp       [rcx],ecx
       call      qword ptr [9638]
       mov       rdi,rax
       mov       rcx,offset MT_System.ComponentModel.DescriptionAttribute
       call      0000000000004F40
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdx,rax
       mov       rcx,offset MT_System.ComponentModel.DescriptionAttribute[]
       call      0000000000007450
       cmp       dword ptr [rax+8],0
       jne       short 000000000000EE35
       mov       rcx,rsi
       mov       rax,[rbx+8]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
       mov       rcx,[rax+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       mov       rax,[rax+38]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
       mov       ecx,4D
       mov       rdx,7FF82F2FF850
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,333
       mov       rdx,7FF82F2FF850
       call      0000000000000390
       mov       rdi,rax
       call      00000000000015A0
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      0000000000000658
       mov       rcx,rax
       call      000000000000F6C0
       int       3
; Total bytes of code 248
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumExtensionsBenchmark.GetDescription01()
; 			var result = this._testEnum.GetDescription();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.StringComparison
       call      000000000000EFB0
       mov       ecx,[rsi+0B4]
       mov       [rax+8],ecx
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
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       test      rsi,rsi
       jne       near ptr 000000000000F092
       call      qword ptr [9B28]
       mov       rsi,rax
       mov       ecx,7
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],5
       jl        near ptr 000000000000F128
       lea       rcx,[rdi+0C]
       mov       rdx,187D5C04810
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr 000000000000F14B
       lea       rcx,[rdi+16]
       mov       rdx,187D5C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000EFB3
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 000000000000EFB8
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000F053
       call      qword ptr [9C48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EF70A30
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EF70A30
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
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [9870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       rcx,rsi
       call      00000000000053F0
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       mov       [rsp+28],rax
       call      qword ptr [rax+8]
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1C
       call      qword ptr [8950]
       mov       rdi,rax
       mov       rcx,offset MT_System.ComponentModel.DescriptionAttribute
       call      0000000000003330
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdx,rax
       mov       rcx,offset MT_System.ComponentModel.DescriptionAttribute[]
       call      qword ptr [5858]
       cmp       dword ptr [rax+8],0
       jne       short 000000000000F112
       mov       rcx,rsi
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+8]
       mov       rcx,[rax+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+38]
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [5F48]
       mov       rcx,rsi
       call      0000000000006AD0
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [5F48]
       mov       rcx,rsi
       call      0000000000006AD0
       int       3
; Total bytes of code 607
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumExtensionsBenchmark.GetItems01()
; 			var result = this._testEnum.GetItems();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.StringComparison
       call      000000000000B2D0
       mov       ecx,[rsi+0B8]
       mov       [rax+8],ecx
       mov       rcx,rax
       call      0000000000009540
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Extensions.EnumExtensions.GetItems(System.Enum)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000A797
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,7FF82EFC4928
       mov       edx,28
       call      000000000000CB10
       mov       rdx,297954F2F70
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      000000000000AEB0
       mov       rcx,rsi
       call      000000000000F570
       mov       rsi,rax
       mov       rcx,rsi
       call      00000000000008E8
       mov       rbx,rax
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       near ptr 000000000000A785
       movsxd    rcx,ebp
       mov       r15,[rbx+rcx*8+10]
       mov       rcx,rsi
       lea       rdx,[rsp+38]
       mov       [rsp+20],rdx
       mov       rdx,r15
       xor       r8d,r8d
       mov       r9d,1
       call      00000000000009D8
       mov       r12,[rsp+38]
       xor       edx,edx
       mov       [rsp+38],rdx
       mov       rdx,offset MT_System.Int32
       cmp       [r12],rdx
       je        short 000000000000A728
       mov       rdx,r12
       mov       rcx,offset MT_System.Int32
       call      0000000000007478
       mov       r12d,[r12+8]
       mov       rdx,r15
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       short 000000000000A761
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       movsxd    rax,eax
       shl       rax,4
       lea       r15,[rcx+rax+10]
       mov       rcx,r15
       call      000000000000B010
       mov       [r15+8],r12d
       jmp       short 000000000000A77A
       lea       rcx,[rsp+28]
       mov       [rcx],rdx
       mov       [rcx+8],r12d
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       call      000000000000A450
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr 000000000000A6D4
       mov       rax,rdi
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
       mov       ecx,4D
       mov       rdx,7FF82F33F850
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,333
       mov       rdx,7FF82F33F850
       call      0000000000000390
       mov       rdi,rax
       call      00000000000015A0
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      0000000000000658
       mov       rcx,rax
       call      000000000000F6C0
       int       3
; Total bytes of code 417
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumExtensionsBenchmark.GetItems01()
; 			var result = this._testEnum.GetItems();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.StringComparison
       call      000000000000EFB0
       mov       ecx,[rsi+0B4]
       mov       [rax+8],ecx
       mov       rcx,rax
       call      qword ptr [1FC0]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Extensions.EnumExtensions.GetItems(System.Enum)
       push      r15
       push      r14
       push      r12
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
       test      rsi,rsi
       jne       near ptr 000000000000E6A0
       call      qword ptr [9B28]
       mov       rsi,rax
       mov       ecx,7
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],5
       jl        near ptr 000000000000E7D3
       lea       rcx,[rdi+0C]
       mov       rdx,286AA804810
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr 000000000000E7F6
       lea       rcx,[rdi+16]
       mov       rdx,286AA802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000E5C1
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 000000000000E5C6
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000E661
       call      qword ptr [9C48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EF80A30
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EF80A30
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
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [9870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rdi,rax
       mov       rdx,286AA801FE8
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      0000000000000010
       mov       rcx,rsi
       call      00000000000053F0
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [15D0]
       mov       rbx,rax
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       near ptr 000000000000E7B5
       mov       ecx,ebp
       mov       r15,[rbx+rcx*8+10]
       mov       rcx,rsi
       test      r15,r15
       je        near ptr 000000000000E7C7
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       lea       rdx,[rsp+48]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+38]
       xor       r8d,r8d
       mov       r9d,1
       call      qword ptr [1768]
       mov       r12,[rsp+48]
       xor       edx,edx
       mov       [rsp+48],rdx
       mov       rcx,offset MT_System.Int32
       cmp       [r12],rcx
       je        short 000000000000E756
       mov       rdx,r12
       call      qword ptr [58D0]
       mov       r12d,[r12+8]
       mov       rdx,r15
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       short 000000000000E792
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       mov       eax,eax
       shl       rax,4
       lea       r15,[rcx+rax+10]
       mov       rcx,r15
       call      000000000000ECD0
       mov       [r15+8],r12d
       jmp       short 000000000000E7AA
       mov       [rsp+28],rdx
       mov       [rsp+30],r12d
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       call      qword ptr [31C8]
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr 000000000000E6EE
       mov       rax,rdi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
       mov       ecx,7
       call      qword ptr [7360]
       int       3
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [5F48]
       mov       rcx,rsi
       call      0000000000006AD0
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [5F48]
       mov       rcx,rsi
       call      0000000000006AD0
       int       3
; Total bytes of code 794
```

