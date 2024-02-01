## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCritical_EazyLogger_Benchmark()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+190]
       mov       rdi,[rcx+198]
       mov       rcx,rsi
       mov       r11,7FF9DB520788
       mov       edx,5
       call      qword ptr [7FF9DB520788]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FF9DB7D7320
       mov       edx,48
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2946C8F6800
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,2948C8F9BB0
       mov       r8,[r8]
       mov       rdx,rsi
       mov       r9,rdi
       mov       rax,[rax+18]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M00_L00:
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 124
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCritical_EazyLogger_Benchmark()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+190]
       mov       rdi,[rcx+198]
       mov       rcx,rsi
       mov       r11,7FF9CEDB0730
       mov       edx,5
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FF9CF20A710
       mov       edx,5A
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1F45CC07890
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1F466C00C58
       mov       r8,[r8]
       mov       rdx,rsi
       mov       r9,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+18]
M00_L00:
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 118
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebug_EasyLogger_Benchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FF9DB4F0788
       mov       edx,1
       call      qword ptr [7FF9DB4F0788]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FF9DB7A7320
       mov       edx,48
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,173F1C68800
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,17451C61C18
       mov       r8,[r8]
       mov       rdx,rsi
       xor       r9d,r9d
       mov       rax,[rax+18]
       add       rsp,20
       pop       rsi
       jmp       rax
M00_L00:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 114
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebug_EasyLogger_Benchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FF9CEDC06D0
       mov       edx,1
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FF9CF21A710
       mov       edx,5A
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,18C37803490
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,18C43800C58
       mov       r8,[r8]
       mov       rdx,rsi
       xor       r9d,r9d
       add       rsp,20
       pop       rsi
       jmp       qword ptr [rax+18]
M00_L00:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 108
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogError_EasyLogger_Benchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FF9DB4E0798
       mov       edx,4
       call      qword ptr [7FF9DB4E0798]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FF9DB797320
       mov       edx,48
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1ECF1648808
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1ED51641C18
       mov       r8,[r8]
       mov       rdx,rsi
       xor       r9d,r9d
       mov       rax,[rax+18]
       add       rsp,20
       pop       rsi
       jmp       rax
M00_L00:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 114
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogError_EasyLogger_Benchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FF9CEDF06D0
       mov       edx,4
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FF9CF24A710
       mov       edx,5A
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,287330078A0
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,28731009C08
       mov       r8,[r8]
       mov       rdx,rsi
       xor       r9d,r9d
       add       rsp,20
       pop       rsi
       jmp       qword ptr [rax+18]
M00_L00:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 108
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogException_EasyLogger_Benchmark()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+190]
       mov       rdi,[rcx+198]
       mov       rcx,rsi
       mov       r11,7FF9DB510728
       mov       edx,4
       call      qword ptr [7FF9DB510728]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FF9DB7C7320
       mov       edx,48
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1C883A96818
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1C8F3A91C18
       mov       r8,[r8]
       mov       rdx,rsi
       mov       r9,rdi
       mov       rax,[rax+18]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M00_L00:
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 124
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogException_EasyLogger_Benchmark()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+190]
       mov       rdi,[rcx+198]
       mov       rcx,rsi
       mov       r11,7FF9CEDE06C0
       mov       edx,4
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FF9CF23A710
       mov       edx,5A
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,272B58078A8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,272C5800C58
       mov       r8,[r8]
       mov       rdx,rsi
       mov       r9,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+18]
M00_L00:
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 118
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformation_EasyLogger_Benchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FF9DB520798
       mov       edx,2
       call      qword ptr [7FF9DB520798]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FF9DB7D7320
       mov       edx,48
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2B114BE8818
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,2B184BE1C18
       mov       r8,[r8]
       mov       rdx,rsi
       xor       r9d,r9d
       mov       rax,[rax+18]
       add       rsp,20
       pop       rsi
       jmp       rax
M00_L00:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 114
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformation_EasyLogger_Benchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FF9CEDB06D0
       mov       edx,2
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FF9CF20A710
       mov       edx,5A
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2C86F8078B0
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,2C86B809C08
       mov       r8,[r8]
       mov       rdx,rsi
       xor       r9d,r9d
       add       rsp,20
       pop       rsi
       jmp       qword ptr [rax+18]
M00_L00:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 108
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTrace_EasyLogger_Benchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FF9DB4F0798
       xor       edx,edx
       call      qword ptr [7FF9DB4F0798]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FF9DB7A7320
       mov       edx,48
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,269BCBE8820
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,26A0CBE1C18
       mov       r8,[r8]
       mov       rdx,rsi
       xor       r9d,r9d
       mov       rax,[rax+18]
       add       rsp,20
       pop       rsi
       jmp       rax
M00_L00:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 111
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTrace_EasyLogger_Benchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FF9CEDD0720
       xor       edx,edx
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FF9CF22A710
       mov       edx,5A
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,14D590078B8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,14D59009850
       mov       r8,[r8]
       mov       rdx,rsi
       xor       r9d,r9d
       add       rsp,20
       pop       rsi
       jmp       qword ptr [rax+18]
M00_L00:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 105
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarning_EasyLogger_Benchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FF9DB510798
       mov       edx,3
       call      qword ptr [7FF9DB510798]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FF9DB7C7320
       mov       edx,48
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,29C555C8828
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,29CA55C1C18
       mov       r8,[r8]
       mov       rdx,rsi
       xor       r9d,r9d
       mov       rax,[rax+18]
       add       rsp,20
       pop       rsi
       jmp       rax
M00_L00:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 114
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarning_EasyLogger_Benchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FF9CEDE06C0
       mov       edx,3
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FF9CF23A710
       mov       edx,5A
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FCB28078C0
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1FCAE801470
       mov       r8,[r8]
       mov       rdx,rsi
       xor       r9d,r9d
       add       rsp,20
       pop       rsi
       jmp       qword ptr [rax+18]
M00_L00:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 108
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCritical_EazyLoggerExtensions_Benchmark()
       mov       [rsp+8],rcx
       mov       rcx,[rcx+190]
       mov       r8,[rsp+8]
       mov       r8,[r8+198]
       mov       rdx,1D07F901C18
       mov       rdx,[rdx]
       mov       r9,1D07F901C20
       mov       r9,[r9]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogCriticalMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogCriticalMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       rcx,rsi
       mov       r11,7FF9DB5107A0
       mov       edx,5
       call      qword ptr [7FF9DB5107A0]
       test      eax,eax
       je        near ptr M01_L00
       mov       r14d,390
       mov       rcx,1D07F901C28
       mov       r15,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogCriticalMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogCriticalMessageStruct, System.Exception, System.Func`3<__LogCriticalMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r12,rax
       mov       [rsp+40],r15
       mov       [rsp+48],r14d
       mov       [rsp+30],rdi
       mov       [rsp+38],rbp
       mov       rcx,7FF9DB7C7320
       mov       edx,6E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1D02F9088C0
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+40]
       lea       r9,[rsp+30]
       mov       [rsp+20],rbx
       mov       edx,5
       call      r12
M01_L00:
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 224
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCritical_EazyLoggerExtensions_Benchmark()
       mov       [rsp+8],rcx
       mov       rcx,[rcx+190]
       mov       r8,[rsp+8]
       mov       r8,[r8+198]
       mov       rdx,16A6E800C58
       mov       rdx,[rdx]
       mov       r9,16A6E800C60
       mov       r9,[r9]
       jmp       qword ptr [7FF9CF63F300]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogCriticalMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogCriticalMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       rcx,rsi
       mov       r11,7FF9CEDD0738
       mov       edx,5
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L00
       mov       rcx,16A6E800C68
       mov       r14,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogCriticalMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogCriticalMessageStruct, System.Exception, System.Func`3<__LogCriticalMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r15,rax
       mov       [rsp+48],r14
       mov       dword ptr [rsp+50],390
       mov       [rsp+38],rdi
       mov       [rsp+40],rbp
       mov       rcx,7FF9CF22A710
       mov       edx,92
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,16A5E807960
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       [rsp+20],rbx
       mov       edx,5
       call      r15
M01_L00:
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 220
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogError_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,1BFE9221F90
       mov       rdx,[rdx]
       mov       r8,1BFE9221F98
       mov       r8,[r8]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogErrorMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 38
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogErrorMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       mov       r11,7FF9DB500790
       mov       edx,4
       call      qword ptr [7FF9DB500790]
       test      eax,eax
       je        near ptr M01_L00
       mov       ebp,12D
       mov       rcx,1BFE9221FA0
       mov       r14,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogErrorMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogErrorMessageStruct, System.Exception, System.Func`3<__LogErrorMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r15,rax
       mov       [rsp+48],r14
       mov       [rsp+50],ebp
       mov       [rsp+38],rdi
       mov       [rsp+40],rbx
       mov       rcx,7FF9DB7B7320
       mov       edx,70
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1BFE92188D0
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       edx,4
       xor       eax,eax
       mov       [rsp+20],rax
       call      r15
M01_L00:
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 223
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogError_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,235E6C09850
       mov       rdx,[rdx]
       mov       r8,235E6C09858
       mov       r8,[r8]
       jmp       qword ptr [7FF9CF65F030]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogErrorMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogErrorMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       mov       r11,7FF9CEDF06D8
       mov       edx,4
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L00
       mov       rcx,235E6C09860
       mov       rbp,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogErrorMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogErrorMessageStruct, System.Exception, System.Func`3<__LogErrorMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       [rsp+40],rbp
       mov       dword ptr [rsp+48],12D
       mov       [rsp+30],rdi
       mov       [rsp+38],rbx
       mov       rcx,7FF9CF24A710
       mov       edx,94
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,235E6C07970
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+40]
       lea       r9,[rsp+30]
       mov       edx,4
       xor       eax,eax
       mov       [rsp+20],rax
       call      r14
M01_L00:
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 209
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogException_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,1EAB6C11C18
       mov       rdx,[rdx]
       mov       r8,1EAB6C11C20
       mov       r8,[r8]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogDebugMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 38
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogDebugMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       mov       r11,7FF9DB5007A0
       mov       edx,1
       call      qword ptr [7FF9DB5007A0]
       test      eax,eax
       je        near ptr M01_L00
       mov       ebp,0C9
       mov       rcx,1EA46C15470
       mov       r14,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogDebugMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogDebugMessageStruct, System.Exception, System.Func`3<__LogDebugMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r15,rax
       mov       [rsp+48],r14
       mov       [rsp+50],ebp
       mov       [rsp+38],rdi
       mov       [rsp+40],rbx
       mov       rcx,7FF9DB7B7320
       mov       edx,6F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1EA46C144C0
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       edx,1
       xor       eax,eax
       mov       [rsp+20],rax
       call      r15
M01_L00:
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 223
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogException_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,1FCE6800C58
       mov       rdx,[rdx]
       mov       r8,1FCE6800C60
       mov       r8,[r8]
       jmp       qword ptr [7FF9CF62F018]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogDebugMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogDebugMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       mov       r11,7FF9CEDC06D8
       mov       edx,1
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L00
       mov       rcx,1FCDA8088B0
       mov       rbp,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogDebugMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogDebugMessageStruct, System.Exception, System.Func`3<__LogDebugMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       [rsp+40],rbp
       mov       dword ptr [rsp+48],0C9
       mov       [rsp+30],rdi
       mov       [rsp+38],rbx
       mov       rcx,7FF9CF21A710
       mov       edx,93
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FCDA807968
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+40]
       lea       r9,[rsp+30]
       mov       edx,1
       xor       eax,eax
       mov       [rsp+20],rax
       call      r14
M01_L00:
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 209
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformation_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,1F57B211C18
       mov       rdx,[rdx]
       mov       r8,1F57B211C20
       mov       r8,[r8]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogInformationMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 38
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogInformationMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       mov       r11,7FF9DB510730
       mov       edx,2
       call      qword ptr [7FF9DB510730]
       test      eax,eax
       je        near ptr M01_L00
       mov       ebp,191
       mov       rcx,1F57B211C28
       mov       r14,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogInformationMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogInformationMessageStruct, System.Exception, System.Func`3<__LogInformationMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r15,rax
       mov       [rsp+48],r14
       mov       [rsp+50],ebp
       mov       [rsp+38],rdi
       mov       [rsp+40],rbx
       mov       rcx,7FF9DB7C7320
       mov       edx,72
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1F4EB2188E0
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       edx,2
       xor       eax,eax
       mov       [rsp+20],rax
       call      r15
M01_L00:
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 223
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformation_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,22400800C58
       mov       rdx,[rdx]
       mov       r8,22400800C60
       mov       r8,[r8]
       jmp       qword ptr [7FF9CF62F360]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogInformationMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogInformationMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       mov       r11,7FF9CEDC06D8
       mov       edx,2
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L00
       mov       rcx,22400800C68
       mov       rbp,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogInformationMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogInformationMessageStruct, System.Exception, System.Func`3<__LogInformationMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       [rsp+40],rbp
       mov       dword ptr [rsp+48],191
       mov       [rsp+30],rdi
       mov       [rsp+38],rbx
       mov       rcx,7FF9CF21A710
       mov       edx,96
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,223F0807980
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+40]
       lea       r9,[rsp+30]
       mov       edx,2
       xor       eax,eax
       mov       [rsp+20],rax
       call      r14
M01_L00:
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 209
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogStoredProcedureError_EazyLoggerExtensions_Benchmark()
       mov       [rsp+8],rcx
       mov       rcx,[rcx+190]
       mov       r8,[rsp+8]
       mov       r8,[r8+198]
       mov       rdx,21DE96C1C18
       mov       rdx,[rdx]
       mov       r9,21DE96C1C20
       mov       r9,[r9]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureError(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureError(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       rcx,rsi
       mov       r11,7FF9DB4F0790
       mov       edx,4
       call      qword ptr [7FF9DB4F0790]
       test      eax,eax
       je        near ptr M01_L00
       mov       r14d,1F6
       mov       rcx,21DE96C1C28
       mov       r15,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogStoredProcedureErrorStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogStoredProcedureErrorStruct, System.Exception, System.Func`3<__LogStoredProcedureErrorStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r12,rax
       mov       [rsp+40],r15
       mov       [rsp+48],r14d
       mov       [rsp+30],rdi
       mov       [rsp+38],rbp
       mov       rcx,7FF9DB7A7320
       mov       edx,73
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21DF96C88E8
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+40]
       lea       r9,[rsp+30]
       mov       [rsp+20],rbx
       mov       edx,4
       call      r12
M01_L00:
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 224
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogStoredProcedureError_EazyLoggerExtensions_Benchmark()
       mov       [rsp+8],rcx
       mov       rcx,[rcx+190]
       mov       r8,[rsp+8]
       mov       r8,[r8+198]
       mov       rdx,22AF7009C08
       mov       rdx,[rdx]
       mov       r9,22AF7009C10
       mov       r9,[r9]
       jmp       qword ptr [7FF9CF61F378]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureError(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureError(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       rcx,rsi
       mov       r11,7FF9CEDB06D8
       mov       edx,4
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L00
       mov       rcx,22AF7009C18
       mov       r14,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogStoredProcedureErrorStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogStoredProcedureErrorStruct, System.Exception, System.Func`3<__LogStoredProcedureErrorStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r15,rax
       mov       [rsp+48],r14
       mov       dword ptr [rsp+50],1F6
       mov       [rsp+38],rdi
       mov       [rsp+40],rbp
       mov       rcx,7FF9CF20A710
       mov       edx,97
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,22AE5007988
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       [rsp+20],rbx
       mov       edx,4
       call      r15
M01_L00:
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 220
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogStoredProcedureNoRecordsFound_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,2AF99AC1C18
       mov       rdx,[rdx]
       mov       r8,2AF99AC1C20
       mov       r8,[r8]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureNoRecordsFound(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 38
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureNoRecordsFound(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       mov       r11,7FF9DB5207A0
       mov       edx,4
       call      qword ptr [7FF9DB5207A0]
       test      eax,eax
       je        near ptr M01_L00
       mov       ebp,25A
       mov       rcx,2AF99AC1C28
       mov       r14,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogStoredProcedureNoRecordsFoundStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogStoredProcedureNoRecordsFoundStruct, System.Exception, System.Func`3<__LogStoredProcedureNoRecordsFoundStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r15,rax
       mov       [rsp+48],r14
       mov       [rsp+50],ebp
       mov       [rsp+38],rdi
       mov       [rsp+40],rbx
       mov       rcx,7FF9DB7D7320
       mov       edx,74
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2AF49AC88F0
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       edx,4
       xor       eax,eax
       mov       [rsp+20],rax
       call      r15
M01_L00:
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 223
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogStoredProcedureNoRecordsFound_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,19AFF800C58
       mov       rdx,[rdx]
       mov       r8,19AFF800C60
       mov       r8,[r8]
       jmp       qword ptr [7FF9CF63FC00]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureNoRecordsFound(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureNoRecordsFound(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       mov       r11,7FF9CEDC0738
       mov       edx,4
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L00
       mov       rcx,19AFF800C68
       mov       rbp,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogStoredProcedureNoRecordsFoundStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogStoredProcedureNoRecordsFoundStruct, System.Exception, System.Func`3<__LogStoredProcedureNoRecordsFoundStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       [rsp+40],rbp
       mov       dword ptr [rsp+48],25A
       mov       [rsp+30],rdi
       mov       [rsp+38],rbx
       mov       rcx,7FF9CF21A710
       mov       edx,98
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,19AF5807990
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+40]
       lea       r9,[rsp+30]
       mov       edx,4
       xor       eax,eax
       mov       [rsp+20],rax
       call      r14
M01_L00:
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 209
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTrace_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,266083227A8
       mov       rdx,[rdx]
       mov       r8,266083227B0
       mov       r8,[r8]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogTraceMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 38
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogTraceMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       mov       r11,7FF9DB500740
       xor       edx,edx
       call      qword ptr [7FF9DB500740]
       test      eax,eax
       je        near ptr M01_L00
       mov       ebp,65
       mov       rcx,266083227B8
       mov       r14,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogTraceMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogTraceMessageStruct, System.Exception, System.Func`3<__LogTraceMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r15,rax
       mov       [rsp+48],r14
       mov       [rsp+50],ebp
       mov       [rsp+38],rdi
       mov       [rsp+40],rbx
       mov       rcx,7FF9DB7B7320
       mov       edx,75
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,266083188F8
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       xor       edx,edx
       xor       eax,eax
       mov       [rsp+20],rax
       call      r15
M01_L00:
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 217
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTrace_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,15B8B809850
       mov       rdx,[rdx]
       mov       r8,15B8B809858
       mov       r8,[r8]
       jmp       qword ptr [7FF9CF61F3A8]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogTraceMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogTraceMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       mov       r11,7FF9CEDB0738
       xor       edx,edx
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L00
       mov       rcx,15B8B809860
       mov       rbp,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogTraceMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogTraceMessageStruct, System.Exception, System.Func`3<__LogTraceMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       [rsp+40],rbp
       mov       dword ptr [rsp+48],65
       mov       [rsp+30],rdi
       mov       [rsp+38],rbx
       mov       rcx,7FF9CF20A710
       mov       edx,99
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,15B8B807998
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+40]
       lea       r9,[rsp+30]
       xor       edx,edx
       xor       eax,eax
       mov       [rsp+20],rax
       call      r14
M01_L00:
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 203
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarning_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,12F39B41C18
       mov       rdx,[rdx]
       mov       r8,12F39B41C20
       mov       r8,[r8]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogWarningMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 38
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogWarningMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       mov       r11,7FF9DB4F0740
       mov       edx,3
       call      qword ptr [7FF9DB4F0740]
       test      eax,eax
       je        near ptr M01_L00
       mov       ebp,259
       mov       rcx,12F39B41C28
       mov       r14,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogWarningMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogWarningMessageStruct, System.Exception, System.Func`3<__LogWarningMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r15,rax
       mov       [rsp+48],r14
       mov       [rsp+50],ebp
       mov       [rsp+38],rdi
       mov       [rsp+40],rbx
       mov       rcx,7FF9DB7A7320
       mov       edx,76
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,12EC9B48900
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       edx,3
       xor       eax,eax
       mov       [rsp+20],rax
       call      r15
M01_L00:
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 223
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarning_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,23F30C00C58
       mov       rdx,[rdx]
       mov       r8,23F30C00C60
       mov       r8,[r8]
       jmp       qword ptr [7FF9CF62D0C0]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogWarningMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogWarningMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       mov       r11,7FF9CEDB0738
       mov       edx,3
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L00
       mov       rcx,23F30C00C68
       mov       rbp,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogWarningMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogWarningMessageStruct, System.Exception, System.Func`3<__LogWarningMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       [rsp+40],rbp
       mov       dword ptr [rsp+48],259
       mov       [rsp+30],rdi
       mov       [rsp+38],rbx
       mov       rcx,7FF9CF20A710
       mov       edx,9A
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23F26C059A8
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+40]
       lea       r9,[rsp+30]
       mov       edx,3
       xor       eax,eax
       mov       [rsp+20],rax
       call      r14
M01_L00:
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 209
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCritical_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+198]
       mov       rcx,1E89EC12F48
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,1E89EC227A8
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
       mov       r9,1E89EC18F50
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
       mov       rdx,7FF9DB92F340
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.ThrowHelper.Throw(System.String)
       int       3
; Total bytes of code 217
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       r8,22A22800C58
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,22A1C801F78
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,5
       call      qword ptr [7FF9CF64F3D8]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FF9CF64F450]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,22A1C808208
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
       mov       rdx,7FF9CF3955C0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF5F93D8]
       int       3
; Total bytes of code 219
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebug_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+198]
       mov       rcx,1DFACF52F48
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,1DF9CF51C18
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
       mov       r9,1DFACF58F50
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
       mov       rdx,7FF9DB92F340
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.ThrowHelper.Throw(System.String)
       int       3
; Total bytes of code 217
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       r8,1A050000C58
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,1A04A001F78
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,1
       call      qword ptr [7FF9CF64D3F0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FF9CF64D468]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,1A04A008208
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
       mov       rdx,7FF9CF3955C0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF5F73D8]
       int       3
; Total bytes of code 219
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogError_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+198]
       mov       rcx,1DD02E12F48
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,1DD72E11C18
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
       mov       r9,1DD02E18F50
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
       mov       rdx,7FF9DB94F340
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.ThrowHelper.Throw(System.String)
       int       3
; Total bytes of code 217
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       r8,20C5E409850
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,20C5E401F78
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,4
       call      qword ptr [7FF9CF62F3D8]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FF9CF62F450]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,20C5E408208
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
       mov       rdx,7FF9CF3755C0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF5D7FA8]
       int       3
; Total bytes of code 219
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformation_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+198]
       mov       rcx,19E5F422F48
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,19ECF421C18
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
       mov       r9,19E5F428F50
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
       mov       rdx,7FF9DB91F340
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.ThrowHelper.Throw(System.String)
       int       3
; Total bytes of code 217
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       r8,23303400C58
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,232FB401F78
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,2
       call      qword ptr [7FF9CF62F6D8]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FF9CF62F750]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,232FB408208
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
       mov       rdx,7FF9CF3855C0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF5E7FA8]
       int       3
; Total bytes of code 219
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTrace_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+198]
       mov       rcx,1A760952F48
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,1A7A0951C18
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
       mov       r9,1A740954B48
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
       mov       rdx,7FF9DB92F340
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.ThrowHelper.Throw(System.String)
       int       3
; Total bytes of code 217
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       r8,1CAF0012800
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,1CAF0001F78
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       xor       edx,edx
       call      qword ptr [7FF9CF65FF48]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FF9CF671018]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,1CAF0008208
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
       mov       rdx,7FF9CF3A55C0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF60B3D8]
       int       3
; Total bytes of code 219
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarning_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+198]
       mov       rcx,21F65442F48
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,21F6544A810
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
       mov       r9,21F65448F50
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
       mov       rdx,7FF9DB92F340
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.ThrowHelper.Throw(System.String)
       int       3
; Total bytes of code 217
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       r8,1DBD2800C58
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,1DBC8801F78
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,3
       call      qword ptr [7FF9CF63FC48]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FF9CF63FCC0]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,1DBC8808208
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
       mov       rdx,7FF9CF3855C0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CF5EB3D8]
       int       3
; Total bytes of code 219
```

