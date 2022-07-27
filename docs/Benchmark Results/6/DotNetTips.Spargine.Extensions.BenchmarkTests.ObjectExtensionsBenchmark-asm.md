## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.As()
; 			var result = this._personProper.As<IPerson>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0C0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.As(System.Object)
       call      000000000000B558
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.As[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       test      rdx,rdx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        short 000000000000F91C
       mov       rcx,[rcx+10]
       mov       rcx,[rcx]
       call      0000000000007450
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
       mov       ecx,4D
       mov       rdx,7FF82F336048
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,7C7
       mov       rdx,7FF82F336048
       call      0000000000000390
       mov       rdi,rax
       call      0000000000001940
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      00000000000009F8
       mov       rcx,rax
       call      0000000000001A18
       int       3
; Total bytes of code 118
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.As()
; 			var result = this._personProper.As<IPerson>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+0C0]
       test      rdx,rdx
       jne       near ptr 00000000000071A0
       call      qword ptr [9B28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 00000000000071C8
       lea       rcx,[rdi+0C]
       mov       rdx,2E217804988
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 00000000000071EB
       lea       rcx,[rdi+12]
       mov       rdx,2E217802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       call      qword ptr [9D80]
       int       3
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.IPerson
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
; Total bytes of code 271
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr 0000000000007810
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr 0000000000007810
       lea       rsi,[rdx+r8]
       lea       rdi,[rcx+r8]
       cmp       r8,10
       jbe       short 0000000000007766
       cmp       r8,40
       ja        short 000000000000778E
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short 0000000000007759
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       ja        near ptr 00000000000077F2
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       pop       rsi
       pop       rdi
       ret
       test      r8b,18
       jne       short 00000000000077DF
       test      r8b,4
       jne       short 00000000000077D1
       test      r8,r8
       je        short 0000000000007763
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short 0000000000007763
       movsx     r8,word ptr [rsi+0FFFE]
       mov       [rdi+0FFFE],r8w
       jmp       short 0000000000007763
       cmp       r8,800
       ja        near ptr 0000000000007819
       mov       rax,r8
       shr       rax,6
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short 00000000000077A2
       and       r8,3F
       cmp       r8,10
       ja        near ptr 0000000000007737
       jmp       short 0000000000007801
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rsi+0FFFC]
       mov       [rdi+0FFFC],edx
       jmp       short 0000000000007763
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rsi+0FFF8]
       mov       [rdi+0FFF8],rdx
       jmp       near ptr 0000000000007763
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
       jmp       near ptr 0000000000007759
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       jmp       near ptr 0000000000007763
       cmp       rcx,rdx
       je        near ptr 0000000000007763
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
       je        short 00000000000067D9
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short 00000000000067D9
       test      rsi,rsi
       je        near ptr 0000000000006873
       jmp       short 00000000000067F5
       test      rsi,rsi
       je        short 0000000000006859
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 0000000000006859
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
       je        short 0000000000006873
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        short 0000000000006883
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [5810]
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short 00000000000068A6
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
       mov       rax,2E217802028
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
; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       test      rdx,rdx
       jne       short 0000000000007689
       mov       rax,rdx
       ret
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short 00000000000076DB
       mov       rax,[rax+38]
       cmp       r8,4
       jl        short 00000000000076CA
       cmp       [rax],rcx
       je        short 0000000000007685
       cmp       [rax+8],rcx
       je        short 0000000000007685
       cmp       [rax+10],rcx
       je        short 0000000000007685
       cmp       [rax+18],rcx
       je        short 0000000000007685
       add       rax,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short 00000000000076A0
       test      r8,r8
       je        short 00000000000076DB
       cmp       [rax],rcx
       je        short 0000000000007685
       add       rax,8
       dec       r8
       test      r8,r8
       jg        short 00000000000076CA
       jmp       qword ptr [5870]
; Total bytes of code 97
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.Clone01()
; 			var result = this._personProper.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0C0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      000000000000B560
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
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
       je        short 000000000000B5C8
       mov       rcx,rdx
       call      000000000000E9F0
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short 000000000000B5A5
       jmp       short 000000000000B5BA
       mov       rcx,rsi
       mov       rdx,7FF82F46A630
       call      0000000000004920
       mov       rcx,rax
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr 000000000000B5A0
       mov       ecx,4D
       mov       rdx,7FF82F316048
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,7C7
       mov       rdx,7FF82F316048
       call      0000000000000390
       mov       rdi,rax
       call      0000000000001940
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      00000000000009F8
       mov       rcx,rax
       call      0000000000001A18
       int       3
; Total bytes of code 162
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.Clone01()
; 			var result = this._personProper.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+0C0]
       test      rcx,rcx
       jne       near ptr 000000000000A5EF
       call      qword ptr [9B28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 000000000000A655
       lea       rcx,[rdi+0C]
       mov       rdx,19339411CD0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 000000000000A678
       lea       rcx,[rdi+12]
       mov       rdx,19339402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EF60000
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EF60000
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,rsi
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5270]
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
       call      qword ptr [17C8]
       mov       rdx,rax
       mov       r9,19339412A18
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,19339402028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull(!!0, !!0, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [1CF0]
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize(System.String)
       call      qword ptr [7D20]
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
; Total bytes of code 444
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr 00000000000086F0
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr 00000000000086F0
       lea       rsi,[rdx+r8]
       lea       rdi,[rcx+r8]
       cmp       r8,10
       jbe       short 0000000000008646
       cmp       r8,40
       ja        short 000000000000866E
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short 0000000000008639
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       ja        near ptr 00000000000086D2
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       pop       rsi
       pop       rdi
       ret
       test      r8b,18
       jne       short 00000000000086BF
       test      r8b,4
       jne       short 00000000000086B1
       test      r8,r8
       je        short 0000000000008643
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short 0000000000008643
       movsx     r8,word ptr [rsi+0FFFE]
       mov       [rdi+0FFFE],r8w
       jmp       short 0000000000008643
       cmp       r8,800
       ja        near ptr 00000000000086F9
       mov       rax,r8
       shr       rax,6
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short 0000000000008682
       and       r8,3F
       cmp       r8,10
       ja        near ptr 0000000000008617
       jmp       short 00000000000086E1
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rsi+0FFFC]
       mov       [rdi+0FFFC],edx
       jmp       short 0000000000008643
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rsi+0FFF8]
       mov       [rdi+0FFF8],rdx
       jmp       near ptr 0000000000008643
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
       jmp       near ptr 0000000000008639
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       jmp       near ptr 0000000000008643
       cmp       rcx,rdx
       je        near ptr 0000000000008643
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
       je        short 000000000000A909
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short 000000000000A909
       test      rsi,rsi
       je        near ptr 000000000000A9A3
       jmp       short 000000000000A925
       test      rsi,rsi
       je        short 000000000000A989
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 000000000000A989
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
       je        short 000000000000A9A3
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        short 000000000000A9B3
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [5810]
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short 000000000000A9D6
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
       mov       rax,19339402028
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
       je        short 000000000000D2EC
       mov       eax,[rcx+8]
       xor       r9d,r9d
       test      eax,eax
       sete      r9b
       test      r9d,r9d
       sete      r9b
       movzx     r9d,r9b
       test      eax,eax
       jne       short 000000000000D303
       jmp       short 000000000000D2EF
       xor       r9d,r9d
       test      r8,r8
       je        short 000000000000D303
       cmp       dword ptr [r8+8],0
       je        short 000000000000D303
       mov       rcx,r8
       jmp       near ptr 000000000000D3A9
       test      r9d,r9d
       jne       near ptr 000000000000D3A9
       call      qword ptr [9C48]
       mov       rdi,rax
       test      rsi,rsi
       je        short 000000000000D322
       cmp       dword ptr [rsi+8],0
       je        short 000000000000D322
       jmp       short 000000000000D325
       mov       rsi,rdi
       mov       ecx,9
       mov       rdx,7FF82EF60000
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EF60000
       call      000000000000F510
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       rcx,[rsp+70]
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
       test      dl,dl
       jne       short 000000000000D3B8
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
       jne       near ptr 000000000000AA76
       call      qword ptr [9B28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 000000000000AAE1
       lea       rcx,[rdi+0C]
       mov       rdx,19339411CD0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 000000000000AB04
       lea       rcx,[rdi+12]
       mov       rdx,19339402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000A997
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 000000000000A99C
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000AA37
       call      qword ptr [9C48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EF60000
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EF60000
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
       mov       [rsp+28],rcx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.GetRuntimeType(!!0 ByRef)
       call      qword ptr [5B70]
       mov       rsi,rax
       mov       rcx,1933940C990
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+85],0
       je        short 000000000000AAD6
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7708]
       mov       r8,rax
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteStringUsingSerializer(!!0 ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      qword ptr [0BF48]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       call      qword ptr [7D20]
       jmp       short 000000000000AAA9
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
       jne       near ptr 000000000000F5FC
       test      r8,r8
       je        short 000000000000F574
       mov       rdx,r8
       jmp       near ptr 000000000000F5FC
       call      qword ptr [9B28]
       mov       rbx,rax
       test      rdi,rdi
       je        short 000000000000F5ED
       mov       ebp,[rdi+8]
       test      ebp,ebp
       je        short 000000000000F5ED
       mov       r14d,ebp
       lea       ecx,[r14+2]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebp
       jl        short 000000000000F60C
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [5810]
       mov       ecx,[r15+8]
       sub       ecx,r14d
       cmp       ecx,2
       jl        short 000000000000F62F
       movsxd    rcx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       rdx,19339402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,r15
       test      rsi,rsi
       jne       short 000000000000F652
       jmp       short 000000000000F666
       mov       rcx,19339402090
       mov       rcx,[rcx]
       jmp       short 000000000000F5E6
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
       je        short 000000000000F666
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       jmp       short 000000000000F672
       mov       rdx,rbx
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000F682
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 000000000000F687
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000F722
       call      qword ptr [9C48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EF60000
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EF60000
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
       je        short 000000000000487C
       mov       eax,[rdx+8]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      eax,eax
       jne       short 000000000000487E
       jmp       short 000000000000487E
       xor       ecx,ecx
       test      ecx,ecx
       jne       near ptr 0000000000004928
       call      qword ptr [9C48]
       mov       rsi,rax
       mov       ecx,5E7
       mov       rdx,7FF82EF60000
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF82EF60000
       call      000000000000F510
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82EF60000
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
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short 0000000000004950
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short 0000000000004965
       mov       rcx,rsi
       mov       rdx,7FF82F17E3A0
       call      0000000000000CA0
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7D80]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 298
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.Clone03()
; 			var result = this._personRecord with { };
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       mov       rdi,[rsi+0C8]
       cmp       [rdi],edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      000000000000B2D0
       mov       rbx,rax
       vmovupd   xmm0,[rdi+40]
       vmovupd   [rbx+40],xmm0
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      000000000000AEB0
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      000000000000AEB0
       mov       rdx,[rdi+18]
       lea       rcx,[rbx+18]
       call      000000000000AEB0
       mov       rdx,[rdi+20]
       lea       rcx,[rbx+20]
       call      000000000000AEB0
       mov       rdx,[rdi+28]
       lea       rcx,[rbx+28]
       call      000000000000AEB0
       mov       rdx,[rdi+30]
       lea       rcx,[rbx+30]
       call      000000000000AEB0
       mov       rdx,[rdi+38]
       lea       rcx,[rbx+38]
       call      000000000000AEB0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rbx
       call      000000000000B010
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 168
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.Clone03()
; 			var result = this._personRecord with { };
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       mov       rdi,[rsi+0C8]
       cmp       [rdi],dil
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      000000000000EFB0
       mov       rbx,rax
       vmovupd   xmm0,[rdi+40]
       vmovupd   [rbx+40],xmm0
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      0000000000000010
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      0000000000000010
       mov       rdx,[rdi+18]
       lea       rcx,[rbx+18]
       call      0000000000000010
       mov       rdx,[rdi+20]
       lea       rcx,[rbx+20]
       call      0000000000000010
       mov       rdx,[rdi+28]
       lea       rcx,[rbx+28]
       call      0000000000000010
       mov       rdx,[rdi+30]
       lea       rcx,[rbx+30]
       call      0000000000000010
       mov       rdx,[rdi+38]
       lea       rcx,[rbx+38]
       call      0000000000000010
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rbx
       call      0000000000000010
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 167
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash01()
; 			var result = this._personProper.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0C0]
       call      000000000000E9A0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 45
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       rsi,rcx
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000C456
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rdi
       call      000000000000B6E0
       mov       [rbp+0FFC0],rdi
       mov       rcx,2B3D08E1BA8
       mov       rbx,[rcx]
       mov       rcx,rsi
       call      000000000000E9F0
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0FC48]
       mov       rdx,rax
       mov       rcx,rdi
       call      000000000000B5E8
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      000000000000B2D0
       mov       rbx,rax
       mov       dword ptr [rbx+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      000000000000B400
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      000000000000AEB0
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short 000000000000C425
       mov       rdx,2B3D08E1568
       mov       r12,[rdx]
       mov       rdx,2B3E08E1AC0
       mov       r13,[rdx]
       movsxd    rdx,r14d
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      00000000000010B0
       mov       rdx,rax
       mov       rcx,rbx
       call      000000000000CD10
       add       r14d,1
       jo        short 000000000000C433
       cmp       r15d,r14d
       jg        short 000000000000C3F9
       mov       rcx,rbx
       call      qword ptr [0A3E0]
       mov       r14,rax
       jmp       short 000000000000C439
       call      000000000000ECD0
       int       3
       mov       rcx,rdi
       call      qword ptr [85F0]
       mov       rax,r14
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
       mov       ecx,4D
       mov       rdx,7FF82F336048
       call      0000000000000390
       mov       rdi,rax
       mov       ecx,7C7
       mov       rdx,7FF82F336048
       call      0000000000000390
       mov       rsi,rax
       call      0000000000001940
       mov       r8,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      00000000000009F8
       mov       rcx,rax
       call      0000000000001A18
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
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short 000000000000C4CE
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [85F0]
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
; Total bytes of code 448
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash01()
; 			var result = this._personProper.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0C0]
       call      qword ptr [16D8]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC8],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       near ptr 00000000000026CE
       call      qword ptr [9B28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 00000000000027DB
       lea       rcx,[rdi+0C]
       mov       rdx,26036C00580
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 00000000000027FE
       lea       rcx,[rdi+12]
       mov       rdx,2603AC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 00000000000025EF
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 00000000000025F4
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000268F
       call      qword ptr [9C48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EF80000
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EF80000
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
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7C30]
       mov       [rbp+0FFD8],rdi
       mov       rcx,2603AC00BC8
       mov       rbx,[rcx]
       mov       rcx,rsi
       call      qword ptr [17C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [4010]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7918]
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      000000000000EFB0
       mov       rbx,rax
       mov       dword ptr [rbx+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      000000000000F0D0
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      0000000000000010
       xor       r14d,r14d
       cmp       dword ptr [rsi+8],0
       jle       short 00000000000027B0
       mov       edx,r14d
       lea       rdx,[rsi+rdx+10]
       mov       rcx,2603AC00558
       mov       r8,[rcx]
       movzx     ecx,byte ptr [rdx]
       mov       rdx,2603AC13218
       mov       rdx,[rdx]
       call      qword ptr [7FC0]
       mov       rdx,rax
       test      rdx,rdx
       je        short 00000000000027A4
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rbx
       call      qword ptr [7AC8]
       add       r14d,1
       jo        short 00000000000027BE
       cmp       [rsi+8],r14d
       jg        short 0000000000002760
       mov       rcx,rbx
       call      qword ptr [5530]
       mov       r14,rax
       jmp       short 00000000000027C4
       call      0000000000002090
       int       3
       mov       rcx,rdi
       call      qword ptr [22C0]
       mov       rax,r14
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [5F48]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [5F48]
       mov       rcx,rsi
       call      0000000000006AD0
       int       3
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [22C0]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 783
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash02()
; 			var result = this._personRecord.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0C8]
       call      000000000000E9A0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 45
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       rsi,rcx
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000C336
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rdi
       call      000000000000B6D8
       mov       [rbp+0FFC0],rdi
       mov       rcx,277591C1BA8
       mov       rbx,[rcx]
       mov       rcx,rsi
       call      000000000000E9F0
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [0FC48]
       mov       rdx,rax
       mov       rcx,rdi
       call      000000000000B5E0
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      000000000000B2D0
       mov       rbx,rax
       mov       dword ptr [rbx+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      000000000000B400
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      000000000000AEB0
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short 000000000000C305
       mov       rdx,277591C1568
       mov       r12,[rdx]
       mov       rdx,277491C1AB8
       mov       r13,[rdx]
       movsxd    rdx,r14d
       lea       rdx,[rsi+rdx+10]
       mov       r8,r12
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r13
       call      00000000000010B0
       mov       rdx,rax
       mov       rcx,rbx
       call      000000000000CD10
       add       r14d,1
       jo        short 000000000000C313
       cmp       r15d,r14d
       jg        short 000000000000C2D9
       mov       rcx,rbx
       call      qword ptr [0A3E0]
       mov       r14,rax
       jmp       short 000000000000C319
       call      000000000000ECD0
       int       3
       mov       rcx,rdi
       call      qword ptr [85F0]
       mov       rax,r14
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
       mov       ecx,4D
       mov       rdx,7FF82F326048
       call      0000000000000390
       mov       rdi,rax
       mov       ecx,7C7
       mov       rdx,7FF82F326048
       call      0000000000000390
       mov       rsi,rax
       call      0000000000001940
       mov       r8,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      00000000000009F8
       mov       rcx,rax
       call      0000000000001A18
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
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short 000000000000C3AE
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [85F0]
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
; Total bytes of code 448
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash02()
; 			var result = this._personRecord.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0C8]
       call      qword ptr [16D8]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC8],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       near ptr 000000000000C2AE
       call      qword ptr [9B28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 000000000000C3BB
       lea       rcx,[rdi+0C]
       mov       rdx,23354411CD0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 000000000000C3DE
       lea       rcx,[rdi+12]
       mov       rdx,23354402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000C1CF
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 000000000000C1D4
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000C26F
       call      qword ptr [9C48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EF70000
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EF70000
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
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7F30]
       mov       [rbp+0FFD8],rdi
       mov       rcx,23354400BC8
       mov       rbx,[rcx]
       mov       rcx,rsi
       call      qword ptr [17C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [4010]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7C18]
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      000000000000EFB0
       mov       rbx,rax
       mov       dword ptr [rbx+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      000000000000F0D0
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      0000000000000010
       xor       r14d,r14d
       cmp       dword ptr [rsi+8],0
       jle       short 000000000000C390
       mov       edx,r14d
       lea       rdx,[rsi+rdx+10]
       mov       rcx,23354400558
       mov       r8,[rcx]
       movzx     ecx,byte ptr [rdx]
       mov       rdx,23358400AB0
       mov       rdx,[rdx]
       call      qword ptr [7FC0]
       mov       rdx,rax
       test      rdx,rdx
       je        short 000000000000C384
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rbx
       call      qword ptr [7AC8]
       add       r14d,1
       jo        short 000000000000C39E
       cmp       [rsi+8],r14d
       jg        short 000000000000C340
       mov       rcx,rbx
       call      qword ptr [5530]
       mov       r14,rax
       jmp       short 000000000000C3A4
       call      0000000000002090
       int       3
       mov       rcx,rdi
       call      qword ptr [22C0]
       mov       rax,r14
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [5F48]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      000000000000EFB0
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [5F48]
       mov       rcx,rsi
       call      0000000000006AD0
       int       3
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [22C0]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 783
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.DisposeFields()
; 			var disposableType = new DataTable("TEST");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			disposableType.DisposeFields();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rcx,offset MT_System.Data.DataTable
       call      0000000000001CF0
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [9000]
       mov       rdx,1DDAF004EB8
       mov       rdx,[rdx]
       lea       rcx,[rsi+70]
       call      0000000000000010
       mov       rcx,rsi
       add       rsp,20
       pop       rsi
       jmp       qword ptr [16F0]
; Total bytes of code 68
```
```assembly
; System.Data.DataTable..ctor()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       rdx,1DDAF002028
       mov       rdi,[rdx]
       lea       rcx,[rsi+70]
       mov       rdx,rdi
       call      0000000000000010
       lea       rcx,[rsi+80]
       mov       rdx,rdi
       call      0000000000000010
       mov       byte ptr [rsi+1C4],1
       mov       dword ptr [rsi+1B0],19
       mov       rdx,1DDAF000068
       mov       rdx,[rdx]
       add       rdx,8
       vmovupd   xmm0,[rdx]
       vmovupd   [rsi+1D8],xmm0
       vmovupd   xmm0,[rdx]
       vmovupd   [rsi+1E8],xmm0
       mov       rdx,1DDAD00BE00
       mov       rdx,[rdx]
       lea       rcx,[rsi+0D8]
       call      0000000000000010
       mov       byte ptr [rsi+1CC],1
       mov       rdx,1DDAD00BE08
       mov       rdx,[rdx]
       lea       rcx,[rsi+110]
       call      0000000000000010
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataView, System.Data.Common]]
       call      000000000000EFB0
       mov       rdi,rax
       mov       rdx,1DDAD00BE10
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      0000000000000010
       lea       rcx,[rsi+180]
       mov       rdx,rdi
       call      0000000000000010
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataViewListener, System.Data.Common]]
       call      000000000000EFB0
       mov       rdi,rax
       mov       rdx,1DDAD00BE18
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      0000000000000010
       lea       rcx,[rsi+188]
       mov       rdx,rdi
       call      0000000000000010
       mov       rcx,offset MT_System.Threading.ReaderWriterLockSlim
       call      000000000000EFB0
       mov       dword ptr [rax+40],0FFFFFFFF
       mov       dword ptr [rax+44],0FFFFFFFF
       mov       byte ptr [rax+4D],1
       mov       rdx,7FF82EAB55C0
       mov       ecx,1
       lock xadd [rdx],rcx
       inc       rcx
       mov       [rax+28],rcx
       lea       rcx,[rsi+198]
       mov       rdx,rax
       call      0000000000000010
       mov       dword ptr [rsi+1B8],0FFFFFFFF
       mov       rcx,7FF82F193F60
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rsi+1C0],eax
       mov       rcx,rsi
       call      qword ptr [12E8]
       mov       rcx,1DDAD00AFC8
       mov       rcx,[rcx]
       mov       rdi,rcx
       mov       ebx,[rsi+1C0]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr 000000000000A875
       mov       qword ptr [rsi+1A0],1
       mov       rcx,offset MT_System.Data.RecordManager
       call      000000000000EFB0
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [58B8]
       lea       rcx,[rsi+50]
       mov       rdx,rbx
       call      0000000000000010
       call      qword ptr [0F9F0]
       lea       rcx,[rsi+90]
       mov       rdx,rax
       call      0000000000000010
       mov       rcx,offset MT_System.Data.DataColumnCollection
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [1528]
       lea       rcx,[rsi+30]
       mov       rdx,rdi
       call      0000000000000010
       mov       rcx,offset MT_System.Data.ConstraintCollection
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.ArrayList
       call      000000000000EFB0
       mov       rbx,rax
       mov       rdx,1DDAD00ADF8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      0000000000000010
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      0000000000000010
       mov       dword ptr [rdi+28],1
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      0000000000000010
       lea       rcx,[rsi+38]
       mov       rdx,rdi
       call      0000000000000010
       mov       rcx,offset MT_System.Data.DataRowCollection
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,offset MT_System.Data.DataRowCollection+DataRowTree
       call      000000000000EFB0
       mov       rbx,rax
       mov       dword ptr [rbx+30],2
       mov       rcx,rbx
       call      qword ptr [3648]
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      0000000000000010
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      0000000000000010
       lea       rcx,[rsi+28]
       mov       rdx,rdi
       call      0000000000000010
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.Index, System.Data.Common]]
       call      000000000000EFB0
       mov       rdi,rax
       mov       rdx,1DDAD00BE30
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      0000000000000010
       lea       rcx,[rsi+58]
       mov       rdx,rdi
       call      0000000000000010
       mov       rcx,offset MT_System.Data.DataRowBuilder
       call      000000000000EFB0
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      0000000000000010
       mov       dword ptr [rdi+10],0FFFFFFFF
       lea       rcx,[rsi+178]
       mov       rdx,rdi
       call      0000000000000010
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,offset MT_System.Int32
       call      000000000000EFB0
       mov       [rax+8],ebx
       mov       [rsp+38],rax
       lea       r8,[rsp+38]
       mov       rdx,1DDAF004EC0
       mov       rdx,[rdx]
       mov       [rsp+28],r8
       mov       dword ptr [rsp+30],1
       lea       r8,[rsp+28]
       xor       ecx,ecx
       call      qword ptr [0BDC8]
       mov       r8,rax
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [0B348]
       jmp       near ptr 000000000000A6D3
; Total bytes of code 958
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.DisposeFields(System.IDisposable)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 000000000000B479
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rsi
       call      00000000000053F0
       mov       rcx,rax
       call      qword ptr [0D480]
       mov       rdi,rax
       mov       rcx,1DDAD007DA8
       mov       r8,[rcx]
       test      r8,r8
       jne       short 000000000000B4EA
       mov       rcx,offset MT_System.Func`2[[System.Reflection.FieldInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rbx,rax
       mov       rdx,1DDAD007DA0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      0000000000000010
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<DisposeFields>b__5_0(System.Reflection.FieldInfo)
       mov       [rbx+18],rdx
       mov       rcx,1DDAD007DA8
       mov       rdx,rbx
       call      0000000000000010
       mov       r8,rbx
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Where(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      qword ptr [1BA0]
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      qword ptr [0D630]
       mov       rdi,rax
       test      rdi,rdi
       je        short 000000000000B525
       mov       rcx,rdi
       call      qword ptr [0D918]
       test      eax,eax
       jg        short 000000000000B52E
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
       xor       ebx,ebx
       jmp       short 000000000000B5AE
       cmp       ebx,[rdi+10]
       jae       near ptr 000000000000B5DB
       mov       rcx,[rdi+8]
       cmp       ebx,[rcx+8]
       jae       near ptr 000000000000B5E2
       mov       edx,ebx
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rsi
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rbp,rax
       test      rbp,rbp
       je        short 000000000000B5A9
       mov       rdx,rbp
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [5810]
       test      rax,rax
       je        short 000000000000B588
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [1810]
       jmp       short 000000000000B5A9
       mov       rdx,rbp
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [5810]
       test      rax,rax
       je        short 000000000000B5A9
       mov       rcx,rax
       call      qword ptr [1690]
       add       ebx,1
       jo        short 000000000000B5D6
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount(System.Collections.Generic.IEnumerable`1<!!0>)
       call      qword ptr [0DC30]
       movsxd    rcx,ebx
       cmp       rax,rcx
       jg        near ptr 000000000000B532
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
       call      0000000000002090
       call      qword ptr [70D8]
       int       3
       call      00000000000023D0
       int       3
; Total bytes of code 392
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.HasProperty01()
; 			var result = this._personProper.HasProperty("City");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0C0]
       mov       rdx,1A4E8B91AC0
       mov       rdx,[rdx]
       call      000000000000E9B8
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass7_0
       call      000000000000B2D0
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      000000000000AEB0
       test      rsi,rsi
       jne       short 00000000000006D1
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr 00000000000007A0
       cmp       dword ptr [rcx+8],0
       je        near ptr 00000000000007A0
       xor       eax,eax
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 000000000000071E
       call      00000000000019A0
       mov       rbx,rax
       mov       ecx,7D9
       mov       rdx,7FF82F346048
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000001A20
       int       3
       cmp       [rcx],ecx
       mov       edx,3
       call      0000000000008468
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      000000000000AEB0
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rsi
       call      000000000000F570
       mov       rcx,rax
       call      000000000000B580
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      000000000000AEB0
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass7_0.<HasProperty>b__0(System.Reflection.PropertyInfo)
       mov       [rdi+18],r9
       lea       r9,[rsp+28]
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, Boolean ByRef)
       call      0000000000002E48
       test      rax,rax
       setne     al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       eax,1
       jmp       near ptr 00000000000006EA
; Total bytes of code 282
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.HasProperty01()
; 			var result = this._personProper.HasProperty("City");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0C0]
       mov       rdx,19FA0404EB8
       mov       rdx,[rdx]
       call      qword ptr [1720]
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass7_0
       call      000000000000EFB0
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      0000000000000010
       test      rsi,rsi
       jne       short 0000000000007C01
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        short 0000000000007C22
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short 0000000000007C24
       jmp       short 0000000000007C24
       xor       edx,edx
       test      edx,edx
       jne       near ptr 0000000000007CCE
       call      qword ptr [9C48]
       mov       rbx,rax
       mov       ecx,7D9
       mov       rdx,7FF82EF64060
       call      000000000000F510
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EF60000
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EF60000
       call      000000000000F510
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5270]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [9870]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [9D08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [0D4E0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      0000000000000010
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rsi
       call      00000000000053F0
       mov       rcx,rax
       call      qword ptr [7900]
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      0000000000000010
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass7_0.<HasProperty>b__0(System.Reflection.PropertyInfo)
       mov       [rdi+18],r9
       lea       r9,[rsp+28]
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, Boolean ByRef)
       call      qword ptr [9D68]
       test      rax,rax
       setne     al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 403
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.HasProperty02()
; 			var result = this._personRecord.HasProperty("City");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0C8]
       mov       rdx,277386A22D8
       mov       rdx,[rdx]
       call      000000000000E9B8
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass7_0
       call      000000000000B2D0
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      000000000000AEB0
       test      rsi,rsi
       jne       short 0000000000000261
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr 0000000000000330
       cmp       dword ptr [rcx+8],0
       je        near ptr 0000000000000330
       xor       eax,eax
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short 00000000000002AE
       call      00000000000019A0
       mov       rbx,rax
       mov       ecx,7D9
       mov       rdx,7FF82F316048
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rbx
       call      0000000000001A20
       int       3
       cmp       [rcx],ecx
       mov       edx,3
       call      0000000000008468
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      000000000000AEB0
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rsi
       call      000000000000F570
       mov       rcx,rax
       call      000000000000B588
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      000000000000AEB0
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass7_0.<HasProperty>b__0(System.Reflection.PropertyInfo)
       mov       [rdi+18],r9
       lea       r9,[rsp+28]
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, Boolean ByRef)
       call      0000000000002E48
       test      rax,rax
       setne     al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       eax,1
       jmp       near ptr 000000000000027A
; Total bytes of code 282
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.HasProperty02()
; 			var result = this._personRecord.HasProperty("City");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0C8]
       mov       rdx,1F19F001AC8
       mov       rdx,[rdx]
       call      qword ptr [1720]
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass7_0
       call      000000000000EFB0
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      0000000000000010
       test      rsi,rsi
       jne       short 0000000000007AB1
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        short 0000000000007AD2
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short 0000000000007AD4
       jmp       short 0000000000007AD4
       xor       edx,edx
       test      edx,edx
       jne       near ptr 0000000000007B7E
       call      qword ptr [9C48]
       mov       rbx,rax
       mov       ecx,7D9
       mov       rdx,7FF82EF94060
       call      000000000000F510
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EF90000
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EF90000
       call      000000000000F510
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5270]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [9870]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [9D08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
       call      0000000000006AD0
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [0D4E0]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      0000000000000010
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rsi
       call      00000000000053F0
       mov       rcx,rax
       call      qword ptr [7900]
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      0000000000000010
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass7_0.<HasProperty>b__0(System.Reflection.PropertyInfo)
       mov       [rdi+18],r9
       lea       r9,[rsp+28]
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, Boolean ByRef)
       call      qword ptr [9D68]
       test      rax,rax
       setne     al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 403
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNotNull01()
; 			var result = this._personProper.IsNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rcx+0C0]
       test      rax,rax
       setne     al
       movzx     eax,al
       mov       rdx,[rcx+20]
       mov       [rdx+54],al
       ret
; Total bytes of code 24
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNotNull01()
; 			var result = this._personProper.IsNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       cmp       qword ptr [rcx+0C0],0
       setne     al
       mov       rdx,[rcx+20]
       mov       [rdx+54],al
       ret
; Total bytes of code 21
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNotNull02()
; 			var result = this._personRecord.IsNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rcx+0C8]
       test      rax,rax
       setne     al
       movzx     eax,al
       mov       rdx,[rcx+20]
       mov       [rdx+54],al
       ret
; Total bytes of code 24
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNotNull02()
; 			var result = this._personRecord.IsNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       cmp       qword ptr [rcx+0C8],0
       setne     al
       mov       rdx,[rcx+20]
       mov       [rdx+54],al
       ret
; Total bytes of code 21
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNull01()
; 			var result = this._personProper.IsNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rcx+0C0]
       test      rax,rax
       sete      al
       movzx     eax,al
       mov       rdx,[rcx+20]
       mov       [rdx+54],al
       ret
; Total bytes of code 24
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNull01()
; 			var result = this._personProper.IsNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       cmp       qword ptr [rcx+0C0],0
       sete      al
       mov       rdx,[rcx+20]
       mov       [rdx+54],al
       ret
; Total bytes of code 21
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNull02()
; 			var result = this._personRecord.IsNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rcx+0C8]
       test      rax,rax
       sete      al
       movzx     eax,al
       mov       rdx,[rcx+20]
       mov       [rdx+54],al
       ret
; Total bytes of code 24
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNull02()
; 			var result = this._personRecord.IsNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       cmp       qword ptr [rcx+0C8],0
       sete      al
       mov       rdx,[rcx+20]
       mov       [rdx+54],al
       ret
; Total bytes of code 21
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.Duplicate01()
; 			var result = this._personRecord with { Id = "12345678" };
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       mov       rdi,[rsi+0C8]
       cmp       [rdi],edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      000000000000B2D0
       mov       rbx,rax
       vmovupd   xmm0,[rdi+40]
       vmovupd   [rbx+40],xmm0
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      000000000000AEB0
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      000000000000AEB0
       mov       rdx,[rdi+18]
       lea       rcx,[rbx+18]
       call      000000000000AEB0
       mov       rdx,[rdi+20]
       lea       rcx,[rbx+20]
       call      000000000000AEB0
       mov       rdx,[rdi+28]
       lea       rcx,[rbx+28]
       call      000000000000AEB0
       mov       rdx,[rdi+30]
       lea       rcx,[rbx+30]
       call      000000000000AEB0
       mov       rdx,[rdi+38]
       lea       rcx,[rbx+38]
       call      000000000000AEB0
       mov       rdx,1A1FDFE32F0
       mov       rdx,[rdx]
       lea       rcx,[rbx+38]
       call      000000000000AEB0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rbx
       call      000000000000B010
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 190
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.Duplicate01()
; 			var result = this._personRecord with { Id = "12345678" };
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       mov       rdi,[rsi+0C8]
       cmp       [rdi],dil
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      000000000000EFB0
       mov       rbx,rax
       vmovupd   xmm0,[rdi+40]
       vmovupd   [rbx+40],xmm0
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      0000000000000010
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      0000000000000010
       mov       rdx,[rdi+18]
       lea       rcx,[rbx+18]
       call      0000000000000010
       mov       rdx,[rdi+20]
       lea       rcx,[rbx+20]
       call      0000000000000010
       mov       rdx,[rdi+28]
       lea       rcx,[rbx+28]
       call      0000000000000010
       mov       rdx,[rdi+30]
       lea       rcx,[rbx+30]
       call      0000000000000010
       mov       rdx,[rdi+38]
       lea       rcx,[rbx+38]
       call      0000000000000010
       mov       rdx,20EB1813A30
       mov       rdx,[rdx]
       lea       rcx,[rbx+38]
       call      0000000000000010
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rbx
       call      0000000000000010
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 189
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PersonRecordToString01()
; 			var person = this._personRecord;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0C8]
       cmp       [rcx],ecx
       call      qword ptr [4E20]
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
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
       mov       rdx,1BCA40622D8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      000000000000CD10
       mov       rdx,1BCA40622E0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      000000000000CD10
       mov       rcx,rsi
       mov       rdx,rdi
       call      000000000000E7F0
       test      eax,eax
       je        short 0000000000003EDC
       mov       ecx,[rdi+18]
       mov       eax,ecx
       mov       rdx,[rdi+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short 0000000000003F10
       movsxd    rax,eax
       mov       word ptr [rdx+rax*2+10],20
       inc       ecx
       mov       [rdi+18],ecx
       mov       ecx,[rdi+18]
       mov       eax,ecx
       mov       rdx,[rdi+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short 0000000000003F25
       movsxd    rax,eax
       mov       word ptr [rdx+rax*2+10],7D
       inc       ecx
       mov       [rdi+18],ecx
       mov       rcx,rdi
       mov       rax,[0A3E0]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
       mov       rcx,rdi
       mov       edx,20
       mov       r8d,1
       call      000000000000CD00
       jmp       short 0000000000003EDC
       mov       rcx,rdi
       mov       edx,7D
       mov       r8d,1
       call      000000000000CD00
       jmp       short 0000000000003EFD
; Total bytes of code 250
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PersonRecordToString01()
; 			var person = this._personRecord;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0C8]
       cmp       [rcx],ecx
       call      qword ptr [2E50]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       rdx,1E497C056D0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,0C
       call      qword ptr [7AC8]
       mov       rdx,1E497C056D8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7AC8]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [1258]
       test      eax,eax
       je        short 000000000000AC48
       mov       ecx,[rdi+18]
       mov       edx,ecx
       mov       r8,[rdi+8]
       mov       eax,[r8+8]
       cmp       eax,edx
       jbe       short 000000000000AC34
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],20
       inc       ecx
       mov       [rdi+18],ecx
       jmp       short 000000000000AC48
       mov       rcx,rdi
       mov       edx,20
       mov       r8d,1
       call      qword ptr [7360]
       mov       ecx,[rdi+18]
       mov       edx,ecx
       mov       r8,[rdi+8]
       cmp       [r8+8],edx
       jbe       short 000000000000AC75
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],7D
       inc       ecx
       mov       [rdi+18],ecx
       mov       rcx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [5530]
       mov       rcx,rdi
       mov       edx,7D
       mov       r8d,1
       call      qword ptr [7360]
       jmp       short 000000000000AC66
; Total bytes of code 267
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary01()
; 			var person = this._personProper;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToDictionary(ignoreNulls: true);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0C0]
       mov       rdx,26397DA3020
       mov       rdx,[rdx]
       mov       r8d,1
       call      000000000000E9D8
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       lea       rbp,[rsp+100]
       xor       eax,eax
       mov       [rbp+0FF68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF70],xmm4
       vmovdqa   xmmword ptr [rbp+0FF80],xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF30],rsp
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      0000000000009D38
       mov       rcx,rdi
       test      rcx,rcx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000CF41
       mov       rcx,rdi
       call      000000000000F570
       mov       r15,rax
       mov       rcx,7FF82F320828
       mov       edx,2C
       call      000000000000B4B0
       mov       rcx,26377DA88F0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      0000000000009E18
       test      rax,rax
       je        short 000000000000C85E
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      0000000000009E28
       mov       rax,r14
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       mov       rcx,r15
       call      000000000000B6A8
       test      eax,eax
       je        near ptr 000000000000CB51
       xor       r15d,r15d
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      0000000000007460
       mov       rcx,rax
       mov       r11,7FF82EEA0510
       call      qword ptr [510]
       mov       [rbp+0FF60],rax
       mov       rcx,rax
       mov       r11,7FF82EEA0518
       call      qword ptr [518]
       test      eax,eax
       je        near ptr 000000000000CB0C
       mov       rcx,[rbp+0FF60]
       mov       r11,7FF82EEA0520
       call      qword ptr [520]
       mov       rdi,rax
       mov       ecx,r15d
       add       ecx,1
       jo        near ptr 000000000000CAEF
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      000000000000B2D0
       mov       r12,rax
       call      000000000000E4D0
       mov       rcx,rax
       mov       [r12+8],r15d
       xor       edx,edx
       mov       r8,26397DA1388
       mov       r8,[r8]
       mov       rax,26387DA32F0
       mov       rax,[rax]
       mov       [rbp+0FF68],rsi
       mov       [rbp+0FF70],r12
       mov       [rbp+0FF78],rdx
       mov       [rbp+0FF80],r8
       mov       rdx,rax
       lea       r8,[rbp+0FF68]
       call      0000000000008838
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      000000000000E9D8
       mov       rdi,rax
       test      r14,r14
       je        near ptr 000000000000CAE4
       test      rdi,rdi
       je        near ptr 000000000000CAD9
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      0000000000007440
       test      rax,rax
       jne       near ptr 000000000000CAF4
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      000000000000B2D0
       mov       r15,rax
       call      0000000000001870
       mov       [r15+8],eax
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      000000000000AEB0
       lea       rcx,[r15+30]
       mov       rdx,rdi
       call      000000000000AEB0
       mov       rcx,7FF82F3267E8
       mov       edx,5A
       call      000000000000B4B0
       mov       rcx,26377DA8B90
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short 000000000000CA2E
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rdi,rax
       mov       rdx,26377DA8B80
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr 000000000000CAD3
       lea       rcx,[rdi+8]
       call      000000000000AEB0
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],rdx
       mov       rcx,26377DA8B90
       mov       rdx,rdi
       call      000000000000B010
       mov       rcx,26377DA8B98
       mov       r9,[rcx]
       test      r9,r9
       jne       short 000000000000CA90
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       r14,rax
       mov       rdx,26377DA8B80
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short 000000000000CAD3
       lea       rcx,[r14+8]
       call      000000000000AEB0
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rdx
       mov       rcx,26377DA8B98
       mov       rdx,r14
       call      000000000000B010
       mov       r9,r14
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      000000000000C4B8
       mov       r14,rax
       mov       rcx,[rbp+0FF60]
       mov       r11,7FF82EEA0518
       call      qword ptr [518]
       test      eax,eax
       mov       r15d,ebx
       jne       near ptr 000000000000C8B8
       jmp       short 000000000000CB0C
       call      0000000000007270
       int       3
       mov       ecx,0E
       call      000000000000B010
       int       3
       mov       ecx,4
       call      000000000000B010
       int       3
       call      000000000000ECD0
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r15,rax
       jmp       near ptr 000000000000C9B7
       mov       rdx,[rbp+0FF60]
       mov       rcx,offset MT_System.IDisposable
       call      0000000000007438
       test      rax,rax
       je        short 000000000000CB3A
       mov       rcx,rax
       mov       r11,7FF82EEA0528
       call      qword ptr [528]
       mov       rax,r14
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       cmp       [r15],r15d
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp+0FF88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      0000000000001840
       cmp       dword ptr [rbp+0FF98],0
       jne       short 000000000000CB89
       mov       rcx,26397DA2F08
       mov       r15,[rcx]
       jmp       short 000000000000CBD7
       cmp       dword ptr [rbp+0FF98],1
       jne       short 000000000000CBB6
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      000000000000B460
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp+0FF90]
       xor       edx,edx
       call      0000000000008190
       jmp       short 000000000000CBD7
       lea       rdx,[rbp+0FF88]
       mov       r8d,[rbp+0FF98]
       mov       rcx,offset MD_System.Array.Resize(!!0[] ByRef, Int32)
       call      0000000000001B60
       mov       ecx,[rbp+0FF98]
       mov       [rbp+0FF9C],ecx
       mov       r15,[rbp+0FF88]
       mov       rcx,26397DA3020
       mov       r12,[rcx]
       cmp       dword ptr [rsi+8],0
       jle       near ptr 000000000000CCAB
       xor       ecx,ecx
       mov       [rbp+0FFA0],rcx
       mov       rcx,26397DA2EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [0AB80]
       lea       r8,[rbp+0FFA0]
       mov       [rbp+0FFA8],rax
       test      rax,rax
       jne       short 000000000000CC1F
       xor       ecx,ecx
       xor       edx,edx
       jmp       short 000000000000CC26
       lea       rcx,[rax+10]
       mov       edx,[rax+8]
       add       r8,18
       mov       [r8],rcx
       mov       [r8+8],edx
       xor       r8d,r8d
       mov       [rbp+0FFB0],r8d
       mov       byte ptr [rbp+0FFB4],0
       cmp       byte ptr [rbp+0FFB4],0
       jne       short 000000000000CC85
       mov       r8d,[rbp+0FFB0]
       cmp       r8d,[rbp+0FFC0]
       ja        near ptr 000000000000CF8B
       mov       rcx,[rbp+0FFB8]
       mov       edx,[rbp+0FFC0]
       sub       edx,r8d
       mov       r8d,r8d
       lea       rcx,[rcx+r8*2]
       mov       r8d,[rsi+8]
       cmp       r8d,edx
       ja        short 000000000000CC85
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      000000000000E808
       mov       ecx,[rbp+0FFB0]
       add       ecx,[rsi+8]
       mov       [rbp+0FFB0],ecx
       jmp       short 000000000000CC91
       lea       rcx,[rbp+0FFA0]
       mov       rdx,rsi
       call      00000000000025F8
       lea       rcx,[rbp+0FFA0]
       mov       edx,2E
       call      000000000000B778
       lea       rcx,[rbp+0FFA0]
       call      0000000000002598
       mov       r12,rax
       xor       esi,esi
       cmp       dword ptr [r15+8],0
       jle       near ptr 000000000000CF25
       cmp       esi,[r15+8]
       jae       near ptr 000000000000CFAD
       movsxd    rcx,esi
       mov       r13,[r15+rcx*8+10]
       mov       rcx,r13
       mov       rdx,rdi
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       mov       [rbp+0FF58],rax
       test      bl,bl
       je        near ptr 000000000000CDF0
       test      rax,rax
       je        near ptr 000000000000CF16
       call      000000000000E4D0
       mov       [rbp+0FF50],rax
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,r12
       xor       edx,edx
       mov       r8,26397DA1388
       mov       r8,[r8]
       mov       r13,[rbp+0FF50]
       mov       r9,26387DA32F8
       mov       r9,[r9]
       mov       [rbp+0FF68],rcx
       mov       [rbp+0FF70],rax
       mov       [rbp+0FF78],rdx
       mov       [rbp+0FF80],r8
       mov       rcx,r13
       mov       rdx,r9
       lea       r8,[rbp+0FF68]
       call      0000000000008838
       mov       rdx,rax
       mov       rcx,[rbp+0FF58]
       mov       r8d,1
       call      000000000000E9D8
       mov       r13,rax
       test      r14,r14
       je        near ptr 000000000000CF91
       test      r13,r13
       je        near ptr 000000000000CF9C
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      0000000000007440
       test      rax,rax
       jne       short 000000000000CDF5
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      000000000000B2D0
       mov       [rbp+0FF40],rax
       call      0000000000001870
       mov       r8,[rbp+0FF40]
       mov       [r8+8],eax
       mov       [rbp+0FF40],r8
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      000000000000AEB0
       mov       r14,[rbp+0FF40]
       lea       rcx,[r14+30]
       mov       rdx,r13
       call      000000000000AEB0
       jmp       short 000000000000CE08
       jmp       near ptr 000000000000CCF6
       mov       rcx,rax
       mov       rdx,r13
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       mov       rcx,7FF82F3267E8
       mov       edx,5A
       call      000000000000B4B0
       mov       rcx,26377DA8BA0
       mov       r13,[rcx]
       test      r13,r13
       jne       short 000000000000CE7F
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       r13,rax
       mov       rdx,26377DA8B80
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr 000000000000CFA7
       lea       rcx,[r13+8]
       call      000000000000AEB0
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r13+18],rdx
       mov       rcx,26377DA8BA0
       mov       rdx,r13
       call      000000000000B010
       mov       rcx,26377DA8BA8
       mov       r9,[rcx]
       test      r9,r9
       jne       short 000000000000CEF7
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       r9,rax
       mov       [rbp+0FF48],r9
       mov       rdx,26377DA8B80
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr 000000000000CFA7
       lea       rcx,[r9+8]
       call      000000000000AEB0
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp+0FF48]
       mov       [r9+18],rdx
       mov       rcx,26377DA8BA8
       mov       rdx,r9
       call      000000000000B010
       mov       r9,[rbp+0FF48]
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,r13
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      000000000000C4B8
       mov       r14,rax
       add       esi,1
       jo        short 000000000000CF3C
       cmp       [r15+8],esi
       jg        near ptr 000000000000CCB8
       mov       rax,r14
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       call      000000000000ECD0
       mov       ecx,4D
       mov       rdx,7FF82F326048
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,7C7
       mov       rdx,7FF82F326048
       call      0000000000000390
       mov       rdi,rax
       call      0000000000001940
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      00000000000009F8
       mov       rcx,rax
       call      0000000000001A18
       int       3
       call      0000000000009580
       int       3
       mov       ecx,4
       call      000000000000B010
       int       3
       mov       ecx,0E
       call      000000000000B010
       int       3
       call      0000000000007270
       int       3
       call      000000000000F130
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
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+100]
       mov       rdx,[rbp+0FF60]
       mov       rcx,offset MT_System.IDisposable
       call      0000000000007438
       test      rax,rax
       je        short 000000000000D001
       mov       rcx,rax
       mov       r11,7FF82EEA0528
       call      qword ptr [528]
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
; Total bytes of code 2227
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary01()
; 			var person = this._personProper;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToDictionary(ignoreNulls: true);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0C0]
       mov       rdx,29B47402028
       mov       rdx,[rdx]
       mov       r8d,1
       call      qword ptr [1780]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp+0FF58],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short 000000000000AFF2
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF20],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       r14,rax
       mov       rcx,[r14+18]
       call      qword ptr [5DC8]
       test      rax,rax
       je        short 000000000000B04B
       lea       rcx,[r14+18]
       mov       rdx,rax
       call      0000000000000010
       mov       rax,rsi
       test      rax,rax
       jne       near ptr 000000000000B1C8
       call      qword ptr [9B28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       r14,rax
       cmp       dword ptr [r14+8],3
       jl        near ptr 000000000000B8C8
       lea       rcx,[r14+0C]
       mov       rdx,29B45400580
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[r14+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 000000000000B8EB
       lea       rcx,[r14+12]
       mov       rdx,29B47402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000B0E9
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 000000000000B0EE
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000B189
       call      qword ptr [9C48]
       mov       r14,rax
       mov       ecx,9
       mov       rdx,7FF82EF80000
       call      000000000000F510
       mov       r15,rax
       mov       ecx,36B
       mov       rdx,7FF82EF80000
       call      000000000000F510
       mov       rcx,rax
       mov       r9,r15
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5270]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [9870]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [9D08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
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
       mov       r15,rax
       mov       rcx,29B4740BF18
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [52E8]
       test      rax,rax
       je        short 000000000000B227
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       mov       rcx,r14
       mov       rdx,rdi
       mov       r9d,2
       call      qword ptr [5318]
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       mov       rcx,r15
       call      qword ptr [7C30]
       test      eax,eax
       je        near ptr 000000000000B4DB
       xor       r15d,r15d
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [5888]
       mov       rcx,rax
       mov       r11,7FF82E9C0628
       call      qword ptr [r11]
       mov       [rbp+0FF50],rax
       mov       rcx,rax
       mov       r11,7FF82E9C0630
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr 000000000000B498
       mov       rcx,[rbp+0FF50]
       mov       r11,7FF82E9C0638
       call      qword ptr [r11]
       mov       rsi,rax
       mov       ecx,r15d
       add       ecx,1
       jo        near ptr 000000000000B47B
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      000000000000EFB0
       mov       r12,rax
       call      qword ptr [0F9F0]
       mov       rcx,rax
       mov       [r12+8],r15d
       mov       [rbp+0FF90],rdi
       mov       [rbp+0FF98],r12
       lea       rdx,[rbp+0FF90]
       mov       r8,29B47413218
       mov       r8,[r8]
       mov       [rbp+0FF58],rdx
       mov       dword ptr [rbp+0FF60],2
       mov       rdx,r8
       lea       r8,[rbp+0FF58]
       call      qword ptr [0BDC8]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [1780]
       mov       rsi,rax
       test      r14,r14
       je        near ptr 000000000000B480
       test      rsi,rsi
       je        near ptr 000000000000B48C
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [5828]
       test      rax,rax
       jne       short 000000000000B370
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      000000000000EFB0
       mov       r15,rax
       call      0000000000004EA0
       mov       [r15+8],eax
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      0000000000000010
       lea       rcx,[r15+30]
       mov       rdx,rsi
       call      0000000000000010
       jmp       short 000000000000B383
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r15,rax
       mov       rcx,29B4740C1B8
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short 000000000000B3DD
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rsi,rax
       mov       rdx,29B4740C1A8
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      0000000000000010
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rsi+18],rdx
       mov       rcx,29B4740C1B8
       mov       rdx,rsi
       call      0000000000000010
       mov       rcx,29B4740C1C0
       mov       r9,[rcx]
       test      r9,r9
       jne       short 000000000000B43A
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       r14,rax
       mov       rdx,29B4740C1A8
       mov       rdx,[rdx]
       lea       rcx,[r14+8]
       call      0000000000000010
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rdx
       mov       rcx,29B4740C1C0
       mov       rdx,r14
       call      0000000000000010
       mov       r9,r14
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      qword ptr [94F8]
       mov       r14,rax
       mov       rcx,[rbp+0FF50]
       mov       r11,7FF82E9C0630
       call      qword ptr [r11]
       test      eax,eax
       mov       r15d,ebx
       jne       near ptr 000000000000B27D
       jmp       short 000000000000B498
       call      0000000000002090
       mov       ecx,4
       call      qword ptr [0B780]
       int       3
       mov       ecx,0E
       call      qword ptr [0B780]
       int       3
       mov       rdx,[rbp+0FF50]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [5810]
       test      rax,rax
       je        short 000000000000B4C4
       mov       rcx,rax
       mov       r11,7FF82E9C0640
       call      qword ptr [r11]
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp+0FF78]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7318]
       cmp       dword ptr [rbp+0FF88],0
       je        near ptr 000000000000B89F
       cmp       dword ptr [rbp+0FF88],1
       jne       near ptr 000000000000B85A
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      000000000000F130
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp+0FF80]
       xor       edx,edx
       call      0000000000000020
       mov       rcx,29B47402028
       mov       r12,[rcx]
       cmp       dword ptr [rdi+8],0
       jle       near ptr 000000000000B604
       xor       ecx,ecx
       mov       [rbp+0FFA0],rcx
       mov       rcx,29B47401F40
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [3F18]
       lea       r13,[rbp+0FFA0]
       mov       [rbp+0FFA8],rax
       test      rax,rax
       je        near ptr 000000000000B90E
       lea       r9,[rax+10]
       mov       eax,[rax+8]
       add       r13,18
       mov       [r13],r9
       mov       [r13+8],eax
       xor       r8d,r8d
       mov       [rbp+0FFB0],r8d
       mov       byte ptr [rbp+0FFB4],0
       cmp       byte ptr [rbp+0FFB4],0
       jne       near ptr 000000000000B8B1
       mov       r8d,[rbp+0FFB0]
       cmp       r8d,[rbp+0FFC0]
       ja        near ptr 000000000000B918
       mov       rcx,[rbp+0FFB8]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp+0FFC0]
       sub       edx,r8d
       cmp       [rdi+8],edx
       ja        near ptr 000000000000B8B1
       lea       rdx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8,r8
       call      qword ptr [5810]
       mov       ecx,[rbp+0FFB0]
       add       ecx,[rdi+8]
       mov       [rbp+0FFB0],ecx
       lea       rcx,[rbp+0FFA0]
       mov       edx,2E
       call      qword ptr [7DF8]
       lea       rcx,[rbp+0FFA0]
       call      qword ptr [7300]
       mov       r12,rax
       xor       edi,edi
       cmp       dword ptr [r15+8],0
       jle       near ptr 000000000000B83E
       mov       ecx,edi
       mov       r13,[r15+rcx*8+10]
       mov       rcx,r13
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       mov       [rbp+0FF48],rax
       test      bl,bl
       je        near ptr 000000000000B855
       test      rax,rax
       je        near ptr 000000000000B82B
       call      qword ptr [0F9F0]
       mov       [rbp+0FF40],rax
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp+0FF68],r12
       mov       [rbp+0FF70],rax
       lea       rcx,[rbp+0FF68]
       mov       r13,[rbp+0FF48]
       mov       rdx,[rbp+0FF40]
       mov       r8,29B47413220
       mov       r8,[r8]
       mov       [rbp+0FF58],rcx
       mov       dword ptr [rbp+0FF60],2
       mov       rcx,rdx
       mov       rdx,r8
       lea       r8,[rbp+0FF58]
       call      qword ptr [0BDC8]
       mov       rdx,rax
       mov       rcx,r13
       mov       r8d,1
       call      qword ptr [1780]
       mov       r13,rax
       test      r14,r14
       je        near ptr 000000000000B91F
       test      r13,r13
       je        near ptr 000000000000B92B
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [5828]
       test      rax,rax
       jne       near ptr 000000000000B887
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      000000000000EFB0
       mov       [rbp+0FF30],rax
       call      0000000000004EA0
       mov       r8,[rbp+0FF30]
       mov       [r8+8],eax
       mov       [rbp+0FF30],r8
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      0000000000000010
       mov       r14,[rbp+0FF30]
       lea       rcx,[r14+30]
       mov       rdx,r13
       call      0000000000000010
       mov       rcx,29B4740C1C8
       mov       r13,[rcx]
       test      r13,r13
       jne       short 000000000000B79C
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       r13,rax
       mov       rdx,29B4740C1A8
       mov       rdx,[rdx]
       lea       rcx,[r13+8]
       call      0000000000000010
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r13+18],rdx
       mov       rcx,29B4740C1C8
       mov       rdx,r13
       call      0000000000000010
       mov       rcx,29B4740C1D0
       mov       r9,[rcx]
       test      r9,r9
       jne       short 000000000000B80B
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       r9,rax
       mov       [rbp+0FF38],r9
       mov       rdx,29B4740C1A8
       mov       rdx,[rdx]
       lea       rcx,[r9+8]
       call      0000000000000010
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp+0FF38]
       mov       [r9+18],rdx
       mov       rcx,29B4740C1D0
       mov       rdx,r9
       call      0000000000000010
       mov       r9,[rbp+0FF38]
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,r13
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      qword ptr [94F8]
       mov       r14,rax
       add       edi,1
       jo        near ptr 000000000000B8C3
       cmp       [r15+8],edi
       jg        near ptr 000000000000B611
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       jmp       near ptr 000000000000B644
       lea       rdx,[rbp+0FF78]
       mov       r8d,[rbp+0FF88]
       mov       rcx,offset MD_System.Array.Resize(!!0[] ByRef, Int32)
       call      qword ptr [0D438]
       mov       ecx,[rbp+0FF88]
       mov       [rbp+0FF8C],ecx
       mov       r15,[rbp+0FF78]
       jmp       near ptr 000000000000B538
       mov       rcx,rax
       mov       rdx,r13
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr 000000000000B742
       mov       rcx,29B47401F88
       mov       r15,[rcx]
       jmp       near ptr 000000000000B538
       lea       rcx,[rbp+0FFA0]
       mov       rdx,rdi
       call      qword ptr [7420]
       jmp       near ptr 000000000000B5E8
       call      0000000000002090
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
       xor       r9d,r9d
       xor       eax,eax
       jmp       near ptr 000000000000B585
       call      qword ptr [7048]
       int       3
       mov       ecx,4
       call      qword ptr [0B780]
       int       3
       mov       ecx,0E
       call      qword ptr [0B780]
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
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+110]
       mov       rdx,[rbp+0FF50]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [5810]
       test      rax,rax
       je        short 000000000000B983
       mov       rcx,rax
       mov       r11,7FF82E9C0640
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
; Total bytes of code 2517
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary02()
; 			var person = this._personProper;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToDictionary(ignoreNulls: false);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0C0]
       mov       rdx,2D020113020
       mov       rdx,[rdx]
       xor       r8d,r8d
       call      000000000000E9D8
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       lea       rbp,[rsp+100]
       xor       eax,eax
       mov       [rbp+0FF68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF70],xmm4
       vmovdqa   xmmword ptr [rbp+0FF80],xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF30],rsp
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      0000000000009D38
       mov       rcx,rdi
       test      rcx,rcx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000CE21
       mov       rcx,rdi
       call      000000000000F570
       mov       r15,rax
       mov       rcx,7FF82F340828
       mov       edx,2C
       call      000000000000B4B0
       mov       rcx,2D02011CCF8
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      0000000000009E18
       test      rax,rax
       je        short 000000000000C73E
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      0000000000009E28
       mov       rax,r14
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       mov       rcx,r15
       call      000000000000B6A0
       test      eax,eax
       je        near ptr 000000000000CA31
       xor       r15d,r15d
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      0000000000007460
       mov       rcx,rax
       mov       r11,7FF82EEC0510
       call      qword ptr [510]
       mov       [rbp+0FF60],rax
       mov       rcx,rax
       mov       r11,7FF82EEC0518
       call      qword ptr [518]
       test      eax,eax
       je        near ptr 000000000000C9EC
       mov       rcx,[rbp+0FF60]
       mov       r11,7FF82EEC0520
       call      qword ptr [520]
       mov       rdi,rax
       mov       ecx,r15d
       add       ecx,1
       jo        near ptr 000000000000C9CF
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      000000000000B2D0
       mov       r12,rax
       call      000000000000E4D0
       mov       rcx,rax
       mov       [r12+8],r15d
       xor       edx,edx
       mov       r8,2D020111388
       mov       r8,[r8]
       mov       rax,2D020123A28
       mov       rax,[rax]
       mov       [rbp+0FF68],rsi
       mov       [rbp+0FF70],r12
       mov       [rbp+0FF78],rdx
       mov       [rbp+0FF80],r8
       mov       rdx,rax
       lea       r8,[rbp+0FF68]
       call      0000000000008838
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      000000000000E9D8
       mov       rdi,rax
       test      r14,r14
       je        near ptr 000000000000C9C4
       test      rdi,rdi
       je        near ptr 000000000000C9B9
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      0000000000007440
       test      rax,rax
       jne       near ptr 000000000000C9D4
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      000000000000B2D0
       mov       r15,rax
       call      0000000000001870
       mov       [r15+8],eax
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      000000000000AEB0
       lea       rcx,[r15+30]
       mov       rdx,rdi
       call      000000000000AEB0
       mov       rcx,7FF82F3467E8
       mov       edx,5A
       call      000000000000B4B0
       mov       rcx,2D02011CF98
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short 000000000000C90E
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rdi,rax
       mov       rdx,2D02011CF88
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr 000000000000C9B3
       lea       rcx,[rdi+8]
       call      000000000000AEB0
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],rdx
       mov       rcx,2D02011CF98
       mov       rdx,rdi
       call      000000000000B010
       mov       rcx,2D02011CFA0
       mov       r9,[rcx]
       test      r9,r9
       jne       short 000000000000C970
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       r14,rax
       mov       rdx,2D02011CF88
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short 000000000000C9B3
       lea       rcx,[r14+8]
       call      000000000000AEB0
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rdx
       mov       rcx,2D02011CFA0
       mov       rdx,r14
       call      000000000000B010
       mov       r9,r14
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      000000000000C4A8
       mov       r14,rax
       mov       rcx,[rbp+0FF60]
       mov       r11,7FF82EEC0518
       call      qword ptr [518]
       test      eax,eax
       mov       r15d,ebx
       jne       near ptr 000000000000C798
       jmp       short 000000000000C9EC
       call      0000000000007270
       int       3
       mov       ecx,0E
       call      000000000000B010
       int       3
       mov       ecx,4
       call      000000000000B010
       int       3
       call      000000000000ECD0
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r15,rax
       jmp       near ptr 000000000000C897
       mov       rdx,[rbp+0FF60]
       mov       rcx,offset MT_System.IDisposable
       call      0000000000007438
       test      rax,rax
       je        short 000000000000CA1A
       mov       rcx,rax
       mov       r11,7FF82EEC0528
       call      qword ptr [528]
       mov       rax,r14
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       cmp       [r15],r15d
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp+0FF88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      0000000000001840
       cmp       dword ptr [rbp+0FF98],0
       jne       short 000000000000CA69
       mov       rcx,2D020112F08
       mov       r15,[rcx]
       jmp       short 000000000000CAB7
       cmp       dword ptr [rbp+0FF98],1
       jne       short 000000000000CA96
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      000000000000B460
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp+0FF90]
       xor       edx,edx
       call      0000000000008190
       jmp       short 000000000000CAB7
       lea       rdx,[rbp+0FF88]
       mov       r8d,[rbp+0FF98]
       mov       rcx,offset MD_System.Array.Resize(!!0[] ByRef, Int32)
       call      0000000000001B60
       mov       ecx,[rbp+0FF98]
       mov       [rbp+0FF9C],ecx
       mov       r15,[rbp+0FF88]
       mov       rcx,2D020113020
       mov       r12,[rcx]
       cmp       dword ptr [rsi+8],0
       jle       near ptr 000000000000CB8B
       xor       ecx,ecx
       mov       [rbp+0FFA0],rcx
       mov       rcx,2D020112EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [0AB80]
       lea       r8,[rbp+0FFA0]
       mov       [rbp+0FFA8],rax
       test      rax,rax
       jne       short 000000000000CAFF
       xor       ecx,ecx
       xor       edx,edx
       jmp       short 000000000000CB06
       lea       rcx,[rax+10]
       mov       edx,[rax+8]
       add       r8,18
       mov       [r8],rcx
       mov       [r8+8],edx
       xor       r8d,r8d
       mov       [rbp+0FFB0],r8d
       mov       byte ptr [rbp+0FFB4],0
       cmp       byte ptr [rbp+0FFB4],0
       jne       short 000000000000CB65
       mov       r8d,[rbp+0FFB0]
       cmp       r8d,[rbp+0FFC0]
       ja        near ptr 000000000000CE6B
       mov       rcx,[rbp+0FFB8]
       mov       edx,[rbp+0FFC0]
       sub       edx,r8d
       mov       r8d,r8d
       lea       rcx,[rcx+r8*2]
       mov       r8d,[rsi+8]
       cmp       r8d,edx
       ja        short 000000000000CB65
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      000000000000E808
       mov       ecx,[rbp+0FFB0]
       add       ecx,[rsi+8]
       mov       [rbp+0FFB0],ecx
       jmp       short 000000000000CB71
       lea       rcx,[rbp+0FFA0]
       mov       rdx,rsi
       call      00000000000025F8
       lea       rcx,[rbp+0FFA0]
       mov       edx,2E
       call      000000000000C268
       lea       rcx,[rbp+0FFA0]
       call      0000000000002598
       mov       r12,rax
       xor       esi,esi
       cmp       dword ptr [r15+8],0
       jle       near ptr 000000000000CE05
       cmp       esi,[r15+8]
       jae       near ptr 000000000000CE8D
       movsxd    rcx,esi
       mov       r13,[r15+rcx*8+10]
       mov       rcx,r13
       mov       rdx,rdi
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       mov       [rbp+0FF58],rax
       test      bl,bl
       je        near ptr 000000000000CCD0
       test      rax,rax
       je        near ptr 000000000000CDF6
       call      000000000000E4D0
       mov       [rbp+0FF50],rax
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,r12
       xor       edx,edx
       mov       r8,2D020111388
       mov       r8,[r8]
       mov       r13,[rbp+0FF50]
       mov       r9,2D020123A30
       mov       r9,[r9]
       mov       [rbp+0FF68],rcx
       mov       [rbp+0FF70],rax
       mov       [rbp+0FF78],rdx
       mov       [rbp+0FF80],r8
       mov       rcx,r13
       mov       rdx,r9
       lea       r8,[rbp+0FF68]
       call      0000000000008838
       mov       rdx,rax
       mov       rcx,[rbp+0FF58]
       mov       r8d,1
       call      000000000000E9D8
       mov       r13,rax
       test      r14,r14
       je        near ptr 000000000000CE71
       test      r13,r13
       je        near ptr 000000000000CE7C
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      0000000000007440
       test      rax,rax
       jne       short 000000000000CCD5
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      000000000000B2D0
       mov       [rbp+0FF40],rax
       call      0000000000001870
       mov       r8,[rbp+0FF40]
       mov       [r8+8],eax
       mov       [rbp+0FF40],r8
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      000000000000AEB0
       mov       r14,[rbp+0FF40]
       lea       rcx,[r14+30]
       mov       rdx,r13
       call      000000000000AEB0
       jmp       short 000000000000CCE8
       jmp       near ptr 000000000000CBD6
       mov       rcx,rax
       mov       rdx,r13
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       mov       rcx,7FF82F3467E8
       mov       edx,5A
       call      000000000000B4B0
       mov       rcx,2D02011CFA8
       mov       r13,[rcx]
       test      r13,r13
       jne       short 000000000000CD5F
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       r13,rax
       mov       rdx,2D02011CF88
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr 000000000000CE87
       lea       rcx,[r13+8]
       call      000000000000AEB0
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r13+18],rdx
       mov       rcx,2D02011CFA8
       mov       rdx,r13
       call      000000000000B010
       mov       rcx,2D02011CFB0
       mov       r9,[rcx]
       test      r9,r9
       jne       short 000000000000CDD7
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       r9,rax
       mov       [rbp+0FF48],r9
       mov       rdx,2D02011CF88
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr 000000000000CE87
       lea       rcx,[r9+8]
       call      000000000000AEB0
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp+0FF48]
       mov       [r9+18],rdx
       mov       rcx,2D02011CFB0
       mov       rdx,r9
       call      000000000000B010
       mov       r9,[rbp+0FF48]
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,r13
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      000000000000C4A8
       mov       r14,rax
       add       esi,1
       jo        short 000000000000CE1C
       cmp       [r15+8],esi
       jg        near ptr 000000000000CB98
       mov       rax,r14
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       call      000000000000ECD0
       mov       ecx,4D
       mov       rdx,7FF82F346048
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,7C7
       mov       rdx,7FF82F346048
       call      0000000000000390
       mov       rdi,rax
       call      0000000000001940
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      00000000000009F8
       mov       rcx,rax
       call      0000000000001A18
       int       3
       call      0000000000009580
       int       3
       mov       ecx,4
       call      000000000000B010
       int       3
       mov       ecx,0E
       call      000000000000B010
       int       3
       call      0000000000007270
       int       3
       call      000000000000F130
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
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+100]
       mov       rdx,[rbp+0FF60]
       mov       rcx,offset MT_System.IDisposable
       call      0000000000007438
       test      rax,rax
       je        short 000000000000CEE1
       mov       rcx,rax
       mov       r11,7FF82EEC0528
       call      qword ptr [528]
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
; Total bytes of code 2227
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary02()
; 			var person = this._personProper;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToDictionary(ignoreNulls: false);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0C0]
       mov       rdx,22417402028
       mov       rdx,[rdx]
       xor       r8d,r8d
       call      qword ptr [1780]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp+0FF58],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short 000000000000AED2
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF20],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       r14,rax
       mov       rcx,[r14+18]
       call      qword ptr [5DC8]
       test      rax,rax
       je        short 000000000000AF2B
       lea       rcx,[r14+18]
       mov       rdx,rax
       call      0000000000000010
       mov       rax,rsi
       test      rax,rax
       jne       near ptr 000000000000B0A8
       call      qword ptr [9B28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       r14,rax
       cmp       dword ptr [r14+8],3
       jl        near ptr 000000000000B7A8
       lea       rcx,[r14+0C]
       mov       rdx,22417411CD0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[r14+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 000000000000B7CB
       lea       rcx,[r14+12]
       mov       rdx,22417402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000AFC9
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 000000000000AFCE
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000B069
       call      qword ptr [9C48]
       mov       r14,rax
       mov       ecx,9
       mov       rdx,7FF82EF80000
       call      000000000000F510
       mov       r15,rax
       mov       ecx,36B
       mov       rdx,7FF82EF80000
       call      000000000000F510
       mov       rcx,rax
       mov       r9,r15
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5270]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [9870]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [9D08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
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
       mov       r15,rax
       mov       rcx,2241740BF18
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [52E8]
       test      rax,rax
       je        short 000000000000B107
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       mov       rcx,r14
       mov       rdx,rdi
       mov       r9d,2
       call      qword ptr [5318]
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       mov       rcx,r15
       call      qword ptr [7F30]
       test      eax,eax
       je        near ptr 000000000000B3BB
       xor       r15d,r15d
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [5888]
       mov       rcx,rax
       mov       r11,7FF82E9C0628
       call      qword ptr [r11]
       mov       [rbp+0FF50],rax
       mov       rcx,rax
       mov       r11,7FF82E9C0630
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr 000000000000B378
       mov       rcx,[rbp+0FF50]
       mov       r11,7FF82E9C0638
       call      qword ptr [r11]
       mov       rsi,rax
       mov       ecx,r15d
       add       ecx,1
       jo        near ptr 000000000000B35B
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      000000000000EFB0
       mov       r12,rax
       call      qword ptr [0F9F0]
       mov       rcx,rax
       mov       [r12+8],r15d
       mov       [rbp+0FF90],rdi
       mov       [rbp+0FF98],r12
       lea       rdx,[rbp+0FF90]
       mov       r8,2241B400AB0
       mov       r8,[r8]
       mov       [rbp+0FF58],rdx
       mov       dword ptr [rbp+0FF60],2
       mov       rdx,r8
       lea       r8,[rbp+0FF58]
       call      qword ptr [0BDC8]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [1780]
       mov       rsi,rax
       test      r14,r14
       je        near ptr 000000000000B360
       test      rsi,rsi
       je        near ptr 000000000000B36C
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [5828]
       test      rax,rax
       jne       short 000000000000B250
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      000000000000EFB0
       mov       r15,rax
       call      0000000000004EA0
       mov       [r15+8],eax
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      0000000000000010
       lea       rcx,[r15+30]
       mov       rdx,rsi
       call      0000000000000010
       jmp       short 000000000000B263
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r15,rax
       mov       rcx,2241740C1B8
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short 000000000000B2BD
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rsi,rax
       mov       rdx,2241740C1A8
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      0000000000000010
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rsi+18],rdx
       mov       rcx,2241740C1B8
       mov       rdx,rsi
       call      0000000000000010
       mov       rcx,2241740C1C0
       mov       r9,[rcx]
       test      r9,r9
       jne       short 000000000000B31A
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       r14,rax
       mov       rdx,2241740C1A8
       mov       rdx,[rdx]
       lea       rcx,[r14+8]
       call      0000000000000010
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rdx
       mov       rcx,2241740C1C0
       mov       rdx,r14
       call      0000000000000010
       mov       r9,r14
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      qword ptr [97C8]
       mov       r14,rax
       mov       rcx,[rbp+0FF50]
       mov       r11,7FF82E9C0630
       call      qword ptr [r11]
       test      eax,eax
       mov       r15d,ebx
       jne       near ptr 000000000000B15D
       jmp       short 000000000000B378
       call      0000000000002090
       mov       ecx,4
       call      qword ptr [0B780]
       int       3
       mov       ecx,0E
       call      qword ptr [0B780]
       int       3
       mov       rdx,[rbp+0FF50]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [5810]
       test      rax,rax
       je        short 000000000000B3A4
       mov       rcx,rax
       mov       r11,7FF82E9C0640
       call      qword ptr [r11]
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp+0FF78]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7318]
       cmp       dword ptr [rbp+0FF88],0
       je        near ptr 000000000000B77F
       cmp       dword ptr [rbp+0FF88],1
       jne       near ptr 000000000000B73A
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      000000000000F130
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp+0FF80]
       xor       edx,edx
       call      0000000000000020
       mov       rcx,22417402028
       mov       r12,[rcx]
       cmp       dword ptr [rdi+8],0
       jle       near ptr 000000000000B4E4
       xor       ecx,ecx
       mov       [rbp+0FFA0],rcx
       mov       rcx,22417401F40
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [3F18]
       lea       r13,[rbp+0FFA0]
       mov       [rbp+0FFA8],rax
       test      rax,rax
       je        near ptr 000000000000B7EE
       lea       r9,[rax+10]
       mov       eax,[rax+8]
       add       r13,18
       mov       [r13],r9
       mov       [r13+8],eax
       xor       r8d,r8d
       mov       [rbp+0FFB0],r8d
       mov       byte ptr [rbp+0FFB4],0
       cmp       byte ptr [rbp+0FFB4],0
       jne       near ptr 000000000000B791
       mov       r8d,[rbp+0FFB0]
       cmp       r8d,[rbp+0FFC0]
       ja        near ptr 000000000000B7F8
       mov       rcx,[rbp+0FFB8]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp+0FFC0]
       sub       edx,r8d
       cmp       [rdi+8],edx
       ja        near ptr 000000000000B791
       lea       rdx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8,r8
       call      qword ptr [5810]
       mov       ecx,[rbp+0FFB0]
       add       ecx,[rdi+8]
       mov       [rbp+0FFB0],ecx
       lea       rcx,[rbp+0FFA0]
       mov       edx,2E
       call      qword ptr [9138]
       lea       rcx,[rbp+0FFA0]
       call      qword ptr [7300]
       mov       r12,rax
       xor       edi,edi
       cmp       dword ptr [r15+8],0
       jle       near ptr 000000000000B71E
       mov       ecx,edi
       mov       r13,[r15+rcx*8+10]
       mov       rcx,r13
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       mov       [rbp+0FF48],rax
       test      bl,bl
       je        near ptr 000000000000B735
       test      rax,rax
       je        near ptr 000000000000B70B
       call      qword ptr [0F9F0]
       mov       [rbp+0FF40],rax
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp+0FF68],r12
       mov       [rbp+0FF70],rax
       lea       rcx,[rbp+0FF68]
       mov       r13,[rbp+0FF48]
       mov       rdx,[rbp+0FF40]
       mov       r8,2241B400AB8
       mov       r8,[r8]
       mov       [rbp+0FF58],rcx
       mov       dword ptr [rbp+0FF60],2
       mov       rcx,rdx
       mov       rdx,r8
       lea       r8,[rbp+0FF58]
       call      qword ptr [0BDC8]
       mov       rdx,rax
       mov       rcx,r13
       mov       r8d,1
       call      qword ptr [1780]
       mov       r13,rax
       test      r14,r14
       je        near ptr 000000000000B7FF
       test      r13,r13
       je        near ptr 000000000000B80B
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [5828]
       test      rax,rax
       jne       near ptr 000000000000B767
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      000000000000EFB0
       mov       [rbp+0FF30],rax
       call      0000000000004EA0
       mov       r8,[rbp+0FF30]
       mov       [r8+8],eax
       mov       [rbp+0FF30],r8
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      0000000000000010
       mov       r14,[rbp+0FF30]
       lea       rcx,[r14+30]
       mov       rdx,r13
       call      0000000000000010
       mov       rcx,2241740C1C8
       mov       r13,[rcx]
       test      r13,r13
       jne       short 000000000000B67C
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       r13,rax
       mov       rdx,2241740C1A8
       mov       rdx,[rdx]
       lea       rcx,[r13+8]
       call      0000000000000010
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r13+18],rdx
       mov       rcx,2241740C1C8
       mov       rdx,r13
       call      0000000000000010
       mov       rcx,2241740C1D0
       mov       r9,[rcx]
       test      r9,r9
       jne       short 000000000000B6EB
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       r9,rax
       mov       [rbp+0FF38],r9
       mov       rdx,2241740C1A8
       mov       rdx,[rdx]
       lea       rcx,[r9+8]
       call      0000000000000010
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp+0FF38]
       mov       [r9+18],rdx
       mov       rcx,2241740C1D0
       mov       rdx,r9
       call      0000000000000010
       mov       r9,[rbp+0FF38]
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,r13
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      qword ptr [97C8]
       mov       r14,rax
       add       edi,1
       jo        near ptr 000000000000B7A3
       cmp       [r15+8],edi
       jg        near ptr 000000000000B4F1
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       jmp       near ptr 000000000000B524
       lea       rdx,[rbp+0FF78]
       mov       r8d,[rbp+0FF88]
       mov       rcx,offset MD_System.Array.Resize(!!0[] ByRef, Int32)
       call      qword ptr [0D438]
       mov       ecx,[rbp+0FF88]
       mov       [rbp+0FF8C],ecx
       mov       r15,[rbp+0FF78]
       jmp       near ptr 000000000000B418
       mov       rcx,rax
       mov       rdx,r13
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr 000000000000B622
       mov       rcx,22417401F88
       mov       r15,[rcx]
       jmp       near ptr 000000000000B418
       lea       rcx,[rbp+0FFA0]
       mov       rdx,rdi
       call      qword ptr [7420]
       jmp       near ptr 000000000000B4C8
       call      0000000000002090
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
       xor       r9d,r9d
       xor       eax,eax
       jmp       near ptr 000000000000B465
       call      qword ptr [7048]
       int       3
       mov       ecx,4
       call      qword ptr [0B780]
       int       3
       mov       ecx,0E
       call      qword ptr [0B780]
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
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+110]
       mov       rdx,[rbp+0FF50]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [5810]
       test      rax,rax
       je        short 000000000000B863
       mov       rcx,rax
       mov       r11,7FF82E9C0640
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
; Total bytes of code 2517
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary05()
; 			var person = this._personRecord;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToDictionary(ignoreNulls: true);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0C8]
       mov       rdx,1DF85143020
       mov       rdx,[rdx]
       mov       r8d,1
       call      000000000000E9D8
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       lea       rbp,[rsp+100]
       xor       eax,eax
       mov       [rbp+0FF68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF70],xmm4
       vmovdqa   xmmword ptr [rbp+0FF80],xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF30],rsp
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      0000000000009D38
       mov       rcx,rdi
       test      rcx,rcx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000CF41
       mov       rcx,rdi
       call      000000000000F570
       mov       r15,rax
       mov       rcx,7FF82F310828
       mov       edx,2C
       call      000000000000B4B0
       mov       rcx,1DF8514CCF8
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      0000000000009E18
       test      rax,rax
       je        short 000000000000C85E
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      0000000000009E28
       mov       rax,r14
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       mov       rcx,r15
       call      000000000000B6A8
       test      eax,eax
       je        near ptr 000000000000CB51
       xor       r15d,r15d
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      0000000000007460
       mov       rcx,rax
       mov       r11,7FF82EE90510
       call      qword ptr [510]
       mov       [rbp+0FF60],rax
       mov       rcx,rax
       mov       r11,7FF82EE90518
       call      qword ptr [518]
       test      eax,eax
       je        near ptr 000000000000CB0C
       mov       rcx,[rbp+0FF60]
       mov       r11,7FF82EE90520
       call      qword ptr [520]
       mov       rdi,rax
       mov       ecx,r15d
       add       ecx,1
       jo        near ptr 000000000000CAEF
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      000000000000B2D0
       mov       r12,rax
       call      000000000000E4D0
       mov       rcx,rax
       mov       [r12+8],r15d
       xor       edx,edx
       mov       r8,1DF85141388
       mov       r8,[r8]
       mov       rax,1DF85154228
       mov       rax,[rax]
       mov       [rbp+0FF68],rsi
       mov       [rbp+0FF70],r12
       mov       [rbp+0FF78],rdx
       mov       [rbp+0FF80],r8
       mov       rdx,rax
       lea       r8,[rbp+0FF68]
       call      0000000000008838
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      000000000000E9D8
       mov       rdi,rax
       test      r14,r14
       je        near ptr 000000000000CAE4
       test      rdi,rdi
       je        near ptr 000000000000CAD9
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      0000000000007440
       test      rax,rax
       jne       near ptr 000000000000CAF4
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      000000000000B2D0
       mov       r15,rax
       call      0000000000001870
       mov       [r15+8],eax
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      000000000000AEB0
       lea       rcx,[r15+30]
       mov       rdx,rdi
       call      000000000000AEB0
       mov       rcx,7FF82F3167E8
       mov       edx,5A
       call      000000000000B4B0
       mov       rcx,1DF8514CF98
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short 000000000000CA2E
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rdi,rax
       mov       rdx,1DF8514CF88
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr 000000000000CAD3
       lea       rcx,[rdi+8]
       call      000000000000AEB0
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],rdx
       mov       rcx,1DF8514CF98
       mov       rdx,rdi
       call      000000000000B010
       mov       rcx,1DF8514CFA0
       mov       r9,[rcx]
       test      r9,r9
       jne       short 000000000000CA90
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       r14,rax
       mov       rdx,1DF8514CF88
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short 000000000000CAD3
       lea       rcx,[r14+8]
       call      000000000000AEB0
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rdx
       mov       rcx,1DF8514CFA0
       mov       rdx,r14
       call      000000000000B010
       mov       r9,r14
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      000000000000C4B8
       mov       r14,rax
       mov       rcx,[rbp+0FF60]
       mov       r11,7FF82EE90518
       call      qword ptr [518]
       test      eax,eax
       mov       r15d,ebx
       jne       near ptr 000000000000C8B8
       jmp       short 000000000000CB0C
       call      0000000000007270
       int       3
       mov       ecx,0E
       call      000000000000B010
       int       3
       mov       ecx,4
       call      000000000000B010
       int       3
       call      000000000000ECD0
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r15,rax
       jmp       near ptr 000000000000C9B7
       mov       rdx,[rbp+0FF60]
       mov       rcx,offset MT_System.IDisposable
       call      0000000000007438
       test      rax,rax
       je        short 000000000000CB3A
       mov       rcx,rax
       mov       r11,7FF82EE90528
       call      qword ptr [528]
       mov       rax,r14
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       cmp       [r15],r15d
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp+0FF88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      0000000000001840
       cmp       dword ptr [rbp+0FF98],0
       jne       short 000000000000CB89
       mov       rcx,1DF85142F08
       mov       r15,[rcx]
       jmp       short 000000000000CBD7
       cmp       dword ptr [rbp+0FF98],1
       jne       short 000000000000CBB6
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      000000000000B460
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp+0FF90]
       xor       edx,edx
       call      0000000000008190
       jmp       short 000000000000CBD7
       lea       rdx,[rbp+0FF88]
       mov       r8d,[rbp+0FF98]
       mov       rcx,offset MD_System.Array.Resize(!!0[] ByRef, Int32)
       call      0000000000001B60
       mov       ecx,[rbp+0FF98]
       mov       [rbp+0FF9C],ecx
       mov       r15,[rbp+0FF88]
       mov       rcx,1DF85143020
       mov       r12,[rcx]
       cmp       dword ptr [rsi+8],0
       jle       near ptr 000000000000CCAB
       xor       ecx,ecx
       mov       [rbp+0FFA0],rcx
       mov       rcx,1DF85142EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [0AB80]
       lea       r8,[rbp+0FFA0]
       mov       [rbp+0FFA8],rax
       test      rax,rax
       jne       short 000000000000CC1F
       xor       ecx,ecx
       xor       edx,edx
       jmp       short 000000000000CC26
       lea       rcx,[rax+10]
       mov       edx,[rax+8]
       add       r8,18
       mov       [r8],rcx
       mov       [r8+8],edx
       xor       r8d,r8d
       mov       [rbp+0FFB0],r8d
       mov       byte ptr [rbp+0FFB4],0
       cmp       byte ptr [rbp+0FFB4],0
       jne       short 000000000000CC85
       mov       r8d,[rbp+0FFB0]
       cmp       r8d,[rbp+0FFC0]
       ja        near ptr 000000000000CF8B
       mov       rcx,[rbp+0FFB8]
       mov       edx,[rbp+0FFC0]
       sub       edx,r8d
       mov       r8d,r8d
       lea       rcx,[rcx+r8*2]
       mov       r8d,[rsi+8]
       cmp       r8d,edx
       ja        short 000000000000CC85
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      000000000000E808
       mov       ecx,[rbp+0FFB0]
       add       ecx,[rsi+8]
       mov       [rbp+0FFB0],ecx
       jmp       short 000000000000CC91
       lea       rcx,[rbp+0FFA0]
       mov       rdx,rsi
       call      00000000000025F8
       lea       rcx,[rbp+0FFA0]
       mov       edx,2E
       call      000000000000B778
       lea       rcx,[rbp+0FFA0]
       call      0000000000002598
       mov       r12,rax
       xor       esi,esi
       cmp       dword ptr [r15+8],0
       jle       near ptr 000000000000CF25
       cmp       esi,[r15+8]
       jae       near ptr 000000000000CFAD
       movsxd    rcx,esi
       mov       r13,[r15+rcx*8+10]
       mov       rcx,r13
       mov       rdx,rdi
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       mov       [rbp+0FF58],rax
       test      bl,bl
       je        near ptr 000000000000CDF0
       test      rax,rax
       je        near ptr 000000000000CF16
       call      000000000000E4D0
       mov       [rbp+0FF50],rax
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,r12
       xor       edx,edx
       mov       r8,1DF85141388
       mov       r8,[r8]
       mov       r13,[rbp+0FF50]
       mov       r9,1DF85154230
       mov       r9,[r9]
       mov       [rbp+0FF68],rcx
       mov       [rbp+0FF70],rax
       mov       [rbp+0FF78],rdx
       mov       [rbp+0FF80],r8
       mov       rcx,r13
       mov       rdx,r9
       lea       r8,[rbp+0FF68]
       call      0000000000008838
       mov       rdx,rax
       mov       rcx,[rbp+0FF58]
       mov       r8d,1
       call      000000000000E9D8
       mov       r13,rax
       test      r14,r14
       je        near ptr 000000000000CF91
       test      r13,r13
       je        near ptr 000000000000CF9C
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      0000000000007440
       test      rax,rax
       jne       short 000000000000CDF5
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      000000000000B2D0
       mov       [rbp+0FF40],rax
       call      0000000000001870
       mov       r8,[rbp+0FF40]
       mov       [r8+8],eax
       mov       [rbp+0FF40],r8
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      000000000000AEB0
       mov       r14,[rbp+0FF40]
       lea       rcx,[r14+30]
       mov       rdx,r13
       call      000000000000AEB0
       jmp       short 000000000000CE08
       jmp       near ptr 000000000000CCF6
       mov       rcx,rax
       mov       rdx,r13
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       mov       rcx,7FF82F3167E8
       mov       edx,5A
       call      000000000000B4B0
       mov       rcx,1DF8514CFA8
       mov       r13,[rcx]
       test      r13,r13
       jne       short 000000000000CE7F
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       r13,rax
       mov       rdx,1DF8514CF88
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr 000000000000CFA7
       lea       rcx,[r13+8]
       call      000000000000AEB0
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r13+18],rdx
       mov       rcx,1DF8514CFA8
       mov       rdx,r13
       call      000000000000B010
       mov       rcx,1DF8514CFB0
       mov       r9,[rcx]
       test      r9,r9
       jne       short 000000000000CEF7
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       r9,rax
       mov       [rbp+0FF48],r9
       mov       rdx,1DF8514CF88
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr 000000000000CFA7
       lea       rcx,[r9+8]
       call      000000000000AEB0
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp+0FF48]
       mov       [r9+18],rdx
       mov       rcx,1DF8514CFB0
       mov       rdx,r9
       call      000000000000B010
       mov       r9,[rbp+0FF48]
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,r13
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      000000000000C4B8
       mov       r14,rax
       add       esi,1
       jo        short 000000000000CF3C
       cmp       [r15+8],esi
       jg        near ptr 000000000000CCB8
       mov       rax,r14
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       call      000000000000ECD0
       mov       ecx,4D
       mov       rdx,7FF82F316048
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,7C7
       mov       rdx,7FF82F316048
       call      0000000000000390
       mov       rdi,rax
       call      0000000000001940
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      00000000000009F8
       mov       rcx,rax
       call      0000000000001A18
       int       3
       call      0000000000009580
       int       3
       mov       ecx,4
       call      000000000000B010
       int       3
       mov       ecx,0E
       call      000000000000B010
       int       3
       call      0000000000007270
       int       3
       call      000000000000F130
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
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+100]
       mov       rdx,[rbp+0FF60]
       mov       rcx,offset MT_System.IDisposable
       call      0000000000007438
       test      rax,rax
       je        short 000000000000D001
       mov       rcx,rax
       mov       r11,7FF82EE90528
       call      qword ptr [528]
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
; Total bytes of code 2227
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary05()
; 			var person = this._personRecord;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToDictionary(ignoreNulls: true);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0C8]
       mov       rdx,21662802028
       mov       rdx,[rdx]
       mov       r8d,1
       call      qword ptr [1780]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp+0FF58],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short 000000000000B1F2
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF20],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       r14,rax
       mov       rcx,[r14+18]
       call      qword ptr [5DC8]
       test      rax,rax
       je        short 000000000000B24B
       lea       rcx,[r14+18]
       mov       rdx,rax
       call      0000000000000010
       mov       rax,rsi
       test      rax,rax
       jne       near ptr 000000000000B3C8
       call      qword ptr [9B28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       r14,rax
       cmp       dword ptr [r14+8],3
       jl        near ptr 000000000000BAC8
       lea       rcx,[r14+0C]
       mov       rdx,21662804988
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[r14+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 000000000000BAEB
       lea       rcx,[r14+12]
       mov       rdx,21662802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000B2E9
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 000000000000B2EE
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000B389
       call      qword ptr [9C48]
       mov       r14,rax
       mov       ecx,9
       mov       rdx,7FF82EF70000
       call      000000000000F510
       mov       r15,rax
       mov       ecx,36B
       mov       rdx,7FF82EF70000
       call      000000000000F510
       mov       rcx,rax
       mov       r9,r15
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5270]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [9870]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [9D08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
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
       mov       r15,rax
       mov       rcx,21666802760
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [52E8]
       test      rax,rax
       je        short 000000000000B427
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       mov       rcx,r14
       mov       rdx,rdi
       mov       r9d,2
       call      qword ptr [5318]
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       mov       rcx,r15
       call      qword ptr [7F30]
       test      eax,eax
       je        near ptr 000000000000B6DB
       xor       r15d,r15d
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [5888]
       mov       rcx,rax
       mov       r11,7FF82E9B0630
       call      qword ptr [r11]
       mov       [rbp+0FF50],rax
       mov       rcx,rax
       mov       r11,7FF82E9B0638
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr 000000000000B698
       mov       rcx,[rbp+0FF50]
       mov       r11,7FF82E9B0640
       call      qword ptr [r11]
       mov       rsi,rax
       mov       ecx,r15d
       add       ecx,1
       jo        near ptr 000000000000B67B
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      000000000000EFB0
       mov       r12,rax
       call      qword ptr [0F9F0]
       mov       rcx,rax
       mov       [r12+8],r15d
       mov       [rbp+0FF90],rdi
       mov       [rbp+0FF98],r12
       lea       rdx,[rbp+0FF90]
       mov       r8,216628056D0
       mov       r8,[r8]
       mov       [rbp+0FF58],rdx
       mov       dword ptr [rbp+0FF60],2
       mov       rdx,r8
       lea       r8,[rbp+0FF58]
       call      qword ptr [0BDC8]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [1780]
       mov       rsi,rax
       test      r14,r14
       je        near ptr 000000000000B680
       test      rsi,rsi
       je        near ptr 000000000000B68C
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [5828]
       test      rax,rax
       jne       short 000000000000B570
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      000000000000EFB0
       mov       r15,rax
       call      0000000000004EA0
       mov       [r15+8],eax
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      0000000000000010
       lea       rcx,[r15+30]
       mov       rdx,rsi
       call      0000000000000010
       jmp       short 000000000000B583
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r15,rax
       mov       rcx,21666802A00
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short 000000000000B5DD
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rsi,rax
       mov       rdx,216668029F0
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      0000000000000010
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rsi+18],rdx
       mov       rcx,21666802A00
       mov       rdx,rsi
       call      0000000000000010
       mov       rcx,21666802A08
       mov       r9,[rcx]
       test      r9,r9
       jne       short 000000000000B63A
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       r14,rax
       mov       rdx,216668029F0
       mov       rdx,[rdx]
       lea       rcx,[r14+8]
       call      0000000000000010
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rdx
       mov       rcx,21666802A08
       mov       rdx,r14
       call      0000000000000010
       mov       r9,r14
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      qword ptr [9810]
       mov       r14,rax
       mov       rcx,[rbp+0FF50]
       mov       r11,7FF82E9B0638
       call      qword ptr [r11]
       test      eax,eax
       mov       r15d,ebx
       jne       near ptr 000000000000B47D
       jmp       short 000000000000B698
       call      0000000000002090
       mov       ecx,4
       call      qword ptr [0B780]
       int       3
       mov       ecx,0E
       call      qword ptr [0B780]
       int       3
       mov       rdx,[rbp+0FF50]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [5810]
       test      rax,rax
       je        short 000000000000B6C4
       mov       rcx,rax
       mov       r11,7FF82E9B0648
       call      qword ptr [r11]
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp+0FF78]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7318]
       cmp       dword ptr [rbp+0FF88],0
       je        near ptr 000000000000BA9F
       cmp       dword ptr [rbp+0FF88],1
       jne       near ptr 000000000000BA5A
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      000000000000F130
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp+0FF80]
       xor       edx,edx
       call      0000000000000020
       mov       rcx,21662802028
       mov       r12,[rcx]
       cmp       dword ptr [rdi+8],0
       jle       near ptr 000000000000B804
       xor       ecx,ecx
       mov       [rbp+0FFA0],rcx
       mov       rcx,21662801F40
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [3F18]
       lea       r13,[rbp+0FFA0]
       mov       [rbp+0FFA8],rax
       test      rax,rax
       je        near ptr 000000000000BB0E
       lea       r9,[rax+10]
       mov       eax,[rax+8]
       add       r13,18
       mov       [r13],r9
       mov       [r13+8],eax
       xor       r8d,r8d
       mov       [rbp+0FFB0],r8d
       mov       byte ptr [rbp+0FFB4],0
       cmp       byte ptr [rbp+0FFB4],0
       jne       near ptr 000000000000BAB1
       mov       r8d,[rbp+0FFB0]
       cmp       r8d,[rbp+0FFC0]
       ja        near ptr 000000000000BB18
       mov       rcx,[rbp+0FFB8]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp+0FFC0]
       sub       edx,r8d
       cmp       [rdi+8],edx
       ja        near ptr 000000000000BAB1
       lea       rdx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8,r8
       call      qword ptr [5810]
       mov       ecx,[rbp+0FFB0]
       add       ecx,[rdi+8]
       mov       [rbp+0FFB0],ecx
       lea       rcx,[rbp+0FFA0]
       mov       edx,2E
       call      qword ptr [9138]
       lea       rcx,[rbp+0FFA0]
       call      qword ptr [7300]
       mov       r12,rax
       xor       edi,edi
       cmp       dword ptr [r15+8],0
       jle       near ptr 000000000000BA3E
       mov       ecx,edi
       mov       r13,[r15+rcx*8+10]
       mov       rcx,r13
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       mov       [rbp+0FF48],rax
       test      bl,bl
       je        near ptr 000000000000BA55
       test      rax,rax
       je        near ptr 000000000000BA2B
       call      qword ptr [0F9F0]
       mov       [rbp+0FF40],rax
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp+0FF68],r12
       mov       [rbp+0FF70],rax
       lea       rcx,[rbp+0FF68]
       mov       r13,[rbp+0FF48]
       mov       rdx,[rbp+0FF40]
       mov       r8,216628056D8
       mov       r8,[r8]
       mov       [rbp+0FF58],rcx
       mov       dword ptr [rbp+0FF60],2
       mov       rcx,rdx
       mov       rdx,r8
       lea       r8,[rbp+0FF58]
       call      qword ptr [0BDC8]
       mov       rdx,rax
       mov       rcx,r13
       mov       r8d,1
       call      qword ptr [1780]
       mov       r13,rax
       test      r14,r14
       je        near ptr 000000000000BB1F
       test      r13,r13
       je        near ptr 000000000000BB2B
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [5828]
       test      rax,rax
       jne       near ptr 000000000000BA87
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      000000000000EFB0
       mov       [rbp+0FF30],rax
       call      0000000000004EA0
       mov       r8,[rbp+0FF30]
       mov       [r8+8],eax
       mov       [rbp+0FF30],r8
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      0000000000000010
       mov       r14,[rbp+0FF30]
       lea       rcx,[r14+30]
       mov       rdx,r13
       call      0000000000000010
       mov       rcx,21666802A10
       mov       r13,[rcx]
       test      r13,r13
       jne       short 000000000000B99C
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       r13,rax
       mov       rdx,216668029F0
       mov       rdx,[rdx]
       lea       rcx,[r13+8]
       call      0000000000000010
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r13+18],rdx
       mov       rcx,21666802A10
       mov       rdx,r13
       call      0000000000000010
       mov       rcx,21666802A18
       mov       r9,[rcx]
       test      r9,r9
       jne       short 000000000000BA0B
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       r9,rax
       mov       [rbp+0FF38],r9
       mov       rdx,216668029F0
       mov       rdx,[rdx]
       lea       rcx,[r9+8]
       call      0000000000000010
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp+0FF38]
       mov       [r9+18],rdx
       mov       rcx,21666802A18
       mov       rdx,r9
       call      0000000000000010
       mov       r9,[rbp+0FF38]
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,r13
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      qword ptr [9810]
       mov       r14,rax
       add       edi,1
       jo        near ptr 000000000000BAC3
       cmp       [r15+8],edi
       jg        near ptr 000000000000B811
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       jmp       near ptr 000000000000B844
       lea       rdx,[rbp+0FF78]
       mov       r8d,[rbp+0FF88]
       mov       rcx,offset MD_System.Array.Resize(!!0[] ByRef, Int32)
       call      qword ptr [0D438]
       mov       ecx,[rbp+0FF88]
       mov       [rbp+0FF8C],ecx
       mov       r15,[rbp+0FF78]
       jmp       near ptr 000000000000B738
       mov       rcx,rax
       mov       rdx,r13
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr 000000000000B942
       mov       rcx,21662801F88
       mov       r15,[rcx]
       jmp       near ptr 000000000000B738
       lea       rcx,[rbp+0FFA0]
       mov       rdx,rdi
       call      qword ptr [7420]
       jmp       near ptr 000000000000B7E8
       call      0000000000002090
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
       xor       r9d,r9d
       xor       eax,eax
       jmp       near ptr 000000000000B785
       call      qword ptr [7048]
       int       3
       mov       ecx,4
       call      qword ptr [0B780]
       int       3
       mov       ecx,0E
       call      qword ptr [0B780]
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
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+110]
       mov       rdx,[rbp+0FF50]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [5810]
       test      rax,rax
       je        short 000000000000BB83
       mov       rcx,rax
       mov       r11,7FF82E9B0648
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
; Total bytes of code 2517
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary04()
; 			var person = this._personRecord;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToDictionary(ignoreNulls: false);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0C8]
       mov       rdx,2244D643020
       mov       rdx,[rdx]
       xor       r8d,r8d
       call      000000000000E9D8
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       lea       rbp,[rsp+100]
       xor       eax,eax
       mov       [rbp+0FF68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF70],xmm4
       vmovdqa   xmmword ptr [rbp+0FF80],xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF30],rsp
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      0000000000009D38
       mov       rcx,rdi
       test      rcx,rcx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr 000000000000CF41
       mov       rcx,rdi
       call      000000000000F570
       mov       r15,rax
       mov       rcx,7FF82F310828
       mov       edx,2C
       call      000000000000B4B0
       mov       rcx,2244D64CCF8
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      0000000000009E18
       test      rax,rax
       je        short 000000000000C85E
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      0000000000009E28
       mov       rax,r14
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       mov       rcx,r15
       call      000000000000B6A8
       test      eax,eax
       je        near ptr 000000000000CB51
       xor       r15d,r15d
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      0000000000007460
       mov       rcx,rax
       mov       r11,7FF82EE90510
       call      qword ptr [510]
       mov       [rbp+0FF60],rax
       mov       rcx,rax
       mov       r11,7FF82EE90518
       call      qword ptr [518]
       test      eax,eax
       je        near ptr 000000000000CB0C
       mov       rcx,[rbp+0FF60]
       mov       r11,7FF82EE90520
       call      qword ptr [520]
       mov       rdi,rax
       mov       ecx,r15d
       add       ecx,1
       jo        near ptr 000000000000CAEF
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      000000000000B2D0
       mov       r12,rax
       call      000000000000E4D0
       mov       rcx,rax
       mov       [r12+8],r15d
       xor       edx,edx
       mov       r8,2244D641388
       mov       r8,[r8]
       mov       rax,2244D654228
       mov       rax,[rax]
       mov       [rbp+0FF68],rsi
       mov       [rbp+0FF70],r12
       mov       [rbp+0FF78],rdx
       mov       [rbp+0FF80],r8
       mov       rdx,rax
       lea       r8,[rbp+0FF68]
       call      0000000000008838
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      000000000000E9D8
       mov       rdi,rax
       test      r14,r14
       je        near ptr 000000000000CAE4
       test      rdi,rdi
       je        near ptr 000000000000CAD9
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      0000000000007440
       test      rax,rax
       jne       near ptr 000000000000CAF4
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      000000000000B2D0
       mov       r15,rax
       call      0000000000001870
       mov       [r15+8],eax
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      000000000000AEB0
       lea       rcx,[r15+30]
       mov       rdx,rdi
       call      000000000000AEB0
       mov       rcx,7FF82F3167E8
       mov       edx,5A
       call      000000000000B4B0
       mov       rcx,2244D64CF98
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short 000000000000CA2E
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       rdi,rax
       mov       rdx,2244D64CF88
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr 000000000000CAD3
       lea       rcx,[rdi+8]
       call      000000000000AEB0
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],rdx
       mov       rcx,2244D64CF98
       mov       rdx,rdi
       call      000000000000B010
       mov       rcx,2244D64CFA0
       mov       r9,[rcx]
       test      r9,r9
       jne       short 000000000000CA90
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       r14,rax
       mov       rdx,2244D64CF88
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short 000000000000CAD3
       lea       rcx,[r14+8]
       call      000000000000AEB0
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rdx
       mov       rcx,2244D64CFA0
       mov       rdx,r14
       call      000000000000B010
       mov       r9,r14
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      000000000000C4B8
       mov       r14,rax
       mov       rcx,[rbp+0FF60]
       mov       r11,7FF82EE90518
       call      qword ptr [518]
       test      eax,eax
       mov       r15d,ebx
       jne       near ptr 000000000000C8B8
       jmp       short 000000000000CB0C
       call      0000000000007270
       int       3
       mov       ecx,0E
       call      000000000000B010
       int       3
       mov       ecx,4
       call      000000000000B010
       int       3
       call      000000000000ECD0
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r15,rax
       jmp       near ptr 000000000000C9B7
       mov       rdx,[rbp+0FF60]
       mov       rcx,offset MT_System.IDisposable
       call      0000000000007438
       test      rax,rax
       je        short 000000000000CB3A
       mov       rcx,rax
       mov       r11,7FF82EE90528
       call      qword ptr [528]
       mov       rax,r14
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       cmp       [r15],r15d
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp+0FF88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      0000000000001840
       cmp       dword ptr [rbp+0FF98],0
       jne       short 000000000000CB89
       mov       rcx,2244D642F08
       mov       r15,[rcx]
       jmp       short 000000000000CBD7
       cmp       dword ptr [rbp+0FF98],1
       jne       short 000000000000CBB6
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      000000000000B460
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp+0FF90]
       xor       edx,edx
       call      0000000000008190
       jmp       short 000000000000CBD7
       lea       rdx,[rbp+0FF88]
       mov       r8d,[rbp+0FF98]
       mov       rcx,offset MD_System.Array.Resize(!!0[] ByRef, Int32)
       call      0000000000001B60
       mov       ecx,[rbp+0FF98]
       mov       [rbp+0FF9C],ecx
       mov       r15,[rbp+0FF88]
       mov       rcx,2244D643020
       mov       r12,[rcx]
       cmp       dword ptr [rsi+8],0
       jle       near ptr 000000000000CCAB
       xor       ecx,ecx
       mov       [rbp+0FFA0],rcx
       mov       rcx,2244D642EA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [0AB80]
       lea       r8,[rbp+0FFA0]
       mov       [rbp+0FFA8],rax
       test      rax,rax
       jne       short 000000000000CC1F
       xor       ecx,ecx
       xor       edx,edx
       jmp       short 000000000000CC26
       lea       rcx,[rax+10]
       mov       edx,[rax+8]
       add       r8,18
       mov       [r8],rcx
       mov       [r8+8],edx
       xor       r8d,r8d
       mov       [rbp+0FFB0],r8d
       mov       byte ptr [rbp+0FFB4],0
       cmp       byte ptr [rbp+0FFB4],0
       jne       short 000000000000CC85
       mov       r8d,[rbp+0FFB0]
       cmp       r8d,[rbp+0FFC0]
       ja        near ptr 000000000000CF8B
       mov       rcx,[rbp+0FFB8]
       mov       edx,[rbp+0FFC0]
       sub       edx,r8d
       mov       r8d,r8d
       lea       rcx,[rcx+r8*2]
       mov       r8d,[rsi+8]
       cmp       r8d,edx
       ja        short 000000000000CC85
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      000000000000E808
       mov       ecx,[rbp+0FFB0]
       add       ecx,[rsi+8]
       mov       [rbp+0FFB0],ecx
       jmp       short 000000000000CC91
       lea       rcx,[rbp+0FFA0]
       mov       rdx,rsi
       call      00000000000025F8
       lea       rcx,[rbp+0FFA0]
       mov       edx,2E
       call      000000000000B778
       lea       rcx,[rbp+0FFA0]
       call      0000000000002598
       mov       r12,rax
       xor       esi,esi
       cmp       dword ptr [r15+8],0
       jle       near ptr 000000000000CF25
       cmp       esi,[r15+8]
       jae       near ptr 000000000000CFAD
       movsxd    rcx,esi
       mov       r13,[r15+rcx*8+10]
       mov       rcx,r13
       mov       rdx,rdi
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       mov       [rbp+0FF58],rax
       test      bl,bl
       je        near ptr 000000000000CDF0
       test      rax,rax
       je        near ptr 000000000000CF16
       call      000000000000E4D0
       mov       [rbp+0FF50],rax
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,r12
       xor       edx,edx
       mov       r8,2244D641388
       mov       r8,[r8]
       mov       r13,[rbp+0FF50]
       mov       r9,2244D654230
       mov       r9,[r9]
       mov       [rbp+0FF68],rcx
       mov       [rbp+0FF70],rax
       mov       [rbp+0FF78],rdx
       mov       [rbp+0FF80],r8
       mov       rcx,r13
       mov       rdx,r9
       lea       r8,[rbp+0FF68]
       call      0000000000008838
       mov       rdx,rax
       mov       rcx,[rbp+0FF58]
       mov       r8d,1
       call      000000000000E9D8
       mov       r13,rax
       test      r14,r14
       je        near ptr 000000000000CF91
       test      r13,r13
       je        near ptr 000000000000CF9C
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      0000000000007440
       test      rax,rax
       jne       short 000000000000CDF5
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      000000000000B2D0
       mov       [rbp+0FF40],rax
       call      0000000000001870
       mov       r8,[rbp+0FF40]
       mov       [r8+8],eax
       mov       [rbp+0FF40],r8
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      000000000000AEB0
       mov       r14,[rbp+0FF40]
       lea       rcx,[r14+30]
       mov       rdx,r13
       call      000000000000AEB0
       jmp       short 000000000000CE08
       jmp       near ptr 000000000000CCF6
       mov       rcx,rax
       mov       rdx,r13
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       mov       rcx,7FF82F3167E8
       mov       edx,5A
       call      000000000000B4B0
       mov       rcx,2244D64CFA8
       mov       r13,[rcx]
       test      r13,r13
       jne       short 000000000000CE7F
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       r13,rax
       mov       rdx,2244D64CF88
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr 000000000000CFA7
       lea       rcx,[r13+8]
       call      000000000000AEB0
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r13+18],rdx
       mov       rcx,2244D64CFA8
       mov       rdx,r13
       call      000000000000B010
       mov       rcx,2244D64CFB0
       mov       r9,[rcx]
       test      r9,r9
       jne       short 000000000000CEF7
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000B2D0
       mov       r9,rax
       mov       [rbp+0FF48],r9
       mov       rdx,2244D64CF88
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr 000000000000CFA7
       lea       rcx,[r9+8]
       call      000000000000AEB0
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp+0FF48]
       mov       [r9+18],rdx
       mov       rcx,2244D64CFB0
       mov       rdx,r9
       call      000000000000B010
       mov       r9,[rbp+0FF48]
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,r13
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      000000000000C4B8
       mov       r14,rax
       add       esi,1
       jo        short 000000000000CF3C
       cmp       [r15+8],esi
       jg        near ptr 000000000000CCB8
       mov       rax,r14
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       call      000000000000ECD0
       mov       ecx,4D
       mov       rdx,7FF82F316048
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,7C7
       mov       rdx,7FF82F316048
       call      0000000000000390
       mov       rdi,rax
       call      0000000000001940
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      00000000000009F8
       mov       rcx,rax
       call      0000000000001A18
       int       3
       call      0000000000009580
       int       3
       mov       ecx,4
       call      000000000000B010
       int       3
       mov       ecx,0E
       call      000000000000B010
       int       3
       call      0000000000007270
       int       3
       call      000000000000F130
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
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+100]
       mov       rdx,[rbp+0FF60]
       mov       rcx,offset MT_System.IDisposable
       call      0000000000007438
       test      rax,rax
       je        short 000000000000D001
       mov       rcx,rax
       mov       r11,7FF82EE90528
       call      qword ptr [528]
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
; Total bytes of code 2227
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary04()
; 			var person = this._personRecord;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToDictionary(ignoreNulls: false);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0C8]
       mov       rdx,1E2B5C00030
       mov       rdx,[rdx]
       xor       r8d,r8d
       call      qword ptr [1780]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp+0FF58],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short 000000000000B1B2
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF20],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       r14,rax
       mov       rcx,[r14+18]
       call      qword ptr [5DC8]
       test      rax,rax
       je        short 000000000000B20B
       lea       rcx,[r14+18]
       mov       rdx,rax
       call      0000000000000010
       mov       rax,rsi
       test      rax,rax
       jne       near ptr 000000000000B388
       call      qword ptr [9B28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       r14,rax
       cmp       dword ptr [r14+8],3
       jl        near ptr 000000000000BA88
       lea       rcx,[r14+0C]
       mov       rdx,1E2B3C0F8C0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[r14+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 000000000000BAAB
       lea       rcx,[r14+12]
       mov       rdx,1E2B5C00098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000B2A9
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 000000000000B2AE
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000B349
       call      qword ptr [9C48]
       mov       r14,rax
       mov       ecx,9
       mov       rdx,7FF82EF80000
       call      000000000000F510
       mov       r15,rax
       mov       ecx,36B
       mov       rdx,7FF82EF80000
       call      000000000000F510
       mov       rcx,rax
       mov       r9,r15
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [5270]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [9870]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [9D08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [0FB28]
       mov       rcx,rdi
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
       mov       r15,rax
       mov       rcx,1E2B3C09B08
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [52E8]
       test      rax,rax
       je        short 000000000000B3E7
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       mov       rcx,r14
       mov       rdx,rdi
       mov       r9d,2
       call      qword ptr [5318]
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       mov       rcx,r15
       call      qword ptr [7F30]
       test      eax,eax
       je        near ptr 000000000000B69B
       xor       r15d,r15d
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [5888]
       mov       rcx,rax
       mov       r11,7FF82E9C0630
       call      qword ptr [r11]
       mov       [rbp+0FF50],rax
       mov       rcx,rax
       mov       r11,7FF82E9C0638
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr 000000000000B658
       mov       rcx,[rbp+0FF50]
       mov       r11,7FF82E9C0640
       call      qword ptr [r11]
       mov       rsi,rax
       mov       ecx,r15d
       add       ecx,1
       jo        near ptr 000000000000B63B
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      000000000000EFB0
       mov       r12,rax
       call      qword ptr [0F9F0]
       mov       rcx,rax
       mov       [r12+8],r15d
       mov       [rbp+0FF90],rdi
       mov       [rbp+0FF98],r12
       lea       rdx,[rbp+0FF90]
       mov       r8,1E2B3C10608
       mov       r8,[r8]
       mov       [rbp+0FF58],rdx
       mov       dword ptr [rbp+0FF60],2
       mov       rdx,r8
       lea       r8,[rbp+0FF58]
       call      qword ptr [0BDC8]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [1780]
       mov       rsi,rax
       test      r14,r14
       je        near ptr 000000000000B640
       test      rsi,rsi
       je        near ptr 000000000000B64C
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [5828]
       test      rax,rax
       jne       short 000000000000B530
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      000000000000EFB0
       mov       r15,rax
       call      0000000000004EA0
       mov       [r15+8],eax
       lea       rcx,[r15+28]
       mov       rdx,r14
       call      0000000000000010
       lea       rcx,[r15+30]
       mov       rdx,rsi
       call      0000000000000010
       jmp       short 000000000000B543
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r15,rax
       mov       rcx,1E2B3C09DA8
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short 000000000000B59D
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       rsi,rax
       mov       rdx,1E2B3C09D98
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      0000000000000010
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rsi+18],rdx
       mov       rcx,1E2B3C09DA8
       mov       rdx,rsi
       call      0000000000000010
       mov       rcx,1E2B3C09DB0
       mov       r9,[rcx]
       test      r9,r9
       jne       short 000000000000B5FA
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       r14,rax
       mov       rdx,1E2B3C09D98
       mov       rdx,[rdx]
       lea       rcx,[r14+8]
       call      0000000000000010
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rdx
       mov       rcx,1E2B3C09DB0
       mov       rdx,r14
       call      0000000000000010
       mov       r9,r14
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      qword ptr [9810]
       mov       r14,rax
       mov       rcx,[rbp+0FF50]
       mov       r11,7FF82E9C0638
       call      qword ptr [r11]
       test      eax,eax
       mov       r15d,ebx
       jne       near ptr 000000000000B43D
       jmp       short 000000000000B658
       call      0000000000002090
       mov       ecx,4
       call      qword ptr [0B780]
       int       3
       mov       ecx,0E
       call      qword ptr [0B780]
       int       3
       mov       rdx,[rbp+0FF50]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [5810]
       test      rax,rax
       je        short 000000000000B684
       mov       rcx,rax
       mov       r11,7FF82E9C0648
       call      qword ptr [r11]
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp+0FF78]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7318]
       cmp       dword ptr [rbp+0FF88],0
       je        near ptr 000000000000BA5F
       cmp       dword ptr [rbp+0FF88],1
       jne       near ptr 000000000000BA1A
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      000000000000F130
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp+0FF80]
       xor       edx,edx
       call      0000000000000020
       mov       rcx,1E2B5C00030
       mov       r12,[rcx]
       cmp       dword ptr [rdi+8],0
       jle       near ptr 000000000000B7C4
       xor       ecx,ecx
       mov       [rbp+0FFA0],rcx
       mov       rcx,1E2B3C01F40
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [3F18]
       lea       r13,[rbp+0FFA0]
       mov       [rbp+0FFA8],rax
       test      rax,rax
       je        near ptr 000000000000BACE
       lea       r9,[rax+10]
       mov       eax,[rax+8]
       add       r13,18
       mov       [r13],r9
       mov       [r13+8],eax
       xor       r8d,r8d
       mov       [rbp+0FFB0],r8d
       mov       byte ptr [rbp+0FFB4],0
       cmp       byte ptr [rbp+0FFB4],0
       jne       near ptr 000000000000BA71
       mov       r8d,[rbp+0FFB0]
       cmp       r8d,[rbp+0FFC0]
       ja        near ptr 000000000000BAD8
       mov       rcx,[rbp+0FFB8]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp+0FFC0]
       sub       edx,r8d
       cmp       [rdi+8],edx
       ja        near ptr 000000000000BA71
       lea       rdx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8,r8
       call      qword ptr [5810]
       mov       ecx,[rbp+0FFB0]
       add       ecx,[rdi+8]
       mov       [rbp+0FFB0],ecx
       lea       rcx,[rbp+0FFA0]
       mov       edx,2E
       call      qword ptr [9138]
       lea       rcx,[rbp+0FFA0]
       call      qword ptr [7300]
       mov       r12,rax
       xor       edi,edi
       cmp       dword ptr [r15+8],0
       jle       near ptr 000000000000B9FE
       mov       ecx,edi
       mov       r13,[r15+rcx*8+10]
       mov       rcx,r13
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       mov       [rbp+0FF48],rax
       test      bl,bl
       je        near ptr 000000000000BA15
       test      rax,rax
       je        near ptr 000000000000B9EB
       call      qword ptr [0F9F0]
       mov       [rbp+0FF40],rax
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp+0FF68],r12
       mov       [rbp+0FF70],rax
       lea       rcx,[rbp+0FF68]
       mov       r13,[rbp+0FF48]
       mov       rdx,[rbp+0FF40]
       mov       r8,1E2B3C10610
       mov       r8,[r8]
       mov       [rbp+0FF58],rcx
       mov       dword ptr [rbp+0FF60],2
       mov       rcx,rdx
       mov       rdx,r8
       lea       r8,[rbp+0FF58]
       call      qword ptr [0BDC8]
       mov       rdx,rax
       mov       rcx,r13
       mov       r8d,1
       call      qword ptr [1780]
       mov       r13,rax
       test      r14,r14
       je        near ptr 000000000000BADF
       test      r13,r13
       je        near ptr 000000000000BAEB
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [5828]
       test      rax,rax
       jne       near ptr 000000000000BA47
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      000000000000EFB0
       mov       [rbp+0FF30],rax
       call      0000000000004EA0
       mov       r8,[rbp+0FF30]
       mov       [r8+8],eax
       mov       [rbp+0FF30],r8
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      0000000000000010
       mov       r14,[rbp+0FF30]
       lea       rcx,[r14+30]
       mov       rdx,r13
       call      0000000000000010
       mov       rcx,1E2B3C09DB8
       mov       r13,[rcx]
       test      r13,r13
       jne       short 000000000000B95C
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       r13,rax
       mov       rdx,1E2B3C09D98
       mov       rdx,[rdx]
       lea       rcx,[r13+8]
       call      0000000000000010
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r13+18],rdx
       mov       rcx,1E2B3C09DB8
       mov       rdx,r13
       call      0000000000000010
       mov       rcx,1E2B3C09DC0
       mov       r9,[rcx]
       test      r9,r9
       jne       short 000000000000B9CB
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      000000000000EFB0
       mov       r9,rax
       mov       [rbp+0FF38],r9
       mov       rdx,1E2B3C09D98
       mov       rdx,[rdx]
       lea       rcx,[r9+8]
       call      0000000000000010
       mov       rdx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__11_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp+0FF38]
       mov       [r9+18],rdx
       mov       rcx,1E2B3C09DC0
       mov       rdx,r9
       call      0000000000000010
       mov       r9,[rbp+0FF38]
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,r13
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      qword ptr [9810]
       mov       r14,rax
       add       edi,1
       jo        near ptr 000000000000BA83
       cmp       [r15+8],edi
       jg        near ptr 000000000000B7D1
       mov       rax,r14
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       jmp       near ptr 000000000000B804
       lea       rdx,[rbp+0FF78]
       mov       r8d,[rbp+0FF88]
       mov       rcx,offset MD_System.Array.Resize(!!0[] ByRef, Int32)
       call      qword ptr [0D438]
       mov       ecx,[rbp+0FF88]
       mov       [rbp+0FF8C],ecx
       mov       r15,[rbp+0FF78]
       jmp       near ptr 000000000000B6F8
       mov       rcx,rax
       mov       rdx,r13
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr 000000000000B902
       mov       rcx,1E2B3C01F88
       mov       r15,[rcx]
       jmp       near ptr 000000000000B6F8
       lea       rcx,[rbp+0FFA0]
       mov       rdx,rdi
       call      qword ptr [7420]
       jmp       near ptr 000000000000B7A8
       call      0000000000002090
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
       xor       r9d,r9d
       xor       eax,eax
       jmp       near ptr 000000000000B745
       call      qword ptr [7048]
       int       3
       mov       ecx,4
       call      qword ptr [0B780]
       int       3
       mov       ecx,0E
       call      qword ptr [0B780]
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
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+110]
       mov       rdx,[rbp+0FF50]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [5810]
       test      rax,rax
       je        short 000000000000BB43
       mov       rcx,rax
       mov       r11,7FF82E9C0648
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
; Total bytes of code 2517
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString01()
; 			var person = this._personProper;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToString(ignoreNulls: true);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+0C0]
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       r9,182671015D8
       mov       r9,[r9]
       mov       rdx,18277103020
       mov       rdx,[rdx]
       mov       r8d,3A
       call      000000000000E9E0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 93
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
       jne       short 0000000000000606
       mov       rax,18277103020
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
       je        short 0000000000000658
       mov       r8,18287102AD8
       mov       rdi,[r8]
       jmp       short 000000000000066C
       cmp       byte ptr [rsp+78],0
       jne       short 000000000000066C
       mov       r8,18277103020
       mov       rdi,[r8]
       mov       ebx,[rsp+70]
       movzx     r8d,bl
       mov       rcx,rsi
       mov       rdx,rdi
       call      000000000000E9D8
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
       call      000000000000B598
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      0000000000008A58
       test      eax,eax
       jne       short 00000000000006EC
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString01()
; 			var person = this._personProper;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToString(ignoreNulls: true);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       rcx,[rsi+0C0]
       mov       rdx,1CED0802028
       mov       rdx,[rdx]
       mov       r9,1CED0809D98
       mov       r9,[r9]
       mov       r8d,3A
       call      qword ptr [1798]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 92
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
       jne       short 00000000000073B6
       mov       rax,1CED0802028
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
       je        short 000000000000740B
       mov       r8,1CED2801AC8
       mov       rdi,[r8]
       jmp       short 000000000000741F
       cmp       byte ptr [rsp+78],0
       jne       short 000000000000741F
       mov       r8,1CED0802028
       mov       rdi,[r8]
       mov       ebx,[rsp+70]
       movzx     r8d,bl
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [1780]
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
       call      qword ptr [7C30]
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [0B498]
       test      eax,eax
       jne       short 00000000000074A2
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString02()
; 			var person = this._personProper;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToString(ignoreNulls: false);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+0C0]
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       dword ptr [rsp+28],1
       mov       r9,1C7E3EC2D28
       mov       r9,[r9]
       mov       rdx,1C7E3EB3020
       mov       rdx,[rdx]
       mov       r8d,3A
       call      000000000000E9E0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 93
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
       jne       short 0000000000000506
       mov       rax,1C7E3EB3020
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
       je        short 0000000000000558
       mov       r8,1C7C3EB1AC0
       mov       rdi,[r8]
       jmp       short 000000000000056C
       cmp       byte ptr [rsp+78],0
       jne       short 000000000000056C
       mov       r8,1C7E3EB3020
       mov       rdi,[r8]
       mov       ebx,[rsp+70]
       movzx     r8d,bl
       mov       rcx,rsi
       mov       rdx,rdi
       call      000000000000E9D8
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
       call      000000000000B5A0
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      0000000000008A58
       test      eax,eax
       jne       short 00000000000005EC
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString02()
; 			var person = this._personProper;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToString(ignoreNulls: false);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],1
       mov       rcx,[rsi+0C0]
       mov       rdx,2BD9E002028
       mov       rdx,[rdx]
       mov       r9,2BDA000D928
       mov       r9,[r9]
       mov       r8d,3A
       call      qword ptr [1798]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 90
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
       jne       short 0000000000003196
       mov       rax,2BD9E002028
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
       je        short 00000000000031EB
       mov       r8,2BD9C000AB0
       mov       rdi,[r8]
       jmp       short 00000000000031FF
       cmp       byte ptr [rsp+78],0
       jne       short 00000000000031FF
       mov       r8,2BD9E002028
       mov       rdi,[r8]
       mov       ebx,[rsp+70]
       movzx     r8d,bl
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [1780]
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
       call      qword ptr [7930]
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [0B498]
       test      eax,eax
       jne       short 0000000000003282
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString03()
; 			var person = this._personRecord;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToString(ignoreNulls: true);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+0C8]
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       r9,289E53315D8
       mov       r9,[r9]
       mov       rdx,289D5333020
       mov       rdx,[rdx]
       mov       r8d,3A
       call      000000000000E9E0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 93
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
       jne       short 0000000000007786
       mov       rax,289D5333020
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
       je        short 00000000000077D8
       mov       r8,289D5344228
       mov       rdi,[r8]
       jmp       short 00000000000077EC
       cmp       byte ptr [rsp+78],0
       jne       short 00000000000077EC
       mov       r8,289D5333020
       mov       rdi,[r8]
       mov       ebx,[rsp+70]
       movzx     r8d,bl
       mov       rcx,rsi
       mov       rdx,rdi
       call      000000000000E9D8
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
       call      000000000000B5A0
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      0000000000008A58
       test      eax,eax
       jne       short 000000000000786C
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString03()
; 			var person = this._personRecord;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToString(ignoreNulls: true);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       rcx,[rsi+0C8]
       mov       rdx,2B839C02028
       mov       rdx,[rdx]
       mov       r9,2B837C0D928
       mov       r9,[r9]
       mov       r8d,3A
       call      qword ptr [1798]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 92
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
       jne       short 0000000000007E96
       mov       rax,2B839C02028
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
       je        short 0000000000007EEB
       mov       r8,2B837C0E610
       mov       rdi,[r8]
       jmp       short 0000000000007EFF
       cmp       byte ptr [rsp+78],0
       jne       short 0000000000007EFF
       mov       r8,2B839C02028
       mov       rdi,[r8]
       mov       ebx,[rsp+70]
       movzx     r8d,bl
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [1780]
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
       call      qword ptr [7C30]
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [0B498]
       test      eax,eax
       jne       short 0000000000007F82
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString04()
; 			var person = this._personRecord;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToString(ignoreNulls: false);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+0C8]
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       dword ptr [rsp+28],1
       mov       r9,1AD22C415D8
       mov       r9,[r9]
       mov       rdx,1AD32C43020
       mov       rdx,[rdx]
       mov       r8d,3A
       call      000000000000E9E0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 93
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
       jne       short 0000000000002C66
       mov       rax,1AD32C43020
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
       je        short 0000000000002CB8
       mov       r8,1AD32C53210
       mov       rdi,[r8]
       jmp       short 0000000000002CCC
       cmp       byte ptr [rsp+78],0
       jne       short 0000000000002CCC
       mov       r8,1AD32C43020
       mov       rdi,[r8]
       mov       ebx,[rsp+70]
       movzx     r8d,bl
       mov       rcx,rsi
       mov       rdx,rdi
       call      000000000000E9D8
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
       call      000000000000B5A0
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      0000000000008A58
       test      eax,eax
       jne       short 0000000000002D4C
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString04()
; 			var person = this._personRecord;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToString(ignoreNulls: false);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],1
       mov       rcx,[rsi+0C8]
       mov       rdx,2B380002028
       mov       rdx,[rdx]
       mov       r9,2B3860005E0
       mov       r9,[r9]
       mov       r8d,3A
       call      qword ptr [1798]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 90
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
       jne       short 0000000000004276
       mov       rax,2B380002028
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
       je        short 00000000000042CB
       mov       r8,2B382001AC8
       mov       rdi,[r8]
       jmp       short 00000000000042DF
       cmp       byte ptr [rsp+78],0
       jne       short 00000000000042DF
       mov       r8,2B380002028
       mov       rdi,[r8]
       mov       ebx,[rsp+70]
       movzx     r8d,bl
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [1780]
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
       call      qword ptr [7C30]
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [0B498]
       test      eax,eax
       jne       short 0000000000004362
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.StripNull()
; 			var result = this._personProper.StripNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0C0]
       test      rcx,rcx
       je        short 000000000000F99C
       call      qword ptr [36D8]
       jmp       short 000000000000F9A9
       mov       rax,189C9F93020
       mov       rax,[rax]
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.ToString()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+48]
       call      000000000000E4D0
       cmp       [rsi],esi
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.StripNull()
; 			var result = this._personProper.StripNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0C0]
       test      rcx,rcx
       je        short 000000000000710C
       call      qword ptr [19C8]
       jmp       short 0000000000007119
       mov       rax,19FFC002028
       mov       rax,[rax]
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
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.ToString()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+48]
       call      qword ptr [0F9F0]
       cmp       [rsi],sil
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 27
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.TestingForNull01()
; 			var input = new object();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.CheckForNullParamNormal(input);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Object
       call      000000000000B2D0
       mov       rdx,rax
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 48
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.TestingForNull01()
; 			var input = new object();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.CheckForNullParamNormal(input);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Object
       call      000000000000EFB0
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 46
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.TestingForNull02()
; 			var input = new object();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.CheckForNullParamSpargine(input);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Object
       call      000000000000B2D0
       mov       rdx,rax
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 48
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.TestingForNull02()
; 			var input = new object();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.CheckForNullParamSpargine(input);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Object
       call      000000000000EFB0
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+10]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 46
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson01()
; 			var result = this._personProper.ToJson();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0C0]
       call      000000000000E9F0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 45
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
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr 0000000000005B81
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      0000000000004F40
       mov       rcx,24F8A22D480
       cmp       rax,[rcx]
       jne       short 0000000000005B04
       cmp       qword ptr [rsp+28],0
       je        short 0000000000005B04
       mov       rcx,[rsp+28]
       call      000000000000F570
       mov       rsi,rax
       mov       rcx,24F8A22D350
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+85],0
       jne       short 0000000000005B25
       mov       rcx,rdi
       call      000000000000DE60
       mov       rbx,[rdi+20]
       test      rbx,rbx
       je        short 0000000000005B7D
       mov       rcx,[rbx+80]
       mov       rdx,rsi
       call      0000000000000E80
       test      eax,eax
       jne       short 0000000000005B61
       mov       r8,rbx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteStringUsingSerializer(!!0 ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      000000000000B218
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       mov       rdx,rsi
       call      000000000000DE68
       mov       rbx,rax
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       call      000000000000AEB0
       jmp       short 0000000000005B41
       xor       ecx,ecx
       jmp       short 0000000000005B35
       mov       ecx,4D
       mov       rdx,7FF82F336048
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,7C7
       mov       rdx,7FF82F336048
       call      0000000000000390
       mov       rdi,rax
       call      0000000000001940
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      00000000000009F8
       mov       rcx,rax
       call      0000000000001A18
       int       3
; Total bytes of code 283
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson01()
; 			var result = this._personProper.ToJson();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0C0]
       call      qword ptr [17C8]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
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
       jne       near ptr 000000000000CAE6
       call      qword ptr [9B28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 000000000000CB51
       lea       rcx,[rdi+0C]
       mov       rdx,2420A411CD0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 000000000000CB74
       lea       rcx,[rdi+12]
       mov       rdx,2420A402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000CA07
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 000000000000CA0C
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000CAA7
       call      qword ptr [9C48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EF90000
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EF90000
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
       mov       [rsp+28],rcx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.GetRuntimeType(!!0 ByRef)
       call      qword ptr [5B70]
       mov       rsi,rax
       mov       rcx,2420A40C990
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+85],0
       je        short 000000000000CB46
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7708]
       mov       r8,rax
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteStringUsingSerializer(!!0 ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      qword ptr [0BF48]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       call      qword ptr [7D20]
       jmp       short 000000000000CB19
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson02()
; 			var result = this._personRecord.ToJson();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0C8]
       call      000000000000E9F0
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 45
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
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr 0000000000009081
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      0000000000004F40
       mov       rcx,1CC736ED480
       cmp       rax,[rcx]
       jne       short 0000000000009004
       cmp       qword ptr [rsp+28],0
       je        short 0000000000009004
       mov       rcx,[rsp+28]
       call      000000000000F570
       mov       rsi,rax
       mov       rcx,1CC736ED350
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+85],0
       jne       short 0000000000009025
       mov       rcx,rdi
       call      000000000000DE60
       mov       rbx,[rdi+20]
       test      rbx,rbx
       je        short 000000000000907D
       mov       rcx,[rbx+80]
       mov       rdx,rsi
       call      0000000000000E80
       test      eax,eax
       jne       short 0000000000009061
       mov       r8,rbx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteStringUsingSerializer(!!0 ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      000000000000B218
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       mov       rdx,rsi
       call      000000000000DE68
       mov       rbx,rax
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       call      000000000000AEB0
       jmp       short 0000000000009041
       xor       ecx,ecx
       jmp       short 0000000000009035
       mov       ecx,4D
       mov       rdx,7FF82F306048
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,7C7
       mov       rdx,7FF82F306048
       call      0000000000000390
       mov       rdi,rax
       call      0000000000001940
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      00000000000009F8
       mov       rcx,rax
       call      0000000000001A18
       int       3
; Total bytes of code 283
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson02()
; 			var result = this._personRecord.ToJson();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0C8]
       call      qword ptr [17C8]
       mov       rdx,[rsi+20]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      0000000000000010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
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
       jne       near ptr 000000000000D6E6
       call      qword ptr [9B28]
       mov       rsi,rax
       mov       ecx,5
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr 000000000000D751
       lea       rcx,[rdi+0C]
       mov       rdx,238EB800580
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr 000000000000D774
       lea       rcx,[rdi+12]
       mov       rdx,238E7802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       test      rcx,rcx
       je        short 000000000000D607
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short 000000000000D60C
       mov       eax,1
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr 000000000000D6A7
       call      qword ptr [9C48]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FF82EF70000
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,36B
       mov       rdx,7FF82EF70000
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
       mov       [rsp+28],rcx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.GetRuntimeType(!!0 ByRef)
       call      qword ptr [5B70]
       mov       rsi,rax
       mov       rcx,238E780C990
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+85],0
       je        short 000000000000D746
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7708]
       mov       r8,rax
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteStringUsingSerializer(!!0 ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      qword ptr [0BF48]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,rdi
       call      qword ptr [7D20]
       jmp       short 000000000000D719
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.TryDispose()
; 			var disposableType = new DataTable("TEST");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			disposableType.TryDispose();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rcx,offset MT_System.Data.DataTable
       call      0000000000009B50
       mov       rsi,rax
       mov       rcx,rsi
       call      000000000000C850
       mov       rdx,2470D941AC0
       mov       rdx,[rdx]
       lea       rcx,[rsi+70]
       call      000000000000AEB0
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rsi
       jmp       near ptr 000000000000EA08
; Total bytes of code 68
```
```assembly
; System.Data.DataTable..ctor()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       mov       rdx,246ED943020
       mov       rdi,[rdx]
       lea       rcx,[rsi+70]
       mov       rdx,rdi
       call      000000000000AEB0
       lea       rcx,[rsi+80]
       mov       rdx,rdi
       call      000000000000AEB0
       mov       byte ptr [rsi+1C4],1
       mov       dword ptr [rsi+1B0],19
       mov       rdx,246ED941060
       mov       rdx,[rdx]
       vmovupd   xmm0,[rdx+8]
       vmovupd   [rsi+1D8],xmm0
       mov       rdx,246ED941060
       mov       rdx,[rdx]
       vmovupd   xmm0,[rdx+8]
       vmovupd   [rsi+1E8],xmm0
       mov       rdx,246ED942FC0
       mov       rdx,[rdx]
       lea       rcx,[rsi+0D8]
       call      000000000000AEB0
       mov       byte ptr [rsi+1CC],1
       mov       rdx,246ED942FC8
       mov       rdx,[rdx]
       lea       rcx,[rsi+110]
       call      000000000000AEB0
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataView, System.Data.Common]]
       call      000000000000B2D0
       mov       rdi,rax
       mov       rdx,246ED942FD0
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      000000000000AEB0
       lea       rcx,[rsi+180]
       mov       rdx,rdi
       call      000000000000AEB0
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataViewListener, System.Data.Common]]
       call      000000000000B2D0
       mov       rdi,rax
       mov       rdx,246ED942FD8
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      000000000000AEB0
       lea       rcx,[rsi+188]
       mov       rdx,rdi
       call      000000000000AEB0
       mov       rcx,offset MT_System.Threading.ReaderWriterLockSlim
       call      000000000000B2D0
       mov       dword ptr [rax+40],0FFFFFFFF
       mov       dword ptr [rax+44],0FFFFFFFF
       mov       byte ptr [rax+4D],1
       mov       rdx,7FF82EFC5330
       mov       ecx,1
       lock xadd [rdx],rcx
       inc       rcx
       mov       [rax+28],rcx
       lea       rcx,[rsi+198]
       mov       rdx,rax
       call      000000000000AEB0
       mov       dword ptr [rsi+1B8],0FFFFFFFF
       mov       rcx,7FF82F4A99D4
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rsi+1C0],eax
       mov       rcx,rsi
       call      0000000000004208
       mov       rcx,246ED94FCC0
       mov       rdi,[rcx]
       mov       ebx,[rsi+1C0]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr 00000000000009E7
       mov       qword ptr [rsi+1A0],1
       mov       rcx,offset MT_System.Data.RecordManager
       call      000000000000B2D0
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      000000000000D490
       lea       rcx,[rsi+50]
       mov       rdx,rbx
       call      000000000000AEB0
       call      000000000000E4D0
       lea       rcx,[rsi+90]
       mov       rdx,rax
       call      000000000000AEB0
       mov       rcx,offset MT_System.Data.DataColumnCollection
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      000000000000CF98
       lea       rcx,[rsi+30]
       mov       rdx,rdi
       call      000000000000AEB0
       mov       rcx,offset MT_System.Data.ConstraintCollection
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.ArrayList
       call      000000000000B2D0
       mov       rbx,rax
       mov       rdx,246ED942F88
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      000000000000AEB0
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      000000000000AEB0
       mov       dword ptr [rdi+28],1
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      000000000000AEB0
       lea       rcx,[rsi+38]
       mov       rdx,rdi
       call      000000000000AEB0
       mov       rcx,offset MT_System.Data.DataRowCollection
       call      000000000000B2D0
       mov       rdi,rax
       mov       rcx,offset MT_System.Data.DataRowCollection+DataRowTree
       call      000000000000B2D0
       mov       rbx,rax
       mov       dword ptr [rbx+30],2
       mov       rcx,rbx
       call      000000000000D570
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      000000000000AEB0
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      000000000000AEB0
       lea       rcx,[rsi+28]
       mov       rdx,rdi
       call      000000000000AEB0
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.Index, System.Data.Common]]
       call      000000000000B2D0
       mov       rdi,rax
       mov       rdx,246ED942FF0
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      000000000000AEB0
       lea       rcx,[rsi+58]
       mov       rdx,rdi
       call      000000000000AEB0
       mov       rcx,offset MT_System.Data.DataRowBuilder
       call      000000000000B2D0
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      000000000000AEB0
       mov       dword ptr [rdi+10],0FFFFFFFF
       lea       rcx,[rsi+178]
       mov       rdx,rdi
       call      000000000000AEB0
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,offset MT_System.Int32
       call      000000000000B2D0
       mov       [rax+8],ebx
       mov       rdx,rax
       mov       rcx,2470D941AC8
       mov       rcx,[rcx]
       call      00000000000087F8
       mov       r8,rax
       mov       rcx,rdi
       mov       edx,1
       call      000000000000FD20
       jmp       near ptr 0000000000000849
; Total bytes of code 915
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       [rbp+18],edx
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 000000000000520D
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.IAsyncDisposable
       call      0000000000007438
       test      rax,rax
       je        near ptr 00000000000052DA
       lea       rdx,[rbp+0FFE0]
       mov       rcx,rax
       mov       r11,7FF82EEC0550
       call      qword ptr [550]
       mov       rsi,[rbp+0FFE0]
       test      rsi,rsi
       jne       short 000000000000524C
       xor       edi,edi
       jmp       short 0000000000005299
       mov       rdx,rsi
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      0000000000007440
       test      rax,rax
       je        short 0000000000005274
       test      dword ptr [rax+34],200000
       setne     dil
       movzx     edi,dil
       jmp       short 0000000000005299
       mov       edx,[rbp+0FFE8]
       movsx     rdx,dx
       mov       rcx,rsi
       mov       r11,7FF82EEC0558
       call      qword ptr [558]
       cmp       eax,2
       sete      dil
       movzx     edi,dil
       test      edi,edi
       je        short 00000000000052EE
       call      000000000000F858
       mov       rsi,rax
       mov       rcx,offset MT_System.InvalidOperationException
       call      000000000000B2D0
       mov       rdi,rax
       call      00000000000018F8
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000019F0
       mov       rdx,rax
       mov       rcx,rdi
       call      0000000000008308
       mov       rcx,rdi
       call      00000000000055B0
       mov       rcx,rsi
       mov       r11,7FF82EEC0548
       call      qword ptr [548]
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp+18],0
       je        short 0000000000005315
       call      00000000000053D0
       lea       rax,[52EE]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 324
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.TryDispose()
; 			var disposableType = new DataTable("TEST");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			disposableType.TryDispose();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rcx,offset MT_System.Data.DataTable
       call      0000000000001CF0
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [9000]
       mov       rdx,15E5BC022E0
       mov       rdx,[rdx]
       lea       rcx,[rsi+70]
       call      0000000000000010
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rsi
       jmp       qword ptr [1810]
; Total bytes of code 70
```
```assembly
; System.Data.DataTable..ctor()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       rdx,15E5FC02028
       mov       rdi,[rdx]
       lea       rcx,[rsi+70]
       mov       rdx,rdi
       call      0000000000000010
       lea       rcx,[rsi+80]
       mov       rdx,rdi
       call      0000000000000010
       mov       byte ptr [rsi+1C4],1
       mov       dword ptr [rsi+1B0],19
       mov       rdx,15E5FC00068
       mov       rdx,[rdx]
       add       rdx,8
       vmovupd   xmm0,[rdx]
       vmovupd   [rsi+1D8],xmm0
       vmovupd   xmm0,[rdx]
       vmovupd   [rsi+1E8],xmm0
       mov       rdx,15E5FC10208
       mov       rdx,[rdx]
       lea       rcx,[rsi+0D8]
       call      0000000000000010
       mov       byte ptr [rsi+1CC],1
       mov       rdx,15E5FC10210
       mov       rdx,[rdx]
       lea       rcx,[rsi+110]
       call      0000000000000010
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataView, System.Data.Common]]
       call      000000000000EFB0
       mov       rdi,rax
       mov       rdx,15E5FC10218
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      0000000000000010
       lea       rcx,[rsi+180]
       mov       rdx,rdi
       call      0000000000000010
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataViewListener, System.Data.Common]]
       call      000000000000EFB0
       mov       rdi,rax
       mov       rdx,15E5FC10220
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      0000000000000010
       lea       rcx,[rsi+188]
       mov       rdx,rdi
       call      0000000000000010
       mov       rcx,offset MT_System.Threading.ReaderWriterLockSlim
       call      000000000000EFB0
       mov       dword ptr [rax+40],0FFFFFFFF
       mov       dword ptr [rax+44],0FFFFFFFF
       mov       byte ptr [rax+4D],1
       mov       rdx,7FF82EAE55C0
       mov       ecx,1
       lock xadd [rdx],rcx
       inc       rcx
       mov       [rax+28],rcx
       lea       rcx,[rsi+198]
       mov       rdx,rax
       call      0000000000000010
       mov       dword ptr [rsi+1B8],0FFFFFFFF
       mov       rcx,7FF82F1C3F60
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rsi+1C0],eax
       mov       rcx,rsi
       call      qword ptr [12E8]
       mov       rcx,15E5FC0F3D0
       mov       rcx,[rcx]
       mov       rdi,rcx
       mov       ebx,[rsi+1C0]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr 00000000000086A5
       mov       qword ptr [rsi+1A0],1
       mov       rcx,offset MT_System.Data.RecordManager
       call      000000000000EFB0
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [58B8]
       lea       rcx,[rsi+50]
       mov       rdx,rbx
       call      0000000000000010
       call      qword ptr [0F9F0]
       lea       rcx,[rsi+90]
       mov       rdx,rax
       call      0000000000000010
       mov       rcx,offset MT_System.Data.DataColumnCollection
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [1528]
       lea       rcx,[rsi+30]
       mov       rdx,rdi
       call      0000000000000010
       mov       rcx,offset MT_System.Data.ConstraintCollection
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.ArrayList
       call      000000000000EFB0
       mov       rbx,rax
       mov       rdx,15E5FC0F200
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      0000000000000010
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      0000000000000010
       mov       dword ptr [rdi+28],1
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      0000000000000010
       lea       rcx,[rsi+38]
       mov       rdx,rdi
       call      0000000000000010
       mov       rcx,offset MT_System.Data.DataRowCollection
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,offset MT_System.Data.DataRowCollection+DataRowTree
       call      000000000000EFB0
       mov       rbx,rax
       mov       dword ptr [rbx+30],2
       mov       rcx,rbx
       call      qword ptr [3648]
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      0000000000000010
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      0000000000000010
       lea       rcx,[rsi+28]
       mov       rdx,rdi
       call      0000000000000010
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.Index, System.Data.Common]]
       call      000000000000EFB0
       mov       rdi,rax
       mov       rdx,15E5FC10238
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      0000000000000010
       lea       rcx,[rsi+58]
       mov       rdx,rdi
       call      0000000000000010
       mov       rcx,offset MT_System.Data.DataRowBuilder
       call      000000000000EFB0
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      0000000000000010
       mov       dword ptr [rdi+10],0FFFFFFFF
       lea       rcx,[rsi+178]
       mov       rdx,rdi
       call      0000000000000010
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       mov       rcx,offset MT_System.Int32
       call      000000000000EFB0
       mov       [rax+8],ebx
       mov       [rsp+38],rax
       lea       r8,[rsp+38]
       mov       rdx,15E5BC022E8
       mov       rdx,[rdx]
       mov       [rsp+28],r8
       mov       dword ptr [rsp+30],1
       lea       r8,[rsp+28]
       xor       ecx,ecx
       call      qword ptr [0BDC8]
       mov       r8,rax
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [0B348]
       jmp       near ptr 0000000000008503
; Total bytes of code 958
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       [rbp+18],edx
       mov       rsi,rcx
       test      rsi,rsi
       jne       short 0000000000007EDD
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       mov       rdx,rsi
       mov       rcx,offset MT_System.IAsyncDisposable
       call      qword ptr [5810]
       test      rax,rax
       je        near ptr 0000000000007FA6
       lea       rdx,[rbp+0FFE0]
       mov       rcx,rax
       mov       r11,7FF82E9D05A8
       call      qword ptr [r11]
       mov       rsi,[rbp+0FFE0]
       test      rsi,rsi
       jne       short 0000000000007F1A
       xor       edi,edi
       jmp       short 0000000000007F61
       mov       rdx,rsi
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      qword ptr [5828]
       test      rax,rax
       je        short 0000000000007F41
       xor       edi,edi
       test      dword ptr [rax+34],200000
       setne     dil
       jmp       short 0000000000007F61
       mov       edx,[rbp+0FFE8]
       movsx     rdx,dx
       mov       rcx,rsi
       mov       r11,7FF82E9D05B0
       call      qword ptr [r11]
       xor       edi,edi
       cmp       eax,2
       sete      dil
       test      edi,edi
       je        short 0000000000007FB7
       call      qword ptr [0DDE0]
       mov       rsi,rax
       mov       rcx,offset MT_System.InvalidOperationException
       call      000000000000EFB0
       mov       rdi,rax
       call      qword ptr [9A50]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [9D08]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [0FBD0]
       mov       rcx,rdi
       call      0000000000006AD0
       mov       rcx,rsi
       mov       r11,7FF82E9D05A0
       call      qword ptr [r11]
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp+18],0
       je        short 0000000000007FDE
       call      0000000000005BB0
       lea       rax,[7FB7]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 317
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.FromJson()
; 			var result = this._peopleJson.FromJson<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0B8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson(System.String)
       call      000000000000B560
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      000000000000B010
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       test      edx,edx
       je        short 000000000000353D
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short 000000000000351A
       jmp       short 000000000000352C
       mov       rdx,7FF82F48A718
       call      0000000000004920
       mov       rdx,rax
       mov       rcx,rdx
       mov       rdx,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr 000000000000B5D8
       mov       ecx,4D
       mov       rdx,7FF82F336048
       call      0000000000000390
       mov       rsi,rax
       mov       ecx,7CF
       mov       rdx,7FF82F336048
       call      0000000000000390
       mov       rdi,rax
       call      0000000000001940
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      00000000000009F8
       mov       rcx,rax
       call      0000000000001A18
       int       3
; Total bytes of code 151
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.FromJson()
; 			var result = this._peopleJson.FromJson<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+0B8]
       test      rdx,rdx
       jne       near ptr 0000000000000A60
       call      qword ptr [9B28]
       mov       rsi,rax
       mov       ecx,6
       call      000000000000A000
       mov       rdi,rax
       cmp       dword ptr [rdi+8],4
       jl        near ptr 0000000000000A88
       lea       rcx,[rdi+0C]
       mov       rdx,25377813218
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [5810]
       mov       ecx,[rdi+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr 0000000000000AAB
       lea       rcx,[rdi+14]
       mov       rdx,25377802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [5810]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [0BC60]
       mov       rcx,rax
       call      qword ptr [9D80]
       int       3
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize(System.String)
       call      qword ptr [7C90]
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
; Total bytes of code 271
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr 000000000000A530
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr 000000000000A530
       lea       rsi,[rdx+r8]
       lea       rdi,[rcx+r8]
       cmp       r8,10
       jbe       short 000000000000A486
       cmp       r8,40
       ja        short 000000000000A4AE
       vmovupd   xmm0,[rdx]
       vmovupd   [rcx],xmm0
       cmp       r8,20
       jbe       short 000000000000A479
       vmovupd   xmm0,[rdx+10]
       vmovupd   [rcx+10],xmm0
       cmp       r8,30
       ja        near ptr 000000000000A512
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       pop       rsi
       pop       rdi
       ret
       test      r8b,18
       jne       short 000000000000A4FF
       test      r8b,4
       jne       short 000000000000A4F1
       test      r8,r8
       je        short 000000000000A483
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short 000000000000A483
       movsx     r8,word ptr [rsi+0FFFE]
       mov       [rdi+0FFFE],r8w
       jmp       short 000000000000A483
       cmp       r8,800
       ja        near ptr 000000000000A539
       mov       rax,r8
       shr       rax,6
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short 000000000000A4C2
       and       r8,3F
       cmp       r8,10
       ja        near ptr 000000000000A457
       jmp       short 000000000000A521
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rsi+0FFFC]
       mov       [rdi+0FFFC],edx
       jmp       short 000000000000A483
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rsi+0FFF8]
       mov       [rdi+0FFF8],rdx
       jmp       near ptr 000000000000A483
       vmovupd   xmm0,[rdx+20]
       vmovupd   [rcx+20],xmm0
       jmp       near ptr 000000000000A479
       vmovupd   xmm0,[rsi+0FFF0]
       vmovupd   [rdi+0FFF0],xmm0
       jmp       near ptr 000000000000A483
       cmp       rcx,rdx
       je        near ptr 000000000000A483
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
       je        short 0000000000002BC9
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short 0000000000002BC9
       test      rsi,rsi
       je        near ptr 0000000000002C63
       jmp       short 0000000000002BE5
       test      rsi,rsi
       je        short 0000000000002C49
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short 0000000000002C49
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
       je        short 0000000000002C63
       mov       r14d,ebx
       lea       ecx,[r14+rbp]
       call      000000000000A000
       mov       r15,rax
       cmp       [r15+8],ebx
       jl        short 0000000000002C73
       lea       rcx,[r15+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [5810]
       mov       r8d,[r15+8]
       sub       r8d,r14d
       cmp       r8d,ebp
       jl        short 0000000000002C96
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
       mov       rax,25377802028
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
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        short 0000000000000F8C
       mov       eax,[rdx+8]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      eax,eax
       jne       short 0000000000000F8E
       jmp       short 0000000000000F8E
       xor       ecx,ecx
       test      ecx,ecx
       jne       near ptr 0000000000001038
       call      qword ptr [9C48]
       mov       rsi,rax
       mov       ecx,5E7
       mov       rdx,7FF82EF70000
       call      000000000000F510
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF82EF70000
       call      000000000000F510
       mov       rbx,rax
       mov       ecx,36B
       mov       rdx,7FF82EF70000
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
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [0D4E0]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short 0000000000001060
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short 0000000000001075
       mov       rcx,rsi
       mov       rdx,7FF82F18E278
       call      0000000000000CA0
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7CF0]
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 298
```
**Extern method**
System.String.FastAllocateString(Int32)

