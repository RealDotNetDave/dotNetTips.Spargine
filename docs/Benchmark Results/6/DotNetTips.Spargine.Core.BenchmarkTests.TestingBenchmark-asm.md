## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.WIPTest08()
; 			var ex = new ArgumentNullException(DateTime.Now.ToString(CultureInfo.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			WIPTests.InTest02(ex);
; 			^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       call      System.DateTime.get_Now()
       mov       rsi,rax
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rsi
       mov       r9,0
       mov       r8,rdi
       xor       edx,edx
       call      System.DateTimeFormat.Format(System.DateTime, System.String, System.IFormatProvider, System.TimeSpan)
       mov       rsi,rax
       call      System.SR.get_ArgumentNull_Generic()
       mov       dword ptr [rbx+70],0E0434352
       mov       dword ptr [rbx+74],80131500
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+74],80131501
       lea       rcx,[rbx+78]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+74],80070057
       mov       dword ptr [rbx+74],80004003
       mov       rcx,rbx
       mov       rax,[7FFE6461D358]
       call      qword ptr [rax+20]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M00_L00
       mov       rcx,2A0D39D1028
       mov       rsi,[rcx]
M00_L00:
       mov       rcx,2A0F39D4368
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE6426D170
       mov       [rbx+18],rcx
       mov       rcx,offset System.Console.WriteLine(System.String)
       mov       [rbx+20],rcx
       mov       rcx,rdi
       mov       r9,rsi
       mov       r8,rbx
       xor       edx,edx
       call      BenchmarkDotNet.Loggers.ConsoleLogger.Write(BenchmarkDotNet.Loggers.LogKind, System.Action`1<System.String>, System.String)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 261
```
```assembly
; System.DateTime.get_Now()
       push      rdi
       push      rsi
       sub       rsp,38
       lea       rcx,[rsp+28]
       mov       rax,7FFF810B5040
       call      rax
       mov       rsi,[rsp+28]
       mov       rax,2A0F39D1230
       mov       rdi,[rax]
       sub       rsi,[rdi+8]
       cmp       dword ptr [7FFE64614A34],0
       jne       near ptr M01_L07
M01_L00:
       mov       eax,0B2D05E00
       cmp       rsi,rax
       jae       short M01_L02
       add       rsi,[rdi+10]
M01_L01:
       mov       rcx,rsi
       lea       rdx,[rsp+30]
       call      System.TimeZoneInfo.GetDateTimeNowUtcOffsetFromUtc(System.DateTime, Boolean ByRef)
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rsi
       add       rax,rdx
       mov       rdx,2875F4373FFF
       cmp       rax,rdx
       ja        short M01_L04
       cmp       byte ptr [rsp+30],0
       jne       short M01_L03
       mov       rdx,0
       or        rax,rdx
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rsi,rax
       jmp       short M01_L01
M01_L03:
       mov       rdx,0
       or        rax,rdx
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M01_L04:
       test      rax,rax
       jl        short M01_L05
       mov       rax,2875F4373FFF
       jmp       short M01_L06
M01_L05:
       mov       rax,0
M01_L06:
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M01_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L00
; Total bytes of code 217
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       sub       rsp,28
       mov       rcx,7FFE64374928
       mov       edx,230
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+8]
       test      rax,rax
       jne       short M02_L00
       mov       rax,2A0F39D1578
       mov       rax,[rax]
       test      rax,rax
       jne       short M02_L00
       mov       rax,2A0F39D1558
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,28
       ret
M02_L01:
       add       rsp,28
       jmp       near ptr System.Globalization.CultureInfo.InitializeUserDefaultCulture()
; Total bytes of code 83
```
```assembly
; System.DateTimeFormat.Format(System.DateTime, System.String, System.IFormatProvider, System.TimeSpan)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+20]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       mov       [rbp+30],rax
       mov       rax,0BCB466771E6D
       mov       [rbp],rax
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rax,r8
       mov       rbx,r9
       test      rsi,rsi
       je        near ptr M03_L02
       mov       r14d,[rsi+8]
       cmp       r14d,1
       jne       short M03_L02
       movzx     r15d,word ptr [rsi+0C]
       cmp       r15d,52
       jbe       near ptr M03_L09
       cmp       r15d,6F
       je        near ptr M03_L06
       cmp       r15d,72
       jne       short M03_L02
M03_L00:
       mov       ecx,1D
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       lea       rcx,[rsi+0C]
       mov       edx,[rsi+8]
       mov       [rbp+18],rcx
       mov       [rbp+20],edx
       mov       rcx,rdi
       mov       rdx,rbx
       lea       r8,[rbp+18]
       lea       r9,[rbp+38]
       call      System.DateTimeFormat.TryFormatR(System.DateTime, System.TimeSpan, System.Span`1<Char>, Int32 ByRef)
       mov       rax,rsi
       mov       rcx,0BCB466771E6D
       cmp       [rbp],rcx
       je        short M03_L01
       call      CORINFO_HELP_FAIL_FAST
M03_L01:
       nop
       lea       rsp,[rbp+48]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L02:
       mov       rcx,rax
       call      System.Globalization.DateTimeFormatInfo.GetInstance(System.IFormatProvider)
       test      rsi,rsi
       je        near ptr M03_L08
       lea       rcx,[rsi+0C]
       mov       r14d,[rsi+8]
M03_L03:
       mov       rdx,rdi
       mov       [rbp+8],rcx
       mov       [rbp+10],r14d
       mov       rcx,rdx
       lea       rdx,[rbp+8]
       mov       r8,rax
       mov       r9,rbx
       call      System.DateTimeFormat.FormatStringBuilder(System.DateTime, System.ReadOnlySpan`1<Char>, System.Globalization.DateTimeFormatInfo, System.TimeSpan)
       mov       rdi,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE64612E80]
       mov       rbx,rax
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       cmp       ecx,168
       jg        short M03_L04
       mov       rcx,7FFE64374928
       mov       edx,413
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       lea       rcx,[rax+50]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M03_L04:
       mov       rax,rbx
       mov       rcx,0BCB466771E6D
       cmp       [rbp],rcx
       je        short M03_L05
       call      CORINFO_HELP_FAIL_FAST
M03_L05:
       nop
       lea       rsp,[rbp+48]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L06:
       test      [rsp],esp
       sub       rsp,50
       lea       rcx,[rsp+20]
       mov       [rbp+28],rcx
       mov       dword ptr [rbp+30],21
       mov       r15,[rbp+28]
       mov       esi,[rbp+30]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       [rbp+18],r15
       mov       [rbp+20],esi
       lea       r8,[rbp+18]
       lea       r9,[rbp+40]
       call      System.DateTimeFormat.TryFormatO(System.DateTime, System.TimeSpan, System.Span`1<Char>, Int32 ByRef)
       mov       ecx,[rbp+40]
       mov       eax,ecx
       mov       edx,esi
       cmp       rax,rdx
       ja        short M03_L10
       mov       [rbp+28],r15
       mov       [rbp+30],ecx
       lea       rcx,[rbp+28]
       call      System.Span`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rcx,0BCB466771E6D
       cmp       [rbp],rcx
       je        short M03_L07
       call      CORINFO_HELP_FAIL_FAST
M03_L07:
       nop
       lea       rsp,[rbp+48]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L08:
       xor       ecx,ecx
       xor       r14d,r14d
       jmp       near ptr M03_L03
M03_L09:
       cmp       r15d,4F
       je        near ptr M03_L06
       cmp       r15d,52
       je        near ptr M03_L00
       jmp       near ptr M03_L02
M03_L10:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 520
```
```assembly
; System.SR.get_ArgumentNull_Generic()
       mov       rcx,2A0D39D4A00
       mov       rcx,[rcx]
       jmp       near ptr System.SR.GetResourceString(System.String)
; Total bytes of code 18
```
```assembly
; System.Console.WriteLine(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      System.Console.get_Out()
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 36
```
```assembly
; BenchmarkDotNet.Loggers.ConsoleLogger.Write(BenchmarkDotNet.Loggers.LogKind, System.Action`1<System.String>, System.String)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       mov       ebx,edx
       mov       r14,r8
       mov       rdi,r9
       cmp       byte ptr [rsi+10],0
       jne       short M06_L00
       mov       rcx,rdi
       call      BenchmarkDotNet.Helpers.AsciiHelper.ToAscii(System.String)
       mov       rdi,rax
M06_L00:
       call      System.ConsolePal.get_ForegroundColor()
       mov       [rbp+0FFD4],eax
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,ebx
       call      System.Collections.Generic.Dictionary`2[[BenchmarkDotNet.Loggers.LogKind, BenchmarkDotNet],[System.ConsoleColor, System.Console]].FindValue(BenchmarkDotNet.Loggers.LogKind)
       test      rax,rax
       jne       short M06_L01
       mov       r15d,7
       jmp       short M06_L02
M06_L01:
       mov       rcx,[rsi+8]
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FFE64619210]
       mov       r15d,eax
M06_L02:
       call      System.ConsolePal.get_ForegroundColor()
       cmp       eax,r15d
       je        short M06_L03
       call      System.ConsolePal.get_BackgroundColor()
       cmp       eax,r15d
       je        short M06_L03
       mov       ecx,r15d
       call      System.ConsolePal.set_ForegroundColor(System.ConsoleColor)
M06_L03:
       mov       rcx,[r14+8]
       mov       rdx,rdi
       call      qword ptr [r14+18]
       nop
       call      System.ConsolePal.get_ForegroundColor()
       cmp       eax,[rbp+0FFD4]
       je        short M06_L04
       call      System.ConsolePal.get_BackgroundColor()
       mov       edx,[rbp+0FFD4]
       cmp       eax,edx
       je        short M06_L04
       mov       ecx,edx
       call      System.ConsolePal.set_ForegroundColor(System.ConsoleColor)
M06_L04:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       call      System.ConsolePal.get_ForegroundColor()
       cmp       eax,[rbp+0FFD4]
       je        short M06_L05
       call      System.ConsolePal.get_BackgroundColor()
       cmp       eax,[rbp+0FFD4]
       je        short M06_L05
       mov       ecx,[rbp+0FFD4]
       call      System.ConsolePal.set_ForegroundColor(System.ConsoleColor)
M06_L05:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 250
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.WIPTest07()
; 			var ex = new ArgumentNullException(DateTime.Now.ToString(CultureInfo.CurrentCulture));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			WIPTests.InTest01(ex);
; 			^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       call      System.DateTime.get_Now()
       mov       rsi,rax
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rsi
       mov       r9,0
       mov       r8,rdi
       xor       edx,edx
       call      System.DateTimeFormat.Format(System.DateTime, System.String, System.IFormatProvider, System.TimeSpan)
       mov       rsi,rax
       call      System.SR.get_ArgumentNull_Generic()
       mov       dword ptr [rbx+70],0E0434352
       mov       dword ptr [rbx+74],80131500
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+74],80131501
       lea       rcx,[rbx+78]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+74],80070057
       mov       dword ptr [rbx+74],80004003
       mov       rcx,rbx
       call      qword ptr [7FFE64634BC0]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M00_L00
       mov       rcx,27E24203020
       mov       rsi,[rcx]
M00_L00:
       mov       rcx,27E24206778
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE6428D170
       mov       [rbx+18],rcx
       mov       rcx,offset System.Console.WriteLine(System.String)
       mov       [rbx+20],rcx
       mov       rcx,rdi
       mov       r9,rsi
       mov       r8,rbx
       xor       edx,edx
       call      BenchmarkDotNet.Loggers.ConsoleLogger.Write(BenchmarkDotNet.Loggers.LogKind, System.Action`1<System.String>, System.String)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 257
```
```assembly
; System.DateTime.get_Now()
       push      rdi
       push      rsi
       sub       rsp,38
       lea       rcx,[rsp+28]
       mov       rax,7FFF810B5040
       call      rax
       mov       rsi,[rsp+28]
       mov       rax,27E24201230
       mov       rdi,[rax]
       sub       rsi,[rdi+8]
       cmp       dword ptr [7FFE64634A34],0
       jne       near ptr M01_L07
M01_L00:
       mov       eax,0B2D05E00
       cmp       rsi,rax
       jae       short M01_L02
       add       rsi,[rdi+10]
M01_L01:
       mov       rcx,rsi
       lea       rdx,[rsp+30]
       call      System.TimeZoneInfo.GetDateTimeNowUtcOffsetFromUtc(System.DateTime, Boolean ByRef)
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rsi
       add       rax,rdx
       mov       rdx,2875F4373FFF
       cmp       rax,rdx
       ja        short M01_L04
       cmp       byte ptr [rsp+30],0
       jne       short M01_L03
       mov       rdx,0
       or        rax,rdx
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rsi,rax
       jmp       short M01_L01
M01_L03:
       mov       rdx,0
       or        rax,rdx
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M01_L04:
       test      rax,rax
       jl        short M01_L05
       mov       rax,2875F4373FFF
       jmp       short M01_L06
M01_L05:
       mov       rax,0
M01_L06:
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M01_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L00
; Total bytes of code 217
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       sub       rsp,28
       mov       rcx,7FFE64394928
       mov       edx,230
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+8]
       test      rax,rax
       jne       short M02_L00
       mov       rax,27E24201578
       mov       rax,[rax]
       test      rax,rax
       jne       short M02_L00
       mov       rax,27E24201558
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,28
       ret
M02_L01:
       add       rsp,28
       jmp       near ptr System.Globalization.CultureInfo.InitializeUserDefaultCulture()
; Total bytes of code 83
```
```assembly
; System.DateTimeFormat.Format(System.DateTime, System.String, System.IFormatProvider, System.TimeSpan)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+20]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       mov       [rbp+30],rax
       mov       rax,574556152640
       mov       [rbp],rax
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rax,r8
       mov       rbx,r9
       test      rsi,rsi
       je        near ptr M03_L02
       mov       r14d,[rsi+8]
       cmp       r14d,1
       jne       short M03_L02
       movzx     r15d,word ptr [rsi+0C]
       cmp       r15d,52
       jbe       near ptr M03_L09
       cmp       r15d,6F
       je        near ptr M03_L06
       cmp       r15d,72
       jne       short M03_L02
M03_L00:
       mov       ecx,1D
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       lea       rcx,[rsi+0C]
       mov       edx,[rsi+8]
       mov       [rbp+18],rcx
       mov       [rbp+20],edx
       mov       rcx,rdi
       mov       rdx,rbx
       lea       r8,[rbp+18]
       lea       r9,[rbp+38]
       call      System.DateTimeFormat.TryFormatR(System.DateTime, System.TimeSpan, System.Span`1<Char>, Int32 ByRef)
       mov       rax,rsi
       mov       rcx,574556152640
       cmp       [rbp],rcx
       je        short M03_L01
       call      CORINFO_HELP_FAIL_FAST
M03_L01:
       nop
       lea       rsp,[rbp+48]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L02:
       mov       rcx,rax
       call      System.Globalization.DateTimeFormatInfo.GetInstance(System.IFormatProvider)
       test      rsi,rsi
       je        near ptr M03_L08
       lea       rcx,[rsi+0C]
       mov       r14d,[rsi+8]
M03_L03:
       mov       rdx,rdi
       mov       [rbp+8],rcx
       mov       [rbp+10],r14d
       mov       rcx,rdx
       lea       rdx,[rbp+8]
       mov       r8,rax
       mov       r9,rbx
       call      System.DateTimeFormat.FormatStringBuilder(System.DateTime, System.ReadOnlySpan`1<Char>, System.Globalization.DateTimeFormatInfo, System.TimeSpan)
       mov       rdi,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE64632E80]
       mov       rbx,rax
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       cmp       ecx,168
       jg        short M03_L04
       mov       rcx,7FFE64394928
       mov       edx,413
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       lea       rcx,[rax+50]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M03_L04:
       mov       rax,rbx
       mov       rcx,574556152640
       cmp       [rbp],rcx
       je        short M03_L05
       call      CORINFO_HELP_FAIL_FAST
M03_L05:
       nop
       lea       rsp,[rbp+48]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L06:
       test      [rsp],esp
       sub       rsp,50
       lea       rcx,[rsp+20]
       mov       [rbp+28],rcx
       mov       dword ptr [rbp+30],21
       mov       r15,[rbp+28]
       mov       esi,[rbp+30]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       [rbp+18],r15
       mov       [rbp+20],esi
       lea       r8,[rbp+18]
       lea       r9,[rbp+40]
       call      System.DateTimeFormat.TryFormatO(System.DateTime, System.TimeSpan, System.Span`1<Char>, Int32 ByRef)
       mov       ecx,[rbp+40]
       mov       eax,ecx
       mov       edx,esi
       cmp       rax,rdx
       ja        short M03_L10
       mov       [rbp+28],r15
       mov       [rbp+30],ecx
       lea       rcx,[rbp+28]
       call      System.Span`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rcx,574556152640
       cmp       [rbp],rcx
       je        short M03_L07
       call      CORINFO_HELP_FAIL_FAST
M03_L07:
       nop
       lea       rsp,[rbp+48]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L08:
       xor       ecx,ecx
       xor       r14d,r14d
       jmp       near ptr M03_L03
M03_L09:
       cmp       r15d,4F
       je        near ptr M03_L06
       cmp       r15d,52
       je        near ptr M03_L00
       jmp       near ptr M03_L02
M03_L10:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 520
```
```assembly
; System.SR.get_ArgumentNull_Generic()
       mov       rcx,27E44201DD8
       mov       rcx,[rcx]
       jmp       near ptr System.SR.GetResourceString(System.String)
; Total bytes of code 18
```
```assembly
; System.ArgumentException.get_Message()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      System.ArgumentException.SetMessageField()
       mov       rdi,[rsi+10]
       test      rdi,rdi
       je        near ptr M05_L08
M05_L00:
       mov       rcx,[rsi+78]
       test      rcx,rcx
       je        near ptr M05_L01
       cmp       dword ptr [rcx+8],0
       je        near ptr M05_L01
       mov       rcx,27E2420A590
       mov       rcx,[rcx]
       call      System.SR.GetResourceString(System.String)
       mov       rcx,rax
       mov       rdx,[rsi+78]
       call      System.SR.Format(System.String, System.Object)
       mov       rsi,rax
       test      rdi,rdi
       je        near ptr M05_L05
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        near ptr M05_L05
       test      rsi,rsi
       je        near ptr M05_L02
       cmp       dword ptr [rsi+8],0
       je        near ptr M05_L02
       mov       ebx,[rdi+8]
       mov       ecx,[rsi+8]
       lea       ecx,[rbx+rcx+1]
       call      System.String.FastAllocateString(Int32)
       mov       rbp,rax
       cmp       [rbp+8],ebx
       jl        near ptr M05_L09
       lea       rcx,[rbp+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,ebx
       mov       edx,[rbp+8]
       sub       edx,ecx
       cmp       edx,1
       jl        near ptr M05_L10
       lea       rdx,[rbp+0C]
       movsxd    rcx,ecx
       lea       rcx,[rdx+rcx*2]
       mov       rdx,27E44201E00
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,2
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       edx,[rbx+1]
       mov       rcx,rbp
       mov       r8,rsi
       call      System.String.FillStringChecked(System.String, Int32, System.String)
       mov       rdi,rbp
M05_L01:
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L02:
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        short M05_L04
       mov       ebx,[rdi+8]
       mov       esi,ebx
       lea       ecx,[rsi+1]
       call      System.String.FastAllocateString(Int32)
       mov       rbp,rax
       mov       r14d,[rbp+8]
       cmp       ebx,r14d
       jg        near ptr M05_L11
       lea       r15,[rbp+0C]
       mov       rcx,r15
       lea       rdx,[rdi+0C]
       mov       r8d,ebx
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       sub       r14d,esi
       test      r14d,r14d
       jle       near ptr M05_L12
       movsxd    rcx,esi
       lea       rcx,[r15+rcx*2]
       mov       rdx,27E44201E00
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,2
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdi,rbp
M05_L03:
       jmp       short M05_L01
M05_L04:
       mov       rcx,27E44201E00
       mov       rdi,[rcx]
       jmp       short M05_L03
M05_L05:
       test      rsi,rsi
       je        short M05_L07
       cmp       dword ptr [rsi+8],0
       je        short M05_L07
       mov       ecx,[rsi+8]
       inc       ecx
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],1
       jl        near ptr M05_L13
       lea       rcx,[rdi+0C]
       mov       rdx,27E44201E00
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,2
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       edx,1
       mov       r8,rsi
       call      System.String.FillStringChecked(System.String, Int32, System.String)
M05_L06:
       jmp       near ptr M05_L01
M05_L07:
       mov       rcx,27E44201E00
       mov       rdi,[rcx]
       jmp       short M05_L06
M05_L08:
       mov       rcx,27E2420A5A0
       mov       rcx,[rcx]
       call      System.SR.GetResourceString(System.String)
       mov       rdi,rax
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       call      qword ptr [7FFE64639438]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.SR.Format(System.String, System.Object)
       mov       rdi,rax
       jmp       near ptr M05_L00
M05_L09:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L10:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L13:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 720
```
```assembly
; System.Console.WriteLine(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      System.Console.get_Out()
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax+30]
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 36
```
```assembly
; BenchmarkDotNet.Loggers.ConsoleLogger.Write(BenchmarkDotNet.Loggers.LogKind, System.Action`1<System.String>, System.String)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       mov       ebx,edx
       mov       r14,r8
       mov       rdi,r9
       cmp       byte ptr [rsi+10],0
       jne       short M07_L00
       mov       rcx,rdi
       call      BenchmarkDotNet.Helpers.AsciiHelper.ToAscii(System.String)
       mov       rdi,rax
M07_L00:
       call      System.ConsolePal.get_ForegroundColor()
       mov       [rbp+0FFD4],eax
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,ebx
       call      System.Collections.Generic.Dictionary`2[[BenchmarkDotNet.Loggers.LogKind, BenchmarkDotNet],[System.ConsoleColor, System.Console]].FindValue(BenchmarkDotNet.Loggers.LogKind)
       test      rax,rax
       jne       short M07_L01
       mov       r15d,7
       jmp       short M07_L02
M07_L01:
       mov       rcx,[rsi+8]
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FFE64639210]
       mov       r15d,eax
M07_L02:
       call      System.ConsolePal.get_ForegroundColor()
       cmp       eax,r15d
       je        short M07_L03
       call      System.ConsolePal.get_BackgroundColor()
       cmp       eax,r15d
       je        short M07_L03
       mov       ecx,r15d
       call      System.ConsolePal.set_ForegroundColor(System.ConsoleColor)
M07_L03:
       mov       rcx,[r14+8]
       mov       rdx,rdi
       call      qword ptr [r14+18]
       nop
       call      System.ConsolePal.get_ForegroundColor()
       cmp       eax,[rbp+0FFD4]
       je        short M07_L04
       call      System.ConsolePal.get_BackgroundColor()
       mov       edx,[rbp+0FFD4]
       cmp       eax,edx
       je        short M07_L04
       mov       ecx,edx
       call      System.ConsolePal.set_ForegroundColor(System.ConsoleColor)
M07_L04:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       call      System.ConsolePal.get_ForegroundColor()
       cmp       eax,[rbp+0FFD4]
       je        short M07_L05
       call      System.ConsolePal.get_BackgroundColor()
       cmp       eax,[rbp+0FFD4]
       je        short M07_L05
       mov       ecx,[rbp+0FFD4]
       call      System.ConsolePal.set_ForegroundColor(System.ConsoleColor)
M07_L05:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 250
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.WIPTest02()
; 			var result = WIPTests.TryValidateNullAgressive(this._person);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rcx+0A8]
       test      rax,rax
       sete      al
       movzx     eax,al
       mov       rdx,[rcx+10]
       mov       [rdx+54],al
       ret
; Total bytes of code 24
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.WIPTest01()
; 			var result = WIPTests.TryValidateNull(this._person);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rcx+0A8]
       test      rax,rax
       sete      al
       movzx     eax,al
       mov       rdx,[rcx+10]
       mov       [rdx+54],al
       ret
; Total bytes of code 24
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.WIPTest03()
; 			var result = WIPTests.TryValidateNullNoInlining(this._person);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0A8]
       xor       edx,edx
       call      DotNetTips.Spargine.Core.BenchmarkTests.WIPTests.TryValidateNullNoInlining(System.Object, Boolean)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.WIPTests.TryValidateNullNoInlining(System.Object, Boolean)
; 			var result = value is null;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (result && throwException)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				ExceptionThrower.ThrowInvalidValueException("Failed", value);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return result;
; 			^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       test      rcx,rcx
       sete      sil
       movzx     esi,sil
       movzx     edx,dl
       test      edx,esi
       je        short M01_L00
       mov       rdx,22B9DAE9B40
       mov       rdx,[rdx]
       mov       r8,rcx
       mov       rcx,offset MD_DotNetTips.Spargine.Core.ExceptionThrower.ThrowInvalidValueException(System.String, !!0)
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowInvalidValueException[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon)
M01_L00:
       mov       eax,esi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 62
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.WIPTest04()
; 			var result = WIPTests.TryValidateNullNoOptimization(this._person);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rcx+0A8]
       test      rax,rax
       sete      al
       movzx     eax,al
       mov       rdx,[rcx+10]
       mov       [rdx+54],al
       ret
; Total bytes of code 24
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.WIPTest05()
; 			var result = WIPTests.TryValidateNullPreserveSig(this._person);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rcx+0A8]
       test      rax,rax
       sete      al
       movzx     eax,al
       mov       rdx,[rcx+10]
       mov       [rdx+54],al
       ret
; Total bytes of code 24
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.WIPTest06()
; 			var result = WIPTests.TryValidateNullSynchronized(this._person);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0A8]
       xor       edx,edx
       call      DotNetTips.Spargine.Core.BenchmarkTests.WIPTests.TryValidateNullSynchronized(System.Object, Boolean)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.WIPTests.TryValidateNullSynchronized(System.Object, Boolean)
; 			var result = value is null;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (result && throwException)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				ExceptionThrower.ThrowInvalidValueException("Failed", value);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return result;
; 			^^^^^^^^^^^^^^
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       edi,edx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,1766A092338
       call      CORINFO_HELP_MON_ENTER_STATIC
       test      rsi,rsi
       sete      bl
       movzx     ebx,bl
       movzx     edx,dil
       test      edx,ebx
       je        short M01_L00
       mov       rdx,1761F381F78
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.ExceptionThrower.ThrowInvalidValueException(System.String, !!0)
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowInvalidValueException[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon)
M01_L00:
       lea       rdx,[rbp+0FFE0]
       mov       rcx,1766A092338
       call      CORINFO_HELP_MON_EXIT_STATIC
       movzx     eax,bl
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       lea       rdx,[rbp+0FFE0]
       mov       rcx,1766A092338
       call      CORINFO_HELP_MON_EXIT_STATIC
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 178
```

