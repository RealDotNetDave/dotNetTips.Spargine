## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.CalculatePercent01()
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+0D0]
       mov       rdx,[rsi+0D8]
       call      dotNetTips.Spargine.Core.WIPTests.CalculatePercent(System.TimeSpan, System.TimeSpan)
       mov       rax,[rsi+10]
       cmp       [rax],eax
       add       rax,18
       vmovsd    qword ptr [rax],xmm0
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
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
       vmovsd    xmm1,qword ptr [7FFB3C41FC20]
       vandps    xmm0,xmm0,xmm1
       vdivsd    xmm0,xmm6,xmm0
       vmulsd    xmm0,xmm0,qword ptr [7FFB3C41FC30]
       vmovaps   xmm6,[rsp+20]
       add       rsp,38
       ret
; Total bytes of code 96
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.CalculatePercent02()
       push      rsi
       sub       rsp,40
       vzeroupper
       vmovaps   [rsp+30],xmm6
       mov       rsi,rcx
       mov       rcx,[rsi+0D0]
       mov       [rsp+20],rcx
       mov       rcx,[rsi+0D8]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       call      System.TimeSpan.get_TotalMilliseconds()
       vmovaps   xmm6,xmm0
       lea       rcx,[rsp+20]
       call      System.TimeSpan.get_TotalMilliseconds()
       vsubsd    xmm6,xmm6,xmm0
       lea       rcx,[rsp+20]
       call      System.TimeSpan.get_TotalMilliseconds()
       vmovsd    xmm1,qword ptr [7FFB3C42FBF8]
       vandps    xmm0,xmm0,xmm1
       vdivsd    xmm0,xmm6,xmm0
       vmulsd    xmm0,xmm0,qword ptr [7FFB3C42FC08]
       mov       rax,[rsi+10]
       cmp       [rax],eax
       add       rax,18
       vmovsd    qword ptr [rax],xmm0
       vmovaps   xmm6,[rsp+30]
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 129
```
```assembly
; System.TimeSpan.get_TotalMilliseconds()
       vzeroupper
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,qword ptr [rcx]
       vdivsd    xmm0,xmm0,[7FFB3C42FB00]
       vucomisd  xmm0,qword ptr [7FFB3C42FB10]
       jbe       short M01_L00
       vmovsd    xmm0,qword ptr [7FFB3C42FB20]
       ret
M01_L00:
       vmovsd    xmm1,qword ptr [7FFB3C42FB30]
       vucomisd  xmm1,xmm0
       jbe       short M01_L01
       vmovsd    xmm0,qword ptr [7FFB3C42FB40]
       ret
M01_L01:
       ret
; Total bytes of code 63
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.CalculatePercent03()
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+0D0]
       mov       rdx,[rsi+0D8]
       call      dotNetTips.Spargine.Core.WIPTests.CalculatePercentNoInline(System.TimeSpan, System.TimeSpan)
       mov       rax,[rsi+10]
       cmp       [rax],eax
       add       rax,18
       vmovsd    qword ptr [rax],xmm0
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
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
       vmovsd    xmm1,qword ptr [7FFB3C42FC20]
       vandps    xmm0,xmm0,xmm1
       vdivsd    xmm0,xmm6,xmm0
       vmulsd    xmm0,xmm0,qword ptr [7FFB3C42FC30]
       vmovaps   xmm6,[rsp+20]
       add       rsp,38
       ret
; Total bytes of code 96
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.CalculatePercent04()
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+0D0]
       mov       rdx,[rsi+0D8]
       call      dotNetTips.Spargine.Core.WIPTests.CalculatePercentNoOptimization(System.TimeSpan, System.TimeSpan)
       mov       rax,[rsi+10]
       cmp       [rax],eax
       add       rax,18
       vmovsd    qword ptr [rax],xmm0
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
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
       vmulsd    xmm0,xmm0,qword ptr [7FFB3C41D360]
       lea       rsp,[rbp]
       pop       rbp
       ret
; Total bytes of code 105
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.CalculatePercent06()
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+0D0]
       mov       rdx,[rsi+0D8]
       call      dotNetTips.Spargine.Core.WIPTests.CalculatePercentPreserveSig(System.TimeSpan, System.TimeSpan)
       mov       rax,[rsi+10]
       cmp       [rax],eax
       add       rax,18
       vmovsd    qword ptr [rax],xmm0
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
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
       vmovsd    xmm1,qword ptr [7FFB3C3FFF10]
       vandps    xmm0,xmm0,xmm1
       vdivsd    xmm0,xmm6,xmm0
       vmulsd    xmm0,xmm0,qword ptr [7FFB3C3FFF20]
       vmovaps   xmm6,[rsp+20]
       add       rsp,38
       ret
; Total bytes of code 96
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.CalculatePercent05()
       push      rsi
       sub       rsp,20
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+0D0]
       mov       rdx,[rsi+0D8]
       call      dotNetTips.Spargine.Core.WIPTests.CalculatePercentSynchronized(System.TimeSpan, System.TimeSpan)
       mov       rax,[rsi+10]
       cmp       [rax],eax
       add       rax,18
       vmovsd    qword ptr [rax],xmm0
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
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
       mov       rcx,1D019AEAF28
       call      CORINFO_HELP_MON_ENTER_STATIC
       lea       rcx,[rbp+18]
       call      System.TimeSpan.get_TotalMilliseconds()
       vmovaps   xmm6,xmm0
       lea       rcx,[rbp+10]
       call      System.TimeSpan.get_TotalMilliseconds()
       vsubsd    xmm6,xmm6,xmm0
       lea       rcx,[rbp+10]
       call      System.TimeSpan.get_TotalMilliseconds()
       vmovsd    xmm1,qword ptr [7FFB3C400008]
       vandps    xmm0,xmm0,xmm1
       vdivsd    xmm0,xmm6,xmm0
       vmulsd    xmm6,xmm0,qword ptr [7FFB3C400018]
       lea       rdx,[rbp+0FFE8]
       mov       rcx,1D019AEAF28
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
       mov       rcx,1D019AEAF28
       call      CORINFO_HELP_MON_EXIT_STATIC
       nop
       vmovaps   xmm6,[rsp+30]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 208
```
