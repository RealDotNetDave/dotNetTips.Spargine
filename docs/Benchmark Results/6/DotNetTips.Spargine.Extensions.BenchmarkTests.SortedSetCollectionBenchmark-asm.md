## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,2B6E6373340
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2B6E6373338
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2B6E6373340
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
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAC4438378]
       vucomisd  xmm0,qword ptr [7FFAC4438380]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
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
       mov       rdx,7FFAC4588480
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFAC3EB0968
       call      qword ptr [7FFAC3EB0968]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFAC4588558
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
       mov       r11,7FFAC3EB0968
       call      qword ptr [7FFAC3EB0968]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFAC3EB0970
       call      qword ptr [7FFAC3EB0970]
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
       mov       r11,7FFAC3EB0970
       call      qword ptr [7FFAC3EB0970]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,1A758406750
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1A758406748
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFAC4ECCFD8
       mov       [rbx+18],rdx
       mov       rcx,1A758406750
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
       call      qword ptr [7FFAC4EC1318]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,7FFAC4EDC6B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFAC46308C8
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
       mov       rdx,7FFAC4EDC790
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
       mov       r11,7FFAC46308C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L06
M01_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFAC46308D0
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
       call      qword ptr [7FFAC4A3B780]
       int       3
M01_L09:
       mov       ecx,0C
       call      qword ptr [7FFAC4A3B780]
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
       mov       r11,7FFAC46308D0
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,1BD02F53340
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1BD02F53338
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1BD02F53340
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
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAC4438CD8]
       vucomisd  xmm0,qword ptr [7FFAC4438CE0]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
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
       mov       rdx,7FFAC4587A40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFAC3EB0968
       call      qword ptr [7FFAC3EB0968]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFAC4587B18
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
       mov       r11,7FFAC3EB0968
       call      qword ptr [7FFAC3EB0968]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFAC3EB0970
       call      qword ptr [7FFAC3EB0970]
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
       mov       r11,7FFAC3EB0970
       call      qword ptr [7FFAC3EB0970]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,27DB9C02348
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,27DB9C02340
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFAC4EEEBA0
       mov       [rbx+18],rdx
       mov       rcx,27DB9C02348
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
       call      qword ptr [7FFAC4EE19C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,7FFAC4EFC6B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFAC46508C8
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
       mov       rdx,7FFAC4EFC790
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
       mov       r11,7FFAC46508C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L06
M01_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFAC46508D0
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
       call      qword ptr [7FFAC4A5B780]
       int       3
M01_L09:
       mov       ecx,0C
       call      qword ptr [7FFAC4A5B780]
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
       mov       r11,7FFAC46508D0
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,260C8A93340
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,260C8A93338
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,260C8A93340
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
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAC4438CD8]
       vucomisd  xmm0,qword ptr [7FFAC4438CE0]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
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
       mov       rdx,7FFAC4587A40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFAC3EB0968
       call      qword ptr [7FFAC3EB0968]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFAC4587B18
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
       mov       r11,7FFAC3EB0968
       call      qword ptr [7FFAC3EB0968]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFAC3EB0970
       call      qword ptr [7FFAC3EB0970]
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
       mov       r11,7FFAC3EB0970
       call      qword ptr [7FFAC3EB0970]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,22AC5402348
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,22AC5402340
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFAC529EBA0
       mov       [rbx+18],rdx
       mov       rcx,22AC5402348
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
       call      qword ptr [7FFAC52919C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,7FFAC52AC6B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFAC4A008C8
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
       mov       rdx,7FFAC52AC790
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
       mov       r11,7FFAC4A008C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L06
M01_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFAC4A008D0
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
       call      qword ptr [7FFAC4E0B780]
       int       3
M01_L09:
       mov       ecx,0C
       call      qword ptr [7FFAC4E0B780]
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
       mov       r11,7FFAC4A008D0
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,1B2C2333340
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1B2C2333338
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1B2C2333340
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
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAC4428C98]
       vucomisd  xmm0,qword ptr [7FFAC4428CA0]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
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
       mov       rdx,7FFAC4577A40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFAC3EA0968
       call      qword ptr [7FFAC3EA0968]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFAC4577B18
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
       mov       r11,7FFAC3EA0968
       call      qword ptr [7FFAC3EA0968]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFAC3EA0970
       call      qword ptr [7FFAC3EA0970]
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
       mov       r11,7FFAC3EA0970
       call      qword ptr [7FFAC3EA0970]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,1D71D806750
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1D71D806748
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFAC529E8A0
       mov       [rbx+18],rdx
       mov       rcx,1D71D806750
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
       call      qword ptr [7FFAC52919C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,7FFAC52AC6B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFAC4A008C8
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
       mov       rdx,7FFAC52AC790
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
       mov       r11,7FFAC4A008C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L06
M01_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFAC4A008D0
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
       call      qword ptr [7FFAC4E0B780]
       int       3
M01_L09:
       mov       ecx,0C
       call      qword ptr [7FFAC4E0B780]
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
       mov       r11,7FFAC4A008D0
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,209C42B7748
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,209C42B7740
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,209C42B7748
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
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAC4418D58]
       vucomisd  xmm0,qword ptr [7FFAC4418D60]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
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
       mov       rdx,7FFAC4567A40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFAC3E90968
       call      qword ptr [7FFAC3E90968]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFAC4567B18
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
       mov       r11,7FFAC3E90968
       call      qword ptr [7FFAC3E90968]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFAC3E90970
       call      qword ptr [7FFAC3E90970]
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
       mov       r11,7FFAC3E90970
       call      qword ptr [7FFAC3E90970]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,1F6C1006750
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1F6C1006748
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFAC52BE8A0
       mov       [rbx+18],rdx
       mov       rcx,1F6C1006750
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
       call      qword ptr [7FFAC52B19C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,7FFAC52CC6D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFAC4A208C8
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
       mov       rdx,7FFAC52CC7B0
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
       mov       r11,7FFAC4A208C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L06
M01_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFAC4A208D0
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
       call      qword ptr [7FFAC4E2B780]
       int       3
M01_L09:
       mov       ecx,0C
       call      qword ptr [7FFAC4E2B780]
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
       mov       r11,7FFAC4A208D0
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,1B5568E7748
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1B5568E7740
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1B5568E7748
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
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAC4418CD8]
       vucomisd  xmm0,qword ptr [7FFAC4418CE0]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
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
       mov       rdx,7FFAC4567A40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFAC3E90968
       call      qword ptr [7FFAC3E90968]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFAC4567B18
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
       mov       r11,7FFAC3E90968
       call      qword ptr [7FFAC3E90968]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFAC3E90970
       call      qword ptr [7FFAC3E90970]
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
       mov       r11,7FFAC3E90970
       call      qword ptr [7FFAC3E90970]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,14B7FC02348
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,14B7FC02340
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFAC52AEBA0
       mov       [rbx+18],rdx
       mov       rcx,14B7FC02348
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
       call      qword ptr [7FFAC52A19C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,7FFAC52BC6F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFAC4A108C8
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
       mov       rdx,7FFAC52BC7D0
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
       mov       r11,7FFAC4A108C8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L06
M01_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFAC4A108D0
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
       call      qword ptr [7FFAC4E1B780]
       int       3
M01_L09:
       mov       ecx,0C
       call      qword ptr [7FFAC4E1B780]
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
       mov       r11,7FFAC4A108D0
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,2192D1F7748
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2192D1F7740
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2192D1F7748
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
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAC45D7BF8]
       vucomisd  xmm0,qword ptr [7FFAC45D7C00]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
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
       mov       rdx,7FFAC45CB548
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFAC3EB0A98
       call      qword ptr [7FFAC3EB0A98]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFAC45CB620
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
       mov       r11,7FFAC3EB0A98
       call      qword ptr [7FFAC3EB0A98]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFAC3EB0AA0
       call      qword ptr [7FFAC3EB0AA0]
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
       mov       r11,7FFAC3EB0AA0
       call      qword ptr [7FFAC3EB0AA0]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,11CAF006750
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,11CAF006748
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFAC52C6FD8
       mov       [rbx+18],rdx
       mov       rcx,11CAF006750
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
       call      qword ptr [7FFAC529B9C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,7FFAC52FE450
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFAC49F0A08
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
       mov       rdx,7FFAC52FE528
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
       mov       r11,7FFAC49F0A08
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L06
M01_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFAC49F0A10
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
       call      qword ptr [7FFAC4DFB780]
       int       3
M01_L09:
       mov       ecx,0C
       call      qword ptr [7FFAC4DFB780]
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
       mov       r11,7FFAC49F0A10
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,1BBBA547748
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1BBBA547740
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1BBBA547748
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
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rdx
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAC45C6078]
       vucomisd  xmm0,qword ptr [7FFAC45C6080]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 189
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
       mov       rdx,7FFAC45B6918
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFAC3EA0A88
       call      qword ptr [7FFAC3EA0A88]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFAC45B69F0
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
       mov       r11,7FFAC3EA0A88
       call      qword ptr [7FFAC3EA0A88]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFAC3EA0A90
       call      qword ptr [7FFAC3EA0A90]
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
       mov       r11,7FFAC3EA0A90
       call      qword ptr [7FFAC3EA0A90]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+278]
       mov       rcx,14839406750
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,14839406748
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFAC52E68A0
       mov       [rbx+18],rdx
       mov       rcx,14839406750
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
       call      qword ptr [7FFAC52BB318]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,7FFAC531D8A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-38],rcx
       mov       r11,7FFAC4A10A08
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
       mov       rdx,7FFAC531D978
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
       mov       r11,7FFAC4A10A08
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L02
       jmp       short M01_L06
M01_L05:
       mov       dword ptr [rbp-2C],1
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbp-38]
       mov       r11,7FFAC4A10A10
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
       call      qword ptr [7FFAC4E1B780]
       int       3
M01_L09:
       mov       ecx,0C
       call      qword ptr [7FFAC4E1B780]
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
       mov       r11,7FFAC4A10A10
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+278]
       mov       r8,248918B4E48
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
       mov       rdx,7FFAC45AC028
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
       mov       rdx,7FFAC45AC1B0
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
       mov       rdx,7FFAC45AC0B8
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
       mov       rdx,7FFAC45AC0D8
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
       mov       rdx,7FFAC45AC0D8
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
       mov       rdx,7FFAC45AC068
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
       mov       rdx,7FFAC45AC028
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
       mov       rdx,7FFAC45AC398
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
       mov       rdx,7FFAC413AFC0
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
       mov       r11,7FFAC3EC0900
       call      qword ptr [7FFAC3EC0900]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC3EC0908
       call      qword ptr [7FFAC3EC0908]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFAC3EC0908
       call      qword ptr [7FFAC3EC0908]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+278]
       mov       r8,21309005FA8
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFAC4BF1708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FFAC4BF3078]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC4EF5270]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFAC4F356B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAC47CB828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FFAC4F35780
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FFAC4BF1AB0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
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
       mov       rdx,7FFAC4F35748
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFAC4E8D438]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFAC4F35768
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
       mov       rdx,7FFAC4F356F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAC4E8D408]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FFAC4F356B8
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
       call      qword ptr [7FFAC4BF1AE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FFAC4F35600
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FFAC4BC1E40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FFAC4A26B10
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFAC49E1F90]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC4EB1570]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       r11,7FFAC46208C8
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC46208D0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFAC46208D0
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+278]
       mov       r8,1908CC98E38
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
       mov       rdx,7FFAC4589230
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
       mov       rdx,7FFAC45892F8
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
       mov       rdx,7FFAC45892C0
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
       mov       rdx,7FFAC45892E0
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
       mov       rdx,7FFAC45892E0
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
       mov       rdx,7FFAC4589270
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
       mov       rdx,7FFAC4589230
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
       mov       rdx,7FFAC4589180
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
       mov       rdx,7FFAC411AFC0
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
       mov       r11,7FFAC3EB0900
       call      qword ptr [7FFAC3EB0900]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC3EB0908
       call      qword ptr [7FFAC3EB0908]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFAC3EB0908
       call      qword ptr [7FFAC3EB0908]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+278]
       mov       r8,230AE007FA0
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFAC4BBF708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FFAC4BE1078]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC4EE3270]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFAC4ECE118
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAC47CB828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FFAC4ECE1E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FFAC4BBFAB0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
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
       mov       rdx,7FFAC4ECE1A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFAC4E7B438]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFAC4ECE1C8
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
       mov       rdx,7FFAC4ECE158
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAC4E7B408]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FFAC4ECE118
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
       call      qword ptr [7FFAC4BBFAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FFAC4ECE060
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FFAC4B7FE40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FFAC4A16B10
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFAC49CFF90]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC4E7F570]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       r11,7FFAC46208C8
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC46208D0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFAC46208D0
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+278]
       mov       r8,25CCFCD4A30
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
       mov       rdx,7FFAC4579230
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
       mov       rdx,7FFAC45792F8
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
       mov       rdx,7FFAC45792C0
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
       mov       rdx,7FFAC45792E0
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
       mov       rdx,7FFAC45792E0
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
       mov       rdx,7FFAC4579270
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
       mov       rdx,7FFAC4579230
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
       mov       rdx,7FFAC4579180
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
       mov       rdx,7FFAC410AFC0
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
       mov       r11,7FFAC3EA0900
       call      qword ptr [7FFAC3EA0900]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC3EA0908
       call      qword ptr [7FFAC3EA0908]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFAC3EA0908
       call      qword ptr [7FFAC3EA0908]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+278]
       mov       r8,229CDC07FA0
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFAC4F8F708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FFAC4FB1078]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC52B3708]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFAC529E160
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAC4B9B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FFAC529E228
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FFAC4F8FAB0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
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
       mov       rdx,7FFAC529E1F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFAC524B438]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFAC529E210
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
       mov       rdx,7FFAC529E1A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAC524B408]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FFAC529E160
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
       call      qword ptr [7FFAC4F8FAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FFAC529E0A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FFAC4F4FE40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FFAC4DE6B10
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFAC4D9FF90]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC524F570]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       r11,7FFAC49F08C8
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC49F08D0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFAC49F08D0
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+278]
       mov       r8,165E7828E38
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
       mov       rdx,7FFAC4599230
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
       mov       rdx,7FFAC45992F8
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
       mov       rdx,7FFAC45992C0
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
       mov       rdx,7FFAC45992E0
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
       mov       rdx,7FFAC45992E0
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
       mov       rdx,7FFAC4599270
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
       mov       rdx,7FFAC4599230
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
       mov       rdx,7FFAC4599180
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
       mov       rdx,7FFAC412AFC0
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
       mov       r11,7FFAC3EC0900
       call      qword ptr [7FFAC3EC0900]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC3EC0908
       call      qword ptr [7FFAC3EC0908]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFAC3EC0908
       call      qword ptr [7FFAC3EC0908]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+278]
       mov       r8,22689007FA0
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFAC4F9F708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FFAC4FC1078]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC52D1978]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFAC52AE160
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAC4BAB828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FFAC52AE228
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FFAC4F9FAB0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
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
       mov       rdx,7FFAC52AE1F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFAC5269D08]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFAC52AE210
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
       mov       rdx,7FFAC52AE1A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAC5269CD8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FFAC52AE160
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
       call      qword ptr [7FFAC4F9FAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FFAC52AE0A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FFAC4F5FE40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FFAC4DF6B10
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFAC4DAFF90]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC526DEB8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       r11,7FFAC4A008C8
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC4A008D0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFAC4A008D0
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+278]
       mov       r8,231C7DC6E40
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
       mov       rdx,7FFAC4589230
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
       mov       rdx,7FFAC45892F8
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
       mov       rdx,7FFAC45892C0
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
       mov       rdx,7FFAC45892E0
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
       mov       rdx,7FFAC45892E0
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
       mov       rdx,7FFAC4589270
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
       mov       rdx,7FFAC4589230
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
       mov       rdx,7FFAC45891C8
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
       mov       rdx,7FFAC411AFC0
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
       mov       r11,7FFAC3EB0900
       call      qword ptr [7FFAC3EB0900]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC3EB0908
       call      qword ptr [7FFAC3EB0908]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFAC3EB0908
       call      qword ptr [7FFAC3EB0908]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+278]
       mov       r8,1FC41803B98
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFAC4F8F708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FFAC4FB1078]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC52B3708]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFAC529E180
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAC4B9B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FFAC529E248
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FFAC4F8FAB0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
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
       mov       rdx,7FFAC529E210
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFAC524B438]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFAC529E230
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
       mov       rdx,7FFAC529E1C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAC524B408]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FFAC529E180
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
       call      qword ptr [7FFAC4F8FAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FFAC529E0C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FFAC4F4FE40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FFAC4DE6B10
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFAC4D9FF90]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC524F570]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       r11,7FFAC49F08C8
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC49F08D0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFAC49F08D0
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+278]
       mov       r8,26B3A448E38
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
       mov       rdx,7FFAC4589230
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
       mov       rdx,7FFAC45892F8
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
       mov       rdx,7FFAC45892C0
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
       mov       rdx,7FFAC45892E0
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
       mov       rdx,7FFAC45892E0
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
       mov       rdx,7FFAC4589270
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
       mov       rdx,7FFAC4589230
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
       mov       rdx,7FFAC45891C8
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
       mov       rdx,7FFAC411AFC0
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
       mov       r11,7FFAC3EB0900
       call      qword ptr [7FFAC3EB0900]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC3EB0908
       call      qword ptr [7FFAC3EB0908]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFAC3EB0908
       call      qword ptr [7FFAC3EB0908]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+278]
       mov       r8,1BAE3403B98
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFAC4FBF708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FFAC4FE1078]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC52E3270]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFAC52CE190
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAC4BCB828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FFAC52CE258
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FFAC4FBFAB0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
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
       mov       rdx,7FFAC52CE220
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFAC527B438]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFAC52CE240
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
       mov       rdx,7FFAC52CE1D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAC527B408]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FFAC52CE190
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
       call      qword ptr [7FFAC4FBFAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FFAC52CE0D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FFAC4F7FE40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FFAC4E16B10
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFAC4DCFF90]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC527F570]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       r11,7FFAC4A208C8
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC4A208D0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFAC4A208D0
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+278]
       mov       r8,24085148E40
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
       mov       rdx,7FFAC45AA898
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
       mov       rdx,7FFAC45AA960
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
       mov       rdx,7FFAC45AA928
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
       mov       rdx,7FFAC45AA948
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
       mov       rdx,7FFAC45AA948
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
       mov       rdx,7FFAC45AA8D8
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
       mov       rdx,7FFAC45AA898
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
       mov       rdx,7FFAC45AA830
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
       mov       rdx,7FFAC40FAFC0
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
       mov       r11,7FFAC3E90910
       call      qword ptr [7FFAC3E90910]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC3E90918
       call      qword ptr [7FFAC3E90918]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFAC3E90918
       call      qword ptr [7FFAC3E90918]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+278]
       mov       r8,29431407FA8
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFAC4FAF708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FFAC4FD1078]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC52EB978]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFAC532E1F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAC4BBB828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FFAC532E2B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FFAC4FAFAB0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
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
       mov       rdx,7FFAC532E280
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFAC52B5438]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFAC532E2A0
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
       mov       rdx,7FFAC532E230
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAC52B5408]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FFAC532E1F0
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
       call      qword ptr [7FFAC4FAFAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FFAC532E180
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FFAC4F6FE40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FFAC4E06B10
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFAC4DBFF90]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC52B9570]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       r11,7FFAC4A10A08
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC4A10A10
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFAC4A10A10
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+278]
       mov       r8,1EAA96D8E40
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
       mov       rdx,7FFAC45B7770
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
       mov       rdx,7FFAC45B7838
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
       mov       rdx,7FFAC45B7800
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
       mov       rdx,7FFAC45B7820
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
       mov       rdx,7FFAC45B7820
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
       mov       rdx,7FFAC45B77B0
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
       mov       rdx,7FFAC45B7770
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
       mov       rdx,7FFAC45B7708
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
       mov       rdx,7FFAC410AFC0
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
       mov       r11,7FFAC3EA0990
       call      qword ptr [7FFAC3EA0990]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC3EA0998
       call      qword ptr [7FFAC3EA0998]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFAC3EA0998
       call      qword ptr [7FFAC3EA0998]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+278]
       mov       r8,20E5F005FB0
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FFAC4F9F708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rcx,rdi
       call      qword ptr [7FFAC4FC1078]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ecx,ecx
       test      eax,eax
       setle     cl
       mov       [rsp+20],cl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC52DB270]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFAC531D690
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAC4BAB828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rdx,7FFAC531D758
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,r12
       cmp       [rcx],rax
       je        short M01_L03
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FFAC4F9FAB0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].HasEqualComparer(System.Collections.Generic.SortedSet`1<System.__Canon>)
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
       mov       rdx,7FFAC531D720
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L10:
       mov       [rsp+20],rsi
       mov       rcx,rdx
       mov       rdx,rbp
       mov       r9d,ebx
       xor       r8d,r8d
       call      qword ptr [7FFAC52A3D38]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFAC531D740
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
       mov       rdx,7FFAC531D6D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L17:
       lea       r8,[rsp+48]
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FFAC52A3D08]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FFAC531D690
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
       call      qword ptr [7FFAC4F9FAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FFAC531D620
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L24:
       call      qword ptr [7FFAC4F5FE40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,825
       mov       rdx,7FFAC4DF6B10
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFAC4DAFF90]
       int       3
M01_L26:
       mov       ecx,[r12+20]
       mov       [rdi+20],ecx
       mov       rcx,[r12+8]
       mov       edx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC52A7EB8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       r11,7FFAC4A00A08
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC4A00A10
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
M02_L01:
       add       esi,1
       jo        short M02_L03
       mov       rcx,rdi
       mov       r11,7FFAC4A00A10
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+278]
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
       mov       r11,7FFAC3EA0900
       call      qword ptr [7FFAC3EA0900]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC3EA0908
       call      qword ptr [7FFAC3EA0908]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAC3EA0908
       call      qword ptr [7FFAC3EA0908]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+278]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAC4BF1078]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC4ECF6A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FFAC46308C8
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC46308D0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAC46308D0
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+278]
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
       mov       r11,7FFAC3EB0900
       call      qword ptr [7FFAC3EB0900]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC3EB0908
       call      qword ptr [7FFAC3EB0908]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAC3EB0908
       call      qword ptr [7FFAC3EB0908]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+278]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAC4BE1078]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC4EBFF18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FFAC46208C8
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC46208D0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAC46208D0
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+278]
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
       mov       r11,7FFAC3EA0900
       call      qword ptr [7FFAC3EA0900]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC3EA0908
       call      qword ptr [7FFAC3EA0908]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAC3EA0908
       call      qword ptr [7FFAC3EA0908]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+278]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAC4FC1078]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC52C1270]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FFAC4A008C8
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC4A008D0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAC4A008D0
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+278]
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
       mov       r11,7FFAC3E90900
       call      qword ptr [7FFAC3E90900]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC3E90908
       call      qword ptr [7FFAC3E90908]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAC3E90908
       call      qword ptr [7FFAC3E90908]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+278]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAC4FB1078]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC528F6A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FFAC49F08C8
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC49F08D0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAC49F08D0
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+278]
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
       mov       r11,7FFAC3EB0900
       call      qword ptr [7FFAC3EB0900]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC3EB0908
       call      qword ptr [7FFAC3EB0908]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAC3EB0908
       call      qword ptr [7FFAC3EB0908]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+278]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAC4FD1078]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC52D1270]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FFAC4A108C8
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC4A108D0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAC4A108D0
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+278]
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
       mov       r11,7FFAC3E90900
       call      qword ptr [7FFAC3E90900]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC3E90908
       call      qword ptr [7FFAC3E90908]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAC3E90908
       call      qword ptr [7FFAC3E90908]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+278]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAC4FC1078]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC529FF18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FFAC4A008C8
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC4A008D0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAC4A008D0
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+278]
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
       mov       r11,7FFAC3EA0910
       call      qword ptr [7FFAC3EA0910]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC3EA0918
       call      qword ptr [7FFAC3EA0918]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAC3EA0918
       call      qword ptr [7FFAC3EA0918]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+278]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAC4FD1078]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC52E96A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FFAC4A10A08
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC4A10A10
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAC4A10A10
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+278]
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
       mov       r11,7FFAC3EB0990
       call      qword ptr [7FFAC3EB0990]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC3EB0998
       call      qword ptr [7FFAC3EB0998]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAC3EB0998
       call      qword ptr [7FFAC3EB0998]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+278]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAC4FE1078]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAC52F9270]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FFAC4A20A08
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAC4A20A10
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAC4A20A10
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

