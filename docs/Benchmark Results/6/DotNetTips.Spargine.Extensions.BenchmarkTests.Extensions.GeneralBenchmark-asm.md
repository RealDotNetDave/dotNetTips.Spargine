## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Extensions.GeneralBenchmark.GuidFastEqualsTest()
; 		var firstGuid = System.Guid.NewGuid();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var secondGuid = System.Guid.NewGuid();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.Consumer.Consume(firstGuid.FastEquals(secondGuid));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       rsi,rcx
       lea       rcx,[rsp+30]
       call      000000000000FAE0
       lea       rcx,[rsp+20]
       call      000000000000FAE0
       mov       rsi,[rsi+20]
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+20]
       call      00000000000093B8
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; System.Guid.NewGuid()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       vzeroupper
       lea       rbp,[rsp+40]
       mov       rsi,rcx
       lea       rcx,[rbp+0FFE0]
       call      0000000000001A90
       mov       edi,eax
       test      edi,edi
       jne       short 000000000000D275
       vmovupd   xmm0,[rbp+0FFE0]
       vmovupd   [rsi],xmm0
       mov       rax,rsi
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       mov       rcx,offset MT_System.Exception
       call      000000000000B2D0
       mov       rsi,rax
       mov       rcx,rsi
       call      0000000000008CF8
       mov       [rsi+74],edi
       mov       rcx,rsi
       call      00000000000055B0
       int       3
; Total bytes of code 91
```
```assembly
; DotNetTips.Spargine.Extensions.GuidExtensions.FastEquals(System.Guid ByRef, System.Guid ByRef)
       vzeroupper
       cmp       [rcx],ecx
       cmp       [rdx],edx
       vmovupd   xmm0,[rcx]
       vmovupd   xmm1,[rdx]
       vpcmpeqb  xmm0,xmm0,xmm1
       vpmovmskb eax,xmm0
       and       eax,0FFFF
       cmp       eax,0FFFF
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 40
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Extensions.GeneralBenchmark.GuidFastEqualsTest()
; 		var firstGuid = System.Guid.NewGuid();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var secondGuid = System.Guid.NewGuid();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		this.Consumer.Consume(firstGuid.FastEquals(secondGuid));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       rsi,rcx
       lea       rcx,[rsp+30]
       call      qword ptr [9A80]
       lea       rcx,[rsp+20]
       call      qword ptr [9A80]
       mov       rsi,[rsi+20]
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+20]
       call      qword ptr [3018]
       mov       [rsi+54],al
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; System.Guid.NewGuid()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       vzeroupper
       lea       rbp,[rsp+0B0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+0FF78]
       mov       rdx,r10
       call      0000000000008310
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp+0FF98],rcx
       mov       rcx,rbp
       mov       [rbp+0FFA8],rcx
       lea       rcx,[rbp+0FFB8]
       mov       rax,offset MD_Interop+Ole32.<CoCreateGuid>g____PInvoke|1_0(System.Guid*)
       mov       [rbp+0FF88],rax
       lea       rax,[0C331]
       mov       [rbp+0FFA0],rax
       lea       rax,[rbp+0FF78]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       call      qword ptr [0BCF0]
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7E8C],0
       je        short 000000000000C344
       call      qword ptr [0A378]
       mov       rcx,[rbp+0FF80]
       mov       [rdi+10],rcx
       mov       esi,eax
       test      esi,esi
       jne       short 000000000000C373
       vmovupd   xmm0,[rbp+0FFB8]
       mov       rsi,[rbp+10]
       vmovupd   [rsi],xmm0
       mov       rax,rsi
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       mov       rcx,offset MT_System.Exception
       call      000000000000EFB0
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [0FC00]
       mov       [rdi+74],esi
       mov       rcx,rdi
       call      0000000000006AD0
       int       3
; Total bytes of code 218
```
```assembly
; DotNetTips.Spargine.Extensions.GuidExtensions.FastEquals(System.Guid ByRef, System.Guid ByRef)
       vzeroupper
       cmp       [rcx],cl
       cmp       [rdx],dl
       vmovupd   xmm0,[rcx]
       vpcmpeqb  xmm0,xmm0,[rdx]
       vpmovmskb eax,xmm0
       and       eax,0FFFF
       cmp       eax,0FFFF
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 36
```

