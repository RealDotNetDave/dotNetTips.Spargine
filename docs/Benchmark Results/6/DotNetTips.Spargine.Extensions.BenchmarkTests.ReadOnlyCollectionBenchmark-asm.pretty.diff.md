## DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark-20240131-195631
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCAB048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90C904B0
-       call      qword ptr [7FFF90C904B0]
+       mov       r11,7FFF8F3B0A98
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF8F3B0AA0
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF8F3B0AA0
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
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
 ; Total bytes of code 72
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
-       mov       r11,7FFF90C904B0
-       call      qword ptr [7FFF90C904B0]
+       mov       r11,7FFF90CB04B0
+       call      qword ptr [7FFF90CB04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF90CB04B8
+       call      qword ptr [7FFF90CB04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF90CB04B8
+       call      qword ptr [7FFF90CB04B8]
        test      eax,eax
        jne       short M01_L01
 M01_L02:
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCAF048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90C904B0
-       call      qword ptr [7FFF90C904B0]
+       mov       r11,7FFF8F3B0A78
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF8F3B0A80
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF8F3B0A80
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
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
 ; Total bytes of code 72
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
-       mov       r11,7FFF90C904B0
-       call      qword ptr [7FFF90C904B0]
+       mov       r11,7FFF90CC04B0
+       call      qword ptr [7FFF90CC04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        jne       short M01_L01
 M01_L02:
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCADC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90C904B0
-       call      qword ptr [7FFF90C904B0]
+       mov       r11,7FFF8F3B0A78
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF8F3B0A80
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF8F3B0A80
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F963060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FC9D048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90C904B0
-       call      qword ptr [7FFF90C904B0]
+       mov       r11,7FFF8F3A0A78
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF8F3A0A80
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF8F3A0A80
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
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
 ; Total bytes of code 72
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
-       mov       r11,7FFF90C904B0
-       call      qword ptr [7FFF90C904B0]
+       mov       r11,7FFF90CC04B0
+       call      qword ptr [7FFF90CC04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        jne       short M01_L01
 M01_L02:
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCADC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90C904B0
-       call      qword ptr [7FFF90C904B0]
+       mov       r11,7FFF8F3B0A78
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF8F3B0A80
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF8F3B0A80
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
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
 ; Total bytes of code 72
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
-       mov       r11,7FFF90C904B0
-       call      qword ptr [7FFF90C904B0]
+       mov       r11,7FFF90CD04B0
+       call      qword ptr [7FFF90CD04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF90CD04B8
+       call      qword ptr [7FFF90CD04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF90CD04B8
+       call      qword ptr [7FFF90CD04B8]
        test      eax,eax
        jne       short M01_L01
 M01_L02:
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCBD048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90C904B0
-       call      qword ptr [7FFF90C904B0]
+       mov       r11,7FFF8F3C0A78
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF8F3C0A80
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF8F3C0A80
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
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
 ; Total bytes of code 72
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
-       mov       r11,7FFF90C904B0
-       call      qword ptr [7FFF90C904B0]
+       mov       r11,7FFF90CC04B0
+       call      qword ptr [7FFF90CC04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        jne       short M01_L01
 M01_L02:
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCBD048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90C904B0
-       call      qword ptr [7FFF90C904B0]
+       mov       r11,7FFF8F3C0A78
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF8F3C0A80
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF8F3C0A80
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       xor       edi,edi
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     dil
+       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCAB048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A98
-       call      qword ptr [r11]
+       mov       r11,7FFF90CB04B0
+       call      qword ptr [7FFF90CB04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0AA0
-       call      qword ptr [r11]
+       mov       r11,7FFF90CB04B8
+       call      qword ptr [7FFF90CB04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0AA0
-       call      qword ptr [r11]
+       mov       r11,7FFF90CB04B8
+       call      qword ptr [7FFF90CB04B8]
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
-; Total bytes of code 98
+; Total bytes of code 107
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        xor       edi,edi
        test      eax,eax
        setle     dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCAB048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCAF048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A98
+       mov       r11,7FFF8F3B0A78
        call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0AA0
+       mov       r11,7FFF8F3B0A80
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0AA0
+       mov       r11,7FFF8F3B0A80
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       xor       edi,edi
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     dil
+       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCAB048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A98
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B0
+       call      qword ptr [7FFF90CC04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0AA0
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0AA0
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
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
-; Total bytes of code 98
+; Total bytes of code 107
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        xor       edi,edi
        test      eax,eax
        setle     dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCAB048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCADC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A98
+       mov       r11,7FFF8F3B0A78
        call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0AA0
+       mov       r11,7FFF8F3B0A80
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0AA0
+       mov       r11,7FFF8F3B0A80
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       xor       edi,edi
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     dil
+       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCAB048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A98
-       call      qword ptr [r11]
+       mov       r11,7FFF90C904B0
+       call      qword ptr [7FFF90C904B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0AA0
-       call      qword ptr [r11]
+       mov       r11,7FFF90C904B8
+       call      qword ptr [7FFF90C904B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0AA0
-       call      qword ptr [r11]
+       mov       r11,7FFF90C904B8
+       call      qword ptr [7FFF90C904B8]
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
-; Total bytes of code 98
+; Total bytes of code 107
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F963060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        xor       edi,edi
        test      eax,eax
        setle     dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCAB048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FC9D048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A98
+       mov       r11,7FFF8F3A0A78
        call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0AA0
+       mov       r11,7FFF8F3A0A80
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0AA0
+       mov       r11,7FFF8F3A0A80
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       xor       edi,edi
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     dil
+       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCAB048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A98
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B0
+       call      qword ptr [7FFF90CC04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0AA0
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0AA0
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
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
-; Total bytes of code 98
+; Total bytes of code 107
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        xor       edi,edi
        test      eax,eax
        setle     dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCAB048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCADC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A98
+       mov       r11,7FFF8F3B0A78
        call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0AA0
+       mov       r11,7FFF8F3B0A80
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0AA0
+       mov       r11,7FFF8F3B0A80
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       xor       edi,edi
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     dil
+       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCAB048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A98
-       call      qword ptr [r11]
+       mov       r11,7FFF90CD04B0
+       call      qword ptr [7FFF90CD04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0AA0
-       call      qword ptr [r11]
+       mov       r11,7FFF90CD04B8
+       call      qword ptr [7FFF90CD04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0AA0
-       call      qword ptr [r11]
+       mov       r11,7FFF90CD04B8
+       call      qword ptr [7FFF90CD04B8]
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
-; Total bytes of code 98
+; Total bytes of code 107
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        xor       edi,edi
        test      eax,eax
        setle     dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCAB048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCBD048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A98
+       mov       r11,7FFF8F3C0A78
        call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0AA0
+       mov       r11,7FFF8F3C0A80
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0AA0
+       mov       r11,7FFF8F3C0A80
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       xor       edi,edi
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     dil
+       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCAB048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A98
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B0
+       call      qword ptr [7FFF90CC04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0AA0
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0AA0
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
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
-; Total bytes of code 98
+; Total bytes of code 107
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        xor       edi,edi
        test      eax,eax
        setle     dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCAB048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCBD048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A98
+       mov       r11,7FFF8F3C0A78
        call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0AA0
+       mov       r11,7FFF8F3C0A80
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0AA0
+       mov       r11,7FFF8F3C0A80
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCAF048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90CB04B0
-       call      qword ptr [7FFF90CB04B0]
+       mov       r11,7FFF8F3B0A78
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90CB04B8
-       call      qword ptr [7FFF90CB04B8]
+       mov       r11,7FFF8F3B0A80
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90CB04B8
-       call      qword ptr [7FFF90CB04B8]
+       mov       r11,7FFF8F3B0A80
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
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
 ; Total bytes of code 72
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
-       mov       r11,7FFF90CB04B0
-       call      qword ptr [7FFF90CB04B0]
+       mov       r11,7FFF90CC04B0
+       call      qword ptr [7FFF90CC04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90CB04B8
-       call      qword ptr [7FFF90CB04B8]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90CB04B8
-       call      qword ptr [7FFF90CB04B8]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        jne       short M01_L01
 M01_L02:
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCADC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90CB04B0
-       call      qword ptr [7FFF90CB04B0]
+       mov       r11,7FFF8F3B0A78
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90CB04B8
-       call      qword ptr [7FFF90CB04B8]
+       mov       r11,7FFF8F3B0A80
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90CB04B8
-       call      qword ptr [7FFF90CB04B8]
+       mov       r11,7FFF8F3B0A80
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
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
 ; Total bytes of code 72
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
-       mov       r11,7FFF90CB04B0
-       call      qword ptr [7FFF90CB04B0]
+       mov       r11,7FFF90C904B0
+       call      qword ptr [7FFF90C904B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90CB04B8
-       call      qword ptr [7FFF90CB04B8]
+       mov       r11,7FFF90C904B8
+       call      qword ptr [7FFF90C904B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90CB04B8
-       call      qword ptr [7FFF90CB04B8]
+       mov       r11,7FFF90C904B8
+       call      qword ptr [7FFF90C904B8]
        test      eax,eax
        jne       short M01_L01
 M01_L02:
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F963060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FC9D048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90CB04B0
-       call      qword ptr [7FFF90CB04B0]
+       mov       r11,7FFF8F3A0A78
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90CB04B8
-       call      qword ptr [7FFF90CB04B8]
+       mov       r11,7FFF8F3A0A80
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90CB04B8
-       call      qword ptr [7FFF90CB04B8]
+       mov       r11,7FFF8F3A0A80
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
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
 ; Total bytes of code 72
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
-       mov       r11,7FFF90CB04B0
-       call      qword ptr [7FFF90CB04B0]
+       mov       r11,7FFF90CC04B0
+       call      qword ptr [7FFF90CC04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90CB04B8
-       call      qword ptr [7FFF90CB04B8]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90CB04B8
-       call      qword ptr [7FFF90CB04B8]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        jne       short M01_L01
 M01_L02:
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCADC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90CB04B0
-       call      qword ptr [7FFF90CB04B0]
+       mov       r11,7FFF8F3B0A78
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90CB04B8
-       call      qword ptr [7FFF90CB04B8]
+       mov       r11,7FFF8F3B0A80
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90CB04B8
-       call      qword ptr [7FFF90CB04B8]
+       mov       r11,7FFF8F3B0A80
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
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
 ; Total bytes of code 72
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
-       mov       r11,7FFF90CB04B0
-       call      qword ptr [7FFF90CB04B0]
+       mov       r11,7FFF90CD04B0
+       call      qword ptr [7FFF90CD04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90CB04B8
-       call      qword ptr [7FFF90CB04B8]
+       mov       r11,7FFF90CD04B8
+       call      qword ptr [7FFF90CD04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90CB04B8
-       call      qword ptr [7FFF90CB04B8]
+       mov       r11,7FFF90CD04B8
+       call      qword ptr [7FFF90CD04B8]
        test      eax,eax
        jne       short M01_L01
 M01_L02:
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCBD048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90CB04B0
-       call      qword ptr [7FFF90CB04B0]
+       mov       r11,7FFF8F3C0A78
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90CB04B8
-       call      qword ptr [7FFF90CB04B8]
+       mov       r11,7FFF8F3C0A80
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90CB04B8
-       call      qword ptr [7FFF90CB04B8]
+       mov       r11,7FFF8F3C0A80
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
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
 ; Total bytes of code 72
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
-       mov       r11,7FFF90CB04B0
-       call      qword ptr [7FFF90CB04B0]
+       mov       r11,7FFF90CC04B0
+       call      qword ptr [7FFF90CC04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90CB04B8
-       call      qword ptr [7FFF90CB04B8]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90CB04B8
-       call      qword ptr [7FFF90CB04B8]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        jne       short M01_L01
 M01_L02:
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCBD048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90CB04B0
-       call      qword ptr [7FFF90CB04B0]
+       mov       r11,7FFF8F3C0A78
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90CB04B8
-       call      qword ptr [7FFF90CB04B8]
+       mov       r11,7FFF8F3C0A80
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90CB04B8
-       call      qword ptr [7FFF90CB04B8]
+       mov       r11,7FFF8F3C0A80
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       xor       edi,edi
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     dil
+       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCAF048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A78
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B0
+       call      qword ptr [7FFF90CC04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
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
-; Total bytes of code 98
+; Total bytes of code 107
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        xor       edi,edi
        test      eax,eax
        setle     dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCAF048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCADC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       xor       edi,edi
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     dil
+       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCAF048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A78
-       call      qword ptr [r11]
+       mov       r11,7FFF90C904B0
+       call      qword ptr [7FFF90C904B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90C904B8
+       call      qword ptr [7FFF90C904B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90C904B8
+       call      qword ptr [7FFF90C904B8]
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
-; Total bytes of code 98
+; Total bytes of code 107
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F963060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        xor       edi,edi
        test      eax,eax
        setle     dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCAF048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FC9D048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A78
+       mov       r11,7FFF8F3A0A78
        call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
+       mov       r11,7FFF8F3A0A80
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
+       mov       r11,7FFF8F3A0A80
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       xor       edi,edi
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     dil
+       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCAF048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A78
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B0
+       call      qword ptr [7FFF90CC04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
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
-; Total bytes of code 98
+; Total bytes of code 107
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        xor       edi,edi
        test      eax,eax
        setle     dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCAF048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCADC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       xor       edi,edi
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     dil
+       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCAF048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A78
-       call      qword ptr [r11]
+       mov       r11,7FFF90CD04B0
+       call      qword ptr [7FFF90CD04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90CD04B8
+       call      qword ptr [7FFF90CD04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90CD04B8
+       call      qword ptr [7FFF90CD04B8]
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
-; Total bytes of code 98
+; Total bytes of code 107
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        xor       edi,edi
        test      eax,eax
        setle     dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCAF048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCBD048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A78
+       mov       r11,7FFF8F3C0A78
        call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
+       mov       r11,7FFF8F3C0A80
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
+       mov       r11,7FFF8F3C0A80
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       xor       edi,edi
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     dil
+       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCAF048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A78
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B0
+       call      qword ptr [7FFF90CC04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
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
-; Total bytes of code 98
+; Total bytes of code 107
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        xor       edi,edi
        test      eax,eax
        setle     dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCAF048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCBD048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A78
+       mov       r11,7FFF8F3C0A78
        call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
+       mov       r11,7FFF8F3C0A80
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
+       mov       r11,7FFF8F3C0A80
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCADC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90CC04B0
-       call      qword ptr [7FFF90CC04B0]
+       mov       r11,7FFF8F3B0A78
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90CC04B8
-       call      qword ptr [7FFF90CC04B8]
+       mov       r11,7FFF8F3B0A80
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90CC04B8
-       call      qword ptr [7FFF90CC04B8]
+       mov       r11,7FFF8F3B0A80
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
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
 ; Total bytes of code 72
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
-       mov       r11,7FFF90CC04B0
-       call      qword ptr [7FFF90CC04B0]
+       mov       r11,7FFF90C904B0
+       call      qword ptr [7FFF90C904B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90CC04B8
-       call      qword ptr [7FFF90CC04B8]
+       mov       r11,7FFF90C904B8
+       call      qword ptr [7FFF90C904B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90CC04B8
-       call      qword ptr [7FFF90CC04B8]
+       mov       r11,7FFF90C904B8
+       call      qword ptr [7FFF90C904B8]
        test      eax,eax
        jne       short M01_L01
 M01_L02:
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F963060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FC9D048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90CC04B0
-       call      qword ptr [7FFF90CC04B0]
+       mov       r11,7FFF8F3A0A78
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90CC04B8
-       call      qword ptr [7FFF90CC04B8]
+       mov       r11,7FFF8F3A0A80
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90CC04B8
-       call      qword ptr [7FFF90CC04B8]
+       mov       r11,7FFF8F3A0A80
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCADC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90CC04B0
-       call      qword ptr [7FFF90CC04B0]
+       mov       r11,7FFF8F3B0A78
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90CC04B8
-       call      qword ptr [7FFF90CC04B8]
+       mov       r11,7FFF8F3B0A80
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90CC04B8
-       call      qword ptr [7FFF90CC04B8]
+       mov       r11,7FFF8F3B0A80
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
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
 ; Total bytes of code 72
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
-       mov       r11,7FFF90CC04B0
-       call      qword ptr [7FFF90CC04B0]
+       mov       r11,7FFF90CD04B0
+       call      qword ptr [7FFF90CD04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90CC04B8
-       call      qword ptr [7FFF90CC04B8]
+       mov       r11,7FFF90CD04B8
+       call      qword ptr [7FFF90CD04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90CC04B8
-       call      qword ptr [7FFF90CC04B8]
+       mov       r11,7FFF90CD04B8
+       call      qword ptr [7FFF90CD04B8]
        test      eax,eax
        jne       short M01_L01
 M01_L02:
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCBD048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90CC04B0
-       call      qword ptr [7FFF90CC04B0]
+       mov       r11,7FFF8F3C0A78
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90CC04B8
-       call      qword ptr [7FFF90CC04B8]
+       mov       r11,7FFF8F3C0A80
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90CC04B8
-       call      qword ptr [7FFF90CC04B8]
+       mov       r11,7FFF8F3C0A80
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCBD048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90CC04B0
-       call      qword ptr [7FFF90CC04B0]
+       mov       r11,7FFF8F3C0A78
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90CC04B8
-       call      qword ptr [7FFF90CC04B8]
+       mov       r11,7FFF8F3C0A80
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90CC04B8
-       call      qword ptr [7FFF90CC04B8]
+       mov       r11,7FFF8F3C0A80
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       xor       edi,edi
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     dil
+       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCADC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A78
-       call      qword ptr [r11]
+       mov       r11,7FFF90C904B0
+       call      qword ptr [7FFF90C904B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90C904B8
+       call      qword ptr [7FFF90C904B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90C904B8
+       call      qword ptr [7FFF90C904B8]
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
-; Total bytes of code 98
+; Total bytes of code 107
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F963060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        xor       edi,edi
        test      eax,eax
        setle     dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCADC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FC9D048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A78
+       mov       r11,7FFF8F3A0A78
        call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
+       mov       r11,7FFF8F3A0A80
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
+       mov       r11,7FFF8F3A0A80
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       xor       edi,edi
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     dil
+       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCADC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A78
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B0
+       call      qword ptr [7FFF90CC04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
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
-; Total bytes of code 98
+; Total bytes of code 107
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       xor       edi,edi
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     dil
+       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCADC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A78
-       call      qword ptr [r11]
+       mov       r11,7FFF90CD04B0
+       call      qword ptr [7FFF90CD04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90CD04B8
+       call      qword ptr [7FFF90CD04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90CD04B8
+       call      qword ptr [7FFF90CD04B8]
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
-; Total bytes of code 98
+; Total bytes of code 107
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        xor       edi,edi
        test      eax,eax
        setle     dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCADC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCBD048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A78
+       mov       r11,7FFF8F3C0A78
        call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
+       mov       r11,7FFF8F3C0A80
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
+       mov       r11,7FFF8F3C0A80
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       xor       edi,edi
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     dil
+       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCADC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A78
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B0
+       call      qword ptr [7FFF90CC04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
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
-; Total bytes of code 98
+; Total bytes of code 107
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        xor       edi,edi
        test      eax,eax
        setle     dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCADC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCBD048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A78
+       mov       r11,7FFF8F3C0A78
        call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
+       mov       r11,7FFF8F3C0A80
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
+       mov       r11,7FFF8F3C0A80
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F963060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FC9D048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90C904B0
-       call      qword ptr [7FFF90C904B0]
+       mov       r11,7FFF8F3A0A78
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF8F3A0A80
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF8F3A0A80
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
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
 ; Total bytes of code 72
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
-       mov       r11,7FFF90C904B0
-       call      qword ptr [7FFF90C904B0]
+       mov       r11,7FFF90CC04B0
+       call      qword ptr [7FFF90CC04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        jne       short M01_L01
 M01_L02:
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCADC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90C904B0
-       call      qword ptr [7FFF90C904B0]
+       mov       r11,7FFF8F3B0A78
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF8F3B0A80
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF8F3B0A80
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
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
 ; Total bytes of code 72
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
-       mov       r11,7FFF90C904B0
-       call      qword ptr [7FFF90C904B0]
+       mov       r11,7FFF90CD04B0
+       call      qword ptr [7FFF90CD04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF90CD04B8
+       call      qword ptr [7FFF90CD04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF90CD04B8
+       call      qword ptr [7FFF90CD04B8]
        test      eax,eax
        jne       short M01_L01
 M01_L02:
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCBD048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90C904B0
-       call      qword ptr [7FFF90C904B0]
+       mov       r11,7FFF8F3C0A78
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF8F3C0A80
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF8F3C0A80
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
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
 ; Total bytes of code 72
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
-       mov       r11,7FFF90C904B0
-       call      qword ptr [7FFF90C904B0]
+       mov       r11,7FFF90CC04B0
+       call      qword ptr [7FFF90CC04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        jne       short M01_L01
 M01_L02:
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCBD048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90C904B0
-       call      qword ptr [7FFF90C904B0]
+       mov       r11,7FFF8F3C0A78
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF8F3C0A80
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90C904B8
-       call      qword ptr [7FFF90C904B8]
+       mov       r11,7FFF8F3C0A80
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F963060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       xor       edi,edi
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     dil
+       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FC9D048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3A0A78
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B0
+       call      qword ptr [7FFF90CC04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3A0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3A0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
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
-; Total bytes of code 98
+; Total bytes of code 107
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F963060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        xor       edi,edi
        test      eax,eax
        setle     dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FC9D048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCADC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3A0A78
+       mov       r11,7FFF8F3B0A78
        call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3A0A80
+       mov       r11,7FFF8F3B0A80
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3A0A80
+       mov       r11,7FFF8F3B0A80
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F963060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       xor       edi,edi
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     dil
+       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FC9D048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3A0A78
-       call      qword ptr [r11]
+       mov       r11,7FFF90CD04B0
+       call      qword ptr [7FFF90CD04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3A0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90CD04B8
+       call      qword ptr [7FFF90CD04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3A0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90CD04B8
+       call      qword ptr [7FFF90CD04B8]
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
-; Total bytes of code 98
+; Total bytes of code 107
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F963060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        xor       edi,edi
        test      eax,eax
        setle     dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FC9D048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCBD048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3A0A78
+       mov       r11,7FFF8F3C0A78
        call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3A0A80
+       mov       r11,7FFF8F3C0A80
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3A0A80
+       mov       r11,7FFF8F3C0A80
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F963060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       xor       edi,edi
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     dil
+       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FC9D048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3A0A78
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B0
+       call      qword ptr [7FFF90CC04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3A0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3A0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
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
-; Total bytes of code 98
+; Total bytes of code 107
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F963060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        xor       edi,edi
        test      eax,eax
        setle     dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FC9D048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCBD048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3A0A78
+       mov       r11,7FFF8F3C0A78
        call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3A0A80
+       mov       r11,7FFF8F3C0A80
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3A0A80
+       mov       r11,7FFF8F3C0A80
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCADC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90CC04B0
-       call      qword ptr [7FFF90CC04B0]
+       mov       r11,7FFF8F3B0A78
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90CC04B8
-       call      qword ptr [7FFF90CC04B8]
+       mov       r11,7FFF8F3B0A80
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90CC04B8
-       call      qword ptr [7FFF90CC04B8]
+       mov       r11,7FFF8F3B0A80
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
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
 ; Total bytes of code 72
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
-       mov       r11,7FFF90CC04B0
-       call      qword ptr [7FFF90CC04B0]
+       mov       r11,7FFF90CD04B0
+       call      qword ptr [7FFF90CD04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90CC04B8
-       call      qword ptr [7FFF90CC04B8]
+       mov       r11,7FFF90CD04B8
+       call      qword ptr [7FFF90CD04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90CC04B8
-       call      qword ptr [7FFF90CC04B8]
+       mov       r11,7FFF90CD04B8
+       call      qword ptr [7FFF90CD04B8]
        test      eax,eax
        jne       short M01_L01
 M01_L02:
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCBD048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90CC04B0
-       call      qword ptr [7FFF90CC04B0]
+       mov       r11,7FFF8F3C0A78
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90CC04B8
-       call      qword ptr [7FFF90CC04B8]
+       mov       r11,7FFF8F3C0A80
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90CC04B8
-       call      qword ptr [7FFF90CC04B8]
+       mov       r11,7FFF8F3C0A80
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCBD048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90CC04B0
-       call      qword ptr [7FFF90CC04B0]
+       mov       r11,7FFF8F3C0A78
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90CC04B8
-       call      qword ptr [7FFF90CC04B8]
+       mov       r11,7FFF8F3C0A80
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90CC04B8
-       call      qword ptr [7FFF90CC04B8]
+       mov       r11,7FFF8F3C0A80
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       xor       edi,edi
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     dil
+       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCADC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A78
-       call      qword ptr [r11]
+       mov       r11,7FFF90CD04B0
+       call      qword ptr [7FFF90CD04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90CD04B8
+       call      qword ptr [7FFF90CD04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90CD04B8
+       call      qword ptr [7FFF90CD04B8]
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
-; Total bytes of code 98
+; Total bytes of code 107
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        xor       edi,edi
        test      eax,eax
        setle     dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCADC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCBD048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A78
+       mov       r11,7FFF8F3C0A78
        call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
+       mov       r11,7FFF8F3C0A80
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
+       mov       r11,7FFF8F3C0A80
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       xor       edi,edi
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     dil
+       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCADC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A78
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B0
+       call      qword ptr [7FFF90CC04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
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
-; Total bytes of code 98
+; Total bytes of code 107
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F973060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        xor       edi,edi
        test      eax,eax
        setle     dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCADC00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCBD048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3B0A78
+       mov       r11,7FFF8F3C0A78
        call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
+       mov       r11,7FFF8F3C0A80
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3B0A80
+       mov       r11,7FFF8F3C0A80
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCBD048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90CD04B0
-       call      qword ptr [7FFF90CD04B0]
+       mov       r11,7FFF8F3C0A78
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90CD04B8
-       call      qword ptr [7FFF90CD04B8]
+       mov       r11,7FFF8F3C0A80
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90CD04B8
-       call      qword ptr [7FFF90CD04B8]
+       mov       r11,7FFF8F3C0A80
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
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
 ; Total bytes of code 72
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
-       mov       r11,7FFF90CD04B0
-       call      qword ptr [7FFF90CD04B0]
+       mov       r11,7FFF90CC04B0
+       call      qword ptr [7FFF90CC04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90CD04B8
-       call      qword ptr [7FFF90CD04B8]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90CD04B8
-       call      qword ptr [7FFF90CD04B8]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        jne       short M01_L01
 M01_L02:
```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCBD048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90CD04B0
-       call      qword ptr [7FFF90CD04B0]
+       mov       r11,7FFF8F3C0A78
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90CD04B8
-       call      qword ptr [7FFF90CD04B8]
+       mov       r11,7FFF8F3C0A80
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90CD04B8
-       call      qword ptr [7FFF90CD04B8]
+       mov       r11,7FFF8F3C0A80
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       xor       edi,edi
+       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     dil
+       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF8FCBD048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF8F3C0A78
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B0
+       call      qword ptr [7FFF90CC04B0]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF8F3C0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF8F3C0A80
-       call      qword ptr [r11]
+       mov       r11,7FFF90CC04B8
+       call      qword ptr [7FFF90CC04B8]
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
-; Total bytes of code 98
+; Total bytes of code 107
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
**Diff for DoesNotHaveItems method between:**
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rcx,[rsi+288]
        test      rcx,rcx
        jne       short M00_L00
        mov       edi,1
        jmp       short M00_L01
 M00_L00:
-       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8F983060]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       xor       edi,edi
        test      eax,eax
        setle     dil
-       movzx     edi,dil
 M00_L01:
        mov       [rsp+20],dil
        mov       rcx,[rsi+18]
        lea       rdx,[rsp+20]
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFF8FCBD048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 ; Total bytes of code 72
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
-       mov       r11,7FFF90CC04B0
-       call      qword ptr [7FFF90CC04B0]
+       mov       r11,7FFF8F3C0A78
+       call      qword ptr [r11]
        mov       rdi,rax
        mov       rcx,rdi
-       mov       r11,7FFF90CC04B8
-       call      qword ptr [7FFF90CC04B8]
+       mov       r11,7FFF8F3C0A80
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       esi,1
        jo        short M01_L03
        mov       rcx,rdi
-       mov       r11,7FFF90CC04B8
-       call      qword ptr [7FFF90CC04B8]
+       mov       r11,7FFF8F3C0A80
+       call      qword ptr [r11]
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
-; Total bytes of code 107
+; Total bytes of code 98
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        movzx     eax,byte ptr [rdx]
        mov       [rcx+4C],al
        ret
 ; Total bytes of code 7
```
