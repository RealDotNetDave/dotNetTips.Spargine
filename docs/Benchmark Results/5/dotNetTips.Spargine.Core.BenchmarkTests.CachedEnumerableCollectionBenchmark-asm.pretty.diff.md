## dotNetTips.Spargine.Core.BenchmarkTests.CachedEnumerableCollectionBenchmark-20210828-134641
**Diff for CollectionCreate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF7AD240670]
+       mov       r11,7FF7ACE70670
-       call      qword ptr [7FF7AD270670]
-       mov       r11,7FF7ACE90670
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rsi+18]
        je        short M01_L00
        test      dl,dl
        jne       short M01_L01
        cmp       byte ptr [rsi+20],0
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
 ; Total bytes of code 235
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
 M00_L00:
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        je        short M00_L00
        cmp       qword ptr [rbp+0FFD8],0
        lea       rbp,[rbp+50]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        nop
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,[rbp+0FFD8]
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        mov       [rbp+0FFD8],rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rdi
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r14
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[r14+8]
        mov       rdx,[rdx]
+       mov       rdx,205DFE32D30
-       mov       rdx,2E5495D2D30
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+148]
        mov       rsi,rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			using var result = CachedEnumerable.Create(this.PersonProperList);
 ; dotNetTips.Spargine.Core.BenchmarkTests.CachedEnumerableCollectionBenchmark.CollectionCreate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8f3f84e7-7f8c-42d5-a913-87028bc5471f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6412e8e2-dbe7-4e41-a570-63aff4939d79-diff.temp
index b971b9a..c4473fb 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6412e8e2-dbe7-4e41-a570-63aff4939d79-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8f3f84e7-7f8c-42d5-a913-87028bc5471f-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF7AD240670]
+       mov       r11,7FF7ACE70670
-       call      qword ptr [7FF7AD270670]
-       mov       r11,7FF7ACE90670
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rsi+18]
        je        short M01_L00
        test      dl,dl
        jne       short M01_L01
        cmp       byte ptr [rsi+20],0
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
 ; Total bytes of code 235
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
 M00_L00:
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        je        short M00_L00
        cmp       qword ptr [rbp+0FFD8],0
        lea       rbp,[rbp+50]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        nop
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,[rbp+0FFD8]
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        mov       [rbp+0FFD8],rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rdi
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r14
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[r14+8]
        mov       rdx,[rdx]
+       mov       rdx,23CEF972D30
-       mov       rdx,2E5495D2D30
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+148]
        mov       rsi,rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			using var result = CachedEnumerable.Create(this.PersonProperList);
 ; dotNetTips.Spargine.Core.BenchmarkTests.CachedEnumerableCollectionBenchmark.CollectionCreate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8e1e09ac-3d09-407f-aa21-11b4f70ce44a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c7b8d82a-9917-4b49-acbc-90828b34e15f-diff.temp
index b971b9a..724e336 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c7b8d82a-9917-4b49-acbc-90828b34e15f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8e1e09ac-3d09-407f-aa21-11b4f70ce44a-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/55567f9a-ac15-4e8e-9ca4-bc2e64c4bdfe-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5e071477-e484-4397-a0d6-6349788bc680-diff.temp
index b971b9a..141179e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5e071477-e484-4397-a0d6-6349788bc680-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/55567f9a-ac15-4e8e-9ca4-bc2e64c4bdfe-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
mov       [rsi+18],rax
        xor       eax,eax
        call      qword ptr [7FF7AD270670]
+       mov       r11,7FF7ACEA0670
-       mov       r11,7FF7ACE90670
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rsi+18]
        je        short M01_L00
        test      dl,dl
        jne       short M01_L01
        cmp       byte ptr [rsi+20],0
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
 ; Total bytes of code 235
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
 M00_L00:
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        je        short M00_L00
        cmp       qword ptr [rbp+0FFD8],0
        lea       rbp,[rbp+50]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        nop
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,[rbp+0FFD8]
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        mov       [rbp+0FFD8],rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rdi
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r14
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[r14+8]
        mov       rdx,[rdx]
+       mov       rdx,2252FEE2D30
-       mov       rdx,2E5495D2D30
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+148]
        mov       rsi,rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			using var result = CachedEnumerable.Create(this.PersonProperList);
 ; dotNetTips.Spargine.Core.BenchmarkTests.CachedEnumerableCollectionBenchmark.CollectionCreate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9656cdc1-ede8-4349-92e8-3511abadf6a8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c13b6747-1710-4f21-8dca-4dbc2a4855e3-diff.temp
index b971b9a..b49fbf0 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c13b6747-1710-4f21-8dca-4dbc2a4855e3-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9656cdc1-ede8-4349-92e8-3511abadf6a8-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF7AD240670]
+       mov       r11,7FF7ACE70670
-       call      qword ptr [7FF7AD270670]
-       mov       r11,7FF7ACE90670
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rsi+18]
        je        short M01_L00
        test      dl,dl
        jne       short M01_L01
        cmp       byte ptr [rsi+20],0
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
 ; Total bytes of code 235
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
 M00_L00:
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        je        short M00_L00
        cmp       qword ptr [rbp+0FFD8],0
        lea       rbp,[rbp+50]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        nop
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,[rbp+0FFD8]
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        mov       [rbp+0FFD8],rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rdi
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r14
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[r14+8]
        mov       rdx,[rdx]
+       mov       rdx,17C809F2D30
-       mov       rdx,2E5495D2D30
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+148]
        mov       rsi,rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			using var result = CachedEnumerable.Create(this.PersonProperList);
 ; dotNetTips.Spargine.Core.BenchmarkTests.CachedEnumerableCollectionBenchmark.CollectionCreate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3794cb6b-9049-43a8-82db-7eb56b3f4310-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3f818441-a378-4207-9da4-6a3e87bd1dba-diff.temp
index b971b9a..0aa7594 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3f818441-a378-4207-9da4-6a3e87bd1dba-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/3794cb6b-9049-43a8-82db-7eb56b3f4310-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF7AD230670]
+       mov       r11,7FF7ACE60670
-       call      qword ptr [7FF7AD270670]
-       mov       r11,7FF7ACE90670
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rsi+18]
        je        short M01_L00
        test      dl,dl
        jne       short M01_L01
        cmp       byte ptr [rsi+20],0
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
 ; Total bytes of code 235
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
 M00_L00:
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        je        short M00_L00
        cmp       qword ptr [rbp+0FFD8],0
        lea       rbp,[rbp+50]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        nop
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,[rbp+0FFD8]
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        mov       [rbp+0FFD8],rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rdi
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r14
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[r14+8]
        mov       rdx,[rdx]
+       mov       rdx,1FE18652D30
-       mov       rdx,2E5495D2D30
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+148]
        mov       rsi,rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			using var result = CachedEnumerable.Create(this.PersonProperList);
 ; dotNetTips.Spargine.Core.BenchmarkTests.CachedEnumerableCollectionBenchmark.CollectionCreate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f0e5d36b-b4f4-4820-b7aa-ed46441fd149-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a992b2b9-982b-4723-be28-16ef0e3b1ae6-diff.temp
index b971b9a..262212c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a992b2b9-982b-4723-be28-16ef0e3b1ae6-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f0e5d36b-b4f4-4820-b7aa-ed46441fd149-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/908fa6e0-35d1-4257-9294-2dc2b64ce18b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ba5f938d-4969-4fb0-8202-2523afe90ceb-diff.temp
index c4473fb..724e336 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ba5f938d-4969-4fb0-8202-2523afe90ceb-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/908fa6e0-35d1-4257-9294-2dc2b64ce18b-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF7AD260670]
+       mov       r11,7FF7ACE90670
-       call      qword ptr [7FF7AD240670]
-       mov       r11,7FF7ACE70670
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rsi+18]
        je        short M01_L00
        test      dl,dl
        jne       short M01_L01
        cmp       byte ptr [rsi+20],0
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
 ; Total bytes of code 235
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
 M00_L00:
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        je        short M00_L00
        cmp       qword ptr [rbp+0FFD8],0
        lea       rbp,[rbp+50]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        nop
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,[rbp+0FFD8]
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        mov       [rbp+0FFD8],rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rdi
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r14
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[r14+8]
        mov       rdx,[rdx]
+       mov       rdx,25931742D30
-       mov       rdx,205DFE32D30
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+148]
        mov       rsi,rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			using var result = CachedEnumerable.Create(this.PersonProperList);
 ; dotNetTips.Spargine.Core.BenchmarkTests.CachedEnumerableCollectionBenchmark.CollectionCreate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/57622c75-cedf-4cbb-b10a-90434f52cbb1-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6432845f-35dd-48dc-8899-fe8b94e99b42-diff.temp
index c4473fb..141179e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6432845f-35dd-48dc-8899-fe8b94e99b42-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/57622c75-cedf-4cbb-b10a-90434f52cbb1-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF7AD270670]
+       mov       r11,7FF7ACEA0670
-       call      qword ptr [7FF7AD240670]
-       mov       r11,7FF7ACE70670
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rsi+18]
        je        short M01_L00
        test      dl,dl
        jne       short M01_L01
        cmp       byte ptr [rsi+20],0
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
 ; Total bytes of code 235
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
 M00_L00:
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        je        short M00_L00
        cmp       qword ptr [rbp+0FFD8],0
        lea       rbp,[rbp+50]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        nop
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,[rbp+0FFD8]
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        mov       [rbp+0FFD8],rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rdi
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r14
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[r14+8]
        mov       rdx,[rdx]
+       mov       rdx,2252FEE2D30
-       mov       rdx,205DFE32D30
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+148]
        mov       rsi,rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			using var result = CachedEnumerable.Create(this.PersonProperList);
 ; dotNetTips.Spargine.Core.BenchmarkTests.CachedEnumerableCollectionBenchmark.CollectionCreate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/83f2f801-4b05-4a42-be90-6b85cf539649-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7cf27391-7373-4297-8f8b-d96d784d6b0c-diff.temp
index c4473fb..b49fbf0 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7cf27391-7373-4297-8f8b-d96d784d6b0c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/83f2f801-4b05-4a42-be90-6b85cf539649-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/81c5d162-f335-4fbe-bfa3-4a960a7a0178-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6e1d30ac-5e21-465f-b54e-b8430b219d4d-diff.temp
index c4473fb..0aa7594 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6e1d30ac-5e21-465f-b54e-b8430b219d4d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/81c5d162-f335-4fbe-bfa3-4a960a7a0178-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF7AD230670]
+       mov       r11,7FF7ACE60670
-       call      qword ptr [7FF7AD240670]
-       mov       r11,7FF7ACE70670
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rsi+18]
        je        short M01_L00
        test      dl,dl
        jne       short M01_L01
        cmp       byte ptr [rsi+20],0
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
 ; Total bytes of code 235
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
 M00_L00:
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        je        short M00_L00
        cmp       qword ptr [rbp+0FFD8],0
        lea       rbp,[rbp+50]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        nop
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,[rbp+0FFD8]
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        mov       [rbp+0FFD8],rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rdi
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r14
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[r14+8]
        mov       rdx,[rdx]
+       mov       rdx,1FE18652D30
-       mov       rdx,205DFE32D30
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+148]
        mov       rsi,rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			using var result = CachedEnumerable.Create(this.PersonProperList);
 ; dotNetTips.Spargine.Core.BenchmarkTests.CachedEnumerableCollectionBenchmark.CollectionCreate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a73becf8-0030-4c42-9326-0128e79032ff-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5809464d-3841-4260-ac13-49250563e391-diff.temp
index c4473fb..262212c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5809464d-3841-4260-ac13-49250563e391-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/a73becf8-0030-4c42-9326-0128e79032ff-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF7AD260670]
+       mov       r11,7FF7ACE90670
-       call      qword ptr [7FF7AD240670]
-       mov       r11,7FF7ACE70670
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rsi+18]
        je        short M01_L00
        test      dl,dl
        jne       short M01_L01
        cmp       byte ptr [rsi+20],0
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
 ; Total bytes of code 235
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
 M00_L00:
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        je        short M00_L00
        cmp       qword ptr [rbp+0FFD8],0
        lea       rbp,[rbp+50]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        nop
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,[rbp+0FFD8]
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        mov       [rbp+0FFD8],rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rdi
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r14
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[r14+8]
        mov       rdx,[rdx]
+       mov       rdx,25931742D30
-       mov       rdx,23CEF972D30
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+148]
        mov       rsi,rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			using var result = CachedEnumerable.Create(this.PersonProperList);
 ; dotNetTips.Spargine.Core.BenchmarkTests.CachedEnumerableCollectionBenchmark.CollectionCreate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/01d2239e-fe84-4851-b9d3-f3718122208d-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4447ee62-4760-4667-9f3c-c839752e0016-diff.temp
index 724e336..141179e 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4447ee62-4760-4667-9f3c-c839752e0016-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/01d2239e-fe84-4851-b9d3-f3718122208d-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF7AD270670]
+       mov       r11,7FF7ACEA0670
-       call      qword ptr [7FF7AD240670]
-       mov       r11,7FF7ACE70670
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rsi+18]
        je        short M01_L00
        test      dl,dl
        jne       short M01_L01
        cmp       byte ptr [rsi+20],0
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
 ; Total bytes of code 235
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
 M00_L00:
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        je        short M00_L00
        cmp       qword ptr [rbp+0FFD8],0
        lea       rbp,[rbp+50]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        nop
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,[rbp+0FFD8]
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        mov       [rbp+0FFD8],rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rdi
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r14
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[r14+8]
        mov       rdx,[rdx]
+       mov       rdx,2252FEE2D30
-       mov       rdx,23CEF972D30
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+148]
        mov       rsi,rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			using var result = CachedEnumerable.Create(this.PersonProperList);
 ; dotNetTips.Spargine.Core.BenchmarkTests.CachedEnumerableCollectionBenchmark.CollectionCreate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/62f0a553-da19-4dbf-aa52-5411241ed4d4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c2221f06-5824-4f9a-bf92-505fab0a5375-diff.temp
index 724e336..b49fbf0 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c2221f06-5824-4f9a-bf92-505fab0a5375-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/62f0a553-da19-4dbf-aa52-5411241ed4d4-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/88e8b2e9-d31a-40e7-8f8a-bd728d08c504-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9fc60d33-cd06-4488-968f-4f93c4c83134-diff.temp
index 724e336..0aa7594 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9fc60d33-cd06-4488-968f-4f93c4c83134-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/88e8b2e9-d31a-40e7-8f8a-bd728d08c504-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF7AD230670]
+       mov       r11,7FF7ACE60670
-       call      qword ptr [7FF7AD240670]
-       mov       r11,7FF7ACE70670
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rsi+18]
        je        short M01_L00
        test      dl,dl
        jne       short M01_L01
        cmp       byte ptr [rsi+20],0
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
 ; Total bytes of code 235
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
 M00_L00:
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        je        short M00_L00
        cmp       qword ptr [rbp+0FFD8],0
        lea       rbp,[rbp+50]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        nop
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,[rbp+0FFD8]
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        mov       [rbp+0FFD8],rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rdi
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r14
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[r14+8]
        mov       rdx,[rdx]
+       mov       rdx,1FE18652D30
-       mov       rdx,23CEF972D30
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+148]
        mov       rsi,rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			using var result = CachedEnumerable.Create(this.PersonProperList);
 ; dotNetTips.Spargine.Core.BenchmarkTests.CachedEnumerableCollectionBenchmark.CollectionCreate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/128c4108-ae11-4a38-85f4-a9b05dfc5ce8-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4ee47ba5-eab2-449c-9f2e-7c5f3cbdb02c-diff.temp
index 724e336..262212c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4ee47ba5-eab2-449c-9f2e-7c5f3cbdb02c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/128c4108-ae11-4a38-85f4-a9b05dfc5ce8-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF7AD270670]
+       mov       r11,7FF7ACEA0670
-       call      qword ptr [7FF7AD260670]
-       mov       r11,7FF7ACE90670
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rsi+18]
        je        short M01_L00
        test      dl,dl
        jne       short M01_L01
        cmp       byte ptr [rsi+20],0
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
 ; Total bytes of code 235
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
 M00_L00:
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        je        short M00_L00
        cmp       qword ptr [rbp+0FFD8],0
        lea       rbp,[rbp+50]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        nop
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,[rbp+0FFD8]
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        mov       [rbp+0FFD8],rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rdi
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r14
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[r14+8]
        mov       rdx,[rdx]
+       mov       rdx,2252FEE2D30
-       mov       rdx,25931742D30
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+148]
        mov       rsi,rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			using var result = CachedEnumerable.Create(this.PersonProperList);
 ; dotNetTips.Spargine.Core.BenchmarkTests.CachedEnumerableCollectionBenchmark.CollectionCreate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/47eb0aae-5f74-48c1-95be-0ff74f54cd72-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7c0c4ffd-84f5-4233-9003-ec931f9b8789-diff.temp
index 141179e..b49fbf0 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7c0c4ffd-84f5-4233-9003-ec931f9b8789-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/47eb0aae-5f74-48c1-95be-0ff74f54cd72-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF7AD240670]
+       mov       r11,7FF7ACE70670
-       call      qword ptr [7FF7AD260670]
-       mov       r11,7FF7ACE90670
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rsi+18]
        je        short M01_L00
        test      dl,dl
        jne       short M01_L01
        cmp       byte ptr [rsi+20],0
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
 ; Total bytes of code 235
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
 M00_L00:
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        je        short M00_L00
        cmp       qword ptr [rbp+0FFD8],0
        lea       rbp,[rbp+50]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        nop
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,[rbp+0FFD8]
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        mov       [rbp+0FFD8],rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rdi
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r14
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[r14+8]
        mov       rdx,[rdx]
+       mov       rdx,17C809F2D30
-       mov       rdx,25931742D30
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+148]
        mov       rsi,rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			using var result = CachedEnumerable.Create(this.PersonProperList);
 ; dotNetTips.Spargine.Core.BenchmarkTests.CachedEnumerableCollectionBenchmark.CollectionCreate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/da4d803f-a764-4bf9-99ec-122db08cb970-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/372bc36e-dee6-452e-a1ba-a8d411039176-diff.temp
index 141179e..0aa7594 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/372bc36e-dee6-452e-a1ba-a8d411039176-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/da4d803f-a764-4bf9-99ec-122db08cb970-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF7AD230670]
+       mov       r11,7FF7ACE60670
-       call      qword ptr [7FF7AD260670]
-       mov       r11,7FF7ACE90670
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rsi+18]
        je        short M01_L00
        test      dl,dl
        jne       short M01_L01
        cmp       byte ptr [rsi+20],0
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
 ; Total bytes of code 235
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
 M00_L00:
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        je        short M00_L00
        cmp       qword ptr [rbp+0FFD8],0
        lea       rbp,[rbp+50]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        nop
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,[rbp+0FFD8]
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        mov       [rbp+0FFD8],rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rdi
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r14
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[r14+8]
        mov       rdx,[rdx]
+       mov       rdx,1FE18652D30
-       mov       rdx,25931742D30
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+148]
        mov       rsi,rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			using var result = CachedEnumerable.Create(this.PersonProperList);
 ; dotNetTips.Spargine.Core.BenchmarkTests.CachedEnumerableCollectionBenchmark.CollectionCreate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/17e6bec6-3867-4760-b0e4-f8df7f6a4918-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e1a7f7c3-10fa-436f-b6b8-6889f2539248-diff.temp
index 141179e..262212c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e1a7f7c3-10fa-436f-b6b8-6889f2539248-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/17e6bec6-3867-4760-b0e4-f8df7f6a4918-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF7AD240670]
+       mov       r11,7FF7ACE70670
-       call      qword ptr [7FF7AD270670]
-       mov       r11,7FF7ACEA0670
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rsi+18]
        je        short M01_L00
        test      dl,dl
        jne       short M01_L01
        cmp       byte ptr [rsi+20],0
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
 ; Total bytes of code 235
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
 M00_L00:
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        je        short M00_L00
        cmp       qword ptr [rbp+0FFD8],0
        lea       rbp,[rbp+50]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        nop
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,[rbp+0FFD8]
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        mov       [rbp+0FFD8],rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rdi
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r14
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[r14+8]
        mov       rdx,[rdx]
+       mov       rdx,17C809F2D30
-       mov       rdx,2252FEE2D30
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+148]
        mov       rsi,rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			using var result = CachedEnumerable.Create(this.PersonProperList);
 ; dotNetTips.Spargine.Core.BenchmarkTests.CachedEnumerableCollectionBenchmark.CollectionCreate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2e62c043-d9e4-43b3-9e0b-a1492cb5faf2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/eb5f41a5-312c-4363-afe5-618b064c0f4f-diff.temp
index b49fbf0..0aa7594 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/eb5f41a5-312c-4363-afe5-618b064c0f4f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2e62c043-d9e4-43b3-9e0b-a1492cb5faf2-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF7AD230670]
+       mov       r11,7FF7ACE60670
-       call      qword ptr [7FF7AD270670]
-       mov       r11,7FF7ACEA0670
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rsi+18]
        je        short M01_L00
        test      dl,dl
        jne       short M01_L01
        cmp       byte ptr [rsi+20],0
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
 ; Total bytes of code 235
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
 M00_L00:
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        je        short M00_L00
        cmp       qword ptr [rbp+0FFD8],0
        lea       rbp,[rbp+50]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        nop
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,[rbp+0FFD8]
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        mov       [rbp+0FFD8],rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rdi
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r14
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[r14+8]
        mov       rdx,[rdx]
+       mov       rdx,1FE18652D30
-       mov       rdx,2252FEE2D30
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+148]
        mov       rsi,rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			using var result = CachedEnumerable.Create(this.PersonProperList);
 ; dotNetTips.Spargine.Core.BenchmarkTests.CachedEnumerableCollectionBenchmark.CollectionCreate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/28d97e8a-958a-409c-92b4-a743b933a1b3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bf7fe20c-ff95-4b07-82f6-7ce9b416dd7c-diff.temp
index b49fbf0..262212c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bf7fe20c-ff95-4b07-82f6-7ce9b416dd7c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/28d97e8a-958a-409c-92b4-a743b933a1b3-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
.NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF7AD230670]
+       mov       r11,7FF7ACE60670
-       call      qword ptr [7FF7AD240670]
-       mov       r11,7FF7ACE70670
        je        short M01_L00
        test      rcx,rcx
        mov       rcx,[rsi+18]
        je        short M01_L00
        test      dl,dl
        jne       short M01_L01
        cmp       byte ptr [rsi+20],0
        mov       rsi,rcx
        sub       rsp,20
        push      rsi
 ; dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
 ; Total bytes of code 235
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        add       rsp,30
        nop
 M00_L00:
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        je        short M00_L00
        cmp       qword ptr [rbp+0FFD8],0
        lea       rbp,[rbp+50]
        mov       [rsp+20],rbp
        mov       rbp,[rcx+20]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
        ret
        pop       rbp
        pop       r14
        pop       rdi
        pop       rsi
        pop       rbx
        lea       rsp,[rbp+0FFE0]
        nop
        call      System.GC.SuppressFinalize(System.Object)
        mov       rcx,[rbp+0FFD8]
        call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
        mov       edx,1
        mov       rcx,[rbp+0FFD8]
        nop
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        mov       rdx,[rbp+0FFD8]
        add       rcx,10
        cmp       [rcx],ecx
        mov       rcx,[rsi+10]
        mov       [rbp+0FFD8],rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,rdi
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        mov       rdx,r14
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[r14+8]
        mov       rdx,[rdx]
+       mov       rdx,1FE18652D30
-       mov       rdx,17C809F2D30
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+148]
        mov       rsi,rcx
        mov       [rbp+0FFD0],rsp
        lea       rbp,[rsp+50]
        sub       rsp,30
        push      rbx
        push      rsi
        push      rdi
        push      r14
        push      rbp
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			this.Consumer.Consume(result);
 ; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
 ; 			using var result = CachedEnumerable.Create(this.PersonProperList);
 ; dotNetTips.Spargine.Core.BenchmarkTests.CachedEnumerableCollectionBenchmark.CollectionCreate01()
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cdaac2d2-5bdf-4fda-942e-d88d37f759b7-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b59f0f03-3a24-4353-b1d4-204f30d9ca2f-diff.temp
index 0aa7594..262212c 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b59f0f03-3a24-4353-b1d4-204f30d9ca2f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/cdaac2d2-5bdf-4fda-942e-d88d37f759b7-diff.temp
```
