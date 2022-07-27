## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+134]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      0000000000006870
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short 000000000000A620
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short 000000000000A622
       xor       eax,eax
       mov       edx,eax
       test      eax,eax
       jne       short 000000000000A632
       mov       esi,1
       jmp       near ptr 000000000000A74B
       test      edx,edx
       jne       near ptr 000000000000A74B
       call      0000000000002E68
       mov       rdi,rax
       mov       rcx,17C59B01720
       mov       rcx,[rcx]
       jmp       near ptr 000000000000A768
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000A706
       call      0000000000002ED0
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82F27A3D0
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82F27A3D0
       call      0000000000000390
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82F27A3D0
       call      0000000000000390
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      0000000000001FF8
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rbx,rax
       call      0000000000002D88
       mov       rdx,rax
       mov       rcx,rdi
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      00000000000001E8
       mov       rcx,rbx
       call      00000000000055B0
       mov       edx,3
       call      0000000000008468
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000B2D0
       mov       rbx,rax
       call      0000000000002D90
       mov       rdx,rax
       mov       rcx,rdi
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      0000000000005760
       mov       rcx,rbx
       call      00000000000055B0
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      00000000000013D8
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       cmp       dword ptr [rcx+8],0
       je        near ptr 000000000000A654
       xor       eax,eax
       jmp       near ptr 000000000000A659
; Total bytes of code 377
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+130]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7858]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 53
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short 000000000000DEF9
       mov       eax,1
       jmp       short 000000000000DEFB
       xor       eax,eax
       mov       edx,eax
       test      eax,eax
       jne       short 000000000000DF08
       mov       esi,1
       jmp       short 000000000000DF0C
       test      edx,edx
       je        short 000000000000DF2A
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [3918]
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       call      qword ptr [0BB10]
       mov       rsi,rax
       mov       rax,278F7800720
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000DFE4
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF81954B998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF81954B998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B888]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [3030]
       mov       rcx,rbx
       call      0000000000006AD0
       int       3
; Total bytes of code 334
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+134]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      0000000000006840
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short 000000000000A720
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short 000000000000A722
       xor       eax,eax
       mov       edx,eax
       test      eax,eax
       jne       short 000000000000A732
       mov       esi,1
       jmp       near ptr 000000000000A84B
       test      edx,edx
       jne       near ptr 000000000000A84B
       call      0000000000002E68
       mov       rdi,rax
       mov       rcx,18BE5359B00
       mov       rcx,[rcx]
       jmp       near ptr 000000000000A868
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000A806
       call      0000000000002ED0
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82F27A3D0
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82F27A3D0
       call      0000000000000390
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82F27A3D0
       call      0000000000000390
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      0000000000001FF8
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rbx,rax
       call      0000000000002D88
       mov       rdx,rax
       mov       rcx,rdi
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      00000000000001E8
       mov       rcx,rbx
       call      00000000000055B0
       mov       edx,3
       call      0000000000008468
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000B2D0
       mov       rbx,rax
       call      0000000000002D90
       mov       rdx,rax
       mov       rcx,rdi
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      0000000000005760
       mov       rcx,rbx
       call      00000000000055B0
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      00000000000013D8
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       cmp       dword ptr [rcx+8],0
       je        near ptr 000000000000A754
       xor       eax,eax
       jmp       near ptr 000000000000A759
; Total bytes of code 377
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+130]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7B58]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 53
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short 000000000000DEF9
       mov       eax,1
       jmp       short 000000000000DEFB
       xor       eax,eax
       mov       edx,eax
       test      eax,eax
       jne       short 000000000000DF08
       mov       esi,1
       jmp       short 000000000000DF0C
       test      edx,edx
       je        short 000000000000DF2A
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [3918]
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       call      qword ptr [0BB10]
       mov       rsi,rax
       mov       rax,24B18400720
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000DFE4
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B888]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [3030]
       mov       rcx,rbx
       call      0000000000006AD0
       int       3
; Total bytes of code 334
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+134]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      00000000000068A0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short 000000000000A5D0
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short 000000000000A5D2
       xor       eax,eax
       mov       edx,eax
       test      eax,eax
       jne       short 000000000000A5E2
       mov       esi,1
       jmp       near ptr 000000000000A6FB
       test      edx,edx
       jne       near ptr 000000000000A6FB
       call      0000000000002E68
       mov       rdi,rax
       mov       rcx,1B517EB9B00
       mov       rcx,[rcx]
       jmp       near ptr 000000000000A718
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000A6B6
       call      0000000000002ED0
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82F29A3D0
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82F29A3D0
       call      0000000000000390
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82F29A3D0
       call      0000000000000390
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      0000000000001FF8
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rbx,rax
       call      0000000000002D88
       mov       rdx,rax
       mov       rcx,rdi
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      00000000000001E8
       mov       rcx,rbx
       call      00000000000055B0
       mov       edx,3
       call      0000000000008468
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000B2D0
       mov       rbx,rax
       call      0000000000002D90
       mov       rdx,rax
       mov       rcx,rdi
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      0000000000005760
       mov       rcx,rbx
       call      00000000000055B0
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      00000000000013D8
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       cmp       dword ptr [rcx+8],0
       je        near ptr 000000000000A604
       xor       eax,eax
       jmp       near ptr 000000000000A609
; Total bytes of code 377
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+130]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7858]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 53
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short 000000000000DEF9
       mov       eax,1
       jmp       short 000000000000DEFB
       xor       eax,eax
       mov       edx,eax
       test      eax,eax
       jne       short 000000000000DF08
       mov       esi,1
       jmp       short 000000000000DF0C
       test      edx,edx
       je        short 000000000000DF2A
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [3918]
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       call      qword ptr [0BB10]
       mov       rsi,rax
       mov       rax,20018408B00
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000DFE4
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B888]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [3030]
       mov       rcx,rbx
       call      0000000000006AD0
       int       3
; Total bytes of code 334
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+134]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      00000000000068D0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short 000000000000A830
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short 000000000000A832
       xor       eax,eax
       mov       edx,eax
       test      eax,eax
       jne       short 000000000000A842
       mov       esi,1
       jmp       near ptr 000000000000A95B
       test      edx,edx
       jne       near ptr 000000000000A95B
       call      0000000000002E68
       mov       rdi,rax
       mov       rcx,264D7E29B00
       mov       rcx,[rcx]
       jmp       near ptr 000000000000A978
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000A916
       call      0000000000002ED0
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82F26A3D0
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82F26A3D0
       call      0000000000000390
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82F26A3D0
       call      0000000000000390
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      0000000000001FF8
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rbx,rax
       call      0000000000002D88
       mov       rdx,rax
       mov       rcx,rdi
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      00000000000001E8
       mov       rcx,rbx
       call      00000000000055B0
       mov       edx,3
       call      0000000000008468
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000B2D0
       mov       rbx,rax
       call      0000000000002D90
       mov       rdx,rax
       mov       rcx,rdi
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      0000000000005760
       mov       rcx,rbx
       call      00000000000055B0
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      00000000000013D8
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       cmp       dword ptr [rcx+8],0
       je        near ptr 000000000000A864
       xor       eax,eax
       jmp       near ptr 000000000000A869
; Total bytes of code 377
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+130]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7858]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 53
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short 000000000000DEF9
       mov       eax,1
       jmp       short 000000000000DEFB
       xor       eax,eax
       mov       edx,eax
       test      eax,eax
       jne       short 000000000000DF08
       mov       esi,1
       jmp       short 000000000000DF0C
       test      edx,edx
       je        short 000000000000DF2A
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [3918]
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       call      qword ptr [0BB10]
       mov       rsi,rax
       mov       rax,25F2A400720
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000DFE4
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B888]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [3030]
       mov       rcx,rbx
       call      0000000000006AD0
       int       3
; Total bytes of code 334
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+134]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      00000000000068D0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short 000000000000A680
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short 000000000000A682
       xor       eax,eax
       mov       edx,eax
       test      eax,eax
       jne       short 000000000000A692
       mov       esi,1
       jmp       near ptr 000000000000A7AB
       test      edx,edx
       jne       near ptr 000000000000A7AB
       call      0000000000002E68
       mov       rdi,rax
       mov       rcx,2149C0F1720
       mov       rcx,[rcx]
       jmp       near ptr 000000000000A7C8
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000A766
       call      0000000000002ED0
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82F27A3D0
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82F27A3D0
       call      0000000000000390
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82F27A3D0
       call      0000000000000390
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      0000000000001FF8
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rbx,rax
       call      0000000000002D88
       mov       rdx,rax
       mov       rcx,rdi
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      00000000000001E8
       mov       rcx,rbx
       call      00000000000055B0
       mov       edx,3
       call      0000000000008468
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000B2D0
       mov       rbx,rax
       call      0000000000002D90
       mov       rdx,rax
       mov       rcx,rdi
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      0000000000005760
       mov       rcx,rbx
       call      00000000000055B0
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      00000000000013D8
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       cmp       dword ptr [rcx+8],0
       je        near ptr 000000000000A6B4
       xor       eax,eax
       jmp       near ptr 000000000000A6B9
; Total bytes of code 377
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+130]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7B58]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 53
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short 000000000000DEF9
       mov       eax,1
       jmp       short 000000000000DEFB
       xor       eax,eax
       mov       edx,eax
       test      eax,eax
       jne       short 000000000000DF08
       mov       esi,1
       jmp       short 000000000000DF0C
       test      edx,edx
       je        short 000000000000DF2A
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [3918]
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       call      qword ptr [0BB10]
       mov       rsi,rax
       mov       rax,20D228046F8
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000DFE4
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B888]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [3030]
       mov       rcx,rbx
       call      0000000000006AD0
       int       3
; Total bytes of code 334
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+134]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      00000000000068D0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short 000000000000A680
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short 000000000000A682
       xor       eax,eax
       mov       edx,eax
       test      eax,eax
       jne       short 000000000000A692
       mov       esi,1
       jmp       near ptr 000000000000A7AB
       test      edx,edx
       jne       near ptr 000000000000A7AB
       call      0000000000002E68
       mov       rdi,rax
       mov       rcx,19D5E819B00
       mov       rcx,[rcx]
       jmp       near ptr 000000000000A7C8
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000A766
       call      0000000000002ED0
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82F26A3D0
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82F26A3D0
       call      0000000000000390
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82F26A3D0
       call      0000000000000390
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      0000000000001FF8
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rbx,rax
       call      0000000000002D88
       mov       rdx,rax
       mov       rcx,rdi
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      00000000000001E8
       mov       rcx,rbx
       call      00000000000055B0
       mov       edx,3
       call      0000000000008468
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000B2D0
       mov       rbx,rax
       call      0000000000002D90
       mov       rdx,rax
       mov       rcx,rdi
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      0000000000005760
       mov       rcx,rbx
       call      00000000000055B0
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      00000000000013D8
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       cmp       dword ptr [rcx+8],0
       je        near ptr 000000000000A6B4
       xor       eax,eax
       jmp       near ptr 000000000000A6B9
; Total bytes of code 377
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+130]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7B58]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 53
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short 000000000000DEF9
       mov       eax,1
       jmp       short 000000000000DEFB
       xor       eax,eax
       mov       edx,eax
       test      eax,eax
       jne       short 000000000000DF08
       mov       esi,1
       jmp       short 000000000000DF0C
       test      edx,edx
       je        short 000000000000DF2A
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [3918]
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       call      qword ptr [0BB10]
       mov       rsi,rax
       mov       rax,1F295400720
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000DFE4
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEDB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEDB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B888]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [3030]
       mov       rcx,rbx
       call      0000000000006AD0
       int       3
; Total bytes of code 334
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+134]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      00000000000068D0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short 000000000000A830
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short 000000000000A832
       xor       eax,eax
       mov       edx,eax
       test      eax,eax
       jne       short 000000000000A842
       mov       esi,1
       jmp       near ptr 000000000000A95B
       test      edx,edx
       jne       near ptr 000000000000A95B
       call      0000000000002E68
       mov       rdi,rax
       mov       rcx,1E0DCF79B00
       mov       rcx,[rcx]
       jmp       near ptr 000000000000A978
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000A916
       call      0000000000002ED0
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82F26A3D0
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82F26A3D0
       call      0000000000000390
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82F26A3D0
       call      0000000000000390
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      0000000000001FF8
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rbx,rax
       call      0000000000002D88
       mov       rdx,rax
       mov       rcx,rdi
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      00000000000001E8
       mov       rcx,rbx
       call      00000000000055B0
       mov       edx,3
       call      0000000000008468
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000B2D0
       mov       rbx,rax
       call      0000000000002D90
       mov       rdx,rax
       mov       rcx,rdi
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      0000000000005760
       mov       rcx,rbx
       call      00000000000055B0
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      00000000000013D8
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       cmp       dword ptr [rcx+8],0
       je        near ptr 000000000000A864
       xor       eax,eax
       jmp       near ptr 000000000000A869
; Total bytes of code 377
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+130]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7B58]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 53
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short 000000000000DEF9
       mov       eax,1
       jmp       short 000000000000DEFB
       xor       eax,eax
       mov       edx,eax
       test      eax,eax
       jne       short 000000000000DF08
       mov       esi,1
       jmp       short 000000000000DF0C
       test      edx,edx
       je        short 000000000000DF2A
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [3918]
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       call      qword ptr [0BB10]
       mov       rsi,rax
       mov       rax,1E423000720
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000DFE4
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B888]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [3030]
       mov       rcx,rbx
       call      0000000000006AD0
       int       3
; Total bytes of code 334
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+134]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      0000000000000E70
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short 0000000000007A80
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short 0000000000007A82
       xor       eax,eax
       mov       edx,eax
       test      eax,eax
       jne       short 0000000000007A92
       mov       esi,1
       jmp       near ptr 0000000000007BAB
       test      edx,edx
       jne       near ptr 0000000000007BAB
       call      0000000000002E68
       mov       rdi,rax
       mov       rcx,23120721720
       mov       rcx,[rcx]
       jmp       near ptr 0000000000007BC8
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 0000000000007B66
       call      0000000000002ED0
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82F28A3D0
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82F28A3D0
       call      0000000000000390
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82F28A3D0
       call      0000000000000390
       mov       rcx,rsi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      0000000000001FF8
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rbx,rax
       call      0000000000002D88
       mov       rdx,rax
       mov       rcx,rdi
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      00000000000001E8
       mov       rcx,rbx
       call      00000000000055B0
       mov       edx,3
       call      0000000000008468
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000B2D0
       mov       rbx,rax
       call      0000000000002D90
       mov       rdx,rax
       mov       rcx,rdi
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      0000000000005760
       mov       rcx,rbx
       call      00000000000055B0
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      00000000000013D8
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       cmp       dword ptr [rcx+8],0
       je        near ptr 0000000000007AB4
       xor       eax,eax
       jmp       near ptr 0000000000007AB9
; Total bytes of code 377
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate01()
; 			var result = Collection<Person>.Create(Count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+130]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [0F858]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 53
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       esi,edx
       test      esi,esi
       jle       short 000000000000ABA9
       mov       eax,1
       jmp       short 000000000000ABAB
       xor       eax,eax
       mov       edx,eax
       test      eax,eax
       jne       short 000000000000ABB8
       mov       esi,1
       jmp       short 000000000000ABBC
       test      edx,edx
       je        short 000000000000ABDA
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [3918]
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       call      qword ptr [0BB10]
       mov       rsi,rax
       mov       rax,1EA8B800720
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000AC94
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B888]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [3030]
       mov       rcx,rbx
       call      0000000000006AD0
       int       3
; Total bytes of code 334
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      000000000000F778
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      0000000000006850
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short 00000000000080C8
       mov       rcx,rdx
       call      000000000000FAB8
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short 00000000000080A5
       jmp       short 00000000000080BA
       mov       rcx,rsi
       mov       rdx,7FF82F2D1EC8
       call      0000000000004920
       mov       rcx,rax
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr 0000000000000378
       mov       ecx,4D
       mov       rdx,7FF82F26ED50
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,7C7
       mov       rdx,7FF82F26ED50
       call      0000000000000390
       mov       rdi,rax
       call      0000000000002E70
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      0000000000001F28
       mov       rcx,rax
       call      0000000000002F48
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 000000000000ABDC
       jmp       short 000000000000ABF1
       mov       rcx,rdi
       mov       rdx,7FF82F4A1718
       call      0000000000002740
       mov       rcx,rax
       mov       r8,257366E3020
       mov       r8,[r8]
       mov       r9,257366EB270
       mov       r9,[r9]
       mov       rdx,rbx
       call      000000000000DB40
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000004F40
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      0000000000000948
       test      eax,eax
       je        near ptr 000000000000AE5D
       mov       rcx,rdi
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,r15
       call      00000000000013D0
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AC6C
       jmp       short 000000000000AC81
       mov       rcx,rdi
       mov       rdx,7FF82F4A1970
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 000000000000AD3A
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AC9E
       jmp       short 000000000000ACB3
       mov       rcx,rdi
       mov       rdx,7FF82F4A1970
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 000000000000ACC6
       jmp       short 000000000000ACDB
       mov       rcx,rdi
       mov       rdx,7FF82F4A1C10
       call      0000000000002740
       mov       rcx,rax
       call      000000000000B2D0
       mov       r13,rax
       test      r12,r12
       je        near ptr 000000000000AF73
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      000000000000AEB0
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AD11
       jmp       short 000000000000AD26
       mov       rcx,rdi
       mov       rdx,7FF82F4A1970
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      000000000000AEB0
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 000000000000AD45
       jmp       short 000000000000AD5A
       mov       rcx,rdi
       mov       rdx,7FF82F4A19B0
       call      0000000000002740
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      00000000000065E0
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000AD73
       jmp       short 000000000000AD88
       mov       rcx,rdi
       mov       rdx,7FF82F4A19D0
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82EE706C8
       call      qword ptr [6C8]
       test      eax,eax
       je        near ptr 000000000000AE36
       mov       r11,[r14+30]
       test      r11,r11
       je        short 000000000000ADBB
       jmp       short 000000000000ADD0
       mov       rcx,rdi
       mov       rdx,7FF82F4A1A00
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 000000000000ADE0
       cmp       esi,0FFFFFFFE
       jne       short 000000000000ADED
       mov       rcx,r15
       mov       rdx,rax
       call      0000000000006828
       jmp       short 000000000000AE1B
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 000000000000AE10
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000008190
       jmp       short 000000000000AE1B
       mov       rcx,r15
       mov       rdx,rax
       call      0000000000001458
       mov       rcx,rbx
       mov       r11,7FF82EE706C8
       call      qword ptr [6C8]
       test      eax,eax
       jne       near ptr 000000000000ADB0
       mov       rcx,rbx
       mov       r11,7FF82EE706D0
       call      qword ptr [6D0]
       mov       rax,r15
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
       call      0000000000002DE8
       mov       rbx,rax
       mov       rax,257366EB810
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short 000000000000AE7C
       xor       eax,eax
       jmp       short 000000000000AE81
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000AF2E
       call      0000000000002ED0
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82F26A3D0
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82F26A3D0
       call      0000000000000390
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82F26A3D0
       call      0000000000000390
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      0000000000001FF8
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D88
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      00000000000001E8
       mov       rcx,rdi
       call      00000000000055B0
       mov       edx,3
       call      0000000000008468
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D90
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      0000000000005760
       mov       rcx,rdi
       call      00000000000055B0
       call      0000000000007270
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 000000000000AFB4
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82EE706D0
       call      qword ptr [6D0]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1062
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+110]
       test      rcx,rcx
       jne       near ptr 0000000000007C3F
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 0000000000007CBE
       lea       rcx,[rdi+0C]
       mov       rdx,1E525C025B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 0000000000007CE1
       lea       rcx,[rdi+12]
       mov       rdx,1E521C00098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,rsi
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [9708]
       mov       rdx,rax
       mov       r9,1E521C00D10
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1E521C00030
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull(!!0, !!0, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [3CF0]
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize(System.String)
       call      qword ptr [5828]
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [5888]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
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
; Total bytes of code 469
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr 0000000000004E30
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr 0000000000004E30
       lea       rsi,[rdx+r8]
       lea       rdi,[rcx+r8]
       cmp       r8,10
       jbe       short 0000000000004D86
       cmp       r8,40
       ja        short 0000000000004DAE
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short 0000000000004D79
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       ja        near ptr 0000000000004E12
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       pop       rsi
       pop       rdi
       ret
       test      r8b,18
       jne       short 0000000000004DFF
       test      r8b,4
       jne       short 0000000000004DF1
       test      r8,r8
       je        short 0000000000004D83
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short 0000000000004D83
       movsx     r8,word ptr [rsi+0FFFE]
       mov       [rdi+0FFFE],r8w
       jmp       short 0000000000004D83
       cmp       r8,800
       ja        near ptr 0000000000004E39
       mov       rax,r8
       shr       rax,6
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short 0000000000004DC2
       and       r8,3F
       cmp       r8,10
       ja        near ptr 0000000000004D57
       jmp       short 0000000000004E21
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rsi+0FFFC]
       mov       [rdi+0FFFC],edx
       jmp       short 0000000000004D83
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rsi+0FFF8]
       mov       [rdi+0FFF8],rdx
       jmp       near ptr 0000000000004D83
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
       jmp       near ptr 0000000000004D79
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       jmp       near ptr 0000000000004D83
       cmp       rcx,rdx
       je        near ptr 0000000000004D83
       pop       rsi
       pop       rdi
       jmp       qword ptr [5828]
; Total bytes of code 289
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short 000000000000A1D9
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short 000000000000A1D9
       test      rsi,rsi
       je        near ptr 000000000000A273
       jmp       short 000000000000A1F5
       test      rsi,rsi
       je        short 000000000000A259
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000A259
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000A273
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        short 000000000000A283
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [5810]
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short 000000000000A2A6
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,1E521C00030
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
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
; Total bytes of code 282
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short 0000000000007F9C
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short 0000000000007FB3
       jmp       short 0000000000007F9F
       xor       r9d,r9d
       test      r8,r8
       je        short 0000000000007FB3
       cmp       dword ptr [r8+8],0
       je        short 0000000000007FB3
       mov       rcx,r8
       jmp       near ptr 0000000000008059
       test      r9d,r9d
       jne       near ptr 0000000000008059
       call      qword ptr [0BC48]
       mov       rdi,rax
       test      rsi,rsi
       je        short 0000000000007FD2
       cmp       dword ptr [rsi+8],0
       je        short 0000000000007FD2
       jmp       short 0000000000007FD5
       mov       rsi,rdi
       mov       ecx,9
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       test      dl,dl
       jne       short 0000000000008068
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [0D4E0]
; Total bytes of code 268
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr 0000000000008486
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 00000000000084F1
       lea       rcx,[rdi+0C]
       mov       rdx,1E525C025B0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 0000000000008514
       lea       rcx,[rdi+12]
       mov       rdx,1E521C00098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 00000000000083A7
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 00000000000083AC
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 0000000000008447
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       [rsp+28],rcx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.GetRuntimeType(!!0 ByRef)
       call      qword ptr [0BEB8]
       mov       rsi,rax
       mov       rcx,1E523C05C30
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+85],0
       je        short 00000000000084E6
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0D840]
       mov       r8,rax
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteStringUsingSerializer(!!0 ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      qword ptr [1F78]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       call      qword ptr [0DE58]
       jmp       short 00000000000084B9
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
; Total bytes of code 568
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,r9
       mov       rdi,[rsp+80]
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       jne       near ptr 0000000000004FAC
       test      r8,r8
       je        short 0000000000004F24
       mov       rdx,r8
       jmp       near ptr 0000000000004FAC
       call      qword ptr [0BB28]
       mov       rbx,rax
       test      rdi,rdi
       je        short 0000000000004F9D
       mov       ebp,[rdi+8]
       test      ebp,ebp
       je        short 0000000000004F9D
       mov       r14d,ebp
       lea       ecx,[r14+2]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebp
       jl        short 0000000000004FBC
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       ecx,[r15+8]
       sub       ecx,r14d
       cmp       ecx,2
       jl        short 0000000000004FDF
       movsxd    rcx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       rdx,1E521C00098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,r15
       test      rsi,rsi
       jne       short 0000000000005002
       jmp       short 0000000000005016
       mov       rcx,1E521C00098
       mov       rcx,[rcx]
       jmp       short 0000000000004F96
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [5F48]
       mov       rcx,rsi
       call      0000000000006AD0
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [5F48]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       dword ptr [rsi+8],0
       je        short 0000000000005016
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       jmp       short 0000000000005022
       mov       rdx,rbx
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 0000000000005032
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 0000000000005037
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 00000000000050D2
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       int       3
; Total bytes of code 546
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        short 0000000000009DDC
       mov       eax,[rdx+8]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      eax,eax
       jne       short 0000000000009DDE
       jmp       short 0000000000009DDE
       xor       ecx,ecx
       test      ecx,ecx
       jne       near ptr 0000000000009E88
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,5E7
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short 0000000000009EB0
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short 0000000000009EC5
       mov       rcx,rsi
       mov       rdx,7FF82F0DB0F0
       call      0000000000000CA0
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [5888]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 298
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 000000000000601C
       jmp       short 0000000000006031
       mov       rcx,rdi
       mov       rdx,7FF82F1B3AD8
       call      00000000000087F0
       mov       rcx,rax
       mov       r8,1E521C00030
       mov       r8,[r8]
       mov       r9,1E521C00A30
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [3C00]
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000003330
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr 00000000000062A3
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [8A70]
       test      eax,eax
       je        near ptr 00000000000062C1
       mov       rcx,rdi
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [3900]
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 00000000000060B8
       jmp       short 00000000000060CD
       mov       rcx,rdi
       mov       rdx,7FF82F1B3D30
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 0000000000006186
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 00000000000060EA
       jmp       short 00000000000060FF
       mov       rcx,rdi
       mov       rdx,7FF82F1B3D30
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 0000000000006112
       jmp       short 0000000000006127
       mov       rcx,rdi
       mov       rdx,7FF82F1B3FC0
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EFB0
       mov       r13,rax
       test      r12,r12
       je        near ptr 00000000000063C4
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      0000000000000010
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000615D
       jmp       short 0000000000006172
       mov       rcx,rdi
       mov       rdx,7FF82F1B3D30
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      0000000000000010
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 0000000000006191
       jmp       short 00000000000061A6
       mov       rcx,rdi
       mov       rdx,7FF82F1B3D70
       call      00000000000087F0
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [5BA0]
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 00000000000061C0
       jmp       short 00000000000061D5
       mov       rcx,rdi
       mov       rdx,7FF82F1B3D90
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82E9B0820
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr 000000000000627F
       mov       r11,[r14+30]
       test      r11,r11
       je        short 0000000000006205
       jmp       short 000000000000621A
       mov       rcx,rdi
       mov       rdx,7FF82F1B3DC0
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 000000000000622A
       cmp       esi,0FFFFFFFE
       jne       short 0000000000006238
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [5810]
       jmp       short 0000000000006267
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 000000000000625B
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000000020
       jmp       short 0000000000006267
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [3A98]
       mov       rcx,rbx
       mov       r11,7FF82E9B0820
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr 00000000000061FA
       mov       rcx,rbx
       mov       r11,7FF82E9B0828
       call      qword ptr [r11]
       mov       rax,r15
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
       mov       ecx,2E7
       mov       rdx,7FF82E9A4000
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       call      qword ptr [0B990]
       mov       rbx,rax
       mov       rax,1E521C00FE0
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000637B
       call      qword ptr [0BC48]
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rsi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B888]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [3030]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [5630]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 0000000000006403
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82E9B0828
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1077
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      000000000000F778
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      00000000000068E0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short 00000000000080C8
       mov       rcx,rdx
       call      000000000000FAB8
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short 00000000000080A5
       jmp       short 00000000000080BA
       mov       rcx,rsi
       mov       rdx,7FF82F2D1EC8
       call      0000000000004920
       mov       rcx,rax
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr 0000000000000378
       mov       ecx,4D
       mov       rdx,7FF82F26ED50
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,7C7
       mov       rdx,7FF82F26ED50
       call      0000000000000390
       mov       rdi,rax
       call      0000000000002E70
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      0000000000001F28
       mov       rcx,rax
       call      0000000000002F48
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 000000000000ACDC
       jmp       short 000000000000ACF1
       mov       rcx,rdi
       mov       rdx,7FF82F4A1780
       call      0000000000002740
       mov       rcx,rax
       mov       r8,12975AF3020
       mov       r8,[r8]
       mov       r9,12995AF1660
       mov       r9,[r9]
       mov       rdx,rbx
       call      000000000000DD00
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000004F40
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      0000000000000948
       test      eax,eax
       je        near ptr 000000000000AF5D
       mov       rcx,rdi
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,r15
       call      00000000000013D0
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AD6C
       jmp       short 000000000000AD81
       mov       rcx,rdi
       mov       rdx,7FF82F4A19D8
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 000000000000AE3A
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AD9E
       jmp       short 000000000000ADB3
       mov       rcx,rdi
       mov       rdx,7FF82F4A19D8
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 000000000000ADC6
       jmp       short 000000000000ADDB
       mov       rcx,rdi
       mov       rdx,7FF82F4A1C78
       call      0000000000002740
       mov       rcx,rax
       call      000000000000B2D0
       mov       r13,rax
       test      r12,r12
       je        near ptr 000000000000B073
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      000000000000AEB0
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AE11
       jmp       short 000000000000AE26
       mov       rcx,rdi
       mov       rdx,7FF82F4A19D8
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      000000000000AEB0
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 000000000000AE45
       jmp       short 000000000000AE5A
       mov       rcx,rdi
       mov       rdx,7FF82F4A1A18
       call      0000000000002740
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      00000000000065E0
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000AE73
       jmp       short 000000000000AE88
       mov       rcx,rdi
       mov       rdx,7FF82F4A1A38
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82EE706C8
       call      qword ptr [6C8]
       test      eax,eax
       je        near ptr 000000000000AF36
       mov       r11,[r14+30]
       test      r11,r11
       je        short 000000000000AEBB
       jmp       short 000000000000AED0
       mov       rcx,rdi
       mov       rdx,7FF82F4A1A68
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 000000000000AEE0
       cmp       esi,0FFFFFFFE
       jne       short 000000000000AEED
       mov       rcx,r15
       mov       rdx,rax
       call      00000000000068B8
       jmp       short 000000000000AF1B
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 000000000000AF10
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000008190
       jmp       short 000000000000AF1B
       mov       rcx,r15
       mov       rdx,rax
       call      0000000000001458
       mov       rcx,rbx
       mov       r11,7FF82EE706C8
       call      qword ptr [6C8]
       test      eax,eax
       jne       near ptr 000000000000AEB0
       mov       rcx,rbx
       mov       r11,7FF82EE706D0
       call      qword ptr [6D0]
       mov       rax,r15
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
       call      0000000000002DE8
       mov       rbx,rax
       mov       rax,12995AF1C00
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short 000000000000AF7C
       xor       eax,eax
       jmp       short 000000000000AF81
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000B02E
       call      0000000000002ED0
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82F26A3D0
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82F26A3D0
       call      0000000000000390
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82F26A3D0
       call      0000000000000390
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      0000000000001FF8
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D88
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      00000000000001E8
       mov       rcx,rdi
       call      00000000000055B0
       mov       edx,3
       call      0000000000008468
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D90
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      0000000000005760
       mov       rcx,rdi
       call      00000000000055B0
       call      0000000000007270
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 000000000000B0B4
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82EE706D0
       call      qword ptr [6D0]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1062
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+110]
       test      rcx,rcx
       jne       near ptr 0000000000007D3F
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 0000000000007DBE
       lea       rcx,[rdi+0C]
       mov       rdx,21D7BC005B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 0000000000007DE1
       lea       rcx,[rdi+12]
       mov       rdx,21D79C00098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,rsi
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [9708]
       mov       rdx,rax
       mov       r9,21D7DC03908
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,21D79C00030
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull(!!0, !!0, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [3CF0]
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize(System.String)
       call      qword ptr [5828]
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [5888]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
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
; Total bytes of code 469
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr 0000000000004BD0
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr 0000000000004BD0
       lea       rsi,[rdx+r8]
       lea       rdi,[rcx+r8]
       cmp       r8,10
       jbe       short 0000000000004B26
       cmp       r8,40
       ja        short 0000000000004B4E
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short 0000000000004B19
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       ja        near ptr 0000000000004BB2
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       pop       rsi
       pop       rdi
       ret
       test      r8b,18
       jne       short 0000000000004B9F
       test      r8b,4
       jne       short 0000000000004B91
       test      r8,r8
       je        short 0000000000004B23
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short 0000000000004B23
       movsx     r8,word ptr [rsi+0FFFE]
       mov       [rdi+0FFFE],r8w
       jmp       short 0000000000004B23
       cmp       r8,800
       ja        near ptr 0000000000004BD9
       mov       rax,r8
       shr       rax,6
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short 0000000000004B62
       and       r8,3F
       cmp       r8,10
       ja        near ptr 0000000000004AF7
       jmp       short 0000000000004BC1
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rsi+0FFFC]
       mov       [rdi+0FFFC],edx
       jmp       short 0000000000004B23
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rsi+0FFF8]
       mov       [rdi+0FFF8],rdx
       jmp       near ptr 0000000000004B23
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
       jmp       near ptr 0000000000004B19
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       jmp       near ptr 0000000000004B23
       cmp       rcx,rdx
       je        near ptr 0000000000004B23
       pop       rsi
       pop       rdi
       jmp       qword ptr [5828]
; Total bytes of code 289
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short 000000000000A109
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short 000000000000A109
       test      rsi,rsi
       je        near ptr 000000000000A1A3
       jmp       short 000000000000A125
       test      rsi,rsi
       je        short 000000000000A189
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000A189
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000A1A3
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        short 000000000000A1B3
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [5810]
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short 000000000000A1D6
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,21D79C00030
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
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
; Total bytes of code 282
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short 0000000000007F3C
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short 0000000000007F53
       jmp       short 0000000000007F3F
       xor       r9d,r9d
       test      r8,r8
       je        short 0000000000007F53
       cmp       dword ptr [r8+8],0
       je        short 0000000000007F53
       mov       rcx,r8
       jmp       near ptr 0000000000007FF9
       test      r9d,r9d
       jne       near ptr 0000000000007FF9
       call      qword ptr [0BC48]
       mov       rdi,rax
       test      rsi,rsi
       je        short 0000000000007F72
       cmp       dword ptr [rsi+8],0
       je        short 0000000000007F72
       jmp       short 0000000000007F75
       mov       rsi,rdi
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       test      dl,dl
       jne       short 0000000000008008
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [0D4E0]
; Total bytes of code 268
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr 0000000000008586
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 00000000000085F1
       lea       rcx,[rdi+0C]
       mov       rdx,21D7BC005B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 0000000000008614
       lea       rcx,[rdi+12]
       mov       rdx,21D79C00098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 00000000000084A7
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 00000000000084AC
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 0000000000008547
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       [rsp+28],rcx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.GetRuntimeType(!!0 ByRef)
       call      qword ptr [0BEB8]
       mov       rsi,rax
       mov       rcx,21D7FC03C38
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+85],0
       je        short 00000000000085E6
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0D840]
       mov       r8,rax
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteStringUsingSerializer(!!0 ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      qword ptr [1F78]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       call      qword ptr [0DE58]
       jmp       short 00000000000085B9
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
; Total bytes of code 568
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,r9
       mov       rdi,[rsp+80]
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       jne       near ptr 0000000000004FFC
       test      r8,r8
       je        short 0000000000004F74
       mov       rdx,r8
       jmp       near ptr 0000000000004FFC
       call      qword ptr [0BB28]
       mov       rbx,rax
       test      rdi,rdi
       je        short 0000000000004FED
       mov       ebp,[rdi+8]
       test      ebp,ebp
       je        short 0000000000004FED
       mov       r14d,ebp
       lea       ecx,[r14+2]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebp
       jl        short 000000000000500C
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       ecx,[r15+8]
       sub       ecx,r14d
       cmp       ecx,2
       jl        short 000000000000502F
       movsxd    rcx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       rdx,21D79C00098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,r15
       test      rsi,rsi
       jne       short 0000000000005052
       jmp       short 0000000000005066
       mov       rcx,21D79C00098
       mov       rcx,[rcx]
       jmp       short 0000000000004FE6
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [5F48]
       mov       rcx,rsi
       call      0000000000006AD0
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [5F48]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       dword ptr [rsi+8],0
       je        short 0000000000005066
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       jmp       short 0000000000005072
       mov       rdx,rbx
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 0000000000005082
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 0000000000005087
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 0000000000005122
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       int       3
; Total bytes of code 546
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        short 0000000000009EDC
       mov       eax,[rdx+8]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      eax,eax
       jne       short 0000000000009EDE
       jmp       short 0000000000009EDE
       xor       ecx,ecx
       test      ecx,ecx
       jne       near ptr 0000000000009F88
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,5E7
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short 0000000000009FB0
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short 0000000000009FC5
       mov       rcx,rsi
       mov       rdx,7FF82F0AB0F0
       call      0000000000000CA0
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [5888]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 298
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 000000000000611C
       jmp       short 0000000000006131
       mov       rcx,rdi
       mov       rdx,7FF82F183AF0
       call      00000000000087F0
       mov       rcx,rax
       mov       r8,21D79C00030
       mov       r8,[r8]
       mov       r9,21D7DC03628
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [3C00]
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000003330
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr 00000000000063A3
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [8A70]
       test      eax,eax
       je        near ptr 00000000000063C1
       mov       rcx,rdi
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [3900]
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 00000000000061B8
       jmp       short 00000000000061CD
       mov       rcx,rdi
       mov       rdx,7FF82F183D48
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 0000000000006286
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 00000000000061EA
       jmp       short 00000000000061FF
       mov       rcx,rdi
       mov       rdx,7FF82F183D48
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 0000000000006212
       jmp       short 0000000000006227
       mov       rcx,rdi
       mov       rdx,7FF82F183FD8
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EFB0
       mov       r13,rax
       test      r12,r12
       je        near ptr 00000000000064C4
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      0000000000000010
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000625D
       jmp       short 0000000000006272
       mov       rcx,rdi
       mov       rdx,7FF82F183D48
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      0000000000000010
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 0000000000006291
       jmp       short 00000000000062A6
       mov       rcx,rdi
       mov       rdx,7FF82F183D88
       call      00000000000087F0
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [5BA0]
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 00000000000062C0
       jmp       short 00000000000062D5
       mov       rcx,rdi
       mov       rdx,7FF82F183DA8
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82E980820
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr 000000000000637F
       mov       r11,[r14+30]
       test      r11,r11
       je        short 0000000000006305
       jmp       short 000000000000631A
       mov       rcx,rdi
       mov       rdx,7FF82F183DD8
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 000000000000632A
       cmp       esi,0FFFFFFFE
       jne       short 0000000000006338
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [5810]
       jmp       short 0000000000006367
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 000000000000635B
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000000020
       jmp       short 0000000000006367
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [3A98]
       mov       rcx,rbx
       mov       r11,7FF82E980820
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr 00000000000062FA
       mov       rcx,rbx
       mov       r11,7FF82E980828
       call      qword ptr [r11]
       mov       rax,r15
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
       mov       ecx,2E7
       mov       rdx,7FF82E974000
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       call      qword ptr [0B990]
       mov       rbx,rax
       mov       rax,21D7DC03BD8
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000647B
       call      qword ptr [0BC48]
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rsi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B888]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [3030]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [5630]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 0000000000006503
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82E980828
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1077
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      000000000000F778
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      00000000000068E0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short 0000000000005B58
       mov       rcx,rdx
       call      000000000000FAB8
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short 0000000000005B35
       jmp       short 0000000000005B4A
       mov       rcx,rsi
       mov       rdx,7FF82F301EC8
       call      0000000000004920
       mov       rcx,rax
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr 0000000000000378
       mov       ecx,4D
       mov       rdx,7FF82F29ED50
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,7C7
       mov       rdx,7FF82F29ED50
       call      0000000000000390
       mov       rdi,rax
       call      0000000000002E70
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      0000000000001F28
       mov       rcx,rax
       call      0000000000002F48
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 000000000000ACDC
       jmp       short 000000000000ACF1
       mov       rcx,rdi
       mov       rdx,7FF82F4D1780
       call      0000000000002740
       mov       rcx,rax
       mov       r8,23D26BB3020
       mov       r8,[r8]
       mov       r9,23D06BB1660
       mov       r9,[r9]
       mov       rdx,rbx
       call      000000000000DD00
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000004F40
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      0000000000000948
       test      eax,eax
       je        near ptr 000000000000AF5D
       mov       rcx,rdi
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,r15
       call      00000000000013D0
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AD6C
       jmp       short 000000000000AD81
       mov       rcx,rdi
       mov       rdx,7FF82F4D19D8
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 000000000000AE3A
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AD9E
       jmp       short 000000000000ADB3
       mov       rcx,rdi
       mov       rdx,7FF82F4D19D8
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 000000000000ADC6
       jmp       short 000000000000ADDB
       mov       rcx,rdi
       mov       rdx,7FF82F4D1C78
       call      0000000000002740
       mov       rcx,rax
       call      000000000000B2D0
       mov       r13,rax
       test      r12,r12
       je        near ptr 000000000000B073
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      000000000000AEB0
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AE11
       jmp       short 000000000000AE26
       mov       rcx,rdi
       mov       rdx,7FF82F4D19D8
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      000000000000AEB0
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 000000000000AE45
       jmp       short 000000000000AE5A
       mov       rcx,rdi
       mov       rdx,7FF82F4D1A18
       call      0000000000002740
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      00000000000065E0
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000AE73
       jmp       short 000000000000AE88
       mov       rcx,rdi
       mov       rdx,7FF82F4D1A38
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82EEA06C8
       call      qword ptr [6C8]
       test      eax,eax
       je        near ptr 000000000000AF36
       mov       r11,[r14+30]
       test      r11,r11
       je        short 000000000000AEBB
       jmp       short 000000000000AED0
       mov       rcx,rdi
       mov       rdx,7FF82F4D1A68
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 000000000000AEE0
       cmp       esi,0FFFFFFFE
       jne       short 000000000000AEED
       mov       rcx,r15
       mov       rdx,rax
       call      00000000000068B8
       jmp       short 000000000000AF1B
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 000000000000AF10
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000008190
       jmp       short 000000000000AF1B
       mov       rcx,r15
       mov       rdx,rax
       call      0000000000001458
       mov       rcx,rbx
       mov       r11,7FF82EEA06C8
       call      qword ptr [6C8]
       test      eax,eax
       jne       near ptr 000000000000AEB0
       mov       rcx,rbx
       mov       r11,7FF82EEA06D0
       call      qword ptr [6D0]
       mov       rax,r15
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
       call      0000000000002DE8
       mov       rbx,rax
       mov       rax,23D06BB1C00
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short 000000000000AF7C
       xor       eax,eax
       jmp       short 000000000000AF81
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000B02E
       call      0000000000002ED0
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82F29A3D0
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82F29A3D0
       call      0000000000000390
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82F29A3D0
       call      0000000000000390
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      0000000000001FF8
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D88
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      00000000000001E8
       mov       rcx,rdi
       call      00000000000055B0
       mov       edx,3
       call      0000000000008468
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D90
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      0000000000005760
       mov       rcx,rdi
       call      00000000000055B0
       call      0000000000007270
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 000000000000B0B4
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82EEA06D0
       call      qword ptr [6D0]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1062
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+110]
       test      rcx,rcx
       jne       near ptr 000000000000A8BF
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 000000000000A93E
       lea       rcx,[rdi+0C]
       mov       rdx,295230005B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 000000000000A961
       lea       rcx,[rdi+12]
       mov       rdx,29525000098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,rsi
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [9708]
       mov       rdx,rax
       mov       r9,29525006CE0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,29525000030
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull(!!0, !!0, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [3CF0]
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize(System.String)
       call      qword ptr [5828]
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7B88]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
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
; Total bytes of code 469
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr 0000000000004230
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr 0000000000004230
       lea       rsi,[rdx+r8]
       lea       rdi,[rcx+r8]
       cmp       r8,10
       jbe       short 0000000000004186
       cmp       r8,40
       ja        short 00000000000041AE
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short 0000000000004179
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       ja        near ptr 0000000000004212
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       pop       rsi
       pop       rdi
       ret
       test      r8b,18
       jne       short 00000000000041FF
       test      r8b,4
       jne       short 00000000000041F1
       test      r8,r8
       je        short 0000000000004183
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short 0000000000004183
       movsx     r8,word ptr [rsi+0FFFE]
       mov       [rdi+0FFFE],r8w
       jmp       short 0000000000004183
       cmp       r8,800
       ja        near ptr 0000000000004239
       mov       rax,r8
       shr       rax,6
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short 00000000000041C2
       and       r8,3F
       cmp       r8,10
       ja        near ptr 0000000000004157
       jmp       short 0000000000004221
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rsi+0FFFC]
       mov       [rdi+0FFFC],edx
       jmp       short 0000000000004183
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rsi+0FFF8]
       mov       [rdi+0FFF8],rdx
       jmp       near ptr 0000000000004183
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
       jmp       near ptr 0000000000004179
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       jmp       near ptr 0000000000004183
       cmp       rcx,rdx
       je        near ptr 0000000000004183
       pop       rsi
       pop       rdi
       jmp       qword ptr [5828]
; Total bytes of code 289
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short 000000000000A3D9
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short 000000000000A3D9
       test      rsi,rsi
       je        near ptr 000000000000A473
       jmp       short 000000000000A3F5
       test      rsi,rsi
       je        short 000000000000A459
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000A459
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000A473
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        short 000000000000A483
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [5810]
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short 000000000000A4A6
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,29525000030
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
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
; Total bytes of code 282
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short 000000000000AACC
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short 000000000000AAE3
       jmp       short 000000000000AACF
       xor       r9d,r9d
       test      r8,r8
       je        short 000000000000AAE3
       cmp       dword ptr [r8+8],0
       je        short 000000000000AAE3
       mov       rcx,r8
       jmp       near ptr 000000000000AB89
       test      r9d,r9d
       jne       near ptr 000000000000AB89
       call      qword ptr [0BC48]
       mov       rdi,rax
       test      rsi,rsi
       je        short 000000000000AB02
       cmp       dword ptr [rsi+8],0
       je        short 000000000000AB02
       jmp       short 000000000000AB05
       mov       rsi,rdi
       mov       ecx,9
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       test      dl,dl
       jne       short 000000000000AB98
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [0D4E0]
; Total bytes of code 268
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr 000000000000B106
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 000000000000B171
       lea       rcx,[rdi+0C]
       mov       rdx,295230005B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 000000000000B194
       lea       rcx,[rdi+12]
       mov       rdx,29525000098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000B027
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 000000000000B02C
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000B0C7
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       [rsp+28],rcx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.GetRuntimeType(!!0 ByRef)
       call      qword ptr [0BEB8]
       mov       rsi,rax
       mov       rcx,29525006048
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+85],0
       je        short 000000000000B166
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0D840]
       mov       r8,rax
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteStringUsingSerializer(!!0 ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      qword ptr [1F78]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       call      qword ptr [0DE58]
       jmp       short 000000000000B139
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
; Total bytes of code 568
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,r9
       mov       rdi,[rsp+80]
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       jne       near ptr 00000000000054DC
       test      r8,r8
       je        short 0000000000005454
       mov       rdx,r8
       jmp       near ptr 00000000000054DC
       call      qword ptr [0BB28]
       mov       rbx,rax
       test      rdi,rdi
       je        short 00000000000054CD
       mov       ebp,[rdi+8]
       test      ebp,ebp
       je        short 00000000000054CD
       mov       r14d,ebp
       lea       ecx,[r14+2]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebp
       jl        short 00000000000054EC
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       ecx,[r15+8]
       sub       ecx,r14d
       cmp       ecx,2
       jl        short 000000000000550F
       movsxd    rcx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       rdx,29525000098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,r15
       test      rsi,rsi
       jne       short 0000000000005532
       jmp       short 0000000000005546
       mov       rcx,29525000098
       mov       rcx,[rcx]
       jmp       short 00000000000054C6
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [5F48]
       mov       rcx,rsi
       call      0000000000006AD0
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [5F48]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       dword ptr [rsi+8],0
       je        short 0000000000005546
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       jmp       short 0000000000005552
       mov       rdx,rbx
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 0000000000005562
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 0000000000005567
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 0000000000005602
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       int       3
; Total bytes of code 546
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        short 0000000000006B0C
       mov       eax,[rdx+8]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      eax,eax
       jne       short 0000000000006B0E
       jmp       short 0000000000006B0E
       xor       ecx,ecx
       test      ecx,ecx
       jne       near ptr 0000000000006BB8
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,5E7
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short 0000000000006BE0
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short 0000000000006BF5
       mov       rcx,rsi
       mov       rdx,7FF82F0BB0F0
       call      0000000000000CA0
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [5888]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 298
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 0000000000008F1C
       jmp       short 0000000000008F31
       mov       rcx,rdi
       mov       rdx,7FF82F193AF0
       call      00000000000087F0
       mov       rcx,rax
       mov       r8,29525000030
       mov       r8,[r8]
       mov       r9,29525006A00
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7300]
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000003330
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr 00000000000091A3
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [8A70]
       test      eax,eax
       je        near ptr 00000000000091C1
       mov       rcx,rdi
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [3900]
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 0000000000008FB8
       jmp       short 0000000000008FCD
       mov       rcx,rdi
       mov       rdx,7FF82F193D48
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 0000000000009086
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 0000000000008FEA
       jmp       short 0000000000008FFF
       mov       rcx,rdi
       mov       rdx,7FF82F193D48
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 0000000000009012
       jmp       short 0000000000009027
       mov       rcx,rdi
       mov       rdx,7FF82F193FD8
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EFB0
       mov       r13,rax
       test      r12,r12
       je        near ptr 00000000000092C4
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      0000000000000010
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000905D
       jmp       short 0000000000009072
       mov       rcx,rdi
       mov       rdx,7FF82F193D48
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      0000000000000010
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 0000000000009091
       jmp       short 00000000000090A6
       mov       rcx,rdi
       mov       rdx,7FF82F193D88
       call      00000000000087F0
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [5BA0]
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 00000000000090C0
       jmp       short 00000000000090D5
       mov       rcx,rdi
       mov       rdx,7FF82F193DA8
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82E990838
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr 000000000000917F
       mov       r11,[r14+30]
       test      r11,r11
       je        short 0000000000009105
       jmp       short 000000000000911A
       mov       rcx,rdi
       mov       rdx,7FF82F193DD8
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 000000000000912A
       cmp       esi,0FFFFFFFE
       jne       short 0000000000009138
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7B10]
       jmp       short 0000000000009167
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 000000000000915B
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000000020
       jmp       short 0000000000009167
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [3A98]
       mov       rcx,rbx
       mov       r11,7FF82E990838
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr 00000000000090FA
       mov       rcx,rbx
       mov       r11,7FF82E990840
       call      qword ptr [r11]
       mov       rax,r15
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
       mov       ecx,2E7
       mov       rdx,7FF82E984000
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       call      qword ptr [0B990]
       mov       rbx,rax
       mov       rax,29525006FB0
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000927B
       call      qword ptr [0BC48]
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rsi,rax
       mov       ecx,36B
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B888]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [3030]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [5630]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 0000000000009303
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82E990840
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1077
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      000000000000F778
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      00000000000068E0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short 0000000000005C58
       mov       rcx,rdx
       call      000000000000FAB8
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short 0000000000005C35
       jmp       short 0000000000005C4A
       mov       rcx,rsi
       mov       rdx,7FF82F2D1EC8
       call      0000000000004920
       mov       rcx,rax
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr 0000000000000378
       mov       ecx,4D
       mov       rdx,7FF82F26ED50
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,7C7
       mov       rdx,7FF82F26ED50
       call      0000000000000390
       mov       rdi,rax
       call      0000000000002E70
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      0000000000001F28
       mov       rcx,rax
       call      0000000000002F48
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 000000000000ACDC
       jmp       short 000000000000ACF1
       mov       rcx,rdi
       mov       rdx,7FF82F4A1780
       call      0000000000002740
       mov       rcx,rax
       mov       r8,1DC4A481028
       mov       r8,[r8]
       mov       r9,1DC6A483658
       mov       r9,[r9]
       mov       rdx,rbx
       call      000000000000DD00
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000004F40
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      0000000000000948
       test      eax,eax
       je        near ptr 000000000000AF5D
       mov       rcx,rdi
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,r15
       call      00000000000013D0
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AD6C
       jmp       short 000000000000AD81
       mov       rcx,rdi
       mov       rdx,7FF82F4A19D8
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 000000000000AE3A
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AD9E
       jmp       short 000000000000ADB3
       mov       rcx,rdi
       mov       rdx,7FF82F4A19D8
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 000000000000ADC6
       jmp       short 000000000000ADDB
       mov       rcx,rdi
       mov       rdx,7FF82F4A1C78
       call      0000000000002740
       mov       rcx,rax
       call      000000000000B2D0
       mov       r13,rax
       test      r12,r12
       je        near ptr 000000000000B073
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      000000000000AEB0
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AE11
       jmp       short 000000000000AE26
       mov       rcx,rdi
       mov       rdx,7FF82F4A19D8
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      000000000000AEB0
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 000000000000AE45
       jmp       short 000000000000AE5A
       mov       rcx,rdi
       mov       rdx,7FF82F4A1A18
       call      0000000000002740
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      00000000000065E0
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000AE73
       jmp       short 000000000000AE88
       mov       rcx,rdi
       mov       rdx,7FF82F4A1A38
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82EE706C8
       call      qword ptr [6C8]
       test      eax,eax
       je        near ptr 000000000000AF36
       mov       r11,[r14+30]
       test      r11,r11
       je        short 000000000000AEBB
       jmp       short 000000000000AED0
       mov       rcx,rdi
       mov       rdx,7FF82F4A1A68
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 000000000000AEE0
       cmp       esi,0FFFFFFFE
       jne       short 000000000000AEED
       mov       rcx,r15
       mov       rdx,rax
       call      00000000000068B8
       jmp       short 000000000000AF1B
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 000000000000AF10
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000008190
       jmp       short 000000000000AF1B
       mov       rcx,r15
       mov       rdx,rax
       call      0000000000001458
       mov       rcx,rbx
       mov       r11,7FF82EE706C8
       call      qword ptr [6C8]
       test      eax,eax
       jne       near ptr 000000000000AEB0
       mov       rcx,rbx
       mov       r11,7FF82EE706D0
       call      qword ptr [6D0]
       mov       rax,r15
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
       call      0000000000002DE8
       mov       rbx,rax
       mov       rax,1DC6A483BF8
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short 000000000000AF7C
       xor       eax,eax
       jmp       short 000000000000AF81
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000B02E
       call      0000000000002ED0
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82F26A3D0
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82F26A3D0
       call      0000000000000390
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82F26A3D0
       call      0000000000000390
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      0000000000001FF8
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D88
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      00000000000001E8
       mov       rcx,rdi
       call      00000000000055B0
       mov       edx,3
       call      0000000000008468
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D90
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      0000000000005760
       mov       rcx,rdi
       call      00000000000055B0
       call      0000000000007270
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 000000000000B0B4
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82EE706D0
       call      qword ptr [6D0]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1062
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+110]
       test      rcx,rcx
       jne       near ptr 000000000000A8FF
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 000000000000A97E
       lea       rcx,[rdi+0C]
       mov       rdx,23111C005B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 000000000000A9A1
       lea       rcx,[rdi+12]
       mov       rdx,2310FC00098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,rsi
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [9708]
       mov       rdx,rax
       mov       r9,2310FC06CE0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2310FC00030
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull(!!0, !!0, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [3CF0]
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize(System.String)
       call      qword ptr [5828]
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7888]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
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
; Total bytes of code 469
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr 0000000000004230
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr 0000000000004230
       lea       rsi,[rdx+r8]
       lea       rdi,[rcx+r8]
       cmp       r8,10
       jbe       short 0000000000004186
       cmp       r8,40
       ja        short 00000000000041AE
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short 0000000000004179
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       ja        near ptr 0000000000004212
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       pop       rsi
       pop       rdi
       ret
       test      r8b,18
       jne       short 00000000000041FF
       test      r8b,4
       jne       short 00000000000041F1
       test      r8,r8
       je        short 0000000000004183
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short 0000000000004183
       movsx     r8,word ptr [rsi+0FFFE]
       mov       [rdi+0FFFE],r8w
       jmp       short 0000000000004183
       cmp       r8,800
       ja        near ptr 0000000000004239
       mov       rax,r8
       shr       rax,6
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short 00000000000041C2
       and       r8,3F
       cmp       r8,10
       ja        near ptr 0000000000004157
       jmp       short 0000000000004221
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rsi+0FFFC]
       mov       [rdi+0FFFC],edx
       jmp       short 0000000000004183
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rsi+0FFF8]
       mov       [rdi+0FFF8],rdx
       jmp       near ptr 0000000000004183
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
       jmp       near ptr 0000000000004179
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       jmp       near ptr 0000000000004183
       cmp       rcx,rdx
       je        near ptr 0000000000004183
       pop       rsi
       pop       rdi
       jmp       qword ptr [5828]
; Total bytes of code 289
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short 000000000000A419
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short 000000000000A419
       test      rsi,rsi
       je        near ptr 000000000000A4B3
       jmp       short 000000000000A435
       test      rsi,rsi
       je        short 000000000000A499
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000A499
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000A4B3
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        short 000000000000A4C3
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [5810]
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short 000000000000A4E6
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,2310FC00030
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
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
; Total bytes of code 282
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short 000000000000E44C
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short 000000000000E463
       jmp       short 000000000000E44F
       xor       r9d,r9d
       test      r8,r8
       je        short 000000000000E463
       cmp       dword ptr [r8+8],0
       je        short 000000000000E463
       mov       rcx,r8
       jmp       near ptr 000000000000E509
       test      r9d,r9d
       jne       near ptr 000000000000E509
       call      qword ptr [0BC48]
       mov       rdi,rax
       test      rsi,rsi
       je        short 000000000000E482
       cmp       dword ptr [rsi+8],0
       je        short 000000000000E482
       jmp       short 000000000000E485
       mov       rsi,rdi
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       test      dl,dl
       jne       short 000000000000E518
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [0D4E0]
; Total bytes of code 268
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr 000000000000B146
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 000000000000B1B1
       lea       rcx,[rdi+0C]
       mov       rdx,23111C005B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 000000000000B1D4
       lea       rcx,[rdi+12]
       mov       rdx,2310FC00098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000B067
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 000000000000B06C
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000B107
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       [rsp+28],rcx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.GetRuntimeType(!!0 ByRef)
       call      qword ptr [0BEB8]
       mov       rsi,rax
       mov       rcx,2310FC06048
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+85],0
       je        short 000000000000B1A6
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0D840]
       mov       r8,rax
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteStringUsingSerializer(!!0 ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      qword ptr [1F78]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       call      qword ptr [0DE58]
       jmp       short 000000000000B179
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
; Total bytes of code 568
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,r9
       mov       rdi,[rsp+80]
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       jne       near ptr 00000000000059DC
       test      r8,r8
       je        short 0000000000005954
       mov       rdx,r8
       jmp       near ptr 00000000000059DC
       call      qword ptr [0BB28]
       mov       rbx,rax
       test      rdi,rdi
       je        short 00000000000059CD
       mov       ebp,[rdi+8]
       test      ebp,ebp
       je        short 00000000000059CD
       mov       r14d,ebp
       lea       ecx,[r14+2]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebp
       jl        short 00000000000059EC
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       ecx,[r15+8]
       sub       ecx,r14d
       cmp       ecx,2
       jl        short 0000000000005A0F
       movsxd    rcx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       rdx,2310FC00098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,r15
       test      rsi,rsi
       jne       short 0000000000005A32
       jmp       short 0000000000005A46
       mov       rcx,2310FC00098
       mov       rcx,[rcx]
       jmp       short 00000000000059C6
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [5F48]
       mov       rcx,rsi
       call      0000000000006AD0
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [5F48]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       dword ptr [rsi+8],0
       je        short 0000000000005A46
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       jmp       short 0000000000005A52
       mov       rdx,rbx
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 0000000000005A62
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 0000000000005A67
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 0000000000005B02
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       int       3
; Total bytes of code 546
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        short 000000000000691C
       mov       eax,[rdx+8]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      eax,eax
       jne       short 000000000000691E
       jmp       short 000000000000691E
       xor       ecx,ecx
       test      ecx,ecx
       jne       near ptr 00000000000069C8
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,5E7
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short 00000000000069F0
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short 0000000000006A05
       mov       rcx,rsi
       mov       rdx,7FF82F0AB0F0
       call      0000000000000CA0
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [5888]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 298
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 0000000000008CDC
       jmp       short 0000000000008CF1
       mov       rcx,rdi
       mov       rdx,7FF82F183AF0
       call      00000000000087F0
       mov       rcx,rax
       mov       r8,2310FC00030
       mov       r8,[r8]
       mov       r9,2310FC06A00
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7300]
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000003330
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr 0000000000008F63
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [8A70]
       test      eax,eax
       je        near ptr 0000000000008F81
       mov       rcx,rdi
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [3900]
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 0000000000008D78
       jmp       short 0000000000008D8D
       mov       rcx,rdi
       mov       rdx,7FF82F183D48
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 0000000000008E46
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 0000000000008DAA
       jmp       short 0000000000008DBF
       mov       rcx,rdi
       mov       rdx,7FF82F183D48
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 0000000000008DD2
       jmp       short 0000000000008DE7
       mov       rcx,rdi
       mov       rdx,7FF82F183FD8
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EFB0
       mov       r13,rax
       test      r12,r12
       je        near ptr 0000000000009084
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      0000000000000010
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 0000000000008E1D
       jmp       short 0000000000008E32
       mov       rcx,rdi
       mov       rdx,7FF82F183D48
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      0000000000000010
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 0000000000008E51
       jmp       short 0000000000008E66
       mov       rcx,rdi
       mov       rdx,7FF82F183D88
       call      00000000000087F0
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [5BA0]
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 0000000000008E80
       jmp       short 0000000000008E95
       mov       rcx,rdi
       mov       rdx,7FF82F183DA8
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82E980838
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr 0000000000008F3F
       mov       r11,[r14+30]
       test      r11,r11
       je        short 0000000000008EC5
       jmp       short 0000000000008EDA
       mov       rcx,rdi
       mov       rdx,7FF82F183DD8
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 0000000000008EEA
       cmp       esi,0FFFFFFFE
       jne       short 0000000000008EF8
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7810]
       jmp       short 0000000000008F27
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 0000000000008F1B
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000000020
       jmp       short 0000000000008F27
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [3A98]
       mov       rcx,rbx
       mov       r11,7FF82E980838
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr 0000000000008EBA
       mov       rcx,rbx
       mov       r11,7FF82E980840
       call      qword ptr [r11]
       mov       rax,r15
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
       mov       ecx,2E7
       mov       rdx,7FF82E974000
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       call      qword ptr [0B990]
       mov       rbx,rax
       mov       rax,2310FC06FB0
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000903B
       call      qword ptr [0BC48]
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rsi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B888]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [3030]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [5630]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 00000000000090C3
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82E980840
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1077
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      000000000000F778
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      00000000000068E0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short 0000000000005C78
       mov       rcx,rdx
       call      000000000000FAB8
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short 0000000000005C55
       jmp       short 0000000000005C6A
       mov       rcx,rsi
       mov       rdx,7FF82F2E1EC8
       call      0000000000004920
       mov       rcx,rax
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr 0000000000000378
       mov       ecx,4D
       mov       rdx,7FF82F27ED50
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,7C7
       mov       rdx,7FF82F27ED50
       call      0000000000000390
       mov       rdi,rax
       call      0000000000002E70
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      0000000000001F28
       mov       rcx,rax
       call      0000000000002F48
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 000000000000ACDC
       jmp       short 000000000000ACF1
       mov       rcx,rdi
       mov       rdx,7FF82F4B1718
       call      0000000000002740
       mov       rcx,rax
       mov       r8,25792A43020
       mov       r8,[r8]
       mov       r9,257B2A42678
       mov       r9,[r9]
       mov       rdx,rbx
       call      000000000000DD00
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000004F40
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      0000000000000948
       test      eax,eax
       je        near ptr 000000000000AF5D
       mov       rcx,rdi
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,r15
       call      00000000000013D0
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AD6C
       jmp       short 000000000000AD81
       mov       rcx,rdi
       mov       rdx,7FF82F4B1970
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 000000000000AE3A
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AD9E
       jmp       short 000000000000ADB3
       mov       rcx,rdi
       mov       rdx,7FF82F4B1970
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 000000000000ADC6
       jmp       short 000000000000ADDB
       mov       rcx,rdi
       mov       rdx,7FF82F4B1C10
       call      0000000000002740
       mov       rcx,rax
       call      000000000000B2D0
       mov       r13,rax
       test      r12,r12
       je        near ptr 000000000000B073
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      000000000000AEB0
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AE11
       jmp       short 000000000000AE26
       mov       rcx,rdi
       mov       rdx,7FF82F4B1970
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      000000000000AEB0
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 000000000000AE45
       jmp       short 000000000000AE5A
       mov       rcx,rdi
       mov       rdx,7FF82F4B19B0
       call      0000000000002740
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      00000000000065E0
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000AE73
       jmp       short 000000000000AE88
       mov       rcx,rdi
       mov       rdx,7FF82F4B19D0
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82EE806C8
       call      qword ptr [6C8]
       test      eax,eax
       je        near ptr 000000000000AF36
       mov       r11,[r14+30]
       test      r11,r11
       je        short 000000000000AEBB
       jmp       short 000000000000AED0
       mov       rcx,rdi
       mov       rdx,7FF82F4B1A00
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 000000000000AEE0
       cmp       esi,0FFFFFFFE
       jne       short 000000000000AEED
       mov       rcx,r15
       mov       rdx,rax
       call      00000000000068B8
       jmp       short 000000000000AF1B
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 000000000000AF10
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000008190
       jmp       short 000000000000AF1B
       mov       rcx,r15
       mov       rdx,rax
       call      0000000000001458
       mov       rcx,rbx
       mov       r11,7FF82EE806C8
       call      qword ptr [6C8]
       test      eax,eax
       jne       near ptr 000000000000AEB0
       mov       rcx,rbx
       mov       r11,7FF82EE806D0
       call      qword ptr [6D0]
       mov       rax,r15
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
       call      0000000000002DE8
       mov       rbx,rax
       mov       rax,257B2A42C18
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short 000000000000AF7C
       xor       eax,eax
       jmp       short 000000000000AF81
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000B02E
       call      0000000000002ED0
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82F27A3D0
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82F27A3D0
       call      0000000000000390
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82F27A3D0
       call      0000000000000390
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      0000000000001FF8
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D88
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      00000000000001E8
       mov       rcx,rdi
       call      00000000000055B0
       mov       edx,3
       call      0000000000008468
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D90
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      0000000000005760
       mov       rcx,rdi
       call      00000000000055B0
       call      0000000000007270
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 000000000000B0B4
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82EE806D0
       call      qword ptr [6D0]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1062
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+110]
       test      rcx,rcx
       jne       near ptr 000000000000A8DF
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 000000000000A95E
       lea       rcx,[rdi+0C]
       mov       rdx,21441C06588
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 000000000000A981
       lea       rcx,[rdi+12]
       mov       rdx,21445C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,rsi
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [9708]
       mov       rdx,rax
       mov       r9,21441C080F8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,21445C02028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull(!!0, !!0, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [3CF0]
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize(System.String)
       call      qword ptr [5828]
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7B88]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
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
; Total bytes of code 469
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr 0000000000004230
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr 0000000000004230
       lea       rsi,[rdx+r8]
       lea       rdi,[rcx+r8]
       cmp       r8,10
       jbe       short 0000000000004186
       cmp       r8,40
       ja        short 00000000000041AE
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short 0000000000004179
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       ja        near ptr 0000000000004212
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       pop       rsi
       pop       rdi
       ret
       test      r8b,18
       jne       short 00000000000041FF
       test      r8b,4
       jne       short 00000000000041F1
       test      r8,r8
       je        short 0000000000004183
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short 0000000000004183
       movsx     r8,word ptr [rsi+0FFFE]
       mov       [rdi+0FFFE],r8w
       jmp       short 0000000000004183
       cmp       r8,800
       ja        near ptr 0000000000004239
       mov       rax,r8
       shr       rax,6
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short 00000000000041C2
       and       r8,3F
       cmp       r8,10
       ja        near ptr 0000000000004157
       jmp       short 0000000000004221
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rsi+0FFFC]
       mov       [rdi+0FFFC],edx
       jmp       short 0000000000004183
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rsi+0FFF8]
       mov       [rdi+0FFF8],rdx
       jmp       near ptr 0000000000004183
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
       jmp       near ptr 0000000000004179
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       jmp       near ptr 0000000000004183
       cmp       rcx,rdx
       je        near ptr 0000000000004183
       pop       rsi
       pop       rdi
       jmp       qword ptr [5828]
; Total bytes of code 289
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short 000000000000A3D9
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short 000000000000A3D9
       test      rsi,rsi
       je        near ptr 000000000000A473
       jmp       short 000000000000A3F5
       test      rsi,rsi
       je        short 000000000000A459
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000A459
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000A473
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        short 000000000000A483
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [5810]
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short 000000000000A4A6
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,21445C02028
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
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
; Total bytes of code 282
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short 000000000000E42C
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short 000000000000E443
       jmp       short 000000000000E42F
       xor       r9d,r9d
       test      r8,r8
       je        short 000000000000E443
       cmp       dword ptr [r8+8],0
       je        short 000000000000E443
       mov       rcx,r8
       jmp       near ptr 000000000000E4E9
       test      r9d,r9d
       jne       near ptr 000000000000E4E9
       call      qword ptr [0BC48]
       mov       rdi,rax
       test      rsi,rsi
       je        short 000000000000E462
       cmp       dword ptr [rsi+8],0
       je        short 000000000000E462
       jmp       short 000000000000E465
       mov       rsi,rdi
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       test      dl,dl
       jne       short 000000000000E4F8
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [0D4E0]
; Total bytes of code 268
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr 000000000000B126
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 000000000000B191
       lea       rcx,[rdi+0C]
       mov       rdx,21441C06588
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 000000000000B1B4
       lea       rcx,[rdi+12]
       mov       rdx,21445C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000B047
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 000000000000B04C
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000B0E7
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       [rsp+28],rcx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.GetRuntimeType(!!0 ByRef)
       call      qword ptr [0BEB8]
       mov       rsi,rax
       mov       rcx,21441C05C30
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+85],0
       je        short 000000000000B186
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0D840]
       mov       r8,rax
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteStringUsingSerializer(!!0 ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      qword ptr [1F78]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       call      qword ptr [0DE58]
       jmp       short 000000000000B159
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
; Total bytes of code 568
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,r9
       mov       rdi,[rsp+80]
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       jne       near ptr 0000000000005D6C
       test      r8,r8
       je        short 0000000000005CE4
       mov       rdx,r8
       jmp       near ptr 0000000000005D6C
       call      qword ptr [0BB28]
       mov       rbx,rax
       test      rdi,rdi
       je        short 0000000000005D5D
       mov       ebp,[rdi+8]
       test      ebp,ebp
       je        short 0000000000005D5D
       mov       r14d,ebp
       lea       ecx,[r14+2]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebp
       jl        short 0000000000005D7C
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       ecx,[r15+8]
       sub       ecx,r14d
       cmp       ecx,2
       jl        short 0000000000005D9F
       movsxd    rcx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       rdx,21445C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,r15
       test      rsi,rsi
       jne       short 0000000000005DC2
       jmp       short 0000000000005DD6
       mov       rcx,21445C02090
       mov       rcx,[rcx]
       jmp       short 0000000000005D56
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [5F48]
       mov       rcx,rsi
       call      0000000000006AD0
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [5F48]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       dword ptr [rsi+8],0
       je        short 0000000000005DD6
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       jmp       short 0000000000005DE2
       mov       rdx,rbx
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 0000000000005DF2
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 0000000000005DF7
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 0000000000005E92
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       int       3
; Total bytes of code 546
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        short 0000000000006B3C
       mov       eax,[rdx+8]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      eax,eax
       jne       short 0000000000006B3E
       jmp       short 0000000000006B3E
       xor       ecx,ecx
       test      ecx,ecx
       jne       near ptr 0000000000006BE8
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,5E7
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short 0000000000006C10
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short 0000000000006C25
       mov       rcx,rsi
       mov       rdx,7FF82F0AB0F0
       call      0000000000000CA0
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [5888]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 298
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 0000000000008F3C
       jmp       short 0000000000008F51
       mov       rcx,rdi
       mov       rdx,7FF82F183B00
       call      00000000000087F0
       mov       rcx,rax
       mov       r8,21445C02028
       mov       r8,[r8]
       mov       r9,21441C07E18
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7300]
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000003330
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr 00000000000091C3
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [8A70]
       test      eax,eax
       je        near ptr 00000000000091E1
       mov       rcx,rdi
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [3900]
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 0000000000008FD8
       jmp       short 0000000000008FED
       mov       rcx,rdi
       mov       rdx,7FF82F183D58
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 00000000000090A6
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000900A
       jmp       short 000000000000901F
       mov       rcx,rdi
       mov       rdx,7FF82F183D58
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 0000000000009032
       jmp       short 0000000000009047
       mov       rcx,rdi
       mov       rdx,7FF82F183FE8
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EFB0
       mov       r13,rax
       test      r12,r12
       je        near ptr 00000000000092E4
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      0000000000000010
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000907D
       jmp       short 0000000000009092
       mov       rcx,rdi
       mov       rdx,7FF82F183D58
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      0000000000000010
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 00000000000090B1
       jmp       short 00000000000090C6
       mov       rcx,rdi
       mov       rdx,7FF82F183D98
       call      00000000000087F0
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [5BA0]
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 00000000000090E0
       jmp       short 00000000000090F5
       mov       rcx,rdi
       mov       rdx,7FF82F183DB8
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82E980838
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr 000000000000919F
       mov       r11,[r14+30]
       test      r11,r11
       je        short 0000000000009125
       jmp       short 000000000000913A
       mov       rcx,rdi
       mov       rdx,7FF82F183DE8
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 000000000000914A
       cmp       esi,0FFFFFFFE
       jne       short 0000000000009158
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7B10]
       jmp       short 0000000000009187
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 000000000000917B
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000000020
       jmp       short 0000000000009187
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [3A98]
       mov       rcx,rbx
       mov       r11,7FF82E980838
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr 000000000000911A
       mov       rcx,rbx
       mov       r11,7FF82E980840
       call      qword ptr [r11]
       mov       rax,r15
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
       mov       ecx,2E7
       mov       rdx,7FF82E974000
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       call      qword ptr [0B990]
       mov       rbx,rax
       mov       rax,21441C083C8
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000929B
       call      qword ptr [0BC48]
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rsi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B888]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [3030]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [5630]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 0000000000009323
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82E980840
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1077
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      000000000000F778
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      00000000000068B0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short 0000000000005868
       mov       rcx,rdx
       call      000000000000FAB8
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short 0000000000005845
       jmp       short 000000000000585A
       mov       rcx,rsi
       mov       rdx,7FF82F2F1EC8
       call      0000000000004920
       mov       rcx,rax
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr 0000000000000378
       mov       ecx,4D
       mov       rdx,7FF82F28ED50
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,7C7
       mov       rdx,7FF82F28ED50
       call      0000000000000390
       mov       rdi,rax
       call      0000000000002E70
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      0000000000001F28
       mov       rcx,rax
       call      0000000000002F48
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 000000000000AC3C
       jmp       short 000000000000AC51
       mov       rcx,rdi
       mov       rdx,7FF82F4C1718
       call      0000000000002740
       mov       rcx,rax
       mov       r8,1F8BD8C3020
       mov       r8,[r8]
       mov       r9,1F8BD8CB270
       mov       r9,[r9]
       mov       rdx,rbx
       call      000000000000DD10
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000004F40
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      0000000000000948
       test      eax,eax
       je        near ptr 000000000000AEBD
       mov       rcx,rdi
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,r15
       call      00000000000013D0
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000ACCC
       jmp       short 000000000000ACE1
       mov       rcx,rdi
       mov       rdx,7FF82F4C1970
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 000000000000AD9A
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000ACFE
       jmp       short 000000000000AD13
       mov       rcx,rdi
       mov       rdx,7FF82F4C1970
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 000000000000AD26
       jmp       short 000000000000AD3B
       mov       rcx,rdi
       mov       rdx,7FF82F4C1C10
       call      0000000000002740
       mov       rcx,rax
       call      000000000000B2D0
       mov       r13,rax
       test      r12,r12
       je        near ptr 000000000000AFD3
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      000000000000AEB0
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AD71
       jmp       short 000000000000AD86
       mov       rcx,rdi
       mov       rdx,7FF82F4C1970
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      000000000000AEB0
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 000000000000ADA5
       jmp       short 000000000000ADBA
       mov       rcx,rdi
       mov       rdx,7FF82F4C19B0
       call      0000000000002740
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      00000000000065E0
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000ADD3
       jmp       short 000000000000ADE8
       mov       rcx,rdi
       mov       rdx,7FF82F4C19D0
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82EE906C8
       call      qword ptr [6C8]
       test      eax,eax
       je        near ptr 000000000000AE96
       mov       r11,[r14+30]
       test      r11,r11
       je        short 000000000000AE1B
       jmp       short 000000000000AE30
       mov       rcx,rdi
       mov       rdx,7FF82F4C1A00
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 000000000000AE40
       cmp       esi,0FFFFFFFE
       jne       short 000000000000AE4D
       mov       rcx,r15
       mov       rdx,rax
       call      0000000000006888
       jmp       short 000000000000AE7B
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 000000000000AE70
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000008190
       jmp       short 000000000000AE7B
       mov       rcx,r15
       mov       rdx,rax
       call      0000000000001458
       mov       rcx,rbx
       mov       r11,7FF82EE906C8
       call      qword ptr [6C8]
       test      eax,eax
       jne       near ptr 000000000000AE10
       mov       rcx,rbx
       mov       r11,7FF82EE906D0
       call      qword ptr [6D0]
       mov       rax,r15
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
       call      0000000000002DE8
       mov       rbx,rax
       mov       rax,1F8BD8CB810
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short 000000000000AEDC
       xor       eax,eax
       jmp       short 000000000000AEE1
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000AF8E
       call      0000000000002ED0
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82F28A3D0
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82F28A3D0
       call      0000000000000390
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82F28A3D0
       call      0000000000000390
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      0000000000001FF8
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D88
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      00000000000001E8
       mov       rcx,rdi
       call      00000000000055B0
       mov       edx,3
       call      0000000000008468
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D90
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      0000000000005760
       mov       rcx,rdi
       call      00000000000055B0
       call      0000000000007270
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 000000000000B014
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82EE906D0
       call      qword ptr [6D0]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1062
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+110]
       test      rcx,rcx
       jne       near ptr 0000000000008ADF
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 0000000000008B5E
       lea       rcx,[rdi+0C]
       mov       rdx,2562F4005B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 0000000000008B81
       lea       rcx,[rdi+12]
       mov       rdx,25633400098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,rsi
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [9708]
       mov       rdx,rax
       mov       r9,25633403D20
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,25633400030
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull(!!0, !!0, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [3CF0]
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize(System.String)
       call      qword ptr [5828]
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7B88]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
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
; Total bytes of code 469
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr 0000000000005750
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr 0000000000005750
       lea       rsi,[rdx+r8]
       lea       rdi,[rcx+r8]
       cmp       r8,10
       jbe       short 00000000000056A6
       cmp       r8,40
       ja        short 00000000000056CE
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short 0000000000005699
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       ja        near ptr 0000000000005732
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       pop       rsi
       pop       rdi
       ret
       test      r8b,18
       jne       short 000000000000571F
       test      r8b,4
       jne       short 0000000000005711
       test      r8,r8
       je        short 00000000000056A3
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short 00000000000056A3
       movsx     r8,word ptr [rsi+0FFFE]
       mov       [rdi+0FFFE],r8w
       jmp       short 00000000000056A3
       cmp       r8,800
       ja        near ptr 0000000000005759
       mov       rax,r8
       shr       rax,6
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short 00000000000056E2
       and       r8,3F
       cmp       r8,10
       ja        near ptr 0000000000005677
       jmp       short 0000000000005741
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rsi+0FFFC]
       mov       [rdi+0FFFC],edx
       jmp       short 00000000000056A3
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rsi+0FFF8]
       mov       [rdi+0FFF8],rdx
       jmp       near ptr 00000000000056A3
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
       jmp       near ptr 0000000000005699
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       jmp       near ptr 00000000000056A3
       cmp       rcx,rdx
       je        near ptr 00000000000056A3
       pop       rsi
       pop       rdi
       jmp       qword ptr [5828]
; Total bytes of code 289
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short 000000000000ACC9
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short 000000000000ACC9
       test      rsi,rsi
       je        near ptr 000000000000AD63
       jmp       short 000000000000ACE5
       test      rsi,rsi
       je        short 000000000000AD49
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000AD49
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000AD63
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        short 000000000000AD73
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [5810]
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short 000000000000AD96
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,25633400030
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
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
; Total bytes of code 282
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short 000000000000875C
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short 0000000000008773
       jmp       short 000000000000875F
       xor       r9d,r9d
       test      r8,r8
       je        short 0000000000008773
       cmp       dword ptr [r8+8],0
       je        short 0000000000008773
       mov       rcx,r8
       jmp       near ptr 0000000000008819
       test      r9d,r9d
       jne       near ptr 0000000000008819
       call      qword ptr [0BC48]
       mov       rdi,rax
       test      rsi,rsi
       je        short 0000000000008792
       cmp       dword ptr [rsi+8],0
       je        short 0000000000008792
       jmp       short 0000000000008795
       mov       rsi,rdi
       mov       ecx,9
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       test      dl,dl
       jne       short 0000000000008828
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [0D4E0]
; Total bytes of code 268
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr 0000000000009326
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 0000000000009391
       lea       rcx,[rdi+0C]
       mov       rdx,2562F4005B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 00000000000093B4
       lea       rcx,[rdi+12]
       mov       rdx,25633400098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 0000000000009247
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 000000000000924C
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 00000000000092E7
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       [rsp+28],rcx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.GetRuntimeType(!!0 ByRef)
       call      qword ptr [0BEB8]
       mov       rsi,rax
       mov       rcx,25631403C38
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+85],0
       je        short 0000000000009386
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0D840]
       mov       r8,rax
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteStringUsingSerializer(!!0 ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      qword ptr [1F78]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       call      qword ptr [0DE58]
       jmp       short 0000000000009359
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
; Total bytes of code 568
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,r9
       mov       rdi,[rsp+80]
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       jne       near ptr 000000000000671C
       test      r8,r8
       je        short 0000000000006694
       mov       rdx,r8
       jmp       near ptr 000000000000671C
       call      qword ptr [0BB28]
       mov       rbx,rax
       test      rdi,rdi
       je        short 000000000000670D
       mov       ebp,[rdi+8]
       test      ebp,ebp
       je        short 000000000000670D
       mov       r14d,ebp
       lea       ecx,[r14+2]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebp
       jl        short 000000000000672C
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       ecx,[r15+8]
       sub       ecx,r14d
       cmp       ecx,2
       jl        short 000000000000674F
       movsxd    rcx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       rdx,25633400098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,r15
       test      rsi,rsi
       jne       short 0000000000006772
       jmp       short 0000000000006786
       mov       rcx,25633400098
       mov       rcx,[rcx]
       jmp       short 0000000000006706
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [5F48]
       mov       rcx,rsi
       call      0000000000006AD0
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [5F48]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       dword ptr [rsi+8],0
       je        short 0000000000006786
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       jmp       short 0000000000006792
       mov       rdx,rbx
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 00000000000067A2
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 00000000000067A7
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 0000000000006842
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       int       3
; Total bytes of code 546
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        short 000000000000A83C
       mov       eax,[rdx+8]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      eax,eax
       jne       short 000000000000A83E
       jmp       short 000000000000A83E
       xor       ecx,ecx
       test      ecx,ecx
       jne       near ptr 000000000000A8E8
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,5E7
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short 000000000000A910
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short 000000000000A925
       mov       rcx,rsi
       mov       rdx,7FF82F0DB0F0
       call      0000000000000CA0
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [5888]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 298
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 000000000000713C
       jmp       short 0000000000007151
       mov       rcx,rdi
       mov       rdx,7FF82F1B3CF0
       call      00000000000087F0
       mov       rcx,rax
       mov       r8,25633400030
       mov       r8,[r8]
       mov       r9,25633403A40
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7300]
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000003330
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr 00000000000073C3
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [8A70]
       test      eax,eax
       je        near ptr 00000000000073E1
       mov       rcx,rdi
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [3900]
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 00000000000071D8
       jmp       short 00000000000071ED
       mov       rcx,rdi
       mov       rdx,7FF82F1B3F48
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 00000000000072A6
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000720A
       jmp       short 000000000000721F
       mov       rcx,rdi
       mov       rdx,7FF82F1B3F48
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 0000000000007232
       jmp       short 0000000000007247
       mov       rcx,rdi
       mov       rdx,7FF82F1B41D8
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EFB0
       mov       r13,rax
       test      r12,r12
       je        near ptr 00000000000074E4
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      0000000000000010
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000727D
       jmp       short 0000000000007292
       mov       rcx,rdi
       mov       rdx,7FF82F1B3F48
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      0000000000000010
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 00000000000072B1
       jmp       short 00000000000072C6
       mov       rcx,rdi
       mov       rdx,7FF82F1B3F88
       call      00000000000087F0
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [5BA0]
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 00000000000072E0
       jmp       short 00000000000072F5
       mov       rcx,rdi
       mov       rdx,7FF82F1B3FA8
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82E9B0850
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr 000000000000739F
       mov       r11,[r14+30]
       test      r11,r11
       je        short 0000000000007325
       jmp       short 000000000000733A
       mov       rcx,rdi
       mov       rdx,7FF82F1B3FD8
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 000000000000734A
       cmp       esi,0FFFFFFFE
       jne       short 0000000000007358
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7B10]
       jmp       short 0000000000007387
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 000000000000737B
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000000020
       jmp       short 0000000000007387
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [3A98]
       mov       rcx,rbx
       mov       r11,7FF82E9B0850
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr 000000000000731A
       mov       rcx,rbx
       mov       r11,7FF82E9B0858
       call      qword ptr [r11]
       mov       rax,r15
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
       mov       ecx,2E7
       mov       rdx,7FF82E9A4000
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       call      qword ptr [0B990]
       mov       rbx,rax
       mov       rax,25633403FF0
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000749B
       call      qword ptr [0BC48]
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rsi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B888]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [3030]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [5630]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 0000000000007523
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82E9B0858
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1077
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      000000000000F778
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      00000000000068B0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short 00000000000089B8
       mov       rcx,rdx
       call      000000000000FAB8
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short 0000000000008995
       jmp       short 00000000000089AA
       mov       rcx,rsi
       mov       rdx,7FF82F2E1EC8
       call      0000000000004920
       mov       rcx,rax
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr 0000000000000378
       mov       ecx,4D
       mov       rdx,7FF82F27ED50
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,7C7
       mov       rdx,7FF82F27ED50
       call      0000000000000390
       mov       rdi,rax
       call      0000000000002E70
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      0000000000001F28
       mov       rcx,rax
       call      0000000000002F48
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 000000000000AC3C
       jmp       short 000000000000AC51
       mov       rcx,rdi
       mov       rdx,7FF82F4B1798
       call      0000000000002740
       mov       rcx,rax
       mov       r8,243529D3020
       mov       r8,[r8]
       mov       r9,243529D6280
       mov       r9,[r9]
       mov       rdx,rbx
       call      000000000000DD10
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000004F40
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      0000000000000948
       test      eax,eax
       je        near ptr 000000000000AEBD
       mov       rcx,rdi
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,r15
       call      00000000000013D0
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000ACCC
       jmp       short 000000000000ACE1
       mov       rcx,rdi
       mov       rdx,7FF82F4B19F0
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 000000000000AD9A
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000ACFE
       jmp       short 000000000000AD13
       mov       rcx,rdi
       mov       rdx,7FF82F4B19F0
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 000000000000AD26
       jmp       short 000000000000AD3B
       mov       rcx,rdi
       mov       rdx,7FF82F4B1C90
       call      0000000000002740
       mov       rcx,rax
       call      000000000000B2D0
       mov       r13,rax
       test      r12,r12
       je        near ptr 000000000000AFD3
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      000000000000AEB0
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AD71
       jmp       short 000000000000AD86
       mov       rcx,rdi
       mov       rdx,7FF82F4B19F0
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      000000000000AEB0
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 000000000000ADA5
       jmp       short 000000000000ADBA
       mov       rcx,rdi
       mov       rdx,7FF82F4B1A30
       call      0000000000002740
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      00000000000065E0
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000ADD3
       jmp       short 000000000000ADE8
       mov       rcx,rdi
       mov       rdx,7FF82F4B1A50
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82EE806C8
       call      qword ptr [6C8]
       test      eax,eax
       je        near ptr 000000000000AE96
       mov       r11,[r14+30]
       test      r11,r11
       je        short 000000000000AE1B
       jmp       short 000000000000AE30
       mov       rcx,rdi
       mov       rdx,7FF82F4B1A80
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 000000000000AE40
       cmp       esi,0FFFFFFFE
       jne       short 000000000000AE4D
       mov       rcx,r15
       mov       rdx,rax
       call      0000000000006888
       jmp       short 000000000000AE7B
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 000000000000AE70
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000008190
       jmp       short 000000000000AE7B
       mov       rcx,r15
       mov       rdx,rax
       call      0000000000001458
       mov       rcx,rbx
       mov       r11,7FF82EE806C8
       call      qword ptr [6C8]
       test      eax,eax
       jne       near ptr 000000000000AE10
       mov       rcx,rbx
       mov       r11,7FF82EE806D0
       call      qword ptr [6D0]
       mov       rax,r15
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
       call      0000000000002DE8
       mov       rbx,rax
       mov       rax,243529D6820
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short 000000000000AEDC
       xor       eax,eax
       jmp       short 000000000000AEE1
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000AF8E
       call      0000000000002ED0
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82F27A3D0
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82F27A3D0
       call      0000000000000390
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82F27A3D0
       call      0000000000000390
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      0000000000001FF8
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D88
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      00000000000001E8
       mov       rcx,rdi
       call      00000000000055B0
       mov       edx,3
       call      0000000000008468
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D90
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      0000000000005760
       mov       rcx,rdi
       call      00000000000055B0
       call      0000000000007270
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 000000000000B014
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82EE806D0
       call      qword ptr [6D0]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1062
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+110]
       test      rcx,rcx
       jne       near ptr 000000000000C21F
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 000000000000C29E
       lea       rcx,[rdi+0C]
       mov       rdx,1A9F84005B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 000000000000C2C1
       lea       rcx,[rdi+12]
       mov       rdx,1A9F2402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,rsi
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [9708]
       mov       rdx,rax
       mov       r9,1A9F44008F8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1A9F2402028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull(!!0, !!0, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [3CF0]
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize(System.String)
       call      qword ptr [5828]
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7B88]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
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
; Total bytes of code 469
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr 0000000000004B90
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr 0000000000004B90
       lea       rsi,[rdx+r8]
       lea       rdi,[rcx+r8]
       cmp       r8,10
       jbe       short 0000000000004AE6
       cmp       r8,40
       ja        short 0000000000004B0E
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short 0000000000004AD9
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       ja        near ptr 0000000000004B72
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       pop       rsi
       pop       rdi
       ret
       test      r8b,18
       jne       short 0000000000004B5F
       test      r8b,4
       jne       short 0000000000004B51
       test      r8,r8
       je        short 0000000000004AE3
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short 0000000000004AE3
       movsx     r8,word ptr [rsi+0FFFE]
       mov       [rdi+0FFFE],r8w
       jmp       short 0000000000004AE3
       cmp       r8,800
       ja        near ptr 0000000000004B99
       mov       rax,r8
       shr       rax,6
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short 0000000000004B22
       and       r8,3F
       cmp       r8,10
       ja        near ptr 0000000000004AB7
       jmp       short 0000000000004B81
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rsi+0FFFC]
       mov       [rdi+0FFFC],edx
       jmp       short 0000000000004AE3
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rsi+0FFF8]
       mov       [rdi+0FFF8],rdx
       jmp       near ptr 0000000000004AE3
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
       jmp       near ptr 0000000000004AD9
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       jmp       near ptr 0000000000004AE3
       cmp       rcx,rdx
       je        near ptr 0000000000004AE3
       pop       rsi
       pop       rdi
       jmp       qword ptr [5828]
; Total bytes of code 289
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short 000000000000BB19
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short 000000000000BB19
       test      rsi,rsi
       je        near ptr 000000000000BBB3
       jmp       short 000000000000BB35
       test      rsi,rsi
       je        short 000000000000BB99
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000BB99
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000BBB3
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        short 000000000000BBC3
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [5810]
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short 000000000000BBE6
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,1A9F2402028
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
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
; Total bytes of code 282
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short 000000000000ED6C
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short 000000000000ED83
       jmp       short 000000000000ED6F
       xor       r9d,r9d
       test      r8,r8
       je        short 000000000000ED83
       cmp       dword ptr [r8+8],0
       je        short 000000000000ED83
       mov       rcx,r8
       jmp       near ptr 000000000000EE29
       test      r9d,r9d
       jne       near ptr 000000000000EE29
       call      qword ptr [0BC48]
       mov       rdi,rax
       test      rsi,rsi
       je        short 000000000000EDA2
       cmp       dword ptr [rsi+8],0
       je        short 000000000000EDA2
       jmp       short 000000000000EDA5
       mov       rsi,rdi
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       test      dl,dl
       jne       short 000000000000EE38
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [0D4E0]
; Total bytes of code 268
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr 000000000000CA66
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 000000000000CAD1
       lea       rcx,[rdi+0C]
       mov       rdx,1A9F84005B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 000000000000CAF4
       lea       rcx,[rdi+12]
       mov       rdx,1A9F2402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000C987
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 000000000000C98C
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000CA27
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       [rsp+28],rcx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.GetRuntimeType(!!0 ByRef)
       call      qword ptr [0BEB8]
       mov       rsi,rax
       mov       rcx,1A9F2408040
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+85],0
       je        short 000000000000CAC6
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0D840]
       mov       r8,rax
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteStringUsingSerializer(!!0 ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      qword ptr [1F78]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       call      qword ptr [0DE58]
       jmp       short 000000000000CA99
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
; Total bytes of code 568
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,r9
       mov       rdi,[rsp+80]
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       jne       near ptr 00000000000067EC
       test      r8,r8
       je        short 0000000000006764
       mov       rdx,r8
       jmp       near ptr 00000000000067EC
       call      qword ptr [0BB28]
       mov       rbx,rax
       test      rdi,rdi
       je        short 00000000000067DD
       mov       ebp,[rdi+8]
       test      ebp,ebp
       je        short 00000000000067DD
       mov       r14d,ebp
       lea       ecx,[r14+2]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebp
       jl        short 00000000000067FC
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       ecx,[r15+8]
       sub       ecx,r14d
       cmp       ecx,2
       jl        short 000000000000681F
       movsxd    rcx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       rdx,1A9F2402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,r15
       test      rsi,rsi
       jne       short 0000000000006842
       jmp       short 0000000000006856
       mov       rcx,1A9F2402090
       mov       rcx,[rcx]
       jmp       short 00000000000067D6
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [5F48]
       mov       rcx,rsi
       call      0000000000006AD0
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [5F48]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       dword ptr [rsi+8],0
       je        short 0000000000006856
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       jmp       short 0000000000006862
       mov       rdx,rbx
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 0000000000006872
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 0000000000006877
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 0000000000006912
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       int       3
; Total bytes of code 546
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        short 0000000000007EEC
       mov       eax,[rdx+8]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      eax,eax
       jne       short 0000000000007EEE
       jmp       short 0000000000007EEE
       xor       ecx,ecx
       test      ecx,ecx
       jne       near ptr 0000000000007F98
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,5E7
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short 0000000000007FC0
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short 0000000000007FD5
       mov       rcx,rsi
       mov       rdx,7FF82F0AB110
       call      0000000000000CA0
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [5888]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 298
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 000000000000A87C
       jmp       short 000000000000A891
       mov       rcx,rdi
       mov       rdx,7FF82F183D68
       call      00000000000087F0
       mov       rcx,rax
       mov       r8,1A9F2402028
       mov       r8,[r8]
       mov       r9,1A9F4400618
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7300]
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000003330
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr 000000000000AB03
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [8A70]
       test      eax,eax
       je        near ptr 000000000000AB21
       mov       rcx,rdi
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [3900]
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000A918
       jmp       short 000000000000A92D
       mov       rcx,rdi
       mov       rdx,7FF82F183FC0
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 000000000000A9E6
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000A94A
       jmp       short 000000000000A95F
       mov       rcx,rdi
       mov       rdx,7FF82F183FC0
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 000000000000A972
       jmp       short 000000000000A987
       mov       rcx,rdi
       mov       rdx,7FF82F184250
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EFB0
       mov       r13,rax
       test      r12,r12
       je        near ptr 000000000000AC24
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      0000000000000010
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000A9BD
       jmp       short 000000000000A9D2
       mov       rcx,rdi
       mov       rdx,7FF82F183FC0
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      0000000000000010
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 000000000000A9F1
       jmp       short 000000000000AA06
       mov       rcx,rdi
       mov       rdx,7FF82F184000
       call      00000000000087F0
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [5BA0]
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000AA20
       jmp       short 000000000000AA35
       mov       rcx,rdi
       mov       rdx,7FF82F184020
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82E980860
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr 000000000000AADF
       mov       r11,[r14+30]
       test      r11,r11
       je        short 000000000000AA65
       jmp       short 000000000000AA7A
       mov       rcx,rdi
       mov       rdx,7FF82F184050
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 000000000000AA8A
       cmp       esi,0FFFFFFFE
       jne       short 000000000000AA98
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7B10]
       jmp       short 000000000000AAC7
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 000000000000AABB
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000000020
       jmp       short 000000000000AAC7
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [3A98]
       mov       rcx,rbx
       mov       r11,7FF82E980860
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr 000000000000AA5A
       mov       rcx,rbx
       mov       r11,7FF82E980868
       call      qword ptr [r11]
       mov       rax,r15
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
       mov       ecx,2E7
       mov       rdx,7FF82E974000
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       call      qword ptr [0B990]
       mov       rbx,rax
       mov       rax,1A9F4400BC8
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000ABDB
       call      qword ptr [0BC48]
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rsi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B888]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [3030]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [5630]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 000000000000AC63
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82E980868
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1077
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      000000000000F778
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      0000000000000CA0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short 0000000000008498
       mov       rcx,rdx
       call      000000000000FAB8
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short 0000000000008475
       jmp       short 000000000000848A
       mov       rcx,rsi
       mov       rdx,7FF82F2E1EC8
       call      0000000000004920
       mov       rcx,rax
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr 0000000000000378
       mov       ecx,4D
       mov       rdx,7FF82F27ED50
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,7C7
       mov       rdx,7FF82F27ED50
       call      0000000000000390
       mov       rdi,rax
       call      0000000000002E70
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      0000000000001F28
       mov       rcx,rax
       call      0000000000002F48
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 000000000000509C
       jmp       short 00000000000050B1
       mov       rcx,rdi
       mov       rdx,7FF82F4C1798
       call      0000000000002740
       mov       rcx,rax
       mov       r8,22E21DF1028
       mov       r8,[r8]
       mov       r9,22E11DF1E78
       mov       r9,[r9]
       mov       rdx,rbx
       call      0000000000002BC0
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000004F40
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      0000000000000948
       test      eax,eax
       je        near ptr 000000000000531D
       mov       rcx,rdi
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,r15
       call      00000000000013D0
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000512C
       jmp       short 0000000000005141
       mov       rcx,rdi
       mov       rdx,7FF82F4C19F0
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 00000000000051FA
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000515E
       jmp       short 0000000000005173
       mov       rcx,rdi
       mov       rdx,7FF82F4C19F0
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 0000000000005186
       jmp       short 000000000000519B
       mov       rcx,rdi
       mov       rdx,7FF82F4C1C90
       call      0000000000002740
       mov       rcx,rax
       call      000000000000B2D0
       mov       r13,rax
       test      r12,r12
       je        near ptr 0000000000005433
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      000000000000AEB0
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 00000000000051D1
       jmp       short 00000000000051E6
       mov       rcx,rdi
       mov       rdx,7FF82F4C19F0
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      000000000000AEB0
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 0000000000005205
       jmp       short 000000000000521A
       mov       rcx,rdi
       mov       rdx,7FF82F4C1A30
       call      0000000000002740
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      00000000000065E0
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 0000000000005233
       jmp       short 0000000000005248
       mov       rcx,rdi
       mov       rdx,7FF82F4C1A50
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82EE806C8
       call      qword ptr [6C8]
       test      eax,eax
       je        near ptr 00000000000052F6
       mov       r11,[r14+30]
       test      r11,r11
       je        short 000000000000527B
       jmp       short 0000000000005290
       mov       rcx,rdi
       mov       rdx,7FF82F4C1A80
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 00000000000052A0
       cmp       esi,0FFFFFFFE
       jne       short 00000000000052AD
       mov       rcx,r15
       mov       rdx,rax
       call      0000000000000C78
       jmp       short 00000000000052DB
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 00000000000052D0
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000008190
       jmp       short 00000000000052DB
       mov       rcx,r15
       mov       rdx,rax
       call      0000000000001458
       mov       rcx,rbx
       mov       r11,7FF82EE806C8
       call      qword ptr [6C8]
       test      eax,eax
       jne       near ptr 0000000000005270
       mov       rcx,rbx
       mov       r11,7FF82EE806D0
       call      qword ptr [6D0]
       mov       rax,r15
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
       call      0000000000002DE8
       mov       rbx,rax
       mov       rax,22E11DF2418
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short 000000000000533C
       xor       eax,eax
       jmp       short 0000000000005341
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 00000000000053EE
       call      0000000000002ED0
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82F27A3D0
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82F27A3D0
       call      0000000000000390
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82F27A3D0
       call      0000000000000390
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      0000000000001FF8
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D88
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      00000000000001E8
       mov       rcx,rdi
       call      00000000000055B0
       mov       edx,3
       call      0000000000008468
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D90
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      0000000000005760
       mov       rcx,rdi
       call      00000000000055B0
       call      0000000000007270
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 0000000000005474
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82EE806D0
       call      qword ptr [6D0]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1062
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate03()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), ensureUnique: Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+110]
       test      rcx,rcx
       jne       near ptr 000000000000DAFF
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 000000000000DB7E
       lea       rcx,[rdi+0C]
       mov       rdx,1F0AEC005B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 000000000000DBA1
       lea       rcx,[rdi+12]
       mov       rdx,1F0AAC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,rsi
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [9708]
       mov       rdx,rax
       mov       r9,1F0AEC02128
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1F0AAC02028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull(!!0, !!0, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [3CF0]
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize(System.String)
       call      qword ptr [57E0]
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [0F888]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
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
; Total bytes of code 469
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr 000000000000DC70
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr 000000000000DC70
       lea       rsi,[rdx+r8]
       lea       rdi,[rcx+r8]
       cmp       r8,10
       jbe       short 000000000000DBC6
       cmp       r8,40
       ja        short 000000000000DBEE
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short 000000000000DBB9
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       ja        near ptr 000000000000DC52
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       pop       rsi
       pop       rdi
       ret
       test      r8b,18
       jne       short 000000000000DC3F
       test      r8b,4
       jne       short 000000000000DC31
       test      r8,r8
       je        short 000000000000DBC3
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short 000000000000DBC3
       movsx     r8,word ptr [rsi+0FFFE]
       mov       [rdi+0FFFE],r8w
       jmp       short 000000000000DBC3
       cmp       r8,800
       ja        near ptr 000000000000DC79
       mov       rax,r8
       shr       rax,6
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short 000000000000DC02
       and       r8,3F
       cmp       r8,10
       ja        near ptr 000000000000DB97
       jmp       short 000000000000DC61
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rsi+0FFFC]
       mov       [rdi+0FFFC],edx
       jmp       short 000000000000DBC3
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rsi+0FFF8]
       mov       [rdi+0FFF8],rdx
       jmp       near ptr 000000000000DBC3
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
       jmp       near ptr 000000000000DBB9
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       jmp       near ptr 000000000000DBC3
       cmp       rcx,rdx
       je        near ptr 000000000000DBC3
       pop       rsi
       pop       rdi
       jmp       qword ptr [5828]
; Total bytes of code 289
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short 000000000000E4E9
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short 000000000000E4E9
       test      rsi,rsi
       je        near ptr 000000000000E583
       jmp       short 000000000000E505
       test      rsi,rsi
       je        short 000000000000E569
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000E569
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000E583
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        short 000000000000E593
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [5810]
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short 000000000000E5B6
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,1F0AAC02028
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
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
; Total bytes of code 282
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short 000000000000F1FC
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short 000000000000F213
       jmp       short 000000000000F1FF
       xor       r9d,r9d
       test      r8,r8
       je        short 000000000000F213
       cmp       dword ptr [r8+8],0
       je        short 000000000000F213
       mov       rcx,r8
       jmp       near ptr 000000000000F2B9
       test      r9d,r9d
       jne       near ptr 000000000000F2B9
       call      qword ptr [0BC48]
       mov       rdi,rax
       test      rsi,rsi
       je        short 000000000000F232
       cmp       dword ptr [rsi+8],0
       je        short 000000000000F232
       jmp       short 000000000000F235
       mov       rsi,rdi
       mov       ecx,9
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       test      dl,dl
       jne       short 000000000000F2C8
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [0D4E0]
; Total bytes of code 268
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr 000000000000B516
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 000000000000B581
       lea       rcx,[rdi+0C]
       mov       rdx,1F0AEC005B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 000000000000B5A4
       lea       rcx,[rdi+12]
       mov       rdx,1F0AAC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000B437
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 000000000000B43C
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000B4D7
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       [rsp+28],rcx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.GetRuntimeType(!!0 ByRef)
       call      qword ptr [0BEB8]
       mov       rsi,rax
       mov       rcx,1F0AAC08040
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+85],0
       je        short 000000000000B576
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0D840]
       mov       r8,rax
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteStringUsingSerializer(!!0 ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      qword ptr [1F78]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       call      qword ptr [0DE58]
       jmp       short 000000000000B549
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
; Total bytes of code 568
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,r9
       mov       rdi,[rsp+80]
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       jne       near ptr 00000000000055EC
       test      r8,r8
       je        short 0000000000005564
       mov       rdx,r8
       jmp       near ptr 00000000000055EC
       call      qword ptr [0BB28]
       mov       rbx,rax
       test      rdi,rdi
       je        short 00000000000055DD
       mov       ebp,[rdi+8]
       test      ebp,ebp
       je        short 00000000000055DD
       mov       r14d,ebp
       lea       ecx,[r14+2]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebp
       jl        short 00000000000055FC
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       ecx,[r15+8]
       sub       ecx,r14d
       cmp       ecx,2
       jl        short 000000000000561F
       movsxd    rcx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       rdx,1F0AAC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,r15
       test      rsi,rsi
       jne       short 0000000000005642
       jmp       short 0000000000005656
       mov       rcx,1F0AAC02090
       mov       rcx,[rcx]
       jmp       short 00000000000055D6
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [5F48]
       mov       rcx,rsi
       call      0000000000006AD0
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [5F48]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       dword ptr [rsi+8],0
       je        short 0000000000005656
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       jmp       short 0000000000005662
       mov       rdx,rbx
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 0000000000005672
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 0000000000005677
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 0000000000005712
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       int       3
; Total bytes of code 546
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        short 000000000000C4FC
       mov       eax,[rdx+8]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      eax,eax
       jne       short 000000000000C4FE
       jmp       short 000000000000C4FE
       xor       ecx,ecx
       test      ecx,ecx
       jne       near ptr 000000000000C5A8
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,5E7
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short 000000000000C5D0
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short 000000000000C5E5
       mov       rcx,rsi
       mov       rdx,7FF82F0DB120
       call      0000000000000CA0
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [5840]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 298
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 000000000000EC7C
       jmp       short 000000000000EC91
       mov       rcx,rdi
       mov       rdx,7FF82F213768
       call      00000000000087F0
       mov       rcx,rax
       mov       r8,1F0AAC02028
       mov       r8,[r8]
       mov       r9,1F0AEC01E48
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [0FC00]
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000003330
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr 000000000000EF03
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [8A70]
       test      eax,eax
       je        near ptr 000000000000EF21
       mov       rcx,rdi
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [3900]
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000ED18
       jmp       short 000000000000ED2D
       mov       rcx,rdi
       mov       rdx,7FF82F2139C0
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 000000000000EDE6
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000ED4A
       jmp       short 000000000000ED5F
       mov       rcx,rdi
       mov       rdx,7FF82F2139C0
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 000000000000ED72
       jmp       short 000000000000ED87
       mov       rcx,rdi
       mov       rdx,7FF82F213C50
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EFB0
       mov       r13,rax
       test      r12,r12
       je        near ptr 000000000000F024
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      0000000000000010
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000EDBD
       jmp       short 000000000000EDD2
       mov       rcx,rdi
       mov       rdx,7FF82F2139C0
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      0000000000000010
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 000000000000EDF1
       jmp       short 000000000000EE06
       mov       rcx,rdi
       mov       rdx,7FF82F213A00
       call      00000000000087F0
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [5BA0]
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000EE20
       jmp       short 000000000000EE35
       mov       rcx,rdi
       mov       rdx,7FF82F213A20
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82E9B09C8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr 000000000000EEDF
       mov       r11,[r14+30]
       test      r11,r11
       je        short 000000000000EE65
       jmp       short 000000000000EE7A
       mov       rcx,rdi
       mov       rdx,7FF82F213A50
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 000000000000EE8A
       cmp       esi,0FFFFFFFE
       jne       short 000000000000EE98
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [0F810]
       jmp       short 000000000000EEC7
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 000000000000EEBB
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000000020
       jmp       short 000000000000EEC7
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [3A98]
       mov       rcx,rbx
       mov       r11,7FF82E9B09C8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr 000000000000EE5A
       mov       rcx,rbx
       mov       r11,7FF82E9B09D0
       call      qword ptr [r11]
       mov       rax,r15
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
       mov       ecx,2E7
       mov       rdx,7FF82E9A4000
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       call      qword ptr [0B990]
       mov       rbx,rax
       mov       rax,1F0AEC02400
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000EFDB
       call      qword ptr [0BC48]
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rsi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEEB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B888]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [3030]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [5630]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 000000000000F063
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82E9B09D0
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1077
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      000000000000F778
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      0000000000006880
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short 0000000000004FF8
       mov       rcx,rdx
       call      000000000000FAB8
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short 0000000000004FD5
       jmp       short 0000000000004FEA
       mov       rcx,rsi
       mov       rdx,7FF82F2F1EC8
       call      0000000000004920
       mov       rcx,rax
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr 0000000000000378
       mov       ecx,4D
       mov       rdx,7FF82F28ED50
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,7C7
       mov       rdx,7FF82F28ED50
       call      0000000000000390
       mov       rdi,rax
       call      0000000000002E70
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      0000000000001F28
       mov       rcx,rax
       call      0000000000002F48
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 000000000000AC7C
       jmp       short 000000000000AC91
       mov       rcx,rdi
       mov       rdx,7FF82F4C1718
       call      0000000000002740
       mov       rcx,rax
       mov       r8,1C214403020
       mov       r8,[r8]
       mov       r9,1C234402678
       mov       r9,[r9]
       mov       rdx,rbx
       call      000000000000DB40
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000004F40
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      0000000000000948
       test      eax,eax
       je        near ptr 000000000000AEFD
       mov       rcx,rdi
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,r15
       call      00000000000013D0
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AD0C
       jmp       short 000000000000AD21
       mov       rcx,rdi
       mov       rdx,7FF82F4C1970
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 000000000000ADDA
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AD3E
       jmp       short 000000000000AD53
       mov       rcx,rdi
       mov       rdx,7FF82F4C1970
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 000000000000AD66
       jmp       short 000000000000AD7B
       mov       rcx,rdi
       mov       rdx,7FF82F4C1C10
       call      0000000000002740
       mov       rcx,rax
       call      000000000000B2D0
       mov       r13,rax
       test      r12,r12
       je        near ptr 000000000000B013
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      000000000000AEB0
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000ADB1
       jmp       short 000000000000ADC6
       mov       rcx,rdi
       mov       rdx,7FF82F4C1970
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      000000000000AEB0
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 000000000000ADE5
       jmp       short 000000000000ADFA
       mov       rcx,rdi
       mov       rdx,7FF82F4C19B0
       call      0000000000002740
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      00000000000065E0
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000AE13
       jmp       short 000000000000AE28
       mov       rcx,rdi
       mov       rdx,7FF82F4C19D0
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82EE906C8
       call      qword ptr [6C8]
       test      eax,eax
       je        near ptr 000000000000AED6
       mov       r11,[r14+30]
       test      r11,r11
       je        short 000000000000AE5B
       jmp       short 000000000000AE70
       mov       rcx,rdi
       mov       rdx,7FF82F4C1A00
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 000000000000AE80
       cmp       esi,0FFFFFFFE
       jne       short 000000000000AE8D
       mov       rcx,r15
       mov       rdx,rax
       call      0000000000006858
       jmp       short 000000000000AEBB
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 000000000000AEB0
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000008190
       jmp       short 000000000000AEBB
       mov       rcx,r15
       mov       rdx,rax
       call      0000000000001458
       mov       rcx,rbx
       mov       r11,7FF82EE906C8
       call      qword ptr [6C8]
       test      eax,eax
       jne       near ptr 000000000000AE50
       mov       rcx,rbx
       mov       r11,7FF82EE906D0
       call      qword ptr [6D0]
       mov       rax,r15
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
       call      0000000000002DE8
       mov       rbx,rax
       mov       rax,1C234402C18
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short 000000000000AF1C
       xor       eax,eax
       jmp       short 000000000000AF21
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000AFCE
       call      0000000000002ED0
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82F28A3D0
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82F28A3D0
       call      0000000000000390
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82F28A3D0
       call      0000000000000390
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      0000000000001FF8
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D88
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      00000000000001E8
       mov       rcx,rdi
       call      00000000000055B0
       mov       edx,3
       call      0000000000008468
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D90
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      0000000000005760
       mov       rcx,rdi
       call      00000000000055B0
       call      0000000000007270
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 000000000000B054
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82EE906D0
       call      qword ptr [6D0]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1062
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+110]
       test      rcx,rcx
       jne       near ptr 000000000000A41F
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 000000000000A49E
       lea       rcx,[rdi+0C]
       mov       rdx,27DC84005B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 000000000000A4C1
       lea       rcx,[rdi+12]
       mov       rdx,27DC4402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF81953B998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF81953B998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,rsi
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [9708]
       mov       rdx,rax
       mov       r9,27DC8402128
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,27DC4402028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull(!!0, !!0, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [3CF0]
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize(System.String)
       call      qword ptr [5828]
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [5B88]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
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
; Total bytes of code 469
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr 0000000000004230
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr 0000000000004230
       lea       rsi,[rdx+r8]
       lea       rdi,[rcx+r8]
       cmp       r8,10
       jbe       short 0000000000004186
       cmp       r8,40
       ja        short 00000000000041AE
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short 0000000000004179
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       ja        near ptr 0000000000004212
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       pop       rsi
       pop       rdi
       ret
       test      r8b,18
       jne       short 00000000000041FF
       test      r8b,4
       jne       short 00000000000041F1
       test      r8,r8
       je        short 0000000000004183
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short 0000000000004183
       movsx     r8,word ptr [rsi+0FFFE]
       mov       [rdi+0FFFE],r8w
       jmp       short 0000000000004183
       cmp       r8,800
       ja        near ptr 0000000000004239
       mov       rax,r8
       shr       rax,6
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short 00000000000041C2
       and       r8,3F
       cmp       r8,10
       ja        near ptr 0000000000004157
       jmp       short 0000000000004221
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rsi+0FFFC]
       mov       [rdi+0FFFC],edx
       jmp       short 0000000000004183
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rsi+0FFF8]
       mov       [rdi+0FFF8],rdx
       jmp       near ptr 0000000000004183
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
       jmp       near ptr 0000000000004179
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       jmp       near ptr 0000000000004183
       cmp       rcx,rdx
       je        near ptr 0000000000004183
       pop       rsi
       pop       rdi
       jmp       qword ptr [5828]
; Total bytes of code 289
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short 0000000000009E59
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short 0000000000009E59
       test      rsi,rsi
       je        near ptr 0000000000009EF3
       jmp       short 0000000000009E75
       test      rsi,rsi
       je        short 0000000000009ED9
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 0000000000009ED9
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 0000000000009EF3
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        short 0000000000009F03
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [5810]
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short 0000000000009F26
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,27DC4402028
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
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
; Total bytes of code 282
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short 0000000000008E4C
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short 0000000000008E63
       jmp       short 0000000000008E4F
       xor       r9d,r9d
       test      r8,r8
       je        short 0000000000008E63
       cmp       dword ptr [r8+8],0
       je        short 0000000000008E63
       mov       rcx,r8
       jmp       near ptr 0000000000008F09
       test      r9d,r9d
       jne       near ptr 0000000000008F09
       call      qword ptr [0BC48]
       mov       rdi,rax
       test      rsi,rsi
       je        short 0000000000008E82
       cmp       dword ptr [rsi+8],0
       je        short 0000000000008E82
       jmp       short 0000000000008E85
       mov       rsi,rdi
       mov       ecx,9
       mov       rdx,7FF81953B998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF81953B998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       test      dl,dl
       jne       short 0000000000008F18
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [0D4E0]
; Total bytes of code 268
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr 000000000000AC66
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 000000000000ACD1
       lea       rcx,[rdi+0C]
       mov       rdx,27DC84005B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 000000000000ACF4
       lea       rcx,[rdi+12]
       mov       rdx,27DC4402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000AB87
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 000000000000AB8C
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000AC27
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF81953B998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF81953B998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       [rsp+28],rcx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.GetRuntimeType(!!0 ByRef)
       call      qword ptr [0BEB8]
       mov       rsi,rax
       mov       rcx,27DC4408040
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+85],0
       je        short 000000000000ACC6
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0D840]
       mov       r8,rax
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteStringUsingSerializer(!!0 ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      qword ptr [1F78]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       call      qword ptr [0DE58]
       jmp       short 000000000000AC99
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
; Total bytes of code 568
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,r9
       mov       rdi,[rsp+80]
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       jne       near ptr 00000000000047FC
       test      r8,r8
       je        short 0000000000004774
       mov       rdx,r8
       jmp       near ptr 00000000000047FC
       call      qword ptr [0BB28]
       mov       rbx,rax
       test      rdi,rdi
       je        short 00000000000047ED
       mov       ebp,[rdi+8]
       test      ebp,ebp
       je        short 00000000000047ED
       mov       r14d,ebp
       lea       ecx,[r14+2]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebp
       jl        short 000000000000480C
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       ecx,[r15+8]
       sub       ecx,r14d
       cmp       ecx,2
       jl        short 000000000000482F
       movsxd    rcx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       rdx,27DC4402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,r15
       test      rsi,rsi
       jne       short 0000000000004852
       jmp       short 0000000000004866
       mov       rcx,27DC4402090
       mov       rcx,[rcx]
       jmp       short 00000000000047E6
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [5F48]
       mov       rcx,rsi
       call      0000000000006AD0
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [5F48]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       dword ptr [rsi+8],0
       je        short 0000000000004866
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       jmp       short 0000000000004872
       mov       rdx,rbx
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 0000000000004882
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 0000000000004887
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 0000000000004922
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF81953B998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF81953B998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       int       3
; Total bytes of code 546
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        short 00000000000063CC
       mov       eax,[rdx+8]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      eax,eax
       jne       short 00000000000063CE
       jmp       short 00000000000063CE
       xor       ecx,ecx
       test      ecx,ecx
       jne       near ptr 0000000000006478
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,5E7
       mov       rdx,7FF81953B998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF81953B998
       call      000000000000F510
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF81953B998
       call      000000000000F510
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short 00000000000064A0
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short 00000000000064B5
       mov       rcx,rsi
       mov       rdx,7FF81972B0F0
       call      0000000000000CA0
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [5888]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 298
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 00000000000087FC
       jmp       short 0000000000008811
       mov       rcx,rdi
       mov       rdx,7FF819803AD8
       call      00000000000087F0
       mov       rcx,rax
       mov       r8,27DC4402028
       mov       r8,[r8]
       mov       r9,27DC8401E48
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [3C00]
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000003330
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr 0000000000008A83
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [8A70]
       test      eax,eax
       je        near ptr 0000000000008AA1
       mov       rcx,rdi
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [3900]
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 0000000000008898
       jmp       short 00000000000088AD
       mov       rcx,rdi
       mov       rdx,7FF819803D30
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 0000000000008966
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 00000000000088CA
       jmp       short 00000000000088DF
       mov       rcx,rdi
       mov       rdx,7FF819803D30
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 00000000000088F2
       jmp       short 0000000000008907
       mov       rcx,rdi
       mov       rdx,7FF819803FC0
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EFB0
       mov       r13,rax
       test      r12,r12
       je        near ptr 0000000000008BA4
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      0000000000000010
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000893D
       jmp       short 0000000000008952
       mov       rcx,rdi
       mov       rdx,7FF819803D30
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      0000000000000010
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 0000000000008971
       jmp       short 0000000000008986
       mov       rcx,rdi
       mov       rdx,7FF819803D70
       call      00000000000087F0
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [5BA0]
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 00000000000089A0
       jmp       short 00000000000089B5
       mov       rcx,rdi
       mov       rdx,7FF819803D90
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF819000820
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr 0000000000008A5F
       mov       r11,[r14+30]
       test      r11,r11
       je        short 00000000000089E5
       jmp       short 00000000000089FA
       mov       rcx,rdi
       mov       rdx,7FF819803DC0
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 0000000000008A0A
       cmp       esi,0FFFFFFFE
       jne       short 0000000000008A18
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [5B10]
       jmp       short 0000000000008A47
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 0000000000008A3B
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000000020
       jmp       short 0000000000008A47
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [3A98]
       mov       rcx,rbx
       mov       r11,7FF819000820
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr 00000000000089DA
       mov       rcx,rbx
       mov       r11,7FF819000828
       call      qword ptr [r11]
       mov       rax,r15
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
       mov       ecx,2E7
       mov       rdx,7FF818FF4000
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       call      qword ptr [0B990]
       mov       rbx,rax
       mov       rax,27DC84023F8
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 0000000000008B5B
       call      qword ptr [0BC48]
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FF81953B998
       call      000000000000F510
       mov       rsi,rax
       mov       ecx,36B
       mov       rdx,7FF81953B998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B888]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [3030]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [5630]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 0000000000008BE3
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF819000828
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1077
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      000000000000F778
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      0000000000006880
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short 00000000000054D8
       mov       rcx,rdx
       call      000000000000FAB8
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short 00000000000054B5
       jmp       short 00000000000054CA
       mov       rcx,rsi
       mov       rdx,7FF82F2F1EC8
       call      0000000000004920
       mov       rcx,rax
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr 0000000000000378
       mov       ecx,4D
       mov       rdx,7FF82F28ED50
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,7C7
       mov       rdx,7FF82F28ED50
       call      0000000000000390
       mov       rdi,rax
       call      0000000000002E70
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      0000000000001F28
       mov       rcx,rax
       call      0000000000002F48
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 000000000000AC7C
       jmp       short 000000000000AC91
       mov       rcx,rdi
       mov       rdx,7FF82F4C1780
       call      0000000000002740
       mov       rcx,rax
       mov       r8,2D12D013020
       mov       r8,[r8]
       mov       r9,2D12D016280
       mov       r9,[r9]
       mov       rdx,rbx
       call      000000000000DB40
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000004F40
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      0000000000000948
       test      eax,eax
       je        near ptr 000000000000AEFD
       mov       rcx,rdi
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,r15
       call      00000000000013D0
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AD0C
       jmp       short 000000000000AD21
       mov       rcx,rdi
       mov       rdx,7FF82F4C19D8
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 000000000000ADDA
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AD3E
       jmp       short 000000000000AD53
       mov       rcx,rdi
       mov       rdx,7FF82F4C19D8
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 000000000000AD66
       jmp       short 000000000000AD7B
       mov       rcx,rdi
       mov       rdx,7FF82F4C1C78
       call      0000000000002740
       mov       rcx,rax
       call      000000000000B2D0
       mov       r13,rax
       test      r12,r12
       je        near ptr 000000000000B013
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      000000000000AEB0
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000ADB1
       jmp       short 000000000000ADC6
       mov       rcx,rdi
       mov       rdx,7FF82F4C19D8
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      000000000000AEB0
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 000000000000ADE5
       jmp       short 000000000000ADFA
       mov       rcx,rdi
       mov       rdx,7FF82F4C1A18
       call      0000000000002740
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      00000000000065E0
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000AE13
       jmp       short 000000000000AE28
       mov       rcx,rdi
       mov       rdx,7FF82F4C1A38
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82EE906C8
       call      qword ptr [6C8]
       test      eax,eax
       je        near ptr 000000000000AED6
       mov       r11,[r14+30]
       test      r11,r11
       je        short 000000000000AE5B
       jmp       short 000000000000AE70
       mov       rcx,rdi
       mov       rdx,7FF82F4C1A68
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 000000000000AE80
       cmp       esi,0FFFFFFFE
       jne       short 000000000000AE8D
       mov       rcx,r15
       mov       rdx,rax
       call      0000000000006858
       jmp       short 000000000000AEBB
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 000000000000AEB0
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000008190
       jmp       short 000000000000AEBB
       mov       rcx,r15
       mov       rdx,rax
       call      0000000000001458
       mov       rcx,rbx
       mov       r11,7FF82EE906C8
       call      qword ptr [6C8]
       test      eax,eax
       jne       near ptr 000000000000AE50
       mov       rcx,rbx
       mov       r11,7FF82EE906D0
       call      qword ptr [6D0]
       mov       rax,r15
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
       call      0000000000002DE8
       mov       rbx,rax
       mov       rax,2D12D016820
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short 000000000000AF1C
       xor       eax,eax
       jmp       short 000000000000AF21
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000AFCE
       call      0000000000002ED0
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82F28A3D0
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82F28A3D0
       call      0000000000000390
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82F28A3D0
       call      0000000000000390
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      0000000000001FF8
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D88
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      00000000000001E8
       mov       rcx,rdi
       call      00000000000055B0
       mov       edx,3
       call      0000000000008468
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D90
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      0000000000005760
       mov       rcx,rdi
       call      00000000000055B0
       call      0000000000007270
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 000000000000B054
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82EE906D0
       call      qword ptr [6D0]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1062
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+110]
       test      rcx,rcx
       jne       near ptr 000000000000A47F
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 000000000000A4FE
       lea       rcx,[rdi+0C]
       mov       rdx,129A10049C0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 000000000000A521
       lea       rcx,[rdi+12]
       mov       rdx,129A1002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,rsi
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [9708]
       mov       rdx,rax
       mov       r9,129A1005518
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,129A1002028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull(!!0, !!0, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [3CF0]
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize(System.String)
       call      qword ptr [5828]
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7888]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
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
; Total bytes of code 469
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr 0000000000004230
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr 0000000000004230
       lea       rsi,[rdx+r8]
       lea       rdi,[rcx+r8]
       cmp       r8,10
       jbe       short 0000000000004186
       cmp       r8,40
       ja        short 00000000000041AE
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short 0000000000004179
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       ja        near ptr 0000000000004212
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       pop       rsi
       pop       rdi
       ret
       test      r8b,18
       jne       short 00000000000041FF
       test      r8b,4
       jne       short 00000000000041F1
       test      r8,r8
       je        short 0000000000004183
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short 0000000000004183
       movsx     r8,word ptr [rsi+0FFFE]
       mov       [rdi+0FFFE],r8w
       jmp       short 0000000000004183
       cmp       r8,800
       ja        near ptr 0000000000004239
       mov       rax,r8
       shr       rax,6
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short 00000000000041C2
       and       r8,3F
       cmp       r8,10
       ja        near ptr 0000000000004157
       jmp       short 0000000000004221
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rsi+0FFFC]
       mov       [rdi+0FFFC],edx
       jmp       short 0000000000004183
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rsi+0FFF8]
       mov       [rdi+0FFF8],rdx
       jmp       near ptr 0000000000004183
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
       jmp       near ptr 0000000000004179
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       jmp       near ptr 0000000000004183
       cmp       rcx,rdx
       je        near ptr 0000000000004183
       pop       rsi
       pop       rdi
       jmp       qword ptr [5828]
; Total bytes of code 289
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short 000000000000A259
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short 000000000000A259
       test      rsi,rsi
       je        near ptr 000000000000A2F3
       jmp       short 000000000000A275
       test      rsi,rsi
       je        short 000000000000A2D9
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000A2D9
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000A2F3
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        short 000000000000A303
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [5810]
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short 000000000000A326
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,129A1002028
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
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
; Total bytes of code 282
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short 000000000000AAEC
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short 000000000000AB03
       jmp       short 000000000000AAEF
       xor       r9d,r9d
       test      r8,r8
       je        short 000000000000AB03
       cmp       dword ptr [r8+8],0
       je        short 000000000000AB03
       mov       rcx,r8
       jmp       near ptr 000000000000ABA9
       test      r9d,r9d
       jne       near ptr 000000000000ABA9
       call      qword ptr [0BC48]
       mov       rdi,rax
       test      rsi,rsi
       je        short 000000000000AB22
       cmp       dword ptr [rsi+8],0
       je        short 000000000000AB22
       jmp       short 000000000000AB25
       mov       rsi,rdi
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       test      dl,dl
       jne       short 000000000000ABB8
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [0D4E0]
; Total bytes of code 268
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr 000000000000ACC6
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 000000000000AD31
       lea       rcx,[rdi+0C]
       mov       rdx,129A10049C0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 000000000000AD54
       lea       rcx,[rdi+12]
       mov       rdx,129A1002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000ABE7
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 000000000000ABEC
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000AC87
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       [rsp+28],rcx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.GetRuntimeType(!!0 ByRef)
       call      qword ptr [0BEB8]
       mov       rsi,rax
       mov       rcx,129A3003C38
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+85],0
       je        short 000000000000AD26
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0D840]
       mov       r8,rax
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteStringUsingSerializer(!!0 ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      qword ptr [1F78]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       call      qword ptr [0DE58]
       jmp       short 000000000000ACF9
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
; Total bytes of code 568
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,r9
       mov       rdi,[rsp+80]
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       jne       near ptr 000000000000507C
       test      r8,r8
       je        short 0000000000004FF4
       mov       rdx,r8
       jmp       near ptr 000000000000507C
       call      qword ptr [0BB28]
       mov       rbx,rax
       test      rdi,rdi
       je        short 000000000000506D
       mov       ebp,[rdi+8]
       test      ebp,ebp
       je        short 000000000000506D
       mov       r14d,ebp
       lea       ecx,[r14+2]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebp
       jl        short 000000000000508C
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       ecx,[r15+8]
       sub       ecx,r14d
       cmp       ecx,2
       jl        short 00000000000050AF
       movsxd    rcx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       rdx,129A1002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,r15
       test      rsi,rsi
       jne       short 00000000000050D2
       jmp       short 00000000000050E6
       mov       rcx,129A1002090
       mov       rcx,[rcx]
       jmp       short 0000000000005066
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [5F48]
       mov       rcx,rsi
       call      0000000000006AD0
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [5F48]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       dword ptr [rsi+8],0
       je        short 00000000000050E6
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       jmp       short 00000000000050F2
       mov       rdx,rbx
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 0000000000005102
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 0000000000005107
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 00000000000051A2
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       int       3
; Total bytes of code 546
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        short 00000000000064EC
       mov       eax,[rdx+8]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      eax,eax
       jne       short 00000000000064EE
       jmp       short 00000000000064EE
       xor       ecx,ecx
       test      ecx,ecx
       jne       near ptr 0000000000006598
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,5E7
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short 00000000000065C0
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short 00000000000065D5
       mov       rcx,rsi
       mov       rdx,7FF82F0AB0F0
       call      0000000000000CA0
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [5888]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 298
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 00000000000088DC
       jmp       short 00000000000088F1
       mov       rcx,rdi
       mov       rdx,7FF82F183AF0
       call      00000000000087F0
       mov       rcx,rax
       mov       r8,129A1002028
       mov       r8,[r8]
       mov       r9,129A1005238
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7300]
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000003330
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr 0000000000008B63
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [8A70]
       test      eax,eax
       je        near ptr 0000000000008B81
       mov       rcx,rdi
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [3900]
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 0000000000008978
       jmp       short 000000000000898D
       mov       rcx,rdi
       mov       rdx,7FF82F183D48
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 0000000000008A46
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 00000000000089AA
       jmp       short 00000000000089BF
       mov       rcx,rdi
       mov       rdx,7FF82F183D48
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 00000000000089D2
       jmp       short 00000000000089E7
       mov       rcx,rdi
       mov       rdx,7FF82F183FD8
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EFB0
       mov       r13,rax
       test      r12,r12
       je        near ptr 0000000000008C84
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      0000000000000010
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 0000000000008A1D
       jmp       short 0000000000008A32
       mov       rcx,rdi
       mov       rdx,7FF82F183D48
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      0000000000000010
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 0000000000008A51
       jmp       short 0000000000008A66
       mov       rcx,rdi
       mov       rdx,7FF82F183D88
       call      00000000000087F0
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [5BA0]
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 0000000000008A80
       jmp       short 0000000000008A95
       mov       rcx,rdi
       mov       rdx,7FF82F183DA8
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82E980820
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr 0000000000008B3F
       mov       r11,[r14+30]
       test      r11,r11
       je        short 0000000000008AC5
       jmp       short 0000000000008ADA
       mov       rcx,rdi
       mov       rdx,7FF82F183DD8
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 0000000000008AEA
       cmp       esi,0FFFFFFFE
       jne       short 0000000000008AF8
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7810]
       jmp       short 0000000000008B27
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 0000000000008B1B
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000000020
       jmp       short 0000000000008B27
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [3A98]
       mov       rcx,rbx
       mov       r11,7FF82E980820
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr 0000000000008ABA
       mov       rcx,rbx
       mov       r11,7FF82E980828
       call      qword ptr [r11]
       mov       rax,r15
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
       mov       ecx,2E7
       mov       rdx,7FF82E974000
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       call      qword ptr [0B990]
       mov       rbx,rax
       mov       rax,129A10057E8
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 0000000000008C3B
       call      qword ptr [0BC48]
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rsi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B888]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [3030]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [5630]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 0000000000008CC3
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82E980828
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1077
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      000000000000F778
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      00000000000068E0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short 0000000000005B38
       mov       rcx,rdx
       call      000000000000FAB8
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short 0000000000005B15
       jmp       short 0000000000005B2A
       mov       rcx,rsi
       mov       rdx,7FF82F2F1EC8
       call      0000000000004920
       mov       rcx,rax
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr 0000000000000378
       mov       ecx,4D
       mov       rdx,7FF82F28ED50
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,7C7
       mov       rdx,7FF82F28ED50
       call      0000000000000390
       mov       rdi,rax
       call      0000000000002E70
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      0000000000001F28
       mov       rcx,rax
       call      0000000000002F48
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 000000000000ACDC
       jmp       short 000000000000ACF1
       mov       rcx,rdi
       mov       rdx,7FF82F4C1718
       call      0000000000002740
       mov       rcx,rax
       mov       r8,1C10F0A1028
       mov       r8,[r8]
       mov       r9,1C0FF0A5638
       mov       r9,[r9]
       mov       rdx,rbx
       call      000000000000DD00
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000004F40
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      0000000000000948
       test      eax,eax
       je        near ptr 000000000000AF5D
       mov       rcx,rdi
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,r15
       call      00000000000013D0
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AD6C
       jmp       short 000000000000AD81
       mov       rcx,rdi
       mov       rdx,7FF82F4C1970
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 000000000000AE3A
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AD9E
       jmp       short 000000000000ADB3
       mov       rcx,rdi
       mov       rdx,7FF82F4C1970
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 000000000000ADC6
       jmp       short 000000000000ADDB
       mov       rcx,rdi
       mov       rdx,7FF82F4C1C10
       call      0000000000002740
       mov       rcx,rax
       call      000000000000B2D0
       mov       r13,rax
       test      r12,r12
       je        near ptr 000000000000B073
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      000000000000AEB0
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AE11
       jmp       short 000000000000AE26
       mov       rcx,rdi
       mov       rdx,7FF82F4C1970
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      000000000000AEB0
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 000000000000AE45
       jmp       short 000000000000AE5A
       mov       rcx,rdi
       mov       rdx,7FF82F4C19B0
       call      0000000000002740
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      00000000000065E0
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000AE73
       jmp       short 000000000000AE88
       mov       rcx,rdi
       mov       rdx,7FF82F4C19D0
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82EE906C8
       call      qword ptr [6C8]
       test      eax,eax
       je        near ptr 000000000000AF36
       mov       r11,[r14+30]
       test      r11,r11
       je        short 000000000000AEBB
       jmp       short 000000000000AED0
       mov       rcx,rdi
       mov       rdx,7FF82F4C1A00
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 000000000000AEE0
       cmp       esi,0FFFFFFFE
       jne       short 000000000000AEED
       mov       rcx,r15
       mov       rdx,rax
       call      00000000000068B8
       jmp       short 000000000000AF1B
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 000000000000AF10
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000008190
       jmp       short 000000000000AF1B
       mov       rcx,r15
       mov       rdx,rax
       call      0000000000001458
       mov       rcx,rbx
       mov       r11,7FF82EE906C8
       call      qword ptr [6C8]
       test      eax,eax
       jne       near ptr 000000000000AEB0
       mov       rcx,rbx
       mov       r11,7FF82EE906D0
       call      qword ptr [6D0]
       mov       rax,r15
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
       call      0000000000002DE8
       mov       rbx,rax
       mov       rax,1C0FF0A5BD8
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short 000000000000AF7C
       xor       eax,eax
       jmp       short 000000000000AF81
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000B02E
       call      0000000000002ED0
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82F28A3D0
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82F28A3D0
       call      0000000000000390
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82F28A3D0
       call      0000000000000390
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      0000000000001FF8
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D88
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      00000000000001E8
       mov       rcx,rdi
       call      00000000000055B0
       mov       edx,3
       call      0000000000008468
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D90
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      0000000000005760
       mov       rcx,rdi
       call      00000000000055B0
       call      0000000000007270
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 000000000000B0B4
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82EE906D0
       call      qword ptr [6D0]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1062
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+110]
       test      rcx,rcx
       jne       near ptr 000000000000A7FF
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 000000000000A87E
       lea       rcx,[rdi+0C]
       mov       rdx,24E5A8005B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 000000000000A8A1
       lea       rcx,[rdi+12]
       mov       rdx,24E56802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,rsi
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [9708]
       mov       rdx,rax
       mov       r9,24E56808CD8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,24E56802028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull(!!0, !!0, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [3CF0]
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize(System.String)
       call      qword ptr [5828]
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7B88]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
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
; Total bytes of code 469
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr 0000000000004230
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr 0000000000004230
       lea       rsi,[rdx+r8]
       lea       rdi,[rcx+r8]
       cmp       r8,10
       jbe       short 0000000000004186
       cmp       r8,40
       ja        short 00000000000041AE
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short 0000000000004179
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       ja        near ptr 0000000000004212
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       pop       rsi
       pop       rdi
       ret
       test      r8b,18
       jne       short 00000000000041FF
       test      r8b,4
       jne       short 00000000000041F1
       test      r8,r8
       je        short 0000000000004183
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short 0000000000004183
       movsx     r8,word ptr [rsi+0FFFE]
       mov       [rdi+0FFFE],r8w
       jmp       short 0000000000004183
       cmp       r8,800
       ja        near ptr 0000000000004239
       mov       rax,r8
       shr       rax,6
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short 00000000000041C2
       and       r8,3F
       cmp       r8,10
       ja        near ptr 0000000000004157
       jmp       short 0000000000004221
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rsi+0FFFC]
       mov       [rdi+0FFFC],edx
       jmp       short 0000000000004183
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rsi+0FFF8]
       mov       [rdi+0FFF8],rdx
       jmp       near ptr 0000000000004183
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
       jmp       near ptr 0000000000004179
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       jmp       near ptr 0000000000004183
       cmp       rcx,rdx
       je        near ptr 0000000000004183
       pop       rsi
       pop       rdi
       jmp       qword ptr [5828]
; Total bytes of code 289
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short 000000000000A359
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short 000000000000A359
       test      rsi,rsi
       je        near ptr 000000000000A3F3
       jmp       short 000000000000A375
       test      rsi,rsi
       je        short 000000000000A3D9
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000A3D9
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000A3F3
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        short 000000000000A403
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [5810]
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short 000000000000A426
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,24E56802028
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
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
; Total bytes of code 282
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short 000000000000918C
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short 00000000000091A3
       jmp       short 000000000000918F
       xor       r9d,r9d
       test      r8,r8
       je        short 00000000000091A3
       cmp       dword ptr [r8+8],0
       je        short 00000000000091A3
       mov       rcx,r8
       jmp       near ptr 0000000000009249
       test      r9d,r9d
       jne       near ptr 0000000000009249
       call      qword ptr [0BC48]
       mov       rdi,rax
       test      rsi,rsi
       je        short 00000000000091C2
       cmp       dword ptr [rsi+8],0
       je        short 00000000000091C2
       jmp       short 00000000000091C5
       mov       rsi,rdi
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       test      dl,dl
       jne       short 0000000000009258
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [0D4E0]
; Total bytes of code 268
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr 000000000000B046
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 000000000000B0B1
       lea       rcx,[rdi+0C]
       mov       rdx,24E5A8005B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 000000000000B0D4
       lea       rcx,[rdi+12]
       mov       rdx,24E56802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000AF67
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 000000000000AF6C
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000B007
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       [rsp+28],rcx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.GetRuntimeType(!!0 ByRef)
       call      qword ptr [0BEB8]
       mov       rsi,rax
       mov       rcx,24E56808040
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+85],0
       je        short 000000000000B0A6
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0D840]
       mov       r8,rax
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteStringUsingSerializer(!!0 ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      qword ptr [1F78]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       call      qword ptr [0DE58]
       jmp       short 000000000000B079
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
; Total bytes of code 568
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,r9
       mov       rdi,[rsp+80]
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       jne       near ptr 000000000000508C
       test      r8,r8
       je        short 0000000000005004
       mov       rdx,r8
       jmp       near ptr 000000000000508C
       call      qword ptr [0BB28]
       mov       rbx,rax
       test      rdi,rdi
       je        short 000000000000507D
       mov       ebp,[rdi+8]
       test      ebp,ebp
       je        short 000000000000507D
       mov       r14d,ebp
       lea       ecx,[r14+2]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebp
       jl        short 000000000000509C
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       ecx,[r15+8]
       sub       ecx,r14d
       cmp       ecx,2
       jl        short 00000000000050BF
       movsxd    rcx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       rdx,24E56802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,r15
       test      rsi,rsi
       jne       short 00000000000050E2
       jmp       short 00000000000050F6
       mov       rcx,24E56802090
       mov       rcx,[rcx]
       jmp       short 0000000000005076
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [5F48]
       mov       rcx,rsi
       call      0000000000006AD0
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [5F48]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       dword ptr [rsi+8],0
       je        short 00000000000050F6
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       jmp       short 0000000000005102
       mov       rdx,rbx
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 0000000000005112
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 0000000000005117
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 00000000000051B2
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       int       3
; Total bytes of code 546
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        short 000000000000688C
       mov       eax,[rdx+8]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      eax,eax
       jne       short 000000000000688E
       jmp       short 000000000000688E
       xor       ecx,ecx
       test      ecx,ecx
       jne       near ptr 0000000000006938
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,5E7
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short 0000000000006960
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short 0000000000006975
       mov       rcx,rsi
       mov       rdx,7FF82F0AB0F0
       call      0000000000000CA0
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [5888]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 298
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 0000000000008C5C
       jmp       short 0000000000008C71
       mov       rcx,rdi
       mov       rdx,7FF82F183AF0
       call      00000000000087F0
       mov       rcx,rax
       mov       r8,24E56802028
       mov       r8,[r8]
       mov       r9,24E568089F8
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7300]
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000003330
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr 0000000000008EE3
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [8A70]
       test      eax,eax
       je        near ptr 0000000000008F01
       mov       rcx,rdi
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [3900]
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 0000000000008CF8
       jmp       short 0000000000008D0D
       mov       rcx,rdi
       mov       rdx,7FF82F183D48
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 0000000000008DC6
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 0000000000008D2A
       jmp       short 0000000000008D3F
       mov       rcx,rdi
       mov       rdx,7FF82F183D48
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 0000000000008D52
       jmp       short 0000000000008D67
       mov       rcx,rdi
       mov       rdx,7FF82F183FD8
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EFB0
       mov       r13,rax
       test      r12,r12
       je        near ptr 0000000000009004
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      0000000000000010
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 0000000000008D9D
       jmp       short 0000000000008DB2
       mov       rcx,rdi
       mov       rdx,7FF82F183D48
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      0000000000000010
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 0000000000008DD1
       jmp       short 0000000000008DE6
       mov       rcx,rdi
       mov       rdx,7FF82F183D88
       call      00000000000087F0
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [5BA0]
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 0000000000008E00
       jmp       short 0000000000008E15
       mov       rcx,rdi
       mov       rdx,7FF82F183DA8
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82E980838
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr 0000000000008EBF
       mov       r11,[r14+30]
       test      r11,r11
       je        short 0000000000008E45
       jmp       short 0000000000008E5A
       mov       rcx,rdi
       mov       rdx,7FF82F183DD8
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 0000000000008E6A
       cmp       esi,0FFFFFFFE
       jne       short 0000000000008E78
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7B10]
       jmp       short 0000000000008EA7
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 0000000000008E9B
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000000020
       jmp       short 0000000000008EA7
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [3A98]
       mov       rcx,rbx
       mov       r11,7FF82E980838
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr 0000000000008E3A
       mov       rcx,rbx
       mov       r11,7FF82E980840
       call      qword ptr [r11]
       mov       rax,r15
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
       mov       ecx,2E7
       mov       rdx,7FF82E974000
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       call      qword ptr [0B990]
       mov       rbx,rax
       mov       rax,24E56808FA8
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 0000000000008FBB
       call      qword ptr [0BC48]
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rsi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B888]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [3030]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [5630]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 0000000000009043
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82E980840
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1077
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      000000000000F778
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      00000000000068B0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short 00000000000058B8
       mov       rcx,rdx
       call      000000000000FAB8
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short 0000000000005895
       jmp       short 00000000000058AA
       mov       rcx,rsi
       mov       rdx,7FF82F2F1EC8
       call      0000000000004920
       mov       rcx,rax
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr 0000000000000378
       mov       ecx,4D
       mov       rdx,7FF82F28ED50
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,7C7
       mov       rdx,7FF82F28ED50
       call      0000000000000390
       mov       rdi,rax
       call      0000000000002E70
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      0000000000001F28
       mov       rcx,rax
       call      0000000000002F48
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 000000000000AC3C
       jmp       short 000000000000AC51
       mov       rcx,rdi
       mov       rdx,7FF82F4C1718
       call      0000000000002740
       mov       rcx,rax
       mov       r8,116717D3020
       mov       r8,[r8]
       mov       r9,116617D1E78
       mov       r9,[r9]
       mov       rdx,rbx
       call      000000000000DD00
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000004F40
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      0000000000000948
       test      eax,eax
       je        near ptr 000000000000AEBD
       mov       rcx,rdi
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,r15
       call      00000000000013D0
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000ACCC
       jmp       short 000000000000ACE1
       mov       rcx,rdi
       mov       rdx,7FF82F4C1970
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 000000000000AD9A
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000ACFE
       jmp       short 000000000000AD13
       mov       rcx,rdi
       mov       rdx,7FF82F4C1970
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 000000000000AD26
       jmp       short 000000000000AD3B
       mov       rcx,rdi
       mov       rdx,7FF82F4C1C10
       call      0000000000002740
       mov       rcx,rax
       call      000000000000B2D0
       mov       r13,rax
       test      r12,r12
       je        near ptr 000000000000AFD3
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      000000000000AEB0
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AD71
       jmp       short 000000000000AD86
       mov       rcx,rdi
       mov       rdx,7FF82F4C1970
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      000000000000AEB0
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 000000000000ADA5
       jmp       short 000000000000ADBA
       mov       rcx,rdi
       mov       rdx,7FF82F4C19B0
       call      0000000000002740
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      00000000000065E0
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000ADD3
       jmp       short 000000000000ADE8
       mov       rcx,rdi
       mov       rdx,7FF82F4C19D0
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82EE906C8
       call      qword ptr [6C8]
       test      eax,eax
       je        near ptr 000000000000AE96
       mov       r11,[r14+30]
       test      r11,r11
       je        short 000000000000AE1B
       jmp       short 000000000000AE30
       mov       rcx,rdi
       mov       rdx,7FF82F4C1A00
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 000000000000AE40
       cmp       esi,0FFFFFFFE
       jne       short 000000000000AE4D
       mov       rcx,r15
       mov       rdx,rax
       call      0000000000006888
       jmp       short 000000000000AE7B
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 000000000000AE70
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000008190
       jmp       short 000000000000AE7B
       mov       rcx,r15
       mov       rdx,rax
       call      0000000000001458
       mov       rcx,rbx
       mov       r11,7FF82EE906C8
       call      qword ptr [6C8]
       test      eax,eax
       jne       near ptr 000000000000AE10
       mov       rcx,rbx
       mov       r11,7FF82EE906D0
       call      qword ptr [6D0]
       mov       rax,r15
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
       call      0000000000002DE8
       mov       rbx,rax
       mov       rax,116617D2418
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short 000000000000AEDC
       xor       eax,eax
       jmp       short 000000000000AEE1
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000AF8E
       call      0000000000002ED0
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82F28A3D0
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82F28A3D0
       call      0000000000000390
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82F28A3D0
       call      0000000000000390
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      0000000000001FF8
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D88
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      00000000000001E8
       mov       rcx,rdi
       call      00000000000055B0
       mov       edx,3
       call      0000000000008468
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D90
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      0000000000005760
       mov       rcx,rdi
       call      00000000000055B0
       call      0000000000007270
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 000000000000B014
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82EE906D0
       call      qword ptr [6D0]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1062
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+110]
       test      rcx,rcx
       jne       near ptr 000000000000825F
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 00000000000082DE
       lea       rcx,[rdi+0C]
       mov       rdx,15B748005B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 0000000000008301
       lea       rcx,[rdi+12]
       mov       rdx,15B76802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEDB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEDB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,rsi
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [9708]
       mov       rdx,rax
       mov       r9,15B76805D18
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,15B76802028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull(!!0, !!0, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [3CF0]
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize(System.String)
       call      qword ptr [5828]
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7B88]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
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
; Total bytes of code 469
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr 0000000000004E30
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr 0000000000004E30
       lea       rsi,[rdx+r8]
       lea       rdi,[rcx+r8]
       cmp       r8,10
       jbe       short 0000000000004D86
       cmp       r8,40
       ja        short 0000000000004DAE
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short 0000000000004D79
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       ja        near ptr 0000000000004E12
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       pop       rsi
       pop       rdi
       ret
       test      r8b,18
       jne       short 0000000000004DFF
       test      r8b,4
       jne       short 0000000000004DF1
       test      r8,r8
       je        short 0000000000004D83
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short 0000000000004D83
       movsx     r8,word ptr [rsi+0FFFE]
       mov       [rdi+0FFFE],r8w
       jmp       short 0000000000004D83
       cmp       r8,800
       ja        near ptr 0000000000004E39
       mov       rax,r8
       shr       rax,6
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short 0000000000004DC2
       and       r8,3F
       cmp       r8,10
       ja        near ptr 0000000000004D57
       jmp       short 0000000000004E21
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rsi+0FFFC]
       mov       [rdi+0FFFC],edx
       jmp       short 0000000000004D83
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rsi+0FFF8]
       mov       [rdi+0FFF8],rdx
       jmp       near ptr 0000000000004D83
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
       jmp       near ptr 0000000000004D79
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       jmp       near ptr 0000000000004D83
       cmp       rcx,rdx
       je        near ptr 0000000000004D83
       pop       rsi
       pop       rdi
       jmp       qword ptr [5828]
; Total bytes of code 289
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short 000000000000A3E9
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short 000000000000A3E9
       test      rsi,rsi
       je        near ptr 000000000000A483
       jmp       short 000000000000A405
       test      rsi,rsi
       je        short 000000000000A469
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000A469
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000A483
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        short 000000000000A493
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [5810]
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short 000000000000A4B6
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,15B76802028
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
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
; Total bytes of code 282
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short 0000000000007FDC
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short 0000000000007FF3
       jmp       short 0000000000007FDF
       xor       r9d,r9d
       test      r8,r8
       je        short 0000000000007FF3
       cmp       dword ptr [r8+8],0
       je        short 0000000000007FF3
       mov       rcx,r8
       jmp       near ptr 0000000000008099
       test      r9d,r9d
       jne       near ptr 0000000000008099
       call      qword ptr [0BC48]
       mov       rdi,rax
       test      rsi,rsi
       je        short 0000000000008012
       cmp       dword ptr [rsi+8],0
       je        short 0000000000008012
       jmp       short 0000000000008015
       mov       rsi,rdi
       mov       ecx,9
       mov       rdx,7FF82EEDB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEDB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       test      dl,dl
       jne       short 00000000000080A8
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [0D4E0]
; Total bytes of code 268
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr 0000000000008AA6
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 0000000000008B11
       lea       rcx,[rdi+0C]
       mov       rdx,15B748005B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 0000000000008B34
       lea       rcx,[rdi+12]
       mov       rdx,15B76802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 00000000000089C7
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 00000000000089CC
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 0000000000008A67
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEDB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEDB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       [rsp+28],rcx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.GetRuntimeType(!!0 ByRef)
       call      qword ptr [0BEB8]
       mov       rsi,rax
       mov       rcx,15B7A803C38
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+85],0
       je        short 0000000000008B06
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0D840]
       mov       r8,rax
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteStringUsingSerializer(!!0 ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      qword ptr [1F78]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       call      qword ptr [0DE58]
       jmp       short 0000000000008AD9
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
; Total bytes of code 568
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,r9
       mov       rdi,[rsp+80]
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       jne       near ptr 0000000000005D1C
       test      r8,r8
       je        short 0000000000005C94
       mov       rdx,r8
       jmp       near ptr 0000000000005D1C
       call      qword ptr [0BB28]
       mov       rbx,rax
       test      rdi,rdi
       je        short 0000000000005D0D
       mov       ebp,[rdi+8]
       test      ebp,ebp
       je        short 0000000000005D0D
       mov       r14d,ebp
       lea       ecx,[r14+2]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebp
       jl        short 0000000000005D2C
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       ecx,[r15+8]
       sub       ecx,r14d
       cmp       ecx,2
       jl        short 0000000000005D4F
       movsxd    rcx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       rdx,15B76802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,r15
       test      rsi,rsi
       jne       short 0000000000005D72
       jmp       short 0000000000005D86
       mov       rcx,15B76802090
       mov       rcx,[rcx]
       jmp       short 0000000000005D06
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [5F48]
       mov       rcx,rsi
       call      0000000000006AD0
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [5F48]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       dword ptr [rsi+8],0
       je        short 0000000000005D86
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       jmp       short 0000000000005D92
       mov       rdx,rbx
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 0000000000005DA2
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 0000000000005DA7
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 0000000000005E42
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEDB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEDB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       int       3
; Total bytes of code 546
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        short 0000000000009FBC
       mov       eax,[rdx+8]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      eax,eax
       jne       short 0000000000009FBE
       jmp       short 0000000000009FBE
       xor       ecx,ecx
       test      ecx,ecx
       jne       near ptr 000000000000A068
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,5E7
       mov       rdx,7FF82EEDB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF82EEDB998
       call      000000000000F510
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82EEDB998
       call      000000000000F510
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short 000000000000A090
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short 000000000000A0A5
       mov       rcx,rsi
       mov       rdx,7FF82F0CB0F0
       call      0000000000000CA0
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [5888]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 298
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 00000000000066BC
       jmp       short 00000000000066D1
       mov       rcx,rdi
       mov       rdx,7FF82F1A3AF0
       call      00000000000087F0
       mov       rcx,rax
       mov       r8,15B76802028
       mov       r8,[r8]
       mov       r9,15B76805A38
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7300]
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000003330
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr 0000000000006943
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [8A70]
       test      eax,eax
       je        near ptr 0000000000006961
       mov       rcx,rdi
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [3900]
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 0000000000006758
       jmp       short 000000000000676D
       mov       rcx,rdi
       mov       rdx,7FF82F1A3D48
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 0000000000006826
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000678A
       jmp       short 000000000000679F
       mov       rcx,rdi
       mov       rdx,7FF82F1A3D48
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 00000000000067B2
       jmp       short 00000000000067C7
       mov       rcx,rdi
       mov       rdx,7FF82F1A3FD8
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EFB0
       mov       r13,rax
       test      r12,r12
       je        near ptr 0000000000006A64
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      0000000000000010
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 00000000000067FD
       jmp       short 0000000000006812
       mov       rcx,rdi
       mov       rdx,7FF82F1A3D48
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      0000000000000010
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 0000000000006831
       jmp       short 0000000000006846
       mov       rcx,rdi
       mov       rdx,7FF82F1A3D88
       call      00000000000087F0
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [5BA0]
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 0000000000006860
       jmp       short 0000000000006875
       mov       rcx,rdi
       mov       rdx,7FF82F1A3DA8
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82E9A0838
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr 000000000000691F
       mov       r11,[r14+30]
       test      r11,r11
       je        short 00000000000068A5
       jmp       short 00000000000068BA
       mov       rcx,rdi
       mov       rdx,7FF82F1A3DD8
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 00000000000068CA
       cmp       esi,0FFFFFFFE
       jne       short 00000000000068D8
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7B10]
       jmp       short 0000000000006907
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 00000000000068FB
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000000020
       jmp       short 0000000000006907
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [3A98]
       mov       rcx,rbx
       mov       r11,7FF82E9A0838
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr 000000000000689A
       mov       rcx,rbx
       mov       r11,7FF82E9A0840
       call      qword ptr [r11]
       mov       rax,r15
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
       mov       ecx,2E7
       mov       rdx,7FF82E994000
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       call      qword ptr [0B990]
       mov       rbx,rax
       mov       rax,15B76805FE8
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 0000000000006A1B
       call      qword ptr [0BC48]
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FF82EEDB998
       call      000000000000F510
       mov       rsi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEDB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B888]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [3030]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [5630]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 0000000000006AA3
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82E9A0840
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1077
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      000000000000F778
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      00000000000068E0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short 00000000000086A8
       mov       rcx,rdx
       call      000000000000FAB8
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short 0000000000008685
       jmp       short 000000000000869A
       mov       rcx,rsi
       mov       rdx,7FF82F2E1EC8
       call      0000000000004920
       mov       rcx,rax
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr 0000000000000378
       mov       ecx,4D
       mov       rdx,7FF82F27ED50
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,7C7
       mov       rdx,7FF82F27ED50
       call      0000000000000390
       mov       rdi,rax
       call      0000000000002E70
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      0000000000001F28
       mov       rcx,rax
       call      0000000000002F48
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 000000000000ACDC
       jmp       short 000000000000ACF1
       mov       rcx,rdi
       mov       rdx,7FF82F4B1780
       call      0000000000002740
       mov       rcx,rax
       mov       r8,2119A963020
       mov       r8,[r8]
       mov       r9,2119A96A258
       mov       r9,[r9]
       mov       rdx,rbx
       call      000000000000DD00
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000004F40
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      0000000000000948
       test      eax,eax
       je        near ptr 000000000000AF5D
       mov       rcx,rdi
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,r15
       call      00000000000013D0
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AD6C
       jmp       short 000000000000AD81
       mov       rcx,rdi
       mov       rdx,7FF82F4B19D8
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 000000000000AE3A
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AD9E
       jmp       short 000000000000ADB3
       mov       rcx,rdi
       mov       rdx,7FF82F4B19D8
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 000000000000ADC6
       jmp       short 000000000000ADDB
       mov       rcx,rdi
       mov       rdx,7FF82F4B1C78
       call      0000000000002740
       mov       rcx,rax
       call      000000000000B2D0
       mov       r13,rax
       test      r12,r12
       je        near ptr 000000000000B073
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      000000000000AEB0
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AE11
       jmp       short 000000000000AE26
       mov       rcx,rdi
       mov       rdx,7FF82F4B19D8
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      000000000000AEB0
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 000000000000AE45
       jmp       short 000000000000AE5A
       mov       rcx,rdi
       mov       rdx,7FF82F4B1A18
       call      0000000000002740
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      00000000000065E0
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000AE73
       jmp       short 000000000000AE88
       mov       rcx,rdi
       mov       rdx,7FF82F4B1A38
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82EE806C8
       call      qword ptr [6C8]
       test      eax,eax
       je        near ptr 000000000000AF36
       mov       r11,[r14+30]
       test      r11,r11
       je        short 000000000000AEBB
       jmp       short 000000000000AED0
       mov       rcx,rdi
       mov       rdx,7FF82F4B1A68
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 000000000000AEE0
       cmp       esi,0FFFFFFFE
       jne       short 000000000000AEED
       mov       rcx,r15
       mov       rdx,rax
       call      00000000000068B8
       jmp       short 000000000000AF1B
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 000000000000AF10
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000008190
       jmp       short 000000000000AF1B
       mov       rcx,r15
       mov       rdx,rax
       call      0000000000001458
       mov       rcx,rbx
       mov       r11,7FF82EE806C8
       call      qword ptr [6C8]
       test      eax,eax
       jne       near ptr 000000000000AEB0
       mov       rcx,rbx
       mov       r11,7FF82EE806D0
       call      qword ptr [6D0]
       mov       rax,r15
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
       call      0000000000002DE8
       mov       rbx,rax
       mov       rax,2119A96A7F8
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short 000000000000AF7C
       xor       eax,eax
       jmp       short 000000000000AF81
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000B02E
       call      0000000000002ED0
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82F27A3D0
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82F27A3D0
       call      0000000000000390
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82F27A3D0
       call      0000000000000390
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      0000000000001FF8
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D88
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      00000000000001E8
       mov       rcx,rdi
       call      00000000000055B0
       mov       edx,3
       call      0000000000008468
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D90
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      0000000000005760
       mov       rcx,rdi
       call      00000000000055B0
       call      0000000000007270
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 000000000000B0B4
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82EE806D0
       call      qword ptr [6D0]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1062
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+110]
       test      rcx,rcx
       jne       near ptr 000000000000827F
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 00000000000082FE
       lea       rcx,[rdi+0C]
       mov       rdx,2AB4A0005B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 0000000000008321
       lea       rcx,[rdi+12]
       mov       rdx,2AB46002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,rsi
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [9708]
       mov       rdx,rax
       mov       r9,2AB4A002128
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2AB46002028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull(!!0, !!0, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [3CF0]
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize(System.String)
       call      qword ptr [5828]
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7888]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
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
; Total bytes of code 469
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr 0000000000008290
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr 0000000000008290
       lea       rsi,[rdx+r8]
       lea       rdi,[rcx+r8]
       cmp       r8,10
       jbe       short 00000000000081E6
       cmp       r8,40
       ja        short 000000000000820E
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short 00000000000081D9
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       ja        near ptr 0000000000008272
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       pop       rsi
       pop       rdi
       ret
       test      r8b,18
       jne       short 000000000000825F
       test      r8b,4
       jne       short 0000000000008251
       test      r8,r8
       je        short 00000000000081E3
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short 00000000000081E3
       movsx     r8,word ptr [rsi+0FFFE]
       mov       [rdi+0FFFE],r8w
       jmp       short 00000000000081E3
       cmp       r8,800
       ja        near ptr 0000000000008299
       mov       rax,r8
       shr       rax,6
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short 0000000000008222
       and       r8,3F
       cmp       r8,10
       ja        near ptr 00000000000081B7
       jmp       short 0000000000008281
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rsi+0FFFC]
       mov       [rdi+0FFFC],edx
       jmp       short 00000000000081E3
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rsi+0FFF8]
       mov       [rdi+0FFF8],rdx
       jmp       near ptr 00000000000081E3
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
       jmp       near ptr 00000000000081D9
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       jmp       near ptr 00000000000081E3
       cmp       rcx,rdx
       je        near ptr 00000000000081E3
       pop       rsi
       pop       rdi
       jmp       qword ptr [5828]
; Total bytes of code 289
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short 000000000000A3F9
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short 000000000000A3F9
       test      rsi,rsi
       je        near ptr 000000000000A493
       jmp       short 000000000000A415
       test      rsi,rsi
       je        short 000000000000A479
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000A479
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000A493
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        short 000000000000A4A3
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [5810]
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short 000000000000A4C6
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,2AB46002028
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
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
; Total bytes of code 282
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short 0000000000007D1C
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short 0000000000007D33
       jmp       short 0000000000007D1F
       xor       r9d,r9d
       test      r8,r8
       je        short 0000000000007D33
       cmp       dword ptr [r8+8],0
       je        short 0000000000007D33
       mov       rcx,r8
       jmp       near ptr 0000000000007DD9
       test      r9d,r9d
       jne       near ptr 0000000000007DD9
       call      qword ptr [0BC48]
       mov       rdi,rax
       test      rsi,rsi
       je        short 0000000000007D52
       cmp       dword ptr [rsi+8],0
       je        short 0000000000007D52
       jmp       short 0000000000007D55
       mov       rsi,rdi
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       test      dl,dl
       jne       short 0000000000007DE8
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [0D4E0]
; Total bytes of code 268
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr 0000000000008AC6
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 0000000000008B31
       lea       rcx,[rdi+0C]
       mov       rdx,2AB4A0005B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 0000000000008B54
       lea       rcx,[rdi+12]
       mov       rdx,2AB46002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 00000000000089E7
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 00000000000089EC
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 0000000000008A87
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       [rsp+28],rcx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.GetRuntimeType(!!0 ByRef)
       call      qword ptr [0BEB8]
       mov       rsi,rax
       mov       rcx,2AB4C003C38
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+85],0
       je        short 0000000000008B26
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0D840]
       mov       r8,rax
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteStringUsingSerializer(!!0 ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      qword ptr [1F78]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       call      qword ptr [0DE58]
       jmp       short 0000000000008AF9
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
; Total bytes of code 568
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,r9
       mov       rdi,[rsp+80]
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       jne       near ptr 0000000000005E7C
       test      r8,r8
       je        short 0000000000005DF4
       mov       rdx,r8
       jmp       near ptr 0000000000005E7C
       call      qword ptr [0BB28]
       mov       rbx,rax
       test      rdi,rdi
       je        short 0000000000005E6D
       mov       ebp,[rdi+8]
       test      ebp,ebp
       je        short 0000000000005E6D
       mov       r14d,ebp
       lea       ecx,[r14+2]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebp
       jl        short 0000000000005E8C
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       ecx,[r15+8]
       sub       ecx,r14d
       cmp       ecx,2
       jl        short 0000000000005EAF
       movsxd    rcx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       rdx,2AB46002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,r15
       test      rsi,rsi
       jne       short 0000000000005ED2
       jmp       short 0000000000005EE6
       mov       rcx,2AB46002090
       mov       rcx,[rcx]
       jmp       short 0000000000005E66
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [5F48]
       mov       rcx,rsi
       call      0000000000006AD0
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [5F48]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       dword ptr [rsi+8],0
       je        short 0000000000005EE6
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       jmp       short 0000000000005EF2
       mov       rdx,rbx
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 0000000000005F02
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 0000000000005F07
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 0000000000005FA2
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       int       3
; Total bytes of code 546
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        short 0000000000009FDC
       mov       eax,[rdx+8]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      eax,eax
       jne       short 0000000000009FDE
       jmp       short 0000000000009FDE
       xor       ecx,ecx
       test      ecx,ecx
       jne       near ptr 000000000000A088
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,5E7
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short 000000000000A0B0
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short 000000000000A0C5
       mov       rcx,rsi
       mov       rdx,7FF82F0AB0F0
       call      0000000000000CA0
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [5888]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 298
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 00000000000066DC
       jmp       short 00000000000066F1
       mov       rcx,rdi
       mov       rdx,7FF82F183B00
       call      00000000000087F0
       mov       rcx,rax
       mov       r8,2AB46002028
       mov       r8,[r8]
       mov       r9,2AB4A001E48
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7300]
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000003330
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr 0000000000006963
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [8A70]
       test      eax,eax
       je        near ptr 0000000000006981
       mov       rcx,rdi
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [3900]
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 0000000000006778
       jmp       short 000000000000678D
       mov       rcx,rdi
       mov       rdx,7FF82F183D58
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 0000000000006846
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 00000000000067AA
       jmp       short 00000000000067BF
       mov       rcx,rdi
       mov       rdx,7FF82F183D58
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 00000000000067D2
       jmp       short 00000000000067E7
       mov       rcx,rdi
       mov       rdx,7FF82F183FE8
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EFB0
       mov       r13,rax
       test      r12,r12
       je        near ptr 0000000000006A84
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      0000000000000010
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000681D
       jmp       short 0000000000006832
       mov       rcx,rdi
       mov       rdx,7FF82F183D58
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      0000000000000010
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 0000000000006851
       jmp       short 0000000000006866
       mov       rcx,rdi
       mov       rdx,7FF82F183D98
       call      00000000000087F0
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [5BA0]
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 0000000000006880
       jmp       short 0000000000006895
       mov       rcx,rdi
       mov       rdx,7FF82F183DB8
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82E980838
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr 000000000000693F
       mov       r11,[r14+30]
       test      r11,r11
       je        short 00000000000068C5
       jmp       short 00000000000068DA
       mov       rcx,rdi
       mov       rdx,7FF82F183DE8
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 00000000000068EA
       cmp       esi,0FFFFFFFE
       jne       short 00000000000068F8
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7810]
       jmp       short 0000000000006927
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 000000000000691B
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000000020
       jmp       short 0000000000006927
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [3A98]
       mov       rcx,rbx
       mov       r11,7FF82E980838
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr 00000000000068BA
       mov       rcx,rbx
       mov       r11,7FF82E980840
       call      qword ptr [r11]
       mov       rax,r15
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
       mov       ecx,2E7
       mov       rdx,7FF82E974000
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       call      qword ptr [0B990]
       mov       rbx,rax
       mov       rax,2AB4A0023F8
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 0000000000006A3B
       call      qword ptr [0BC48]
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rsi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B888]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [3030]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [5630]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 0000000000006AC3
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82E980840
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1077
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      000000000000F778
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      00000000000068E0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short 0000000000003B08
       mov       rcx,rdx
       call      000000000000FAB8
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short 0000000000003AE5
       jmp       short 0000000000003AFA
       mov       rcx,rsi
       mov       rdx,7FF82F2D1EC8
       call      0000000000004920
       mov       rcx,rax
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr 0000000000000378
       mov       ecx,4D
       mov       rdx,7FF82F26ED50
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,7C7
       mov       rdx,7FF82F26ED50
       call      0000000000000390
       mov       rdi,rax
       call      0000000000002E70
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      0000000000001F28
       mov       rcx,rax
       call      0000000000002F48
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 000000000000ACDC
       jmp       short 000000000000ACF1
       mov       rcx,rdi
       mov       rdx,7FF82F4A1780
       call      0000000000002740
       mov       rcx,rax
       mov       r8,2235CE73020
       mov       r8,[r8]
       mov       r9,2237CE71E78
       mov       r9,[r9]
       mov       rdx,rbx
       call      000000000000DD10
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000004F40
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      0000000000000948
       test      eax,eax
       je        near ptr 000000000000AF5D
       mov       rcx,rdi
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,r15
       call      00000000000013D0
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AD6C
       jmp       short 000000000000AD81
       mov       rcx,rdi
       mov       rdx,7FF82F4A19D8
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 000000000000AE3A
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AD9E
       jmp       short 000000000000ADB3
       mov       rcx,rdi
       mov       rdx,7FF82F4A19D8
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 000000000000ADC6
       jmp       short 000000000000ADDB
       mov       rcx,rdi
       mov       rdx,7FF82F4A1C78
       call      0000000000002740
       mov       rcx,rax
       call      000000000000B2D0
       mov       r13,rax
       test      r12,r12
       je        near ptr 000000000000B073
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      000000000000AEB0
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AE11
       jmp       short 000000000000AE26
       mov       rcx,rdi
       mov       rdx,7FF82F4A19D8
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      000000000000AEB0
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 000000000000AE45
       jmp       short 000000000000AE5A
       mov       rcx,rdi
       mov       rdx,7FF82F4A1A18
       call      0000000000002740
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      00000000000065E0
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000AE73
       jmp       short 000000000000AE88
       mov       rcx,rdi
       mov       rdx,7FF82F4A1A38
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82EE706C8
       call      qword ptr [6C8]
       test      eax,eax
       je        near ptr 000000000000AF36
       mov       r11,[r14+30]
       test      r11,r11
       je        short 000000000000AEBB
       jmp       short 000000000000AED0
       mov       rcx,rdi
       mov       rdx,7FF82F4A1A68
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 000000000000AEE0
       cmp       esi,0FFFFFFFE
       jne       short 000000000000AEED
       mov       rcx,r15
       mov       rdx,rax
       call      00000000000068B8
       jmp       short 000000000000AF1B
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 000000000000AF10
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000008190
       jmp       short 000000000000AF1B
       mov       rcx,r15
       mov       rdx,rax
       call      0000000000001458
       mov       rcx,rbx
       mov       r11,7FF82EE706C8
       call      qword ptr [6C8]
       test      eax,eax
       jne       near ptr 000000000000AEB0
       mov       rcx,rbx
       mov       r11,7FF82EE706D0
       call      qword ptr [6D0]
       mov       rax,r15
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
       call      0000000000002DE8
       mov       rbx,rax
       mov       rax,2237CE72418
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short 000000000000AF7C
       xor       eax,eax
       jmp       short 000000000000AF81
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000B02E
       call      0000000000002ED0
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82F26A3D0
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82F26A3D0
       call      0000000000000390
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82F26A3D0
       call      0000000000000390
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      0000000000001FF8
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D88
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      00000000000001E8
       mov       rcx,rdi
       call      00000000000055B0
       mov       edx,3
       call      0000000000008468
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D90
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      0000000000005760
       mov       rcx,rdi
       call      00000000000055B0
       call      0000000000007270
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 000000000000B0B4
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82EE706D0
       call      qword ptr [6D0]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1062
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+110]
       test      rcx,rcx
       jne       near ptr 0000000000008CFF
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 0000000000008D7E
       lea       rcx,[rdi+0C]
       mov       rdx,239D0808998
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 0000000000008DA1
       lea       rcx,[rdi+12]
       mov       rdx,239D0802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,rsi
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [9708]
       mov       rdx,rax
       mov       r9,239D080A508
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,239D0802028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull(!!0, !!0, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [3CF0]
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize(System.String)
       call      qword ptr [5828]
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7888]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
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
; Total bytes of code 469
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr 00000000000049F0
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr 00000000000049F0
       lea       rsi,[rdx+r8]
       lea       rdi,[rcx+r8]
       cmp       r8,10
       jbe       short 0000000000004946
       cmp       r8,40
       ja        short 000000000000496E
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short 0000000000004939
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       ja        near ptr 00000000000049D2
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       pop       rsi
       pop       rdi
       ret
       test      r8b,18
       jne       short 00000000000049BF
       test      r8b,4
       jne       short 00000000000049B1
       test      r8,r8
       je        short 0000000000004943
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short 0000000000004943
       movsx     r8,word ptr [rsi+0FFFE]
       mov       [rdi+0FFFE],r8w
       jmp       short 0000000000004943
       cmp       r8,800
       ja        near ptr 00000000000049F9
       mov       rax,r8
       shr       rax,6
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short 0000000000004982
       and       r8,3F
       cmp       r8,10
       ja        near ptr 0000000000004917
       jmp       short 00000000000049E1
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rsi+0FFFC]
       mov       [rdi+0FFFC],edx
       jmp       short 0000000000004943
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rsi+0FFF8]
       mov       [rdi+0FFF8],rdx
       jmp       near ptr 0000000000004943
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
       jmp       near ptr 0000000000004939
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       jmp       near ptr 0000000000004943
       cmp       rcx,rdx
       je        near ptr 0000000000004943
       pop       rsi
       pop       rdi
       jmp       qword ptr [5828]
; Total bytes of code 289
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short 000000000000B4B9
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short 000000000000B4B9
       test      rsi,rsi
       je        near ptr 000000000000B553
       jmp       short 000000000000B4D5
       test      rsi,rsi
       je        short 000000000000B539
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000B539
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000B553
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        short 000000000000B563
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [5810]
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short 000000000000B586
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,239D0802028
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
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
; Total bytes of code 282
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short 000000000000837C
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short 0000000000008393
       jmp       short 000000000000837F
       xor       r9d,r9d
       test      r8,r8
       je        short 0000000000008393
       cmp       dword ptr [r8+8],0
       je        short 0000000000008393
       mov       rcx,r8
       jmp       near ptr 0000000000008439
       test      r9d,r9d
       jne       near ptr 0000000000008439
       call      qword ptr [0BC48]
       mov       rdi,rax
       test      rsi,rsi
       je        short 00000000000083B2
       cmp       dword ptr [rsi+8],0
       je        short 00000000000083B2
       jmp       short 00000000000083B5
       mov       rsi,rdi
       mov       ecx,9
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       test      dl,dl
       jne       short 0000000000008448
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [0D4E0]
; Total bytes of code 268
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr 0000000000009546
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 00000000000095B1
       lea       rcx,[rdi+0C]
       mov       rdx,239D0808998
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 00000000000095D4
       lea       rcx,[rdi+12]
       mov       rdx,239D0802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 0000000000009467
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 000000000000946C
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 0000000000009507
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       [rsp+28],rcx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.GetRuntimeType(!!0 ByRef)
       call      qword ptr [0BEB8]
       mov       rsi,rax
       mov       rcx,239D0808040
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+85],0
       je        short 00000000000095A6
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0D840]
       mov       r8,rax
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteStringUsingSerializer(!!0 ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      qword ptr [1F78]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       call      qword ptr [0DE58]
       jmp       short 0000000000009579
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
; Total bytes of code 568
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,r9
       mov       rdi,[rsp+80]
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       jne       near ptr 00000000000065DC
       test      r8,r8
       je        short 0000000000006554
       mov       rdx,r8
       jmp       near ptr 00000000000065DC
       call      qword ptr [0BB28]
       mov       rbx,rax
       test      rdi,rdi
       je        short 00000000000065CD
       mov       ebp,[rdi+8]
       test      ebp,ebp
       je        short 00000000000065CD
       mov       r14d,ebp
       lea       ecx,[r14+2]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebp
       jl        short 00000000000065EC
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       ecx,[r15+8]
       sub       ecx,r14d
       cmp       ecx,2
       jl        short 000000000000660F
       movsxd    rcx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       rdx,239D0802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,r15
       test      rsi,rsi
       jne       short 0000000000006632
       jmp       short 0000000000006646
       mov       rcx,239D0802090
       mov       rcx,[rcx]
       jmp       short 00000000000065C6
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [5F48]
       mov       rcx,rsi
       call      0000000000006AD0
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [5F48]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       dword ptr [rsi+8],0
       je        short 0000000000006646
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       jmp       short 0000000000006652
       mov       rdx,rbx
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 0000000000006662
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 0000000000006667
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 0000000000006702
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       int       3
; Total bytes of code 546
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        short 000000000000AA5C
       mov       eax,[rdx+8]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      eax,eax
       jne       short 000000000000AA5E
       jmp       short 000000000000AA5E
       xor       ecx,ecx
       test      ecx,ecx
       jne       near ptr 000000000000AB08
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,5E7
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short 000000000000AB30
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short 000000000000AB45
       mov       rcx,rsi
       mov       rdx,7FF82F0BB0F0
       call      0000000000000CA0
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [5888]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 298
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 000000000000735C
       jmp       short 0000000000007371
       mov       rcx,rdi
       mov       rdx,7FF82F193CE0
       call      00000000000087F0
       mov       rcx,rax
       mov       r8,239D0802028
       mov       r8,[r8]
       mov       r9,239D080A228
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7300]
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000003330
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr 00000000000075E3
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [8A70]
       test      eax,eax
       je        near ptr 0000000000007601
       mov       rcx,rdi
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [3900]
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 00000000000073F8
       jmp       short 000000000000740D
       mov       rcx,rdi
       mov       rdx,7FF82F193F38
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 00000000000074C6
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000742A
       jmp       short 000000000000743F
       mov       rcx,rdi
       mov       rdx,7FF82F193F38
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 0000000000007452
       jmp       short 0000000000007467
       mov       rcx,rdi
       mov       rdx,7FF82F1941C8
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EFB0
       mov       r13,rax
       test      r12,r12
       je        near ptr 0000000000007704
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      0000000000000010
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000749D
       jmp       short 00000000000074B2
       mov       rcx,rdi
       mov       rdx,7FF82F193F38
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      0000000000000010
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 00000000000074D1
       jmp       short 00000000000074E6
       mov       rcx,rdi
       mov       rdx,7FF82F193F78
       call      00000000000087F0
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [5BA0]
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 0000000000007500
       jmp       short 0000000000007515
       mov       rcx,rdi
       mov       rdx,7FF82F193F98
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82E990850
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr 00000000000075BF
       mov       r11,[r14+30]
       test      r11,r11
       je        short 0000000000007545
       jmp       short 000000000000755A
       mov       rcx,rdi
       mov       rdx,7FF82F193FC8
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 000000000000756A
       cmp       esi,0FFFFFFFE
       jne       short 0000000000007578
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7810]
       jmp       short 00000000000075A7
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 000000000000759B
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000000020
       jmp       short 00000000000075A7
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [3A98]
       mov       rcx,rbx
       mov       r11,7FF82E990850
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr 000000000000753A
       mov       rcx,rbx
       mov       r11,7FF82E990858
       call      qword ptr [r11]
       mov       rax,r15
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
       mov       ecx,2E7
       mov       rdx,7FF82E984000
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       call      qword ptr [0B990]
       mov       rbx,rax
       mov       rax,239D080A7D8
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 00000000000076BB
       call      qword ptr [0BC48]
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rsi,rax
       mov       ecx,36B
       mov       rdx,7FF82EECB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B888]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [3030]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [5630]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 0000000000007743
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82E990858
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1077
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      000000000000F778
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      00000000000068E0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short 0000000000005F68
       mov       rcx,rdx
       call      000000000000FAB8
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short 0000000000005F45
       jmp       short 0000000000005F5A
       mov       rcx,rsi
       mov       rdx,7FF82F2C1EC8
       call      0000000000004920
       mov       rcx,rax
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr 0000000000000378
       mov       ecx,4D
       mov       rdx,7FF82F25ED50
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,7C7
       mov       rdx,7FF82F25ED50
       call      0000000000000390
       mov       rdi,rax
       call      0000000000002E70
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      0000000000001F28
       mov       rcx,rax
       call      0000000000002F48
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 000000000000ACDC
       jmp       short 000000000000ACF1
       mov       rcx,rdi
       mov       rdx,7FF82F491730
       call      0000000000002740
       mov       rcx,rax
       mov       r8,23FB45A3020
       mov       r8,[r8]
       mov       r9,23FB45AAA58
       mov       r9,[r9]
       mov       rdx,rbx
       call      000000000000DD10
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000004F40
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      0000000000000948
       test      eax,eax
       je        near ptr 000000000000AF5D
       mov       rcx,rdi
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,r15
       call      00000000000013D0
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AD6C
       jmp       short 000000000000AD81
       mov       rcx,rdi
       mov       rdx,7FF82F491988
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 000000000000AE3A
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AD9E
       jmp       short 000000000000ADB3
       mov       rcx,rdi
       mov       rdx,7FF82F491988
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 000000000000ADC6
       jmp       short 000000000000ADDB
       mov       rcx,rdi
       mov       rdx,7FF82F491C28
       call      0000000000002740
       mov       rcx,rax
       call      000000000000B2D0
       mov       r13,rax
       test      r12,r12
       je        near ptr 000000000000B073
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      000000000000AEB0
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000AE11
       jmp       short 000000000000AE26
       mov       rcx,rdi
       mov       rdx,7FF82F491988
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      000000000000AEB0
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 000000000000AE45
       jmp       short 000000000000AE5A
       mov       rcx,rdi
       mov       rdx,7FF82F4919C8
       call      0000000000002740
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      00000000000065E0
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000AE73
       jmp       short 000000000000AE88
       mov       rcx,rdi
       mov       rdx,7FF82F4919E8
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82EE606C8
       call      qword ptr [6C8]
       test      eax,eax
       je        near ptr 000000000000AF36
       mov       r11,[r14+30]
       test      r11,r11
       je        short 000000000000AEBB
       jmp       short 000000000000AED0
       mov       rcx,rdi
       mov       rdx,7FF82F491A18
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 000000000000AEE0
       cmp       esi,0FFFFFFFE
       jne       short 000000000000AEED
       mov       rcx,r15
       mov       rdx,rax
       call      00000000000068B8
       jmp       short 000000000000AF1B
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 000000000000AF10
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000008190
       jmp       short 000000000000AF1B
       mov       rcx,r15
       mov       rdx,rax
       call      0000000000001458
       mov       rcx,rbx
       mov       r11,7FF82EE606C8
       call      qword ptr [6C8]
       test      eax,eax
       jne       near ptr 000000000000AEB0
       mov       rcx,rbx
       mov       r11,7FF82EE606D0
       call      qword ptr [6D0]
       mov       rax,r15
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
       call      0000000000002DE8
       mov       rbx,rax
       mov       rax,23FB45AAFF8
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short 000000000000AF7C
       xor       eax,eax
       jmp       short 000000000000AF81
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000B02E
       call      0000000000002ED0
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82F25A3D0
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82F25A3D0
       call      0000000000000390
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82F25A3D0
       call      0000000000000390
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      0000000000001FF8
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D88
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      00000000000001E8
       mov       rcx,rdi
       call      00000000000055B0
       mov       edx,3
       call      0000000000008468
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D90
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      0000000000005760
       mov       rcx,rdi
       call      00000000000055B0
       call      0000000000007270
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 000000000000B0B4
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82EE606D0
       call      qword ptr [6D0]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1062
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+110]
       test      rcx,rcx
       jne       near ptr 00000000000096DF
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 000000000000975E
       lea       rcx,[rdi+0C]
       mov       rdx,207B38005B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 0000000000009781
       lea       rcx,[rdi+12]
       mov       rdx,207B1800098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,rsi
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [9708]
       mov       rdx,rax
       mov       r9,207B3802128
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,207B1800030
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull(!!0, !!0, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [3CF0]
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize(System.String)
       call      qword ptr [5828]
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [7888]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
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
; Total bytes of code 469
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr 0000000000005E30
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr 0000000000005E30
       lea       rsi,[rdx+r8]
       lea       rdi,[rcx+r8]
       cmp       r8,10
       jbe       short 0000000000005D86
       cmp       r8,40
       ja        short 0000000000005DAE
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short 0000000000005D79
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       ja        near ptr 0000000000005E12
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       pop       rsi
       pop       rdi
       ret
       test      r8b,18
       jne       short 0000000000005DFF
       test      r8b,4
       jne       short 0000000000005DF1
       test      r8,r8
       je        short 0000000000005D83
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short 0000000000005D83
       movsx     r8,word ptr [rsi+0FFFE]
       mov       [rdi+0FFFE],r8w
       jmp       short 0000000000005D83
       cmp       r8,800
       ja        near ptr 0000000000005E39
       mov       rax,r8
       shr       rax,6
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short 0000000000005DC2
       and       r8,3F
       cmp       r8,10
       ja        near ptr 0000000000005D57
       jmp       short 0000000000005E21
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rsi+0FFFC]
       mov       [rdi+0FFFC],edx
       jmp       short 0000000000005D83
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rsi+0FFF8]
       mov       [rdi+0FFF8],rdx
       jmp       near ptr 0000000000005D83
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
       jmp       near ptr 0000000000005D79
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       jmp       near ptr 0000000000005D83
       cmp       rcx,rdx
       je        near ptr 0000000000005D83
       pop       rsi
       pop       rdi
       jmp       qword ptr [5828]
; Total bytes of code 289
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short 000000000000BA39
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short 000000000000BA39
       test      rsi,rsi
       je        near ptr 000000000000BAD3
       jmp       short 000000000000BA55
       test      rsi,rsi
       je        short 000000000000BAB9
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000BAB9
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000BAD3
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        short 000000000000BAE3
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [5810]
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short 000000000000BB06
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,207B1800030
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
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
; Total bytes of code 282
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short 000000000000879C
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short 00000000000087B3
       jmp       short 000000000000879F
       xor       r9d,r9d
       test      r8,r8
       je        short 00000000000087B3
       cmp       dword ptr [r8+8],0
       je        short 00000000000087B3
       mov       rcx,r8
       jmp       near ptr 0000000000008859
       test      r9d,r9d
       jne       near ptr 0000000000008859
       call      qword ptr [0BC48]
       mov       rdi,rax
       test      rsi,rsi
       je        short 00000000000087D2
       cmp       dword ptr [rsi+8],0
       je        short 00000000000087D2
       jmp       short 00000000000087D5
       mov       rsi,rdi
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       test      dl,dl
       jne       short 0000000000008868
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [0D4E0]
; Total bytes of code 268
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr 0000000000009F26
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 0000000000009F91
       lea       rcx,[rdi+0C]
       mov       rdx,207B38005B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 0000000000009FB4
       lea       rcx,[rdi+12]
       mov       rdx,207B1800098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 0000000000009E47
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 0000000000009E4C
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 0000000000009EE7
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       [rsp+28],rcx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.GetRuntimeType(!!0 ByRef)
       call      qword ptr [0BEB8]
       mov       rsi,rax
       mov       rcx,207AF805C30
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+85],0
       je        short 0000000000009F86
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0D840]
       mov       r8,rax
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteStringUsingSerializer(!!0 ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      qword ptr [1F78]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       call      qword ptr [0DE58]
       jmp       short 0000000000009F59
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
; Total bytes of code 568
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,r9
       mov       rdi,[rsp+80]
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       jne       near ptr 00000000000067DC
       test      r8,r8
       je        short 0000000000006754
       mov       rdx,r8
       jmp       near ptr 00000000000067DC
       call      qword ptr [0BB28]
       mov       rbx,rax
       test      rdi,rdi
       je        short 00000000000067CD
       mov       ebp,[rdi+8]
       test      ebp,ebp
       je        short 00000000000067CD
       mov       r14d,ebp
       lea       ecx,[r14+2]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebp
       jl        short 00000000000067EC
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       ecx,[r15+8]
       sub       ecx,r14d
       cmp       ecx,2
       jl        short 000000000000680F
       movsxd    rcx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       rdx,207B1800098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,r15
       test      rsi,rsi
       jne       short 0000000000006832
       jmp       short 0000000000006846
       mov       rcx,207B1800098
       mov       rcx,[rcx]
       jmp       short 00000000000067C6
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [5F48]
       mov       rcx,rsi
       call      0000000000006AD0
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [5F48]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       dword ptr [rsi+8],0
       je        short 0000000000006846
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       jmp       short 0000000000006852
       mov       rdx,rbx
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 0000000000006862
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 0000000000006867
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 0000000000006902
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       int       3
; Total bytes of code 546
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        short 000000000000B33C
       mov       eax,[rdx+8]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      eax,eax
       jne       short 000000000000B33E
       jmp       short 000000000000B33E
       xor       ecx,ecx
       test      ecx,ecx
       jne       near ptr 000000000000B3E8
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,5E7
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short 000000000000B410
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short 000000000000B425
       mov       rcx,rsi
       mov       rdx,7FF82F0AB110
       call      0000000000000CA0
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [5888]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 298
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 00000000000075DC
       jmp       short 00000000000075F1
       mov       rcx,rdi
       mov       rdx,7FF82F183D68
       call      00000000000087F0
       mov       rcx,rax
       mov       r8,207B1800030
       mov       r8,[r8]
       mov       r9,207B3801E48
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [7300]
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000003330
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr 0000000000007863
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [8A70]
       test      eax,eax
       je        near ptr 0000000000007881
       mov       rcx,rdi
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [3900]
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 0000000000007678
       jmp       short 000000000000768D
       mov       rcx,rdi
       mov       rdx,7FF82F183FC0
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 0000000000007746
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 00000000000076AA
       jmp       short 00000000000076BF
       mov       rcx,rdi
       mov       rdx,7FF82F183FC0
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 00000000000076D2
       jmp       short 00000000000076E7
       mov       rcx,rdi
       mov       rdx,7FF82F184250
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EFB0
       mov       r13,rax
       test      r12,r12
       je        near ptr 0000000000007984
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      0000000000000010
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000771D
       jmp       short 0000000000007732
       mov       rcx,rdi
       mov       rdx,7FF82F183FC0
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      0000000000000010
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 0000000000007751
       jmp       short 0000000000007766
       mov       rcx,rdi
       mov       rdx,7FF82F184000
       call      00000000000087F0
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [5BA0]
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 0000000000007780
       jmp       short 0000000000007795
       mov       rcx,rdi
       mov       rdx,7FF82F184020
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82E980860
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr 000000000000783F
       mov       r11,[r14+30]
       test      r11,r11
       je        short 00000000000077C5
       jmp       short 00000000000077DA
       mov       rcx,rdi
       mov       rdx,7FF82F184050
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 00000000000077EA
       cmp       esi,0FFFFFFFE
       jne       short 00000000000077F8
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7810]
       jmp       short 0000000000007827
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 000000000000781B
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000000020
       jmp       short 0000000000007827
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [3A98]
       mov       rcx,rbx
       mov       r11,7FF82E980860
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr 00000000000077BA
       mov       rcx,rbx
       mov       r11,7FF82E980868
       call      qword ptr [r11]
       mov       rax,r15
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
       mov       ecx,2E7
       mov       rdx,7FF82E974000
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       call      qword ptr [0B990]
       mov       rbx,rax
       mov       rax,207B38023F8
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000793B
       call      qword ptr [0BC48]
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rsi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B888]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [3030]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [5630]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 00000000000079C3
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82E980868
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1077
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      000000000000F778
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      0000000000000D20
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short 00000000000085D8
       mov       rcx,rdx
       call      000000000000FAB8
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short 00000000000085B5
       jmp       short 00000000000085CA
       mov       rcx,rsi
       mov       rdx,7FF82F2E1EC8
       call      0000000000004920
       mov       rcx,rax
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr 0000000000000378
       mov       ecx,4D
       mov       rdx,7FF82F27ED50
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,7C7
       mov       rdx,7FF82F27ED50
       call      0000000000000390
       mov       rdi,rax
       call      0000000000002E70
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      0000000000001F28
       mov       rcx,rax
       call      0000000000002F48
       int       3
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 000000000000511C
       jmp       short 0000000000005131
       mov       rcx,rdi
       mov       rdx,7FF82F4C1730
       call      0000000000002740
       mov       rcx,rax
       mov       r8,258EB6D3020
       mov       r8,[r8]
       mov       r9,258DB6D1660
       mov       r9,[r9]
       mov       rdx,rbx
       call      0000000000002C30
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000004F40
       mov       rcx,rax
       mov       [r15+8],esi
       mov       rdx,r15
       call      0000000000000948
       test      eax,eax
       je        near ptr 000000000000539D
       mov       rcx,rdi
       call      000000000000B2D0
       mov       r15,rax
       mov       rcx,r15
       call      00000000000013D0
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 00000000000051AC
       jmp       short 00000000000051C1
       mov       rcx,rdi
       mov       rdx,7FF82F4C1988
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 000000000000527A
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 00000000000051DE
       jmp       short 00000000000051F3
       mov       rcx,rdi
       mov       rdx,7FF82F4C1988
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 0000000000005206
       jmp       short 000000000000521B
       mov       rcx,rdi
       mov       rdx,7FF82F4C1C28
       call      0000000000002740
       mov       rcx,rax
       call      000000000000B2D0
       mov       r13,rax
       test      r12,r12
       je        near ptr 00000000000054B3
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      000000000000AEB0
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 0000000000005251
       jmp       short 0000000000005266
       mov       rcx,rdi
       mov       rdx,7FF82F4C1988
       call      0000000000002740
       mov       rcx,rax
       call      0000000000006100
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      000000000000AEB0
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 0000000000005285
       jmp       short 000000000000529A
       mov       rcx,rdi
       mov       rdx,7FF82F4C19C8
       call      0000000000002740
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      00000000000065E0
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 00000000000052B3
       jmp       short 00000000000052C8
       mov       rcx,rdi
       mov       rdx,7FF82F4C19E8
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82EE806C8
       call      qword ptr [6C8]
       test      eax,eax
       je        near ptr 0000000000005376
       mov       r11,[r14+30]
       test      r11,r11
       je        short 00000000000052FB
       jmp       short 0000000000005310
       mov       rcx,rdi
       mov       rdx,7FF82F4C1A18
       call      0000000000002740
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 0000000000005320
       cmp       esi,0FFFFFFFE
       jne       short 000000000000532D
       mov       rcx,r15
       mov       rdx,rax
       call      0000000000000CF8
       jmp       short 000000000000535B
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 0000000000005350
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000008190
       jmp       short 000000000000535B
       mov       rcx,r15
       mov       rdx,rax
       call      0000000000001458
       mov       rcx,rbx
       mov       r11,7FF82EE806C8
       call      qword ptr [6C8]
       test      eax,eax
       jne       near ptr 00000000000052F0
       mov       rcx,rbx
       mov       r11,7FF82EE806D0
       call      qword ptr [6D0]
       mov       rax,r15
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
       call      0000000000002DE8
       mov       rbx,rax
       mov       rax,258DB6D1C00
       mov       rcx,[rax]
       cmp       dword ptr [rcx+8],0
       je        short 00000000000053BC
       xor       eax,eax
       jmp       short 00000000000053C1
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000546E
       call      0000000000002ED0
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82F27A3D0
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82F27A3D0
       call      0000000000000390
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82F27A3D0
       call      0000000000000390
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      0000000000001FF8
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D88
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      00000000000001E8
       mov       rcx,rdi
       call      00000000000055B0
       mov       edx,3
       call      0000000000008468
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000B2D0
       mov       rdi,rax
       call      0000000000002D90
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000002F20
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      0000000000005760
       mov       rcx,rdi
       call      00000000000055B0
       call      0000000000007270
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 00000000000054F4
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82EE806D0
       call      qword ptr [6D0]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1062
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.CollectionCollectionBenchmark.CollectionCreate02()
; 			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+110]
       test      rcx,rcx
       jne       near ptr 000000000000DB7F
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 000000000000DBFE
       lea       rcx,[rdi+0C]
       mov       rdx,17E934069A0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 000000000000DC21
       lea       rcx,[rdi+12]
       mov       rdx,17E93402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,rsi
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [9708]
       mov       rdx,rax
       mov       r9,17E93408510
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,17E93402028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull(!!0, !!0, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [3CF0]
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize(System.String)
       call      qword ptr [57E0]
       mov       rdx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       mov       r8d,0FFFFFFFF
       call      qword ptr [0FB88]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
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
; Total bytes of code 469
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr 000000000000DC50
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr 000000000000DC50
       lea       rsi,[rdx+r8]
       lea       rdi,[rcx+r8]
       cmp       r8,10
       jbe       short 000000000000DBA6
       cmp       r8,40
       ja        short 000000000000DBCE
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short 000000000000DB99
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       ja        near ptr 000000000000DC32
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       pop       rsi
       pop       rdi
       ret
       test      r8b,18
       jne       short 000000000000DC1F
       test      r8b,4
       jne       short 000000000000DC11
       test      r8,r8
       je        short 000000000000DBA3
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short 000000000000DBA3
       movsx     r8,word ptr [rsi+0FFFE]
       mov       [rdi+0FFFE],r8w
       jmp       short 000000000000DBA3
       cmp       r8,800
       ja        near ptr 000000000000DC59
       mov       rax,r8
       shr       rax,6
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short 000000000000DBE2
       and       r8,3F
       cmp       r8,10
       ja        near ptr 000000000000DB77
       jmp       short 000000000000DC41
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rsi+0FFFC]
       mov       [rdi+0FFFC],edx
       jmp       short 000000000000DBA3
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rsi+0FFF8]
       mov       [rdi+0FFF8],rdx
       jmp       near ptr 000000000000DBA3
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
       jmp       near ptr 000000000000DB99
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       jmp       near ptr 000000000000DBA3
       cmp       rcx,rdx
       je        near ptr 000000000000DBA3
       pop       rsi
       pop       rdi
       jmp       qword ptr [5828]
; Total bytes of code 289
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short 000000000000EA39
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short 000000000000EA39
       test      rsi,rsi
       je        near ptr 000000000000EAD3
       jmp       short 000000000000EA55
       test      rsi,rsi
       je        short 000000000000EAB9
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000EAB9
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000EAD3
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        short 000000000000EAE3
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [5810]
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short 000000000000EB06
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,17E93402028
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
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
; Total bytes of code 282
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,r9
       test      rcx,rcx
       je        short 000000000000F21C
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short 000000000000F233
       jmp       short 000000000000F21F
       xor       r9d,r9d
       test      r8,r8
       je        short 000000000000F233
       cmp       dword ptr [r8+8],0
       je        short 000000000000F233
       mov       rcx,r8
       jmp       near ptr 000000000000F2D9
       test      r9d,r9d
       jne       near ptr 000000000000F2D9
       call      qword ptr [0BC48]
       mov       rdi,rax
       test      rsi,rsi
       je        short 000000000000F252
       cmp       dword ptr [rsi+8],0
       je        short 000000000000F252
       jmp       short 000000000000F255
       mov       rsi,rdi
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       test      dl,dl
       jne       short 000000000000F2E8
       mov       rax,rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       cmp       [rcx],cl
       mov       edx,3
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [0D4E0]
; Total bytes of code 268
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr 000000000000B596
       call      qword ptr [0BB28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 000000000000B601
       lea       rcx,[rdi+0C]
       mov       rdx,17E934069A0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 000000000000B624
       lea       rcx,[rdi+12]
       mov       rdx,17E93402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000B4B7
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 000000000000B4BC
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000B557
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       [rsp+28],rcx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.GetRuntimeType(!!0 ByRef)
       call      qword ptr [0BEB8]
       mov       rsi,rax
       mov       rcx,17E93406048
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+85],0
       je        short 000000000000B5F6
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0D840]
       mov       r8,rax
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteStringUsingSerializer(!!0 ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      qword ptr [1F78]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       call      qword ptr [0DE58]
       jmp       short 000000000000B5C9
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
; Total bytes of code 568
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,r9
       mov       rdi,[rsp+80]
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       jne       near ptr 0000000000002D7C
       test      r8,r8
       je        short 0000000000002CF4
       mov       rdx,r8
       jmp       near ptr 0000000000002D7C
       call      qword ptr [0BB28]
       mov       rbx,rax
       test      rdi,rdi
       je        short 0000000000002D6D
       mov       ebp,[rdi+8]
       test      ebp,ebp
       je        short 0000000000002D6D
       mov       r14d,ebp
       lea       ecx,[r14+2]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebp
       jl        short 0000000000002D8C
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       ecx,[r15+8]
       sub       ecx,r14d
       cmp       ecx,2
       jl        short 0000000000002DAF
       movsxd    rcx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       rdx,17E93402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,r15
       test      rsi,rsi
       jne       short 0000000000002DD2
       jmp       short 0000000000002DE6
       mov       rcx,17E93402090
       mov       rcx,[rcx]
       jmp       short 0000000000002D66
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [5F48]
       mov       rcx,rsi
       call      0000000000006AD0
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [5F48]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       dword ptr [rsi+8],0
       je        short 0000000000002DE6
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       jmp       short 0000000000002DF2
       mov       rdx,rbx
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 0000000000002E02
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 0000000000002E07
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 0000000000002EA2
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
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
       call      qword ptr [0B870]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       int       3
; Total bytes of code 546
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        short 000000000000C57C
       mov       eax,[rdx+8]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      eax,eax
       jne       short 000000000000C57E
       jmp       short 000000000000C57E
       xor       ecx,ecx
       test      ecx,ecx
       jne       near ptr 000000000000C628
       call      qword ptr [0BC48]
       mov       rsi,rax
       mov       ecx,5E7
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rbx,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [0FB28]
       mov       rcx,rbx
       call      0000000000006AD0
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short 000000000000C650
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short 000000000000C665
       mov       rcx,rsi
       mov       rdx,7FF82F0AB120
       call      0000000000000CA0
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [5840]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 298
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
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
       mov       [rbp+0FFA8],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rcx,[rdi+30]
       mov       r14,[rcx+8]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short 000000000000ECFC
       jmp       short 000000000000ED11
       mov       rcx,rdi
       mov       rdx,7FF82F1E3768
       call      00000000000087F0
       mov       rcx,rax
       mov       r8,17E93402028
       mov       r8,[r8]
       mov       r9,17E93408230
       mov       r9,[r9]
       mov       rdx,rbx
       call      qword ptr [0FC00]
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Tristate
       call      0000000000003330
       mov       [r15+8],esi
       test      rax,rax
       je        near ptr 000000000000EF83
       mov       rdx,r15
       mov       rcx,rax
       call      qword ptr [8A70]
       test      eax,eax
       je        near ptr 000000000000EFA1
       mov       rcx,rdi
       call      000000000000EFB0
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [3900]
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000ED98
       jmp       short 000000000000EDAD
       mov       rcx,rdi
       mov       rdx,7FF82F1E39C0
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr 000000000000EE66
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000EDCA
       jmp       short 000000000000EDDF
       mov       rcx,rdi
       mov       rdx,7FF82F1E39C0
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       mov       r12,[rax]
       mov       rcx,[r14+38]
       test      rcx,rcx
       je        short 000000000000EDF2
       jmp       short 000000000000EE07
       mov       rcx,rdi
       mov       rdx,7FF82F1E3C50
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EFB0
       mov       r13,rax
       test      r12,r12
       je        near ptr 000000000000F0A4
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      0000000000000010
       mov       rcx,offset DotNetTips.Spargine.Core.Collections.Generic.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__8_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short 000000000000EE3D
       jmp       short 000000000000EE52
       mov       rcx,rdi
       mov       rdx,7FF82F1E39C0
       call      00000000000087F0
       mov       rcx,rax
       call      000000000000EDE0
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      0000000000000010
       mov       r12,r13
       mov       rcx,[r14+20]
       test      rcx,rcx
       je        short 000000000000EE71
       jmp       short 000000000000EE86
       mov       rcx,rdi
       mov       rdx,7FF82F1E3A00
       call      00000000000087F0
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8,r12
       call      qword ptr [5BA0]
       mov       rbx,rax
       mov       r11,[r14+28]
       test      r11,r11
       je        short 000000000000EEA0
       jmp       short 000000000000EEB5
       mov       rcx,rdi
       mov       rdx,7FF82F1E3A20
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp+0FFB8],rbx
       mov       rcx,rbx
       mov       r11,7FF82E9809C8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr 000000000000EF5F
       mov       r11,[r14+30]
       test      r11,r11
       je        short 000000000000EEE5
       jmp       short 000000000000EEFA
       mov       rcx,rdi
       mov       rdx,7FF82F1E3A50
       call      00000000000087F0
       mov       r11,rax
       mov       rcx,rbx
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short 000000000000EF0A
       cmp       esi,0FFFFFFFE
       jne       short 000000000000EF18
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [0FB10]
       jmp       short 000000000000EF47
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short 000000000000EF3B
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rax
       call      0000000000000020
       jmp       short 000000000000EF47
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [3A98]
       mov       rcx,rbx
       mov       r11,7FF82E9809C8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr 000000000000EEDA
       mov       rcx,rbx
       mov       r11,7FF82E9809D0
       call      qword ptr [r11]
       mov       rax,r15
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
       mov       ecx,2E7
       mov       rdx,7FF82E974000
       call      000000000000F510
       mov       rcx,rax
       call      qword ptr [0FBA0]
       int       3
       call      qword ptr [0B990]
       mov       rbx,rax
       mov       rax,17E934087E8
       mov       rcx,[rax]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000F05B
       call      qword ptr [0BC48]
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rsi,rax
       mov       ecx,36B
       mov       rdx,7FF82EEBB998
       call      000000000000F510
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5C60]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B870]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [0B888]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0BD08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [3030]
       mov       rcx,rdi
       call      0000000000006AD0
       call      qword ptr [5630]
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB8],0
       je        short 000000000000F0E3
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FF82E9809D0
       call      qword ptr [r11]
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1077
```
**Extern method**
System.String.FastAllocateString(Int32)

