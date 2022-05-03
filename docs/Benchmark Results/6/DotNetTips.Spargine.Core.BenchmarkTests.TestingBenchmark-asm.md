## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.WIPTest08()
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
       mov       rax,[7FFF3090D4B8]
       call      qword ptr [rax+20]
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L00
       mov       rcx,1D71B873020
       mov       rcx,[rcx]
M00_L00:
       call      System.Console.WriteLine(System.String)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 179
```
```assembly
; System.DateTime.get_Now()
       push      rdi
       push      rsi
       sub       rsp,38
       lea       rcx,[rsp+28]
       mov       rax,7FFFCC6D5040
       call      rax
       mov       rsi,[rsp+28]
       mov       rax,1D71B871230
       mov       rdi,[rax]
       sub       rsi,[rdi+8]
       cmp       dword ptr [7FFF30914A34],0
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
       mov       rcx,7FFF30674928
       mov       edx,230
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+8]
       test      rax,rax
       jne       short M02_L00
       mov       rax,1D71B871578
       mov       rax,[rax]
       test      rax,rax
       jne       short M02_L00
       mov       rax,1D71B871558
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
       mov       rax,94B2990D96ED
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
       mov       rcx,94B2990D96ED
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
       call      qword ptr [7FFF30912E80]
       mov       rbx,rax
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       cmp       ecx,168
       jg        short M03_L04
       mov       rcx,7FFF30674928
       mov       edx,413
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       lea       rcx,[rax+50]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M03_L04:
       mov       rax,rbx
       mov       rcx,94B2990D96ED
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
       mov       rcx,94B2990D96ED
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
       mov       rcx,1D73B8725F0
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.WIPTest07()
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
       call      qword ptr [7FFF30924BC0]
       mov       rcx,rax
       test      rcx,rcx
       jne       short M00_L00
       mov       rcx,19136BF3020
       mov       rcx,[rcx]
M00_L00:
       call      System.Console.WriteLine(System.String)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 175
```
```assembly
; System.DateTime.get_Now()
       push      rdi
       push      rsi
       sub       rsp,38
       lea       rcx,[rsp+28]
       mov       rax,7FFFCC6D5040
       call      rax
       mov       rsi,[rsp+28]
       mov       rax,19136BF1230
       mov       rdi,[rax]
       sub       rsi,[rdi+8]
       cmp       dword ptr [7FFF30924A34],0
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
       mov       rcx,7FFF30684928
       mov       edx,230
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+8]
       test      rax,rax
       jne       short M02_L00
       mov       rax,19136BF1578
       mov       rax,[rax]
       test      rax,rax
       jne       short M02_L00
       mov       rax,19136BF1558
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
       mov       rax,4BDBE490C7D4
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
       mov       rcx,4BDBE490C7D4
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
       call      qword ptr [7FFF30922E80]
       mov       rbx,rax
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       cmp       ecx,168
       jg        short M03_L04
       mov       rcx,7FFF30684928
       mov       edx,413
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       lea       rcx,[rax+50]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M03_L04:
       mov       rax,rbx
       mov       rcx,4BDBE490C7D4
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
       mov       rcx,4BDBE490C7D4
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
       mov       rcx,19156BF65C8
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
       mov       rcx,19136BF5DA0
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
       mov       rdx,19156BF65F0
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
       mov       rdx,19156BF65F0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,2
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdi,rbp
M05_L03:
       jmp       short M05_L01
M05_L04:
       mov       rcx,19156BF65F0
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
       mov       rdx,19156BF65F0
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
       mov       rcx,19156BF65F0
       mov       rdi,[rcx]
       jmp       short M05_L06
M05_L08:
       mov       rcx,19136BF5DB0
       mov       rcx,[rcx]
       call      System.SR.GetResourceString(System.String)
       mov       rdi,rax
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       call      qword ptr [7FFF30929438]
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.WIPTest02()
       mov       rax,[rcx+0A8]
       test      rax,rax
       sete      al
       movzx     eax,al
       mov       rdx,[rcx+10]
       mov       [rdx+54],al
       ret
; Total bytes of code 24
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.WIPTest01()
       mov       rax,[rcx+0A8]
       test      rax,rax
       sete      al
       movzx     eax,al
       mov       rdx,[rcx+10]
       mov       [rdx+54],al
       ret
; Total bytes of code 24
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.WIPTest03()
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
       push      rsi
       sub       rsp,20
       test      rcx,rcx
       sete      sil
       movzx     esi,sil
       movzx     edx,dl
       test      edx,esi
       je        short M01_L00
       mov       rdx,1903DFA1760
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

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.WIPTest04()
       mov       rax,[rcx+0A8]
       test      rax,rax
       sete      al
       movzx     eax,al
       mov       rdx,[rcx+10]
       mov       [rdx+54],al
       ret
; Total bytes of code 24
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.WIPTest05()
       mov       rax,[rcx+0A8]
       test      rax,rax
       sete      al
       movzx     eax,al
       mov       rdx,[rcx+10]
       mov       [rdx+54],al
       ret
; Total bytes of code 24
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.WIPTest06()
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
       mov       rcx,1CDD0F6B058
       call      CORINFO_HELP_MON_ENTER_STATIC
       test      rsi,rsi
       sete      bl
       movzx     ebx,bl
       movzx     edx,dil
       test      edx,ebx
       je        short M01_L00
       mov       rdx,1D232BA2F90
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.ExceptionThrower.ThrowInvalidValueException(System.String, !!0)
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowInvalidValueException[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon)
M01_L00:
       lea       rdx,[rbp+0FFE0]
       mov       rcx,1CDD0F6B058
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
       mov       rcx,1CDD0F6B058
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

