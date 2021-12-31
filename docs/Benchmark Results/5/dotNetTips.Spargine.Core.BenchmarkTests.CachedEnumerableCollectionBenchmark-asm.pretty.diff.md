## dotNetTips.Spargine.Core.BenchmarkTests.CachedEnumerableCollectionBenchmark-20211222-160923
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0c160364-76c0-4df5-b5c1-9c5b8b89d7e7-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/708e00aa-f759-4b67-9965-86c7de694899-diff.temp
index cd4741b..b23afcb 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/708e00aa-f759-4b67-9965-86c7de694899-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0c160364-76c0-4df5-b5c1-9c5b8b89d7e7-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF85D6306E0]
+       mov       r11,7FF85D2506E0
-       call      qword ptr [7FF85D6506E0]
-       mov       r11,7FF85D2606E0
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
+       mov       rdx,1D5D3C82D20
-       mov       rdx,1ED6E6B2D20
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+158]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bebf288d-b0da-4c72-9c97-eec5db35d521-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ac7ba454-5ff4-41e8-ada3-88e1a9244c19-diff.temp
index cd4741b..91adbb3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ac7ba454-5ff4-41e8-ada3-88e1a9244c19-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bebf288d-b0da-4c72-9c97-eec5db35d521-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/72cb826d-962f-49a2-b498-f496bdfeda71-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/193381fd-a7ce-46f6-9274-2810679546b2-diff.temp
index cd4741b..b98a473 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/193381fd-a7ce-46f6-9274-2810679546b2-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/72cb826d-962f-49a2-b498-f496bdfeda71-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/844d869c-b4c7-483f-9fac-9557bcec6d86-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c3122297-e433-46f5-87ca-a9d26f8a8baf-diff.temp
index cd4741b..b435641 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/c3122297-e433-46f5-87ca-a9d26f8a8baf-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/844d869c-b4c7-483f-9fac-9557bcec6d86-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
mov       [rsi+18],rax
        xor       eax,eax
        call      qword ptr [7FF85D6506E0]
+       mov       r11,7FF85D2706E0
-       mov       r11,7FF85D2606E0
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
+       mov       rdx,15236AB2D20
-       mov       rdx,1ED6E6B2D20
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+158]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5082f645-ae6e-4bd2-a3db-040c8d727cdc-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/80357263-8893-46db-a8df-199a85a10aba-diff.temp
index cd4741b..18af881 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/80357263-8893-46db-a8df-199a85a10aba-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5082f645-ae6e-4bd2-a3db-040c8d727cdc-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e7142ebc-8508-452c-b36c-88a36c08a3eb-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/52c1c4b8-b431-440f-9b5b-aad6f3f5260f-diff.temp
index cd4741b..118b8e7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/52c1c4b8-b431-440f-9b5b-aad6f3f5260f-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e7142ebc-8508-452c-b36c-88a36c08a3eb-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF85D6206E8]
+       mov       r11,7FF85D2406E8
-       call      qword ptr [7FF85D6506E0]
-       mov       r11,7FF85D2606E0
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
+       mov       rdx,1B052792D20
-       mov       rdx,1ED6E6B2D20
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+158]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/90a14caf-9f17-468a-86c8-75b25232e370-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f8f0d5cf-b70f-4df3-8032-553aecec6475-diff.temp
index cd4741b..8df998b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f8f0d5cf-b70f-4df3-8032-553aecec6475-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/90a14caf-9f17-468a-86c8-75b25232e370-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF85D6306E0]
+       mov       r11,7FF85D2506E0
-       call      qword ptr [7FF85D6406E0]
-       mov       r11,7FF85D2606E0
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
+       mov       rdx,1D5D3C82D20
-       mov       rdx,1A5FD8D2D20
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+158]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e1f73348-a6a4-4615-8185-e8825f3e57cd-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1597b6cd-0cc8-4b13-bf39-96d200c01c86-diff.temp
index b23afcb..91adbb3 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1597b6cd-0cc8-4b13-bf39-96d200c01c86-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/e1f73348-a6a4-4615-8185-e8825f3e57cd-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fc06c477-adc6-403f-864a-5ea5d8fd60c2-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f0b20b83-273a-45ff-abb6-e87f189e7e84-diff.temp
index b23afcb..b98a473 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f0b20b83-273a-45ff-abb6-e87f189e7e84-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/fc06c477-adc6-403f-864a-5ea5d8fd60c2-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b6710b56-1af8-43a9-8971-7fcb9b5b0cad-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2bda2222-8ffa-475c-a20f-9cc5bc5b506d-diff.temp
index b23afcb..b435641 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2bda2222-8ffa-475c-a20f-9cc5bc5b506d-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b6710b56-1af8-43a9-8971-7fcb9b5b0cad-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF85D6506E0]
+       mov       r11,7FF85D2706E0
-       call      qword ptr [7FF85D6406E0]
-       mov       r11,7FF85D2606E0
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
+       mov       rdx,15236AB2D20
-       mov       rdx,1A5FD8D2D20
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+158]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/37e1c247-e930-4bf9-ab2b-5096664ffc9a-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b723e5a4-102d-436d-9693-b29cec38e2df-diff.temp
index b23afcb..18af881 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/b723e5a4-102d-436d-9693-b29cec38e2df-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/37e1c247-e930-4bf9-ab2b-5096664ffc9a-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/611288a3-1587-4c8c-a544-98d171105147-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bbe53b8d-4a60-400b-83ad-2d086da605b1-diff.temp
index b23afcb..118b8e7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/bbe53b8d-4a60-400b-83ad-2d086da605b1-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/611288a3-1587-4c8c-a544-98d171105147-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF85D6206E8]
+       mov       r11,7FF85D2406E8
-       call      qword ptr [7FF85D6406E0]
-       mov       r11,7FF85D2606E0
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
+       mov       rdx,1B052792D20
-       mov       rdx,1A5FD8D2D20
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+158]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d0dc9b0e-fe71-4e1a-b6f4-3b921c70c06b-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5c7b669e-10a6-47f1-8897-5fa5cf0b738c-diff.temp
index b23afcb..8df998b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/5c7b669e-10a6-47f1-8897-5fa5cf0b738c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d0dc9b0e-fe71-4e1a-b6f4-3b921c70c06b-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF85D6406E0]
+       mov       r11,7FF85D2606E0
-       call      qword ptr [7FF85D6306E0]
-       mov       r11,7FF85D2506E0
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
+       mov       rdx,125EC432D20
-       mov       rdx,1D5D3C82D20
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+158]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/50cc160c-7cf9-4855-9288-beb315c75bc0-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4d3251f6-abee-43b4-952f-ebc9ca836c0c-diff.temp
index 91adbb3..b98a473 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4d3251f6-abee-43b4-952f-ebc9ca836c0c-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/50cc160c-7cf9-4855-9288-beb315c75bc0-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF85D6406E0]
+       mov       r11,7FF85D2606E0
-       call      qword ptr [7FF85D6306E0]
-       mov       r11,7FF85D2506E0
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
+       mov       rdx,22359192D20
-       mov       rdx,1D5D3C82D20
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+158]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8f6b606b-df8f-4ab4-aff1-35cf2d59b108-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/233afc71-0b37-4030-97ef-15e45af14356-diff.temp
index 91adbb3..b435641 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/233afc71-0b37-4030-97ef-15e45af14356-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8f6b606b-df8f-4ab4-aff1-35cf2d59b108-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF85D6506E0]
+       mov       r11,7FF85D2706E0
-       call      qword ptr [7FF85D6306E0]
-       mov       r11,7FF85D2506E0
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
+       mov       rdx,15236AB2D20
-       mov       rdx,1D5D3C82D20
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+158]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8677aefe-2066-4b03-b5a1-f8f5a051a37e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/061310e3-ad73-49d7-94d2-82dec3485b84-diff.temp
index 91adbb3..18af881 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/061310e3-ad73-49d7-94d2-82dec3485b84-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8677aefe-2066-4b03-b5a1-f8f5a051a37e-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF85D6406E0]
+       mov       r11,7FF85D2606E0
-       call      qword ptr [7FF85D6306E0]
-       mov       r11,7FF85D2506E0
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
+       mov       rdx,196DEC02D20
-       mov       rdx,1D5D3C82D20
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+158]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/30a77581-5f68-4c69-99a8-893f40780504-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/15bf4dfe-b230-4950-b4fd-779a9aecafcf-diff.temp
index 91adbb3..118b8e7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/15bf4dfe-b230-4950-b4fd-779a9aecafcf-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/30a77581-5f68-4c69-99a8-893f40780504-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF85D6206E8]
+       mov       r11,7FF85D2406E8
-       call      qword ptr [7FF85D6306E0]
-       mov       r11,7FF85D2506E0
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
+       mov       rdx,1B052792D20
-       mov       rdx,1D5D3C82D20
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+158]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/135b08b2-51b4-44d8-b21d-052f7ed569c5-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/538385ed-15aa-40a7-a353-3a5294679560-diff.temp
index 91adbb3..8df998b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/538385ed-15aa-40a7-a353-3a5294679560-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/135b08b2-51b4-44d8-b21d-052f7ed569c5-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4579e624-85f5-4109-8355-0e618cec070f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6f9896bd-455c-4168-96f5-961c2a730660-diff.temp
index b98a473..b435641 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/6f9896bd-455c-4168-96f5-961c2a730660-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/4579e624-85f5-4109-8355-0e618cec070f-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF85D6506E0]
+       mov       r11,7FF85D2706E0
-       call      qword ptr [7FF85D6406E0]
-       mov       r11,7FF85D2606E0
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
+       mov       rdx,15236AB2D20
-       mov       rdx,125EC432D20
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+158]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ecd6e8df-1fe2-46c1-9b96-644e3fb668fe-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7477689b-31ce-4d73-8360-49d08a5cf1eb-diff.temp
index b98a473..18af881 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7477689b-31ce-4d73-8360-49d08a5cf1eb-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/ecd6e8df-1fe2-46c1-9b96-644e3fb668fe-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1cb1cbcc-d50d-48f1-b264-342afbf6d05f-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2faa85a2-9f50-4d41-a3cb-2d253320c85a-diff.temp
index b98a473..118b8e7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/2faa85a2-9f50-4d41-a3cb-2d253320c85a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/1cb1cbcc-d50d-48f1-b264-342afbf6d05f-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF85D6206E8]
+       mov       r11,7FF85D2406E8
-       call      qword ptr [7FF85D6406E0]
-       mov       r11,7FF85D2606E0
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
+       mov       rdx,1B052792D20
-       mov       rdx,125EC432D20
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+158]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/20395feb-73ec-48eb-b5d8-33f533b0f779-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/00899a3b-7371-4c95-8494-4b444d1780d4-diff.temp
index b98a473..8df998b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/00899a3b-7371-4c95-8494-4b444d1780d4-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/20395feb-73ec-48eb-b5d8-33f533b0f779-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF85D6506E0]
+       mov       r11,7FF85D2706E0
-       call      qword ptr [7FF85D6406E0]
-       mov       r11,7FF85D2606E0
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
+       mov       rdx,15236AB2D20
-       mov       rdx,22359192D20
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+158]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9592aa2d-47e0-4c43-8764-9bd823a8d19e-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/aea5fdce-02db-4a28-a40c-e81498280206-diff.temp
index b435641..18af881 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/aea5fdce-02db-4a28-a40c-e81498280206-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/9592aa2d-47e0-4c43-8764-9bd823a8d19e-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/97b0cd81-0853-4b82-a8af-ed925abfc796-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/06767abf-69e4-4f6a-9412-97db36018305-diff.temp
index b435641..118b8e7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/06767abf-69e4-4f6a-9412-97db36018305-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/97b0cd81-0853-4b82-a8af-ed925abfc796-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF85D6206E8]
+       mov       r11,7FF85D2406E8
-       call      qword ptr [7FF85D6406E0]
-       mov       r11,7FF85D2606E0
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
+       mov       rdx,1B052792D20
-       mov       rdx,22359192D20
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+158]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f6961d51-8433-464b-9e1b-33a268905649-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7e8dd722-f608-4308-8f16-ce44e5c04b01-diff.temp
index b435641..8df998b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/7e8dd722-f608-4308-8f16-ce44e5c04b01-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f6961d51-8433-464b-9e1b-33a268905649-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF85D6406E0]
+       mov       r11,7FF85D2606E0
-       call      qword ptr [7FF85D6506E0]
-       mov       r11,7FF85D2706E0
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
+       mov       rdx,196DEC02D20
-       mov       rdx,15236AB2D20
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+158]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f5d59d97-50d8-49d6-9eec-32d72b1d41e3-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8e70b59b-fea5-48db-be81-77f8921bf8a9-diff.temp
index 18af881..118b8e7 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/8e70b59b-fea5-48db-be81-77f8921bf8a9-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/f5d59d97-50d8-49d6-9eec-32d72b1d41e3-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF85D6206E8]
+       mov       r11,7FF85D2406E8
-       call      qword ptr [7FF85D6506E0]
-       mov       r11,7FF85D2706E0
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
+       mov       rdx,1B052792D20
-       mov       rdx,15236AB2D20
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+158]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/53d1c514-aea9-4f55-afb7-e7f8d0a098f4-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d1d527f2-697e-466f-a8d9-64317c3a5c4a-diff.temp
index 18af881..8df998b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/d1d527f2-697e-466f-a8d9-64317c3a5c4a-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/53d1c514-aea9-4f55-afb7-e7f8d0a098f4-diff.temp
```
**Diff for CollectionCreate01 method between:**
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
.NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```diff
M01_L00:
        mov       [rsi+18],rax
        xor       eax,eax
+       call      qword ptr [7FF85D6206E8]
+       mov       r11,7FF85D2406E8
-       call      qword ptr [7FF85D6406E0]
-       mov       r11,7FF85D2606E0
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
+       mov       rdx,1B052792D20
-       mov       rdx,196DEC02D20
        mov       r14,rax
        call      CORINFO_HELP_NEWSFAST
        mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rbx,rax
        call      CORINFO_HELP_NEWFAST
        mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
        mov       rdi,[rsi+158]
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
+++ b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0967556a-8bf7-4c41-a25b-21668770df61-diff.temp
--- a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/01c68740-0552-4a0d-952b-0dde6fc37891-diff.temp
index 118b8e7..8df998b 100644
diff --git a/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/01c68740-0552-4a0d-952b-0dde6fc37891-diff.temp b/C:/src/GitHub/dotNetTips.Spargine/source/5/Benchmarking/OutputBin/net5.0/BenchmarkDotNet.Artifacts/results/0967556a-8bf7-4c41-a25b-21668770df61-diff.temp
```
