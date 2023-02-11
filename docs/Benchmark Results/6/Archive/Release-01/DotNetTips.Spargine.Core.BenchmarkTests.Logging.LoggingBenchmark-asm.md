## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCriticalBenchmark()
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			EasyLogger.LogCritical(this._logger, "CRITICAL ENTRY", testException);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,2D8CFCD1988
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
       mov       rsi,[rsi+0B8]
       mov       rcx,rsi
       mov       r11,7FFE6E9705E0
       mov       edx,5
       call      qword ptr [7FFE6ED105E0]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFE6ED7A4A0
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2D8DFCD7BD8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,2D8CFCD1990
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
; Total bytes of code 188
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebugBenchmark()
; 			EasyLogger.LogDebug(this._logger, "DEBUG ENTRY");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+0B8]
       mov       rcx,rsi
       mov       r11,7FFE6E970530
       mov       edx,1
       call      qword ptr [7FFE6ECF0530]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFE6ED686F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,215D38B7BE0
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,215E38B1988
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

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogErrorBenchmark()
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			EasyLogger.LogError(this._logger, "ERROR ENTRY", testException);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,1F2283831B8
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
       mov       rsi,[rsi+0B8]
       mov       rcx,rsi
       mov       r11,7FFE6E960530
       mov       edx,4
       call      qword ptr [7FFE6ECE0530]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFE6ED586F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1F248387BE8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1F2283831C0
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
; Total bytes of code 188
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformationBenchmark()
; 			EasyLogger.LogInformation(this._logger, "ERROR ENTRY");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+0B8]
       mov       rcx,rsi
       mov       r11,7FFE6E960530
       mov       edx,2
       call      qword ptr [7FFE6ECE0530]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFE6ED586F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,17127B637E8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,17117B629A0
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

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTraceBenchmark()
; 			EasyLogger.LogTrace(this._logger, "TRACE ENTRY");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+0B8]
       mov       rcx,rsi
       mov       r11,7FFE6E980530
       xor       edx,edx
       call      qword ptr [7FFE6ED00530]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFE6ED786F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,20AD83F37F0
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,20AA83F6DA8
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

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarningBenchmark()
; 			EasyLogger.LogWarning(this._logger, "WARNING ENTRY");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+0B8]
       mov       rcx,rsi
       mov       r11,7FFE6E970530
       mov       edx,3
       call      qword ptr [7FFE6ECF0530]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFE6ED686F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2269C9B37F8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,2266C9B6DA8
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

