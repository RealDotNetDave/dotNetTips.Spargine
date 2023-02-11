## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2AA92567780
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2AA92567778
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2AA92567780
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
       mov       [rax+54],bl
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
       mov       rdx,7FF80ED17F28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FF80E680928
       call      qword ptr [7FF80E680928]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FF80ED18000
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
       mov       r11,7FF80E680928
       call      qword ptr [7FF80E680928]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FF80E680930
       call      qword ptr [7FF80E680930]
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
       mov       r11,7FF80E680930
       call      qword ptr [7FF80E680930]
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1EA1F806788
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1EA1F806780
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF8079AE330
       mov       [rbx+18],rdx
       mov       rcx,1EA1F806788
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
       call      qword ptr [7FF8079A12E8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+54],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 160
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
       je        near ptr M01_L08
       test      rsi,rsi
       je        near ptr M01_L09
       mov       r14,[rdi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FF8079BC470
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FF807160870
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L06
M01_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FF8079BC548
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M01_L05
       mov       rcx,[rbp-38]
       mov       r11,7FF807160870
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L06
M01_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FF807160878
       call      qword ptr [r11]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L07:
       mov       rcx,rsp
       call      M01_L10
       nop
       mov       eax,[rbp-2C]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L08:
       mov       ecx,10
       call      qword ptr [7FF80756B780]
       int       3
M01_L09:
       mov       ecx,0C
       call      qword ptr [7FF80756B780]
       int       3
M01_L10:
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
       je        short M01_L11
       mov       r11,7FF807160878
       call      qword ptr [r11]
M01_L11:
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2B3EDDA7780
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2B3EDDA7778
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2B3EDDA7780
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
       mov       [rax+54],bl
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
       mov       rdx,7FF80ED17F58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FF80E680928
       call      qword ptr [7FF80E680928]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FF80ED18030
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
       mov       r11,7FF80E680928
       call      qword ptr [7FF80E680928]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FF80E680930
       call      qword ptr [7FF80E680930]
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
       mov       r11,7FF80E680930
       call      qword ptr [7FF80E680930]
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,21380006788
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,21380006780
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF7E15EEFD8
       mov       [rbx+18],rdx
       mov       rcx,21380006788
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
       call      qword ptr [7FF7E15E1990]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+54],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 160
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
       je        near ptr M01_L08
       test      rsi,rsi
       je        near ptr M01_L09
       mov       r14,[rdi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FF7E15FC488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FF7E0DA0870
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L06
M01_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FF7E15FC560
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M01_L05
       mov       rcx,[rbp-38]
       mov       r11,7FF7E0DA0870
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L06
M01_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FF7E0DA0878
       call      qword ptr [r11]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L07:
       mov       rcx,rsp
       call      M01_L10
       nop
       mov       eax,[rbp-2C]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L08:
       mov       ecx,10
       call      qword ptr [7FF7E11AB780]
       int       3
M01_L09:
       mov       ecx,0C
       call      qword ptr [7FF7E11AB780]
       int       3
M01_L10:
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
       je        short M01_L11
       mov       r11,7FF7E0DA0878
       call      qword ptr [r11]
M01_L11:
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1A3CD805788
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1A3CD805780
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1A3CD805788
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
       mov       [rax+54],bl
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
       mov       rdx,7FF80ECE7F58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FF80E650928
       call      qword ptr [7FF80E650928]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FF80ECE8030
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
       mov       r11,7FF80E650928
       call      qword ptr [7FF80E650928]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FF80E650930
       call      qword ptr [7FF80E650930]
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
       mov       r11,7FF80E650930
       call      qword ptr [7FF80E650930]
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,209C3006788
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,209C3006780
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF8079D0330
       mov       [rbx+18],rdx
       mov       rcx,209C3006788
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
       call      qword ptr [7FF8079A1990]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+54],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 160
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
       je        near ptr M01_L08
       test      rsi,rsi
       je        near ptr M01_L09
       mov       r14,[rdi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FF8079BC488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FF807160870
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L06
M01_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FF8079BC560
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M01_L05
       mov       rcx,[rbp-38]
       mov       r11,7FF807160870
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L06
M01_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FF807160878
       call      qword ptr [r11]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L07:
       mov       rcx,rsp
       call      M01_L10
       nop
       mov       eax,[rbp-2C]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L08:
       mov       ecx,10
       call      qword ptr [7FF80756B780]
       int       3
M01_L09:
       mov       ecx,0C
       call      qword ptr [7FF80756B780]
       int       3
M01_L10:
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
       je        short M01_L11
       mov       r11,7FF807160878
       call      qword ptr [r11]
M01_L11:
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1C2B1F17780
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1C2B1F17778
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1C2B1F17780
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
       mov       [rax+54],bl
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
       mov       rdx,7FF80ED27F58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FF80E690928
       call      qword ptr [7FF80E690928]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FF80ED28030
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
       mov       r11,7FF80E690928
       call      qword ptr [7FF80E690928]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FF80E690930
       call      qword ptr [7FF80E690930]
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
       mov       r11,7FF80E690930
       call      qword ptr [7FF80E690930]
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1F44B406788
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1F44B406780
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF8079D0330
       mov       [rbx+18],rdx
       mov       rcx,1F44B406788
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
       call      qword ptr [7FF8079A1990]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+54],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 160
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
       je        near ptr M01_L08
       test      rsi,rsi
       je        near ptr M01_L09
       mov       r14,[rdi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FF8079BC488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FF807160870
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L06
M01_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FF8079BC560
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M01_L05
       mov       rcx,[rbp-38]
       mov       r11,7FF807160870
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L06
M01_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FF807160878
       call      qword ptr [r11]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L07:
       mov       rcx,rsp
       call      M01_L10
       nop
       mov       eax,[rbp-2C]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L08:
       mov       ecx,10
       call      qword ptr [7FF80756B780]
       int       3
M01_L09:
       mov       ecx,0C
       call      qword ptr [7FF80756B780]
       int       3
M01_L10:
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
       je        short M01_L11
       mov       r11,7FF807160878
       call      qword ptr [r11]
M01_L11:
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,19BBED37780
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,19BBED37778
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,19BBED37780
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
       mov       [rax+54],bl
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
       mov       rdx,7FF80ECF7F58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FF80E660928
       call      qword ptr [7FF80E660928]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FF80ECF8030
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
       mov       r11,7FF80E660928
       call      qword ptr [7FF80E660928]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FF80E660930
       call      qword ptr [7FF80E660930]
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
       mov       r11,7FF80E660930
       call      qword ptr [7FF80E660930]
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,27C69806788
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,27C69806780
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF8079AE8A0
       mov       [rbx+18],rdx
       mov       rcx,27C69806788
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
       call      qword ptr [7FF8079A12E8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+54],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 160
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
       je        near ptr M01_L08
       test      rsi,rsi
       je        near ptr M01_L09
       mov       r14,[rdi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FF8079BC488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FF807160870
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L06
M01_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FF8079BC560
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M01_L05
       mov       rcx,[rbp-38]
       mov       r11,7FF807160870
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L06
M01_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FF807160878
       call      qword ptr [r11]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L07:
       mov       rcx,rsp
       call      M01_L10
       nop
       mov       eax,[rbp-2C]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L08:
       mov       ecx,10
       call      qword ptr [7FF80756B780]
       int       3
M01_L09:
       mov       ecx,0C
       call      qword ptr [7FF80756B780]
       int       3
M01_L10:
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
       je        short M01_L11
       mov       r11,7FF807160878
       call      qword ptr [r11]
M01_L11:
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1C14FFF7780
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1C14FFF7778
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1C14FFF7780
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
       mov       [rax+54],bl
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
       mov       rdx,7FF80ED07F58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FF80E670928
       call      qword ptr [7FF80E670928]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FF80ED08030
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
       mov       r11,7FF80E670928
       call      qword ptr [7FF80E670928]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FF80E670930
       call      qword ptr [7FF80E670930]
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
       mov       r11,7FF80E670930
       call      qword ptr [7FF80E670930]
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1FD9D806788
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1FD9D806780
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF8079CEFD8
       mov       [rbx+18],rdx
       mov       rcx,1FD9D806788
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
       call      qword ptr [7FF8079C1990]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+54],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 160
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
       je        near ptr M01_L08
       test      rsi,rsi
       je        near ptr M01_L09
       mov       r14,[rdi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FF8079DC488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FF807180870
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L06
M01_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FF8079DC560
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M01_L05
       mov       rcx,[rbp-38]
       mov       r11,7FF807180870
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L06
M01_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FF807180878
       call      qword ptr [r11]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L07:
       mov       rcx,rsp
       call      M01_L10
       nop
       mov       eax,[rbp-2C]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L08:
       mov       ecx,10
       call      qword ptr [7FF80758B780]
       int       3
M01_L09:
       mov       ecx,0C
       call      qword ptr [7FF80758B780]
       int       3
M01_L10:
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
       je        short M01_L11
       mov       r11,7FF807180878
       call      qword ptr [r11]
M01_L11:
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,213D3FB7780
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,213D3FB7778
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,213D3FB7780
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
       mov       [rax+54],bl
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
       mov       rdx,7FF80ECE7F58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FF80E650928
       call      qword ptr [7FF80E650928]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FF80ECE8030
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
       mov       r11,7FF80E650928
       call      qword ptr [7FF80E650928]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FF80E650930
       call      qword ptr [7FF80E650930]
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
       mov       r11,7FF80E650930
       call      qword ptr [7FF80E650930]
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1C85E406788
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1C85E406780
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF8079D0330
       mov       [rbx+18],rdx
       mov       rcx,1C85E406788
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
       call      qword ptr [7FF8079A1990]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+54],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 160
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
       je        near ptr M01_L08
       test      rsi,rsi
       je        near ptr M01_L09
       mov       r14,[rdi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FF8079BC488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FF807160870
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L06
M01_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FF8079BC560
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M01_L05
       mov       rcx,[rbp-38]
       mov       r11,7FF807160870
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L06
M01_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FF807160878
       call      qword ptr [r11]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L07:
       mov       rcx,rsp
       call      M01_L10
       nop
       mov       eax,[rbp-2C]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L08:
       mov       ecx,10
       call      qword ptr [7FF80756B780]
       int       3
M01_L09:
       mov       ecx,0C
       call      qword ptr [7FF80756B780]
       int       3
M01_L10:
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
       je        short M01_L11
       mov       r11,7FF807160878
       call      qword ptr [r11]
M01_L11:
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1FB418F7780
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1FB418F7778
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1FB418F7780
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
       mov       [rax+54],bl
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
       mov       rdx,7FF80ECF7F58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FF80E660928
       call      qword ptr [7FF80E660928]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FF80ECF8030
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
       mov       r11,7FF80E660928
       call      qword ptr [7FF80E660928]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FF80E660930
       call      qword ptr [7FF80E660930]
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
       mov       r11,7FF80E660930
       call      qword ptr [7FF80E660930]
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1CF61C06788
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1CF61C06780
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF8079AE8A0
       mov       [rbx+18],rdx
       mov       rcx,1CF61C06788
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
       call      qword ptr [7FF8079A12E8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+54],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 160
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
       je        near ptr M01_L08
       test      rsi,rsi
       je        near ptr M01_L09
       mov       r14,[rdi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FF8079BC488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FF807160870
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L06
M01_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FF8079BC560
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M01_L05
       mov       rcx,[rbp-38]
       mov       r11,7FF807160870
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L06
M01_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FF807160878
       call      qword ptr [r11]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L07:
       mov       rcx,rsp
       call      M01_L10
       nop
       mov       eax,[rbp-2C]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L08:
       mov       ecx,10
       call      qword ptr [7FF80756B780]
       int       3
M01_L09:
       mov       ecx,0C
       call      qword ptr [7FF80756B780]
       int       3
M01_L10:
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
       je        short M01_L11
       mov       r11,7FF807160878
       call      qword ptr [r11]
M01_L11:
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,211902C7780
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,211902C7778
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,211902C7780
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
       mov       [rax+54],bl
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
       mov       rdx,7FF80ED07F58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FF80E670928
       call      qword ptr [7FF80E670928]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FF80ED08030
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
       mov       r11,7FF80E670928
       call      qword ptr [7FF80E670928]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FF80E670930
       call      qword ptr [7FF80E670930]
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
       mov       r11,7FF80E670930
       call      qword ptr [7FF80E670930]
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,20A22806788
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,20A22806780
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FF80799E8A0
       mov       [rbx+18],rdx
       mov       rcx,20A22806788
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
       call      qword ptr [7FF8079912E8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+54],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 160
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
       je        near ptr M01_L08
       test      rsi,rsi
       je        near ptr M01_L09
       mov       r14,[rdi+10]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FF8079AC4A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FF807150870
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L06
M01_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FF8079AC580
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L04:
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M01_L05
       mov       rcx,[rbp-38]
       mov       r11,7FF807150870
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L06
M01_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FF807150878
       call      qword ptr [r11]
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L07:
       mov       rcx,rsp
       call      M01_L10
       nop
       mov       eax,[rbp-2C]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L08:
       mov       ecx,10
       call      qword ptr [7FF80755B780]
       int       3
M01_L09:
       mov       ecx,0C
       call      qword ptr [7FF80755B780]
       int       3
M01_L10:
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
       je        short M01_L11
       mov       r11,7FF807150878
       call      qword ptr [r11]
M01_L11:
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

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       r8,1F002563000
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
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FF80ED3C900
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
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr M01_L21
       jmp       near ptr M01_L22
M01_L04:
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FF80ED3C9C8
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
       mov       rdx,7FF80ED3C990
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
       mov       r11,[r15+70]
       test      r11,r11
       je        short M01_L12
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FF80ED3C9B0
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
       mov       r11,[r15+70]
       test      r11,r11
       je        short M01_L16
       mov       rax,[rsp+30]
       jmp       short M01_L17
M01_L16:
       mov       rdx,7FF80ED3C9B0
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
       mov       r15,[r15+58]
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
       mov       rdx,7FF80ED3C940
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
       mov       r12,[r15+68]
       test      r12,r12
       je        near ptr M01_L09
       mov       rax,r12
       jmp       near ptr M01_L10
M01_L23:
       mov       rdx,7FF80ED3C900
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
       cmp       qword ptr [r15+50],0
       je        short M01_L28
       mov       rcx,[r15+50]
       jmp       short M01_L29
M01_L28:
       mov       rdx,7FF80ED3C850
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
       mov       rdx,7FF80E8FAFC0
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
; Total bytes of code 1076
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
       mov       r11,7FF80E6908C0
       call      qword ptr [7FF80E6908C0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF80E6908C8
       call      qword ptr [7FF80E6908C8]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FF80E6908C8
       call      qword ptr [7FF80E6908C8]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       r8,202F3407FB8
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FF8076FF708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FF807731060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8079D5018]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FF807A164A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF8072FB828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       short M01_L04
M01_L03:
       mov       rcx,r14
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr M01_L16
       jmp       near ptr M01_L17
M01_L04:
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FF807A16570
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FF8076FFAB0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
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
       mov       rdx,7FF807A16538
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FF80797B438]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       r11,[r15+70]
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
       mov       rdx,7FF807A16558
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
       mov       rdx,7FF807A164E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF80797B408]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       mov       rbp,rax
       cmp       dword ptr [rsp+48],0
       jle       short M01_L21
       mov       rsi,[rdi+10]
       mov       rcx,r14
       mov       ebx,[rsp+48]
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        near ptr M01_L09
       jmp       near ptr M01_L10
M01_L18:
       mov       rdx,7FF807A164A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
       jmp       short M01_L20
M01_L19:
       mov       [rsp+48],r12d
       mov       rcx,r14
       mov       r14d,[rsp+48]
       dec       r14d
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short M01_L18
M01_L20:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,r14d
       xor       r8d,r8d
       call      qword ptr [7FF8076FFAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       cmp       qword ptr [r15+50],0
       je        short M01_L23
       mov       rcx,[r15+50]
       jmp       short M01_L24
M01_L23:
       mov       rdx,7FF807A163F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FF8076F1780]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FF807546BC0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF8074FFF90]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF80797F570]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L08
M01_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 846
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
       mov       r11,7FF807150870
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF807150878
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FF807150878
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       r8,28951833000
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
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FF80ED09970
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
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr M01_L21
       jmp       near ptr M01_L22
M01_L04:
       mov       rcx,r14
       mov       rax,[r15+88]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FF80ED09A38
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
       mov       rdx,7FF80ED09A00
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
       mov       r11,[r15+80]
       test      r11,r11
       je        short M01_L12
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FF80ED09A20
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
       mov       r11,[r15+80]
       test      r11,r11
       je        short M01_L16
       mov       rax,[rsp+30]
       jmp       short M01_L17
M01_L16:
       mov       rdx,7FF80ED09A20
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
       mov       r15,[r15+68]
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
       mov       rdx,7FF80ED099B0
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
       mov       r12,[r15+78]
       test      r12,r12
       je        near ptr M01_L09
       mov       rax,r12
       jmp       near ptr M01_L10
M01_L23:
       mov       rdx,7FF80ED09970
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
       cmp       qword ptr [r15+60],0
       je        short M01_L28
       mov       rcx,[r15+60]
       jmp       short M01_L29
M01_L28:
       mov       rdx,7FF80ED098C0
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
       mov       rdx,7FF80E8DAFC0
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
; Total bytes of code 1085
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
       mov       r11,7FF80E6708C0
       call      qword ptr [7FF80E6708C0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF80E6708C8
       call      qword ptr [7FF80E6708C8]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FF80E6708C8
       call      qword ptr [7FF80E6708C8]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       r8,202BAC07FB8
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FF7E12FF708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FF7E1331060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF7E15D5018]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF7E15BDF90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF7E0F0B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FF7E15BE058
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FF7E12FFAB0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
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
       mov       rdx,7FF7E15BE020
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FF7E157B438]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF7E15BE040
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
       mov       rdx,7FF7E15BDFD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF7E157B408]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FF7E15BDF90
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
       call      qword ptr [7FF7E12FFAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FF7E15BDED8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FF7E12F1780]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FF7E1156BC0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF7E110FF90]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF7E157F570]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       r11,7FF7E0D60870
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF7E0D60878
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FF7E0D60878
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       r8,1DD4B6D3000
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
       mov       rdx,[r15+58]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FF80ED1C710
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
       mov       rdx,[r15+60]
       test      rdx,rdx
       je        near ptr M01_L21
       jmp       near ptr M01_L22
M01_L04:
       mov       rcx,r14
       mov       rax,[r15+78]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FF80ED1C898
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
       mov       rdx,7FF80ED1C7A0
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
       mov       r11,[r15+70]
       test      r11,r11
       je        short M01_L12
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FF80ED1C7C0
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
       mov       r11,[r15+70]
       test      r11,r11
       je        short M01_L16
       mov       rax,[rsp+30]
       jmp       short M01_L17
M01_L16:
       mov       rdx,7FF80ED1C7C0
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
       mov       r15,[r15+58]
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
       mov       rdx,7FF80ED1C750
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
       mov       r12,[r15+68]
       test      r12,r12
       je        near ptr M01_L09
       mov       rax,r12
       jmp       near ptr M01_L10
M01_L23:
       mov       rdx,7FF80ED1C710
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
       cmp       qword ptr [r15+80],0
       je        short M01_L28
       mov       rcx,[r15+80]
       jmp       short M01_L29
M01_L28:
       mov       rdx,7FF80ED1CA80
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
       mov       rdx,7FF80E8DAFC0
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
; Total bytes of code 1082
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
       mov       r11,7FF80E6708C0
       call      qword ptr [7FF80E6708C0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF80E6708C8
       call      qword ptr [7FF80E6708C8]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FF80E6708C8
       call      qword ptr [7FF80E6708C8]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       r8,16E46007FB8
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FF8076FF708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FF807731060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8079D5018]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF8079BDF90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF80730B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FF8079BE058
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FF8076FFAB0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
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
       mov       rdx,7FF8079BE020
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FF80796B438]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF8079BE040
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
       mov       rdx,7FF8079BDFD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF80796B408]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FF8079BDF90
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
       call      qword ptr [7FF8076FFAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FF8079BDED8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FF8076F1780]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FF807556BC0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80750FF90]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF80796F570]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       r11,7FF807160870
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF807160878
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FF807160878
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       r8,24F3CD23000
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
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FF80ECF9970
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
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr M01_L21
       jmp       near ptr M01_L22
M01_L04:
       mov       rcx,r14
       mov       rax,[r15+88]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FF80ECF9A38
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
       mov       rdx,7FF80ECF9A00
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
       mov       r11,[r15+80]
       test      r11,r11
       je        short M01_L12
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FF80ECF9A20
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
       mov       r11,[r15+80]
       test      r11,r11
       je        short M01_L16
       mov       rax,[rsp+30]
       jmp       short M01_L17
M01_L16:
       mov       rdx,7FF80ECF9A20
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
       mov       r15,[r15+68]
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
       mov       rdx,7FF80ECF99B0
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
       mov       r12,[r15+78]
       test      r12,r12
       je        near ptr M01_L09
       mov       rax,r12
       jmp       near ptr M01_L10
M01_L23:
       mov       rdx,7FF80ECF9970
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
       cmp       qword ptr [r15+60],0
       je        short M01_L28
       mov       rcx,[r15+60]
       jmp       short M01_L29
M01_L28:
       mov       rdx,7FF80ECF98C0
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
       mov       rdx,7FF80E8CAFC0
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
; Total bytes of code 1085
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
       mov       r11,7FF80E6608C0
       call      qword ptr [7FF80E6608C0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF80E6608C8
       call      qword ptr [7FF80E6608C8]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FF80E6608C8
       call      qword ptr [7FF80E6608C8]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       r8,23BB7807FB8
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FF80770F708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FF807741060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8079E3438]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF8079CDF90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF80731B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FF8079CE058
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FF80770FAB0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
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
       mov       rdx,7FF8079CE020
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FF807989D08]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF8079CE040
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
       mov       rdx,7FF8079CDFD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF807989CD8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FF8079CDF90
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
       call      qword ptr [7FF80770FAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FF8079CDED8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FF807701780]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FF807566BC0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80751FF90]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF80798DEB8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       r11,7FF807170870
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF807170878
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FF807170878
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       r8,18364743000
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
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FF80ED19970
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
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr M01_L21
       jmp       near ptr M01_L22
M01_L04:
       mov       rcx,r14
       mov       rax,[r15+88]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FF80ED19A38
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
       mov       rdx,7FF80ED19A00
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
       mov       r11,[r15+80]
       test      r11,r11
       je        short M01_L12
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FF80ED19A20
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
       mov       r11,[r15+80]
       test      r11,r11
       je        short M01_L16
       mov       rax,[rsp+30]
       jmp       short M01_L17
M01_L16:
       mov       rdx,7FF80ED19A20
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
       mov       r15,[r15+68]
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
       mov       rdx,7FF80ED199B0
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
       mov       r12,[r15+78]
       test      r12,r12
       je        near ptr M01_L09
       mov       rax,r12
       jmp       near ptr M01_L10
M01_L23:
       mov       rdx,7FF80ED19970
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
       cmp       qword ptr [r15+60],0
       je        short M01_L28
       mov       rcx,[r15+60]
       jmp       short M01_L29
M01_L28:
       mov       rdx,7FF80ED198C0
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
       mov       rdx,7FF80E8EAFC0
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
; Total bytes of code 1085
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
       mov       r11,7FF80E6808C0
       call      qword ptr [7FF80E6808C0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF80E6808C8
       call      qword ptr [7FF80E6808C8]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FF80E6808C8
       call      qword ptr [7FF80E6808C8]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       r8,218B9007FB8
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FF8076EF708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FF807721060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8079C3D38]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF8079ADF90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF8072FB828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FF8079AE058
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FF8076EFAB0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
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
       mov       rdx,7FF8079AE020
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FF80796B438]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF8079AE040
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
       mov       rdx,7FF8079ADFD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF80796B408]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FF8079ADF90
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
       call      qword ptr [7FF8076EFAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FF8079ADED8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FF8076E1780]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FF807546BC0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF8074FFF90]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF80796F570]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       r11,7FF807150870
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF807150878
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FF807150878
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       r8,25AB6BA3000
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
       mov       rdx,7FF80ED18DB8
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
       mov       rdx,7FF80ED18E80
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
       mov       rdx,7FF80ED18E48
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
       mov       rdx,7FF80ED18E68
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
       mov       rdx,7FF80ED18E68
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
       mov       rdx,7FF80ED18DF8
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
       mov       rdx,7FF80ED18DB8
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
       mov       rdx,7FF80ED18D08
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
       mov       rdx,7FF80E8EAFC0
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
       mov       r11,7FF80E6808C0
       call      qword ptr [7FF80E6808C0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF80E6808C8
       call      qword ptr [7FF80E6808C8]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FF80E6808C8
       call      qword ptr [7FF80E6808C8]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       r8,1FCC8405FC0
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FF8076DF708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FF807711060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8079B3D38]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF80799DFD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF8072EB828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FF80799E0A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FF8076DFAB0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
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
       mov       rdx,7FF80799E068
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FF80795B438]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF80799E088
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
       mov       rdx,7FF80799E018
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF80795B408]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FF80799DFD8
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
       call      qword ptr [7FF8076DFAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FF80799DF20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FF8076D1780]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FF807536BC0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF8074EFF90]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF80795F570]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       r11,7FF807140870
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF807140878
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FF807140878
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       r8,2BEF5DC3000
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
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FF80ED09970
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
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr M01_L21
       jmp       near ptr M01_L22
M01_L04:
       mov       rcx,r14
       mov       rax,[r15+88]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FF80ED09A38
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
       mov       rdx,7FF80ED09A00
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
       mov       r11,[r15+80]
       test      r11,r11
       je        short M01_L12
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FF80ED09A20
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
       mov       r11,[r15+80]
       test      r11,r11
       je        short M01_L16
       mov       rax,[rsp+30]
       jmp       short M01_L17
M01_L16:
       mov       rdx,7FF80ED09A20
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
       mov       r15,[r15+68]
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
       mov       rdx,7FF80ED099B0
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
       mov       r12,[r15+78]
       test      r12,r12
       je        near ptr M01_L09
       mov       rax,r12
       jmp       near ptr M01_L10
M01_L23:
       mov       rdx,7FF80ED09970
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
       cmp       qword ptr [r15+60],0
       je        short M01_L28
       mov       rcx,[r15+60]
       jmp       short M01_L29
M01_L28:
       mov       rdx,7FF80ED098C0
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
       mov       rdx,7FF80E8DAFC0
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
; Total bytes of code 1085
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
       mov       r11,7FF80E6708C0
       call      qword ptr [7FF80E6708C0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF80E6708C8
       call      qword ptr [7FF80E6708C8]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FF80E6708C8
       call      qword ptr [7FF80E6708C8]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       r8,1FF1AC07FB8
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FF8076DF708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FF807711060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8079B5018]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF80799DFD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF8072EB828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FF80799E0A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FF8076DFAB0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
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
       mov       rdx,7FF80799E068
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FF80795B438]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF80799E088
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
       mov       rdx,7FF80799E018
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF80795B408]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FF80799DFD8
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
       call      qword ptr [7FF8076DFAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FF80799DF20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FF8076D1780]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FF807536BC0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF8074EFF90]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF80795F570]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       r11,7FF807140870
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF807140878
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FF807140878
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       r8,1C9BD253000
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
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FF80ED09970
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
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr M01_L21
       jmp       near ptr M01_L22
M01_L04:
       mov       rcx,r14
       mov       rax,[r15+88]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FF80ED09A38
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
       mov       rdx,7FF80ED09A00
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
       mov       r11,[r15+80]
       test      r11,r11
       je        short M01_L12
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FF80ED09A20
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
       mov       r11,[r15+80]
       test      r11,r11
       je        short M01_L16
       mov       rax,[rsp+30]
       jmp       short M01_L17
M01_L16:
       mov       rdx,7FF80ED09A20
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
       mov       r15,[r15+68]
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
       mov       rdx,7FF80ED099B0
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
       mov       r12,[r15+78]
       test      r12,r12
       je        near ptr M01_L09
       mov       rax,r12
       jmp       near ptr M01_L10
M01_L23:
       mov       rdx,7FF80ED09970
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
       cmp       qword ptr [r15+60],0
       je        short M01_L28
       mov       rcx,[r15+60]
       jmp       short M01_L29
M01_L28:
       mov       rdx,7FF80ED098C0
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
       mov       rdx,7FF80E8DAFC0
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
; Total bytes of code 1085
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
       mov       r11,7FF80E6708C0
       call      qword ptr [7FF80E6708C0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF80E6708C8
       call      qword ptr [7FF80E6708C8]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FF80E6708C8
       call      qword ptr [7FF80E6708C8]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       r8,1AD62C07FB8
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FF8076DF708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FF807711060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8079B3D38]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF80799DFD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF8072EB828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FF80799E0A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FF8076DFAB0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
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
       mov       rdx,7FF80799E068
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FF80795B438]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF80799E088
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
       mov       rdx,7FF80799E018
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF80795B408]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FF80799DFD8
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
       call      qword ptr [7FF8076DFAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FF80799DF20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FF8076D1780]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FF807536BC0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF8074EFF90]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF80795F570]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       r11,7FF807140870
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF807140878
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FF807140878
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       r8,186F2A43000
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
       mov       rdx,[r15+68]
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FF80ED09970
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
       mov       rdx,[r15+70]
       test      rdx,rdx
       je        near ptr M01_L21
       jmp       near ptr M01_L22
M01_L04:
       mov       rcx,r14
       mov       rax,[r15+88]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rdx,7FF80ED09A38
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
       mov       rdx,7FF80ED09A00
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
       mov       r11,[r15+80]
       test      r11,r11
       je        short M01_L12
       mov       r8,[rsp+30]
       mov       r9,[rsp+28]
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FF80ED09A20
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
       mov       r11,[r15+80]
       test      r11,r11
       je        short M01_L16
       mov       rax,[rsp+30]
       jmp       short M01_L17
M01_L16:
       mov       rdx,7FF80ED09A20
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
       mov       r15,[r15+68]
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
       mov       rdx,7FF80ED099B0
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
       mov       r12,[r15+78]
       test      r12,r12
       je        near ptr M01_L09
       mov       rax,r12
       jmp       near ptr M01_L10
M01_L23:
       mov       rdx,7FF80ED09970
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
       cmp       qword ptr [r15+60],0
       je        short M01_L28
       mov       rcx,[r15+60]
       jmp       short M01_L29
M01_L28:
       mov       rdx,7FF80ED09908
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
       mov       rdx,7FF80E8DAFC0
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
; Total bytes of code 1085
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
       mov       r11,7FF80E6708C0
       call      qword ptr [7FF80E6708C0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF80E6708C8
       call      qword ptr [7FF80E6708C8]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FF80E6708C8
       call      qword ptr [7FF80E6708C8]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       mov       r8,13C2C407FB8
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FF8076EF708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FF807721060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8079C3D38]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FF8079ADFE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF8072FB828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FF8079AE0B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FF8076EFAB0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
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
       mov       rdx,7FF8079AE078
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FF80796B438]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FF8079AE098
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
       mov       rdx,7FF8079AE028
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF80796B408]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FF8079ADFE8
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
       call      qword ptr [7FF8076EFAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FF8079ADF30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FF8076E1780]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FF807546BC0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF8074FFF90]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF80796F570]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       r11,7FF807150870
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF807150878
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FF807150878
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       r11,7FF80E6708C0
       call      qword ptr [7FF80E6708C0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF80E6708C8
       call      qword ptr [7FF80E6708C8]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FF80E6708C8
       call      qword ptr [7FF80E6708C8]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF807741060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8079BFF18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FF807170870
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF807170878
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FF807170878
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       r11,7FF80E6508C0
       call      qword ptr [7FF80E6508C0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF80E6508C8
       call      qword ptr [7FF80E6508C8]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FF80E6508C8
       call      qword ptr [7FF80E6508C8]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF7E1341060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF7E15E16A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FF7E0D70870
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF7E0D70878
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FF7E0D70878
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       r11,7FF80E6808C0
       call      qword ptr [7FF80E6808C0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF80E6808C8
       call      qword ptr [7FF80E6808C8]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FF80E6808C8
       call      qword ptr [7FF80E6808C8]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF807731060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8079D19A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FF807160870
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF807160878
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FF807160878
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       r11,7FF80E6708C0
       call      qword ptr [7FF80E6708C0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF80E6708C8
       call      qword ptr [7FF80E6708C8]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FF80E6708C8
       call      qword ptr [7FF80E6708C8]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF807711060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF80798FF18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FF807140870
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF807140878
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FF807140878
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       r11,7FF80E6608C0
       call      qword ptr [7FF80E6608C0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF80E6608C8
       call      qword ptr [7FF80E6608C8]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FF80E6608C8
       call      qword ptr [7FF80E6608C8]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF807721060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8079C19A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FF807150870
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF807150878
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FF807150878
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       r11,7FF80E6908C0
       call      qword ptr [7FF80E6908C0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF80E6908C8
       call      qword ptr [7FF80E6908C8]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FF80E6908C8
       call      qword ptr [7FF80E6908C8]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF807731060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8079D16A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FF807160870
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF807160878
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FF807160878
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       r11,7FF80E6708C0
       call      qword ptr [7FF80E6708C0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF80E6708C8
       call      qword ptr [7FF80E6708C8]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FF80E6708C8
       call      qword ptr [7FF80E6708C8]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF807731060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8079D16A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FF807160870
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF807160878
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FF807160878
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       r11,7FF80E6708C0
       call      qword ptr [7FF80E6708C0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF80E6708C8
       call      qword ptr [7FF80E6708C8]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FF80E6708C8
       call      qword ptr [7FF80E6708C8]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF807711060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8079B16A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FF807140870
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF807140878
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FF807140878
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       r11,7FF80E6608C0
       call      qword ptr [7FF80E6608C0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF80E6608C8
       call      qword ptr [7FF80E6608C8]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FF80E6608C8
       call      qword ptr [7FF80E6608C8]
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FF807721060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8079C19A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FF807150870
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FF807150878
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FF807150878
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
       mov       [rcx+54],al
       ret
; Total bytes of code 7
```

