## DotNetTips.Spargine.Extensions.BenchmarkTests.GeneralBenchmark-20240130-075926
**Diff for GuidEqualsTest method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.GeneralBenchmark.GuidEqualsTest()
        push      rsi
        sub       rsp,40
        vzeroupper
        mov       rsi,rcx
        lea       rcx,[rsi+190]
        vmovupd   xmm0,[rsi+1A0]
        vmovupd   [rsp+30],xmm0
        lea       rdx,[rsp+30]
-       call      System.Guid.EqualsCore(System.Guid ByRef, System.Guid ByRef)
-       movzx     ecx,al
-       mov       [rsp+28],cl
+       call      qword ptr [7FF9ECEDD888]; System.Guid.EqualsCore(System.Guid ByRef, System.Guid ByRef)
+       mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9ED519B88]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,40
        pop       rsi
        ret
-; Total bytes of code 72
+; Total bytes of code 71
 ; System.Guid.EqualsCore(System.Guid ByRef, System.Guid ByRef)
-       mov       eax,[rcx]
-       cmp       eax,[rdx]
-       je        short M01_L01
-M01_L00:
-       xor       eax,eax
-       ret
-M01_L01:
-       mov       eax,[rcx+4]
-       cmp       eax,[rdx+4]
-       jne       short M01_L00
-       mov       eax,[rcx+8]
-       cmp       eax,[rdx+8]
-       jne       short M01_L00
-       mov       eax,[rcx+0C]
-       cmp       eax,[rdx+0C]
+       vzeroupper
+       vmovdqu   xmm0,xmmword ptr [rcx]
+       vpcmpeqb  xmm0,xmm0,[rdx]
+       vpmovmskb eax,xmm0
+       cmp       eax,0FFFF
        sete      al
        movzx     eax,al
        ret
-; Total bytes of code 38
+; Total bytes of code 27
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
