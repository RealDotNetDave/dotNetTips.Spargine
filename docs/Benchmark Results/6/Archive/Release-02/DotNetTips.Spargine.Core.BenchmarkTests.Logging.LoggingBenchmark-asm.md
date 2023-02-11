## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCriticalBenchmark()
; 			EasyLogger.LogCritical(logger: this._logger, message: CriticalMessage, ex: this._testException);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+1C8]
       mov       rdi,[rcx+1D0]
       mov       rcx,rsi
       mov       r11,7FFB528705D0
       mov       edx,5
       call      qword ptr [7FFB52C105D0]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFB52B38058
       mov       edx,3D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,24297B47E08
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,24287B419B8
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebugBenchmark()
; 			EasyLogger.LogDebug(this._logger, DebugMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+1C8]
       mov       rcx,rsi
       mov       r11,7FFB52850540
       mov       edx,1
       call      qword ptr [7FFB52BF0540]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFB52B18058
       mov       edx,3D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1AB68AC7E10
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1AB68AC9D98
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogErrorBenchmark()
; 			EasyLogger.LogError(logger: this._logger, message: ErrorMessage, ex: this._testException);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+1C8]
       mov       rdi,[rcx+1D0]
       mov       rcx,rsi
       mov       r11,7FFB52870540
       mov       edx,4
       call      qword ptr [7FFB52C10540]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFB52B38058
       mov       edx,3D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,261EAFD3A10
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,261EAFD61A8
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformationBenchmark()
; 			EasyLogger.LogInformation(this._logger, ErrorMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+1C8]
       mov       rcx,rsi
       mov       r11,7FFB52840540
       mov       edx,2
       call      qword ptr [7FFB52BE0540]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFB52B08058
       mov       edx,3D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,20BEDD93A18
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,20BCDD95DC0
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTraceBenchmark()
; 			EasyLogger.LogTrace(this._logger, TraceMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+1C8]
       mov       rcx,rsi
       mov       r11,7FFB52880540
       xor       edx,edx
       call      qword ptr [7FFB52C20540]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFB52B48058
       mov       edx,3D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1D159277E28
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1D1692721D0
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarningBenchmark()
; 			EasyLogger.LogWarning(this._logger, WarningMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+1C8]
       mov       rcx,rsi
       mov       r11,7FFB52870540
       mov       edx,3
       call      qword ptr [7FFB52C10540]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFB52B38058
       mov       edx,3D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,11299357E30
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,112893519B8
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogCriticalBenchmark()
; 			this._logger.LogCritical(100, this._testException, DebugMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+1C8]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+1D0]
       mov       rcx,20731432FA0
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,207114319B8
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,207314384A8
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFB52C8B830
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogDebugBenchmark()
; 			this._logger.LogDebug(100, this._testException, DebugMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+1C8]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+1D0]
       mov       rcx,1A07CAB2FA0
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,1A08CAB19B8
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,1A07CAB84A8
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFB52C7B830
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogErrorBenchmark()
; 			this._logger.LogError(eventId: 100, exception: this._testException, message: ErrorMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+1C8]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+1D0]
       mov       rcx,277CD7E2FA0
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,277DD7E95D0
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,277DD7E64B0
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFB52C5B830
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogInformationBenchmark()
; 			this._logger.LogInformation(100, this._testException, InformationMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+1C8]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+1D0]
       mov       rcx,2BEABB32FA0
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,2BEABB36DD8
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,2BEBBB340A0
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFB52C6B830
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogTraceBenchmark()
; 			this._logger.LogTrace(100, this._testException, TraceMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+1C8]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+1D0]
       mov       rcx,1DE87142FA0
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,1DE871475F0
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,1DE971440A0
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFB52C6B830
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.ILoggerLogWarningBenchmark()
; 			this._logger.LogWarning(100, this._testException, DebugMessage);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+1C8]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+1D0]
       mov       rcx,1B616DA2FA0
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,1B5F6DA19B8
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,1B616DA84A8
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFB52C5B830
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

