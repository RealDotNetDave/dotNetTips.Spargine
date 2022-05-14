## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.CreatePerson01()
; 			var person = RandomData.GenerateRefPerson<Person>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(person);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       sub       rsp,78
       lea       rbp,[rsp+80]
       mov       rsi,rcx
       mov       dword ptr [rbp+0FFF0],19
       mov       dword ptr [rbp+0FFE8],0F
       mov       dword ptr [rbp+0FFE0],0F
       mov       dword ptr [rbp+0FFD8],0F
       mov       dword ptr [rbp+0FFD0],19
       mov       dword ptr [rbp+0FFC8],8
       mov       dword ptr [rbp+0FFC0],0F
       lea       rdx,[rbp+0FFD8]
       mov       [rsp+20],rdx
       lea       rdx,[rbp+0FFD0]
       mov       [rsp+28],rdx
       lea       rdx,[rbp+0FFC8]
       mov       [rsp+30],rdx
       lea       rdx,[rbp+0FFC0]
       mov       [rsp+38],rdx
       lea       rdx,[rbp+0FFF0]
       lea       r8,[rbp+0FFE8]
       lea       r9,[rbp+0FFE0]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson(Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef)
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,78
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],0
       je        short M01_L00
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFEBCE20E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       rbp,rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC9A0460
       call      qword ptr [7FFEBCD80460]
       mov       ecx,[rsi]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC9A0468
       call      qword ptr [7FFEBCD80468]
       mov       ecx,[rsi]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC9A0470
       call      qword ptr [7FFEBCD80470]
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+60]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       dword ptr [rsp+58],1
       mov       dword ptr [rsp+50],4B
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+50]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32 ByRef, Int32 ByRef)
       imul      ecx,eax,16D
       jo        near ptr M01_L02
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rax,46DC5D638865
       cmp       rcx,rax
       jg        near ptr M01_L03
       mov       rax,0B923A29C779B
       cmp       rcx,rax
       jl        near ptr M01_L03
       imul      rsi,rcx,2710
       lea       rcx,[rsp+60]
       call      System.DateTimeOffset.get_ClockDateTime()
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rax
       sub       rdx,rsi
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L04
       mov       rcx,0
       and       rcx,rax
       or        rdx,rcx
       mov       ecx,[rsp+60]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L05
       mov       r8,0FF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L05
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+30],xmm0
       lea       rcx,[rsp+30]
       call      System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rcx,rbp
       lea       rdx,[rsp+20]
       mov       r11,7FFEBC9A0478
       call      qword ptr [7FFEBCD80478]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC9A0480
       call      qword ptr [7FFEBCD80480]
       mov       ecx,[rdi]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC9A0488
       call      qword ptr [7FFEBCD80488]
       mov       ecx,[rbx]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC9A0490
       call      qword ptr [7FFEBCD80490]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC9A0498
       call      qword ptr [7FFEBCD80498]
       mov       rsi,[rsp+0C0]
       mov       ecx,[rsi]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC9A04A0
       call      qword ptr [7FFEBCD804A0]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC9A04A8
       call      qword ptr [7FFEBCD804A8]
       mov       rsi,[rsp+0C8]
       mov       ecx,[rsi]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC9A04B0
       call      qword ptr [7FFEBCD804B0]
       mov       rsi,[rsp+0D0]
       mov       ecx,[rsi]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC9A04B8
       call      qword ptr [7FFEBCD804B8]
       mov       rsi,[rsp+0D8]
       mov       ecx,[rsi]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC9A04C0
       call      qword ptr [7FFEBCD804C0]
       mov       rax,rbp
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      System.SR.get_Overflow_TimeSpanTooLong()
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L04:
       xor       ecx,ecx
       call      System.DateTime.ThrowDateArithmetic(Int32)
       int       3
M01_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_TimeSpanTooLong()
       int       3
; Total bytes of code 861
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.CreatePerson04()
; 			var person = RandomData.GenerateRefPerson<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(person);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       sub       rsp,78
       lea       rbp,[rsp+80]
       mov       rsi,rcx
       mov       dword ptr [rbp+0FFF0],19
       mov       dword ptr [rbp+0FFE8],0F
       mov       dword ptr [rbp+0FFE0],0F
       mov       dword ptr [rbp+0FFD8],0F
       mov       dword ptr [rbp+0FFD0],19
       mov       dword ptr [rbp+0FFC8],8
       mov       dword ptr [rbp+0FFC0],0F
       lea       rdx,[rbp+0FFD8]
       mov       [rsp+20],rdx
       lea       rdx,[rbp+0FFD0]
       mov       [rsp+28],rdx
       lea       rdx,[rbp+0FFC8]
       mov       [rsp+30],rdx
       lea       rdx,[rbp+0FFC0]
       mov       [rsp+38],rdx
       lea       rdx,[rbp+0FFF0]
       lea       r8,[rbp+0FFE8]
       lea       r9,[rbp+0FFE0]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson(Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef)
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,78
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],0
       je        short M01_L00
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFEBCDF0E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       rbp,rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC970460
       call      qword ptr [7FFEBCD50460]
       mov       ecx,[rsi]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC970468
       call      qword ptr [7FFEBCD50468]
       mov       ecx,[rsi]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC970470
       call      qword ptr [7FFEBCD50470]
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+60]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       dword ptr [rsp+58],1
       mov       dword ptr [rsp+50],4B
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+50]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32 ByRef, Int32 ByRef)
       imul      ecx,eax,16D
       jo        near ptr M01_L02
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rax,46DC5D638865
       cmp       rcx,rax
       jg        near ptr M01_L03
       mov       rax,0B923A29C779B
       cmp       rcx,rax
       jl        near ptr M01_L03
       imul      rsi,rcx,2710
       lea       rcx,[rsp+60]
       call      System.DateTimeOffset.get_ClockDateTime()
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rax
       sub       rdx,rsi
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L04
       mov       rcx,0
       and       rcx,rax
       or        rdx,rcx
       mov       ecx,[rsp+60]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L05
       mov       r8,0FF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L05
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+30],xmm0
       lea       rcx,[rsp+30]
       call      System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rcx,rbp
       lea       rdx,[rsp+20]
       mov       r11,7FFEBC970478
       call      qword ptr [7FFEBCD50478]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC970480
       call      qword ptr [7FFEBCD50480]
       mov       ecx,[rdi]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC970488
       call      qword ptr [7FFEBCD50488]
       mov       ecx,[rbx]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC970490
       call      qword ptr [7FFEBCD50490]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC970498
       call      qword ptr [7FFEBCD50498]
       mov       rsi,[rsp+0C0]
       mov       ecx,[rsi]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC9704A0
       call      qword ptr [7FFEBCD504A0]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC9704A8
       call      qword ptr [7FFEBCD504A8]
       mov       rsi,[rsp+0C8]
       mov       ecx,[rsi]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC9704B0
       call      qword ptr [7FFEBCD504B0]
       mov       rsi,[rsp+0D0]
       mov       ecx,[rsi]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC9704B8
       call      qword ptr [7FFEBCD504B8]
       mov       rsi,[rsp+0D8]
       mov       ecx,[rsi]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC9704C0
       call      qword ptr [7FFEBCD504C0]
       mov       rax,rbp
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      System.SR.get_Overflow_TimeSpanTooLong()
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L04:
       xor       ecx,ecx
       call      System.DateTime.ThrowDateArithmetic(Int32)
       int       3
M01_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_TimeSpanTooLong()
       int       3
; Total bytes of code 861
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.CreatePerson05()
; 			var person = RandomData.GeneratePersonRecordCollection(count: 1, addressCount: 1).First();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(person);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       sub       rsp,0A8
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp+0FFA8],rax
       mov       rsi,rcx
       mov       dword ptr [rbp+0FFF0],1
       mov       dword ptr [rbp+0FFE8],0F
       mov       dword ptr [rbp+0FFE0],19
       mov       dword ptr [rbp+0FFD8],19
       mov       dword ptr [rbp+0FFD0],19
       mov       dword ptr [rbp+0FFC8],19
       mov       dword ptr [rbp+0FFC0],14
       mov       dword ptr [rbp+0FFB8],8
       mov       dword ptr [rbp+0FFB0],0F
       lea       rdx,[rbp+0FFD8]
       mov       [rsp+20],rdx
       lea       rdx,[rbp+0FFD0]
       mov       [rsp+28],rdx
       lea       rdx,[rbp+0FFC8]
       mov       [rsp+30],rdx
       lea       rdx,[rbp+0FFC0]
       mov       [rsp+38],rdx
       lea       rdx,[rbp+0FFB8]
       mov       [rsp+40],rdx
       lea       rdx,[rbp+0FFB0]
       mov       [rsp+48],rdx
       lea       rdx,[rbp+0FFF0]
       lea       r8,[rbp+0FFE8]
       lea       r9,[rbp+0FFE0]
       mov       ecx,1
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef)
       mov       rdx,rax
       lea       r8,[rbp+0FFA8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rdx,rax
       cmp       byte ptr [rbp+0FFA8],0
       je        short M00_L00
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,0A8
       pop       rsi
       pop       rbp
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 228
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0E8
       vzeroupper
       xor       eax,eax
       mov       [rsp+0B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+0C0],xmm4
       mov       [rsp+0D0],rax
       mov       esi,ecx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r14,[rsp+150]
       mov       r15,[rsp+158]
       mov       r12,[rsp+160]
       mov       r13,[rsp+168]
       mov       dword ptr [rsp+0E0],1
       mov       dword ptr [rsp+0D8],7FFFFFFF
       lea       rcx,[rsp+0D0]
       xor       r8d,r8d
       mov       [rcx],r8
       mov       r8,2858E023020
       mov       r8,[r8]
       mov       [rsp+70],r8
       mov       r9d,[rsp+0E0]
       mov       r10d,[rsp+0D8]
       cmp       esi,r9d
       jl        short M01_L00
       cmp       esi,r10d
       setle     r9b
       movzx     r9d,r9b
       jmp       short M01_L01
M01_L00:
       xor       r9d,r9d
M01_L01:
       mov       r10d,r9d
       test      r9d,r9d
       jne       short M01_L02
       movzx     r9d,byte ptr [rcx]
       movzx     r11d,r9b
       mov       ecx,[rcx+4]
       test      r11b,r11b
       je        short M01_L02
       test      r9d,r9d
       je        near ptr M01_L09
       mov       esi,ecx
       jmp       short M01_L05
M01_L02:
       test      r10d,r10d
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       mov       r8,[rsp+70]
       cmp       dword ptr [r8+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r8,rcx
M01_L04:
       mov       rdx,2858E025B38
       mov       rdx,[rdx]
       mov       rcx,r8
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,7FFEBCA84928
       mov       edx,22
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,2858E022F38
       mov       rdx,[rdx]
       mov       rax,[rsp+48]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       mov       [rsp+78],rax
       xor       edx,edx
       mov       [rsp+0CC],edx
       test      esi,esi
       jle       near ptr M01_L07
M01_L06:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B8]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       dword ptr [rsp+0E0],1
       mov       dword ptr [rsp+0D8],4B
       lea       rcx,[rsp+0E0]
       lea       rdx,[rsp+0D8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32 ByRef, Int32 ByRef)
       imul      ecx,eax,16D
       jo        near ptr M01_L08
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rdx,46DC5D638865
       cmp       rcx,rdx
       jg        near ptr M01_L10
       mov       rdx,0B923A29C779B
       cmp       rcx,rdx
       jl        near ptr M01_L10
       imul      rax,rcx,2710
       mov       [rsp+90],rax
       mov       rcx,[rsp+0C0]
       mov       edx,[rsp+0B8]
       movsx     rdx,dx
       movsxd    rdx,edx
       imul      rdx,3C
       mov       r8,0D6BF94D5E5
       cmp       rdx,r8
       jg        near ptr M01_L13
       mov       r8,0FF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L13
       imul      rdx,989680
       call      System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L11
       mov       rcx,0FFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+90]
       mov       r8,2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L12
       mov       r8,0
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B8]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L13
       mov       r8,0FF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L13
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+98],xmm0
       lea       rcx,[rsp+98]
       call      System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+98]
       vmovupd   [rsp+0A8],xmm0
       vmovupd   xmm0,[rsp+0A8]
       vmovupd   [rsp+80],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+80]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,[rbx]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,[rbp]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13
       mov       rax,[rsp+170]
       mov       [rsp+28],rax
       mov       r10,[rsp+178]
       mov       [rsp+30],r10
       mov       ecx,[rdi]
       mov       rdx,r14
       mov       r8,r15
       mov       r9,r12
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+78]
       mov       rcx,[rdx+8]
       mov       r11,7FFEBC9802B0
       call      qword ptr [7FFEBCD502B0]
       test      eax,eax
       jne       near ptr M01_L14
       mov       rax,[rsp+78]
       mov       rcx,[rax+8]
       mov       r11,7FFEBC9802B8
       call      qword ptr [7FFEBCD502B8]
       mov       edx,eax
       mov       rax,[rsp+78]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFEBC9802C0
       call      qword ptr [7FFEBCD502C0]
       mov       edx,[rsp+0CC]
       add       edx,1
       jo        short M01_L08
       cmp       edx,esi
       mov       [rsp+0CC],edx
       jl        near ptr M01_L06
M01_L07:
       mov       rax,[rsp+78]
       add       rsp,0E8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
M01_L10:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      System.SR.get_Overflow_TimeSpanTooLong()
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       call      System.DateTime.ThrowTicksOutOfRange()
       int       3
M01_L12:
       xor       ecx,ecx
       call      System.DateTime.ThrowDateArithmetic(Int32)
       int       3
M01_L13:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_TimeSpanTooLong()
       int       3
M01_L14:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 1328
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp+0FFB0],rax
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M02_L21
       mov       r14,[rsi+10]
       mov       rcx,r14
       mov       r15,[rcx+8]
       cmp       r15,38
       jle       near ptr M02_L06
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r12,rax
       test      r12,r12
       jne       short M02_L04
       mov       rcx,r14
       cmp       r15,40
       jle       near ptr M02_L10
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        near ptr M02_L10
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r13,rax
       test      r13,r13
       je        near ptr M02_L13
       cmp       r15,58
       jle       near ptr M02_L11
       mov       r11,[r14+58]
       test      r11,r11
       je        near ptr M02_L11
M02_L02:
       mov       rcx,r13
       call      qword ptr [r11]
       test      eax,eax
       jg        near ptr M02_L09
M02_L03:
       mov       byte ptr [rbx],0
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L04:
       mov       rcx,r14
       cmp       r15,68
       jle       near ptr M02_L12
       mov       r11,[rcx+68]
       test      r11,r11
       je        near ptr M02_L12
M02_L05:
       mov       rcx,r12
       mov       rdx,rbx
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE50B78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFEBCE510A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L08:
       mov       rcx,r13
       mov       r11,rax
       xor       edx,edx
       call      qword ptr [rax]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L09:
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],60
       jle       short M02_L07
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M02_L07
       mov       rax,r11
       jmp       short M02_L08
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCE50D68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L01
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFEBCE51090
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L02
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFEBCE510C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L05
M02_L13:
       mov       rcx,r14
       cmp       r15,48
       jle       short M02_L18
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M02_L18
M02_L14:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,rax
       mov       r11,7FFEBC980460
       call      qword ptr [7FFEBCD60460]
       test      eax,eax
       jne       short M02_L16
       jmp       short M02_L19
M02_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       [rbp+0FFB0],rax
       jmp       short M02_L20
M02_L16:
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       short M02_L17
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L15
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE50FB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M02_L15
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE50E98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M02_L14
M02_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFEBC980468
       call      qword ptr [7FFEBCD60468]
       jmp       near ptr M02_L03
M02_L20:
       mov       rcx,rsp
       call      M02_L22
       nop
       mov       rax,[rbp+0FFB0]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L21:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L22:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rcx,[rbp+0FFB8]
       test      rcx,rcx
       je        short M02_L23
       mov       r11,7FFEBC980468
       call      qword ptr [7FFEBCD60468]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 720
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.PropertiesToString01()
; 			var person = RandomData.GenerateRefPerson<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(person.PropertiesToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       sub       rsp,78
       lea       rbp,[rsp+80]
       mov       rsi,rcx
       mov       dword ptr [rbp+0FFF0],19
       mov       dword ptr [rbp+0FFE8],0F
       mov       dword ptr [rbp+0FFE0],0F
       mov       dword ptr [rbp+0FFD8],0F
       mov       dword ptr [rbp+0FFD0],19
       mov       dword ptr [rbp+0FFC8],8
       mov       dword ptr [rbp+0FFC0],0F
       lea       rdx,[rbp+0FFD8]
       mov       [rsp+20],rdx
       lea       rdx,[rbp+0FFD0]
       mov       [rsp+28],rdx
       lea       rdx,[rbp+0FFC8]
       mov       [rsp+30],rdx
       lea       rdx,[rbp+0FFC0]
       mov       [rsp+38],rdx
       lea       rdx,[rbp+0FFF0]
       lea       r8,[rbp+0FFE8]
       lea       r9,[rbp+0FFE0]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson(Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef)
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef)
       mov       rcx,rax
       mov       rsi,[rsi+10]
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       r9,1F2E3801E20
       mov       r9,[r9]
       mov       rdx,1F2E37F3020
       mov       rdx,[rdx]
       mov       r8d,3A
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,78
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 211
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],0
       je        short M01_L00
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFEBCDE0E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       rbp,rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC960540
       call      qword ptr [7FFEBCD50540]
       mov       ecx,[rsi]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC960548
       call      qword ptr [7FFEBCD50548]
       mov       ecx,[rsi]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC960550
       call      qword ptr [7FFEBCD50550]
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+60]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       dword ptr [rsp+58],1
       mov       dword ptr [rsp+50],4B
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+50]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32 ByRef, Int32 ByRef)
       imul      ecx,eax,16D
       jo        near ptr M01_L02
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rax,46DC5D638865
       cmp       rcx,rax
       jg        near ptr M01_L03
       mov       rax,0B923A29C779B
       cmp       rcx,rax
       jl        near ptr M01_L03
       imul      rsi,rcx,2710
       lea       rcx,[rsp+60]
       call      System.DateTimeOffset.get_ClockDateTime()
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rax
       sub       rdx,rsi
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L04
       mov       rcx,0
       and       rcx,rax
       or        rdx,rcx
       mov       ecx,[rsp+60]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L05
       mov       r8,0FF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L05
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+30],xmm0
       lea       rcx,[rsp+30]
       call      System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rcx,rbp
       lea       rdx,[rsp+20]
       mov       r11,7FFEBC960558
       call      qword ptr [7FFEBCD50558]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC960560
       call      qword ptr [7FFEBCD50560]
       mov       ecx,[rdi]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC960568
       call      qword ptr [7FFEBCD50568]
       mov       ecx,[rbx]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC960570
       call      qword ptr [7FFEBCD50570]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC960578
       call      qword ptr [7FFEBCD50578]
       mov       rsi,[rsp+0C0]
       mov       ecx,[rsi]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC960580
       call      qword ptr [7FFEBCD50580]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC960588
       call      qword ptr [7FFEBCD50588]
       mov       rsi,[rsp+0C8]
       mov       ecx,[rsi]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC960590
       call      qword ptr [7FFEBCD50590]
       mov       rsi,[rsp+0D0]
       mov       ecx,[rsi]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC960598
       call      qword ptr [7FFEBCD50598]
       mov       rsi,[rsp+0D8]
       mov       ecx,[rsi]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFEBC9605A0
       call      qword ptr [7FFEBCD505A0]
       mov       rax,rbp
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      System.SR.get_Overflow_TimeSpanTooLong()
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L04:
       xor       ecx,ecx
       call      System.DateTime.ThrowDateArithmetic(Int32)
       int       3
M01_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_TimeSpanTooLong()
       int       3
; Total bytes of code 861
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbp,rdx
       mov       ebx,r8d
       mov       rdi,r9
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass12_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+10],bx
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,1F2E37F3020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L00:
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       test      eax,eax
       je        short M02_L01
       mov       r8,1F3037F1760
       mov       rdi,[r8]
       jmp       short M02_L02
M02_L01:
       cmp       byte ptr [rsp+78],0
       jne       short M02_L02
       mov       r8,1F2E37F3020
       mov       rdi,[r8]
M02_L02:
       mov       ebx,[rsp+70]
       movzx     r8d,bl
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass12_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rsi
       mov       r8,rbp
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate(System.Collections.Generic.IEnumerable`1<!!0>, !!1, System.Func`3<!!1,!!0,!!1>)
       call      System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       jne       short M02_L03
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L03:
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.String.Remove(Int32, Int32)
; Total bytes of code 344
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.PropertiesToString02()
; 			var person = RandomData.GeneratePersonRecordCollection(count: 1, addressCount: 1).First();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(person.PropertiesToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       sub       rsp,0A8
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp+0FFA8],rax
       mov       rsi,rcx
       mov       dword ptr [rbp+0FFF0],1
       mov       dword ptr [rbp+0FFE8],0F
       mov       dword ptr [rbp+0FFE0],19
       mov       dword ptr [rbp+0FFD8],19
       mov       dword ptr [rbp+0FFD0],19
       mov       dword ptr [rbp+0FFC8],19
       mov       dword ptr [rbp+0FFC0],14
       mov       dword ptr [rbp+0FFB8],8
       mov       dword ptr [rbp+0FFB0],0F
       lea       rdx,[rbp+0FFD8]
       mov       [rsp+20],rdx
       lea       rdx,[rbp+0FFD0]
       mov       [rsp+28],rdx
       lea       rdx,[rbp+0FFC8]
       mov       [rsp+30],rdx
       lea       rdx,[rbp+0FFC0]
       mov       [rsp+38],rdx
       lea       rdx,[rbp+0FFB8]
       mov       [rsp+40],rdx
       lea       rdx,[rbp+0FFB0]
       mov       [rsp+48],rdx
       lea       rdx,[rbp+0FFF0]
       lea       r8,[rbp+0FFE8]
       lea       r9,[rbp+0FFE0]
       mov       ecx,1
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef)
       mov       rdx,rax
       lea       r8,[rbp+0FFA8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rcx,rax
       cmp       byte ptr [rbp+0FFA8],0
       je        short M00_L00
       mov       rsi,[rsi+10]
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       r9,147B75015E8
       mov       r9,[r9]
       mov       rdx,147D7503020
       mov       rdx,[rdx]
       mov       r8d,3A
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,0A8
       pop       rsi
       pop       rbp
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 284
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0E8
       vzeroupper
       xor       eax,eax
       mov       [rsp+0B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+0C0],xmm4
       mov       [rsp+0D0],rax
       mov       esi,ecx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       r14,[rsp+150]
       mov       r15,[rsp+158]
       mov       r12,[rsp+160]
       mov       r13,[rsp+168]
       mov       dword ptr [rsp+0E0],1
       mov       dword ptr [rsp+0D8],7FFFFFFF
       lea       rcx,[rsp+0D0]
       xor       r8d,r8d
       mov       [rcx],r8
       mov       r8,147D7503020
       mov       r8,[r8]
       mov       [rsp+70],r8
       mov       r9d,[rsp+0E0]
       mov       r10d,[rsp+0D8]
       cmp       esi,r9d
       jl        short M01_L00
       cmp       esi,r10d
       setle     r9b
       movzx     r9d,r9b
       jmp       short M01_L01
M01_L00:
       xor       r9d,r9d
M01_L01:
       mov       r10d,r9d
       test      r9d,r9d
       jne       short M01_L02
       movzx     r9d,byte ptr [rcx]
       movzx     r11d,r9b
       mov       ecx,[rcx+4]
       test      r11b,r11b
       je        short M01_L02
       test      r9d,r9d
       je        near ptr M01_L09
       mov       esi,ecx
       jmp       short M01_L05
M01_L02:
       test      r10d,r10d
       jne       short M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rcx,rax
       mov       r8,[rsp+70]
       cmp       dword ptr [r8+8],0
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       r8,rcx
M01_L04:
       mov       rdx,147B7501730
       mov       rdx,[rdx]
       mov       rcx,r8
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L05:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,7FFEBCA84928
       mov       edx,22
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,147D7502F38
       mov       rdx,[rdx]
       mov       rax,[rsp+48]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       mov       [rsp+78],rax
       xor       edx,edx
       mov       [rsp+0CC],edx
       test      esi,esi
       jle       near ptr M01_L07
M01_L06:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B8]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       dword ptr [rsp+0E0],1
       mov       dword ptr [rsp+0D8],4B
       lea       rcx,[rsp+0E0]
       lea       rdx,[rsp+0D8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32 ByRef, Int32 ByRef)
       imul      ecx,eax,16D
       jo        near ptr M01_L08
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rdx,46DC5D638865
       cmp       rcx,rdx
       jg        near ptr M01_L10
       mov       rdx,0B923A29C779B
       cmp       rcx,rdx
       jl        near ptr M01_L10
       imul      rax,rcx,2710
       mov       [rsp+90],rax
       mov       rcx,[rsp+0C0]
       mov       edx,[rsp+0B8]
       movsx     rdx,dx
       movsxd    rdx,edx
       imul      rdx,3C
       mov       r8,0D6BF94D5E5
       cmp       rdx,r8
       jg        near ptr M01_L13
       mov       r8,0FF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L13
       imul      rdx,989680
       call      System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L11
       mov       rcx,0FFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+90]
       mov       r8,2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L12
       mov       r8,0
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B8]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L13
       mov       r8,0FF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L13
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+98],xmm0
       lea       rcx,[rsp+98]
       call      System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+98]
       vmovupd   [rsp+0A8],xmm0
       vmovupd   xmm0,[rsp+0A8]
       vmovupd   [rsp+80],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+80]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,[rbx]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,[rbp]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13
       mov       rax,[rsp+170]
       mov       [rsp+28],rax
       mov       r10,[rsp+178]
       mov       [rsp+30],r10
       mov       ecx,[rdi]
       mov       rdx,r14
       mov       r8,r15
       mov       r9,r12
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+78]
       mov       rcx,[rdx+8]
       mov       r11,7FFEBC9802B0
       call      qword ptr [7FFEBCD502B0]
       test      eax,eax
       jne       near ptr M01_L14
       mov       rax,[rsp+78]
       mov       rcx,[rax+8]
       mov       r11,7FFEBC9802B8
       call      qword ptr [7FFEBCD502B8]
       mov       edx,eax
       mov       rax,[rsp+78]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFEBC9802C0
       call      qword ptr [7FFEBCD502C0]
       mov       edx,[rsp+0CC]
       add       edx,1
       jo        short M01_L08
       cmp       edx,esi
       mov       [rsp+0CC],edx
       jl        near ptr M01_L06
M01_L07:
       mov       rax,[rsp+78]
       add       rsp,0E8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_NoValue()
       int       3
M01_L10:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      System.SR.get_Overflow_TimeSpanTooLong()
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       call      System.DateTime.ThrowTicksOutOfRange()
       int       3
M01_L12:
       xor       ecx,ecx
       call      System.DateTime.ThrowDateArithmetic(Int32)
       int       3
M01_L13:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_TimeSpanTooLong()
       int       3
M01_L14:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 1328
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp+0FFB0],rax
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M02_L21
       mov       r14,[rsi+10]
       mov       rcx,r14
       mov       r15,[rcx+8]
       cmp       r15,38
       jle       near ptr M02_L06
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M02_L06
M02_L00:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r12,rax
       test      r12,r12
       jne       short M02_L04
       mov       rcx,r14
       cmp       r15,40
       jle       near ptr M02_L10
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        near ptr M02_L10
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r13,rax
       test      r13,r13
       je        near ptr M02_L13
       cmp       r15,58
       jle       near ptr M02_L11
       mov       r11,[r14+58]
       test      r11,r11
       je        near ptr M02_L11
M02_L02:
       mov       rcx,r13
       call      qword ptr [r11]
       test      eax,eax
       jg        near ptr M02_L09
M02_L03:
       mov       byte ptr [rbx],0
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L04:
       mov       rcx,r14
       cmp       r15,68
       jle       near ptr M02_L12
       mov       r11,[rcx+68]
       test      r11,r11
       je        near ptr M02_L12
M02_L05:
       mov       rcx,r12
       mov       rdx,rbx
       call      qword ptr [r11]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFEBCE5D4F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFEBCE5DA20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M02_L08:
       mov       rcx,r13
       mov       r11,rax
       xor       edx,edx
       call      qword ptr [rax]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L09:
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],60
       jle       short M02_L07
       mov       r11,[rcx+60]
       test      r11,r11
       je        short M02_L07
       mov       rax,r11
       jmp       short M02_L08
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFEBCE5D6E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L01
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFEBCE5DA08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L02
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFEBCE5DA38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L05
M02_L13:
       mov       rcx,r14
       cmp       r15,48
       jle       short M02_L18
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M02_L18
M02_L14:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,rax
       mov       r11,7FFEBC980568
       call      qword ptr [7FFEBCD70568]
       test      eax,eax
       jne       short M02_L16
       jmp       short M02_L19
M02_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       mov       [rbp+0FFB0],rax
       jmp       short M02_L20
M02_L16:
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],50
       jle       short M02_L17
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L15
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFEBCE5D930
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M02_L15
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFEBCE5D810
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M02_L14
M02_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFEBC980570
       call      qword ptr [7FFEBCD70570]
       jmp       near ptr M02_L03
M02_L20:
       mov       rcx,rsp
       call      M02_L22
       nop
       mov       rax,[rbp+0FFB0]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L21:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L22:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rcx,[rbp+0FFB8]
       test      rcx,rcx
       je        short M02_L23
       mov       r11,7FFEBC980570
       call      qword ptr [7FFEBCD70570]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 720
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbp,rdx
       mov       ebx,r8d
       mov       rdi,r9
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass12_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+10],bx
       test      rsi,rsi
       jne       short M03_L00
       mov       rax,147D7503020
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L00:
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,4
       call      System.String.Equals(System.String, System.String, System.StringComparison)
       test      eax,eax
       je        short M03_L01
       mov       r8,147D7512FB0
       mov       rdi,[r8]
       jmp       short M03_L02
M03_L01:
       cmp       byte ptr [rsp+78],0
       jne       short M03_L02
       mov       r8,147D7503020
       mov       rdi,[r8]
M03_L02:
       mov       ebx,[rsp+70]
       movzx     r8d,bl
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass12_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rsi
       mov       r8,rbp
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate(System.Collections.Generic.IEnumerable`1<!!0>, !!1, System.Func`3<!!1,!!0,!!1>)
       call      System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       jne       short M03_L03
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.String.Remove(Int32, Int32)
; Total bytes of code 344
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

