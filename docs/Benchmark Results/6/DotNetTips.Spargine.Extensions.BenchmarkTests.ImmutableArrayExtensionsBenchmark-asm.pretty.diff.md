## DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark-20231027-224510
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C646AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C67A0078
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C67A0078
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff

```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67BD360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BF828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C67AF048
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C67AF048
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff

```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67A9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67AB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C647AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C678FAD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C678FAD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C59764B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C5C4E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C5C4E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67AB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C679F758
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C679F758
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C678B360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C678D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C645AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C676F570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62EB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C676F570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6467300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff

```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67BB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C679F950
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C679F950
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67BD060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BF828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C679F5E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C679F5E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 66
+; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C646AC70],0
+       cmp       dword ptr [7FF9C59A64B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67A0078
+       mov       rdx,7FF9C5C7E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67A0078
+       mov       rdx,7FF9C5C7E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67BD360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BF828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C646AC70],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67A0078
+       mov       rdx,7FF9C67AF048
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67A0078
+       mov       rdx,7FF9C67AF048
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 66
+; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C646AC70],0
+       cmp       dword ptr [7FF9C59A64B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67A0078
+       mov       rdx,7FF9C5C7E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67A0078
+       mov       rdx,7FF9C5C7E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67A9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67AB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C646AC70],0
+       cmp       dword ptr [7FF9C647AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67A0078
+       mov       rdx,7FF9C678FAD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67A0078
+       mov       rdx,7FF9C678FAD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 66
+; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C646AC70],0
+       cmp       dword ptr [7FF9C59764B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67A0078
+       mov       rdx,7FF9C5C4E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67A0078
+       mov       rdx,7FF9C5C4E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67AB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C646AC70],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67A0078
+       mov       rdx,7FF9C679F758
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67A0078
+       mov       rdx,7FF9C679F758
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 66
+; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C646AC70],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67A0078
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67A0078
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C678B360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C678D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C646AC70],0
+       cmp       dword ptr [7FF9C645AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67A0078
+       mov       rdx,7FF9C676F570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62EB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67A0078
+       mov       rdx,7FF9C676F570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6467300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 66
+; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C646AC70],0
+       cmp       dword ptr [7FF9C59A64B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67A0078
+       mov       rdx,7FF9C5C7E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67A0078
+       mov       rdx,7FF9C5C7E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67BB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C646AC70],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67A0078
+       mov       rdx,7FF9C679F950
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67A0078
+       mov       rdx,7FF9C679F950
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 66
+; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C646AC70],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67A0078
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67A0078
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67BD060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BF828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C646AC70],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67A0078
+       mov       rdx,7FF9C679F5E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67A0078
+       mov       rdx,7FF9C679F5E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67BD360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BF828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C67AF048
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C67AF048
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff

```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67A9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67AB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C647AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C678FAD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C678FAD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C59764B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C5C4E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C5C4E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67AB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C679F758
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C679F758
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C678B360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C678D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C645AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C676F570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62EB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C676F570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6467300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff

```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67BB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C679F950
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C679F950
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67BD060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BF828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C679F5E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C679F5E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C67BD360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67BF828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 66
+; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C648AC70],0
+       cmp       dword ptr [7FF9C59A64B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AF048
+       mov       rdx,7FF9C5C7E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AF048
+       mov       rdx,7FF9C5C7E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C67BD360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67A9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67BF828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67AB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C648AC70],0
+       cmp       dword ptr [7FF9C647AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AF048
+       mov       rdx,7FF9C678FAD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AF048
+       mov       rdx,7FF9C678FAD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C67BD360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67BF828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 66
+; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C648AC70],0
+       cmp       dword ptr [7FF9C59764B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AF048
+       mov       rdx,7FF9C5C4E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AF048
+       mov       rdx,7FF9C5C4E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C67BD360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67AB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67BF828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
        cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AF048
+       mov       rdx,7FF9C679F758
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AF048
+       mov       rdx,7FF9C679F758
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C67BD360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67BF828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 66
+; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C648AC70],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AF048
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AF048
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C67BD360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C678B360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67BF828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C678D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C648AC70],0
+       cmp       dword ptr [7FF9C645AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AF048
+       mov       rdx,7FF9C676F570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62EB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AF048
+       mov       rdx,7FF9C676F570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6467300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C67BD360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67BF828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 66
+; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C648AC70],0
+       cmp       dword ptr [7FF9C59A64B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AF048
+       mov       rdx,7FF9C5C7E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AF048
+       mov       rdx,7FF9C5C7E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C67BD360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67BB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67BF828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
        cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AF048
+       mov       rdx,7FF9C679F950
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AF048
+       mov       rdx,7FF9C679F950
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C67BD360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67BF828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 66
+; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C648AC70],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AF048
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AF048
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C67BD360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67BD060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      qword ptr [7FF9C67BF828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
        cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AF048
+       mov       rdx,7FF9C679F5E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AF048
+       mov       rdx,7FF9C679F5E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67A9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67AB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C647AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C678FAD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C678FAD0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C59764B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C5C4E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C5C4E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67AB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C679F758
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C679F758
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C678B360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C678D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C645AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C676F570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62EB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C676F570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6467300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff

```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67BB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C679F950
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C679F950
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67BD060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BF828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C679F5E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C679F5E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C67A9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67AB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 66
+; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C647AC70],0
+       cmp       dword ptr [7FF9C59764B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678FAD0
+       mov       rdx,7FF9C5C4E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678FAD0
+       mov       rdx,7FF9C5C4E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C67A9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67AB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67AB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C647AC70],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678FAD0
+       mov       rdx,7FF9C679F758
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678FAD0
+       mov       rdx,7FF9C679F758
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C67A9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67AB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 66
+; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C647AC70],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678FAD0
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678FAD0
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C67A9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C678B360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67AB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C678D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C647AC70],0
+       cmp       dword ptr [7FF9C645AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678FAD0
+       mov       rdx,7FF9C676F570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62EB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678FAD0
+       mov       rdx,7FF9C676F570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6467300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C67A9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67AB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 66
+; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C647AC70],0
+       cmp       dword ptr [7FF9C59A64B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678FAD0
+       mov       rdx,7FF9C5C7E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678FAD0
+       mov       rdx,7FF9C5C7E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C67A9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67BB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67AB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C647AC70],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678FAD0
+       mov       rdx,7FF9C679F950
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678FAD0
+       mov       rdx,7FF9C679F950
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C67A9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67AB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 66
+; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C647AC70],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678FAD0
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678FAD0
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C67A9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67BD060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67AB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BF828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C647AC70],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678FAD0
+       mov       rdx,7FF9C679F5E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678FAD0
+       mov       rdx,7FF9C679F5E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67AB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59764B8],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E998
+       mov       rdx,7FF9C679F758
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E998
+       mov       rdx,7FF9C679F758
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59764B8],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E998
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E998
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C678B360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C678D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59764B8],0
+       cmp       dword ptr [7FF9C645AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E998
+       mov       rdx,7FF9C676F570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62EB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E998
+       mov       rdx,7FF9C676F570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6467300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59764B8],0
+       cmp       dword ptr [7FF9C59A64B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E998
+       mov       rdx,7FF9C5C7E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E998
+       mov       rdx,7FF9C5C7E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67BB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59764B8],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E998
+       mov       rdx,7FF9C679F950
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E998
+       mov       rdx,7FF9C679F950
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59764B8],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E998
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E998
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67BD060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BF828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59764B8],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E998
+       mov       rdx,7FF9C679F5E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E998
+       mov       rdx,7FF9C679F5E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C67AB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 66
+; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C648AC70],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679F758
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679F758
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C67AB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C678B360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C678D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C648AC70],0
+       cmp       dword ptr [7FF9C645AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679F758
+       mov       rdx,7FF9C676F570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62EB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679F758
+       mov       rdx,7FF9C676F570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6467300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C67AB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 66
+; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C648AC70],0
+       cmp       dword ptr [7FF9C59A64B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679F758
+       mov       rdx,7FF9C5C7E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679F758
+       mov       rdx,7FF9C5C7E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C67AB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67BB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
        cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679F758
+       mov       rdx,7FF9C679F950
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679F758
+       mov       rdx,7FF9C679F950
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C67AB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 66
+; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C648AC70],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679F758
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679F758
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C67AB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67BD060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BF828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
        cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679F758
+       mov       rdx,7FF9C679F5E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679F758
+       mov       rdx,7FF9C679F5E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C678B360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C678D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59964B8],0
+       cmp       dword ptr [7FF9C645AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E998
+       mov       rdx,7FF9C676F570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62EB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E998
+       mov       rdx,7FF9C676F570
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6467300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59964B8],0
+       cmp       dword ptr [7FF9C59A64B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E998
+       mov       rdx,7FF9C5C7E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E998
+       mov       rdx,7FF9C5C7E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67BB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59964B8],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E998
+       mov       rdx,7FF9C679F950
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E998
+       mov       rdx,7FF9C679F950
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff

```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67BD060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BF828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59964B8],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E998
+       mov       rdx,7FF9C679F5E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E998
+       mov       rdx,7FF9C679F5E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C678B360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C678D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 66
+; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C645AC70],0
+       cmp       dword ptr [7FF9C59A64B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C676F570
+       mov       rdx,7FF9C5C7E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C62EB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C676F570
+       mov       rdx,7FF9C5C7E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6467300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C678B360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67BB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C678D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C645AC70],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C676F570
+       mov       rdx,7FF9C679F950
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C62EB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C676F570
+       mov       rdx,7FF9C679F950
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6467300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C678B360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C678D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 66
+; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C645AC70],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C676F570
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C62EB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C676F570
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6467300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C678B360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67BD060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C678D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BF828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C645AC70],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C676F570
+       mov       rdx,7FF9C679F5E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C62EB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C676F570
+       mov       rdx,7FF9C679F5E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6467300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67BB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C679F950
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C679F950
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67BD060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BF828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C679F5E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E998
+       mov       rdx,7FF9C679F5E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C67BB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67BD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 66
+; Total bytes of code 64
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C648AC70],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679F950
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679F950
+       mov       rdx,7FF9C5C6E998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      qword ptr [7FF9C67BB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67BD060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67BD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BF828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
        cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679F950
+       mov       rdx,7FF9C679F5E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679F950
+       mov       rdx,7FF9C679F5E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItemsWithCount method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       r8d,[rsi+284]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, Int32)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
+       call      qword ptr [7FF9C67BD060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BF828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 64
+; Total bytes of code 66
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF9C59964B8],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E998
+       mov       rdx,7FF9C679F5E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E998
+       mov       rdx,7FF9C679F5E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        mov       eax,[rbp-2C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C67AB360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59964B8],0
+       cmp       dword ptr [7FF9C647AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C678F640
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C678F640
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59964B8],0
+       cmp       dword ptr [7FF9C59A64B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C5C7E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C5C7E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C679D060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C679F828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59964B8],0
+       cmp       dword ptr [7FF9C646AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C677F408
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C677F408
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff

```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C67CB8D0]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67CF0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59964B8],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C67AE8B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C67AE8B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59964B8],0
+       cmp       dword ptr [7FF9C59764B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C5C4E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C5C4E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C67B9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59964B8],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C679FAE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C679FAE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59964B8],0
+       cmp       dword ptr [7FF9C59B64B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C5C8E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C5C8E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59964B8],0
+       cmp       dword ptr [7FF9C646AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C677FBF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C677FBF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59964B8],0
+       cmp       dword ptr [7FF9C59864B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C5C5E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C5C5E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C67AB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59964B8],0
+       cmp       dword ptr [7FF9C647AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C678F320
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C678F320
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff

```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59964B8],0
+       cmp       dword ptr [7FF9C646AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C677FFF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C677FFF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67AB360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 59
+; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C647AC70],0
+       cmp       dword ptr [7FF9C59A64B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F640
+       mov       rdx,7FF9C5C7E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F640
+       mov       rdx,7FF9C5C7E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
-       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
+       movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 246
+; Total bytes of code 247
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67AB360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C679D060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C679F828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C647AC70],0
+       cmp       dword ptr [7FF9C646AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F640
+       mov       rdx,7FF9C677F408
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F640
+       mov       rdx,7FF9C677F408
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67AB360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 59
+; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C647AC70],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F640
+       mov       rdx,7FF9C5C6E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F640
+       mov       rdx,7FF9C5C6E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
-       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
+       movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 246
+; Total bytes of code 247
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67AB360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C67CB8D0]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67CF0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C647AC70],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F640
+       mov       rdx,7FF9C67AE8B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F640
+       mov       rdx,7FF9C67AE8B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67AB360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 59
+; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C647AC70],0
+       cmp       dword ptr [7FF9C59764B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F640
+       mov       rdx,7FF9C5C4E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F640
+       mov       rdx,7FF9C5C4E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
-       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
+       movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 246
+; Total bytes of code 247
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67AB360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C67B9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C647AC70],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F640
+       mov       rdx,7FF9C679FAE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F640
+       mov       rdx,7FF9C679FAE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67AB360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 59
+; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C647AC70],0
+       cmp       dword ptr [7FF9C59B64B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F640
+       mov       rdx,7FF9C5C8E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F640
+       mov       rdx,7FF9C5C8E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
-       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
+       movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 246
+; Total bytes of code 247
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67AB360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C647AC70],0
+       cmp       dword ptr [7FF9C646AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F640
+       mov       rdx,7FF9C677FBF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F640
+       mov       rdx,7FF9C677FBF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67AB360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 59
+; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C647AC70],0
+       cmp       dword ptr [7FF9C59864B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F640
+       mov       rdx,7FF9C5C5E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F640
+       mov       rdx,7FF9C5C5E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
-       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
+       movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 246
+; Total bytes of code 247
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67AB360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C67AB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FF9C647AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F640
+       mov       rdx,7FF9C678F320
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F640
+       mov       rdx,7FF9C678F320
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67AB360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 59
+; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C647AC70],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F640
+       mov       rdx,7FF9C5C6E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F640
+       mov       rdx,7FF9C5C6E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
-       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
+       movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 246
+; Total bytes of code 247
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67AB360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C647AC70],0
+       cmp       dword ptr [7FF9C646AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F640
+       mov       rdx,7FF9C677FFF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F640
+       mov       rdx,7FF9C677FFF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C679D060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C679F828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C646AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E980
+       mov       rdx,7FF9C677F408
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E980
+       mov       rdx,7FF9C677F408
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E980
+       mov       rdx,7FF9C5C6E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E980
+       mov       rdx,7FF9C5C6E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C67CB8D0]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67CF0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E980
+       mov       rdx,7FF9C67AE8B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E980
+       mov       rdx,7FF9C67AE8B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C59764B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E980
+       mov       rdx,7FF9C5C4E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E980
+       mov       rdx,7FF9C5C4E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C67B9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E980
+       mov       rdx,7FF9C679FAE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E980
+       mov       rdx,7FF9C679FAE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C59B64B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E980
+       mov       rdx,7FF9C5C8E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E980
+       mov       rdx,7FF9C5C8E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C646AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E980
+       mov       rdx,7FF9C677FBF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E980
+       mov       rdx,7FF9C677FBF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C59864B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E980
+       mov       rdx,7FF9C5C5E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E980
+       mov       rdx,7FF9C5C5E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C67AB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C647AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E980
+       mov       rdx,7FF9C678F320
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E980
+       mov       rdx,7FF9C678F320
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E980
+       mov       rdx,7FF9C5C6E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E980
+       mov       rdx,7FF9C5C6E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59A64B8],0
+       cmp       dword ptr [7FF9C646AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E980
+       mov       rdx,7FF9C677FFF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C7E980
+       mov       rdx,7FF9C677FFF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C679D060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C679F828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 59
+; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C646AC70],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677F408
+       mov       rdx,7FF9C5C6E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677F408
+       mov       rdx,7FF9C5C6E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
-       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
+       movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 246
+; Total bytes of code 247
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C679D060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C67CB8D0]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C679F828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67CF0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C646AC70],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677F408
+       mov       rdx,7FF9C67AE8B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677F408
+       mov       rdx,7FF9C67AE8B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C679D060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C679F828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 59
+; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C646AC70],0
+       cmp       dword ptr [7FF9C59764B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677F408
+       mov       rdx,7FF9C5C4E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677F408
+       mov       rdx,7FF9C5C4E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
-       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
+       movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 246
+; Total bytes of code 247
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C679D060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C67B9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C679F828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C646AC70],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677F408
+       mov       rdx,7FF9C679FAE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677F408
+       mov       rdx,7FF9C679FAE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C679D060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C679F828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 59
+; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C646AC70],0
+       cmp       dword ptr [7FF9C59B64B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677F408
+       mov       rdx,7FF9C5C8E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677F408
+       mov       rdx,7FF9C5C8E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
-       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
+       movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 246
+; Total bytes of code 247
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C679D060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C679F828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FF9C646AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677F408
+       mov       rdx,7FF9C677FBF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677F408
+       mov       rdx,7FF9C677FBF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C679D060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C679F828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 59
+; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C646AC70],0
+       cmp       dword ptr [7FF9C59864B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677F408
+       mov       rdx,7FF9C5C5E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677F408
+       mov       rdx,7FF9C5C5E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
-       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
+       movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 246
+; Total bytes of code 247
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C679D060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C67AB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C679F828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C646AC70],0
+       cmp       dword ptr [7FF9C647AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677F408
+       mov       rdx,7FF9C678F320
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677F408
+       mov       rdx,7FF9C678F320
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C679D060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C679F828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 59
+; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C646AC70],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677F408
+       mov       rdx,7FF9C5C6E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677F408
+       mov       rdx,7FF9C5C6E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
-       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
+       movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 246
+; Total bytes of code 247
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C679D060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C679F828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FF9C646AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677F408
+       mov       rdx,7FF9C677FFF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677F408
+       mov       rdx,7FF9C677FFF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C67CB8D0]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67CF0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59964B8],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C67AE8B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C67AE8B0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59964B8],0
+       cmp       dword ptr [7FF9C59764B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C5C4E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C5C4E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C67B9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59964B8],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C679FAE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C679FAE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59964B8],0
+       cmp       dword ptr [7FF9C59B64B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C5C8E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C5C8E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59964B8],0
+       cmp       dword ptr [7FF9C646AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C677FBF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C677FBF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59964B8],0
+       cmp       dword ptr [7FF9C59864B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C5C5E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C5C5E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C67AB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59964B8],0
+       cmp       dword ptr [7FF9C647AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C678F320
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C678F320
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff

```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59964B8],0
+       cmp       dword ptr [7FF9C646AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C677FFF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C677FFF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67CB8D0]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67CF0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 59
+; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C648AC70],0
+       cmp       dword ptr [7FF9C59764B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AE8B0
+       mov       rdx,7FF9C5C4E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AE8B0
+       mov       rdx,7FF9C5C4E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
-       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
+       movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 246
+; Total bytes of code 247
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67CB8D0]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C67B9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67CF0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AE8B0
+       mov       rdx,7FF9C679FAE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AE8B0
+       mov       rdx,7FF9C679FAE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67CB8D0]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67CF0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 59
+; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C648AC70],0
+       cmp       dword ptr [7FF9C59B64B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AE8B0
+       mov       rdx,7FF9C5C8E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AE8B0
+       mov       rdx,7FF9C5C8E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
-       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
+       movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 246
+; Total bytes of code 247
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67CB8D0]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67CF0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C648AC70],0
+       cmp       dword ptr [7FF9C646AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AE8B0
+       mov       rdx,7FF9C677FBF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AE8B0
+       mov       rdx,7FF9C677FBF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67CB8D0]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67CF0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 59
+; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C648AC70],0
+       cmp       dword ptr [7FF9C59864B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AE8B0
+       mov       rdx,7FF9C5C5E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AE8B0
+       mov       rdx,7FF9C5C5E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
-       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
+       movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 246
+; Total bytes of code 247
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67CB8D0]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C67AB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67CF0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C648AC70],0
+       cmp       dword ptr [7FF9C647AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AE8B0
+       mov       rdx,7FF9C678F320
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AE8B0
+       mov       rdx,7FF9C678F320
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67CB8D0]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67CF0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 59
+; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C648AC70],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AE8B0
+       mov       rdx,7FF9C5C6E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AE8B0
+       mov       rdx,7FF9C5C6E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
-       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
+       movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 246
+; Total bytes of code 247
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67CB8D0]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67CF0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C648AC70],0
+       cmp       dword ptr [7FF9C646AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AE8B0
+       mov       rdx,7FF9C677FFF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C67AE8B0
+       mov       rdx,7FF9C677FFF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C67B9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67BB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59764B8],0
+       cmp       dword ptr [7FF9C648AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E980
+       mov       rdx,7FF9C679FAE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E980
+       mov       rdx,7FF9C679FAE0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59764B8],0
+       cmp       dword ptr [7FF9C59B64B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E980
+       mov       rdx,7FF9C5C8E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E980
+       mov       rdx,7FF9C5C8E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59764B8],0
+       cmp       dword ptr [7FF9C646AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E980
+       mov       rdx,7FF9C677FBF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E980
+       mov       rdx,7FF9C677FBF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59764B8],0
+       cmp       dword ptr [7FF9C59864B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E980
+       mov       rdx,7FF9C5C5E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E980
+       mov       rdx,7FF9C5C5E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C67AB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59764B8],0
+       cmp       dword ptr [7FF9C647AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E980
+       mov       rdx,7FF9C678F320
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E980
+       mov       rdx,7FF9C678F320
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59764B8],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E980
+       mov       rdx,7FF9C5C6E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E980
+       mov       rdx,7FF9C5C6E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59764B8],0
+       cmp       dword ptr [7FF9C646AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E980
+       mov       rdx,7FF9C677FFF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C4E980
+       mov       rdx,7FF9C677FFF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67B9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67BB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 59
+; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C648AC70],0
+       cmp       dword ptr [7FF9C59B64B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679FAE0
+       mov       rdx,7FF9C5C8E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679FAE0
+       mov       rdx,7FF9C5C8E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
-       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
+       movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 246
+; Total bytes of code 247
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67B9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67BB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C648AC70],0
+       cmp       dword ptr [7FF9C646AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679FAE0
+       mov       rdx,7FF9C677FBF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679FAE0
+       mov       rdx,7FF9C677FBF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67B9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67BB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 59
+; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C648AC70],0
+       cmp       dword ptr [7FF9C59864B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679FAE0
+       mov       rdx,7FF9C5C5E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679FAE0
+       mov       rdx,7FF9C5C5E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
-       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
+       movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 246
+; Total bytes of code 247
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67B9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C67AB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67BB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C648AC70],0
+       cmp       dword ptr [7FF9C647AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679FAE0
+       mov       rdx,7FF9C678F320
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679FAE0
+       mov       rdx,7FF9C678F320
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67B9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67BB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 59
+; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C648AC70],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679FAE0
+       mov       rdx,7FF9C5C6E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679FAE0
+       mov       rdx,7FF9C5C6E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
-       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
+       movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 246
+; Total bytes of code 247
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67B9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67BB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C648AC70],0
+       cmp       dword ptr [7FF9C646AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679FAE0
+       mov       rdx,7FF9C677FFF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C631B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C679FAE0
+       mov       rdx,7FF9C677FFF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6497300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59B64B8],0
+       cmp       dword ptr [7FF9C646AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C8E980
+       mov       rdx,7FF9C677FBF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C8E980
+       mov       rdx,7FF9C677FBF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59B64B8],0
+       cmp       dword ptr [7FF9C59864B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C8E980
+       mov       rdx,7FF9C5C5E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C8E980
+       mov       rdx,7FF9C5C5E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C67AB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59B64B8],0
+       cmp       dword ptr [7FF9C647AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C8E980
+       mov       rdx,7FF9C678F320
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C8E980
+       mov       rdx,7FF9C678F320
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59B64B8],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C8E980
+       mov       rdx,7FF9C5C6E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C8E980
+       mov       rdx,7FF9C5C6E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59B64B8],0
+       cmp       dword ptr [7FF9C646AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C8E980
+       mov       rdx,7FF9C677FFF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C8E980
+       mov       rdx,7FF9C677FFF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 59
+; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C646AC70],0
+       cmp       dword ptr [7FF9C59864B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677FBF8
+       mov       rdx,7FF9C5C5E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677FBF8
+       mov       rdx,7FF9C5C5E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
-       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
+       movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 246
+; Total bytes of code 247
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C67AB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C646AC70],0
+       cmp       dword ptr [7FF9C647AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677FBF8
+       mov       rdx,7FF9C678F320
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677FBF8
+       mov       rdx,7FF9C678F320
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 59
+; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C646AC70],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677FBF8
+       mov       rdx,7FF9C5C6E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677FBF8
+       mov       rdx,7FF9C5C6E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
-       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
+       movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 246
+; Total bytes of code 247
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677FBF8
+       mov       rdx,7FF9C677FFF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C677FBF8
+       mov       rdx,7FF9C677FFF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C67AB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59864B8],0
+       cmp       dword ptr [7FF9C647AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C5E980
+       mov       rdx,7FF9C678F320
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C5E980
+       mov       rdx,7FF9C678F320
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
        call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
        call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59864B8],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C5E980
+       mov       rdx,7FF9C5C6E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C5E980
+       mov       rdx,7FF9C5C6E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59864B8],0
+       cmp       dword ptr [7FF9C646AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C5E980
+       mov       rdx,7FF9C677FFF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C5E980
+       mov       rdx,7FF9C677FFF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67AB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 59
+; Total bytes of code 57
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C647AC70],0
+       cmp       dword ptr [7FF9C59964B8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F320
+       mov       rdx,7FF9C5C6E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F320
+       mov       rdx,7FF9C5C6E980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
-       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
+       movzx     eax,al
        mov       [rbp-10],eax
        nop
+       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 246
+; Total bytes of code 247
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for ImmutableArrayHasItems method between:**
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      qword ptr [7FF9C67AB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C67AD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
 ; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C647AC70],0
+       cmp       dword ptr [7FF9C646AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F320
+       mov       rdx,7FF9C677FFF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      qword ptr [7FF9C630B570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C678F320
+       mov       rdx,7FF9C677FFF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      qword ptr [7FF9C6487300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
        mov       [rbp-10],eax
        nop
```
**Diff for ImmutableArrayHasItems method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
        push      rsi
        sub       rsp,30
        mov       rsi,rcx
        mov       rdx,[rsi+288]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
-       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
+       call      qword ptr [7FF9C679B060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        mov       [rsp+28],al
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+28]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF9C679D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 57
+; Total bytes of code 59
 ; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
        push      rbp
        sub       rsp,50
        lea       rbp,[rsp+50]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF9C59964B8],0
+       cmp       dword ptr [7FF9C646AC70],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L01
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L02
 M01_L01:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C677FFF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L02:
        lea       rcx,[rbp+18]
        mov       rdx,[rbp-18]
-       call      System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
+       call      qword ptr [7FF9C62FB570]; System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
        mov       [rbp-1C],eax
        mov       ecx,[rbp-1C]
        movzx     ecx,cl
        mov       [rbp-0C],ecx
        cmp       dword ptr [rbp-0C],0
        je        short M01_L03
        nop
        xor       ecx,ecx
        mov       [rbp-10],ecx
        nop
        jmp       short M01_L06
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-28],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF9C5C6E980
+       mov       rdx,7FF9C677FFF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-28],rax
 M01_L05:
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-28]
        call      CORINFO_HELP_BOX
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF9C6477300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-2C],eax
+       xor       eax,eax
        cmp       dword ptr [rbp-2C],0
        setg      al
-       movzx     eax,al
        mov       [rbp-10],eax
        nop
-       jmp       short M01_L06
 M01_L06:
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
-; Total bytes of code 247
+; Total bytes of code 246
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
