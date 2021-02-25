## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.CreatePerson01()
; 			var person = RandomData.GeneratePerson<Person>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(person);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       rsi,rcx
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       rcx,offset MD_dotNetTips.Spargine.Tester.RandomData.GeneratePerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 104
```
```assembly
; dotNetTips.Spargine.Tester.RandomData.GeneratePerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
; 			var person = new T
; 			^^
; 			{
; 			^^
; 				Id = RandomData.GenerateKey(),
; 			^^
; 				Address1 = RandomData.GenerateWord(addressLength),
; 			^^
; 				Address2 = RandomData.GenerateWord(addressLength),
; 			^^
; 				BornOn = DateTimeOffset.Now.Subtract(new TimeSpan(365 * GenerateInteger(1, 75), 0, 0, 0)),
; 			^^
; 				CellPhone = GeneratePhoneNumberUSA(),
; 			^^
; 				City = RandomData.GenerateWord(cityLength),
; 			^^
; 				Country = RandomData.GenerateWord(countryLength),
; 			^^
; 				Email = RandomData.GenerateEmailAddress(),
; 			^^
; 				FirstName = RandomData.GenerateWord(firstNameLength),
; 			^^
; 				HomePhone = GeneratePhoneNumberUSA(),
; 			^^
; 				LastName = RandomData.GenerateWord(lastNameLength),
; 			^^
; 				PostalCode = RandomData.GenerateNumber(postalCodeLength),
; 			^^
; 				State = RandomData.GenerateWord(stateLength)
; 			^^
; 			};
; 			^^
; 			return person;
; 			^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,98
       xor       eax,eax
       mov       [rsp+80],rax
       mov       [rsp+88],rax
       mov       [rsp+90],rcx
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
       mov       rdx,7FFB171EB870
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       rbp,rax
       lea       rcx,[rsp+58]
       call      System.Guid.NewGuid()
       vmovupd   xmm0,[rsp+58]
       vmovupd   [rsp+48],xmm0
       lea       rcx,[rsp+48]
       call      dotNetTips.Spargine.Extensions.GuidExtensions.ToDigits(System.Guid)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D604C8
       call      qword ptr [7FFB171804C8]
       mov       ecx,esi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D604D0
       call      qword ptr [7FFB171804D0]
       mov       ecx,esi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D604D8
       call      qword ptr [7FFB171804D8]
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+80]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       xor       ecx,ecx
       mov       [rsp+78],rcx
       mov       ecx,1
       mov       edx,4B
       call      dotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      edx,eax,16D
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       lea       rcx,[rsp+78]
       xor       r8d,r8d
       xor       r9d,r9d
       call      System.TimeSpan..ctor(Int32, Int32, Int32, Int32, Int32)
       lea       rcx,[rsp+80]
       lea       rdx,[rsp+68]
       mov       r8,[rsp+78]
       call      System.DateTimeOffset.Subtract(System.TimeSpan)
       vmovupd   xmm0,[rsp+68]
       vmovupd   [rsp+38],xmm0
       mov       rcx,rbp
       lea       rdx,[rsp+38]
       mov       r11,7FFB16D604E0
       call      qword ptr [7FFB171804E0]
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D604E8
       call      qword ptr [7FFB171804E8]
       mov       ecx,edi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D604F0
       call      qword ptr [7FFB171804F0]
       mov       ecx,ebx
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D604F8
       call      qword ptr [7FFB171804F8]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D60500
       call      qword ptr [7FFB17180500]
       mov       ecx,[rsp+0E0]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D60508
       call      qword ptr [7FFB17180508]
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D60510
       call      qword ptr [7FFB17180510]
       mov       ecx,[rsp+0E8]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D60518
       call      qword ptr [7FFB17180518]
       mov       ecx,[rsp+0F0]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D60520
       call      qword ptr [7FFB17180520]
       mov       ecx,[rsp+0F8]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D60528
       call      qword ptr [7FFB17180528]
       mov       rax,rbp
       add       rsp,98
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 634
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.CreatePerson02()
; 			var person = RandomData.GeneratePerson<PersonFixed>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(person);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       rsi,rcx
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       rcx,offset MD_dotNetTips.Spargine.Tester.RandomData.GeneratePerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 104
```
```assembly
; dotNetTips.Spargine.Tester.RandomData.GeneratePerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
; 			var person = new T
; 			^^
; 			{
; 			^^
; 				Id = RandomData.GenerateKey(),
; 			^^
; 				Address1 = RandomData.GenerateWord(addressLength),
; 			^^
; 				Address2 = RandomData.GenerateWord(addressLength),
; 			^^
; 				BornOn = DateTimeOffset.Now.Subtract(new TimeSpan(365 * GenerateInteger(1, 75), 0, 0, 0)),
; 			^^
; 				CellPhone = GeneratePhoneNumberUSA(),
; 			^^
; 				City = RandomData.GenerateWord(cityLength),
; 			^^
; 				Country = RandomData.GenerateWord(countryLength),
; 			^^
; 				Email = RandomData.GenerateEmailAddress(),
; 			^^
; 				FirstName = RandomData.GenerateWord(firstNameLength),
; 			^^
; 				HomePhone = GeneratePhoneNumberUSA(),
; 			^^
; 				LastName = RandomData.GenerateWord(lastNameLength),
; 			^^
; 				PostalCode = RandomData.GenerateNumber(postalCodeLength),
; 			^^
; 				State = RandomData.GenerateWord(stateLength)
; 			^^
; 			};
; 			^^
; 			return person;
; 			^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,98
       xor       eax,eax
       mov       [rsp+80],rax
       mov       [rsp+88],rax
       mov       [rsp+90],rcx
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
       mov       rdx,7FFB171CB870
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       rbp,rax
       lea       rcx,[rsp+58]
       call      System.Guid.NewGuid()
       vmovupd   xmm0,[rsp+58]
       vmovupd   [rsp+48],xmm0
       lea       rcx,[rsp+48]
       call      dotNetTips.Spargine.Extensions.GuidExtensions.ToDigits(System.Guid)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D404C8
       call      qword ptr [7FFB171604C8]
       mov       ecx,esi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D404D0
       call      qword ptr [7FFB171604D0]
       mov       ecx,esi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D404D8
       call      qword ptr [7FFB171604D8]
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+80]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       xor       ecx,ecx
       mov       [rsp+78],rcx
       mov       ecx,1
       mov       edx,4B
       call      dotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      edx,eax,16D
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       lea       rcx,[rsp+78]
       xor       r8d,r8d
       xor       r9d,r9d
       call      System.TimeSpan..ctor(Int32, Int32, Int32, Int32, Int32)
       lea       rcx,[rsp+80]
       lea       rdx,[rsp+68]
       mov       r8,[rsp+78]
       call      System.DateTimeOffset.Subtract(System.TimeSpan)
       vmovupd   xmm0,[rsp+68]
       vmovupd   [rsp+38],xmm0
       mov       rcx,rbp
       lea       rdx,[rsp+38]
       mov       r11,7FFB16D404E0
       call      qword ptr [7FFB171604E0]
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D404E8
       call      qword ptr [7FFB171604E8]
       mov       ecx,edi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D404F0
       call      qword ptr [7FFB171604F0]
       mov       ecx,ebx
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D404F8
       call      qword ptr [7FFB171604F8]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D40500
       call      qword ptr [7FFB17160500]
       mov       ecx,[rsp+0E0]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D40508
       call      qword ptr [7FFB17160508]
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D40510
       call      qword ptr [7FFB17160510]
       mov       ecx,[rsp+0E8]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D40518
       call      qword ptr [7FFB17160518]
       mov       ecx,[rsp+0F0]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D40520
       call      qword ptr [7FFB17160520]
       mov       ecx,[rsp+0F8]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D40528
       call      qword ptr [7FFB17160528]
       mov       rax,rbp
       add       rsp,98
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 634
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.CreatePerson03()
; 			var person = RandomData.GeneratePerson<PersonPlus>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(person);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       rsi,rcx
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       rcx,offset MD_dotNetTips.Spargine.Tester.RandomData.GeneratePerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 104
```
```assembly
; dotNetTips.Spargine.Tester.RandomData.GeneratePerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
; 			var person = new T
; 			^^
; 			{
; 			^^
; 				Id = RandomData.GenerateKey(),
; 			^^
; 				Address1 = RandomData.GenerateWord(addressLength),
; 			^^
; 				Address2 = RandomData.GenerateWord(addressLength),
; 			^^
; 				BornOn = DateTimeOffset.Now.Subtract(new TimeSpan(365 * GenerateInteger(1, 75), 0, 0, 0)),
; 			^^
; 				CellPhone = GeneratePhoneNumberUSA(),
; 			^^
; 				City = RandomData.GenerateWord(cityLength),
; 			^^
; 				Country = RandomData.GenerateWord(countryLength),
; 			^^
; 				Email = RandomData.GenerateEmailAddress(),
; 			^^
; 				FirstName = RandomData.GenerateWord(firstNameLength),
; 			^^
; 				HomePhone = GeneratePhoneNumberUSA(),
; 			^^
; 				LastName = RandomData.GenerateWord(lastNameLength),
; 			^^
; 				PostalCode = RandomData.GenerateNumber(postalCodeLength),
; 			^^
; 				State = RandomData.GenerateWord(stateLength)
; 			^^
; 			};
; 			^^
; 			return person;
; 			^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,98
       xor       eax,eax
       mov       [rsp+80],rax
       mov       [rsp+88],rax
       mov       [rsp+90],rcx
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
       mov       rdx,7FFB171AB870
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       rbp,rax
       lea       rcx,[rsp+58]
       call      System.Guid.NewGuid()
       vmovupd   xmm0,[rsp+58]
       vmovupd   [rsp+48],xmm0
       lea       rcx,[rsp+48]
       call      dotNetTips.Spargine.Extensions.GuidExtensions.ToDigits(System.Guid)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D204C8
       call      qword ptr [7FFB171404C8]
       mov       ecx,esi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D204D0
       call      qword ptr [7FFB171404D0]
       mov       ecx,esi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D204D8
       call      qword ptr [7FFB171404D8]
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+80]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       xor       ecx,ecx
       mov       [rsp+78],rcx
       mov       ecx,1
       mov       edx,4B
       call      dotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      edx,eax,16D
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       lea       rcx,[rsp+78]
       xor       r8d,r8d
       xor       r9d,r9d
       call      System.TimeSpan..ctor(Int32, Int32, Int32, Int32, Int32)
       lea       rcx,[rsp+80]
       lea       rdx,[rsp+68]
       mov       r8,[rsp+78]
       call      System.DateTimeOffset.Subtract(System.TimeSpan)
       vmovupd   xmm0,[rsp+68]
       vmovupd   [rsp+38],xmm0
       mov       rcx,rbp
       lea       rdx,[rsp+38]
       mov       r11,7FFB16D204E0
       call      qword ptr [7FFB171404E0]
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D204E8
       call      qword ptr [7FFB171404E8]
       mov       ecx,edi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D204F0
       call      qword ptr [7FFB171404F0]
       mov       ecx,ebx
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D204F8
       call      qword ptr [7FFB171404F8]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D20500
       call      qword ptr [7FFB17140500]
       mov       ecx,[rsp+0E0]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D20508
       call      qword ptr [7FFB17140508]
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D20510
       call      qword ptr [7FFB17140510]
       mov       ecx,[rsp+0E8]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D20518
       call      qword ptr [7FFB17140518]
       mov       ecx,[rsp+0F0]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D20520
       call      qword ptr [7FFB17140520]
       mov       ecx,[rsp+0F8]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D20528
       call      qword ptr [7FFB17140528]
       mov       rax,rbp
       add       rsp,98
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 634
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.CreatePerson04()
; 			var person = RandomData.GeneratePerson<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(person);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       rsi,rcx
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       rcx,offset MD_dotNetTips.Spargine.Tester.RandomData.GeneratePerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 104
```
```assembly
; dotNetTips.Spargine.Tester.RandomData.GeneratePerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
; 			var person = new T
; 			^^
; 			{
; 			^^
; 				Id = RandomData.GenerateKey(),
; 			^^
; 				Address1 = RandomData.GenerateWord(addressLength),
; 			^^
; 				Address2 = RandomData.GenerateWord(addressLength),
; 			^^
; 				BornOn = DateTimeOffset.Now.Subtract(new TimeSpan(365 * GenerateInteger(1, 75), 0, 0, 0)),
; 			^^
; 				CellPhone = GeneratePhoneNumberUSA(),
; 			^^
; 				City = RandomData.GenerateWord(cityLength),
; 			^^
; 				Country = RandomData.GenerateWord(countryLength),
; 			^^
; 				Email = RandomData.GenerateEmailAddress(),
; 			^^
; 				FirstName = RandomData.GenerateWord(firstNameLength),
; 			^^
; 				HomePhone = GeneratePhoneNumberUSA(),
; 			^^
; 				LastName = RandomData.GenerateWord(lastNameLength),
; 			^^
; 				PostalCode = RandomData.GenerateNumber(postalCodeLength),
; 			^^
; 				State = RandomData.GenerateWord(stateLength)
; 			^^
; 			};
; 			^^
; 			return person;
; 			^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,98
       xor       eax,eax
       mov       [rsp+80],rax
       mov       [rsp+88],rax
       mov       [rsp+90],rcx
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
       mov       rdx,7FFB171BB870
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       rbp,rax
       lea       rcx,[rsp+58]
       call      System.Guid.NewGuid()
       vmovupd   xmm0,[rsp+58]
       vmovupd   [rsp+48],xmm0
       lea       rcx,[rsp+48]
       call      dotNetTips.Spargine.Extensions.GuidExtensions.ToDigits(System.Guid)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D304C8
       call      qword ptr [7FFB171504C8]
       mov       ecx,esi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D304D0
       call      qword ptr [7FFB171504D0]
       mov       ecx,esi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D304D8
       call      qword ptr [7FFB171504D8]
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+80]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       xor       ecx,ecx
       mov       [rsp+78],rcx
       mov       ecx,1
       mov       edx,4B
       call      dotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      edx,eax,16D
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       lea       rcx,[rsp+78]
       xor       r8d,r8d
       xor       r9d,r9d
       call      System.TimeSpan..ctor(Int32, Int32, Int32, Int32, Int32)
       lea       rcx,[rsp+80]
       lea       rdx,[rsp+68]
       mov       r8,[rsp+78]
       call      System.DateTimeOffset.Subtract(System.TimeSpan)
       vmovupd   xmm0,[rsp+68]
       vmovupd   [rsp+38],xmm0
       mov       rcx,rbp
       lea       rdx,[rsp+38]
       mov       r11,7FFB16D304E0
       call      qword ptr [7FFB171504E0]
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D304E8
       call      qword ptr [7FFB171504E8]
       mov       ecx,edi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D304F0
       call      qword ptr [7FFB171504F0]
       mov       ecx,ebx
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D304F8
       call      qword ptr [7FFB171504F8]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D30500
       call      qword ptr [7FFB17150500]
       mov       ecx,[rsp+0E0]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D30508
       call      qword ptr [7FFB17150508]
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D30510
       call      qword ptr [7FFB17150510]
       mov       ecx,[rsp+0E8]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D30518
       call      qword ptr [7FFB17150518]
       mov       ecx,[rsp+0F0]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D30520
       call      qword ptr [7FFB17150520]
       mov       ecx,[rsp+0F8]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D30528
       call      qword ptr [7FFB17150528]
       mov       rax,rbp
       add       rsp,98
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 634
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.CreatePerson05()
; 			var person = RandomData.GeneratePersonCollection(count: 1, addressCount: 1).First();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(person);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
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
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePersonCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.First(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.First[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; dotNetTips.Spargine.Tester.RandomData.GeneratePersonCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0D8
       vzeroupper
       xor       eax,eax
       mov       [rsp+98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+0A0],xmm4
       vmovdqa   xmmword ptr [rsp+0B0],xmm4
       vmovdqa   xmmword ptr [rsp+0C0],xmm4
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+140]
       mov       r15d,[rsp+148]
       mov       r12d,[rsp+150]
       mov       r13d,[rsp+158]
; 			var records = new List<PersonRecord>(count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonRecord, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rcx,rax
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
; 			for (var i = 0; i < count; i++)
; 			     ^^^^^^^^^
       mov       rax,[rsp+50]
       mov       [rsp+58],rax
       xor       edx,edx
       mov       [rsp+0D4],edx
       test      esi,esi
       jle       near ptr M01_L03
M01_L00:
       call      dotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+48],rax
       lea       rcx,[rsp+0A0]
       call      System.Guid.NewGuid()
       mov       rcx,offset MT_dotNetTips.Spargine.Tester.Models.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+70],xmm0
       lea       rcx,[rsp+70]
       call      dotNetTips.Spargine.Extensions.GuidExtensions.ToDigits(System.Guid)
       mov       [rsp+38],rax
       mov       rcx,[rsp+40]
       mov       rdx,[rsp+48]
       call      dotNetTips.Spargine.Tester.Models.PersonRecord.set_Email(System.String)
       mov       rcx,[rsp+40]
       mov       rdx,[rsp+38]
       call      qword ptr [7FFB17136AF0]
; 				PersonRecord person = new(RandomData.GenerateEmailAddress(), RandomData.GenerateKey())
; 				^^
; 				{
; 				^^
; 					BornOn = DateTimeOffset.Now.Subtract(new TimeSpan(365 * GenerateInteger(1, 75), 0, 0, 0)),
; 				^^
; 					FirstName = RandomData.GenerateWord(firstNameLength),
; 				^^
; 					HomePhone = GeneratePhoneNumberUSA(),
; 				^^
; 					LastName = RandomData.GenerateWord(lastNameLength),
; 				^^
; 					CellPhone = GeneratePhoneNumberUSA(),
; 				^^
; 					Addresses = GenerateAddresses(addressCount, addressLength, cityLength, countryLength, countyProvinceLength, postalCodeLength, stateLength),
; 				^^
; 				};
; 				^^
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0C0]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      dotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rax,46DC5D638865
       cmp       rcx,rax
       jg        near ptr M01_L05
       mov       rax,0B923A29C779B
       cmp       rcx,rax
       jl        near ptr M01_L05
       imul      rax,rcx,2710
       mov       [rsp+80],rax
       lea       rcx,[rsp+0C0]
       call      System.DateTimeOffset.get_ClockDateTime()
       mov       [rsp+98],rax
       lea       rcx,[rsp+98]
       mov       rdx,[rsp+80]
       call      System.DateTime.Subtract(System.TimeSpan)
       mov       rdx,rax
       mov       ecx,[rsp+0C0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L06
       mov       r8,0FF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L06
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+88],xmm0
       lea       rcx,[rsp+88]
       call      System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+88]
       vmovupd   [rsp+0B0],xmm0
       vmovupd   xmm0,[rsp+0B0]
       vmovupd   [rsp+60],xmm0
       mov       rcx,[rsp+40]
       lea       rdx,[rsp+60]
       call      dotNetTips.Spargine.Tester.Models.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      dotNetTips.Spargine.Tester.Models.PersonRecord.set_FirstName(System.String)
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      dotNetTips.Spargine.Tester.Models.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      dotNetTips.Spargine.Tester.Models.PersonRecord.set_LastName(System.String)
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      dotNetTips.Spargine.Tester.Models.PersonRecord.set_CellPhone(System.String)
; 				records.Add(person);
; 				^^^^^^^^^^^^^^^^^^^^
       mov       [rsp+20],r13d
       mov       eax,[rsp+160]
       mov       [rsp+28],eax
       mov       r10d,[rsp+168]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      dotNetTips.Spargine.Tester.RandomData.GenerateAddresses(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsp+40]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsp+40]
       mov       r8,rcx
       mov       rax,[rsp+58]
       inc       dword ptr [rax+14]
       mov       rcx,[rax+8]
       mov       edx,[rax+10]
       cmp       [rcx+8],edx
       jbe       short M01_L01
       lea       r9d,[rdx+1]
       mov       [rsp+58],rax
       mov       [rax+10],r9d
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L02
M01_L01:
       mov       [rsp+58],rax
       mov       rcx,rax
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L02:
       mov       edx,[rsp+0D4]
       inc       edx
       cmp       edx,esi
       mov       [rsp+0D4],edx
       jl        near ptr M01_L00
; 			records.TrimExcess();
; 			^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       rsi,[rsp+58]
       mov       rdx,[rsi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB1712DBA8]
       vcvttsd2si edx,xmm0
       cmp       [rsi+10],edx
       jge       short M01_L04
       mov       edx,[rsi+10]
       mov       rcx,rsi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
; 			return records;
; 			^^^^^^^^^^^^^^^
M01_L04:
       mov       rax,rsi
       add       rsp,0D8
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
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      System.SR.get_Overflow_TimeSpanTooLong()
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       xor       ecx,ecx
       mov       [rsi+78],rcx
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_TimeSpanTooLong()
       int       3
; Total bytes of code 959
```
```assembly
; System.Linq.Enumerable.First[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB17200CE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       lea       r8,[rsp+20]
       mov       rcx,rdx
       mov       rdx,rsi
       call      System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M02_L02
       add       rsp,30
       pop       rsi
       ret
M02_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 81
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.PropertiesToString01()
; 			var person = RandomData.GeneratePerson<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(person.PropertiesToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       rsi,rcx
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       rcx,offset MD_dotNetTips.Spargine.Tester.RandomData.GeneratePerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,rax
       mov       rsi,[rsi+10]
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       r9,221D97412C8
       mov       r9,[r9]
       mov       rdx,221E9741048
       mov       rdx,[rdx]
       mov       r8d,3A
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 160
```
```assembly
; dotNetTips.Spargine.Tester.RandomData.GeneratePerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
; 			var person = new T
; 			^^
; 			{
; 			^^
; 				Id = RandomData.GenerateKey(),
; 			^^
; 				Address1 = RandomData.GenerateWord(addressLength),
; 			^^
; 				Address2 = RandomData.GenerateWord(addressLength),
; 			^^
; 				BornOn = DateTimeOffset.Now.Subtract(new TimeSpan(365 * GenerateInteger(1, 75), 0, 0, 0)),
; 			^^
; 				CellPhone = GeneratePhoneNumberUSA(),
; 			^^
; 				City = RandomData.GenerateWord(cityLength),
; 			^^
; 				Country = RandomData.GenerateWord(countryLength),
; 			^^
; 				Email = RandomData.GenerateEmailAddress(),
; 			^^
; 				FirstName = RandomData.GenerateWord(firstNameLength),
; 			^^
; 				HomePhone = GeneratePhoneNumberUSA(),
; 			^^
; 				LastName = RandomData.GenerateWord(lastNameLength),
; 			^^
; 				PostalCode = RandomData.GenerateNumber(postalCodeLength),
; 			^^
; 				State = RandomData.GenerateWord(stateLength)
; 			^^
; 			};
; 			^^
; 			return person;
; 			^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,98
       xor       eax,eax
       mov       [rsp+80],rax
       mov       [rsp+88],rax
       mov       [rsp+90],rcx
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
       mov       rdx,7FFB171DB870
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       rbp,rax
       lea       rcx,[rsp+58]
       call      System.Guid.NewGuid()
       vmovupd   xmm0,[rsp+58]
       vmovupd   [rsp+48],xmm0
       lea       rcx,[rsp+48]
       call      dotNetTips.Spargine.Extensions.GuidExtensions.ToDigits(System.Guid)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D50630
       call      qword ptr [7FFB17180630]
       mov       ecx,esi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D50638
       call      qword ptr [7FFB17180638]
       mov       ecx,esi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D50640
       call      qword ptr [7FFB17180640]
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+80]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       xor       ecx,ecx
       mov       [rsp+78],rcx
       mov       ecx,1
       mov       edx,4B
       call      dotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      edx,eax,16D
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       lea       rcx,[rsp+78]
       xor       r8d,r8d
       xor       r9d,r9d
       call      System.TimeSpan..ctor(Int32, Int32, Int32, Int32, Int32)
       lea       rcx,[rsp+80]
       lea       rdx,[rsp+68]
       mov       r8,[rsp+78]
       call      System.DateTimeOffset.Subtract(System.TimeSpan)
       vmovupd   xmm0,[rsp+68]
       vmovupd   [rsp+38],xmm0
       mov       rcx,rbp
       lea       rdx,[rsp+38]
       mov       r11,7FFB16D50648
       call      qword ptr [7FFB17180648]
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D50650
       call      qword ptr [7FFB17180650]
       mov       ecx,edi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D50658
       call      qword ptr [7FFB17180658]
       mov       ecx,ebx
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D50660
       call      qword ptr [7FFB17180660]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D50668
       call      qword ptr [7FFB17180668]
       mov       ecx,[rsp+0E0]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D50670
       call      qword ptr [7FFB17180670]
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D50678
       call      qword ptr [7FFB17180678]
       mov       ecx,[rsp+0E8]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D50680
       call      qword ptr [7FFB17180680]
       mov       ecx,[rsp+0F0]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D50688
       call      qword ptr [7FFB17180688]
       mov       ecx,[rsp+0F8]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFB16D50690
       call      qword ptr [7FFB17180690]
       mov       rax,rbp
       add       rsp,98
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 634
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebp,r8d
       mov       rbx,r9
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+10],bp
       mov       r8,221E9741048
       mov       r8,[r8]
       mov       rdx,222097410E0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,221E9741048
       mov       r8,[r8]
       mov       rdx,222097410E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r14+8]
       mov       rdx,222097410F0
       mov       rdx,[rdx]
       mov       r8,221E9741048
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       call      00007FFB769A23C0
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.String.Equals(System.String, System.String)
       test      eax,eax
       je        short M02_L00
       mov       r8,222097410F8
       mov       rbx,[r8]
       jmp       short M02_L01
M02_L00:
       cmp       byte ptr [rsp+78],0
       jne       short M02_L01
       mov       r8,221E9741048
       mov       rbx,[r8]
M02_L01:
       mov       ebp,[rsp+70]
       movzx     r8d,bpl
       mov       rcx,rsi
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass10_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rbx+18],r9
       mov       r9,rbx
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate(System.Collections.Generic.IEnumerable`1<!!0>, !!1, System.Func`3<!!1,!!0,!!1>)
       call      System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       jne       short M02_L02
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L02:
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
; Total bytes of code 412
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.Tester.RandomDataBenchmark.PropertiesToString02()
; 			var person = RandomData.GeneratePersonCollection(count: 1, addressCount: 1).First();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(person.PropertiesToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
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
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePersonCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.First(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.First[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rax
       mov       rsi,[rsi+10]
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       r9,2A69C9A5730
       mov       r9,[r9]
       mov       rdx,2A69C9A3060
       mov       rdx,[rdx]
       mov       r8d,3A
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 189
```
```assembly
; dotNetTips.Spargine.Tester.RandomData.GeneratePersonCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0D8
       vzeroupper
       xor       eax,eax
       mov       [rsp+98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+0A0],xmm4
       vmovdqa   xmmword ptr [rsp+0B0],xmm4
       vmovdqa   xmmword ptr [rsp+0C0],xmm4
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+140]
       mov       r15d,[rsp+148]
       mov       r12d,[rsp+150]
       mov       r13d,[rsp+158]
; 			var records = new List<PersonRecord>(count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonRecord, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rcx,rax
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
; 			for (var i = 0; i < count; i++)
; 			     ^^^^^^^^^
       mov       rax,[rsp+50]
       mov       [rsp+58],rax
       xor       edx,edx
       mov       [rsp+0D4],edx
       test      esi,esi
       jle       near ptr M01_L03
M01_L00:
       call      dotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+48],rax
       lea       rcx,[rsp+0A0]
       call      System.Guid.NewGuid()
       mov       rcx,offset MT_dotNetTips.Spargine.Tester.Models.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+70],xmm0
       lea       rcx,[rsp+70]
       call      dotNetTips.Spargine.Extensions.GuidExtensions.ToDigits(System.Guid)
       mov       [rsp+38],rax
       mov       rcx,[rsp+40]
       mov       rdx,[rsp+48]
       call      dotNetTips.Spargine.Tester.Models.PersonRecord.set_Email(System.String)
       mov       rcx,[rsp+40]
       mov       rdx,[rsp+38]
       call      qword ptr [7FFB17166AF0]
; 				PersonRecord person = new(RandomData.GenerateEmailAddress(), RandomData.GenerateKey())
; 				^^
; 				{
; 				^^
; 					BornOn = DateTimeOffset.Now.Subtract(new TimeSpan(365 * GenerateInteger(1, 75), 0, 0, 0)),
; 				^^
; 					FirstName = RandomData.GenerateWord(firstNameLength),
; 				^^
; 					HomePhone = GeneratePhoneNumberUSA(),
; 				^^
; 					LastName = RandomData.GenerateWord(lastNameLength),
; 				^^
; 					CellPhone = GeneratePhoneNumberUSA(),
; 				^^
; 					Addresses = GenerateAddresses(addressCount, addressLength, cityLength, countryLength, countyProvinceLength, postalCodeLength, stateLength),
; 				^^
; 				};
; 				^^
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0C0]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      dotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rax,46DC5D638865
       cmp       rcx,rax
       jg        near ptr M01_L05
       mov       rax,0B923A29C779B
       cmp       rcx,rax
       jl        near ptr M01_L05
       imul      rax,rcx,2710
       mov       [rsp+80],rax
       lea       rcx,[rsp+0C0]
       call      System.DateTimeOffset.get_ClockDateTime()
       mov       [rsp+98],rax
       lea       rcx,[rsp+98]
       mov       rdx,[rsp+80]
       call      System.DateTime.Subtract(System.TimeSpan)
       mov       rdx,rax
       mov       ecx,[rsp+0C0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L06
       mov       r8,0FF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L06
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+88],xmm0
       lea       rcx,[rsp+88]
       call      System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+88]
       vmovupd   [rsp+0B0],xmm0
       vmovupd   xmm0,[rsp+0B0]
       vmovupd   [rsp+60],xmm0
       mov       rcx,[rsp+40]
       lea       rdx,[rsp+60]
       call      dotNetTips.Spargine.Tester.Models.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      dotNetTips.Spargine.Tester.Models.PersonRecord.set_FirstName(System.String)
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      dotNetTips.Spargine.Tester.Models.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      dotNetTips.Spargine.Tester.Models.PersonRecord.set_LastName(System.String)
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      dotNetTips.Spargine.Tester.Models.PersonRecord.set_CellPhone(System.String)
; 				records.Add(person);
; 				^^^^^^^^^^^^^^^^^^^^
       mov       [rsp+20],r13d
       mov       eax,[rsp+160]
       mov       [rsp+28],eax
       mov       r10d,[rsp+168]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      dotNetTips.Spargine.Tester.RandomData.GenerateAddresses(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsp+40]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsp+40]
       mov       r8,rcx
       mov       rax,[rsp+58]
       inc       dword ptr [rax+14]
       mov       rcx,[rax+8]
       mov       edx,[rax+10]
       cmp       [rcx+8],edx
       jbe       short M01_L01
       lea       r9d,[rdx+1]
       mov       [rsp+58],rax
       mov       [rax+10],r9d
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L02
M01_L01:
       mov       [rsp+58],rax
       mov       rcx,rax
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L02:
       mov       edx,[rsp+0D4]
       inc       edx
       cmp       edx,esi
       mov       [rsp+0D4],edx
       jl        near ptr M01_L00
; 			records.TrimExcess();
; 			^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       rsi,[rsp+58]
       mov       rdx,[rsi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB1715DBA8]
       vcvttsd2si edx,xmm0
       cmp       [rsi+10],edx
       jge       short M01_L04
       mov       edx,[rsi+10]
       mov       rcx,rsi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
; 			return records;
; 			^^^^^^^^^^^^^^^
M01_L04:
       mov       rax,rsi
       add       rsp,0D8
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
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      System.SR.get_Overflow_TimeSpanTooLong()
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       xor       ecx,ecx
       mov       [rsi+78],rcx
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_TimeSpanTooLong()
       int       3
; Total bytes of code 959
```
```assembly
; System.Linq.Enumerable.First[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB17251450
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L01:
       lea       r8,[rsp+20]
       mov       rcx,rdx
       mov       rdx,rsi
       call      System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       cmp       byte ptr [rsp+20],0
       je        short M02_L02
       add       rsp,30
       pop       rsi
       ret
M02_L02:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 81
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebp,r8d
       mov       rbx,r9
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+10],bp
       mov       r8,2A69C9A3060
       mov       r8,[r8]
       mov       rdx,2A6AC9A10E0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,2A69C9A3060
       mov       r8,[r8]
       mov       rdx,2A6AC9A10E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r14+8]
       mov       rdx,2A6AC9A10F0
       mov       rdx,[rdx]
       mov       r8,2A69C9A3060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       call      00007FFB769A23C0
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.String.Equals(System.String, System.String)
       test      eax,eax
       je        short M03_L00
       mov       r8,2A6AC9A10F8
       mov       rbx,[r8]
       jmp       short M03_L01
M03_L00:
       cmp       byte ptr [rsp+78],0
       jne       short M03_L01
       mov       r8,2A69C9A3060
       mov       rbx,[r8]
M03_L01:
       mov       ebp,[rsp+70]
       movzx     r8d,bpl
       mov       rcx,rsi
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass10_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rbx+18],r9
       mov       r9,rbx
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate(System.Collections.Generic.IEnumerable`1<!!0>, !!1, System.Func`3<!!1,!!0,!!1>)
       call      System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       jne       short M03_L02
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L02:
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
; Total bytes of code 412
```

