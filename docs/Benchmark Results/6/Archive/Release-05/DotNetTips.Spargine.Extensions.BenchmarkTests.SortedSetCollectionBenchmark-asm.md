## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1F55A2AD468
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1F55A2AD460
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1F55A2AD468
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       xor       ebx,ebx
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 159
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L01
       cmp       dword ptr [rax+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
M01_L01:
       mov       eax,1
       jmp       short M01_L00
; Total bytes of code 33
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L08
       test      rdi,rdi
       je        near ptr M02_L09
       mov       r14,[rsi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFA98EEA7E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFA986A0B20
       call      qword ptr [7FFA986A0B20]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFA98EEA8C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,[rbp-38]
       mov       r11,7FFA986A0B20
       call      qword ptr [7FFA986A0B20]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFA986A0B28
       call      qword ptr [7FFA986A0B28]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L07:
       mov       rcx,rsp
       call      M02_L10
       nop
       mov       eax,[rbp-2C]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L09:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp-38]
       test      rcx,rcx
       je        short M02_L11
       mov       r11,7FFA986A0B28
       call      qword ptr [7FFA986A0B28]
M02_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 348
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2A68B40A060
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2A68B40A058
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2A68B40A060
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       xor       ebx,ebx
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      qword ptr [7FFAAB4632E8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 160
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L00
       cmp       dword ptr [rax+8],0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 35
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L08
       test      rsi,rsi
       je        near ptr M02_L09
       mov       r14,[rdi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFAAB4DC4E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFAAAB00A88
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAB4DC5B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,[rbp-38]
       mov       r11,7FFAAAB00A88
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFAAAB00A90
       call      qword ptr [r11]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L07:
       mov       rcx,rsp
       call      M02_L10
       nop
       mov       eax,[rbp-2C]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       mov       ecx,10
       call      qword ptr [7FFAAAF7B780]
       int       3
M02_L09:
       mov       ecx,0C
       call      qword ptr [7FFAAAF7B780]
       int       3
M02_L10:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp-38]
       test      rcx,rcx
       je        short M02_L11
       mov       r11,7FFAAAB00A90
       call      qword ptr [r11]
M02_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 335
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1AB9C62D468
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1AB9C62D460
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1AB9C62D468
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       xor       ebx,ebx
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 159
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L01
       cmp       dword ptr [rax+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
M01_L01:
       mov       eax,1
       jmp       short M01_L00
; Total bytes of code 33
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L08
       test      rdi,rdi
       je        near ptr M02_L09
       mov       r14,[rsi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFA98EFAB28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFA986B0B20
       call      qword ptr [7FFA986B0B20]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFA98EFAC00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,[rbp-38]
       mov       r11,7FFA986B0B20
       call      qword ptr [7FFA986B0B20]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFA986B0B28
       call      qword ptr [7FFA986B0B28]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L07:
       mov       rcx,rsp
       call      M02_L10
       nop
       mov       eax,[rbp-2C]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L09:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp-38]
       test      rcx,rcx
       je        short M02_L11
       mov       r11,7FFA986B0B28
       call      qword ptr [7FFA986B0B28]
M02_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 348
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2479040C470
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2479040C468
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2479040C470
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       xor       ebx,ebx
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      qword ptr [7FFAAB461990]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 160
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L00
       cmp       dword ptr [rax+8],0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 35
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L08
       test      rsi,rsi
       je        near ptr M02_L09
       mov       r14,[rdi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFAAB5C0868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFAAAB10A88
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAB5C0940
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,[rbp-38]
       mov       r11,7FFAAAB10A88
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFAAAB10A90
       call      qword ptr [r11]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L07:
       mov       rcx,rsp
       call      M02_L10
       nop
       mov       eax,[rbp-2C]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       mov       ecx,10
       call      qword ptr [7FFAAAF8B780]
       int       3
M02_L09:
       mov       ecx,0C
       call      qword ptr [7FFAAAF8B780]
       int       3
M02_L10:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp-38]
       test      rcx,rcx
       je        short M02_L11
       mov       r11,7FFAAAB10A90
       call      qword ptr [r11]
M02_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 335
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2C963CBD468
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2C963CBD460
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2C963CBD468
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       xor       ebx,ebx
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 159
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L01
       cmp       dword ptr [rax+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
M01_L01:
       mov       eax,1
       jmp       short M01_L00
; Total bytes of code 33
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L08
       test      rdi,rdi
       je        near ptr M02_L09
       mov       r14,[rsi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFA98F0AB78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFA986C0B20
       call      qword ptr [7FFA986C0B20]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFA98F0AC50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,[rbp-38]
       mov       r11,7FFA986C0B20
       call      qword ptr [7FFA986C0B20]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFA986C0B28
       call      qword ptr [7FFA986C0B28]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L07:
       mov       rcx,rsp
       call      M02_L10
       nop
       mov       eax,[rbp-2C]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L09:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp-38]
       test      rcx,rcx
       je        short M02_L11
       mov       r11,7FFA986C0B28
       call      qword ptr [7FFA986C0B28]
M02_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 348
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2445880C470
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2445880C468
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2445880C470
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       xor       ebx,ebx
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      qword ptr [7FFAAB471990]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 160
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L00
       cmp       dword ptr [rax+8],0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 35
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L08
       test      rsi,rsi
       je        near ptr M02_L09
       mov       r14,[rdi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFAAB5D0878
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFAAAB20A88
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAB5D0950
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,[rbp-38]
       mov       r11,7FFAAAB20A88
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFAAAB20A90
       call      qword ptr [r11]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L07:
       mov       rcx,rsp
       call      M02_L10
       nop
       mov       eax,[rbp-2C]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       mov       ecx,10
       call      qword ptr [7FFAAAF9B780]
       int       3
M02_L09:
       mov       ecx,0C
       call      qword ptr [7FFAAAF9B780]
       int       3
M02_L10:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp-38]
       test      rcx,rcx
       je        short M02_L11
       mov       r11,7FFAAAB20A90
       call      qword ptr [r11]
M02_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 335
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,21254BFD468
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,21254BFD460
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,21254BFD468
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       xor       ebx,ebx
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 159
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L01
       cmp       dword ptr [rax+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
M01_L01:
       mov       eax,1
       jmp       short M01_L00
; Total bytes of code 33
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L08
       test      rdi,rdi
       je        near ptr M02_L09
       mov       r14,[rsi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFA98F0AB70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFA986C0B20
       call      qword ptr [7FFA986C0B20]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFA98F0AC48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,[rbp-38]
       mov       r11,7FFA986C0B20
       call      qword ptr [7FFA986C0B20]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFA986C0B28
       call      qword ptr [7FFA986C0B28]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L07:
       mov       rcx,rsp
       call      M02_L10
       nop
       mov       eax,[rbp-2C]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L09:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp-38]
       test      rcx,rcx
       je        short M02_L11
       mov       r11,7FFA986C0B28
       call      qword ptr [7FFA986C0B28]
M02_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 348
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1E3E5C0C470
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1E3E5C0C468
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1E3E5C0C470
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       xor       ebx,ebx
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      qword ptr [7FFAAB45F2E8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 160
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L00
       cmp       dword ptr [rax+8],0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 35
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L08
       test      rsi,rsi
       je        near ptr M02_L09
       mov       r14,[rdi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFAAB5948D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFAAAB20A88
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAB5949B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,[rbp-38]
       mov       r11,7FFAAAB20A88
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFAAAB20A90
       call      qword ptr [r11]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L07:
       mov       rcx,rsp
       call      M02_L10
       nop
       mov       eax,[rbp-2C]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       mov       ecx,10
       call      qword ptr [7FFAAAF9B780]
       int       3
M02_L09:
       mov       ecx,0C
       call      qword ptr [7FFAAAF9B780]
       int       3
M02_L10:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp-38]
       test      rcx,rcx
       je        short M02_L11
       mov       r11,7FFAAAB20A90
       call      qword ptr [r11]
M02_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 335
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,216CFD5D468
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,216CFD5D460
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,216CFD5D468
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       xor       ebx,ebx
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 159
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L01
       cmp       dword ptr [rax+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
M01_L01:
       mov       eax,1
       jmp       short M01_L00
; Total bytes of code 33
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L08
       test      rdi,rdi
       je        near ptr M02_L09
       mov       r14,[rsi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFA98EEAB60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFA986A0B20
       call      qword ptr [7FFA986A0B20]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFA98EEAC38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,[rbp-38]
       mov       r11,7FFA986A0B20
       call      qword ptr [7FFA986A0B20]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFA986A0B28
       call      qword ptr [7FFA986A0B28]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L07:
       mov       rcx,rsp
       call      M02_L10
       nop
       mov       eax,[rbp-2C]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L09:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp-38]
       test      rcx,rcx
       je        short M02_L11
       mov       r11,7FFA986A0B28
       call      qword ptr [7FFA986A0B28]
M02_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 348
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,27DF6C0C470
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,27DF6C0C468
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,27DF6C0C470
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       xor       ebx,ebx
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      qword ptr [7FFAAB4A12E8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 160
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L00
       cmp       dword ptr [rax+8],0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 35
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L08
       test      rsi,rsi
       je        near ptr M02_L09
       mov       r14,[rdi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFAAB50FB48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFAAAB30A88
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAB50FC20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,[rbp-38]
       mov       r11,7FFAAAB30A88
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFAAAB30A90
       call      qword ptr [r11]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L07:
       mov       rcx,rsp
       call      M02_L10
       nop
       mov       eax,[rbp-2C]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       mov       ecx,10
       call      qword ptr [7FFAAAFAB780]
       int       3
M02_L09:
       mov       ecx,0C
       call      qword ptr [7FFAAAFAB780]
       int       3
M02_L10:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp-38]
       test      rcx,rcx
       je        short M02_L11
       mov       r11,7FFAAAB30A90
       call      qword ptr [r11]
M02_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 335
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2721C91D468
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2721C91D460
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2721C91D468
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       xor       ebx,ebx
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 159
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L01
       cmp       dword ptr [rax+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
M01_L01:
       mov       eax,1
       jmp       short M01_L00
; Total bytes of code 33
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L08
       test      rdi,rdi
       je        near ptr M02_L09
       mov       r14,[rsi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFA98EEABE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFA986A0B20
       call      qword ptr [7FFA986A0B20]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFA98EEACC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,[rbp-38]
       mov       r11,7FFA986A0B20
       call      qword ptr [7FFA986A0B20]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFA986A0B28
       call      qword ptr [7FFA986A0B28]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L07:
       mov       rcx,rsp
       call      M02_L10
       nop
       mov       eax,[rbp-2C]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L09:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp-38]
       test      rcx,rcx
       je        short M02_L11
       mov       r11,7FFA986A0B28
       call      qword ptr [7FFA986A0B28]
M02_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 348
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,220F6C0C470
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,220F6C0C468
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,220F6C0C470
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       xor       ebx,ebx
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      qword ptr [7FFAAB4832E8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 160
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L00
       cmp       dword ptr [rax+8],0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 35
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L08
       test      rsi,rsi
       je        near ptr M02_L09
       mov       r14,[rdi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFAAB4FCB00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFAAAB20A88
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAB4FCBD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,[rbp-38]
       mov       r11,7FFAAAB20A88
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFAAAB20A90
       call      qword ptr [r11]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L07:
       mov       rcx,rsp
       call      M02_L10
       nop
       mov       eax,[rbp-2C]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       mov       ecx,10
       call      qword ptr [7FFAAAF9B780]
       int       3
M02_L09:
       mov       ecx,0C
       call      qword ptr [7FFAAAF9B780]
       int       3
M02_L10:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp-38]
       test      rcx,rcx
       je        short M02_L11
       mov       r11,7FFAAAB20A90
       call      qword ptr [r11]
M02_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 335
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1E3D5E99060
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1E3D5E99058
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1E3D5E99060
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       xor       ebx,ebx
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 159
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L01
       cmp       dword ptr [rax+8],0
       je        short M01_L01
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
M01_L01:
       mov       eax,1
       jmp       short M01_L00
; Total bytes of code 33
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L08
       test      rdi,rdi
       je        near ptr M02_L09
       mov       r14,[rsi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFA98EFAB60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFA986B0B20
       call      qword ptr [7FFA986B0B20]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFA98EFAC38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,[rbp-38]
       mov       r11,7FFA986B0B20
       call      qword ptr [7FFA986B0B20]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFA986B0B28
       call      qword ptr [7FFA986B0B28]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L07:
       mov       rcx,rsp
       call      M02_L10
       nop
       mov       eax,[rbp-2C]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L09:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp-38]
       test      rcx,rcx
       je        short M02_L11
       mov       r11,7FFA986B0B28
       call      qword ptr [7FFA986B0B28]
M02_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 348
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1D30BC0C470
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1D30BC0C468
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1D30BC0C470
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       xor       ebx,ebx
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      qword ptr [7FFAAB451990]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 160
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       rax,[rdx+8]
       test      rax,rax
       je        short M01_L00
       cmp       dword ptr [rax+8],0
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 35
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L08
       test      rsi,rsi
       je        near ptr M02_L09
       mov       r14,[rdi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFAAB5B0970
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFAAAB00A88
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAB5B0A48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,[rbp-38]
       mov       r11,7FFAAAB00A88
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFAAAB00A90
       call      qword ptr [r11]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L07:
       mov       rcx,rsp
       call      M02_L10
       nop
       mov       eax,[rbp-2C]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       mov       ecx,10
       call      qword ptr [7FFAAAF7B780]
       int       3
M02_L09:
       mov       ecx,0C
       call      qword ptr [7FFAAAF7B780]
       int       3
M02_L10:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp-38]
       test      rcx,rcx
       je        short M02_L11
       mov       r11,7FFAAAB00A90
       call      qword ptr [r11]
M02_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 335
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,18062791290
       mov       r8,[r8]
       mov       rcx,rdi
       call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     cl
       movzx     ecx,cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 99
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr M01_L27
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        near ptr M01_L30
M01_L00:
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFA98F0E648
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       r12,rax
       test      r12,r12
       jne       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr M01_L21
       jmp       near ptr M01_L22
M01_L04:
       mov       rcx,r14
       mov       rax,[r15+80]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FFA98F0E710
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
       test      eax,eax
       je        short M01_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr M01_L20
M01_L07:
       cmp       dword ptr [r12+20],0
       jg        near ptr M01_L31
M01_L08:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       rdx,7FFA98F0E6D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr M01_L19
       test      rbp,rbp
       je        near ptr M01_L15
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr M01_L15
M01_L11:
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12-1]
       cmp       ecx,r13d
       jae       near ptr M01_L32
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+78]
       test      r11,r11
       je        short M01_L12
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFA98F0E6F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
M01_L13:
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L14
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr M01_L32
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ebx,[rsp+44]
M01_L14:
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr M01_L11
       jmp       near ptr M01_L19
M01_L15:
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr M01_L32
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12-1]
       cmp       ecx,r13d
       jae       near ptr M01_L32
       lea       ecx,[r12-1]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+78]
       test      r11,r11
       je        short M01_L16
       mov       rax,[rsp+30]
       jmp       short M01_L17
M01_L16:
       mov       rdx,7FFA98F0E6F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rax,[rsp+30]
M01_L17:
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L18
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr M01_L32
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ebx,[rsp+44]
M01_L18:
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr M01_L15
M01_L19:
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+60]
       test      r15,r15
       je        short M01_L23
       jmp       short M01_L24
M01_L20:
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L07
M01_L21:
       mov       rdx,7FFA98F0E688
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L22:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short M01_L26
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+70]
       test      r12,r12
       je        near ptr M01_L09
       mov       rax,r12
       jmp       near ptr M01_L10
M01_L23:
       mov       rdx,7FFA98F0E648
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M01_L25
M01_L24:
       mov       rax,r15
M01_L25:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
M01_L26:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L27:
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+58],0
       je        short M01_L28
       mov       rcx,[r15+58]
       jmp       short M01_L29
M01_L28:
       mov       rdx,7FFA98F0E5E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L29:
       call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L30:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FFA989B72B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L08
M01_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1079
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       xor       esi,esi
       mov       r11,7FFA986C0480
       call      qword ptr [7FFA986C0480]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA986C0488
       call      qword ptr [7FFA986C0488]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFA986C0488
       call      qword ptr [7FFA986C0488]
       test      eax,eax
       jne       short M02_L01
M02_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,1D73F406548
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFAAB12F708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FFAAB161060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4B1D20]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 101
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr M01_L22
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        near ptr M01_L25
M01_L00:
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFAAB5C2C60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAAACBB828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr M01_L16
       jmp       near ptr M01_L17
M01_L04:
       mov       rcx,r14
       mov       rax,[r15+80]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FFAAB5C2D28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FFAAB12FAB0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
       test      eax,eax
       je        short M01_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr M01_L12
M01_L07:
       cmp       dword ptr [r12+20],0
       jg        near ptr M01_L26
M01_L08:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       rdx,7FFAAB5C2CF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFAAB447450]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr M01_L19
M01_L11:
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr M01_L27
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx-1]
       cmp       ecx,r13d
       jae       near ptr M01_L27
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+78]
       test      r11,r11
       je        short M01_L13
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short M01_L14
M01_L12:
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L07
M01_L13:
       mov       rdx,7FFAAB5C2D10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
M01_L14:
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L15
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr M01_L27
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12d,[rsp+44]
M01_L15:
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr M01_L11
       jmp       short M01_L19
M01_L16:
       mov       rdx,7FFAAB5C2CA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAAB447420]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short M01_L21
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr M01_L09
       jmp       near ptr M01_L10
M01_L18:
       mov       rdx,7FFAAB5C2C60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
       jmp       short M01_L20
M01_L19:
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        short M01_L18
M01_L20:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [7FFAAB12FAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
M01_L21:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+58],0
       je        short M01_L23
       mov       rcx,[r15+58]
       jmp       short M01_L24
M01_L23:
       mov       rdx,7FFAAB5C2BF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FFAAB121780]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FFAAAF916B0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFAAAF3FF90]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB44B570]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L08
M01_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 849
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       xor       esi,esi
       mov       r11,7FFAAAB10AA8
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB10AB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB10AB0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L01
M02_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 98
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,1BA0AB71298
       mov       r8,[r8]
       mov       rcx,rdi
       call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     cl
       movzx     ecx,cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 99
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr M01_L27
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        near ptr M01_L30
M01_L00:
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFA98F0AE68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       r12,rax
       test      r12,r12
       jne       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr M01_L21
       jmp       near ptr M01_L22
M01_L04:
       mov       rcx,r14
       mov       rax,[r15+80]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FFA98F0AF30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
       test      eax,eax
       je        short M01_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr M01_L20
M01_L07:
       cmp       dword ptr [r12+20],0
       jg        near ptr M01_L31
M01_L08:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       rdx,7FFA98F0AEF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr M01_L19
       test      rbp,rbp
       je        near ptr M01_L15
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr M01_L15
M01_L11:
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12-1]
       cmp       ecx,r13d
       jae       near ptr M01_L32
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+78]
       test      r11,r11
       je        short M01_L12
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFA98F0AF18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
M01_L13:
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L14
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr M01_L32
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ebx,[rsp+44]
M01_L14:
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr M01_L11
       jmp       near ptr M01_L19
M01_L15:
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr M01_L32
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12-1]
       cmp       ecx,r13d
       jae       near ptr M01_L32
       lea       ecx,[r12-1]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+78]
       test      r11,r11
       je        short M01_L16
       mov       rax,[rsp+30]
       jmp       short M01_L17
M01_L16:
       mov       rdx,7FFA98F0AF18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rax,[rsp+30]
M01_L17:
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L18
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr M01_L32
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ebx,[rsp+44]
M01_L18:
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr M01_L15
M01_L19:
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+60]
       test      r15,r15
       je        short M01_L23
       jmp       short M01_L24
M01_L20:
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L07
M01_L21:
       mov       rdx,7FFA98F0AEA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L22:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short M01_L26
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+70]
       test      r12,r12
       je        near ptr M01_L09
       mov       rax,r12
       jmp       near ptr M01_L10
M01_L23:
       mov       rdx,7FFA98F0AE68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M01_L25
M01_L24:
       mov       rax,r15
M01_L25:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
M01_L26:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L27:
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+58],0
       je        short M01_L28
       mov       rcx,[r15+58]
       jmp       short M01_L29
M01_L28:
       mov       rdx,7FFA98F0AE00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L29:
       call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L30:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FFA989B72B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L08
M01_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1079
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       xor       esi,esi
       mov       r11,7FFA986C0480
       call      qword ptr [7FFA986C0480]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA986C0488
       call      qword ptr [7FFA986C0488]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFA986C0488
       call      qword ptr [7FFA986C0488]
       test      eax,eax
       jne       short M02_L01
M02_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,1BDB00108F8
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFAAB12F708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FFAAB161060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB493990]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 101
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr M01_L22
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        near ptr M01_L25
M01_L00:
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFAAB595008
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAAACBB828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr M01_L16
       jmp       near ptr M01_L17
M01_L04:
       mov       rcx,r14
       mov       rax,[r15+80]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FFAAB5950D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FFAAB12FAB0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
       test      eax,eax
       je        short M01_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr M01_L12
M01_L07:
       cmp       dword ptr [r12+20],0
       jg        near ptr M01_L26
M01_L08:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       rdx,7FFAAB595098
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFAAB447D20]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr M01_L19
M01_L11:
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr M01_L27
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx-1]
       cmp       ecx,r13d
       jae       near ptr M01_L27
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+78]
       test      r11,r11
       je        short M01_L13
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short M01_L14
M01_L12:
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L07
M01_L13:
       mov       rdx,7FFAAB5950B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
M01_L14:
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L15
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr M01_L27
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12d,[rsp+44]
M01_L15:
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr M01_L11
       jmp       short M01_L19
M01_L16:
       mov       rdx,7FFAAB595048
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAAB447CF0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short M01_L21
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr M01_L09
       jmp       near ptr M01_L10
M01_L18:
       mov       rdx,7FFAAB595008
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
       jmp       short M01_L20
M01_L19:
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        short M01_L18
M01_L20:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [7FFAAB12FAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
M01_L21:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+58],0
       je        short M01_L23
       mov       rcx,[r15+58]
       jmp       short M01_L24
M01_L23:
       mov       rdx,7FFAAB594F98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FFAAB121780]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FFAAAF916B0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFAAAF3FF90]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB44BEB8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L08
M01_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 849
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       xor       esi,esi
       mov       r11,7FFAAAB10A78
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB10A80
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB10A80
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L01
M02_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 98
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,240C1741298
       mov       r8,[r8]
       mov       rcx,rdi
       call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     cl
       movzx     ecx,cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 99
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr M01_L27
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        near ptr M01_L30
M01_L00:
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFA98EFAC30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       r12,rax
       test      r12,r12
       jne       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr M01_L21
       jmp       near ptr M01_L22
M01_L04:
       mov       rcx,r14
       mov       rax,[r15+80]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FFA98EFACF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
       test      eax,eax
       je        short M01_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr M01_L20
M01_L07:
       cmp       dword ptr [r12+20],0
       jg        near ptr M01_L31
M01_L08:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       rdx,7FFA98EFACC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr M01_L19
       test      rbp,rbp
       je        near ptr M01_L15
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr M01_L15
M01_L11:
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12-1]
       cmp       ecx,r13d
       jae       near ptr M01_L32
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+78]
       test      r11,r11
       je        short M01_L12
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFA98EFACE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
M01_L13:
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L14
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr M01_L32
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ebx,[rsp+44]
M01_L14:
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr M01_L11
       jmp       near ptr M01_L19
M01_L15:
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr M01_L32
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12-1]
       cmp       ecx,r13d
       jae       near ptr M01_L32
       lea       ecx,[r12-1]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+78]
       test      r11,r11
       je        short M01_L16
       mov       rax,[rsp+30]
       jmp       short M01_L17
M01_L16:
       mov       rdx,7FFA98EFACE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rax,[rsp+30]
M01_L17:
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L18
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr M01_L32
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ebx,[rsp+44]
M01_L18:
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr M01_L15
M01_L19:
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+60]
       test      r15,r15
       je        short M01_L23
       jmp       short M01_L24
M01_L20:
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L07
M01_L21:
       mov       rdx,7FFA98EFAC70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L22:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short M01_L26
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+70]
       test      r12,r12
       je        near ptr M01_L09
       mov       rax,r12
       jmp       near ptr M01_L10
M01_L23:
       mov       rdx,7FFA98EFAC30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M01_L25
M01_L24:
       mov       rax,r15
M01_L25:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
M01_L26:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L27:
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+58],0
       je        short M01_L28
       mov       rcx,[r15+58]
       jmp       short M01_L29
M01_L28:
       mov       rdx,7FFA98EFABC8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L29:
       call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L30:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FFA989A72B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L08
M01_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1079
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       xor       esi,esi
       mov       r11,7FFA986B0480
       call      qword ptr [7FFA986B0480]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA986B0488
       call      qword ptr [7FFA986B0488]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFA986B0488
       call      qword ptr [7FFA986B0488]
       test      eax,eax
       jne       short M02_L01
M02_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,25F078108F8
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFAAB12F708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FFAAB161060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB495270]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 101
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr M01_L22
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        near ptr M01_L25
M01_L00:
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFAAB5C22E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAAACBB828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr M01_L16
       jmp       near ptr M01_L17
M01_L04:
       mov       rcx,r14
       mov       rax,[r15+80]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FFAAB5C23B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FFAAB12FAB0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
       test      eax,eax
       je        short M01_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr M01_L12
M01_L07:
       cmp       dword ptr [r12+20],0
       jg        near ptr M01_L26
M01_L08:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       rdx,7FFAAB5C2378
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFAAB43B1B0]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr M01_L19
M01_L11:
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr M01_L27
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx-1]
       cmp       ecx,r13d
       jae       near ptr M01_L27
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+78]
       test      r11,r11
       je        short M01_L13
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short M01_L14
M01_L12:
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L07
M01_L13:
       mov       rdx,7FFAAB5C2398
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
M01_L14:
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L15
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr M01_L27
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12d,[rsp+44]
M01_L15:
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr M01_L11
       jmp       short M01_L19
M01_L16:
       mov       rdx,7FFAAB5C2328
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAAB43B180]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short M01_L21
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr M01_L09
       jmp       near ptr M01_L10
M01_L18:
       mov       rdx,7FFAAB5C22E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
       jmp       short M01_L20
M01_L19:
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        short M01_L18
M01_L20:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [7FFAAB12FAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
M01_L21:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+58],0
       je        short M01_L23
       mov       rcx,[r15+58]
       jmp       short M01_L24
M01_L23:
       mov       rdx,7FFAAB5C2278
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FFAAB121780]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FFAAAF916B0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFAAAF3FF90]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB43F570]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L08
M01_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 849
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       xor       esi,esi
       mov       r11,7FFAAAB10A78
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB10A80
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB10A80
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L01
M02_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 98
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,215209E1298
       mov       r8,[r8]
       mov       rcx,rdi
       call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     cl
       movzx     ecx,cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 99
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr M01_L27
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        near ptr M01_L30
M01_L00:
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFA98EFB8B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       r12,rax
       test      r12,r12
       jne       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr M01_L21
       jmp       near ptr M01_L22
M01_L04:
       mov       rcx,r14
       mov       rax,[r15+80]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FFA98EFB980
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
       test      eax,eax
       je        short M01_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr M01_L20
M01_L07:
       cmp       dword ptr [r12+20],0
       jg        near ptr M01_L31
M01_L08:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       rdx,7FFA98EFB948
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr M01_L19
       test      rbp,rbp
       je        near ptr M01_L15
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr M01_L15
M01_L11:
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12-1]
       cmp       ecx,r13d
       jae       near ptr M01_L32
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+78]
       test      r11,r11
       je        short M01_L12
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFA98EFB968
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
M01_L13:
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L14
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr M01_L32
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ebx,[rsp+44]
M01_L14:
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr M01_L11
       jmp       near ptr M01_L19
M01_L15:
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr M01_L32
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12-1]
       cmp       ecx,r13d
       jae       near ptr M01_L32
       lea       ecx,[r12-1]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+78]
       test      r11,r11
       je        short M01_L16
       mov       rax,[rsp+30]
       jmp       short M01_L17
M01_L16:
       mov       rdx,7FFA98EFB968
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rax,[rsp+30]
M01_L17:
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L18
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr M01_L32
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ebx,[rsp+44]
M01_L18:
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr M01_L15
M01_L19:
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+60]
       test      r15,r15
       je        short M01_L23
       jmp       short M01_L24
M01_L20:
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L07
M01_L21:
       mov       rdx,7FFA98EFB8F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L22:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short M01_L26
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+70]
       test      r12,r12
       je        near ptr M01_L09
       mov       rax,r12
       jmp       near ptr M01_L10
M01_L23:
       mov       rdx,7FFA98EFB8B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M01_L25
M01_L24:
       mov       rax,r15
M01_L25:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
M01_L26:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L27:
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+58],0
       je        short M01_L28
       mov       rcx,[r15+58]
       jmp       short M01_L29
M01_L28:
       mov       rdx,7FFA98EFB850
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L29:
       call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L30:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FFA989A72B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L08
M01_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1079
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       xor       esi,esi
       mov       r11,7FFA986B0480
       call      qword ptr [7FFA986B0480]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA986B0488
       call      qword ptr [7FFA986B0488]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFA986B0488
       call      qword ptr [7FFA986B0488]
       test      eax,eax
       jne       short M02_L01
M02_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,242F34108F8
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFAAB14F708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FFAAB181060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4B3990]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 101
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr M01_L22
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        near ptr M01_L25
M01_L00:
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFAAB5E42E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAAACDB828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr M01_L16
       jmp       near ptr M01_L17
M01_L04:
       mov       rcx,r14
       mov       rax,[r15+80]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FFAAB5E43B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FFAAB14FAB0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
       test      eax,eax
       je        short M01_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr M01_L12
M01_L07:
       cmp       dword ptr [r12+20],0
       jg        near ptr M01_L26
M01_L08:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       rdx,7FFAAB5E4378
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFAAB4691B0]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr M01_L19
M01_L11:
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr M01_L27
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx-1]
       cmp       ecx,r13d
       jae       near ptr M01_L27
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+78]
       test      r11,r11
       je        short M01_L13
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short M01_L14
M01_L12:
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L07
M01_L13:
       mov       rdx,7FFAAB5E4398
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
M01_L14:
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L15
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr M01_L27
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12d,[rsp+44]
M01_L15:
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr M01_L11
       jmp       short M01_L19
M01_L16:
       mov       rdx,7FFAAB5E4328
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAAB469180]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short M01_L21
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr M01_L09
       jmp       near ptr M01_L10
M01_L18:
       mov       rdx,7FFAAB5E42E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
       jmp       short M01_L20
M01_L19:
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        short M01_L18
M01_L20:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [7FFAAB14FAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
M01_L21:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+58],0
       je        short M01_L23
       mov       rcx,[r15+58]
       jmp       short M01_L24
M01_L23:
       mov       rdx,7FFAAB5E4278
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FFAAB141780]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FFAAAFB16B0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFAAAF5FF90]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB46D570]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L08
M01_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 849
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       xor       esi,esi
       mov       r11,7FFAAAB30A78
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB30A80
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB30A80
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L01
M02_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 98
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,151CB811298
       mov       r8,[r8]
       mov       rcx,rdi
       call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     cl
       movzx     ecx,cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 99
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr M01_L27
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        near ptr M01_L30
M01_L00:
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFA98F1B978
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       r12,rax
       test      r12,r12
       jne       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr M01_L21
       jmp       near ptr M01_L22
M01_L04:
       mov       rcx,r14
       mov       rax,[r15+80]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FFA98F1BA40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
       test      eax,eax
       je        short M01_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr M01_L20
M01_L07:
       cmp       dword ptr [r12+20],0
       jg        near ptr M01_L31
M01_L08:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       rdx,7FFA98F1BA08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr M01_L19
       test      rbp,rbp
       je        near ptr M01_L15
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr M01_L15
M01_L11:
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12-1]
       cmp       ecx,r13d
       jae       near ptr M01_L32
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+78]
       test      r11,r11
       je        short M01_L12
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFA98F1BA28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
M01_L13:
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L14
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr M01_L32
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ebx,[rsp+44]
M01_L14:
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr M01_L11
       jmp       near ptr M01_L19
M01_L15:
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr M01_L32
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12-1]
       cmp       ecx,r13d
       jae       near ptr M01_L32
       lea       ecx,[r12-1]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+78]
       test      r11,r11
       je        short M01_L16
       mov       rax,[rsp+30]
       jmp       short M01_L17
M01_L16:
       mov       rdx,7FFA98F1BA28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rax,[rsp+30]
M01_L17:
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L18
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr M01_L32
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ebx,[rsp+44]
M01_L18:
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr M01_L15
M01_L19:
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+60]
       test      r15,r15
       je        short M01_L23
       jmp       short M01_L24
M01_L20:
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L07
M01_L21:
       mov       rdx,7FFA98F1B9B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L22:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short M01_L26
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+70]
       test      r12,r12
       je        near ptr M01_L09
       mov       rax,r12
       jmp       near ptr M01_L10
M01_L23:
       mov       rdx,7FFA98F1B978
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M01_L25
M01_L24:
       mov       rax,r15
M01_L25:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
M01_L26:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L27:
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+58],0
       je        short M01_L28
       mov       rcx,[r15+58]
       jmp       short M01_L29
M01_L28:
       mov       rdx,7FFA98F1B910
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L29:
       call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L30:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FFA989C72B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L08
M01_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1079
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       xor       esi,esi
       mov       r11,7FFA986D0480
       call      qword ptr [7FFA986D0480]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA986D0488
       call      qword ptr [7FFA986D0488]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFA986D0488
       call      qword ptr [7FFA986D0488]
       test      eax,eax
       jne       short M02_L01
M02_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,1AD544108F8
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFAAB11F708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FFAAB151060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB483990]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 101
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr M01_L22
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        near ptr M01_L25
M01_L00:
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFAAB5852F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAAACAB828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr M01_L16
       jmp       near ptr M01_L17
M01_L04:
       mov       rcx,r14
       mov       rax,[r15+80]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FFAAB5853C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FFAAB11FAB0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
       test      eax,eax
       je        short M01_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr M01_L12
M01_L07:
       cmp       dword ptr [r12+20],0
       jg        near ptr M01_L26
M01_L08:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       rdx,7FFAAB585388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFAAB437D20]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr M01_L19
M01_L11:
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr M01_L27
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx-1]
       cmp       ecx,r13d
       jae       near ptr M01_L27
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+78]
       test      r11,r11
       je        short M01_L13
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short M01_L14
M01_L12:
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L07
M01_L13:
       mov       rdx,7FFAAB5853A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
M01_L14:
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L15
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr M01_L27
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12d,[rsp+44]
M01_L15:
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr M01_L11
       jmp       short M01_L19
M01_L16:
       mov       rdx,7FFAAB585338
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAAB437CF0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short M01_L21
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr M01_L09
       jmp       near ptr M01_L10
M01_L18:
       mov       rdx,7FFAAB5852F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
       jmp       short M01_L20
M01_L19:
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        short M01_L18
M01_L20:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [7FFAAB11FAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
M01_L21:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+58],0
       je        short M01_L23
       mov       rcx,[r15+58]
       jmp       short M01_L24
M01_L23:
       mov       rdx,7FFAAB585288
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FFAAB111780]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FFAAAF816B0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFAAAF2FF90]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB43BEB8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L08
M01_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 849
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       xor       esi,esi
       mov       r11,7FFAAAB00A78
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB00A80
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB00A80
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L01
M02_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 98
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,13188411298
       mov       r8,[r8]
       mov       rcx,rdi
       call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     cl
       movzx     ecx,cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 99
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr M01_L27
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        near ptr M01_L30
M01_L00:
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFA98F1B918
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       r12,rax
       test      r12,r12
       jne       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr M01_L21
       jmp       near ptr M01_L22
M01_L04:
       mov       rcx,r14
       mov       rax,[r15+80]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FFA98F1B9E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
       test      eax,eax
       je        short M01_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr M01_L20
M01_L07:
       cmp       dword ptr [r12+20],0
       jg        near ptr M01_L31
M01_L08:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       rdx,7FFA98F1B9A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr M01_L19
       test      rbp,rbp
       je        near ptr M01_L15
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr M01_L15
M01_L11:
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12-1]
       cmp       ecx,r13d
       jae       near ptr M01_L32
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+78]
       test      r11,r11
       je        short M01_L12
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFA98F1B9C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
M01_L13:
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L14
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr M01_L32
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ebx,[rsp+44]
M01_L14:
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr M01_L11
       jmp       near ptr M01_L19
M01_L15:
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr M01_L32
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12-1]
       cmp       ecx,r13d
       jae       near ptr M01_L32
       lea       ecx,[r12-1]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+78]
       test      r11,r11
       je        short M01_L16
       mov       rax,[rsp+30]
       jmp       short M01_L17
M01_L16:
       mov       rdx,7FFA98F1B9C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rax,[rsp+30]
M01_L17:
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L18
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr M01_L32
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ebx,[rsp+44]
M01_L18:
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr M01_L15
M01_L19:
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+60]
       test      r15,r15
       je        short M01_L23
       jmp       short M01_L24
M01_L20:
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L07
M01_L21:
       mov       rdx,7FFA98F1B958
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L22:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short M01_L26
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+70]
       test      r12,r12
       je        near ptr M01_L09
       mov       rax,r12
       jmp       near ptr M01_L10
M01_L23:
       mov       rdx,7FFA98F1B918
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M01_L25
M01_L24:
       mov       rax,r15
M01_L25:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
M01_L26:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L27:
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+58],0
       je        short M01_L28
       mov       rcx,[r15+58]
       jmp       short M01_L29
M01_L28:
       mov       rdx,7FFA98F1B8B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L29:
       call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L30:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FFA989C72B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L08
M01_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1079
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       xor       esi,esi
       mov       r11,7FFA986D0480
       call      qword ptr [7FFA986D0480]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA986D0488
       call      qword ptr [7FFA986D0488]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFA986D0488
       call      qword ptr [7FFA986D0488]
       test      eax,eax
       jne       short M02_L01
M02_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,23EA9C108F8
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFAAB11F708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FFAAB151060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB485270]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 101
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr M01_L22
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        near ptr M01_L25
M01_L00:
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFAAB5B2250
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAAACAB828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr M01_L16
       jmp       near ptr M01_L17
M01_L04:
       mov       rcx,r14
       mov       rax,[r15+80]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FFAAB5B2318
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FFAAB11FAB0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
       test      eax,eax
       je        short M01_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr M01_L12
M01_L07:
       cmp       dword ptr [r12+20],0
       jg        near ptr M01_L26
M01_L08:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       rdx,7FFAAB5B22E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFAAB42B1B0]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr M01_L19
M01_L11:
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr M01_L27
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx-1]
       cmp       ecx,r13d
       jae       near ptr M01_L27
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+78]
       test      r11,r11
       je        short M01_L13
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short M01_L14
M01_L12:
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L07
M01_L13:
       mov       rdx,7FFAAB5B2300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
M01_L14:
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L15
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr M01_L27
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12d,[rsp+44]
M01_L15:
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr M01_L11
       jmp       short M01_L19
M01_L16:
       mov       rdx,7FFAAB5B2290
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAAB42B180]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short M01_L21
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr M01_L09
       jmp       near ptr M01_L10
M01_L18:
       mov       rdx,7FFAAB5B2250
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
       jmp       short M01_L20
M01_L19:
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        short M01_L18
M01_L20:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [7FFAAB11FAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
M01_L21:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+58],0
       je        short M01_L23
       mov       rcx,[r15+58]
       jmp       short M01_L24
M01_L23:
       mov       rdx,7FFAAB5B21E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FFAAB111780]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FFAAAF816B0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFAAAF2FF90]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB42F570]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L08
M01_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 849
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       xor       esi,esi
       mov       r11,7FFAAAB00A78
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB00A80
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB00A80
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L01
M02_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 98
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,1D304481298
       mov       r8,[r8]
       mov       rcx,rdi
       call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     cl
       movzx     ecx,cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 99
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr M01_L27
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        near ptr M01_L30
M01_L00:
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFA98F0B9E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       r12,rax
       test      r12,r12
       jne       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr M01_L21
       jmp       near ptr M01_L22
M01_L04:
       mov       rcx,r14
       mov       rax,[r15+80]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FFA98F0BAA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
       test      eax,eax
       je        short M01_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr M01_L20
M01_L07:
       cmp       dword ptr [r12+20],0
       jg        near ptr M01_L31
M01_L08:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       rdx,7FFA98F0BA70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       ebx,1
       mov       r12d,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr M01_L19
       test      rbp,rbp
       je        near ptr M01_L15
       cmp       dword ptr [rsp+48],0
       setge     cl
       movzx     ecx,cl
       mov       r13d,[rbp+8]
       cmp       [rsp+48],r13d
       setle     dl
       movzx     edx,dl
       test      edx,ecx
       je        near ptr M01_L15
M01_L11:
       movsxd    rax,r12d
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12-1]
       cmp       ecx,r13d
       jae       near ptr M01_L32
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+78]
       test      r11,r11
       je        short M01_L12
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFA98F0BA90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
M01_L13:
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L14
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr M01_L32
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ebx,[rsp+44]
M01_L14:
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr M01_L11
       jmp       near ptr M01_L19
M01_L15:
       mov       r13d,[rbp+8]
       cmp       r12d,r13d
       jae       near ptr M01_L32
       movsxd    rcx,r12d
       mov       r8,[rbp+rcx*8+10]
       mov       [rsp+30],r8
       lea       ecx,[r12-1]
       cmp       ecx,r13d
       jae       near ptr M01_L32
       lea       ecx,[r12-1]
       movsxd    rcx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+78]
       test      r11,r11
       je        short M01_L16
       mov       rax,[rsp+30]
       jmp       short M01_L17
M01_L16:
       mov       rdx,7FFA98F0BA90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       rax,[rsp+30]
M01_L17:
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8,[rsp+28]
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L18
       lea       edx,[rbx+1]
       mov       [rsp+44],edx
       movsxd    rdx,r12d
       mov       rdx,[rbp+rdx*8+10]
       cmp       ebx,r13d
       jae       near ptr M01_L32
       movsxd    rcx,ebx
       lea       rcx,[rbp+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ebx,[rsp+44]
M01_L18:
       inc       r12d
       cmp       r12d,[rsp+48]
       jl        near ptr M01_L15
M01_L19:
       mov       [rsp+48],ebx
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       r15,[r15+60]
       test      r15,r15
       je        short M01_L23
       jmp       short M01_L24
M01_L20:
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L07
M01_L21:
       mov       rdx,7FFA98F0BA20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L22:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short M01_L26
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       r12,[r15+70]
       test      r12,r12
       je        near ptr M01_L09
       mov       rax,r12
       jmp       near ptr M01_L10
M01_L23:
       mov       rdx,7FFA98F0B9E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M01_L25
M01_L24:
       mov       rax,r15
M01_L25:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rax
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
M01_L26:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L27:
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+58],0
       je        short M01_L28
       mov       rcx,[r15+58]
       jmp       short M01_L29
M01_L28:
       mov       rdx,7FFA98F0B978
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L29:
       call      System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L30:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,7BD
       mov       rdx,7FFA989B72B8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L31:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L08
M01_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1079
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       xor       esi,esi
       mov       r11,7FFA986C0480
       call      qword ptr [7FFA986C0480]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA986C0488
       call      qword ptr [7FFA986C0488]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFA986C0488
       call      qword ptr [7FFA986C0488]
       test      eax,eax
       jne       short M02_L01
M02_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,22A8340C4F0
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFAAB13F708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FFAAB171060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4A5270]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 101
```
```assembly
; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,rdi
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr M01_L22
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        near ptr M01_L25
M01_L00:
       mov       r14,[rdi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFAAB5D3308
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAAACCB828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr M01_L16
       jmp       near ptr M01_L17
M01_L04:
       mov       rcx,r14
       mov       rax,[r15+80]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FFAAB5D33D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FFAAB13FAB0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
       test      eax,eax
       je        short M01_L03
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr M01_L12
M01_L07:
       cmp       dword ptr [r12+20],0
       jg        near ptr M01_L26
M01_L08:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       rdx,7FFAAB5D3398
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFAAB44B1B0]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r12d,1
       mov       ebx,1
       cmp       dword ptr [rsp+48],1
       jle       near ptr M01_L19
M01_L11:
       mov       r13d,[rbp+8]
       cmp       ebx,r13d
       jae       near ptr M01_L27
       mov       eax,ebx
       mov       [rsp+38],rax
       mov       r8,[rbp+rax*8+10]
       mov       [rsp+30],r8
       lea       ecx,[rbx-1]
       cmp       ecx,r13d
       jae       near ptr M01_L27
       mov       ecx,ecx
       mov       r9,[rbp+rcx*8+10]
       mov       [rsp+28],r9
       mov       rcx,r14
       mov       r11,[r15+78]
       test      r11,r11
       je        short M01_L13
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short M01_L14
M01_L12:
       mov       rcx,r12
       mov       edx,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L07
M01_L13:
       mov       rdx,7FFAAB5D33B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
M01_L14:
       mov       rcx,rsi
       mov       rdx,r8
       mov       r8,r9
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L15
       lea       edx,[r12+1]
       mov       [rsp+44],edx
       mov       rdx,[rsp+38]
       mov       rdx,[rbp+rdx*8+10]
       cmp       r12d,r13d
       jae       near ptr M01_L27
       mov       ecx,r12d
       lea       rcx,[rbp+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12d,[rsp+44]
M01_L15:
       inc       ebx
       cmp       ebx,[rsp+48]
       jl        near ptr M01_L11
       jmp       short M01_L19
M01_L16:
       mov       rdx,7FFAAB5D3348
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAAB44B180]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short M01_L21
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr M01_L09
       jmp       near ptr M01_L10
M01_L18:
       mov       rdx,7FFAAB5D3308
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
       jmp       short M01_L20
M01_L19:
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        short M01_L18
M01_L20:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [7FFAAB13FAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+48]
       mov       [rdi+20],ecx
M01_L21:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       r15,[rdx]
       cmp       qword ptr [r15+58],0
       je        short M01_L23
       mov       rcx,[r15+58]
       jmp       short M01_L24
M01_L23:
       mov       rdx,7FFAAB5D3298
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FFAAB131780]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FFAAAFA16B0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFAAAF4FF90]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB44F570]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L08
M01_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 849
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M02_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L00:
       xor       esi,esi
       mov       r11,7FFAAAB20A78
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB20A80
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB20A80
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L01
M02_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 98
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFA986D04A8
       call      qword ptr [7FFA986D04A8]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA986D04B0
       call      qword ptr [7FFA986D04B0]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFA986D04B0
       call      qword ptr [7FFA986D04B0]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB181060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4C19A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFAAAB30A70
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB30A78
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB30A78
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 98
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFA986A0480
       call      qword ptr [7FFA986A0480]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA986A0488
       call      qword ptr [7FFA986A0488]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFA986A0488
       call      qword ptr [7FFA986A0488]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB171060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4A16A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFAAAB20A78
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB20A80
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB20A80
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 98
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFA986A0480
       call      qword ptr [7FFA986A0480]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA986A0488
       call      qword ptr [7FFA986A0488]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFA986A0488
       call      qword ptr [7FFA986A0488]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB151060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB481F18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFAAAB00A78
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB00A80
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB00A80
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 98
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFA986A0480
       call      qword ptr [7FFA986A0480]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA986A0488
       call      qword ptr [7FFA986A0488]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFA986A0488
       call      qword ptr [7FFA986A0488]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB151060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4816A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFAAAB00A78
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB00A80
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB00A80
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 98
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFA986A0480
       call      qword ptr [7FFA986A0480]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA986A0488
       call      qword ptr [7FFA986A0488]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFA986A0488
       call      qword ptr [7FFA986A0488]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB171060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4A3270]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFAAAB20A78
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB20A80
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB20A80
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 98
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFA986B0480
       call      qword ptr [7FFA986B0480]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA986B0488
       call      qword ptr [7FFA986B0488]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFA986B0488
       call      qword ptr [7FFA986B0488]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB151060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4839A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFAAAB00A78
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB00A80
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB00A80
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 98
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFA986B0480
       call      qword ptr [7FFA986B0480]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA986B0488
       call      qword ptr [7FFA986B0488]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFA986B0488
       call      qword ptr [7FFA986B0488]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB151060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4816A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFAAAB00A78
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB00A80
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB00A80
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 98
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

