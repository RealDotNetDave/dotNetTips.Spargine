## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Extensions.GeneralBenchmark.GuidEqualsTest()
; 		this.Consumer.Consume(this._firstGuid.Equals(this._secondGuid));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       vzeroupper
       mov       rsi,[rcx+18]
       lea       rax,[rcx+1C8]
       vmovupd   xmm0,[rcx+1D8]
       vmovupd   [rsp+20],xmm0
       lea       rdx,[rsp+20]
       mov       rcx,rax
       call      System.Guid.EqualsCore(System.Guid ByRef, System.Guid ByRef)
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; System.Guid.EqualsCore(System.Guid ByRef, System.Guid ByRef)
       mov       eax,[rcx]
       cmp       eax,[rdx]
       je        short M01_L01
M01_L00:
       xor       eax,eax
       ret
M01_L01:
       mov       eax,[rcx+4]
       cmp       eax,[rdx+4]
       jne       short M01_L00
       mov       eax,[rcx+8]
       cmp       eax,[rdx+8]
       jne       short M01_L00
       mov       eax,[rcx+0C]
       cmp       eax,[rdx+0C]
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 38
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Extensions.GeneralBenchmark.GuidFastEqualsTest()
; 		this.Consumer.Consume(this._firstGuid.FastEquals(this._secondGuid));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+18]
       mov       [rsp+30],rcx
       add       rcx,1C8
       mov       rdx,[rsp+30]
       add       rdx,1D8
       call      DotNetTips.Spargine.Extensions.GuidExtensions.FastEquals(System.Guid ByRef, System.Guid ByRef)
       movzx     eax,al
       mov       [rsi+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
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

