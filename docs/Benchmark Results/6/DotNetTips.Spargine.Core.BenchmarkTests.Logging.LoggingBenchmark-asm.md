## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCriticalBenchmark()
; 			EasyLogger.LogCritical(logger: this._logger, message: CriticalMessage, ex: this._testException);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+0B8]
       mov       rdi,[rcx+0C0]
       mov       rcx,rsi
       mov       r11,7FF82CBE0588
       mov       edx,5
       call      qword ptr [588]
       test      eax,eax
       je        short 00000000000019A5
       mov       rcx,7FF82CEE2298
       mov       edx,3D
       call      000000000000B4B0
       mov       rcx,224D3DB75F8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,224B3DB21A8
       mov       r8,[r8]
       mov       rdx,rsi
       mov       r9,rdi
       mov       rax,[rax+18]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 124
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCriticalBenchmark()
; 			EasyLogger.LogCritical(logger: this._logger, message: CriticalMessage, ex: this._testException);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+0B8]
       mov       rdi,[rcx+0C0]
       mov       rcx,rsi
       mov       r11,7FF82E7F05B0
       mov       edx,5
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000F82F
       mov       rcx,7FF82EC2D2F8
       mov       edx,3D
       call      000000000000F180
       mov       rcx,22383802338
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,2237F805660
       mov       r8,[r8]
       mov       rdx,rsi
       mov       r9,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+18]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 118
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebugBenchmark()
; 			EasyLogger.LogDebug(this._logger, DebugMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+0B8]
       mov       rcx,rsi
       mov       r11,7FF82CBE0588
       mov       edx,1
       call      qword ptr [588]
       test      eax,eax
       je        short 000000000000058C
       mov       rcx,7FF82CED2298
       mov       edx,3D
       call      000000000000B4B0
       mov       rcx,23169E77600
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,23169E7A588
       mov       r8,[r8]
       mov       rdx,rsi
       xor       r9d,r9d
       mov       rax,[rax+18]
       add       rsp,20
       pop       rsi
       jmp       rax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 114
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebugBenchmark()
; 			EasyLogger.LogDebug(this._logger, DebugMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+0B8]
       mov       rcx,rsi
       mov       r11,7FF82E8105B0
       mov       edx,1
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000E726
       mov       rcx,7FF82EC3D2F8
       mov       edx,3D
       call      000000000000F180
       mov       rcx,1BA41406748
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1BA41408E20
       mov       r8,[r8]
       mov       rdx,rsi
       xor       r9d,r9d
       add       rsp,20
       pop       rsi
       jmp       qword ptr [rax+18]
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 108
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogErrorBenchmark()
; 			EasyLogger.LogError(logger: this._logger, message: ErrorMessage, ex: this._testException);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+0B8]
       mov       rdi,[rcx+0C0]
       mov       rcx,rsi
       mov       r11,7FF82CBE0588
       mov       edx,4
       call      qword ptr [588]
       test      eax,eax
       je        short 00000000000006B5
       mov       rcx,7FF82CED2298
       mov       edx,3D
       call      000000000000B4B0
       mov       rcx,25669367608
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,25679361990
       mov       r8,[r8]
       mov       rdx,rsi
       mov       r9,rdi
       mov       rax,[rax+18]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 124
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogErrorBenchmark()
; 			EasyLogger.LogError(logger: this._logger, message: ErrorMessage, ex: this._testException);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+0B8]
       mov       rdi,[rcx+0C0]
       mov       rcx,rsi
       mov       r11,7FF82E7F05B0
       mov       edx,4
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000E74F
       mov       rcx,7FF82EC1D2F8
       mov       edx,3D
       call      000000000000F180
       mov       rcx,26038C02348
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,2603AC05660
       mov       r8,[r8]
       mov       rdx,rsi
       mov       r9,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+18]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 118
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformationBenchmark()
; 			EasyLogger.LogInformation(this._logger, ErrorMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+0B8]
       mov       rcx,rsi
       mov       r11,7FF82CBA0588
       mov       edx,2
       call      qword ptr [588]
       test      eax,eax
       je        short 00000000000006AC
       mov       rcx,7FF82CE92298
       mov       edx,3D
       call      000000000000B4B0
       mov       rcx,1FD4C233208
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1FD3C235D98
       mov       r8,[r8]
       mov       rdx,rsi
       xor       r9d,r9d
       mov       rax,[rax+18]
       add       rsp,20
       pop       rsi
       jmp       rax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 114
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformationBenchmark()
; 			EasyLogger.LogInformation(this._logger, ErrorMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+0B8]
       mov       rcx,rsi
       mov       r11,7FF82E7F05B0
       mov       edx,2
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000E726
       mov       rcx,7FF82EC1D2F8
       mov       edx,3D
       call      000000000000F180
       mov       rcx,1E4C2002350
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1E4C2005230
       mov       r8,[r8]
       mov       rdx,rsi
       xor       r9d,r9d
       add       rsp,20
       pop       rsi
       jmp       qword ptr [rax+18]
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 108
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTraceBenchmark()
; 			EasyLogger.LogTrace(this._logger, TraceMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+0B8]
       mov       rcx,rsi
       mov       r11,7FF82CBB0588
       xor       edx,edx
       call      qword ptr [588]
       test      eax,eax
       je        short 00000000000006A9
       mov       rcx,7FF82CEA2298
       mov       edx,3D
       call      000000000000B4B0
       mov       rcx,1EA72287618
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1EA922821A8
       mov       r8,[r8]
       mov       rdx,rsi
       xor       r9d,r9d
       mov       rax,[rax+18]
       add       rsp,20
       pop       rsi
       jmp       rax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 111
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTraceBenchmark()
; 			EasyLogger.LogTrace(this._logger, TraceMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+0B8]
       mov       rcx,rsi
       mov       r11,7FF82E7F05B0
       xor       edx,edx
       call      qword ptr [r11]
       test      eax,eax
       je        short 000000000000E723
       mov       rcx,7FF82EC1D2F8
       mov       edx,3D
       call      000000000000F180
       mov       rcx,19242406760
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,19244400A40
       mov       r8,[r8]
       mov       rdx,rsi
       xor       r9d,r9d
       add       rsp,20
       pop       rsi
       jmp       qword ptr [rax+18]
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 105
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarningBenchmark()
; 			EasyLogger.LogWarning(this._logger, WarningMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+0B8]
       mov       rcx,rsi
       mov       r11,7FF82CBB0588
       mov       edx,3
       call      qword ptr [588]
       test      eax,eax
       je        short 00000000000006AC
       mov       rcx,7FF82CEA2298
       mov       edx,3D
       call      000000000000B4B0
       mov       rcx,19038347620
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1903834A588
       mov       r8,[r8]
       mov       rdx,rsi
       xor       r9d,r9d
       mov       rax,[rax+18]
       add       rsp,20
       pop       rsi
       jmp       rax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 114
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogCriticalBenchmark()
; 			this._logger.LogCritical(100, this._testException, DebugMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+0B8]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+0C0]
       mov       rcx,29863258000
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,29863259D70
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+28],rcx
       mov       rcx,r8
       lea       r8,[rsp+38]
       mov       r9,rax
       mov       edx,5
       call      000000000000CCF0
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
       je        near ptr 000000000000126C
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      000000000000CD20
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
       call      0000000000005ED0
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
       mov       r9,29863257A78
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FF82CFB7588
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       int       3
; Total bytes of code 246
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogCriticalBenchmark()
; 			this._logger.LogCritical(100, this._testException, DebugMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+0B8]
       mov       r9,[rcx+0C0]
       mov       rcx,r8
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,2917040A650
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,291704076B0
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,5
       call      qword ptr [7F78]
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
       je        near ptr 000000000000EEFD
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      qword ptr [9018]
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
       call      00000000000099F0
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
       mov       r9,29170406D70
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FF82ED09020
       call      000000000000F510
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0FAF8]
       mov       rcx,rsi
       call      0000000000006AD0
       int       3
; Total bytes of code 248
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogDebugBenchmark()
; 			this._logger.LogDebug(100, this._testException, DebugMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+0B8]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+0C0]
       mov       rcx,18D90C28000
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,18D90C2A588
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+28],rcx
       mov       rcx,r8
       lea       r8,[rsp+38]
       mov       r9,rax
       mov       edx,1
       call      000000000000CCF0
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
       je        near ptr 000000000000126C
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      000000000000CD20
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
       call      0000000000005ED0
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
       mov       r9,18D90C27A78
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FF82CFC7588
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       int       3
; Total bytes of code 246
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogDebugBenchmark()
; 			this._logger.LogDebug(100, this._testException, DebugMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+0B8]
       mov       r9,[rcx+0C0]
       mov       rcx,r8
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,263E5400A40
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,263E14076B0
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,1
       call      qword ptr [93D8]
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
       je        near ptr 000000000000EEFD
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      qword ptr [9450]
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
       call      00000000000099F0
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
       mov       r9,263E1406D70
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FF82ED39020
       call      000000000000F510
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0FAF8]
       mov       rcx,rsi
       call      0000000000006AD0
       int       3
; Total bytes of code 248
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogErrorBenchmark()
; 			this._logger.LogError(eventId: 100, exception: this._testException, message: ErrorMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+0B8]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+0C0]
       mov       rcx,25041A66008
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,25021A61990
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+28],rcx
       mov       rcx,r8
       lea       r8,[rsp+38]
       mov       r9,rax
       mov       edx,4
       call      000000000000CCD8
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
       je        near ptr 000000000000114C
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      000000000000CD08
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
       call      0000000000005ED0
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
       mov       r9,25041A65A80
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FF82CFB7588
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       int       3
; Total bytes of code 246
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogErrorBenchmark()
; 			this._logger.LogError(eventId: 100, exception: this._testException, message: ErrorMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+0B8]
       mov       r9,[rcx+0C0]
       mov       rcx,r8
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,29D38801258
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,29D348076B0
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,4
       call      qword ptr [93D8]
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
       je        near ptr 000000000000EEFD
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      qword ptr [9450]
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
       call      00000000000099F0
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
       mov       r9,29D34806D70
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FF82ED29020
       call      000000000000F510
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0FAF8]
       mov       rcx,rsi
       call      0000000000006AD0
       int       3
; Total bytes of code 248
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogInformationBenchmark()
; 			this._logger.LogInformation(100, this._testException, InformationMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+0B8]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+0C0]
       mov       rcx,21E88288000
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,21E982821A8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+28],rcx
       mov       rcx,r8
       lea       r8,[rsp+38]
       mov       r9,rax
       mov       edx,2
       call      000000000000CCF0
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
       je        near ptr 000000000000126C
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      000000000000CD20
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
       call      0000000000005ED0
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
       mov       r9,21E88287A78
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FF82CFA7588
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       int       3
; Total bytes of code 246
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogInformationBenchmark()
; 			this._logger.LogInformation(100, this._testException, InformationMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+0B8]
       mov       r9,[rcx+0C0]
       mov       rcx,r8
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,22B36800A40
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,22B348076B0
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,2
       call      qword ptr [93D8]
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
       je        near ptr 000000000000EEFD
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      qword ptr [9450]
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
       call      00000000000099F0
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
       mov       r9,22B34806D70
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FF82ED29020
       call      000000000000F510
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0FAF8]
       mov       rcx,rsi
       call      0000000000006AD0
       int       3
; Total bytes of code 248
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogTraceBenchmark()
; 			this._logger.LogTrace(100, this._testException, TraceMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+0B8]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+0C0]
       mov       rcx,28F623B8000
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,28F523B1990
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+28],rcx
       mov       rcx,r8
       lea       r8,[rsp+38]
       mov       r9,rax
       xor       edx,edx
       call      000000000000CCF0
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
       je        near ptr 000000000000126C
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      000000000000CD20
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
       call      0000000000005ED0
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
       mov       r9,28F623B7A78
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FF82CFC7588
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       int       3
; Total bytes of code 246
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogTraceBenchmark()
; 			this._logger.LogTrace(100, this._testException, TraceMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+0B8]
       mov       r9,[rcx+0C0]
       mov       rcx,r8
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,1CC10409E38
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,1CC104076B0
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       xor       edx,edx
       call      qword ptr [7F78]
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
       je        near ptr 000000000000EEED
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      qword ptr [9018]
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
       call      00000000000099F0
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
       mov       r9,1CC10406D70
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FF82F3F9020
       call      000000000000F510
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0FAF8]
       mov       rcx,rsi
       call      0000000000006AD0
       int       3
; Total bytes of code 248
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogWarningBenchmark()
; 			this._logger.LogWarning(100, this._testException, DebugMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+0B8]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+0C0]
       mov       rcx,259636B8000
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,259536B29A8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+28],rcx
       mov       rcx,r8
       lea       r8,[rsp+38]
       mov       r9,rax
       mov       edx,3
       call      000000000000CCD8
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
       je        near ptr 000000000000114C
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      000000000000CD08
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
       call      0000000000005ED0
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
       mov       r9,259636B7A78
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000B2D0
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FF82CFD7588
       call      0000000000000390
       mov       rdx,rax
       mov       rcx,rsi
       call      00000000000001D8
       mov       rcx,rsi
       call      00000000000055B0
       int       3
; Total bytes of code 246
```

## .NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogWarningBenchmark()
; 			this._logger.LogWarning(100, this._testException, DebugMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+0B8]
       mov       r9,[rcx+0C0]
       mov       rcx,r8
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,1E0F6C00A40
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,1E0FAC076B0
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,3
       call      qword ptr [93D8]
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
       je        near ptr 000000000000EEFD
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      qword ptr [9450]
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
       call      00000000000099F0
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
       mov       r9,1E0FAC06D70
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      000000000000EFB0
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FF82F409020
       call      000000000000F510
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [0FAF8]
       mov       rcx,rsi
       call      0000000000006AD0
       int       3
; Total bytes of code 248
```

