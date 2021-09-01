## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
; 			^^^^^^^^^^^^^^^^^^
; 			{
; 			 
; 				Id = GenerateKey(),
; 				                   
; 				Address1 = GenerateWord(addressLength),
; 				                                       
; 				Address2 = GenerateWord(addressLength),
; 				                                       
; 				BornOn = DateTimeOffset.Now.Subtract(new TimeSpan(365 * GenerateInteger(1, 75), 0, 0, 0)),
; 				                                                                                          
; 				CellPhone = GeneratePhoneNumberUSA(),
; 				                                     
; 				City = GenerateWord(cityLength),
; 				                                
; 				Country = GenerateWord(countryLength),
; 				                                      
; 				Email = GenerateEmailAddress(),
; 				                               
; 				FirstName = GenerateWord(firstNameLength),
; 				                                          
; 				HomePhone = GeneratePhoneNumberUSA(),
; 				                                     
; 				LastName = GenerateWord(lastNameLength),
; 				                                        
; 				PostalCode = GenerateNumber(postalCodeLength),
; 				                                              
; 				State = GenerateWord(stateLength)
; 				                                 
; 			};
; 			  
; 			return person;
; 			^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+60],rax
       mov       [rsp+68],rax
       mov       [rsp+70],rcx
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
       mov       rdx,7FF7AD2CFB88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       rbp,rax
       call      dotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE60468
       call      qword ptr [7FF7AD270468]
       mov       ecx,esi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE60470
       call      qword ptr [7FF7AD270470]
       mov       ecx,esi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE60478
       call      qword ptr [7FF7AD270478]
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+60]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       xor       ecx,ecx
       mov       [rsp+58],rcx
       mov       ecx,1
       mov       edx,4B
       call      dotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      edx,eax,16D
       jo        near ptr M01_L02
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       lea       rcx,[rsp+58]
       xor       r8d,r8d
       xor       r9d,r9d
       call      System.TimeSpan..ctor(Int32, Int32, Int32, Int32, Int32)
       lea       rcx,[rsp+60]
       lea       rdx,[rsp+48]
       mov       r8,[rsp+58]
       call      System.DateTimeOffset.Subtract(System.TimeSpan)
       vmovupd   xmm0,[rsp+48]
       vmovupd   [rsp+38],xmm0
       mov       rcx,rbp
       lea       rdx,[rsp+38]
       mov       r11,7FF7ACE60480
       call      qword ptr [7FF7AD270480]
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE60488
       call      qword ptr [7FF7AD270488]
       mov       ecx,edi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE60490
       call      qword ptr [7FF7AD270490]
       mov       ecx,ebx
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE60498
       call      qword ptr [7FF7AD270498]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE604A0
       call      qword ptr [7FF7AD2704A0]
       mov       ecx,[rsp+0C0]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE604A8
       call      qword ptr [7FF7AD2704A8]
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE604B0
       call      qword ptr [7FF7AD2704B0]
       mov       ecx,[rsp+0C8]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE604B8
       call      qword ptr [7FF7AD2704B8]
       mov       ecx,[rsp+0D0]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE604C0
       call      qword ptr [7FF7AD2704C0]
       mov       ecx,[rsp+0D8]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE604C8
       call      qword ptr [7FF7AD2704C8]
       mov       rax,rbp
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 598
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
; 			^^^^^^^^^^^^^^^^^^
; 			{
; 			 
; 				Id = GenerateKey(),
; 				                   
; 				Address1 = GenerateWord(addressLength),
; 				                                       
; 				Address2 = GenerateWord(addressLength),
; 				                                       
; 				BornOn = DateTimeOffset.Now.Subtract(new TimeSpan(365 * GenerateInteger(1, 75), 0, 0, 0)),
; 				                                                                                          
; 				CellPhone = GeneratePhoneNumberUSA(),
; 				                                     
; 				City = GenerateWord(cityLength),
; 				                                
; 				Country = GenerateWord(countryLength),
; 				                                      
; 				Email = GenerateEmailAddress(),
; 				                               
; 				FirstName = GenerateWord(firstNameLength),
; 				                                          
; 				HomePhone = GeneratePhoneNumberUSA(),
; 				                                     
; 				LastName = GenerateWord(lastNameLength),
; 				                                        
; 				PostalCode = GenerateNumber(postalCodeLength),
; 				                                              
; 				State = GenerateWord(stateLength)
; 				                                 
; 			};
; 			  
; 			return person;
; 			^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+60],rax
       mov       [rsp+68],rax
       mov       [rsp+70],rcx
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
       mov       rdx,7FF7AD2FFB88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       rbp,rax
       call      dotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE90468
       call      qword ptr [7FF7AD2A0468]
       mov       ecx,esi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE90470
       call      qword ptr [7FF7AD2A0470]
       mov       ecx,esi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE90478
       call      qword ptr [7FF7AD2A0478]
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+60]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       xor       ecx,ecx
       mov       [rsp+58],rcx
       mov       ecx,1
       mov       edx,4B
       call      dotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      edx,eax,16D
       jo        near ptr M01_L02
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       lea       rcx,[rsp+58]
       xor       r8d,r8d
       xor       r9d,r9d
       call      System.TimeSpan..ctor(Int32, Int32, Int32, Int32, Int32)
       lea       rcx,[rsp+60]
       lea       rdx,[rsp+48]
       mov       r8,[rsp+58]
       call      System.DateTimeOffset.Subtract(System.TimeSpan)
       vmovupd   xmm0,[rsp+48]
       vmovupd   [rsp+38],xmm0
       mov       rcx,rbp
       lea       rdx,[rsp+38]
       mov       r11,7FF7ACE90480
       call      qword ptr [7FF7AD2A0480]
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE90488
       call      qword ptr [7FF7AD2A0488]
       mov       ecx,edi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE90490
       call      qword ptr [7FF7AD2A0490]
       mov       ecx,ebx
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE90498
       call      qword ptr [7FF7AD2A0498]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE904A0
       call      qword ptr [7FF7AD2A04A0]
       mov       ecx,[rsp+0C0]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE904A8
       call      qword ptr [7FF7AD2A04A8]
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE904B0
       call      qword ptr [7FF7AD2A04B0]
       mov       ecx,[rsp+0C8]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE904B8
       call      qword ptr [7FF7AD2A04B8]
       mov       ecx,[rsp+0D0]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE904C0
       call      qword ptr [7FF7AD2A04C0]
       mov       ecx,[rsp+0D8]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE904C8
       call      qword ptr [7FF7AD2A04C8]
       mov       rax,rbp
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 598
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
; 			^^^^^^^^^^^^^^^^^^
; 			{
; 			 
; 				Id = GenerateKey(),
; 				                   
; 				Address1 = GenerateWord(addressLength),
; 				                                       
; 				Address2 = GenerateWord(addressLength),
; 				                                       
; 				BornOn = DateTimeOffset.Now.Subtract(new TimeSpan(365 * GenerateInteger(1, 75), 0, 0, 0)),
; 				                                                                                          
; 				CellPhone = GeneratePhoneNumberUSA(),
; 				                                     
; 				City = GenerateWord(cityLength),
; 				                                
; 				Country = GenerateWord(countryLength),
; 				                                      
; 				Email = GenerateEmailAddress(),
; 				                               
; 				FirstName = GenerateWord(firstNameLength),
; 				                                          
; 				HomePhone = GeneratePhoneNumberUSA(),
; 				                                     
; 				LastName = GenerateWord(lastNameLength),
; 				                                        
; 				PostalCode = GenerateNumber(postalCodeLength),
; 				                                              
; 				State = GenerateWord(stateLength)
; 				                                 
; 			};
; 			  
; 			return person;
; 			^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+60],rax
       mov       [rsp+68],rax
       mov       [rsp+70],rcx
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
       mov       rdx,7FF7AD2FFB88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       rbp,rax
       call      dotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE90468
       call      qword ptr [7FF7AD2A0468]
       mov       ecx,esi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE90470
       call      qword ptr [7FF7AD2A0470]
       mov       ecx,esi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE90478
       call      qword ptr [7FF7AD2A0478]
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+60]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       xor       ecx,ecx
       mov       [rsp+58],rcx
       mov       ecx,1
       mov       edx,4B
       call      dotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      edx,eax,16D
       jo        near ptr M01_L02
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       lea       rcx,[rsp+58]
       xor       r8d,r8d
       xor       r9d,r9d
       call      System.TimeSpan..ctor(Int32, Int32, Int32, Int32, Int32)
       lea       rcx,[rsp+60]
       lea       rdx,[rsp+48]
       mov       r8,[rsp+58]
       call      System.DateTimeOffset.Subtract(System.TimeSpan)
       vmovupd   xmm0,[rsp+48]
       vmovupd   [rsp+38],xmm0
       mov       rcx,rbp
       lea       rdx,[rsp+38]
       mov       r11,7FF7ACE90480
       call      qword ptr [7FF7AD2A0480]
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE90488
       call      qword ptr [7FF7AD2A0488]
       mov       ecx,edi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE90490
       call      qword ptr [7FF7AD2A0490]
       mov       ecx,ebx
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE90498
       call      qword ptr [7FF7AD2A0498]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE904A0
       call      qword ptr [7FF7AD2A04A0]
       mov       ecx,[rsp+0C0]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE904A8
       call      qword ptr [7FF7AD2A04A8]
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE904B0
       call      qword ptr [7FF7AD2A04B0]
       mov       ecx,[rsp+0C8]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE904B8
       call      qword ptr [7FF7AD2A04B8]
       mov       ecx,[rsp+0D0]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE904C0
       call      qword ptr [7FF7AD2A04C0]
       mov       ecx,[rsp+0D8]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE904C8
       call      qword ptr [7FF7AD2A04C8]
       mov       rax,rbp
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 598
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
; 			^^^^^^^^^^^^^^^^^^
; 			{
; 			 
; 				Id = GenerateKey(),
; 				                   
; 				Address1 = GenerateWord(addressLength),
; 				                                       
; 				Address2 = GenerateWord(addressLength),
; 				                                       
; 				BornOn = DateTimeOffset.Now.Subtract(new TimeSpan(365 * GenerateInteger(1, 75), 0, 0, 0)),
; 				                                                                                          
; 				CellPhone = GeneratePhoneNumberUSA(),
; 				                                     
; 				City = GenerateWord(cityLength),
; 				                                
; 				Country = GenerateWord(countryLength),
; 				                                      
; 				Email = GenerateEmailAddress(),
; 				                               
; 				FirstName = GenerateWord(firstNameLength),
; 				                                          
; 				HomePhone = GeneratePhoneNumberUSA(),
; 				                                     
; 				LastName = GenerateWord(lastNameLength),
; 				                                        
; 				PostalCode = GenerateNumber(postalCodeLength),
; 				                                              
; 				State = GenerateWord(stateLength)
; 				                                 
; 			};
; 			  
; 			return person;
; 			^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+60],rax
       mov       [rsp+68],rax
       mov       [rsp+70],rcx
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
       mov       rdx,7FF7AD2DFB88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       rbp,rax
       call      dotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE70468
       call      qword ptr [7FF7AD280468]
       mov       ecx,esi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE70470
       call      qword ptr [7FF7AD280470]
       mov       ecx,esi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE70478
       call      qword ptr [7FF7AD280478]
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+60]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       xor       ecx,ecx
       mov       [rsp+58],rcx
       mov       ecx,1
       mov       edx,4B
       call      dotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      edx,eax,16D
       jo        near ptr M01_L02
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       lea       rcx,[rsp+58]
       xor       r8d,r8d
       xor       r9d,r9d
       call      System.TimeSpan..ctor(Int32, Int32, Int32, Int32, Int32)
       lea       rcx,[rsp+60]
       lea       rdx,[rsp+48]
       mov       r8,[rsp+58]
       call      System.DateTimeOffset.Subtract(System.TimeSpan)
       vmovupd   xmm0,[rsp+48]
       vmovupd   [rsp+38],xmm0
       mov       rcx,rbp
       lea       rdx,[rsp+38]
       mov       r11,7FF7ACE70480
       call      qword ptr [7FF7AD280480]
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE70488
       call      qword ptr [7FF7AD280488]
       mov       ecx,edi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE70490
       call      qword ptr [7FF7AD280490]
       mov       ecx,ebx
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE70498
       call      qword ptr [7FF7AD280498]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE704A0
       call      qword ptr [7FF7AD2804A0]
       mov       ecx,[rsp+0C0]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE704A8
       call      qword ptr [7FF7AD2804A8]
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE704B0
       call      qword ptr [7FF7AD2804B0]
       mov       ecx,[rsp+0C8]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE704B8
       call      qword ptr [7FF7AD2804B8]
       mov       ecx,[rsp+0D0]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE704C0
       call      qword ptr [7FF7AD2804C0]
       mov       ecx,[rsp+0D8]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE704C8
       call      qword ptr [7FF7AD2804C8]
       mov       rax,rbp
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 598
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       sub       rsp,0B8
       vzeroupper
       xor       eax,eax
       mov       [rsp+88],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+90],xmm4
       vmovdqa   xmmword ptr [rsp+0A0],xmm4
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+120]
       mov       r15d,[rsp+128]
       mov       r12d,[rsp+130]
       mov       r13d,[rsp+138]
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
       mov       [rsp+0B4],edx
       test      esi,esi
       jle       near ptr M01_L03
M01_L00:
       call      dotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+48],rax
       mov       rcx,offset MT_dotNetTips.Spargine.Tester.Models.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       call      dotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+38],rax
       mov       rcx,[rsp+40]
       mov       rdx,[rsp+48]
       call      dotNetTips.Spargine.Tester.Models.PersonRecord.set_Email(System.String)
       mov       rcx,[rsp+40]
       lea       rcx,[rcx+38]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
; 				PersonRecord person = new(GenerateEmailAddress(), GenerateKey())
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				{
; 				 
; 					BornOn = DateTimeOffset.Now.Subtract(new TimeSpan(365 * GenerateInteger(1, 75), 0, 0, 0)),
; 					                                                                                          
; 					FirstName = GenerateWord(firstNameLength),
; 					                                          
; 					HomePhone = GeneratePhoneNumberUSA(),
; 					                                     
; 					LastName = GenerateWord(lastNameLength),
; 					                                        
; 					CellPhone = GeneratePhoneNumberUSA(),
; 					                                     
; 					Addresses = GenerateAddresses(addressCount, addressLength, cityLength, countryLength, countyProvinceLength, postalCodeLength, stateLength),
; 					                                                                                                                                           
; 				};
; 				  
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0A0]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      dotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       jo        near ptr M01_L05
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rax,46DC5D638865
       cmp       rcx,rax
       jg        near ptr M01_L06
       mov       rax,0B923A29C779B
       cmp       rcx,rax
       jl        near ptr M01_L06
       imul      rax,rcx,2710
       mov       [rsp+70],rax
       lea       rcx,[rsp+0A0]
       call      System.DateTimeOffset.get_ClockDateTime()
       mov       [rsp+88],rax
       lea       rcx,[rsp+88]
       mov       rdx,[rsp+70]
       call      System.DateTime.Subtract(System.TimeSpan)
       mov       rdx,rax
       mov       ecx,[rsp+0A0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L07
       mov       r8,0FF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L07
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+78],xmm0
       lea       rcx,[rsp+78]
       call      System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+78]
       vmovupd   [rsp+90],xmm0
       vmovupd   xmm0,[rsp+90]
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
       mov       eax,[rsp+140]
       mov       [rsp+28],eax
       mov       r10d,[rsp+148]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      dotNetTips.Spargine.Tester.RandomData.GenerateAddresses(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsp+40]
       lea       rcx,[rcx+30]
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
       mov       edx,[rsp+0B4]
       add       edx,1
       jo        short M01_L05
       cmp       edx,esi
       mov       [rsp+0B4],edx
       jl        near ptr M01_L00
; 			records.TrimExcess();
; 			^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       rsi,[rsp+58]
       mov       rdx,[rsi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FF7AD27CFB0]
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
       add       rsp,0B8
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
M01_L07:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_TimeSpanTooLong()
       int       3
; Total bytes of code 919
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
       mov       rdx,7FF7AD361228
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       r9,267C142F8C0
       mov       r9,[r9]
       mov       rdx,267C1421028
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
; 			^^^^^^^^^^^^^^^^^^
; 			{
; 			 
; 				Id = GenerateKey(),
; 				                   
; 				Address1 = GenerateWord(addressLength),
; 				                                       
; 				Address2 = GenerateWord(addressLength),
; 				                                       
; 				BornOn = DateTimeOffset.Now.Subtract(new TimeSpan(365 * GenerateInteger(1, 75), 0, 0, 0)),
; 				                                                                                          
; 				CellPhone = GeneratePhoneNumberUSA(),
; 				                                     
; 				City = GenerateWord(cityLength),
; 				                                
; 				Country = GenerateWord(countryLength),
; 				                                      
; 				Email = GenerateEmailAddress(),
; 				                               
; 				FirstName = GenerateWord(firstNameLength),
; 				                                          
; 				HomePhone = GeneratePhoneNumberUSA(),
; 				                                     
; 				LastName = GenerateWord(lastNameLength),
; 				                                        
; 				PostalCode = GenerateNumber(postalCodeLength),
; 				                                              
; 				State = GenerateWord(stateLength)
; 				                                 
; 			};
; 			  
; 			return person;
; 			^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+60],rax
       mov       [rsp+68],rax
       mov       [rsp+70],rcx
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
       mov       rdx,7FF7AD2DFB88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       rbp,rax
       call      dotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE70598
       call      qword ptr [7FF7AD280598]
       mov       ecx,esi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE705A0
       call      qword ptr [7FF7AD2805A0]
       mov       ecx,esi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE705A8
       call      qword ptr [7FF7AD2805A8]
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+60]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       xor       ecx,ecx
       mov       [rsp+58],rcx
       mov       ecx,1
       mov       edx,4B
       call      dotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      edx,eax,16D
       jo        near ptr M01_L02
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       lea       rcx,[rsp+58]
       xor       r8d,r8d
       xor       r9d,r9d
       call      System.TimeSpan..ctor(Int32, Int32, Int32, Int32, Int32)
       lea       rcx,[rsp+60]
       lea       rdx,[rsp+48]
       mov       r8,[rsp+58]
       call      System.DateTimeOffset.Subtract(System.TimeSpan)
       vmovupd   xmm0,[rsp+48]
       vmovupd   [rsp+38],xmm0
       mov       rcx,rbp
       lea       rdx,[rsp+38]
       mov       r11,7FF7ACE705B0
       call      qword ptr [7FF7AD2805B0]
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE705B8
       call      qword ptr [7FF7AD2805B8]
       mov       ecx,edi
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE705C0
       call      qword ptr [7FF7AD2805C0]
       mov       ecx,ebx
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE705C8
       call      qword ptr [7FF7AD2805C8]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE705D0
       call      qword ptr [7FF7AD2805D0]
       mov       ecx,[rsp+0C0]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE705D8
       call      qword ptr [7FF7AD2805D8]
       call      dotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE705E0
       call      qword ptr [7FF7AD2805E0]
       mov       ecx,[rsp+0C8]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE705E8
       call      qword ptr [7FF7AD2805E8]
       mov       ecx,[rsp+0D0]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE705F0
       call      qword ptr [7FF7AD2805F0]
       mov       ecx,[rsp+0D8]
       call      dotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FF7ACE705F8
       call      qword ptr [7FF7AD2805F8]
       mov       rax,rbp
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 598
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
       mov       rcx,rsi
       call      00007FF80CADF070
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
       mov       r8d,4
       call      System.String.Compare(System.String, System.String, System.StringComparison)
       test      eax,eax
       jne       short M02_L00
       mov       r8,267A14240D0
       mov       rbx,[r8]
       jmp       short M02_L01
M02_L00:
       cmp       byte ptr [rsp+78],0
       jne       short M02_L01
       mov       r8,267C1421028
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
; Total bytes of code 315
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       r9,1F5A42018B8
       mov       r9,[r9]
       mov       rdx,1F5A41F3020
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
       sub       rsp,0B8
       vzeroupper
       xor       eax,eax
       mov       [rsp+88],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+90],xmm4
       vmovdqa   xmmword ptr [rsp+0A0],xmm4
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+120]
       mov       r15d,[rsp+128]
       mov       r12d,[rsp+130]
       mov       r13d,[rsp+138]
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
       mov       [rsp+0B4],edx
       test      esi,esi
       jle       near ptr M01_L03
M01_L00:
       call      dotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+48],rax
       mov       rcx,offset MT_dotNetTips.Spargine.Tester.Models.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       call      dotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+38],rax
       mov       rcx,[rsp+40]
       mov       rdx,[rsp+48]
       call      dotNetTips.Spargine.Tester.Models.PersonRecord.set_Email(System.String)
       mov       rcx,[rsp+40]
       lea       rcx,[rcx+38]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
; 				PersonRecord person = new(GenerateEmailAddress(), GenerateKey())
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				{
; 				 
; 					BornOn = DateTimeOffset.Now.Subtract(new TimeSpan(365 * GenerateInteger(1, 75), 0, 0, 0)),
; 					                                                                                          
; 					FirstName = GenerateWord(firstNameLength),
; 					                                          
; 					HomePhone = GeneratePhoneNumberUSA(),
; 					                                     
; 					LastName = GenerateWord(lastNameLength),
; 					                                        
; 					CellPhone = GeneratePhoneNumberUSA(),
; 					                                     
; 					Addresses = GenerateAddresses(addressCount, addressLength, cityLength, countryLength, countyProvinceLength, postalCodeLength, stateLength),
; 					                                                                                                                                           
; 				};
; 				  
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0A0]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      dotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       jo        near ptr M01_L05
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rax,46DC5D638865
       cmp       rcx,rax
       jg        near ptr M01_L06
       mov       rax,0B923A29C779B
       cmp       rcx,rax
       jl        near ptr M01_L06
       imul      rax,rcx,2710
       mov       [rsp+70],rax
       lea       rcx,[rsp+0A0]
       call      System.DateTimeOffset.get_ClockDateTime()
       mov       [rsp+88],rax
       lea       rcx,[rsp+88]
       mov       rdx,[rsp+70]
       call      System.DateTime.Subtract(System.TimeSpan)
       mov       rdx,rax
       mov       ecx,[rsp+0A0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L07
       mov       r8,0FF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L07
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+78],xmm0
       lea       rcx,[rsp+78]
       call      System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+78]
       vmovupd   [rsp+90],xmm0
       vmovupd   xmm0,[rsp+90]
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
       mov       eax,[rsp+140]
       mov       [rsp+28],eax
       mov       r10d,[rsp+148]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      dotNetTips.Spargine.Tester.RandomData.GenerateAddresses(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsp+40]
       lea       rcx,[rcx+30]
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
       mov       edx,[rsp+0B4]
       add       edx,1
       jo        short M01_L05
       cmp       edx,esi
       mov       [rsp+0B4],edx
       jl        near ptr M01_L00
; 			records.TrimExcess();
; 			^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       rsi,[rsp+58]
       mov       rdx,[rsi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FF7AD26CFB0]
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
       add       rsp,0B8
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
M01_L07:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_TimeSpanTooLong()
       int       3
; Total bytes of code 919
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
       mov       rdx,7FF7AD370210
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
       mov       rcx,rsi
       call      00007FF80CADF070
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
       mov       r8d,4
       call      System.String.Compare(System.String, System.String, System.StringComparison)
       test      eax,eax
       jne       short M03_L00
       mov       r8,1F5B41F10C0
       mov       rbx,[r8]
       jmp       short M03_L01
M03_L00:
       cmp       byte ptr [rsp+78],0
       jne       short M03_L01
       mov       r8,1F5A41F3020
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
; Total bytes of code 315
```

