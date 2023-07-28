## DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark-20230721-185802
**Diff for LogCritical_EazyLogger_Benchmark method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCritical_EazyLogger_Benchmark()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,[rcx+190]
        mov       rdi,[rcx+198]
        mov       rcx,rsi
-       mov       r11,7FFD674B0798
+       mov       r11,7FFD459706D0
        mov       edx,5
-       call      qword ptr [7FFD674B0798]
+       call      qword ptr [r11]
        test      eax,eax
        je        short M00_L00
-       mov       rcx,7FFD67756A70
-       mov       edx,49
+       mov       rcx,7FFD45DCA3C8
+       mov       edx,53
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,2BCC81687E8
+       mov       rcx,1DDD8407840
        mov       rax,[rcx]
        mov       rcx,[rax+8]
-       mov       r8,2BCC81737A8
+       mov       r8,1DDE0400C40
        mov       r8,[r8]
        mov       rdx,rsi
        mov       r9,rdi
-       mov       rax,[rax+18]
        add       rsp,28
        pop       rsi
        pop       rdi
-       jmp       rax
+       jmp       qword ptr [rax+18]
 M00_L00:
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
-; Total bytes of code 124
+; Total bytes of code 118
```
**Diff for LogDebug_EasyLogger_Benchmark method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebug_EasyLogger_Benchmark()
        push      rsi
        sub       rsp,20
        mov       rsi,[rcx+190]
        mov       rcx,rsi
-       mov       r11,7FFD674A0798
+       mov       r11,7FFD459706C0
        mov       edx,1
-       call      qword ptr [7FFD674A0798]
+       call      qword ptr [r11]
        test      eax,eax
        je        short M00_L00
-       mov       rcx,7FFD67746A70
-       mov       edx,49
+       mov       rcx,7FFD45DCA3C8
+       mov       edx,53
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,1FD20FA67F8
+       mov       rcx,20656C07848
        mov       rax,[rcx]
        mov       rcx,[rax+8]
-       mov       r8,1FD70FA1C00
+       mov       r8,20664C00C40
        mov       r8,[r8]
        mov       rdx,rsi
        xor       r9d,r9d
-       mov       rax,[rax+18]
        add       rsp,20
        pop       rsi
-       jmp       rax
+       jmp       qword ptr [rax+18]
 M00_L00:
        add       rsp,20
        pop       rsi
        ret
-; Total bytes of code 114
+; Total bytes of code 108
```
**Diff for LogError_EasyLogger_Benchmark method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogError_EasyLogger_Benchmark()
        push      rsi
        sub       rsp,20
        mov       rsi,[rcx+190]
        mov       rcx,rsi
-       mov       r11,7FFD674E0738
+       mov       r11,7FFD45970720
        mov       edx,4
-       call      qword ptr [7FFD674E0738]
+       call      qword ptr [r11]
        test      eax,eax
        je        short M00_L00
-       mov       rcx,7FFD67786A70
-       mov       edx,49
+       mov       rcx,7FFD45DCA3C8
+       mov       edx,53
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,1F72ACF87F8
+       mov       rcx,201DF807850
        mov       rax,[rcx]
        mov       rcx,[rax+8]
-       mov       r8,1F78ACF1C00
+       mov       r8,201DF8117D0
        mov       r8,[r8]
        mov       rdx,rsi
        xor       r9d,r9d
-       mov       rax,[rax+18]
        add       rsp,20
        pop       rsi
-       jmp       rax
+       jmp       qword ptr [rax+18]
 M00_L00:
        add       rsp,20
        pop       rsi
        ret
-; Total bytes of code 114
+; Total bytes of code 108
```
**Diff for LogException_EasyLogger_Benchmark method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogException_EasyLogger_Benchmark()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,[rcx+190]
        mov       rdi,[rcx+198]
        mov       rcx,rsi
-       mov       r11,7FFD674C0798
+       mov       r11,7FFD459906D0
        mov       edx,4
-       call      qword ptr [7FFD674C0798]
+       call      qword ptr [r11]
        test      eax,eax
        je        short M00_L00
-       mov       rcx,7FFD67766A70
-       mov       edx,49
+       mov       rcx,7FFD45DEA3C8
+       mov       edx,53
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,22152A58800
+       mov       rcx,1C9E1407858
        mov       rax,[rcx]
        mov       rcx,[rax+8]
-       mov       r8,221A2A51C00
+       mov       r8,1C9D9409BF0
        mov       r8,[r8]
        mov       rdx,rsi
        mov       r9,rdi
-       mov       rax,[rax+18]
        add       rsp,28
        pop       rsi
        pop       rdi
-       jmp       rax
+       jmp       qword ptr [rax+18]
 M00_L00:
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
-; Total bytes of code 124
+; Total bytes of code 118
```
**Diff for LogInformation_EasyLogger_Benchmark method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformation_EasyLogger_Benchmark()
        push      rsi
        sub       rsp,20
        mov       rsi,[rcx+190]
        mov       rcx,rsi
-       mov       r11,7FFD674C0738
+       mov       r11,7FFD459706D0
        mov       edx,2
-       call      qword ptr [7FFD674C0738]
+       call      qword ptr [r11]
        test      eax,eax
        je        short M00_L00
-       mov       rcx,7FFD67766A70
-       mov       edx,49
+       mov       rcx,7FFD45DCA3C8
+       mov       edx,53
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,20584194400
+       mov       rcx,15155007860
        mov       rax,[rcx]
        mov       rcx,[rax+8]
-       mov       r8,205F4191C00
+       mov       r8,1514D000C40
        mov       r8,[r8]
        mov       rdx,rsi
        xor       r9d,r9d
-       mov       rax,[rax+18]
        add       rsp,20
        pop       rsi
-       jmp       rax
+       jmp       qword ptr [rax+18]
 M00_L00:
        add       rsp,20
        pop       rsi
        ret
-; Total bytes of code 114
+; Total bytes of code 108
```
**Diff for LogTrace_EasyLogger_Benchmark method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTrace_EasyLogger_Benchmark()
        push      rsi
        sub       rsp,20
        mov       rsi,[rcx+190]
        mov       rcx,rsi
-       mov       r11,7FFD674B0738
+       mov       r11,7FFD45970730
        xor       edx,edx
-       call      qword ptr [7FFD674B0738]
+       call      qword ptr [r11]
        test      eax,eax
        je        short M00_L00
-       mov       rcx,7FFD67756A70
-       mov       edx,49
+       mov       rcx,7FFD45DCA3C8
+       mov       edx,53
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,1C2F2D44408
+       mov       rcx,1E427C07868
        mov       rax,[rcx]
        mov       rcx,[rax+8]
-       mov       r8,1C352D41C00
+       mov       r8,1E437C00C40
        mov       r8,[r8]
        mov       rdx,rsi
        xor       r9d,r9d
-       mov       rax,[rax+18]
        add       rsp,20
        pop       rsi
-       jmp       rax
+       jmp       qword ptr [rax+18]
 M00_L00:
        add       rsp,20
        pop       rsi
        ret
-; Total bytes of code 111
+; Total bytes of code 105
```
**Diff for LogWarning_EasyLogger_Benchmark method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarning_EasyLogger_Benchmark()
        push      rsi
        sub       rsp,20
        mov       rsi,[rcx+190]
        mov       rcx,rsi
-       mov       r11,7FFD674D0738
+       mov       r11,7FFD459906D0
        mov       edx,3
-       call      qword ptr [7FFD674D0738]
+       call      qword ptr [r11]
        test      eax,eax
        je        short M00_L00
-       mov       rcx,7FFD67776A70
-       mov       edx,49
+       mov       rcx,7FFD45DEA3C8
+       mov       edx,53
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,23411F96820
+       mov       rcx,20202C07870
        mov       rax,[rcx]
        mov       rcx,[rax+8]
-       mov       r8,23471F91C00
+       mov       r8,20214C00C40
        mov       r8,[r8]
        mov       rdx,rsi
        xor       r9d,r9d
-       mov       rax,[rax+18]
        add       rsp,20
        pop       rsi
-       jmp       rax
+       jmp       qword ptr [rax+18]
 M00_L00:
        add       rsp,20
        pop       rsi
        ret
-; Total bytes of code 114
+; Total bytes of code 108
```
**Diff for LogCritical_EazyLoggerExtensions_Benchmark method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCritical_EazyLoggerExtensions_Benchmark()
        mov       [rsp+8],rcx
        mov       rcx,[rcx+190]
        mov       r8,[rsp+8]
        mov       r8,[r8+198]
-       mov       rdx,1E1A0B21C00
+       mov       rdx,286FAC00C40
        mov       rdx,[rdx]
-       mov       r9,1E1A0B21C08
+       mov       r9,286FAC00C48
        mov       r9,[r9]
-       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogCriticalMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
-; Total bytes of code 55
+       jmp       qword ptr [7FFD52A7F000]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogCriticalMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
+; Total bytes of code 56
 ; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogCriticalMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
        push      r15
        push      r14
-       push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,50
+       sub       rsp,58
+       xor       eax,eax
+       mov       [rsp+38],rax
        vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
+       mov       [rsp+50],rax
        mov       rsi,rcx
        mov       rdi,rdx
        mov       rbx,r8
        mov       rbp,r9
        mov       rcx,rsi
-       mov       r11,7FFD674A0730
+       mov       r11,7FFD522006D8
        mov       edx,5
-       call      qword ptr [7FFD674A0730]
+       call      qword ptr [r11]
        test      eax,eax
        je        near ptr M01_L00
-       mov       r14d,390
-       mov       rcx,1E1A0B21C10
-       mov       r15,[rcx]
+       mov       rcx,286FAC00C50
+       mov       r14,[rcx]
        mov       rcx,rsi
        mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
        mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogCriticalMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogCriticalMessageStruct, System.Exception, System.Func`3<__LogCriticalMessageStruct,System.Exception,System.String>)
        call      CORINFO_HELP_VIRTUAL_FUNC_PTR
-       mov       r12,rax
-       mov       [rsp+40],r15
-       mov       [rsp+48],r14d
-       mov       [rsp+30],rdi
-       mov       [rsp+38],rbp
-       mov       rcx,7FFD67746A70
-       mov       edx,6F
+       mov       r15,rax
+       mov       [rsp+48],r14
+       mov       dword ptr [rsp+50],390
+       mov       [rsp+38],rdi
+       mov       [rsp+40],rbp
+       mov       rcx,7FFD5265A3C8
+       mov       edx,83
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,1E130B288A0
+       mov       rcx,286FEC07900
        mov       rcx,[rcx]
        mov       [rsp+28],rcx
        mov       rcx,rsi
-       lea       r8,[rsp+40]
-       lea       r9,[rsp+30]
+       lea       r8,[rsp+48]
+       lea       r9,[rsp+38]
        mov       [rsp+20],rbx
        mov       edx,5
-       call      r12
+       call      r15
 M01_L00:
        nop
-       add       rsp,50
+       add       rsp,58
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r12
        pop       r14
        pop       r15
        ret
-; Total bytes of code 224
+; Total bytes of code 220
```
**Diff for LogError_EazyLoggerExtensions_Benchmark method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogError_EazyLoggerExtensions_Benchmark()
        mov       rcx,[rcx+190]
-       mov       rdx,23DDEE61C00
+       mov       rdx,2980E401C58
        mov       rdx,[rdx]
-       mov       r8,23DDEE61C08
+       mov       r8,2980E401C60
        mov       r8,[r8]
-       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogErrorMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
-; Total bytes of code 38
+       jmp       qword ptr [7FFD52A4F030]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogErrorMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
+; Total bytes of code 39
 ; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogErrorMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,58
-       xor       eax,eax
-       mov       [rsp+38],rax
+       sub       rsp,50
        vxorps    xmm4,xmm4,xmm4
+       vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
-       mov       [rsp+50],rax
        mov       rsi,rcx
        mov       rdi,rdx
        mov       rbx,r8
        mov       rcx,rsi
-       mov       r11,7FFD674D0740
+       mov       r11,7FFD521D06C8
        mov       edx,4
-       call      qword ptr [7FFD674D0740]
+       call      qword ptr [r11]
        test      eax,eax
        je        near ptr M01_L00
-       mov       ebp,12D
-       mov       rcx,23DDEE61C10
-       mov       r14,[rcx]
+       mov       rcx,2980E401C68
+       mov       rbp,[rcx]
        mov       rcx,rsi
        mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
        mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogErrorMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogErrorMessageStruct, System.Exception, System.Func`3<__LogErrorMessageStruct,System.Exception,System.String>)
        call      CORINFO_HELP_VIRTUAL_FUNC_PTR
-       mov       r15,rax
-       mov       [rsp+48],r14
-       mov       [rsp+50],ebp
-       mov       [rsp+38],rdi
-       mov       [rsp+40],rbx
-       mov       rcx,7FFD67776A70
-       mov       edx,71
+       mov       r14,rax
+       mov       [rsp+40],rbp
+       mov       dword ptr [rsp+48],12D
+       mov       [rsp+30],rdi
+       mov       [rsp+38],rbx
+       mov       rcx,7FFD5262A3C8
+       mov       edx,85
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,23D6EE688B0
+       mov       rcx,29812407910
        mov       rcx,[rcx]
        mov       [rsp+28],rcx
        mov       rcx,rsi
-       lea       r8,[rsp+48]
-       lea       r9,[rsp+38]
+       lea       r8,[rsp+40]
+       lea       r9,[rsp+30]
        mov       edx,4
        xor       eax,eax
        mov       [rsp+20],rax
-       call      r15
+       call      r14
 M01_L00:
        nop
-       add       rsp,58
+       add       rsp,50
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
-; Total bytes of code 223
+; Total bytes of code 209
```
**Diff for LogException_EazyLoggerExtensions_Benchmark method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogException_EazyLoggerExtensions_Benchmark()
        mov       rcx,[rcx+190]
-       mov       rdx,15F7AC81C00
+       mov       rdx,17AB4401C58
        mov       rdx,[rdx]
-       mov       r8,15F7AC81C08
+       mov       r8,17AB4401C60
        mov       r8,[r8]
-       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogDebugMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
-; Total bytes of code 38
+       jmp       qword ptr [7FFD52A5F018]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogDebugMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
+; Total bytes of code 39
 ; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogDebugMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,58
-       xor       eax,eax
-       mov       [rsp+38],rax
+       sub       rsp,50
        vxorps    xmm4,xmm4,xmm4
+       vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
-       mov       [rsp+50],rax
        mov       rsi,rcx
        mov       rdi,rdx
        mov       rbx,r8
        mov       rcx,rsi
-       mov       r11,7FFD674D07A0
+       mov       r11,7FFD521F06D8
        mov       edx,1
-       call      qword ptr [7FFD674D07A0]
+       call      qword ptr [r11]
        test      eax,eax
        je        near ptr M01_L00
-       mov       ebp,0C9
-       mov       rcx,15F1AC85470
-       mov       r14,[rcx]
+       mov       rcx,17AB84044A8
+       mov       rbp,[rcx]
        mov       rcx,rsi
        mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
        mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogDebugMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogDebugMessageStruct, System.Exception, System.Func`3<__LogDebugMessageStruct,System.Exception,System.String>)
        call      CORINFO_HELP_VIRTUAL_FUNC_PTR
-       mov       r15,rax
-       mov       [rsp+48],r14
-       mov       [rsp+50],ebp
-       mov       [rsp+38],rdi
-       mov       [rsp+40],rbx
-       mov       rcx,7FFD67776A70
-       mov       edx,70
+       mov       r14,rax
+       mov       [rsp+40],rbp
+       mov       dword ptr [rsp+48],0C9
+       mov       [rsp+30],rdi
+       mov       [rsp+38],rbx
+       mov       rcx,7FFD5264A3C8
+       mov       edx,84
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,15F1AC844A0
+       mov       rcx,17AB8403500
        mov       rcx,[rcx]
        mov       [rsp+28],rcx
        mov       rcx,rsi
-       lea       r8,[rsp+48]
-       lea       r9,[rsp+38]
+       lea       r8,[rsp+40]
+       lea       r9,[rsp+30]
        mov       edx,1
        xor       eax,eax
        mov       [rsp+20],rax
-       call      r15
+       call      r14
 M01_L00:
        nop
-       add       rsp,58
+       add       rsp,50
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
-; Total bytes of code 223
+; Total bytes of code 209
```
**Diff for LogInformation_EazyLoggerExtensions_Benchmark method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformation_EazyLoggerExtensions_Benchmark()
        mov       rcx,[rcx+190]
-       mov       rdx,20346881C00
+       mov       rdx,2A24AC00C40
        mov       rdx,[rdx]
-       mov       r8,20346881C08
+       mov       r8,2A24AC00C48
        mov       r8,[r8]
-       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogInformationMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
-; Total bytes of code 38
+       jmp       qword ptr [7FFD52A5F060]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogInformationMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
+; Total bytes of code 39
 ; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogInformationMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,58
-       xor       eax,eax
-       mov       [rsp+38],rax
+       sub       rsp,50
        vxorps    xmm4,xmm4,xmm4
+       vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
-       mov       [rsp+50],rax
        mov       rsi,rcx
        mov       rdi,rdx
        mov       rbx,r8
        mov       rcx,rsi
-       mov       r11,7FFD674B0730
+       mov       r11,7FFD521F06D8
        mov       edx,2
-       call      qword ptr [7FFD674B0730]
+       call      qword ptr [r11]
        test      eax,eax
        je        near ptr M01_L00
-       mov       ebp,191
-       mov       rcx,20346881C10
-       mov       r14,[rcx]
+       mov       rcx,2A24AC00C50
+       mov       rbp,[rcx]
        mov       rcx,rsi
        mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
        mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogInformationMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogInformationMessageStruct, System.Exception, System.Func`3<__LogInformationMessageStruct,System.Exception,System.String>)
        call      CORINFO_HELP_VIRTUAL_FUNC_PTR
-       mov       r15,rax
-       mov       [rsp+48],r14
-       mov       [rsp+50],ebp
-       mov       [rsp+38],rdi
-       mov       [rsp+40],rbx
-       mov       rcx,7FFD67756A70
-       mov       edx,73
+       mov       r14,rax
+       mov       [rsp+40],rbp
+       mov       dword ptr [rsp+48],191
+       mov       [rsp+30],rdi
+       mov       [rsp+38],rbx
+       mov       rcx,7FFD5264A3C8
+       mov       edx,87
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,203368888C0
+       mov       rcx,2A24EC07920
        mov       rcx,[rcx]
        mov       [rsp+28],rcx
        mov       rcx,rsi
-       lea       r8,[rsp+48]
-       lea       r9,[rsp+38]
+       lea       r8,[rsp+40]
+       lea       r9,[rsp+30]
        mov       edx,2
        xor       eax,eax
        mov       [rsp+20],rax
-       call      r15
+       call      r14
 M01_L00:
        nop
-       add       rsp,58
+       add       rsp,50
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
-; Total bytes of code 223
+; Total bytes of code 209
```
**Diff for LogStoredProcedureError_EazyLoggerExtensions_Benchmark method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogStoredProcedureError_EazyLoggerExtensions_Benchmark()
        mov       [rsp+8],rcx
        mov       rcx,[rcx+190]
        mov       r8,[rsp+8]
        mov       r8,[r8+198]
-       mov       rdx,1D1B6301C00
+       mov       rdx,1288B400C40
        mov       rdx,[rdx]
-       mov       r9,1D1B6301C08
+       mov       r9,1288B400C48
        mov       r9,[r9]
-       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureError(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
-; Total bytes of code 55
+       jmp       qword ptr [7FFD52A6F8E8]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureError(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
+; Total bytes of code 56
 ; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureError(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
        push      r15
        push      r14
-       push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,50
+       sub       rsp,58
+       xor       eax,eax
+       mov       [rsp+38],rax
        vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
+       mov       [rsp+50],rax
        mov       rsi,rcx
        mov       rdi,rdx
        mov       rbx,r8
        mov       rbp,r9
        mov       rcx,rsi
-       mov       r11,7FFD674D07A0
+       mov       r11,7FFD521F06D8
        mov       edx,4
-       call      qword ptr [7FFD674D07A0]
+       call      qword ptr [r11]
        test      eax,eax
        je        near ptr M01_L00
-       mov       r14d,1F6
-       mov       rcx,1D1B6301C10
-       mov       r15,[rcx]
+       mov       rcx,1288B400C50
+       mov       r14,[rcx]
        mov       rcx,rsi
        mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
        mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogStoredProcedureErrorStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogStoredProcedureErrorStruct, System.Exception, System.Func`3<__LogStoredProcedureErrorStruct,System.Exception,System.String>)
        call      CORINFO_HELP_VIRTUAL_FUNC_PTR
-       mov       r12,rax
-       mov       [rsp+40],r15
-       mov       [rsp+48],r14d
-       mov       [rsp+30],rdi
-       mov       [rsp+38],rbp
-       mov       rcx,7FFD67776A70
-       mov       edx,74
+       mov       r15,rax
+       mov       [rsp+48],r14
+       mov       dword ptr [rsp+50],1F6
+       mov       [rsp+38],rdi
+       mov       [rsp+40],rbp
+       mov       rcx,7FFD5264A3C8
+       mov       edx,88
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,1D1563088C8
+       mov       rcx,12883407928
        mov       rcx,[rcx]
        mov       [rsp+28],rcx
        mov       rcx,rsi
-       lea       r8,[rsp+40]
-       lea       r9,[rsp+30]
+       lea       r8,[rsp+48]
+       lea       r9,[rsp+38]
        mov       [rsp+20],rbx
        mov       edx,4
-       call      r12
+       call      r15
 M01_L00:
        nop
-       add       rsp,50
+       add       rsp,58
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r12
        pop       r14
        pop       r15
        ret
-; Total bytes of code 224
+; Total bytes of code 220
```
**Diff for LogStoredProcedureNoRecordsFound_EazyLoggerExtensions_Benchmark method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogStoredProcedureNoRecordsFound_EazyLoggerExtensions_Benchmark()
        mov       rcx,[rcx+190]
-       mov       rdx,1A6D23C1C00
+       mov       rdx,2E086800C40
        mov       rdx,[rdx]
-       mov       r8,1A6D23C1C08
+       mov       r8,2E086800C48
        mov       r8,[r8]
-       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureNoRecordsFound(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
-; Total bytes of code 38
+       jmp       qword ptr [7FFD52A6F900]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureNoRecordsFound(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
+; Total bytes of code 39
 ; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureNoRecordsFound(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,58
-       xor       eax,eax
-       mov       [rsp+38],rax
+       sub       rsp,50
        vxorps    xmm4,xmm4,xmm4
+       vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
-       mov       [rsp+50],rax
        mov       rsi,rcx
        mov       rdi,rdx
        mov       rbx,r8
        mov       rcx,rsi
-       mov       r11,7FFD674A07A0
+       mov       r11,7FFD521F06C8
        mov       edx,4
-       call      qword ptr [7FFD674A07A0]
+       call      qword ptr [r11]
        test      eax,eax
        je        near ptr M01_L00
-       mov       ebp,25A
-       mov       rcx,1A6D23C1C10
-       mov       r14,[rcx]
+       mov       rcx,2E086800C50
+       mov       rbp,[rcx]
        mov       rcx,rsi
        mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
        mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogStoredProcedureNoRecordsFoundStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogStoredProcedureNoRecordsFoundStruct, System.Exception, System.Func`3<__LogStoredProcedureNoRecordsFoundStruct,System.Exception,System.String>)
        call      CORINFO_HELP_VIRTUAL_FUNC_PTR
-       mov       r15,rax
-       mov       [rsp+48],r14
-       mov       [rsp+50],ebp
-       mov       [rsp+38],rdi
-       mov       [rsp+40],rbx
-       mov       rcx,7FFD67746A70
-       mov       edx,75
+       mov       r14,rax
+       mov       [rsp+40],rbp
+       mov       dword ptr [rsp+48],25A
+       mov       [rsp+30],rdi
+       mov       [rsp+38],rbx
+       mov       rcx,7FFD5264A3C8
+       mov       edx,89
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,1A6423C88D0
+       mov       rcx,2E07E807930
        mov       rcx,[rcx]
        mov       [rsp+28],rcx
        mov       rcx,rsi
-       lea       r8,[rsp+48]
-       lea       r9,[rsp+38]
+       lea       r8,[rsp+40]
+       lea       r9,[rsp+30]
        mov       edx,4
        xor       eax,eax
        mov       [rsp+20],rax
-       call      r15
+       call      r14
 M01_L00:
        nop
-       add       rsp,58
+       add       rsp,50
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
-; Total bytes of code 223
+; Total bytes of code 209
```
**Diff for LogTrace_EazyLoggerExtensions_Benchmark method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTrace_EazyLoggerExtensions_Benchmark()
        mov       rcx,[rcx+190]
-       mov       rdx,16E05BC1C00
+       mov       rdx,1AB468117D0
        mov       rdx,[rdx]
-       mov       r8,16E05BC1C08
+       mov       r8,1AB468117D8
        mov       r8,[r8]
-       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogTraceMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
-; Total bytes of code 38
+       jmp       qword ptr [7FFD52A5FC18]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogTraceMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
+; Total bytes of code 39
 ; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogTraceMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,58
-       xor       eax,eax
-       mov       [rsp+38],rax
+       sub       rsp,50
        vxorps    xmm4,xmm4,xmm4
+       vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
-       mov       [rsp+50],rax
        mov       rsi,rcx
        mov       rdi,rdx
        mov       rbx,r8
        mov       rcx,rsi
-       mov       r11,7FFD674B0730
+       mov       r11,7FFD521E06D8
        xor       edx,edx
-       call      qword ptr [7FFD674B0730]
+       call      qword ptr [r11]
        test      eax,eax
        je        near ptr M01_L00
-       mov       ebp,65
-       mov       rcx,16E05BC1C10
-       mov       r14,[rcx]
+       mov       rcx,1AB468117E0
+       mov       rbp,[rcx]
        mov       rcx,rsi
        mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
        mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogTraceMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogTraceMessageStruct, System.Exception, System.Func`3<__LogTraceMessageStruct,System.Exception,System.String>)
        call      CORINFO_HELP_VIRTUAL_FUNC_PTR
-       mov       r15,rax
-       mov       [rsp+48],r14
-       mov       [rsp+50],ebp
-       mov       [rsp+38],rdi
-       mov       [rsp+40],rbx
-       mov       rcx,7FFD67756A70
-       mov       edx,76
+       mov       r14,rax
+       mov       [rsp+40],rbp
+       mov       dword ptr [rsp+48],65
+       mov       [rsp+30],rdi
+       mov       [rsp+38],rbx
+       mov       rcx,7FFD5263A3C8
+       mov       edx,8A
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,16DB5BC64C8
+       mov       rcx,1AB46807938
        mov       rcx,[rcx]
        mov       [rsp+28],rcx
        mov       rcx,rsi
-       lea       r8,[rsp+48]
-       lea       r9,[rsp+38]
+       lea       r8,[rsp+40]
+       lea       r9,[rsp+30]
        xor       edx,edx
        xor       eax,eax
        mov       [rsp+20],rax
-       call      r15
+       call      r14
 M01_L00:
        nop
-       add       rsp,58
+       add       rsp,50
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
-; Total bytes of code 217
+; Total bytes of code 203
```
**Diff for LogWarning_EazyLoggerExtensions_Benchmark method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarning_EazyLoggerExtensions_Benchmark()
        mov       rcx,[rcx+190]
-       mov       rdx,1233AFA1C00
+       mov       rdx,25884800C40
        mov       rdx,[rdx]
-       mov       r8,1233AFA1C08
+       mov       r8,25884800C48
        mov       r8,[r8]
-       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogWarningMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
-; Total bytes of code 38
+       jmp       qword ptr [7FFD4620F0C0]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogWarningMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
+; Total bytes of code 39
 ; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogWarningMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,58
-       xor       eax,eax
-       mov       [rsp+38],rax
+       sub       rsp,50
        vxorps    xmm4,xmm4,xmm4
+       vmovdqa   xmmword ptr [rsp+30],xmm4
        vmovdqa   xmmword ptr [rsp+40],xmm4
-       mov       [rsp+50],rax
        mov       rsi,rcx
        mov       rdi,rdx
        mov       rbx,r8
        mov       rcx,rsi
-       mov       r11,7FFD674E07A0
+       mov       r11,7FFD459906D8
        mov       edx,3
-       call      qword ptr [7FFD674E07A0]
+       call      qword ptr [r11]
        test      eax,eax
        je        near ptr M01_L00
-       mov       ebp,259
-       mov       rcx,1233AFA1C10
-       mov       r14,[rcx]
+       mov       rcx,25884800C50
+       mov       rbp,[rcx]
        mov       rcx,rsi
        mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
        mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogWarningMessageStruct, DotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogWarningMessageStruct, System.Exception, System.Func`3<__LogWarningMessageStruct,System.Exception,System.String>)
        call      CORINFO_HELP_VIRTUAL_FUNC_PTR
-       mov       r15,rax
-       mov       [rsp+48],r14
-       mov       [rsp+50],ebp
-       mov       [rsp+38],rdi
-       mov       [rsp+40],rbx
-       mov       rcx,7FFD67786A70
-       mov       edx,77
+       mov       r14,rax
+       mov       [rsp+40],rbp
+       mov       dword ptr [rsp+48],259
+       mov       [rsp+30],rdi
+       mov       [rsp+38],rbx
+       mov       rcx,7FFD45DEA3C8
+       mov       edx,8B
        call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
-       mov       rcx,122DAFA88E0
+       mov       rcx,2587E807940
        mov       rcx,[rcx]
        mov       [rsp+28],rcx
        mov       rcx,rsi
-       lea       r8,[rsp+48]
-       lea       r9,[rsp+38]
+       lea       r8,[rsp+40]
+       lea       r9,[rsp+30]
        mov       edx,3
        xor       eax,eax
        mov       [rsp+20],rax
-       call      r15
+       call      r14
 M01_L00:
        nop
-       add       rsp,58
+       add       rsp,50
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
-; Total bytes of code 223
+; Total bytes of code 209
```
**Diff for LogCritical_ILogger_Benchmark method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCritical_ILogger_Benchmark()
        sub       rsp,48
        xor       eax,eax
        mov       [rsp+38],rax
        mov       r8,[rcx+190]
-       xor       r9d,r9d
-       mov       edx,64
-       mov       rax,[rcx+198]
-       mov       rcx,1F4A5B82F48
-       mov       rcx,[rcx]
-       mov       [rsp+38],r9
-       mov       [rsp+40],edx
-       mov       r9,1F4E5B81C00
-       mov       r9,[r9]
-       mov       [rsp+20],r9
-       mov       [rsp+28],rcx
+       mov       r9,[rcx+198]
        mov       rcx,r8
+       xor       r8d,r8d
+       mov       [rsp+38],r8
+       mov       dword ptr [rsp+40],64
+       mov       r8,180FAC00C40
+       mov       r8,[r8]
+       mov       [rsp+20],r8
+       mov       r8,180EAC01F78
+       mov       r8,[r8]
+       mov       [rsp+28],r8
        lea       r8,[rsp+38]
-       mov       r9,rax
        mov       edx,5
-       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
+       call      qword ptr [7FFD4621FF48]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
        nop
        add       rsp,48
        ret
-; Total bytes of code 105
+; Total bytes of code 102
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
-       call      Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
+       call      qword ptr [7FFD46231018]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
-       mov       r9,1F485B84B28
+       mov       r9,180EAC081A8
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
-       mov       rdx,7FFD678CE950
+       mov       rdx,7FFD45F65018
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      System.ThrowHelper.Throw(System.String)
+       call      qword ptr [7FFD461C9FA8]
        int       3
-; Total bytes of code 217
+; Total bytes of code 219
```
**Diff for LogDebug_ILogger_Benchmark method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebug_ILogger_Benchmark()
        sub       rsp,48
        xor       eax,eax
        mov       [rsp+38],rax
        mov       r8,[rcx+190]
-       xor       r9d,r9d
-       mov       edx,64
-       mov       rax,[rcx+198]
-       mov       rcx,1BE1F9C2F48
-       mov       rcx,[rcx]
-       mov       [rsp+38],r9
-       mov       [rsp+40],edx
-       mov       r9,1BE8F9C1C00
-       mov       r9,[r9]
-       mov       [rsp+20],r9
-       mov       [rsp+28],rcx
+       mov       r9,[rcx+198]
        mov       rcx,r8
+       xor       r8d,r8d
+       mov       [rsp+38],r8
+       mov       dword ptr [rsp+40],64
+       mov       r8,22F46000C40
+       mov       r8,[r8]
+       mov       [rsp+20],r8
+       mov       r8,22F3C001F78
+       mov       r8,[r8]
+       mov       [rsp+28],r8
        lea       r8,[rsp+38]
-       mov       r9,rax
        mov       edx,1
-       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
+       call      qword ptr [7FFD461EF3D8]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
        nop
        add       rsp,48
        ret
-; Total bytes of code 105
+; Total bytes of code 102
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
-       call      Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
+       call      qword ptr [7FFD461EF450]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
-       mov       r9,1BE1F9C8F30
+       mov       r9,22F3C0081A8
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
-       mov       rdx,7FFD678CE950
+       mov       rdx,7FFD45F35018
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      System.ThrowHelper.Throw(System.String)
+       call      qword ptr [7FFD461993D8]
        int       3
-; Total bytes of code 217
+; Total bytes of code 219
```
**Diff for LogError_ILogger_Benchmark method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogError_ILogger_Benchmark()
        sub       rsp,48
        xor       eax,eax
        mov       [rsp+38],rax
        mov       r8,[rcx+190]
-       xor       r9d,r9d
-       mov       edx,64
-       mov       rax,[rcx+198]
-       mov       rcx,24A8D3B2F48
-       mov       rcx,[rcx]
-       mov       [rsp+38],r9
-       mov       [rsp+40],edx
-       mov       r9,24B1D3B9B98
-       mov       r9,[r9]
-       mov       [rsp+20],r9
-       mov       [rsp+28],rcx
+       mov       r9,[rcx+198]
        mov       rcx,r8
+       xor       r8d,r8d
+       mov       [rsp+38],r8
+       mov       dword ptr [rsp+40],64
+       mov       r8,2F762400C40
+       mov       r8,[r8]
+       mov       [rsp+20],r8
+       mov       r8,2F752401F78
+       mov       r8,[r8]
+       mov       [rsp+28],r8
        lea       r8,[rsp+38]
-       mov       r9,rax
        mov       edx,4
-       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
+       call      qword ptr [7FFD4620FF48]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
        nop
        add       rsp,48
        ret
-; Total bytes of code 105
+; Total bytes of code 102
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
-       call      Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
+       call      qword ptr [7FFD46221018]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
-       mov       r9,24A8D3B8F30
+       mov       r9,2F756403DA0
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
-       mov       rdx,7FFD678DE950
+       mov       rdx,7FFD45F55018
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      System.ThrowHelper.Throw(System.String)
+       call      qword ptr [7FFD461B9FA8]
        int       3
-; Total bytes of code 217
+; Total bytes of code 219
```
**Diff for LogInformation_ILogger_Benchmark method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformation_ILogger_Benchmark()
        sub       rsp,48
        xor       eax,eax
        mov       [rsp+38],rax
        mov       r8,[rcx+190]
-       xor       r9d,r9d
-       mov       edx,64
-       mov       rax,[rcx+198]
-       mov       rcx,296C8D02F48
-       mov       rcx,[rcx]
-       mov       [rsp+38],r9
-       mov       [rsp+40],edx
-       mov       r9,29748D01C00
-       mov       r9,[r9]
-       mov       [rsp+20],r9
-       mov       [rsp+28],rcx
+       mov       r9,[rcx+198]
        mov       rcx,r8
+       xor       r8d,r8d
+       mov       [rsp+38],r8
+       mov       dword ptr [rsp+40],64
+       mov       r8,19929400C40
+       mov       r8,[r8]
+       mov       [rsp+20],r8
+       mov       r8,19925401F78
+       mov       r8,[r8]
+       mov       [rsp+28],r8
        lea       r8,[rsp+38]
-       mov       r9,rax
        mov       edx,2
-       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
+       call      qword ptr [7FFD461EF3D8]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
        nop
        add       rsp,48
        ret
-; Total bytes of code 105
+; Total bytes of code 102
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
-       call      Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
+       call      qword ptr [7FFD461EF450]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
-       mov       r9,296C8D08F30
+       mov       r9,199254081A8
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
-       mov       rdx,7FFD678CE950
+       mov       rdx,7FFD45F35018
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      System.ThrowHelper.Throw(System.String)
+       call      qword ptr [7FFD46197FA8]
        int       3
-; Total bytes of code 217
+; Total bytes of code 219
```
**Diff for LogTrace_ILogger_Benchmark method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTrace_ILogger_Benchmark()
        sub       rsp,48
        xor       eax,eax
        mov       [rsp+38],rax
        mov       r8,[rcx+190]
-       xor       r9d,r9d
-       mov       edx,64
-       mov       rax,[rcx+198]
-       mov       rcx,257FF622F48
-       mov       rcx,[rcx]
-       mov       [rsp+38],r9
-       mov       [rsp+40],edx
-       mov       r9,2585F621C00
-       mov       r9,[r9]
-       mov       [rsp+20],r9
-       mov       [rsp+28],rcx
+       mov       r9,[rcx+198]
        mov       rcx,r8
+       xor       r8d,r8d
+       mov       [rsp+38],r8
+       mov       dword ptr [rsp+40],64
+       mov       r8,1EC6840A408
+       mov       r8,[r8]
+       mov       [rsp+20],r8
+       mov       r8,1EC6C401F78
+       mov       r8,[r8]
+       mov       [rsp+28],r8
        lea       r8,[rsp+38]
-       mov       r9,rax
        xor       edx,edx
-       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
+       call      qword ptr [7FFD4620FC48]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
        nop
        add       rsp,48
        ret
-; Total bytes of code 102
+; Total bytes of code 99
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
-       call      Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
+       call      qword ptr [7FFD4620FCC0]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
-       mov       r9,257FF628F30
+       mov       r9,1EC6C4081A8
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
-       mov       rdx,7FFD678DE950
+       mov       rdx,7FFD45F55018
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      System.ThrowHelper.Throw(System.String)
+       call      qword ptr [7FFD461BB3D8]
        int       3
-; Total bytes of code 217
+; Total bytes of code 219
```
**Diff for LogWarning_ILogger_Benchmark method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarning_ILogger_Benchmark()
        sub       rsp,48
        xor       eax,eax
        mov       [rsp+38],rax
        mov       r8,[rcx+190]
-       xor       r9d,r9d
-       mov       edx,64
-       mov       rax,[rcx+198]
-       mov       rcx,27B91342F48
-       mov       rcx,[rcx]
-       mov       [rsp+38],r9
-       mov       [rsp+40],edx
-       mov       r9,27BD1341C00
-       mov       r9,[r9]
-       mov       [rsp+20],r9
-       mov       [rsp+28],rcx
+       mov       r9,[rcx+198]
        mov       rcx,r8
+       xor       r8d,r8d
+       mov       [rsp+38],r8
+       mov       dword ptr [rsp+40],64
+       mov       r8,1E885401C58
+       mov       r8,[r8]
+       mov       [rsp+20],r8
+       mov       r8,1E883401F78
+       mov       r8,[r8]
+       mov       [rsp+28],r8
        lea       r8,[rsp+38]
-       mov       r9,rax
        mov       edx,3
-       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
+       call      qword ptr [7FFD4621FF48]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
        nop
        add       rsp,48
        ret
-; Total bytes of code 105
+; Total bytes of code 102
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
-       call      Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
+       call      qword ptr [7FFD46231018]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
-       mov       r9,27B71344B28
+       mov       r9,1E8834081A8
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
-       mov       rdx,7FFD678EE950
+       mov       rdx,7FFD45F65018
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      System.ThrowHelper.Throw(System.String)
+       call      qword ptr [7FFD461CB3D8]
        int       3
-; Total bytes of code 217
+; Total bytes of code 219
```
