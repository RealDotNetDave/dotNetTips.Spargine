## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.CreatePerson01()
; 			Person person = RandomData.GenerateRefPerson<Person>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(person);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       rsi,rcx
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,48
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 104
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vzeroupper
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+58],rax
       mov       [rsp+60],rcx
       mov       esi,edx
       mov       edi,r8d
       mov       ebx,r9d
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],0
       je        short M01_L00
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB477063F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       rbp,rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB472604E0
       call      qword ptr [7FFB476804E0]
       mov       ecx,esi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB472604E8
       call      qword ptr [7FFB476804E8]
       mov       ecx,esi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB472604F0
       call      qword ptr [7FFB476804F0]
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+50]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
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
       lea       rcx,[rsp+50]
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
       mov       ecx,[rsp+50]
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
       mov       r11,7FFB472604F8
       call      qword ptr [7FFB476804F8]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB47260500
       call      qword ptr [7FFB47680500]
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB47260508
       call      qword ptr [7FFB47680508]
       mov       ecx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB47260510
       call      qword ptr [7FFB47680510]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB47260518
       call      qword ptr [7FFB47680518]
       mov       ecx,[rsp+0B0]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB47260520
       call      qword ptr [7FFB47680520]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB47260528
       call      qword ptr [7FFB47680528]
       mov       ecx,[rsp+0B8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB47260530
       call      qword ptr [7FFB47680530]
       mov       ecx,[rsp+0C0]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB47260538
       call      qword ptr [7FFB47680538]
       mov       ecx,[rsp+0C8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB47260540
       call      qword ptr [7FFB47680540]
       mov       rax,rbp
       add       rsp,68
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
; Total bytes of code 828
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.CreatePerson04()
; 			PersonProper person = RandomData.GenerateRefPerson<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(person);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       rsi,rcx
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,48
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 104
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vzeroupper
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+58],rax
       mov       [rsp+60],rcx
       mov       esi,edx
       mov       edi,r8d
       mov       ebx,r9d
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],0
       je        short M01_L00
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB477063F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       rbp,rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB472604E0
       call      qword ptr [7FFB476804E0]
       mov       ecx,esi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB472604E8
       call      qword ptr [7FFB476804E8]
       mov       ecx,esi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB472604F0
       call      qword ptr [7FFB476804F0]
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+50]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
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
       lea       rcx,[rsp+50]
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
       mov       ecx,[rsp+50]
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
       mov       r11,7FFB472604F8
       call      qword ptr [7FFB476804F8]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB47260500
       call      qword ptr [7FFB47680500]
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB47260508
       call      qword ptr [7FFB47680508]
       mov       ecx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB47260510
       call      qword ptr [7FFB47680510]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB47260518
       call      qword ptr [7FFB47680518]
       mov       ecx,[rsp+0B0]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB47260520
       call      qword ptr [7FFB47680520]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB47260528
       call      qword ptr [7FFB47680528]
       mov       ecx,[rsp+0B8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB47260530
       call      qword ptr [7FFB47680530]
       mov       ecx,[rsp+0C0]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB47260538
       call      qword ptr [7FFB47680538]
       mov       ecx,[rsp+0C8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB47260540
       call      qword ptr [7FFB47680540]
       mov       rax,rbp
       add       rsp,68
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
; Total bytes of code 828
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.CreatePerson05()
; 			PersonRecord person = RandomData.GeneratePersonRecordCollection(count: 1, addressCount: 1).First();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(person);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFF0],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,1
       mov       edx,1
       mov       r8d,0F
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       lea       r8,[rbp+0FFF0]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rdx,rax
       cmp       byte ptr [rbp+0FFF0],0
       je        short M00_L00
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0C8
       vzeroupper
       xor       eax,eax
       mov       [rsp+0B0],rax
       mov       [rsp+0B8],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+130]
       mov       r15d,[rsp+138]
       mov       r12d,[rsp+140]
       mov       r13d,[rsp+148]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     cl
       movzx     ecx,cl
       jmp       short M01_L01
M01_L00:
       xor       ecx,ecx
M01_L01:
       test      ecx,ecx
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFB4758F5F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,7FFB47344928
       mov       edx,22
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1FC38B82F38
       mov       rdx,[rdx]
       mov       rax,[rsp+48]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       mov       [rsp+70],rax
       xor       edx,edx
       mov       [rsp+0C4],edx
       test      esi,esi
       jle       near ptr M01_L04
M01_L03:
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
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       jo        near ptr M01_L05
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rdx,46DC5D638865
       cmp       rcx,rdx
       jg        near ptr M01_L06
       mov       rdx,0B923A29C779B
       cmp       rcx,rdx
       jl        near ptr M01_L06
       imul      rax,rcx,2710
       mov       [rsp+88],rax
       mov       rcx,[rsp+0B8]
       mov       edx,[rsp+0B0]
       movsx     rdx,dx
       movsxd    rdx,edx
       imul      rdx,3C
       mov       r8,0D6BF94D5E5
       cmp       rdx,r8
       jg        near ptr M01_L09
       mov       r8,0FF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,0FFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L09
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+90],xmm0
       lea       rcx,[rsp+90]
       call      System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFB472402C8
       call      qword ptr [7FFB476402C8]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFB472402D0
       call      qword ptr [7FFB476402D0]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFB472402D8
       call      qword ptr [7FFB476402D8]
       mov       edx,[rsp+0C4]
       add       edx,1
       jo        short M01_L05
       cmp       edx,esi
       mov       [rsp+0C4],edx
       jl        near ptr M01_L03
M01_L04:
       mov       rax,[rsp+70]
       add       rsp,0C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
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
M01_L07:
       call      System.DateTime.ThrowTicksOutOfRange()
       int       3
M01_L08:
       xor       ecx,ecx
       call      System.DateTime.ThrowDateArithmetic(Int32)
       int       3
M01_L09:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_TimeSpanTooLong()
       int       3
M01_L10:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 1156
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
       mov       rdx,7FFB477593A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB477598D8
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
       mov       rdx,7FFB47759598
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L01
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFB477598C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L02
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFB477598F0
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
       mov       r11,7FFB472404E0
       call      qword ptr [7FFB476604E0]
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
       mov       rdx,7FFB477597E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M02_L15
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFB477596C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M02_L14
M02_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB472404E8
       call      qword ptr [7FFB476604E8]
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
       mov       r11,7FFB472404E8
       call      qword ptr [7FFB476604E8]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.PropertiesToString01()
; 			PersonProper person = RandomData.GenerateRefPerson<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(person.PropertiesToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       rsi,rcx
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,rax
       mov       rsi,[rsi+18]
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       r9,1F1FEFB38D8
       mov       r9,[r9]
       mov       rdx,1F1FEFA3020
       mov       rdx,[rdx]
       mov       r8d,3A
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,48
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 160
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vzeroupper
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+58],rax
       mov       [rsp+60],rcx
       mov       esi,edx
       mov       edi,r8d
       mov       ebx,r9d
       mov       rdx,[rcx+10]
       cmp       qword ptr [rdx+10],0
       je        short M01_L00
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB476E63F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       rbp,rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB472405C0
       call      qword ptr [7FFB476605C0]
       mov       ecx,esi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB472405C8
       call      qword ptr [7FFB476605C8]
       mov       ecx,esi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB472405D0
       call      qword ptr [7FFB476605D0]
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+50]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
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
       lea       rcx,[rsp+50]
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
       mov       ecx,[rsp+50]
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
       mov       r11,7FFB472405D8
       call      qword ptr [7FFB476605D8]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB472405E0
       call      qword ptr [7FFB476605E0]
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB472405E8
       call      qword ptr [7FFB476605E8]
       mov       ecx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB472405F0
       call      qword ptr [7FFB476605F0]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB472405F8
       call      qword ptr [7FFB476605F8]
       mov       ecx,[rsp+0B0]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB47240600
       call      qword ptr [7FFB47660600]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB47240608
       call      qword ptr [7FFB47660608]
       mov       ecx,[rsp+0B8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB47240610
       call      qword ptr [7FFB47660610]
       mov       ecx,[rsp+0C0]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB47240618
       call      qword ptr [7FFB47660618]
       mov       ecx,[rsp+0C8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB47240620
       call      qword ptr [7FFB47660620]
       mov       rax,rbp
       add       rsp,68
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
; Total bytes of code 828
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
       mov       rax,1F1FEFA3020
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
       mov       r8,1F1FEFB4408
       mov       rdi,[r8]
       jmp       short M02_L02
M02_L01:
       cmp       byte ptr [rsp+78],0
       jne       short M02_L02
       mov       r8,1F1FEFA3020
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.PropertiesToString02()
; 			PersonRecord person = RandomData.GeneratePersonRecordCollection(count: 1, addressCount: 1).First();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(person.PropertiesToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFF0],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,1
       mov       edx,1
       mov       r8d,0F
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       lea       r8,[rbp+0FFF0]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rcx,rax
       cmp       byte ptr [rbp+0FFF0],0
       je        short M00_L00
       mov       rsi,[rsi+18]
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       r9,1FDDBED38D8
       mov       r9,[r9]
       mov       rdx,1FDDBEC3020
       mov       rdx,[rdx]
       mov       r8d,3A
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 211
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0C8
       vzeroupper
       xor       eax,eax
       mov       [rsp+0B0],rax
       mov       [rsp+0B8],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+130]
       mov       r15d,[rsp+138]
       mov       r12d,[rsp+140]
       mov       r13d,[rsp+148]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     cl
       movzx     ecx,cl
       jmp       short M01_L01
M01_L00:
       xor       ecx,ecx
M01_L01:
       test      ecx,ecx
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFB475BF5F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,7FFB47374928
       mov       edx,22
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1FDDBEC2F38
       mov       rdx,[rdx]
       mov       rax,[rsp+48]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       mov       [rsp+70],rax
       xor       edx,edx
       mov       [rsp+0C4],edx
       test      esi,esi
       jle       near ptr M01_L04
M01_L03:
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
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       jo        near ptr M01_L05
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rdx,46DC5D638865
       cmp       rcx,rdx
       jg        near ptr M01_L06
       mov       rdx,0B923A29C779B
       cmp       rcx,rdx
       jl        near ptr M01_L06
       imul      rax,rcx,2710
       mov       [rsp+88],rax
       mov       rcx,[rsp+0B8]
       mov       edx,[rsp+0B0]
       movsx     rdx,dx
       movsxd    rdx,edx
       imul      rdx,3C
       mov       r8,0D6BF94D5E5
       cmp       rdx,r8
       jg        near ptr M01_L09
       mov       r8,0FF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,0FFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L09
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+90],xmm0
       lea       rcx,[rsp+90]
       call      System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFB472702C8
       call      qword ptr [7FFB476702C8]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFB472702D0
       call      qword ptr [7FFB476702D0]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFB472702D8
       call      qword ptr [7FFB476702D8]
       mov       edx,[rsp+0C4]
       add       edx,1
       jo        short M01_L05
       cmp       edx,esi
       mov       [rsp+0C4],edx
       jl        near ptr M01_L03
M01_L04:
       mov       rax,[rsp+70]
       add       rsp,0C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
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
M01_L07:
       call      System.DateTime.ThrowTicksOutOfRange()
       int       3
M01_L08:
       xor       ecx,ecx
       call      System.DateTime.ThrowDateArithmetic(Int32)
       int       3
M01_L09:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_TimeSpanTooLong()
       int       3
M01_L10:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 1156
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
       mov       rdx,7FFB477B5D28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB477B6258
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
       mov       rdx,7FFB477B5F18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       near ptr M02_L01
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFB477B6240
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M02_L02
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFB477B6270
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
       mov       r11,7FFB472705E8
       call      qword ptr [7FFB476A05E8]
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
       mov       rdx,7FFB477B6168
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M02_L15
M02_L18:
       mov       rcx,rsi
       mov       rdx,7FFB477B6048
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M02_L14
M02_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB472705F0
       call      qword ptr [7FFB476A05F0]
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
       mov       r11,7FFB472705F0
       call      qword ptr [7FFB476A05F0]
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
       mov       rax,1FDDBEC3020
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
       mov       r8,1FDEBEC2948
       mov       rdi,[r8]
       jmp       short M03_L02
M03_L01:
       cmp       byte ptr [rsp+78],0
       jne       short M03_L02
       mov       r8,1FDDBEC3020
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

