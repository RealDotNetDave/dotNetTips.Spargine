## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.CalculatePercent01()
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+68]
       mov       rdx,[rsi+70]
       call      dotNetTips.Spargine.Core.WIPTests.CalculatePercent(System.TimeSpan, System.TimeSpan)
       mov       rax,[rsi+10]
       cmp       [rax],eax
       add       rax,18
       vmovsd    qword ptr [rax],xmm0
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
```
```assembly
; dotNetTips.Spargine.Core.WIPTests.CalculatePercent(System.TimeSpan, System.TimeSpan)
       sub       rsp,38
       vzeroupper
       vmovaps   [rsp+20],xmm6
       mov       [rsp+40],rcx
       mov       [rsp+48],rdx
       lea       rcx,[rsp+48]
       call      System.TimeSpan.get_TotalMilliseconds()
       vmovaps   xmm6,xmm0
       lea       rcx,[rsp+40]
       call      System.TimeSpan.get_TotalMilliseconds()
       vsubsd    xmm6,xmm6,xmm0
       lea       rcx,[rsp+40]
       call      System.TimeSpan.get_TotalMilliseconds()
       vmovsd    xmm1,qword ptr [7FFB36ECB9F0]
       vandps    xmm0,xmm0,xmm1
       vdivsd    xmm0,xmm6,xmm0
       vmulsd    xmm0,xmm0,qword ptr [7FFB36ECBA00]
       vmovaps   xmm6,[rsp+20]
       add       rsp,38
       ret
; Total bytes of code 96
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.CalculatePercent02()
       push      rsi
       sub       rsp,40
       vzeroupper
       vmovaps   [rsp+30],xmm6
       mov       rsi,rcx
       mov       rcx,[rsi+68]
       mov       [rsp+20],rcx
       mov       rcx,[rsi+70]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       call      System.TimeSpan.get_TotalMilliseconds()
       vmovaps   xmm6,xmm0
       lea       rcx,[rsp+20]
       call      System.TimeSpan.get_TotalMilliseconds()
       vsubsd    xmm6,xmm6,xmm0
       lea       rcx,[rsp+20]
       call      System.TimeSpan.get_TotalMilliseconds()
       vmovsd    xmm1,qword ptr [7FFB36E9B9C0]
       vandps    xmm0,xmm0,xmm1
       vdivsd    xmm0,xmm6,xmm0
       vmulsd    xmm0,xmm0,qword ptr [7FFB36E9B9D0]
       mov       rax,[rsi+10]
       cmp       [rax],eax
       add       rax,18
       vmovsd    qword ptr [rax],xmm0
       vmovaps   xmm6,[rsp+30]
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 123
```
```assembly
; System.TimeSpan.get_TotalMilliseconds()
       vzeroupper
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,qword ptr [rcx]
       vdivsd    xmm0,xmm0,[7FFB36E9B8D0]
       vucomisd  xmm0,qword ptr [7FFB36E9B8E0]
       jbe       short M01_L00
       vmovsd    xmm0,qword ptr [7FFB36E9B8F0]
       ret
M01_L00:
       vmovsd    xmm1,qword ptr [7FFB36E9B900]
       vucomisd  xmm1,xmm0
       jbe       short M01_L01
       vmovsd    xmm0,qword ptr [7FFB36E9B910]
       ret
M01_L01:
       ret
; Total bytes of code 63
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.CalculatePercent03()
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+68]
       mov       rdx,[rsi+70]
       call      dotNetTips.Spargine.Core.WIPTests.CalculatePercentNoInline(System.TimeSpan, System.TimeSpan)
       mov       rax,[rsi+10]
       cmp       [rax],eax
       add       rax,18
       vmovsd    qword ptr [rax],xmm0
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
```
```assembly
; dotNetTips.Spargine.Core.WIPTests.CalculatePercentNoInline(System.TimeSpan, System.TimeSpan)
       sub       rsp,38
       vzeroupper
       vmovaps   [rsp+20],xmm6
       mov       [rsp+40],rcx
       mov       [rsp+48],rdx
       lea       rcx,[rsp+48]
       call      System.TimeSpan.get_TotalMilliseconds()
       vmovaps   xmm6,xmm0
       lea       rcx,[rsp+40]
       call      System.TimeSpan.get_TotalMilliseconds()
       vsubsd    xmm6,xmm6,xmm0
       lea       rcx,[rsp+40]
       call      System.TimeSpan.get_TotalMilliseconds()
       vmovsd    xmm1,qword ptr [7FFB36EBB9F0]
       vandps    xmm0,xmm0,xmm1
       vdivsd    xmm0,xmm6,xmm0
       vmulsd    xmm0,xmm0,qword ptr [7FFB36EBBA00]
       vmovaps   xmm6,[rsp+20]
       add       rsp,38
       ret
; Total bytes of code 96
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.CalculatePercent04()
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+68]
       mov       rdx,[rsi+70]
       call      dotNetTips.Spargine.Core.WIPTests.CalculatePercentNoOptimization(System.TimeSpan, System.TimeSpan)
       mov       rax,[rsi+10]
       cmp       [rax],eax
       add       rax,18
       vmovsd    qword ptr [rax],xmm0
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
```
```assembly
; dotNetTips.Spargine.Core.WIPTests.CalculatePercentNoOptimization(System.TimeSpan, System.TimeSpan)
       push      rbp
       sub       rsp,40
       vzeroupper
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       lea       rcx,[rbp+18]
       call      System.TimeSpan.get_TotalMilliseconds()
       vmovsd    qword ptr [rbp+0FFF8],xmm0
       lea       rcx,[rbp+10]
       call      System.TimeSpan.get_TotalMilliseconds()
       vmovsd    xmm1,qword ptr [rbp+0FFF8]
       vsubsd    xmm0,xmm1,xmm0
       vmovsd    qword ptr [rbp+0FFF0],xmm0
       lea       rcx,[rbp+10]
       call      System.TimeSpan.get_TotalMilliseconds()
       vmovsd    qword ptr [rbp+0FFE8],xmm0
       vmovsd    xmm0,qword ptr [rbp+0FFE8]
       call      System.Math.Abs(Double)
       vmovsd    xmm1,qword ptr [rbp+0FFF0]
       vdivsd    xmm0,xmm1,xmm0
       vmulsd    xmm0,xmm0,qword ptr [7FFB36EA8D40]
       lea       rsp,[rbp]
       pop       rbp
       ret
; Total bytes of code 105
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.CalculatePercent06()
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+68]
       mov       rdx,[rsi+70]
       call      dotNetTips.Spargine.Core.WIPTests.CalculatePercentPreserveSig(System.TimeSpan, System.TimeSpan)
       mov       rax,[rsi+10]
       cmp       [rax],eax
       add       rax,18
       vmovsd    qword ptr [rax],xmm0
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
```
```assembly
; dotNetTips.Spargine.Core.WIPTests.CalculatePercentPreserveSig(System.TimeSpan, System.TimeSpan)
       sub       rsp,38
       vzeroupper
       vmovaps   [rsp+20],xmm6
       mov       [rsp+40],rcx
       mov       [rsp+48],rdx
       lea       rcx,[rsp+48]
       call      System.TimeSpan.get_TotalMilliseconds()
       vmovaps   xmm6,xmm0
       lea       rcx,[rsp+40]
       call      System.TimeSpan.get_TotalMilliseconds()
       vsubsd    xmm6,xmm6,xmm0
       lea       rcx,[rsp+40]
       call      System.TimeSpan.get_TotalMilliseconds()
       vmovsd    xmm1,qword ptr [7FFB36EBB8F0]
       vandps    xmm0,xmm0,xmm1
       vdivsd    xmm0,xmm6,xmm0
       vmulsd    xmm0,xmm0,qword ptr [7FFB36EBB900]
       vmovaps   xmm6,[rsp+20]
       add       rsp,38
       ret
; Total bytes of code 96
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.CalculatePercent05()
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+68]
       mov       rdx,[rsi+70]
       call      dotNetTips.Spargine.Core.WIPTests.CalculatePercentSynchronized(System.TimeSpan, System.TimeSpan)
       mov       rax,[rsi+10]
       cmp       [rax],eax
       add       rax,18
       vmovsd    qword ptr [rax],xmm0
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
```
```assembly
; dotNetTips.Spargine.Core.WIPTests.CalculatePercentSynchronized(System.TimeSpan, System.TimeSpan)
       push      rbp
       sub       rsp,40
       vzeroupper
       vmovaps   [rsp+30],xmm6
       lea       rbp,[rsp+40]
       mov       [rbp+0FFE0],rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       xor       edx,edx
       mov       [rbp+0FFE8],edx
       lea       rdx,[rbp+0FFE8]
       mov       rcx,1A2CCE10878
       call      CORINFO_HELP_MON_ENTER_STATIC
       lea       rcx,[rbp+18]
       call      System.TimeSpan.get_TotalMilliseconds()
       vmovaps   xmm6,xmm0
       lea       rcx,[rbp+10]
       call      System.TimeSpan.get_TotalMilliseconds()
       vsubsd    xmm6,xmm6,xmm0
       lea       rcx,[rbp+10]
       call      System.TimeSpan.get_TotalMilliseconds()
       vmovsd    xmm1,qword ptr [7FFB36E9B9E8]
       vandps    xmm0,xmm0,xmm1
       vdivsd    xmm0,xmm6,xmm0
       vmulsd    xmm6,xmm0,qword ptr [7FFB36E9B9F8]
       lea       rdx,[rbp+0FFE8]
       mov       rcx,1A2CCE10878
       call      CORINFO_HELP_MON_EXIT_STATIC
       vmovaps   xmm0,xmm6
       vmovaps   xmm6,[rsp+30]
       lea       rsp,[rbp]
       pop       rbp
       ret
       push      rbp
       sub       rsp,40
       vzeroupper
       vmovaps   [rsp+30],xmm6
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       lea       rdx,[rbp+0FFE8]
       mov       rcx,1A2CCE10878
       call      CORINFO_HELP_MON_EXIT_STATIC
       nop
       vmovaps   xmm6,[rsp+30]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 208
```

