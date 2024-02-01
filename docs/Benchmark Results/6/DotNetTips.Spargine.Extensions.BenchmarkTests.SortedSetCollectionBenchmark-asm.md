## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1B827197860
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1B827197858
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1B827197860
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
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
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
       mov       rdx,7FFF9146A390
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFF90CA0B50
       call      qword ptr [7FFF90CA0B50]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFF9146A468
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
       mov       r11,7FFF90CA0B50
       call      qword ptr [7FFF90CA0B50]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFF90CA0B58
       call      qword ptr [7FFF90CA0B58]
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
       mov       r11,7FFF90CA0B58
       call      qword ptr [7FFF90CA0B58]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,250A5406868
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,250A5406860
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,250A5406868
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
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      qword ptr [7FFF8FC91990]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,7FFF8FDF2A40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFF8F3C0AB0
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
       mov       rdx,7FFF8FDF2B18
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
       mov       r11,7FFF8F3C0AB0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFF8F3C0AB8
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
       call      qword ptr [7FFF8F7CB780]
       int       3
M02_L09:
       mov       ecx,0C
       call      qword ptr [7FFF8F7CB780]
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
       mov       r11,7FFF8F3C0AB8
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,236DFE97860
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,236DFE97858
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,236DFE97860
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
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
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
       mov       rdx,7FFF9147D6B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFF90CB0B50
       call      qword ptr [7FFF90CB0B50]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFF9147D790
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
       mov       r11,7FFF90CB0B50
       call      qword ptr [7FFF90CB0B50]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFF90CB0B58
       call      qword ptr [7FFF90CB0B58]
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
       mov       r11,7FFF90CB0B58
       call      qword ptr [7FFF90CB0B58]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1B2B9806868
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1B2B9806860
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1B2B9806868
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
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      qword ptr [7FFF8FC83990]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,7FFF8FD0FEE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFF8F3B0AB8
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
       mov       rdx,7FFF8FD0FFC0
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
       mov       r11,7FFF8F3B0AB8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFF8F3B0AC0
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
       call      qword ptr [7FFF8F7BB780]
       int       3
M02_L09:
       mov       ecx,0C
       call      qword ptr [7FFF8F7BB780]
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
       mov       r11,7FFF8F3B0AC0
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1A6B1F37860
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1A6B1F37858
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1A6B1F37860
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
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
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
       mov       rdx,7FFF9147D500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFF90CB0B50
       call      qword ptr [7FFF90CB0B50]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFF9147D5D8
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
       mov       r11,7FFF90CB0B50
       call      qword ptr [7FFF90CB0B50]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFF90CB0B58
       call      qword ptr [7FFF90CB0B58]
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
       mov       r11,7FFF90CB0B58
       call      qword ptr [7FFF90CB0B58]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,294CD006868
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,294CD006860
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,294CD006868
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
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      qword ptr [7FFF8F8A12E8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,7FFF8FA02C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFF8EFD0AB8
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
       mov       rdx,7FFF8FA02CF0
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
       mov       r11,7FFF8EFD0AB8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFF8EFD0AC0
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
       call      qword ptr [7FFF8F3DB780]
       int       3
M02_L09:
       mov       ecx,0C
       call      qword ptr [7FFF8F3DB780]
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
       mov       r11,7FFF8EFD0AC0
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,24089CC7860
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,24089CC7858
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,24089CC7860
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
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
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
       mov       rdx,7FFF9148DEB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFF90CC0B50
       call      qword ptr [7FFF90CC0B50]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFF9148DF88
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
       mov       r11,7FFF90CC0B50
       call      qword ptr [7FFF90CC0B50]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFF90CC0B58
       call      qword ptr [7FFF90CC0B58]
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
       mov       r11,7FFF90CC0B58
       call      qword ptr [7FFF90CC0B58]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,17686806868
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,17686806860
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,17686806868
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
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      qword ptr [7FFF8F8C52E8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,7FFF8FA20E50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFF8EFF0AB8
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
       mov       rdx,7FFF8FA20F28
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
       mov       r11,7FFF8EFF0AB8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFF8EFF0AC0
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
       call      qword ptr [7FFF8F3FB780]
       int       3
M02_L09:
       mov       ecx,0C
       call      qword ptr [7FFF8F3FB780]
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
       mov       r11,7FFF8EFF0AC0
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,16475807860
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,16475807858
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,16475807860
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
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
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
       mov       rdx,7FFF9147D090
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFF90CB0B50
       call      qword ptr [7FFF90CB0B50]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFF9147D168
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
       mov       r11,7FFF90CB0B50
       call      qword ptr [7FFF90CB0B50]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFF90CB0B58
       call      qword ptr [7FFF90CB0B58]
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
       mov       r11,7FFF90CB0B58
       call      qword ptr [7FFF90CB0B58]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,20188C04870
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,20188C04868
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,20188C04870
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
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      qword ptr [7FFF8F8C3990]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,7FFF8F94FEF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFF8EFF0AB8
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
       mov       rdx,7FFF8F94FFD0
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
       mov       r11,7FFF8EFF0AB8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFF8EFF0AC0
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
       call      qword ptr [7FFF8F3FB780]
       int       3
M02_L09:
       mov       ecx,0C
       call      qword ptr [7FFF8F3FB780]
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
       mov       r11,7FFF8EFF0AC0
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1A3689E7860
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1A3689E7858
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1A3689E7860
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
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
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
       mov       rdx,7FFF9148D0D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFF90CC0B50
       call      qword ptr [7FFF90CC0B50]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFF9148D1B0
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
       mov       r11,7FFF90CC0B50
       call      qword ptr [7FFF90CC0B50]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFF90CC0B58
       call      qword ptr [7FFF90CC0B58]
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
       mov       r11,7FFF90CC0B58
       call      qword ptr [7FFF90CC0B58]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1DACCC06868
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1DACCC06860
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1DACCC06868
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
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      qword ptr [7FFF8FC73990]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,7FFF8FCFFEE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFF8F3A0AB8
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
       mov       rdx,7FFF8FCFFFC0
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
       mov       r11,7FFF8F3A0AB8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFF8F3A0AC0
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
       call      qword ptr [7FFF8F7AB780]
       int       3
M02_L09:
       mov       ecx,0C
       call      qword ptr [7FFF8F7AB780]
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
       mov       r11,7FFF8F3A0AC0
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1CC36D37860
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1CC36D37858
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1CC36D37860
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
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
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
       mov       rdx,7FFF9146D648
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFF90CA0B50
       call      qword ptr [7FFF90CA0B50]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFF9146D720
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
       mov       r11,7FFF90CA0B50
       call      qword ptr [7FFF90CA0B50]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFF90CA0B58
       call      qword ptr [7FFF90CA0B58]
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
       mov       r11,7FFF90CA0B58
       call      qword ptr [7FFF90CA0B58]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1D3EC806868
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1D3EC806860
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1D3EC806868
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
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper,Boolean>)
       call      qword ptr [7FFF8FC93990]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,7FFF8FD1FE38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFF8F3C0AB8
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
       mov       rdx,7FFF8FD1FF10
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
       mov       r11,7FFF8F3C0AB8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFF8F3C0AC0
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
       call      qword ptr [7FFF8F7CB780]
       int       3
M02_L09:
       mov       ecx,0C
       call      qword ptr [7FFF8F7CB780]
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
       mov       r11,7FFF8F3C0AC0
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,2C49162BEE0
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
       mov       rdx,7FFF91479928
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
       mov       rdx,7FFF914799F0
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
       mov       rdx,7FFF914799B8
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
       mov       rdx,7FFF914799D8
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
       mov       rdx,7FFF914799D8
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
       mov       rdx,7FFF91479968
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L22:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      00007FFF91246D78
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
       mov       rdx,7FFF91479928
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
       call      00007FFF91015658
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
       mov       rdx,7FFF914798C0
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
       mov       rdx,7FFF90EFC0B8
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
       mov       r11,7FFF90C904B0
       call      qword ptr [7FFF90C904B0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF90C904B8
       call      qword ptr [7FFF90C904B8]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFF90C904B8
       call      qword ptr [7FFF90C904B8]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,222E1808348
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFF8F963048]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FFF8F963720]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FCA3D38]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFF8FD94790
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFF8F53B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FFF8FD94858
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FFF8F9633F0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
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
       mov       rdx,7FFF8FD94820
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFF8FC49450]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFF8FD94840
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
       mov       rdx,7FFF8FD947D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFF8FC49420]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FFF8FD94790
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
       call      qword ptr [7FFF8F963420]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FFF8FD94720
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FFF8F927780]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FFF8F786C90
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F79D960]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC4D570]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       r11,7FFF8F390AC0
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF8F390AC8
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFF8F390AC8
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,21063ADBED8
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
       mov       rdx,7FFF9148EB30
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
       mov       rdx,7FFF9148EBF8
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
       mov       rdx,7FFF9148EBC0
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
       mov       rdx,7FFF9148EBE0
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
       mov       rdx,7FFF9148EBE0
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
       mov       rdx,7FFF9148EB70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L22:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      00007FFF9125EEF0
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
       mov       rdx,7FFF9148EB30
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
       call      00007FFF91035238
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
       mov       rdx,7FFF9148EAC8
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
       mov       rdx,7FFF90F2C0B8
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
       mov       r11,7FFF90CC04B0
       call      qword ptr [7FFF90CC04B0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF90CC04B8
       call      qword ptr [7FFF90CC04B8]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFF90CC04B8
       call      qword ptr [7FFF90CC04B8]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,1D47B008348
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFF8F963048]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FFF8F963720]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FCB5990]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFF8FDD13A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFF8F54B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FFF8FDD1470
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FFF8F9633F0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
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
       mov       rdx,7FFF8FDD1438
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFF8FC5BC90]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFF8FDD1458
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
       mov       rdx,7FFF8FDD13E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFF8FC5BC60]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FFF8FDD13A8
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
       call      qword ptr [7FFF8F963420]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FFF8FDD1338
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FFF8F927780]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FFF8F796C90
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F7AD960]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC5FEB8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       r11,7FFF8F3A0AA8
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF8F3A0AB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFF8F3A0AB0
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,20206BABED8
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
       mov       rdx,7FFF9146DBB8
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
       mov       rdx,7FFF9146DC80
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
       mov       rdx,7FFF9146DC48
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
       mov       rdx,7FFF9146DC68
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
       mov       rdx,7FFF9146DC68
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
       mov       rdx,7FFF9146DBF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L22:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      00007FFF9123F6E0
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
       mov       rdx,7FFF9146DBB8
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
       call      00007FFF91015238
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
       mov       rdx,7FFF9146DB50
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
       mov       rdx,7FFF90F0C0B8
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
       mov       r11,7FFF90CA04B0
       call      qword ptr [7FFF90CA04B0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF90CA04B8
       call      qword ptr [7FFF90CA04B8]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFF90CA04B8
       call      qword ptr [7FFF90CA04B8]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,22CB5808348
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFF8F593048]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FFF8F593720]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8F8E5C60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFF8FA045F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFF8F17B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FFF8FA046B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FFF8F5933F0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
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
       mov       rdx,7FFF8FA04680
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFF8F88B1B0]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFF8FA046A0
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
       mov       rdx,7FFF8FA04630
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFF8F88B180]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FFF8FA045F0
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
       call      qword ptr [7FFF8F593420]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FFF8FA04580
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FFF8F557780]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FFF8F3C6C90
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F3DD960]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8F88F570]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       r11,7FFF8EFD0AA8
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF8EFD0AB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFF8EFD0AB0
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,214F234BED8
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
       mov       rdx,7FFF9146EC30
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
       mov       rdx,7FFF9146ECF8
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
       mov       rdx,7FFF9146ECC0
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
       mov       rdx,7FFF9146ECE0
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
       mov       rdx,7FFF9146ECE0
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
       mov       rdx,7FFF9146EC70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L22:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      00007FFF9123EE50
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
       mov       rdx,7FFF9146EC30
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
       call      00007FFF91015238
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
       mov       rdx,7FFF9146EBC8
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
       mov       rdx,7FFF90F0C0B8
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
       mov       r11,7FFF90CA04B0
       call      qword ptr [7FFF90CA04B0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF90CA04B8
       call      qword ptr [7FFF90CA04B8]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFF90CA04B8
       call      qword ptr [7FFF90CA04B8]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,25B93008348
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFF8F593048]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FFF8F593720]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8F8E5990]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFF8FA02688
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFF8F17B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FFF8FA02750
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FFF8F5933F0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
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
       mov       rdx,7FFF8FA02718
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFF8F88BD20]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFF8FA02738
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
       mov       rdx,7FFF8FA026C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFF8F88BCF0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FFF8FA02688
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
       call      qword ptr [7FFF8F593420]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FFF8FA02618
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FFF8F557780]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FFF8F3C6C90
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F3DD960]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8F88FEB8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       r11,7FFF8EFD0AA8
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF8EFD0AB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFF8EFD0AB0
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,20A333FBED8
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
       mov       rdx,7FFF9148E288
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
       mov       rdx,7FFF9148E350
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
       mov       rdx,7FFF9148E318
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
       mov       rdx,7FFF9148E338
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
       mov       rdx,7FFF9148E338
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
       mov       rdx,7FFF9148E2C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L22:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      00007FFF91260940
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
       mov       rdx,7FFF9148E288
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
       call      00007FFF91035238
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
       mov       rdx,7FFF9148E220
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
       mov       rdx,7FFF90F2C0B8
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
       mov       r11,7FFF90CC04B0
       call      qword ptr [7FFF90CC04B0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF90CC04B8
       call      qword ptr [7FFF90CC04B8]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFF90CC04B8
       call      qword ptr [7FFF90CC04B8]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,178E9C08348
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFF8F5B3048]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FFF8F5B3720]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8F905990]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFF8FA225C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFF8F19B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FFF8FA22688
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FFF8F5B33F0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
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
       mov       rdx,7FFF8FA22650
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFF8F8ABD20]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFF8FA22670
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
       mov       rdx,7FFF8FA22600
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFF8F8ABCF0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FFF8FA225C0
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
       call      qword ptr [7FFF8F5B3420]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FFF8FA22550
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FFF8F577780]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FFF8F3E6C90
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F3FD960]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8F8AFEB8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       r11,7FFF8EFF0AA8
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF8EFF0AB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFF8EFF0AB0
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,2B24F8CBED8
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
       mov       rdx,7FFF9147DFC0
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
       mov       rdx,7FFF9147E088
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
       mov       rdx,7FFF9147E050
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
       mov       rdx,7FFF9147E070
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
       mov       rdx,7FFF9147E070
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
       mov       rdx,7FFF9147E000
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L22:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      00007FFF91250AE0
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
       mov       rdx,7FFF9147DFC0
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
       call      00007FFF91025238
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
       mov       rdx,7FFF9147DF58
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
       mov       rdx,7FFF90F1C0B8
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
       mov       r11,7FFF90CB04B0
       call      qword ptr [7FFF90CB04B0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF90CB04B8
       call      qword ptr [7FFF90CB04B8]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFF90CB04B8
       call      qword ptr [7FFF90CB04B8]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,17C0E408348
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFF8F5A3048]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FFF8F5A3720]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8F8F7990]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFF8FA13698
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFF8F18B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FFF8FA13760
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FFF8F5A33F0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
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
       mov       rdx,7FFF8FA13728
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFF8F89BD20]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFF8FA13748
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
       mov       rdx,7FFF8FA136D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFF8F89BCF0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FFF8FA13698
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
       call      qword ptr [7FFF8F5A3420]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FFF8FA13628
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FFF8F567780]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FFF8F3D6C90
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F3ED960]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8F89FEB8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       r11,7FFF8EFE0AA8
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF8EFE0AB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFF8EFE0AB0
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,2703CAFCEF8
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
       mov       rdx,7FFF9148D780
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
       mov       rdx,7FFF9148D848
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
       mov       rdx,7FFF9148D810
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
       mov       rdx,7FFF9148D830
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
       mov       rdx,7FFF9148D830
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
       mov       rdx,7FFF9148D7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L22:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      00007FFF91262200
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
       mov       rdx,7FFF9148D780
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
       call      00007FFF91035238
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
       mov       rdx,7FFF9148D718
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
       mov       rdx,7FFF90F2C0B8
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
       mov       r11,7FFF90CC04B0
       call      qword ptr [7FFF90CC04B0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF90CC04B8
       call      qword ptr [7FFF90CC04B8]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFF90CC04B8
       call      qword ptr [7FFF90CC04B8]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+288]
       mov       r8,22FB3808348
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFF8F963048]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FFF8F963720]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FCC7990]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFF8FD2E640
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFF8F54B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FFF8FD2E708
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FFF8F9633F0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
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
       mov       rdx,7FFF8FD2E6D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFF8FC5DC90]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFF8FD2E6F0
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
       mov       rdx,7FFF8FD2E680
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFF8FC5DC60]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FFF8FD2E640
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
       call      qword ptr [7FFF8F963420]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FFF8FD2E5D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FFF8F927780]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FFF8F796C90
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF8F7AD960]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC81EB8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       r11,7FFF8F3A0AA8
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF8F3A0AB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFF8F3A0AB0
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       r11,7FFF90CC04B0
       call      qword ptr [7FFF90CC04B0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF90CC04B8
       call      qword ptr [7FFF90CC04B8]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF90CC04B8
       call      qword ptr [7FFF90CC04B8]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF8F953720]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FCB39A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FFF8F390AA0
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF8F390AA8
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF8F390AA8
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       r11,7FFF90CC04B0
       call      qword ptr [7FFF90CC04B0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF90CC04B8
       call      qword ptr [7FFF90CC04B8]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF90CC04B8
       call      qword ptr [7FFF90CC04B8]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF8F953720]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FCA36A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FFF8F390AA8
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF8F390AB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF8F390AB0
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       r11,7FFF90CD04B0
       call      qword ptr [7FFF90CD04B0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF90CD04B8
       call      qword ptr [7FFF90CD04B8]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF90CD04B8
       call      qword ptr [7FFF90CD04B8]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF8F593720]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8F8E36A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FFF8EFD0AA8
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF8EFD0AB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF8EFD0AB0
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       r11,7FFF90CA04B0
       call      qword ptr [7FFF90CA04B0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF90CA04B8
       call      qword ptr [7FFF90CA04B8]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF90CA04B8
       call      qword ptr [7FFF90CA04B8]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF8F583720]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8F8D39A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FFF8EFC0AA8
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF8EFC0AB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF8EFC0AB0
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       r11,7FFF90CB04B0
       call      qword ptr [7FFF90CB04B0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF90CB04B8
       call      qword ptr [7FFF90CB04B8]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF90CB04B8
       call      qword ptr [7FFF90CB04B8]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF8F5A3720]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8F8F36A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FFF8EFE0AA8
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF8EFE0AB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF8EFE0AB0
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       r11,7FFF90CD04B0
       call      qword ptr [7FFF90CD04B0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF90CD04B8
       call      qword ptr [7FFF90CD04B8]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF90CD04B8
       call      qword ptr [7FFF90CD04B8]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF8F583720]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8F8D36A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FFF8EFC0AA8
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF8EFC0AB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF8EFC0AB0
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       r11,7FFF90CA04B0
       call      qword ptr [7FFF90CA04B0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF90CA04B8
       call      qword ptr [7FFF90CA04B8]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF90CA04B8
       call      qword ptr [7FFF90CA04B8]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF8F953720]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FCB56A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FFF8F390AA8
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF8F390AB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF8F390AB0
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

