## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCriticalBenchmark()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+190]
       mov       rdi,[rcx+198]
       mov       rcx,rsi
       mov       r11,7FF7B98C0578
       mov       edx,5
       call      qword ptr [7FF7B98C0578]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FF7B9B75BD0
       mov       edx,3F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,201536A8750
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,201536B24C8
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCriticalBenchmark()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+190]
       mov       rdi,[rcx+198]
       mov       rcx,rsi
       mov       r11,7FFF7EC805A0
       mov       edx,5
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFF7F0E9410
       mov       edx,3F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1BD69407758
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1BD694115B8
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebugBenchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FF7B98C0578
       mov       edx,1
       call      qword ptr [7FF7B98C0578]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FF7B9B75BD0
       mov       edx,3F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2C996758758
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,2C9967634E0
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebugBenchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FFF7EC805A0
       mov       edx,1
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFF7F0E9410
       mov       edx,3F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23804007760
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,238040115B8
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogErrorBenchmark()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+190]
       mov       rdi,[rcx+198]
       mov       rcx,rsi
       mov       r11,7FF7B98B0578
       mov       edx,4
       call      qword ptr [7FF7B98B0578]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FF7B9B65BD0
       mov       edx,3F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1C3E5A04358
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1C3E5A0E0C0
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogErrorBenchmark()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+190]
       mov       rdi,[rcx+198]
       mov       rcx,rsi
       mov       r11,7FFF7EC905A0
       mov       edx,4
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFF7F0F9410
       mov       edx,3F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2AC84007768
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,2AC840115B8
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformationBenchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FF7B98C0578
       mov       edx,2
       call      qword ptr [7FF7B98C0578]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FF7B9B75BD0
       mov       edx,3F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,15E25C28768
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,15E25C324C8
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformationBenchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FFF7EC705A0
       mov       edx,2
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFF7F0D9410
       mov       edx,3F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,16661403368
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1666140D1B0
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTraceBenchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FF7B98E0578
       xor       edx,edx
       call      qword ptr [7FF7B98E0578]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FF7B9B95BD0
       mov       edx,3F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1F5924D8770
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1F5924E34E0
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTraceBenchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FFF7EC605A0
       xor       edx,edx
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFF7F0C9410
       mov       edx,3F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2AC03407778
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,2AC034115B8
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarningBenchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FF7B98C0578
       mov       edx,3
       call      qword ptr [7FF7B98C0578]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FF7B9B75BD0
       mov       edx,3F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,20C27B18778
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,20C27B224C8
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarningBenchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FFF7EC805A0
       mov       edx,3
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFF7F0E9410
       mov       edx,3F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1C92A807780
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1C9328089C0
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogCriticalBenchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+198]
       mov       rcx,26393E12F80
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,26393E224C8
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
       mov       r9,26393E18E00
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
       mov       rdx,7FF7B9D0AF80
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.ThrowHelper.Throw(System.String)
       int       3
; Total bytes of code 217
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogCriticalBenchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       mov       r9,[rcx+198]
       mov       rcx,r8
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,266580089C0
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,26650001FB8
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,5
       call      qword ptr [7FFF7F3373F0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FFF7F337468]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,26650008020
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
       mov       rdx,7FFF7F2417E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7F2B5438]
       int       3
; Total bytes of code 219
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogDebugBenchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+198]
       mov       rcx,23C73E42F80
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,23C73E524C8
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
       mov       r9,23C73E48E00
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
       mov       rdx,7FF7B9CFAF80
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.ThrowHelper.Throw(System.String)
       int       3
; Total bytes of code 217
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogDebugBenchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       mov       r9,[rcx+198]
       mov       rcx,r8
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,1B2F80115B8
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,1B2F8001FB8
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,1
       call      qword ptr [7FFF7F3576F0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FFF7F357768]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,1B2F8008020
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
       mov       rdx,7FFF7F2617E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7F2D5438]
       int       3
; Total bytes of code 219
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogErrorBenchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+198]
       mov       rcx,295DFE72F80
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,295DFE824C8
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
       mov       r9,295DFE78E00
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
       mov       rdx,7FF7B9CEAF80
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.ThrowHelper.Throw(System.String)
       int       3
; Total bytes of code 217
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogErrorBenchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       mov       r9,[rcx+198]
       mov       rcx,r8
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,1D1570115B8
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,1D157001FB8
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,4
       call      qword ptr [7FFF7F3373F0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FFF7F337468]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,1D157008020
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
       mov       rdx,7FFF7F2417E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7F2B5438]
       int       3
; Total bytes of code 219
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogInformationBenchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+198]
       mov       rcx,17F09B12F80
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,17EE9B1F0D8
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
       mov       r9,17EE9B149F8
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
       mov       rdx,7FF7B9CFAF80
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.ThrowHelper.Throw(System.String)
       int       3
; Total bytes of code 217
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogInformationBenchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       mov       r9,[rcx+198]
       mov       rcx,r8
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,22DE18091D8
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,22DE5801FB8
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,2
       call      qword ptr [7FFF7F3573F0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FFF7F357468]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,22DE5808020
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
       mov       rdx,7FFF7F2617E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7F2D5438]
       int       3
; Total bytes of code 219
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogTraceBenchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+198]
       mov       rcx,162EB3E2F80
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,1630B3E98D0
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
       mov       r9,162EB3E8E00
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
       mov       rdx,7FF7B9D0AF80
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.ThrowHelper.Throw(System.String)
       int       3
; Total bytes of code 217
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogTraceBenchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       mov       r9,[rcx+198]
       mov       rcx,r8
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,1D3F980D1B0
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,1D3FD801FB8
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       xor       edx,edx
       call      qword ptr [7FFF7F3373F0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FFF7F337468]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,1D3F9803C18
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
       mov       rdx,7FFF7F2417E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7F2B5438]
       int       3
; Total bytes of code 219
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogWarningBenchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+198]
       mov       rcx,26EDB552F80
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,26EDB5624C8
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
       mov       r9,26EDB558E00
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
       mov       rdx,7FF7B9CEAF80
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.ThrowHelper.Throw(System.String)
       int       3
; Total bytes of code 217
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogWarningBenchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       mov       r9,[rcx+198]
       mov       rcx,r8
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,22C810115B8
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,22C81001FB8
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,3
       call      qword ptr [7FFF7F3576F0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FFF7F357768]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,22C81008020
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
       mov       rdx,7FFF7F2617E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7F2D5438]
       int       3
; Total bytes of code 219
```

