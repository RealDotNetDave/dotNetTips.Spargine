## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCritical_EazyLogger_Benchmark()
       mov       [rsp+8],rcx
       mov       rcx,[rcx+190]
       mov       r8,[rsp+8]
       mov       r8,[r8+198]
       mov       rdx,24287EF1C08
       mov       rdx,[rdx]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLogger.LogCritical(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception)
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLogger.LogCritical(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C7886D08],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9C75D06E0
       mov       edx,5
       call      qword ptr [7FF9C75D06E0]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       rcx,7FF9C7887358
       mov       edx,49
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,24207EF87C8
       mov       rcx,[rcx]
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rax,[rbp-18]
       call      qword ptr [rax+18]
       nop
       nop
M01_L01:
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCritical_EazyLogger_Benchmark()
       mov       [rsp+8],rcx
       mov       rcx,[rcx+190]
       mov       r8,[rsp+8]
       mov       r8,[r8+198]
       mov       rdx,1920E000C40
       mov       rdx,[rdx]
       jmp       qword ptr [7FF9CE9FF000]; DotNetTips.Spargine.Core.Logging.EasyLogger.LogCritical(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception)
; Total bytes of code 43
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLogger.LogCritical(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9CE5D9F50],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9CE180650
       mov       edx,5
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       rcx,7FF9CE5DA710
       mov       edx,5B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,191FE007860
       mov       rcx,[rcx]
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rax,[rbp-10]
       call      qword ptr [rax+18]
       nop
       nop
M01_L01:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 160
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebug_EasyLogger_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,1C3E3171C08
       mov       rdx,[rdx]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLogger.LogDebug(Microsoft.Extensions.Logging.ILogger, System.String)
; Total bytes of code 25
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLogger.LogDebug(Microsoft.Extensions.Logging.ILogger, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C7896D08],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9C75E06B8
       mov       edx,1
       call      qword ptr [7FF9C75E06B8]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       rcx,7FF9C7897358
       mov       edx,49
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1C3F31787D0
       mov       rcx,[rcx]
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       r8,[rbp+18]
       xor       r9d,r9d
       mov       rax,[rbp-18]
       call      qword ptr [rax+18]
       nop
       nop
M01_L01:
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 172
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebug_EasyLogger_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,29033C01C58
       mov       rdx,[rdx]
       jmp       qword ptr [7FF9CE9CD018]; DotNetTips.Spargine.Core.Logging.EasyLogger.LogDebug(Microsoft.Extensions.Logging.ILogger, System.String)
; Total bytes of code 26
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLogger.LogDebug(Microsoft.Extensions.Logging.ILogger, System.String)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9CE5A9F50],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9CE150640
       mov       edx,1
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       rcx,7FF9CE5AA710
       mov       edx,5B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,29035C07868
       mov       rcx,[rcx]
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       r8,[rbp+18]
       xor       r9d,r9d
       mov       rax,[rbp-10]
       call      qword ptr [rax+18]
       nop
       nop
M01_L01:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 155
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogError_EasyLogger_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,1A267695BE0
       mov       rdx,[rdx]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLogger.LogError(Microsoft.Extensions.Logging.ILogger, System.String)
; Total bytes of code 25
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLogger.LogError(Microsoft.Extensions.Logging.ILogger, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C7886D08],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9C75D06B8
       mov       edx,4
       call      qword ptr [7FF9C75D06B8]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       rcx,7FF9C7887358
       mov       edx,49
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1A2676943D0
       mov       rcx,[rcx]
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       r8,[rbp+18]
       xor       r9d,r9d
       mov       rax,[rbp-18]
       call      qword ptr [rax+18]
       nop
       nop
M01_L01:
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 172
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogError_EasyLogger_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,1BF19400C40
       mov       rdx,[rdx]
       jmp       qword ptr [7FF9CE9FF030]; DotNetTips.Spargine.Core.Logging.EasyLogger.LogError(Microsoft.Extensions.Logging.ILogger, System.String)
; Total bytes of code 26
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLogger.LogError(Microsoft.Extensions.Logging.ILogger, System.String)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9CE5D9F50],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9CE180640
       mov       edx,4
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       rcx,7FF9CE5DA710
       mov       edx,5B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1BF13407870
       mov       rcx,[rcx]
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       r8,[rbp+18]
       xor       r9d,r9d
       mov       rax,[rbp-10]
       call      qword ptr [rax+18]
       nop
       nop
M01_L01:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 155
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogException_EasyLogger_Benchmark()
       mov       [rsp+8],rcx
       mov       rcx,[rcx+190]
       mov       r8,[rsp+8]
       mov       r8,[r8+198]
       mov       rdx,22E7F9E1C08
       mov       rdx,[rdx]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLogger.LogException(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception)
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLogger.LogException(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C78A6D08],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9C75F06B8
       mov       edx,4
       call      qword ptr [7FF9C75F06B8]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       rcx,7FF9C78A7358
       mov       edx,49
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,22DEF9E87E0
       mov       rcx,[rcx]
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rax,[rbp-18]
       call      qword ptr [rax+18]
       nop
       nop
M01_L01:
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 177
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogException_EasyLogger_Benchmark()
       mov       [rsp+8],rcx
       mov       rcx,[rcx+190]
       mov       r8,[rsp+8]
       mov       r8,[r8+198]
       mov       rdx,1BE3AC00C40
       mov       rdx,[rdx]
       jmp       qword ptr [7FF9CE9EF048]; DotNetTips.Spargine.Core.Logging.EasyLogger.LogException(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception)
; Total bytes of code 43
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLogger.LogException(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9CE5C9F50],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9CE170650
       mov       edx,4
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       rcx,7FF9CE5CA710
       mov       edx,5B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1BE30C03470
       mov       rcx,[rcx]
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rax,[rbp-10]
       call      qword ptr [rax+18]
       nop
       nop
M01_L01:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 160
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformation_EasyLogger_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,29E3E801C08
       mov       rdx,[rdx]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLogger.LogInformation(Microsoft.Extensions.Logging.ILogger, System.String)
; Total bytes of code 25
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLogger.LogInformation(Microsoft.Extensions.Logging.ILogger, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C7896D08],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9C75E06B8
       mov       edx,2
       call      qword ptr [7FF9C75E06B8]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       rcx,7FF9C7897358
       mov       edx,49
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,29DDE8087E8
       mov       rcx,[rcx]
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       r8,[rbp+18]
       xor       r9d,r9d
       mov       rax,[rbp-18]
       call      qword ptr [rax+18]
       nop
       nop
M01_L01:
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 172
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformation_EasyLogger_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,299EE000C40
       mov       rdx,[rdx]
       jmp       qword ptr [7FF9CEA11360]; DotNetTips.Spargine.Core.Logging.EasyLogger.LogInformation(Microsoft.Extensions.Logging.ILogger, System.String)
; Total bytes of code 26
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLogger.LogInformation(Microsoft.Extensions.Logging.ILogger, System.String)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9CE5D9F50],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9CE180640
       mov       edx,2
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       rcx,7FF9CE5DA710
       mov       edx,5B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,299DE007880
       mov       rcx,[rcx]
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       r8,[rbp+18]
       xor       r9d,r9d
       mov       rax,[rbp-10]
       call      qword ptr [rax+18]
       nop
       nop
M01_L01:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 155
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTrace_EasyLogger_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,134B35F1C08
       mov       rdx,[rdx]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLogger.LogTrace(Microsoft.Extensions.Logging.ILogger, System.String)
; Total bytes of code 25
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLogger.LogTrace(Microsoft.Extensions.Logging.ILogger, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C7886D08],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9C75D06A8
       xor       edx,edx
       call      qword ptr [7FF9C75D06A8]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       rcx,7FF9C7887358
       mov       edx,49
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,134C35F87F0
       mov       rcx,[rcx]
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       r8,[rbp+18]
       xor       r9d,r9d
       mov       rax,[rbp-18]
       call      qword ptr [rax+18]
       nop
       nop
M01_L01:
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 169
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTrace_EasyLogger_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,1E71F800C40
       mov       rdx,[rdx]
       jmp       qword ptr [7FF9CE9EF378]; DotNetTips.Spargine.Core.Logging.EasyLogger.LogTrace(Microsoft.Extensions.Logging.ILogger, System.String)
; Total bytes of code 26
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLogger.LogTrace(Microsoft.Extensions.Logging.ILogger, System.String)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9CE5C9F50],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9CE170650
       xor       edx,edx
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       rcx,7FF9CE5CA710
       mov       edx,5B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1E70D807888
       mov       rcx,[rcx]
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       r8,[rbp+18]
       xor       r9d,r9d
       mov       rax,[rbp-10]
       call      qword ptr [rax+18]
       nop
       nop
M01_L01:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 152
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarning_EasyLogger_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,292D5D51C08
       mov       rdx,[rdx]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLogger.LogWarning(Microsoft.Extensions.Logging.ILogger, System.String)
; Total bytes of code 25
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLogger.LogWarning(Microsoft.Extensions.Logging.ILogger, System.String)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C7866D08],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9C75B06B8
       mov       edx,3
       call      qword ptr [7FF9C75B06B8]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       rcx,7FF9C7867358
       mov       edx,49
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,292E5D587F8
       mov       rcx,[rcx]
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       r8,[rbp+18]
       xor       r9d,r9d
       mov       rax,[rbp-18]
       call      qword ptr [rax+18]
       nop
       nop
M01_L01:
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 172
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarning_EasyLogger_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,263D0400C40
       mov       rdx,[rdx]
       jmp       qword ptr [7FF9CE9DF090]; DotNetTips.Spargine.Core.Logging.EasyLogger.LogWarning(Microsoft.Extensions.Logging.ILogger, System.String)
; Total bytes of code 26
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLogger.LogWarning(Microsoft.Extensions.Logging.ILogger, System.String)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9CE5B9F50],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9CE160650
       mov       edx,3
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       rcx,7FF9CE5BA710
       mov       edx,5B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,263C0407890
       mov       rcx,[rcx]
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       r8,[rbp+18]
       xor       r9d,r9d
       mov       rax,[rbp-10]
       call      qword ptr [rax+18]
       nop
       nop
M01_L01:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 155
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCritical_EazyLoggerExtensions_Benchmark()
       mov       [rsp+8],rcx
       mov       rcx,[rcx+190]
       mov       r8,[rsp+8]
       mov       r8,[r8+198]
       mov       rdx,298FF9C1C08
       mov       rdx,[rdx]
       mov       r9,298FF9C1C10
       mov       r9,[r9]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogCriticalMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogCriticalMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
       push      rbp
       sub       rsp,90
       vzeroupper
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C7896D08],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9C75E06B8
       mov       edx,5
       call      qword ptr [7FF9C75E06B8]
       mov       [rbp-8],eax
       mov       r8d,[rbp-8]
       movzx     r8d,r8b
       mov       [rbp-4],r8d
       cmp       dword ptr [rbp-4],0
       je        near ptr M01_L02
       nop
       mov       r8,298FF9C1C18
       mov       r8,[r8]
       lea       rcx,[rbp-18]
       mov       edx,390
       call      Microsoft.Extensions.Logging.EventId..ctor(Int32, System.String)
       lea       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+28]
       call      DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogCriticalMessageStruct..ctor(System.String, System.String)
       mov       rcx,[rbp+10]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogCriticalMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogCriticalMessageStruct, System.Exception, System.Func`3<__LogCriticalMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-30],rax
       mov       rcx,[rbp+10]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-18]
       vmovdqu   xmmword ptr [rbp-40],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-28]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,7FF9C7897358
       mov       edx,6F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2989F9C8890
       mov       rcx,[rcx]
       mov       [rbp-58],rcx
       mov       rcx,[rbp-58]
       mov       [rsp+28],rcx
       mov       rcx,[rbp-60]
       lea       r8,[rbp-40]
       lea       r9,[rbp-50]
       mov       rdx,[rbp+20]
       mov       [rsp+20],rdx
       mov       edx,5
       mov       rax,[rbp-30]
       call      rax
       nop
       nop
M01_L02:
       nop
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 333
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCritical_EazyLoggerExtensions_Benchmark()
       mov       [rsp+8],rcx
       mov       rcx,[rcx+190]
       mov       r8,[rsp+8]
       mov       r8,[r8+198]
       mov       rdx,20A8DC00C40
       mov       rdx,[rdx]
       mov       r9,20A8DC00C48
       mov       r9,[r9]
       jmp       qword ptr [7FF9CE9FF000]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogCriticalMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogCriticalMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
       push      rbp
       sub       rsp,90
       vzeroupper
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9CE5D9F50],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9CE180650
       mov       edx,5
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       r8d,[rbp-8]
       movzx     r8d,r8b
       mov       [rbp-4],r8d
       cmp       dword ptr [rbp-4],0
       je        near ptr M01_L02
       nop
       mov       r8,20A8DC00C50
       mov       r8,[r8]
       lea       rcx,[rbp-18]
       mov       edx,390
       call      qword ptr [7FF9CE9FF120]
       lea       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+28]
       call      qword ptr [7FF9CE9FF228]
       mov       rcx,[rbp+10]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogCriticalMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogCriticalMessageStruct, System.Exception, System.Func`3<__LogCriticalMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-30],rax
       mov       rcx,[rbp+10]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-18]
       vmovdqu   xmmword ptr [rbp-40],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-28]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,7FF9CE5DA710
       mov       edx,93
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,20A91C07930
       mov       rcx,[rcx]
       mov       [rbp-58],rcx
       mov       rcx,[rbp-58]
       mov       [rsp+28],rcx
       mov       rcx,[rbp-60]
       lea       r8,[rbp-40]
       lea       r9,[rbp-50]
       mov       rdx,[rbp+20]
       mov       [rsp+20],rdx
       mov       edx,5
       mov       rax,[rbp-30]
       call      rax
       nop
       nop
M01_L02:
       nop
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 332
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogError_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,22D890837B0
       mov       rdx,[rdx]
       mov       r8,22D890837B8
       mov       r8,[r8]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogErrorMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 38
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogErrorMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      rbp
       sub       rsp,90
       vzeroupper
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C7896D08],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9C75E06B8
       mov       edx,4
       call      qword ptr [7FF9C75E06B8]
       mov       [rbp-8],eax
       mov       r8d,[rbp-8]
       movzx     r8d,r8b
       mov       [rbp-4],r8d
       cmp       dword ptr [rbp-4],0
       je        near ptr M01_L02
       nop
       mov       r8,22D890837C0
       mov       r8,[r8]
       lea       rcx,[rbp-18]
       mov       edx,12D
       call      Microsoft.Extensions.Logging.EventId..ctor(Int32, System.String)
       lea       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogErrorMessageStruct..ctor(System.String, System.String)
       mov       rcx,[rbp+10]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogErrorMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogErrorMessageStruct, System.Exception, System.Func`3<__LogErrorMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-30],rax
       mov       rcx,[rbp+10]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-18]
       vmovdqu   xmmword ptr [rbp-40],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-28]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,7FF9C7897358
       mov       edx,71
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,22D890788A0
       mov       rcx,[rcx]
       mov       [rbp-58],rcx
       mov       rcx,[rbp-58]
       mov       [rsp+28],rcx
       mov       rcx,[rbp-60]
       lea       r8,[rbp-40]
       lea       r9,[rbp-50]
       mov       edx,4
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rax,[rbp-30]
       call      rax
       nop
       nop
M01_L02:
       nop
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 327
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogError_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,1D2A8409838
       mov       rdx,[rdx]
       mov       r8,1D2A8409840
       mov       r8,[r8]
       jmp       qword ptr [7FF9CE9ED030]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogErrorMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogErrorMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      rbp
       sub       rsp,90
       vzeroupper
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9CE5C9F50],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9CE170640
       mov       edx,4
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       r8d,[rbp-8]
       movzx     r8d,r8b
       mov       [rbp-4],r8d
       cmp       dword ptr [rbp-4],0
       je        near ptr M01_L02
       nop
       mov       r8,1D2A8409848
       mov       r8,[r8]
       lea       rcx,[rbp-18]
       mov       edx,12D
       call      qword ptr [7FF9CE9ED120]
       lea       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9CE9ED228]
       mov       rcx,[rbp+10]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogErrorMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogErrorMessageStruct, System.Exception, System.Func`3<__LogErrorMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-30],rax
       mov       rcx,[rbp+10]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-18]
       vmovdqu   xmmword ptr [rbp-40],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-28]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,7FF9CE5CA710
       mov       edx,95
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1D2A8407940
       mov       rcx,[rcx]
       mov       [rbp-58],rcx
       mov       rcx,[rbp-58]
       mov       [rsp+28],rcx
       mov       rcx,[rbp-60]
       lea       r8,[rbp-40]
       lea       r9,[rbp-50]
       mov       edx,4
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rax,[rbp-30]
       call      rax
       nop
       nop
M01_L02:
       nop
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 326
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogException_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,212923A37B0
       mov       rdx,[rdx]
       mov       r8,212923A37B8
       mov       r8,[r8]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogDebugMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 38
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogDebugMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      rbp
       sub       rsp,90
       vzeroupper
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C7896D08],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9C75E06B8
       mov       edx,1
       call      qword ptr [7FF9C75E06B8]
       mov       [rbp-8],eax
       mov       r8d,[rbp-8]
       movzx     r8d,r8b
       mov       [rbp-4],r8d
       cmp       dword ptr [rbp-4],0
       je        near ptr M01_L02
       nop
       mov       r8,21292399878
       mov       r8,[r8]
       lea       rcx,[rbp-18]
       mov       edx,0C9
       call      Microsoft.Extensions.Logging.EventId..ctor(Int32, System.String)
       lea       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogDebugMessageStruct..ctor(System.String, System.String)
       mov       rcx,[rbp+10]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogDebugMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogDebugMessageStruct, System.Exception, System.Func`3<__LogDebugMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-30],rax
       mov       rcx,[rbp+10]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-18]
       vmovdqu   xmmword ptr [rbp-40],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-28]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,7FF9C7897358
       mov       edx,70
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21292398898
       mov       rcx,[rcx]
       mov       [rbp-58],rcx
       mov       rcx,[rbp-58]
       mov       [rsp+28],rcx
       mov       rcx,[rbp-60]
       lea       r8,[rbp-40]
       lea       r9,[rbp-50]
       mov       edx,1
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rax,[rbp-30]
       call      rax
       nop
       nop
M01_L02:
       nop
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 327
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogException_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,1E057400C40
       mov       rdx,[rdx]
       mov       r8,1E057400C48
       mov       r8,[r8]
       jmp       qword ptr [7FF9CE9FF018]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogDebugMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogDebugMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      rbp
       sub       rsp,90
       vzeroupper
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9CE5D9F50],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9CE180650
       mov       edx,1
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       r8d,[rbp-8]
       movzx     r8d,r8b
       mov       [rbp-4],r8d
       cmp       dword ptr [rbp-4],0
       je        near ptr M01_L02
       nop
       mov       r8,1E0454088B0
       mov       r8,[r8]
       lea       rcx,[rbp-18]
       mov       edx,0C9
       call      qword ptr [7FF9CE9FF120]
       lea       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9CE9FF228]
       mov       rcx,[rbp+10]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogDebugMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogDebugMessageStruct, System.Exception, System.Func`3<__LogDebugMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-30],rax
       mov       rcx,[rbp+10]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-18]
       vmovdqu   xmmword ptr [rbp-40],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-28]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,7FF9CE5DA710
       mov       edx,94
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1E045407938
       mov       rcx,[rcx]
       mov       [rbp-58],rcx
       mov       rcx,[rbp-58]
       mov       [rsp+28],rcx
       mov       rcx,[rbp-60]
       lea       r8,[rbp-40]
       lea       r9,[rbp-50]
       mov       edx,1
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rax,[rbp-30]
       call      rax
       nop
       nop
M01_L02:
       nop
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 326
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformation_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,18A503D1C08
       mov       rdx,[rdx]
       mov       r8,18A503D1C10
       mov       r8,[r8]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogInformationMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 38
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogInformationMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      rbp
       sub       rsp,90
       vzeroupper
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C7896D08],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9C75E06B8
       mov       edx,2
       call      qword ptr [7FF9C75E06B8]
       mov       [rbp-8],eax
       mov       r8d,[rbp-8]
       movzx     r8d,r8b
       mov       [rbp-4],r8d
       cmp       dword ptr [rbp-4],0
       je        near ptr M01_L02
       nop
       mov       r8,18A503D1C18
       mov       r8,[r8]
       lea       rcx,[rbp-18]
       mov       edx,191
       call      Microsoft.Extensions.Logging.EventId..ctor(Int32, System.String)
       lea       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogInformationMessageStruct..ctor(System.String, System.String)
       mov       rcx,[rbp+10]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogInformationMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogInformationMessageStruct, System.Exception, System.Func`3<__LogInformationMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-30],rax
       mov       rcx,[rbp+10]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-18]
       vmovdqu   xmmword ptr [rbp-40],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-28]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,7FF9C7897358
       mov       edx,73
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,189F03D64A0
       mov       rcx,[rcx]
       mov       [rbp-58],rcx
       mov       rcx,[rbp-58]
       mov       [rsp+28],rcx
       mov       rcx,[rbp-60]
       lea       r8,[rbp-40]
       lea       r9,[rbp-50]
       mov       edx,2
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rax,[rbp-30]
       call      rax
       nop
       nop
M01_L02:
       nop
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 327
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformation_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,1D670C127E8
       mov       rdx,[rdx]
       mov       r8,1D670C127F0
       mov       r8,[r8]
       jmp       qword ptr [7FF9CE9FF360]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogInformationMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogInformationMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      rbp
       sub       rsp,90
       vzeroupper
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9CE5D9F50],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9CE180650
       mov       edx,2
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       r8d,[rbp-8]
       movzx     r8d,r8b
       mov       [rbp-4],r8d
       cmp       dword ptr [rbp-4],0
       je        near ptr M01_L02
       nop
       mov       r8,1D670C127F8
       mov       r8,[r8]
       lea       rcx,[rbp-18]
       mov       edx,191
       call      qword ptr [7FF9CE9FF420]
       lea       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9CE9FF528]
       mov       rcx,[rbp+10]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogInformationMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogInformationMessageStruct, System.Exception, System.Func`3<__LogInformationMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-30],rax
       mov       rcx,[rbp+10]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-18]
       vmovdqu   xmmword ptr [rbp-40],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-28]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,7FF9CE5DA710
       mov       edx,97
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1D670C07950
       mov       rcx,[rcx]
       mov       [rbp-58],rcx
       mov       rcx,[rbp-58]
       mov       [rsp+28],rcx
       mov       rcx,[rbp-60]
       lea       r8,[rbp-40]
       lea       r9,[rbp-50]
       mov       edx,2
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rax,[rbp-30]
       call      rax
       nop
       nop
M01_L02:
       nop
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 326
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogStoredProcedureError_EazyLoggerExtensions_Benchmark()
       mov       [rsp+8],rcx
       mov       rcx,[rcx+190]
       mov       r8,[rsp+8]
       mov       r8,[r8+198]
       mov       rdx,1FF6B621C08
       mov       rdx,[rdx]
       mov       r9,1FF6B621C10
       mov       r9,[r9]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureError(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureError(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
       push      rbp
       sub       rsp,90
       vzeroupper
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C7876D08],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9C75C06B8
       mov       edx,4
       call      qword ptr [7FF9C75C06B8]
       mov       [rbp-8],eax
       mov       r8d,[rbp-8]
       movzx     r8d,r8b
       mov       [rbp-4],r8d
       cmp       dword ptr [rbp-4],0
       je        near ptr M01_L02
       nop
       mov       r8,1FF6B621C18
       mov       r8,[r8]
       lea       rcx,[rbp-18]
       mov       edx,1F6
       call      Microsoft.Extensions.Logging.EventId..ctor(Int32, System.String)
       lea       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+28]
       call      DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogStoredProcedureErrorStruct..ctor(System.String, System.String)
       mov       rcx,[rbp+10]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogStoredProcedureErrorStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogStoredProcedureErrorStruct, System.Exception, System.Func`3<__LogStoredProcedureErrorStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-30],rax
       mov       rcx,[rbp+10]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-18]
       vmovdqu   xmmword ptr [rbp-40],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-28]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,7FF9C7877358
       mov       edx,74
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FF0B6288B8
       mov       rcx,[rcx]
       mov       [rbp-58],rcx
       mov       rcx,[rbp-58]
       mov       [rsp+28],rcx
       mov       rcx,[rbp-60]
       lea       r8,[rbp-40]
       lea       r9,[rbp-50]
       mov       rdx,[rbp+20]
       mov       [rsp+20],rdx
       mov       edx,4
       mov       rax,[rbp-30]
       call      rax
       nop
       nop
M01_L02:
       nop
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 333
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogStoredProcedureError_EazyLoggerExtensions_Benchmark()
       mov       [rsp+8],rcx
       mov       rcx,[rcx+190]
       mov       r8,[rsp+8]
       mov       r8,[r8+198]
       mov       rdx,1E24E000C40
       mov       rdx,[rdx]
       mov       r9,1E24E000C48
       mov       r9,[r9]
       jmp       qword ptr [7FF9CEDCF078]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureError(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureError(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
       push      rbp
       sub       rsp,90
       vzeroupper
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9CE9A9F50],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9CE550650
       mov       edx,4
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       r8d,[rbp-8]
       movzx     r8d,r8b
       mov       [rbp-4],r8d
       cmp       dword ptr [rbp-4],0
       je        near ptr M01_L02
       nop
       mov       r8,1E24E000C50
       mov       r8,[r8]
       lea       rcx,[rbp-18]
       mov       edx,1F6
       call      qword ptr [7FF9CEDCF120]
       lea       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+28]
       call      qword ptr [7FF9CEDCF228]
       mov       rcx,[rbp+10]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogStoredProcedureErrorStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogStoredProcedureErrorStruct, System.Exception, System.Func`3<__LogStoredProcedureErrorStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-30],rax
       mov       rcx,[rbp+10]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-18]
       vmovdqu   xmmword ptr [rbp-40],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-28]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,7FF9CE9AA710
       mov       edx,98
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1E242007958
       mov       rcx,[rcx]
       mov       [rbp-58],rcx
       mov       rcx,[rbp-58]
       mov       [rsp+28],rcx
       mov       rcx,[rbp-60]
       lea       r8,[rbp-40]
       lea       r9,[rbp-50]
       mov       rdx,[rbp+20]
       mov       [rsp+20],rdx
       mov       edx,4
       mov       rax,[rbp-30]
       call      rax
       nop
       nop
M01_L02:
       nop
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 332
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogStoredProcedureNoRecordsFound_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,2430B171C08
       mov       rdx,[rdx]
       mov       r8,2430B171C10
       mov       r8,[r8]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureNoRecordsFound(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 38
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureNoRecordsFound(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      rbp
       sub       rsp,90
       vzeroupper
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C7876D08],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9C75C06B8
       mov       edx,4
       call      qword ptr [7FF9C75C06B8]
       mov       [rbp-8],eax
       mov       r8d,[rbp-8]
       movzx     r8d,r8b
       mov       [rbp-4],r8d
       cmp       dword ptr [rbp-4],0
       je        near ptr M01_L02
       nop
       mov       r8,2430B171C18
       mov       r8,[r8]
       lea       rcx,[rbp-18]
       mov       edx,25A
       call      Microsoft.Extensions.Logging.EventId..ctor(Int32, System.String)
       lea       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogStoredProcedureNoRecordsFoundStruct..ctor(System.String, System.String)
       mov       rcx,[rbp+10]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogStoredProcedureNoRecordsFoundStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogStoredProcedureNoRecordsFoundStruct, System.Exception, System.Func`3<__LogStoredProcedureNoRecordsFoundStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-30],rax
       mov       rcx,[rbp+10]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-18]
       vmovdqu   xmmword ptr [rbp-40],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-28]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,7FF9C7877358
       mov       edx,75
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,242AB1788C0
       mov       rcx,[rcx]
       mov       [rbp-58],rcx
       mov       rcx,[rbp-58]
       mov       [rsp+28],rcx
       mov       rcx,[rbp-60]
       lea       r8,[rbp-40]
       lea       r9,[rbp-50]
       mov       edx,4
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rax,[rbp-30]
       call      rax
       nop
       nop
M01_L02:
       nop
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 327
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogStoredProcedureNoRecordsFound_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,1FC6F400C40
       mov       rdx,[rdx]
       mov       r8,1FC6F400C48
       mov       r8,[r8]
       jmp       qword ptr [7FF9CEDBF090]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureNoRecordsFound(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureNoRecordsFound(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      rbp
       sub       rsp,90
       vzeroupper
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9CE999F50],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9CE540650
       mov       edx,4
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       r8d,[rbp-8]
       movzx     r8d,r8b
       mov       [rbp-4],r8d
       cmp       dword ptr [rbp-4],0
       je        near ptr M01_L02
       nop
       mov       r8,1FC6F400C50
       mov       r8,[r8]
       lea       rcx,[rbp-18]
       mov       edx,25A
       call      qword ptr [7FF9CEDBF120]
       lea       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9CEDBF228]
       mov       rcx,[rbp+10]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogStoredProcedureNoRecordsFoundStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogStoredProcedureNoRecordsFoundStruct, System.Exception, System.Func`3<__LogStoredProcedureNoRecordsFoundStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-30],rax
       mov       rcx,[rbp+10]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-18]
       vmovdqu   xmmword ptr [rbp-40],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-28]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,7FF9CE99A710
       mov       edx,99
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FC67407960
       mov       rcx,[rcx]
       mov       [rbp-58],rcx
       mov       rcx,[rbp-58]
       mov       [rsp+28],rcx
       mov       rcx,[rbp-60]
       lea       r8,[rbp-40]
       lea       r9,[rbp-50]
       mov       edx,4
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rax,[rbp-30]
       call      rax
       nop
       nop
M01_L02:
       nop
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 326
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTrace_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,20BFD8E1C08
       mov       rdx,[rdx]
       mov       r8,20BFD8E1C10
       mov       r8,[r8]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogTraceMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 38
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogTraceMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      rbp
       sub       rsp,90
       vzeroupper
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C7876D08],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9C75C06A8
       xor       edx,edx
       call      qword ptr [7FF9C75C06A8]
       mov       [rbp-8],eax
       mov       r8d,[rbp-8]
       movzx     r8d,r8b
       mov       [rbp-4],r8d
       cmp       dword ptr [rbp-4],0
       je        near ptr M01_L02
       nop
       mov       r8,20BFD8E1C18
       mov       r8,[r8]
       lea       rcx,[rbp-18]
       mov       edx,65
       call      Microsoft.Extensions.Logging.EventId..ctor(Int32, System.String)
       lea       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogTraceMessageStruct..ctor(System.String, System.String)
       mov       rcx,[rbp+10]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogTraceMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogTraceMessageStruct, System.Exception, System.Func`3<__LogTraceMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-30],rax
       mov       rcx,[rbp+10]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-18]
       vmovdqu   xmmword ptr [rbp-40],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-28]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,7FF9C7877358
       mov       edx,76
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,20B9D8E88C8
       mov       rcx,[rcx]
       mov       [rbp-58],rcx
       mov       rcx,[rbp-58]
       mov       [rsp+28],rcx
       mov       rcx,[rbp-60]
       lea       r8,[rbp-40]
       lea       r9,[rbp-50]
       xor       edx,edx
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rax,[rbp-30]
       call      rax
       nop
       nop
M01_L02:
       nop
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 321
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTrace_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,1ECBC000C40
       mov       rdx,[rdx]
       mov       r8,1ECBC000C48
       mov       r8,[r8]
       jmp       qword ptr [7FF9CEA0F3A8]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogTraceMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogTraceMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      rbp
       sub       rsp,90
       vzeroupper
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9CE5E9F50],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9CE190650
       xor       edx,edx
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       r8d,[rbp-8]
       movzx     r8d,r8b
       mov       [rbp-4],r8d
       cmp       dword ptr [rbp-4],0
       je        near ptr M01_L02
       nop
       mov       r8,1ECBC000C50
       mov       r8,[r8]
       lea       rcx,[rbp-18]
       mov       edx,65
       call      qword ptr [7FF9CEA0F420]
       lea       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9CEA0F528]
       mov       rcx,[rbp+10]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogTraceMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogTraceMessageStruct, System.Exception, System.Func`3<__LogTraceMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-30],rax
       mov       rcx,[rbp+10]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-18]
       vmovdqu   xmmword ptr [rbp-40],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-28]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,7FF9CE5EA710
       mov       edx,9A
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1ECB0007968
       mov       rcx,[rcx]
       mov       [rbp-58],rcx
       mov       rcx,[rbp-58]
       mov       [rsp+28],rcx
       mov       rcx,[rbp-60]
       lea       r8,[rbp-40]
       lea       r9,[rbp-50]
       xor       edx,edx
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rax,[rbp-30]
       call      rax
       nop
       nop
M01_L02:
       nop
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 320
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarning_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,1A7CEA31C08
       mov       rdx,[rdx]
       mov       r8,1A7CEA31C10
       mov       r8,[r8]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogWarningMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 38
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogWarningMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      rbp
       sub       rsp,90
       vzeroupper
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C7886D08],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9C75D06B8
       mov       edx,3
       call      qword ptr [7FF9C75D06B8]
       mov       [rbp-8],eax
       mov       r8d,[rbp-8]
       movzx     r8d,r8b
       mov       [rbp-4],r8d
       cmp       dword ptr [rbp-4],0
       je        near ptr M01_L02
       nop
       mov       r8,1A7CEA31C18
       mov       r8,[r8]
       lea       rcx,[rbp-18]
       mov       edx,259
       call      Microsoft.Extensions.Logging.EventId..ctor(Int32, System.String)
       lea       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogWarningMessageStruct..ctor(System.String, System.String)
       mov       rcx,[rbp+10]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogWarningMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogWarningMessageStruct, System.Exception, System.Func`3<__LogWarningMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-30],rax
       mov       rcx,[rbp+10]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-18]
       vmovdqu   xmmword ptr [rbp-40],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-28]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,7FF9C7887358
       mov       edx,77
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1A76EA388D0
       mov       rcx,[rcx]
       mov       [rbp-58],rcx
       mov       rcx,[rbp-58]
       mov       [rsp+28],rcx
       mov       rcx,[rbp-60]
       lea       r8,[rbp-40]
       lea       r9,[rbp-50]
       mov       edx,3
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rax,[rbp-30]
       call      rax
       nop
       nop
M01_L02:
       nop
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 327
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarning_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,20A09800C40
       mov       rdx,[rdx]
       mov       r8,20A09800C48
       mov       r8,[r8]
       jmp       qword ptr [7FF9CE9CF3C0]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogWarningMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogWarningMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      rbp
       sub       rsp,90
       vzeroupper
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9CE5A9F50],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FF9CE150650
       mov       edx,3
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       r8d,[rbp-8]
       movzx     r8d,r8b
       mov       [rbp-4],r8d
       cmp       dword ptr [rbp-4],0
       je        near ptr M01_L02
       nop
       mov       r8,20A09800C50
       mov       r8,[r8]
       lea       rcx,[rbp-18]
       mov       edx,259
       call      qword ptr [7FF9CE9CF420]
       lea       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9CE9CF528]
       mov       rcx,[rbp+10]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogWarningMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogWarningMessageStruct, System.Exception, System.Func`3<__LogWarningMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-30],rax
       mov       rcx,[rbp+10]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-18]
       vmovdqu   xmmword ptr [rbp-40],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-28]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,7FF9CE5AA710
       mov       edx,9B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,209F9807970
       mov       rcx,[rcx]
       mov       [rbp-58],rcx
       mov       rcx,[rbp-58]
       mov       [rsp+28],rcx
       mov       rcx,[rbp-60]
       lea       r8,[rbp-40]
       lea       r9,[rbp-50]
       mov       edx,3
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rax,[rbp-30]
       call      rax
       nop
       nop
M01_L02:
       nop
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 326
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCritical_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+198]
       mov       rcx,20872482F48
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,20902481C08
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+28],rcx
       mov       rcx,r8
       lea       r8,[rsp+38]
       mov       r9,rax
       mov       edx,5
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 105
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rdi,rcx
       mov       ebp,edx
       mov       rsi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rdi
       mov       edx,ebp
       mov       r8,rsi
       mov       r9,[rsp+50]
       mov       [rsp+38],r9
       mov       r9,[rsp+58]
       mov       [rsp+40],r9
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rbx
       mov       r9,20872488F20
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,191
       mov       rdx,7FF9C7A1F320
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.ThrowHelper.Throw(System.String)
       int       3
; Total bytes of code 217
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCritical_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       mov       r9,[rcx+198]
       mov       rcx,r8
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,2A460009BF0
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,2A464001F78
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,5
       call      qword ptr [7FF9CE9CF6D8]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 102
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rdi,rcx
       mov       ebp,edx
       mov       rsi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      qword ptr [7FF9CE9CF750]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rdi
       mov       edx,ebp
       mov       r8,rsi
       mov       r9,[rsp+50]
       mov       [rsp+38],r9
       mov       r9,[rsp+58]
       mov       [rsp+40],r9
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rbx
       mov       r9,2A4640081D8
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,191
       mov       rdx,7FF9CE7154D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CE977FA8]
       int       3
; Total bytes of code 219
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebug_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+198]
       mov       rcx,19BE7302F48
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,19BD7301C08
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+28],rcx
       mov       rcx,r8
       lea       r8,[rsp+38]
       mov       r9,rax
       mov       edx,1
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 105
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rdi,rcx
       mov       ebp,edx
       mov       rsi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rdi
       mov       edx,ebp
       mov       r8,rsi
       mov       r9,[rsp+50]
       mov       [rsp+38],r9
       mov       r9,[rsp+58]
       mov       [rsp+40],r9
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rbx
       mov       r9,19BE7308F20
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,191
       mov       rdx,7FF9C79FF320
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.ThrowHelper.Throw(System.String)
       int       3
; Total bytes of code 217
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebug_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       mov       r9,[rcx+198]
       mov       rcx,r8
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,272DE0127E8
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,272DE001F78
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,1
       call      qword ptr [7FF9CE9CF3D8]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 102
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rdi,rcx
       mov       ebp,edx
       mov       rsi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      qword ptr [7FF9CE9CF450]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rdi
       mov       edx,ebp
       mov       r8,rsi
       mov       r9,[rsp+50]
       mov       [rsp+38],r9
       mov       r9,[rsp+58]
       mov       [rsp+40],r9
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rbx
       mov       r9,272DE0081D8
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,191
       mov       rdx,7FF9CE7154D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CE977FA8]
       int       3
; Total bytes of code 219
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogError_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+198]
       mov       rcx,1BB7A342F48
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,1BBDA341C08
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+28],rcx
       mov       rcx,r8
       lea       r8,[rsp+38]
       mov       r9,rax
       mov       edx,4
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 105
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rdi,rcx
       mov       ebp,edx
       mov       rsi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rdi
       mov       edx,ebp
       mov       r8,rsi
       mov       r9,[rsp+50]
       mov       [rsp+38],r9
       mov       r9,[rsp+58]
       mov       [rsp+40],r9
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rbx
       mov       r9,1BB7A348F20
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,191
       mov       rdx,7FF9C79EF320
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.ThrowHelper.Throw(System.String)
       int       3
; Total bytes of code 217
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogError_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       mov       r9,[rcx+198]
       mov       rcx,r8
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,16563C00C40
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,16553C01F78
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,4
       call      qword ptr [7FF9CE9DF6F0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 102
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rdi,rcx
       mov       ebp,edx
       mov       rsi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      qword ptr [7FF9CE9DF768]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rdi
       mov       edx,ebp
       mov       r8,rsi
       mov       r9,[rsp+50]
       mov       [rsp+38],r9
       mov       r9,[rsp+58]
       mov       [rsp+40],r9
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rbx
       mov       r9,16553C081D8
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,191
       mov       rdx,7FF9CE7254D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CE987FA8]
       int       3
; Total bytes of code 219
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformation_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+198]
       mov       rcx,2A7ED192F48
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,2A87D191C08
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+28],rcx
       mov       rcx,r8
       lea       r8,[rsp+38]
       mov       r9,rax
       mov       edx,2
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 105
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rdi,rcx
       mov       ebp,edx
       mov       rsi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rdi
       mov       edx,ebp
       mov       r8,rsi
       mov       r9,[rsp+50]
       mov       [rsp+38],r9
       mov       r9,[rsp+58]
       mov       [rsp+40],r9
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rbx
       mov       r9,2A7ED198F20
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,191
       mov       rdx,7FF9C7A1F320
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.ThrowHelper.Throw(System.String)
       int       3
; Total bytes of code 217
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformation_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       mov       r9,[rcx+198]
       mov       rcx,r8
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,2671E800C40
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,2670E801F78
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,2
       call      qword ptr [7FF9CE9FF6F0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 102
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rdi,rcx
       mov       ebp,edx
       mov       rsi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      qword ptr [7FF9CE9FF768]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rdi
       mov       edx,ebp
       mov       r8,rsi
       mov       r9,[rsp+50]
       mov       [rsp+38],r9
       mov       r9,[rsp+58]
       mov       [rsp+40],r9
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rbx
       mov       r9,2670E8081D8
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,191
       mov       rdx,7FF9CE7454D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CE9A7FA8]
       int       3
; Total bytes of code 219
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTrace_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+198]
       mov       rcx,27C31292F48
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,27C112A17B8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+28],rcx
       mov       rcx,r8
       lea       r8,[rsp+38]
       mov       r9,rax
       xor       edx,edx
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 102
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rdi,rcx
       mov       ebp,edx
       mov       rsi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rdi
       mov       edx,ebp
       mov       r8,rsi
       mov       r9,[rsp+50]
       mov       [rsp+38],r9
       mov       r9,[rsp+58]
       mov       [rsp+40],r9
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rbx
       mov       r9,27C11296F28
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,191
       mov       rdx,7FF9C7A0F320
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.ThrowHelper.Throw(System.String)
       int       3
; Total bytes of code 217
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTrace_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       mov       r9,[rcx+198]
       mov       rcx,r8
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,178FE000C40
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,178F4001F78
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       xor       edx,edx
       call      qword ptr [7FF9CE9ED6F0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 99
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rdi,rcx
       mov       ebp,edx
       mov       rsi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      qword ptr [7FF9CE9ED768]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rdi
       mov       edx,ebp
       mov       r8,rsi
       mov       r9,[rsp+50]
       mov       [rsp+38],r9
       mov       r9,[rsp+58]
       mov       [rsp+40],r9
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rbx
       mov       r9,178F40081D8
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,191
       mov       rdx,7FF9CE7354D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CE9973D8]
       int       3
; Total bytes of code 219
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarning_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+198]
       mov       rcx,2B7DF132F48
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,2B83F131C08
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+28],rcx
       mov       rcx,r8
       lea       r8,[rsp+38]
       mov       r9,rax
       mov       edx,3
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 105
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rdi,rcx
       mov       ebp,edx
       mov       rsi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rdi
       mov       edx,ebp
       mov       r8,rsi
       mov       r9,[rsp+50]
       mov       [rsp+38],r9
       mov       r9,[rsp+58]
       mov       [rsp+40],r9
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rbx
       mov       r9,2B7DF138F20
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,191
       mov       rdx,7FF9C79DF320
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.ThrowHelper.Throw(System.String)
       int       3
; Total bytes of code 217
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarning_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       mov       r9,[rcx+198]
       mov       rcx,r8
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,24F37C00C40
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,24F2FC01F78
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,3
       call      qword ptr [7FF9CE9DF3F0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 102
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rdi,rcx
       mov       ebp,edx
       mov       rsi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      qword ptr [7FF9CE9DF468]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rdi
       mov       edx,ebp
       mov       r8,rsi
       mov       r9,[rsp+50]
       mov       [rsp+38],r9
       mov       r9,[rsp+58]
       mov       [rsp+40],r9
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rbx
       mov       r9,24F2FC081D8
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,191
       mov       rdx,7FF9CE7254D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CE987FA8]
       int       3
; Total bytes of code 219
```

